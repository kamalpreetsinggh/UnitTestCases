using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductNUnitApplication.Repository
{
    public class Calculate
    {
        public static double CalculateRegularDiscount(double price)
        {
            return (price - price * 0.1);
        }

        public static double CalculatePremiumDiscount(double price)
        {
            return (price - price * 0.2);
        }
    }
}
