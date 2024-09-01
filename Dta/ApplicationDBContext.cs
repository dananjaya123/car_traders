using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using car_traders.Model;
using System.Configuration;
using MySqlX.XDevAPI;

namespace car_traders.Dta
{
    internal class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder(); 
            // Set the base path to the current directory where the application is running
            builder.SetBasePath(Directory.GetCurrentDirectory());
            // Add the appsettings.json file to the configuration builder to read configuration settings
            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            // Build the configuration to access its contents
            var configuration = builder.Build();
            // Configure the DbContext to use MySQL with the connection string named "DefaultConnection"
            optionsBuilder.UseMySql(configuration.GetConnectionString("DefaultConnection"),
            //Auto - detect the MySQL server version from the connection string for compatibility
            new MySqlServerVersion(ServerVersion.AutoDetect(configuration.GetConnectionString("DefaultConnection")))); //  MySQL version here

        }

        public DbSet<Car> car { get; set; }
        public DbSet<CarPart> car_parts { get; set; }
        public DbSet<User> user { get; set; }
        public DbSet<Role>role { get; set; }
        public DbSet<Order> order { get; set; }
        public DbSet<OrderDetails> orderDetails { get; set; }
    }
}
