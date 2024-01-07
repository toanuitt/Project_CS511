using Project_CS511.Component;
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
    public partial class likedSubPage : UserControl
    {
        mainForm main;
        public likedSubPage(mainForm main)
        {
            InitializeComponent();
            this.main = main;
            init();
        }

        private void init()
        {
            main.dataSource.SetCollection("user");
            List<string> likedProduct = main.dataSource.findValue("loginName", main.currentUser, "liked").Split('-').ToList();
            int i = 0;
            foreach(string product in likedProduct)
            {
                favouriteBlock f = new favouriteBlock(main);
                f.addData(product);
                f.Name = i.ToString();
                i += 1;
                flowLayoutPanel1.Controls.Add(f);
            }
        }


        private void btn_back_Click(object sender, EventArgs e)
        {
            main.RemoveControlByName("likedSubPage");
        }
    }
}
