using System;

namespace DeliveryApp.Shared
{
    public class Order
    {
        public int Id { get; set; }
        public string Sender { get; set; }
        public string Recipient { get; set; }
        public string PackageDetails { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Status { get; set; }
    }
}
