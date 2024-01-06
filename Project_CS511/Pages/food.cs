using Project_CS511.Component;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511.Pages
{
    public partial class food : UserControl
    {
        mainForm main;
        public food(mainForm main)
        {
            InitializeComponent();
            this.main = main;
            // init current user
            currentuser = new Addressuser();
        }

        private void food_Load(object sender, EventArgs e)
        {

        }
        // move to map.cs
        private void lbl_address_Click(object sender, EventArgs e)
        {
            hideAllControls();
            main.mapPage.getAddress(userlocation);
            main.mapPage.Init();
            main.mapPage.Show();
        }

        #region hide usercontrol
        public void hideAllControls()
        {
            if (main.foodPage != null) { main.foodPage.Hide(); }
            main.HideMenu();
            //if ( != null) { main.foodPage.Hide(); }
            // tiếp tục với các page khác khi thêm vào như account, payment
        }
        #endregion
        public class Addressuser
        {
            public string Address { get; set; }
            public double Latitude { get; set; }
            public double Longitude { get; set; }
        }
        public Addressuser currentuser;

        //set label address
        public void SetLabelAddress(string address)
        {
            lbl_address.Text = address;
        }

        public string GetLabelAddress()
        {
            return lbl_address.Text;
        }
        #region calculate time and distance
        public (string Time, string Distance) getDistance(string origin, string destination)
        {
            System.Threading.Thread.Sleep(1000);
            string key = "AIzaSyBSYbQZksuYN9M8fbvOMzOfHKITwHcSyxg";
            string url = "https://maps.googleapis.com/maps/api/distancematrix/xml?origins=" + origin + "&destinations=" + destination + "&key=" + key;
            WebRequest request = WebRequest.Create(url);
            using (WebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    DataSet dsResult = new DataSet();
                    dsResult.ReadXml(reader);
                    string time = dsResult.Tables["duration"].Rows[0]["text"].ToString();
                    string distance = dsResult.Tables["distance"].Rows[0]["text"].ToString();
                    return (time, distance);
                }
            }

        }
        #endregion

        private void btn_delivery_Click(object sender, EventArgs e)
        {
            btn_delivery.BackColor = Color.LightCyan;
            btn_delivery.ForeColor = Color.Teal;
            btn_dinner.BackColor = SystemColors.Control;
            btn_dinner.ForeColor = SystemColors.ControlText;

        }

        private void btn_dinner_Click(object sender, EventArgs e)
        {
            btn_dinner.BackColor = Color.LightCyan;
            btn_dinner.ForeColor = Color.Teal;
            btn_delivery.BackColor = SystemColors.Control;
            btn_delivery.ForeColor = SystemColors.ControlText;
        }
        public string userlocation;
        public void Init()
        {
            main.dataSource.SetCollection("user");
            userlocation = main.dataSource.findValue("loginName", main.currentUser, "location");
            lbl_address.Text = userlocation.Substring(0, 12)+ "...";
        }
    }
}
