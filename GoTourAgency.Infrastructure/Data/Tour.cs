using GoTourAgency.Infrastructure.Enums;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoTourAgency.Infrastructure.Data
{
    public class Tour
    {
        public Tour()
        {
            TourSights = new List<TourSight>();
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
        public DateTime StartDateAndTime { get; set; }

        [Required]
        public DateTime EndDateAndTime { get; set; }

        [Required]
        public MeetingLocation MeetingLocation { get; set; }

        [Required]
        [Column(TypeName = "money")]
        [Precision(18, 2)]
        public decimal Price { get; set; } 

        [Required]
        public int RegionId { get; set; }
        [ForeignKey(nameof(RegionId))]
        public virtual Region Region { get; set; } = null!;

        [Required]
        public int AgentId { get; set; }
        [ForeignKey(nameof(AgentId))]
        public virtual Agent Agent { get; set; } = null!;

        public virtual List<TourSight> TourSights { get; set; }
    }
}
