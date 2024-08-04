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
    public class CarRepository
    {

        public List<Car> getAllCarList()
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var cars =dbContext.car.ToList();
                return cars;
            }
        }

        public int GetCarCount()
        {
            using (var dbContext = new ApplicationDBContext())
            {

                // Using a native SQL query to get the count of active car parts
                var count = dbContext.car
                                     .Where(cp => cp.Is_active && cp.Status == "available")
                                     .Count();
                return count;

            }
        }


        public List<Car> getAllCarListByModelName(string modelName)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var cars = dbContext.car
                                    .Where(cp => cp.Model_name.Contains(modelName))
                                    .ToList();
                return cars;
            }
        }

    }
}
