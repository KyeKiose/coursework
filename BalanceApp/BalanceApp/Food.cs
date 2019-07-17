using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalanceApp
{
    public abstract class Food
    {
        string name;//название продукта
        double weight;//вес продукта
        double protein;//количество белков в 1 г продукта
        double carbon;//количество углеводов в 1 г продекта
        double fat;//количество жиров в 1 г продукта


        //properties
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }
        public double Weight
        {
            get
            {
                return weight;
            }
            set
            {
                weight = value;
            }
        }
        public double Protein
        {
            get
            {
                return protein;
            }
            set
            {
                protein = value;
            }
        }
        public double Carbon
        {
            get
            {
                return carbon;
            }
            set
            {
                carbon = value;
            }
        }
        public double Fat
        {
            get
            {
                return fat;
            }
            set
            {
                fat = value;
            }
        }
    }
}
