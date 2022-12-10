using GoTourAgency.Infrastructure.Data.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GoTourAgency.Infrastructure.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder
                .Entity<UserSight>()
                .HasKey(us => new { us.UserId, us.SightId });

            builder
                .Entity<TourSight>()
                .HasKey(ts => new { ts.TourId, ts.SightId });

            builder.ApplyConfiguration(new UserConfiguration());
            builder.ApplyConfiguration(new AgentConfiguration());
            builder.ApplyConfiguration(new CategoryConfiguration());
            builder.ApplyConfiguration(new RegionConfiguration());
            builder.ApplyConfiguration(new PhotoConfiguration());
            builder.ApplyConfiguration(new SightConfiguration());

            base.OnModelCreating(builder);
        }

        public DbSet<Sight> Sights { get; set; } = null!;

        public DbSet<Region> Regions { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Photo> Photos { get; set; } = null!;

        public DbSet<UserSight> UsersSites { get; set; } = null!;

        public DbSet<TourSight> ToursSites { get; set; } = null!;

        public DbSet<Tour> Tours { get; set; } = null!;

        public DbSet<Agent> Agents { get; set; } = null!;

    }
}
