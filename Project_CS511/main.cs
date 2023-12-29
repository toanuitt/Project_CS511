using Project_CS511.Component;
using Project_CS511.Pages;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511
{
    public partial class mainForm : Form
    {
        public home homePage;
        public message messagePage;
        public account accountPage;
        public mainForm()
        {
            InitializeComponent();
            init();
        }

        private void init()
        {
            //add menu bar
            menuBar menu = new menuBar(this);
            this.Controls.Add(menu);

            //add home page
            homePage = new home(this);
            this.Controls.Add(homePage);

            //add message
            messagePage = new message(this);
            this.Controls.Add(messagePage);

            //add account
            accountPage = new account(this);
            this.Controls.Add(accountPage);
        }

        public void hideAllControls()
        {
            foreach(Control c in this.Controls)
            {
                c.Hide();
            }
        }

        public void bringControlToFront(Control c)
        {
            c.BringToFront();
        }

        public void RemoveControlByName(string controlName)
        {
            var controlToRemove = Controls.Find(controlName, true).OfType<Control>().FirstOrDefault();

            if (controlToRemove != null)
            {
                Controls.Remove(controlToRemove);
                controlToRemove.Dispose();
            }
        }
    }
}
