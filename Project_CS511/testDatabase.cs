using MongoDB.Bson;
using MongoDB.Driver;
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
    public partial class testDatabase : Form
    {
        DataSource dataSource = new DataSource();
        public testDatabase()
        {
            InitializeComponent();
            dataSource.SetCollection("food");
            addAllCollection();
        }

        private void addAllCollection()
        {
            var collections = dataSource.data.ListCollections();
            foreach (var doc in collections.ToEnumerable())
            {
                Button t = new Button();
                t.Size = new Size(110, 50);
                t.Text = doc["name"].AsString;
                t.Click += (sender, e) =>
                {
                    Button clicked = (Button)sender;
                    cleanColor();
                    clicked.BackColor = Color.LightGreen;
                    flowLayoutPanel1.Controls.Clear();
                    addData(clicked.Text);
                };
                flp_addCollection.Controls.Add(t);
            }
        }

        private void addData(string name) 
        {
            dataSource.SetCollection(name);
            List<BsonDocument> documents = dataSource.returnAllData();
            foreach (BsonDocument doc in documents)
            {
                RichTextBox textBox = new RichTextBox();
                textBox.Size = new Size(330, 100);
                string raw = doc.ToString();
                string[] strings = raw.Substring(1, raw.Length - 2).Split(',');
                foreach (string s in strings)
                {
                    textBox.Text += s + '\n';
                }
                flowLayoutPanel1.Controls.Add(textBox);
            }
        }


        private void cleanColor()
        {
            foreach (Control c in flp_addCollection.Controls)
            {
                c.BackColor = SystemColors.Control;
            }
        }
    }
}
