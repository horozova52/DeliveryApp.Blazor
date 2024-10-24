namespace DeliveryApp.Shared
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime OrderDate { get; set; }
        public int StatusId { get; set; }
        public Status? Status { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public int AddressId { get; set; }
        public Address? Address { get; set; }
    }
}
