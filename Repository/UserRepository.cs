using car_traders.Dta;
using car_traders.Model;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Repository
{
    internal class UserRepository
    {
        public int getUserCount()
        {
            using (var dbContext = new ApplicationDBContext())
            {
                return dbContext.user.Count();

            }
        }

        public Boolean updateUserDetail(Model.User user)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                dbContext.user.Update(user);
                dbContext.SaveChanges();
                return true;
            }
        }

        public Boolean saveUser(Model.User user)
        {
            using(var dbContext = new ApplicationDBContext())
            {
                dbContext.user.Add(user);
                dbContext.SaveChanges();
                return true;
            }
        }
        public int GetCusotmerCount()
        {
            using (var dbContext = new ApplicationDBContext())
            {

                // Using a native SQL query to get the count of active car parts
                var count = dbContext.user
                                     .Where(cp => cp.Is_active && cp.Role_name == "CUSTOMER")
                                     .Count();
                return count;


            }

        }

        public bool IsUserNameOrEmailExists(string username, string email)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                return dbContext.user.Any(u => u.User_name == username || u.Email == email);
            }
        }

        public Model.User Login(string username, string password)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                return dbContext.user.FirstOrDefault(u => u.User_name == username && u.Password == password && u.Is_active);
            }
        }

        public Model.User getEqualEmail(string searchVlues)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                
                var user = dbContext.user
                                    .Where(u => u.User_name==searchVlues|| u.Email==searchVlues)
                                    .FirstOrDefault(); 
                return user;
            }
        }
        public Model.User getUserByUsercode(string userCode)
        {
            using (var dbContext = new ApplicationDBContext())
            {

                var user = dbContext.user
                                    .Where(u => u.User_code == userCode)
                                    .FirstOrDefault();
                return user;
            }
        }

    }
}
