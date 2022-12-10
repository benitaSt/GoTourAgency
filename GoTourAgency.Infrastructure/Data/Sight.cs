using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoTourAgency.Infrastructure.Data
{
    public class Sight
    {
        public Sight()
        {
            Photos = new List<Photo>();
            SightTours = new List<TourSight>();
            SavedBy = new List<UserSight>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(Common.ValidationConstants.sightNameMaxLength)]
        public string Name { get; set; } = null!;

        [StringLength(Common.ValidationConstants.sightDescriptionMaxLength)]
        public string? Description { get; set; }

        [Required]
        public int RegionId { get; set; }
        [ForeignKey(nameof(RegionId))]
        public virtual Region Region { get; set; } = null!;

        [Required]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; } = null!;

        public virtual List<Photo> Photos { get; set; }

        public virtual List<TourSight> SightTours { get; set; }

        public virtual List<UserSight> SavedBy { get; set; }
    }
}
