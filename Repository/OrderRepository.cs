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

        public List<Order> getCustomerOrderByNameOrOrderCode(string userCOde,string searchVal)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var orders = dbContext.order.Where(cp => cp.User_code.Contains(userCOde)
                && cp.Is_active && cp.Order_code.Contains(searchVal) || cp.status.Contains(searchVal)
                ).ToList();
                return orders;
            }
        }

        public int OrderCount()
        {
            using (var dbContext = new ApplicationDBContext())
            {
                int count = dbContext.order.Count();
                return count; 
            }
        }

        public List<Order> getAllActiveOrdersByUser(string userCode)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var order = dbContext.order.Where(od => od.Is_active == true && od.User_code == userCode).ToList();
                return order;
            }
        }

        public List<Order> getAllOrdersByUser(string userCode)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var order = dbContext.order.Where(od => od.User_code == userCode).ToList();
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
        public Boolean updateOrder(Order order)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                dbContext.order.Update(order);
                dbContext.SaveChanges();
                return true;
            }
        }
    }
}
