using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }

    class Product
    {
        private string name;
        private double protein;
        private double carbon;
        private double fat;
        private double ccal;
        public Product(string name, double protein, double carbon, double fat, double ccal)
        {
            this.name = name;
            this.protein = protein;
            this.carbon = carbon;
            this.fat = fat;
            this.ccal = ccal;
        }
    }
    class Meal : Product
    {
        private Product[] meals;
        public Meal(Product[] meals, string name, double protein, double carbon, double fat, double ccal) : base(name, protein, carbon, fat, ccal)
        {
            this.meals = meals;
        }

    }

    class User
    {
         
    }
}
