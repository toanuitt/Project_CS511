using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Project_CS511.Component
{
    public partial class foodlist : UserControl
    {
        mainForm main;
        public foodlist(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }
        #region getset
        private string _pic;
        private string _name;
        private string _price;

        [Category("Custom Props")]
        public string Picture
        {
            get { return _pic; }
            set
            {
                _pic = value;
                string path = getFoodPicturePath();
                pb_picture.Image = Image.FromFile(path + _pic + ".png");
            }
        }
        [Category("Custom Props")]
        public string Namefood
        {
            get { return _name; }
            set { _name = value; lbl_name.Text = _name; }
        }
        [Category("Custom Props")]
        public string Price
        {
            get { return _price; }
            set { _price = value; lbl_price.Text = _price + " đ"; }
        }

        #endregion
        #region Các Hàm chức năng
        private string getFoodPicturePath()
        {
            string[] s = { "\\bin" };
            string currentPath = Application.StartupPath.Split(s, StringSplitOptions.None)[0] + "\\icons\\food\\";
            return currentPath;

        }

        static string FormatMoney(string value)
        {
            int money = Int32.Parse(value);
            // Use the "N" format specifier with CultureInfo.InvariantCulture to get the desired format
            return money.ToString("N0", System.Globalization.CultureInfo.InvariantCulture);
        }
        #endregion
    }
}
