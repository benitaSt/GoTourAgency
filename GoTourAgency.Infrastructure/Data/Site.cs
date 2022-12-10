using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoTourAgency.Infrastructure.Data
{
    public class Site
    {
        public Site()
        {
            Photos = new List<Photo>();
            SiteTours = new List<TourSite>();
            SavedBy = new List<UserSite>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(Common.ValidationConstants.siteNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(Common.ValidationConstants.siteDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public int RegionId { get; set; }
        [ForeignKey(nameof(RegionId))]
        public virtual Region Region { get; set; } = null!;

        [Required]
        public int CategoryId { get; set; }
        [ForeignKey(nameof(CategoryId))]
        public virtual Category Category { get; set; } = null!;

        public virtual List<Photo> Photos { get; set; }

        public virtual List<TourSite> SiteTours { get; set; }

        public virtual List<UserSite> SavedBy { get; set; }
    }
}
