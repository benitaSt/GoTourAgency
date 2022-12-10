using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoTourAgency.Infrastructure.Data
{
    public class Photo
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string ImageUrl { get; set; } = null!;

        public string? Description { get; set; }

        [Required]
        public int SightId { get; set; }
        [ForeignKey(nameof(SightId))]
        public virtual Sight Sight { get; set; } = null!;
    }
}
