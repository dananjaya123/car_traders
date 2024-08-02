using car_traders.Dta;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Repository
{
    public class CarPartsRepository
    {
        public int getActiveCarPartsCaount() {
            using (var dbContext = new ApplicationDBContext())
            {
                // Using a native SQL query to get the count of cars
                var count = dbContext.Database.ExecuteSqlRaw("SELECT COUNT(*) FROM car_traders.car_parts  where Is_active =1 ");
                return count;
            }
        }
    }
}
