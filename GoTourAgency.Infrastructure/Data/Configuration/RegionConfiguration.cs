using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoTourAgency.Infrastructure.Data.Configuration
{
    internal class RegionConfiguration : IEntityTypeConfiguration<Region>
    {
        public void Configure(EntityTypeBuilder<Region> builder)
        {
            builder.HasData(CreateRegions());
        }

        private List<Region> CreateRegions()
        {
            List<Region> regions = new List<Region>()
            {
                new Region()
                {
                    Id = 1,
                    Name = "North"
                },

                new Region()
                {
                    Id = 2,
                    Name = "Soutwest"
                },

                new Region()
                {
                    Id = 3,
                    Name = "Southeast"
                }

             };

            return regions;
        }
    }
}
