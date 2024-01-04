using GMap.NET;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_CS511
{
    public partial class test : Form
    {
        public test()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = getDistance().ToString();
            getDistance();
            //lable1.Text = route.
        }
        public void getDistance()
        {
            System.Threading.Thread.Sleep(1000);
           //  int distance = 0;
            string key = "AIzaSyBSYbQZksuYN9M8fbvOMzOfHKITwHcSyxg";
            string origin = "252 Lý Chính Thắng, Phường 9, Quận 3, Thành phố Hồ Chí Minh, Vietnam";
            string destination = "43 Tân Lập, Đông Hoà, Dĩ An, Bình Dương, Vietnam";
            string url = "https://maps.googleapis.com/maps/api/distancematrix/xml?origins=" + origin + "&destinations=" + destination + "&key="+key;
            WebRequest request = WebRequest.Create(url);
            using (WebResponse response = (HttpWebResponse)request.GetResponse())
            {
                using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                {
                    DataSet dsResult = new DataSet();
                    dsResult.ReadXml(reader);
                    label1.Text = dsResult.Tables["duration"].Rows[0]["text"].ToString();
                    label2.Text = dsResult.Tables["distance"].Rows[0]["text"].ToString();
                }
            }
        //    return 0;
        }
    

        protected string fileGetContents(string fileName)
        {
            string sContents = string.Empty;
            string me = string.Empty;
            try
            {
                if (fileName.ToLower().IndexOf("https:") > -1)
                {
                    System.Net.WebClient wc = new System.Net.WebClient();
                    byte[] response = wc.DownloadData(fileName);
                    sContents = System.Text.Encoding.ASCII.GetString(response);

                }
                else
                {
                    System.IO.StreamReader sr = new System.IO.StreamReader(fileName);
                    sContents = sr.ReadToEnd();
                    sr.Close();
                }
            }
            catch { sContents = "unable to connect to server "; }
            return sContents;
        }
    }
}
