using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Highsay.OrderManagement.Dal
{
    public class Order
    {
        public int Id { get; set; }
        public string TrackingId { get; set; }
        public string Name { get; set; }
        public string  StreetAddress { get; set; }
        public string City { get; set; }

        public string State { get; set; }
        public string ZipCode { get; set; }

      
        [ForeignKey("User")]
        public int UserId { get; set; }

        public virtual User User { get; set; }

    }
}