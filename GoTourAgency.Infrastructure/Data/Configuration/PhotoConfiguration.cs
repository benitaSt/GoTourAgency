using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace GoTourAgency.Infrastructure.Data.Configuration
{
    internal class PhotoConfiguration : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder.HasData(CreatePhotos());
        }

        private List<Photo> CreatePhotos()
        {
            List<Photo> photos = new List<Photo>()
            {
                new Photo()
                {
                    Id = 1,
                    ImageUrl = "https://bulgariatravel.org/wp-content/uploads/2016/076_003_Chudnite_mostove.jpg_7362.jpg",
                    SightId = 1
                },

                new Photo()
                {
                    Id = 2,
                    ImageUrl = "http://1.bp.blogspot.com/-qWh0RQrN-Sw/VbVyDm_A5RI/AAAAAAAAEqQ/J2tEfZ266eY/s1600/Mighty%2Bpillars%2Bwith%2Bthe%2BFertility%2Bstone%2Bin%2Bthe%2Bmiddle%252C%2BThe%2BStone%2BForest%252C%2BVarna%252C%2BBulgaria.jpg",
                    SightId = 2
                },

                new Photo()
                {
                    Id = 3,
                    ImageUrl = "https://www.descopera.ro/wp-content/uploads/2016/09/15716132/1-wikimedia.jpg",
                    SightId = 2
                }

             };

            return photos;
        }
    }
}
