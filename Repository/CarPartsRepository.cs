using car_traders.Dta;
using car_traders.Model;
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

        public List<CarPart> getAllCarPartList()
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var cars = dbContext.car_parts.ToList();
                return cars;
            }
        }
        public List<CarPart> getCarPartsByPartName(string partName)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var carsParts = dbContext.car_parts.Where(cp => cp.Parts_name.Contains(partName)).ToList();
                return carsParts;
            }
        }

        public int getActiveCarPartsCaount() {
            using (var dbContext = new ApplicationDBContext())
            {
                // Using a native SQL query to get the count of active car parts
                var count = dbContext.car_parts
                                     .Where(cp => cp.Is_active)
                                     .Count();
                return count;
            }
        }
    }
}
