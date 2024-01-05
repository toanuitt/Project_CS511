using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511.Component.Cart
{
    public partial class foodBlockCart : UserControl
    {
        mainForm main;
        public int money;
        public foodBlockCart(mainForm main, string id, string name, string price)
        {
            InitializeComponent();
            Name = id;
            this.main = main;
            pb_foodPic.Image = Image.FromFile(getFoodPicturePath()+id+".png");
            lb_foodName.Text = name;
            lb_money.Text = FormatMoney(price) + "₫";
            money = Convert.ToInt32(price);
        }

        public void updateQuantity()
        {
            lb_number.Text = (Int32.Parse(lb_number.Text) + 1).ToString();
        }

        static string FormatMoney(string value)
        {
            int money = Int32.Parse(value);
            // Use the "N" format specifier with CultureInfo.InvariantCulture to get the desired format
            return money.ToString("N0", System.Globalization.CultureInfo.InvariantCulture);
        }

        private string getFoodPicturePath()
        {
            string[] s = { "\\bin" };
            string currentPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\icons\\food\\";
            return currentPath;

        }
    }
}
