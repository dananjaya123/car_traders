using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Model
{
    internal class Car
    {
        public int Id { get; set; }
        public string Car_brand { get; set; }
        public string Color { get; set; }
        public string Manufacturing_year { get; set; }
        public string Model_name { get; set; }
        public int Mileage { get; set; }
        public string Fuel_type { get; set; }
        public string Transmission { get; set; }
        public string Body_type { get; set; }
        public string Image_url { get; set; }
        public string Seller_name { get; set; }
        public string Seller_address { get; set; }
        public string Mobile_number { get; set; }
        public double Price { get; set; }
        public string Description { get; set; }
        public bool Is_active { get; set; }


    }
}
