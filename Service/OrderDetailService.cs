using car_traders.Dta;
using car_traders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Service
{
    internal class OrderDetailService
    {
        public bool saveOrderDetail(OrderDetails details)
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
        public List<OrderDetails> getOrderDetailListByOrderCode(string orderCode)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var detailsList = dbContext.orderDetails
                                           .Where(od => od.Order_code == orderCode)
                                           .ToList();
                return detailsList;
            }
        }

        public OrderDetails getOrderDetailByDetailID(Guid id)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var detailData = dbContext.orderDetails.FirstOrDefault(od => od.Id.Equals(id));
                                           
                return detailData;
            }
        }
        public bool updateOrderDetail(OrderDetails detail)
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
