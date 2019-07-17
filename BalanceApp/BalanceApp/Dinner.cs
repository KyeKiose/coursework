using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceApp
{
    public class Dinner : Meal
    {
        public static double сoefficient = 0.25;
        public Dinner(List<Product> meal) : base(meal){}
    }
}
