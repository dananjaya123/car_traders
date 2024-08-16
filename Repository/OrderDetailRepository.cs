using car_traders.Dta;
using car_traders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Repository
{
    internal class OrderDetailRepository
    {
        public Boolean saveOrderDetail(OrderDetails details)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                dbContext.orderDetails.Add(details);
                dbContext.SaveChanges();
                return true;
            }
        }
        public OrderDetails getOrderByOrderCode(string orderCode)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var detail = dbContext.orderDetails.FirstOrDefault(cp => cp.Order_code == orderCode);
                return detail;
            }
        }
        public Boolean updateOrderDetail(OrderDetails detail)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                dbContext.orderDetails.Update(detail);
                dbContext.SaveChanges();
                return true;
            }
        }
    }
}
