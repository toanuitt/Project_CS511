using MongoDB.Bson;
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
    public partial class foodSlide : UserControl
    {
        mainForm main;
        public foodSlide(mainForm main)
        {
            InitializeComponent();
            this.main = main;
            addFood();
        }

        public void addFood()
        {
            flowLayoutPanel1.Controls.Clear();
            for (int i = 0; i < 10; i++)
            {
                //create new food block
                foodBlock f = new foodBlock(main);

                //get a random documment from food
                main.dataSource.SetCollection("food");
                BsonDocument random = main.dataSource.getRandomDoc();

                //add data to foodblock
                f.addData(random);

                //add new data to food the slide
                flowLayoutPanel1.Controls.Add(f);

                //set data to user collection to avoid confusion
                main.dataSource.SetCollection("user");
            }
            
        }
    }
}
