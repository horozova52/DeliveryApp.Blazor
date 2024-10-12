using Microsoft.EntityFrameworkCore;
using System.Net;
using DeliveryApp.Shared;

namespace DeliveryApp.Server.Data
{
    public class CourierAppContext : DbContext
    {
        public CourierAppContext(DbContextOptions<CourierAppContext> options) : base(options) { }

        public DbSet<User> Users { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Address> Addresses { get; set; }
    }
}
