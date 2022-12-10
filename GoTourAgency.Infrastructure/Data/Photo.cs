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
        public int SiteId { get; set; }
        [ForeignKey(nameof(SiteId))]
        public virtual Site Site { get; set; } = null!;
    }
}
