using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceApp
{
    public class Meal : Product
    {
        protected List<Product> mealList;//поле список продуктов(ингридиентов) одного приема пищи


        public Meal()
        {

        }

        public Meal(List<Product> products)//конструктор приема пищи по списку продуктов
        {
            mealList = new List<Product>();
            mealList = products;
        }

        public double GetCcal()//метод подсчета ккалорий в одном приеме пищи
        {
            double sumCcal = 0;
            for (int i = 0; i < mealList.Count; i++)
            {
                sumCcal += CCal(mealList[i]);
            }
            return sumCcal;
        }

       

    }
}
