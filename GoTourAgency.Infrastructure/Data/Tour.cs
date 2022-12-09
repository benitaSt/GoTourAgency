using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoTourAgency.Infrastructure.Data
{
    public class Tour
    {
        public Tour()
        {
            TourSites = new List<TourSite>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(Common.ValidationConstants.tourNameMaxLength)]
        public string Name { get; set; } = null!;

        [Required]
        [StringLength(Common.ValidationConstants.tourDescriptionMaxLength)]
        public string Description { get; set; } = null!;

        [Required]
        public int RegionId { get; set; }
        [ForeignKey(nameof(RegionId))]
        public virtual Region Region { get; set; } = null!;

        [Required]
        public int AgentId { get; set; }
        [ForeignKey(nameof(AgentId))]
        public virtual Agent Agent { get; set; } = null!;

        public virtual List<TourSite> TourSites { get; set; }
    }
}
