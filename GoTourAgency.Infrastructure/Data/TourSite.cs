using System.ComponentModel.DataAnnotations.Schema;

namespace GoTourAgency.Infrastructure.Data
{
    public class TourSite
    {
        public int TourId { get; set; }
        [ForeignKey(nameof(TourId))]
        public virtual Tour Tour { get; set; } = null!;

        public int SiteId { get; set; }
        [ForeignKey(nameof(SiteId))]
        public virtual Site Site { get; set; } = null!;
    }
}
