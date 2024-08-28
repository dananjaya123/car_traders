using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Model
{
    public class Car
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Car_brand { get; set; }
        public string Color { get; set; }
        public string Manufacturing_year { get; set; }
        public string Model_name { get; set; }
        public int Mileage { get; set; }
        public string Fuel_type { get; set; }
        public string Transmission { get; set; }
        public string Body_type { get; set; }
        public byte[]? Image_data { get; set; }
        public string? Seller_name { get; set; }
        public string? Seller_address { get; set; }
        public string? Mobile_number { get; set; }
        public string Selling_type { get; set; }
        public double Price { get; set; }
        public string? Description { get; set; }

        public string Status { get; set; } = "AVAILABLE"; //available,soldout
        public bool Is_active { get; set; }


    }
}
