using MongoDB.Bson;
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

namespace Project_CS511.Component
{
    public partial class restaurantSlide : UserControl
    {
        mainForm main;
        public restaurantSlide(mainForm main)
        {
            InitializeComponent();
            this.main = main;
            init();
        }

        public void init()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 1; i < 6; i++)
            {
                //create new food block
                restaurantBlock f = new restaurantBlock(main);

                //get a random documment from food
                main.dataSource.SetCollection("user");
                BsonDocument random = main.dataSource.findOneDoc("userId", i.ToString());

                if (random["userId"].AsString != main.currentId)
                {
                    //add data to foodblock
                    f.addData(random);

                    //add new data to food the slide
                    flowLayoutPanel1.Controls.Add(f);
                }
            }
        }

        public void setAvoidImageConflict()
        {
            foreach(Control c in flowLayoutPanel1.Controls)
            {
                restaurantBlock f = (restaurantBlock)c;
                f.setImageToDefault();
            }
        }

        public void addDistance()
        {
            foreach (Control c in flowLayoutPanel1.Controls)
            {
                restaurantBlock temp = (restaurantBlock)c;
                temp.addDistance(temp.userId);
            }
        }
    }
}
