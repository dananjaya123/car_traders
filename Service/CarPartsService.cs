using car_traders.Dta;
using car_traders.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Service
{
    public class CarPartsService
    {
        public bool saveCarPart(CarPart carPart)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                dbContext.car_parts.Add(carPart);
                dbContext.SaveChanges();
                return true;
            }
        }

        public bool updateCarPart(CarPart carPart)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                dbContext.car_parts.Update(carPart);
                dbContext.SaveChanges();
                return true;
            }
        }

        public CarPart getCarPartById(Guid id)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var carPart = dbContext.car_parts.FirstOrDefault(cp => cp.Id == id);
                return carPart;
            }
        }

        public List<CarPart> getAllCarPartList()
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var cars = dbContext.car_parts.Where(cp => cp.Is_active == true).ToList();
                return cars;
            }
        }
        public List<CarPart> getCarPartsByPartName(string searchVal)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var carsParts = dbContext.car_parts.Where(cp => cp.Parts_name.Contains(searchVal)
                || cp.Car_model.Contains(searchVal)
                || cp.Status.Contains(searchVal)
                || cp.Category.Contains(searchVal)
                ).ToList();
                return carsParts;
            }
        }

        public int getActiveCarPartsCaount()
        {
            using (var dbContext = new ApplicationDBContext())
            {
                // Using a native SQL query to get the count of active car parts
                var count = dbContext.car_parts
                                     .Where(cp => cp.Is_active)
                                     .Count();
                return count;
            }
        }

        public bool UpdatePartsStatusAndQty(Guid id, string status, bool isActive, int qty)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var part = dbContext.car_parts.FirstOrDefault(c => c.Id == id);

                if (part != null)
                {
                    part.Status = status;
                    part.Is_active = isActive;
                    part.Qty = part.Qty + qty;


                    dbContext.SaveChanges();
                    return true;
                }

                return false;
            }
        }
    }
}
