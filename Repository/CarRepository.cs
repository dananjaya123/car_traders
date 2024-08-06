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

        public Boolean saveCar(Car car)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                dbContext.car.Add(car);
                dbContext.SaveChanges();
                return true;
            }
        }

        public Boolean updateCar(Car car)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                dbContext.car.Update(car);
                dbContext.SaveChanges();
                return true;
            }
        }

        public Car getCarById(Guid id)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var car = dbContext.car.FirstOrDefault(cp => cp.Id == id);
                return car;
            }
        }
        public List<Car> getAllCarList()
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var cars =dbContext.car.Where(cr=> cr.Is_active==true).ToList();
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


        public List<Car> getAllCarListByModelName(string searchVal)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var cars = dbContext.car
                                    .Where(cp => cp.Model_name.Contains(searchVal)
                                    ||cp.Car_brand.Contains(searchVal)
                                    ||cp.Color.Contains(searchVal)
                                    ||cp.Body_type.Contains(searchVal)
                                    ||cp.Seller_name.Contains(searchVal)
                                    ||cp.Status.Contains(searchVal)
                                    )
                                    .ToList();
                return cars;
            }
        }

    }
}
