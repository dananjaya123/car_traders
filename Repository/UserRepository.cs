using car_traders.Dta;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Repository
{
    internal class UserRepository
    {
        public int GetCusotmerCount()
        {
            using (var dbContext = new ApplicationDBContext())
            {

                // Using a native SQL query to get the count of active car parts
                var count = dbContext.user
                                     .Where(cp => cp.Is_active && cp.Role.Role_name == "customer")
                                     .Count();
                return count;


            }

        }
    }
}
