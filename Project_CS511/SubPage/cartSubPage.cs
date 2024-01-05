using Project_CS511.Component.Cart;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511.SubPage
{
    public partial class cartSubPage : UserControl
    {
        mainForm main;
        addressBlock1 addressBlock;
        Color green = Color.FromArgb(16, 83, 53);
        public cartSubPage(mainForm main)
        {
            InitializeComponent();
            this.main = main;
            init();
        }

        private void init()
        {
            lb_placeOrder.BackColor = green;
            addressBlock = new addressBlock1(main);
            addressBlock.Location= new Point(0,46);
            this.Controls.Add(addressBlock);
            addData();
        }

        private void addData()
        {
            main.dataSource.SetCollection("user");

            string[] raw = main.dataSource.findValue("loginName", main.currentUser, "cart").Split('-');
            List<string> productId = new List<string>(raw);
            List<string> shops = fillAllShopInCart(productId);
            fillAllOrder(productId, shops);
            totalMoney();
        }

        private void btn_back_Click(object sender, EventArgs e)
        {
            main.RemoveControlByName("cartSubPage");
        }

        #region cac ham chuc nang
        public mainForm GetMainForm()
        { return main; }

        public void updateAddress(string address)
        {
            addressBlock.updateAddress(address);
        }


        private List<string> fillAllShopInCart(List<string> productId)
        {
            List<string> shops = new List<string>();

            main.dataSource.SetCollection("food");
            foreach(string id in productId)
            {
                string shopIdTemp = main.dataSource.findValue("foodId", id, "shopId");
                if(!shops.Contains(shopIdTemp))
                {
                    shops.Add(shopIdTemp);
                    main.dataSource.SetCollection("user");
                    OrderBlock t = new OrderBlock(main);
                    t.addData(main.dataSource.findValue("userId", shopIdTemp, "username"), shopIdTemp);
                    flowLayoutPanel1.Controls.Add(t);
                    main.dataSource.SetCollection("food");
                }
            }
            main.dataSource.SetCollection("user");
            return shops;
        }

        private void fillAllOrder(List<string> productId, List<string> shopId)
        {
            foreach(string id_product in productId)
            {
                main.dataSource.SetCollection("food");
                string foundShopId = main.dataSource.findValue("foodId", id_product, "shopId");
                OrderBlock orderBlock = (OrderBlock)findControlByName(flowLayoutPanel1, foundShopId);
                if (orderBlock.items.Contains(id_product))
                {
                    orderBlock.updatefoodBlock(id_product);
                }
                else
                {
                    orderBlock.addFoodBlock(main.dataSource.findOneDoc("foodId", id_product));
                }

                //OrderBlock orderBlock = (OrderBlock)flowLayoutPanel1.Controls.Find(foundShopId, true).FirstOrDefault();
            }
        }

        private void totalMoney()
        {
            int total = 0;
            foreach(Control c in flowLayoutPanel1.Controls)
            {
                OrderBlock orderBlock = (OrderBlock)c;
                total += orderBlock.getShopBill();
            }
            lb_subTotal.Text = FormatMoney(total.ToString()) + "₫";
            //Calcute shipping fee
            
            lb_total.Text = FormatMoney((total + 25000).ToString()) + "₫";
        }

        private Control findControlByName(Control container, string controlName)
        {
            foreach (Control control in container.Controls)
            {
                if (control.Name == controlName)
                {
                    return control;
                }
            }
            return null; 
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
