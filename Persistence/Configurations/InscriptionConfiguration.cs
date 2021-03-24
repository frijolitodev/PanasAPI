using Domain.Inscriptions;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.Configurations
{
    public class InscriptionConfiguration : IEntityTypeConfiguration<Inscription>
    {
        public void Configure(EntityTypeBuilder<Inscription> builder)
        {
            builder.HasKey(e => new { e.PresentationId, e.AttendantId });

            builder.HasOne(e => e.Attendant)
                .WithMany(att => att.Inscriptions);

            builder.HasOne(e => e.Presentation)
                .WithMany(pres => pres.Inscriptions);
        }
    }
}