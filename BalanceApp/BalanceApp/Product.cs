using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceApp
{
    public class Product : Food
    {
        public Product(string name, double protein, double carbon, double fat)//конструктор продукта по имени, Б, У, Ж(в 1 г)
        {
            Name = name;
            Protein = protein;
            Carbon = carbon;
            Fat = fat;
        }
        
        public Product(double weight)
        {
            Weight = weight;
        }
        public Product()
        {
            Name = "banana";
            Weight = 120;
            Protein = 0.02;
            Carbon = 0.22;
            Fat = 0.01;
        }
        public double CCal(Product p)//определение количества ккал в определенном количестве продукта
        {
            return Weight * ((Protein / 100) * 4 + (Carbon / 100) * 4 + (Fat / 100) * 9);
        }
    }
}
