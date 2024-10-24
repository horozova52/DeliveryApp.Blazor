namespace DeliveryApp.Shared
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string PhoneNumber { get; set; } = string.Empty;
        public List<Order> Orders { get; set; } = new List<Order>();

        public List<Address> Addresses { get; set; } = new List<Address>();
    }
}
