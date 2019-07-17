using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceApp
{
    public class Lunch : Meal
    {
        public static double сoefficient = 0.35;
        public Lunch(List<Product> meal) : base(meal) { }
    }
}
