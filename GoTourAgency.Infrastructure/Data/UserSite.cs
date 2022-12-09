using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoTourAgency.Infrastructure.Data
{
    public class UserSite
    {
        public string UserId { get; set; } = null!;
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        public int SiteId { get; set; }
        [ForeignKey(nameof(SiteId))]
        public virtual Site Site { get; set; } = null!;

        public bool InWishes { get; set; } = false;

        public bool Visited { get; set; } = false;

        public bool Favourite { get; set; } = false;

        [StringLength(Common.ValidationConstants.reviewMaxLength)]
        public string? Review { get; set; }
    }
}
