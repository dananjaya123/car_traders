using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Model
{
    internal class CarPart
    {
        public int Id { get; set; }
        public string Pats_name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public int Qty { get; set; }
        public string Category { get; set; }
        public string CarModel { get; set; }
        public string Brand_name { get; set; }
        public string Image_url {  get; set; }
    }
}
