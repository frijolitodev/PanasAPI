using Domain.Attendants;
using Domain.BaseIdentities;
using Domain.Inscriptions;
using Domain.Presentations;
using Domain.Speakers;
using Infrastructure;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class PanasDbContext : DbContext, IPanasDbContext
    {
        public DbSet<BaseIdentity> BaseIdentities { get; set; }
        
        public DbSet<Speaker> Speakers { get; set; }
        
        public DbSet<Attendant> Attendants { get; set; }
        
        public DbSet<Inscription> Inscriptions { get; set; }
        
        public DbSet<Presentation> Presentations { get; set; }
        
        public PanasDbContext(DbContextOptions<PanasDbContext> options) : base(options) {}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(PanasDbContext).Assembly);
        }
    }
}