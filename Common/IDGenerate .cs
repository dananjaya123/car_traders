using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace car_traders.Common
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
    }
}
