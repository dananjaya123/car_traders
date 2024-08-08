using car_traders.Dta;
using car_traders.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Repository
{
    internal class RoleRepository
    {
        public Role getRoleByName(string roleName)
        {
            using (var dbContext = new ApplicationDBContext())
            {
                var role = dbContext.role.FirstOrDefault(rl => rl.Is_active && rl.Role_name == roleName);
                return role;


            }

        }
       
    }
}
