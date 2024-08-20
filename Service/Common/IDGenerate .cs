using car_traders.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Service.Common
{
    internal class IDGenerate
    {
        public string IdGenerate()
        {
            Random random = new Random();
            string id = string.Empty;

            // Generate 6 random numbers
            for (int i = 0; i < 6; i++)
            {
                int randomNumber = random.Next(1, 10); // Generates a number between 1 and 9
                id += randomNumber.ToString();
            }

            return id;
        }

        public string OrderCodeGenerate()
        {
            OrderService repository = new OrderService();
            int orderCount = repository.OrderCount(); // Get the current order count

            // Increment the order count for the new order
            int newOrderNumber = orderCount + 1;

            // Format the new order number as "OR" followed by a 4-digit number, with leading zeros
            string orderCode = $"OR{newOrderNumber.ToString("D4")}";

            return orderCode;
        }


    }
}
