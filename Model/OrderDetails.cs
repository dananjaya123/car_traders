using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Model
{
    public class OrderDetails
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }
        public string Item_name { get; set; }

        public Guid Item_Id { get; set; }
        public string Item_type { get; set; } //car,part
        public double Total_price { get; set; } = 0.0;
        public int Qty { get; set; } = 0;

        public string Order_code { get; set; }

        public bool Is_active { get; set; } = true;




    }
}
