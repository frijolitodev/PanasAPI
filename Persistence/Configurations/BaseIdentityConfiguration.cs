using Domain.Attendants;
using Domain.BaseIdentities;
using Domain.Speakers;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Persistence.Configurations
{
    public class BaseIdentityConfiguration : IEntityTypeConfiguration<BaseIdentity>
    {
        public void Configure(EntityTypeBuilder<BaseIdentity> builder)
        {
            builder.HasKey(e => e.Id);
            builder.Property(e => e.Id)
                .ValueGeneratedOnAdd();
            
            builder.HasIndex(e => e.Email);

            builder.Property(e => e.Identity)
                .HasConversion(new EnumToStringConverter<IdentityRole>());

            builder.HasDiscriminator(i => i.Identity)
                .HasValue<Attendant>(IdentityRole.Attendant)
                .HasValue<Speaker>(IdentityRole.Speaker);
        }
    }
}