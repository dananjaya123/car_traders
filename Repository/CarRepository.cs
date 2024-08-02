using car_traders.Dta;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Repository
{
    public class CarRepository
    {
        
        public int GetCarCount()
        {
            using (var dbContext = new ApplicationDBContext())
            {
                // Using a native SQL query to get the count of cars
                var count = dbContext.Database.ExecuteSqlRaw("SELECT COUNT(*) FROM car_traders.car");
                return count;
            }
           
        }
    }
}
