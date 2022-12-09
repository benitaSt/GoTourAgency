using System.ComponentModel.DataAnnotations;

namespace GoTourAgency.Infrastructure.Data
{
    public class Category
    {
        public Category()
        {
            Sites = new List<Site>();
        }

        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(Common.ValidationConstants.categoryNameMaxLength)]        
        public string Name { get; set; } = null!;

        public virtual List<Site> Sites { get; set; }
    }
}
