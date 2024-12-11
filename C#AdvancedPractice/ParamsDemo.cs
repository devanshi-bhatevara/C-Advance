using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_AdvancedPractice
{
    public class ParamsDemo
    {
        public static decimal CalculateTotal(params decimal[] prices)
        {
            decimal total = 0;
            foreach (var price in prices)
            {
                total += price;
            }
            return total;
        }

        public static void Main2()
        {
            decimal total = CalculateTotal(100.50m, 200m, 50m);
            Console.WriteLine($"Total Amount: {total}");
        }
    }
}
