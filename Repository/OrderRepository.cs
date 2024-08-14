using car_traders.Dta;
using car_traders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Repository
{
    internal class OrderRepository
    {
        public Boolean plaseOrder(Order order)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                dbContext.order.Add(order);
                dbContext.SaveChanges();
                return true;
            }
        }

        public int OrderCount()
        {
            using (var dbContext = new ApplicationDBContext())
            {
                int count = dbContext.order.Count(); // Get the count of orders
                return count; // Return the count
            }
        }

        public List<Order> getAllOrdersByUser(string userCode)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var order = dbContext.order.Where(od => od.Is_active == true && od.User_code == userCode).ToList();
                return order;
            }
        }

        public Order getOrderByOrderCode(string orderCode)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var order = dbContext.order.FirstOrDefault(cp => cp.Order_code == orderCode);
                return order;
            }
        }
    }
}
