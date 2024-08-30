using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Extensions.Configuration;
using Microsoft.EntityFrameworkCore;
using car_traders.Model;
using System.Configuration;

namespace car_traders.Dta
{
    internal class ApplicationDBContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var builder = new ConfigurationBuilder(); // nuget pakage extenstion.configaration use
            builder.SetBasePath(Directory.GetCurrentDirectory()); // user nuget pakage configaraion .json
            builder.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true); // get json file conection string
            var configuration = builder.Build();
            optionsBuilder.UseMySql(configuration.GetConnectionString("DefaultConnection"),
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
