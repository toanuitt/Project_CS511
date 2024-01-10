using DnsClient.Protocol;
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
using ZstdSharp.Unsafe;
using Newtonsoft.Json;
using RestSharp;
using System.Net;

namespace Project_CS511.SubPage
{
    public partial class onlinepayment : UserControl
    {
        mainForm main;
        public onlinepayment(mainForm main)
        {
            InitializeComponent();
            this.main = main;
        }
        public class ApiRequest
        {
            public long accountNo { get; set; }
            public string accountName { get; set; }
            public int acqId { get; set; }
            public int amount { get; set; }
            public string addInfo { get; set; }
            public string format { get; set; }
            public string template { get; set; }
        }

        public class Data
        {
            public int acpId { get; set; }
            public string accountName { get; set; }
            public string qrCode { get; set; }
            public string qrDataURL { get; set; }
        }

        public class ApiResponse
        {
            public string code { get; set; }
            public string desc { get; set; }
            public Data data { get; set; }
        }
        public class Datum
        {
            public int id { get; set; }
            public string name { get; set; }
            public string code { get; set; }
            public string bin { get; set; }
            public string shortName { get; set; }
            public string logo { get; set; }
            public int transferSupported { get; set; }
            public int lookupSupported { get; set; }
            public string short_name { get; set; }
            public int support { get; set; }
            public int isTransfer { get; set; }
            public string swift_code { get; set; }

            public string custom_name
            {
                get
                {
                    return $"({bin}) {shortName}";
                }
            }
        }

        public class Bank
        {
            public string code { get; set; }
            public string desc { get; set; }
            public IList<Datum> data { get; set; }
        }
        public Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            var apiRequest = new ApiRequest();
            var selectedBank = (Datum)cb_nganhang.SelectedItem;
            apiRequest.acqId = Convert.ToInt32(selectedBank.bin);
            // set param
            string txtSTK = "0721000584901";
            string txtTenTaiKhoan = "HE THONG BANKING";
            string txtSoTien = "50000";
            string template = "compact2";
            //
            apiRequest.accountNo = long.Parse(txtSTK);
            apiRequest.accountName = txtTenTaiKhoan;
            apiRequest.amount = Convert.ToInt32(txtSoTien);
            apiRequest.format = "text";
            apiRequest.template = template;
            var jsonRequest = JsonConvert.SerializeObject(apiRequest);
            // use restsharp for request api.
            var client = new RestClient("https://api.vietqr.io/v2/generate");
            var request = new RestRequest();

            request.Method = Method.Post;
            request.AddHeader("Accept", "application/json");

            request.AddParameter("application/json", jsonRequest, ParameterType.RequestBody);

            var response = client.Execute(request);
            var content = response.Content;
            var dataResult = JsonConvert.DeserializeObject<ApiResponse>(content);


            var image = Base64ToImage(dataResult.data.qrDataURL.Replace("data:image/png;base64,", ""));
            pictureBox1.Image = image;

        }

        private void onlinepayment_Load(object sender, EventArgs e)
        {
            using (WebClient client = new WebClient())
            {
                var htmlData = client.DownloadData("https://api.vietqr.io/v2/banks");
                var bankRawJson = Encoding.UTF8.GetString(htmlData);
                var listBankData = JsonConvert.DeserializeObject<Bank>(bankRawJson);

                cb_nganhang.DataSource = listBankData.data;   // list banks
                cb_nganhang.DisplayMember = "custom_name";
                cb_nganhang.ValueMember = "bin";
                if (listBankData.data.Count > 0)
                {
                    cb_nganhang.SelectedIndex = 0;  // Or set it to another valid index as needed
                }
                
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            main.RemoveControlByName("onlinepayment");
        }

        private void cb_nganhang_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
