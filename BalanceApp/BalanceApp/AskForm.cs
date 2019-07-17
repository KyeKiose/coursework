using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BalanceApp
{
    public partial class AskForm : Form
    {
        double weight;
        List<Product> Product { get; set; }

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

        public AskForm()
        {
            InitializeComponent();
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            Weight = Convert.ToDouble(InputWeightMaskedTextBox.Text);
            Product = new List<Product>();
            Product.Add(new Product(Weight));
            this.Close();
        }

        private void buttonCANCEL_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
