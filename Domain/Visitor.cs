using System; 

namespace Domains
{
    public partial class Visitor : BaseEntity
    {
        public string IpAddress { get; set; }
        public DateTime? DateEntered { get; set; }
        public DateTime? LastEnteredDate { get; set; }
    }
}
