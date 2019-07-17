using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceApp
{
    public class Breakfast : Meal
    {
        public static double сoefficient = 0.4;
        public Breakfast(List<Product> meal) : base(meal) { }
    }
}
