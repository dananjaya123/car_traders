using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Model
{
    public class CarPart
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Parts_name { get; set; }
        public string? Description { get; set; }
        public double Price { get; set; } = 0.0;
        public int Qty { get; set; } = 0;
        public string Category { get; set; }
        public string Car_model{ get; set; }
        public string Brand_name { get; set; }
        public byte[]? Image_data { get; set; }
        public string Status { get; set; } = "available"; //available,soldout
        public bool Is_active { get; set; } = true;
    }
}
