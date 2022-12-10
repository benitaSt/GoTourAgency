using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace GoTourAgency.Infrastructure.Data
{
    public class UserSight
    {
        public string UserId { get; set; } = null!;
        [ForeignKey(nameof(UserId))]
        public virtual ApplicationUser User { get; set; } = null!;

        public int SightId { get; set; }
        [ForeignKey(nameof(SightId))]
        public virtual Sight Sight { get; set; } = null!;

        public bool InWishes { get; set; } = false;

        public bool Visited { get; set; } = false;

        public bool Favourite { get; set; } = false;
    }
}
