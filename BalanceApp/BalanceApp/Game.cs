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
    public partial class Game : Form
    {
        Dictionary<int, string> vegetablesDictionary = new Dictionary<int, string>();
        Dictionary<int, string> fruitsDictionary = new Dictionary<int, string>();
        Dictionary<int, string> nutsDictionary = new Dictionary<int, string>();
        Dictionary<int, string> mushroomsDictionary = new Dictionary<int, string>();
        Dictionary<int, string> cerealsDictionary = new Dictionary<int, string>();
        Dictionary<int, string> beansDictionary = new Dictionary<int, string>();
        Dictionary<int, string> dairyDictionary = new Dictionary<int, string>();
        Dictionary<int, string> meatDictionary = new Dictionary<int, string>();
        Dictionary<int, string> fishDictionary = new Dictionary<int, string>();
        Dictionary<int, string> drinksDictionary = new Dictionary<int, string>();
        List<List<Product>> dictionary = new List<List<Product>>();
        ReadDataFromExcel readData = new ReadDataFromExcel($"D:/4 семестр/курсач/BalanceApp/BalanceApp/bin/Debug", 3);
        Product product;

        User user;
        List<Panel> panels = new List<Panel>();
        int index;

        List<Product> actualProducts;

        public Game()
        {
            InitializeComponent();
            setProductDictionary();
        }
        public void setProductDictionary()
        {
            string str0, str1, str2, str3, str4, str5, str6, str7, str8, str9;
            for(int i = 0; i < 13; i++)
            {
                dictionary[i] = new List<Product>();
                str0 = readData.ReadCell(i, 0);
                str1 = readData.ReadCell(i, 4);
                str2 = readData.ReadCell(i, 9);
                str3 = readData.ReadCell(i, 14);
                str4 = readData.ReadCell(i, 19);
                str5 = readData.ReadCell(i, 24);
                str6 = readData.ReadCell(i, 29);
                str7 = readData.ReadCell(i, 34);
                str8 = readData.ReadCell(i, 39);
                str9 = readData.ReadCell(i, 44);
                if (str0 != "")
                {
                    vegetablesDictionary.Add(i, str0);
                    dictionary[i] 

                }
                if (str1 != "")
                {
                    fruitsDictionary.Add(i, str1);
                }
                if (str2 != "")
                {
                    nutsDictionary.Add(i, str2);
                }
                if (str3 != "")
                {
                    mushroomsDictionary.Add(i, str3);
                }
                if (str4 != "")
                {
                    cerealsDictionary.Add(i, str4);
                }
                if (str5 != "")
                {
                    beansDictionary.Add(i, str5);
                }
                if (str6 != "")
                {
                    dairyDictionary.Add(i, str6);
                }
                if (str7 != "")
                {
                    meatDictionary.Add(i, str7);
                }
                if (str8 != "")
                {
                    fishDictionary.Add(i, str8);
                }
                if (str9 != "")
                {
                    drinksDictionary.Add(i, str9);
                }
            }
            readData.workbook.Close(0);
            readData.excel.Quit();
        }

        public void setProductList()
        {
            string str;
            for(int i = 0; i < 10; i++)
            {
                dictionary[i] = new List<Product>();
                while(str != "")
                {
                    double carbon = Convert.ToDouble(readData.ReadCell())
                    dictionary[i].Add(new Product())
                }
            }
        }
        public double Counting(double ccal)
        {
            if (user.UserCcalIndex < 2)
            {

            }
        }

        private void Game_Load(object sender, EventArgs e)
        {
            panels.Add(mainPanel);
            panels.Add(startPanel);
            panels[index].BringToFront();
            ReadExcelFile();
        }

        public void ReadExcelFile()
        {
            ReadDataFromExcel excel = new ReadDataFromExcel(@"D:\4 семестр\курсач\BalanceApp\BalanceApp\bin\Debug\data.xlsx", 1);
            MessageBox.Show(excel.ReadCell(0, 0));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //startPanel.BackColor = Color.FromArgb(0, 0, 0, 0);
            //startPanel.Parent = this;
            if (index < panels.Count - 1)
                panels[++index].BringToFront();// переключатель панелей
        }

        // кнопка старта
        private void startGameButton_Click(object sender, EventArgs e)
        {
            if (index > 0)
                panels[--index].BringToFront();// переключатель панелей

            double weight = Convert.ToDouble(userWeightComboBox.Text);//считывание данных про пользователя
            double height = Convert.ToDouble(userHeightComboBox.Text);//считывание данных про пользователя
            int age = Convert.ToInt32(userAgeComboBox.Text);//считывание данных про пользователя
            User user = new User(userNameTextBox.Text, weight, height, age, userGenderComboBox.Text);//при запуске игры создается новый пользователь
        }

       

        private void AskAmount()
        {
            AskForm f = new AskForm();//спросить про количество продукта перед добавлением в порцию
            f.ShowDialog();
        }

        private void vegetables_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = 0;
            string s = vegetables.SelectedItem.ToString();
            bool d = productDictionary.TryGetValue(vegetables.SelectedIndex, out s);
            AskAmount();//спросить про количество продукта перед добавление в порцию
        }

        private void fruits_SelectedIndexChanged(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void nuts_SelectedIndexChanged(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void mushrooms_SelectedIndexChanged(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void cereals_SelectedIndexChanged(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void beans_SelectedIndexChanged(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void dairy_SelectedIndexChanged(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void meat_SelectedIndexChanged(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void fish_SelectedIndexChanged(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void drinks_SelectedIndexChanged(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add1_1_Click(object sender, EventArgs e)
        {
            AskAmount();//спросить про количество продукта перед добавление в порцию
        }

        private void add1_2_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add1_3_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add2_1_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add2_2_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add2_3_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add3_1_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add3_2_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add3_3_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add4_1_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add4_2_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add4_3_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add5_1_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add5_2_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add5_3_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add6_1_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add6_2_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add6_3_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add7_1_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add7_2_Click(object sender, EventArgs e)
        {
            AskAmount();
        }

        private void add7_3_Click(object sender, EventArgs e)
        {
            AskAmount();
        }
    }
}
