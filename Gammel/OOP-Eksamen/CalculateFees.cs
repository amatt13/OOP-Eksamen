using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Eksamen
{
    class CalculateFees
    {
        public decimal Fees(decimal Price)
        {
            decimal result = -1;

            if (Price >= 0 && Price < 10000)
            {
                result = 1900;
            }
            else if (Price < 50000)
            {
                result = 2250;
            }
            else if (Price < 100000)
            {
                result = 2550;
            }
            else if (Price < 150000)
            {
                result = 2850;
            }
            else if (Price < 200000)
            {
                result = 3400;
            }
            else if (Price < 300000)
            {
                result = 3700;
            }
            else
            {
                result = 4400;
            }

            return result;
        }
    }
}
