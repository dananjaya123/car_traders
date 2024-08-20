using car_traders.Dta;
using car_traders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Service
{
    internal class OrderService
    {
        public int GetActiveOrderCount()
        {
            using (var dbContext = new ApplicationDBContext())
            {

                var count = dbContext.order
                                     .Where(cp => cp.Is_active)
                                     .Count();
                return count;


            }

        }

        public double GetPaidOrderAmount()
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var sum = dbContext.order
                                   .Where(order => order.Is_active && order.status.Equals("PAID"))
                                   .Sum(order => order.Total_amount);

                return sum;
            }
        }
        public bool plaseOrder(Order order)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                dbContext.order.Add(order);
                dbContext.SaveChanges();
                return true;
            }
        }

        public List<Order> getCustomerOrderByNameOrOrderCode(string userCOde, string searchVal)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var orders = dbContext.order.Where(cp => cp.User_code.Contains(userCOde)
                && cp.Is_active && cp.Order_code.Contains(searchVal) || cp.status.Contains(searchVal)
                ).ToList();
                return orders;
            }
        }
        public List<Order> getCustomerOrderByOrderCodeAndStatu(string status, string searchVal)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var orders = dbContext.order.Where(cp => cp.Is_active && cp.Order_code.Contains(searchVal) && cp.status.Contains(status)
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
        public List<Order> getAllOrdersByStatus(string status)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var order = dbContext.order.Where(od => od.status == status).ToList();
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
        public bool updateOrder(Order order)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                dbContext.order.Update(order);
                dbContext.SaveChanges();
                return true;
            }
        }

        public List<Order> getCustomerByOrders(string userCode, string searchVal)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var orders = (from order in dbContext.order
                              join user in dbContext.user on order.User_code equals user.User_code
                              where order.User_code.Contains(userCode)
                                    && order.Is_active
                                    && (order.Order_code.Contains(searchVal) || order.status.Contains(searchVal))
                              select order).ToList();

                return orders;
            }
        }
    }
}
