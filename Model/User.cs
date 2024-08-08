using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Model
{
    public class User
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; } 
        public string User_code {  get; set; }
        public string Name { get; set; }
        public string Contact_num { get; set; } 
        public string Email { get; set; } 
        public string Address { get; set; }
        public string Password { get; set; }
        public string User_name { get; set; }
        public bool Is_active { get; set; } = true;
        public string Role_name { get; set; }

    }
}
