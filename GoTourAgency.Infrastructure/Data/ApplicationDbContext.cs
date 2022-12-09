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
                .Entity<UserSite>()
                .HasKey(us => new { us.UserId, us.SiteId });

            builder
                .Entity<TourSite>()
                .HasKey(ts => new { ts.TourId, ts.SiteId });

            base.OnModelCreating(builder);
        }

        public DbSet<Site> Sites { get; set; } = null!;

        public DbSet<Region> Regions { get; set; } = null!;

        public DbSet<Category> Categories { get; set; } = null!;

        public DbSet<Photo> Photoes { get; set; } = null!;

        public DbSet<UserSite> UsersSites { get; set; } = null!;

        public DbSet<TourSite> ToursSites { get; set; } = null!;

        public DbSet<Tour> Tours { get; set; } = null!;

        public DbSet<Agent> Agents { get; set; } = null!;

    }
}
