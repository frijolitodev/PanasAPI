using Domain.Attendants;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class AttendantConfiguration : IEntityTypeConfiguration<Attendant>
    {
        public void Configure(EntityTypeBuilder<Attendant> builder)
        {
            builder.Property(e => e.FullName)
                .IsRequired();

            builder.Property(e => e.Email)
                .IsRequired();
        }
    }
}