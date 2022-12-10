using System.ComponentModel.DataAnnotations;

namespace GoTourAgency.Infrastructure.Data
{
    public class Region
    {
        public Region()
        {
            Sights = new List<Sight>();
            Tours = new List<Tour>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(Common.ValidationConstants.regionNameMaxLength)]
        public string Name { get; set; } = null!;

        public virtual List<Sight> Sights { get; set; }

        public virtual List<Tour> Tours { get; set; }
    }
}
