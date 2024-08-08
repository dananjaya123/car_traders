using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Model
{
    internal class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public DateTime Created { get; set; }= DateTime.Now;
        public double Total_amount { get; set; } = 0.0;
        public string status { get; set; }
        public int qty { get; set; }
        public bool Is_payment { get; set; } = false;
        public string User_code { get; set; }
        public string Order_code { get; set; }
        public bool Is_active { get; set; } = true;


    }
}
