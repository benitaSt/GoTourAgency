using System.ComponentModel.DataAnnotations.Schema;

namespace GoTourAgency.Infrastructure.Data
{
    public class TourSight
    {
        public int TourId { get; set; }
        [ForeignKey(nameof(TourId))]
        public virtual Tour Tour { get; set; } = null!;

        public int SightId { get; set; }
        [ForeignKey(nameof(SightId))]
        public virtual Sight Sight { get; set; } = null!;
    }
}
