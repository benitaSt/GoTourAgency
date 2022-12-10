using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoTourAgency.Infrastructure.Data.Configuration
{
    internal class SightConfiguration : IEntityTypeConfiguration<Sight>
    {
        public void Configure(EntityTypeBuilder<Sight> builder)
        {
            builder.HasData(CreateSights());
        }

        private List<Sight> CreateSights()
        {
            List<Sight> sights = new List<Sight>()
            {
                new Sight()
                {
                    Id = 1,
                    Name = "Chudni mostove",
                    RegionId = 3,
                    CategoryId = 3
                },

                new Sight()
                {
                    Id = 2,
                    Name = "Pobiti kamani",
                    RegionId = 3,
                    CategoryId = 3
                }
             };

            return sights;
        }
    }
}
