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

namespace Project_CS511.Pages
{
    public partial class home : UserControl
    {
        mainForm main;
        foodSlide foodSlide1;
        restaurantSlide restaurants;
        public home(mainForm main)
        {
            InitializeComponent();
            this.main = main;
            init();
        }

        public void init()
        {
            restaurantSlide restaurantSlide = new restaurantSlide(main);
            flp_home.Controls.Add(restaurantSlide);
            flp_home.Controls.SetChildIndex(restaurantSlide, 2);
            restaurants = restaurantSlide;

            adSlide adSlide = new adSlide();
            flp_home.Controls.Add(adSlide);

            foodSlide foodSlide = new foodSlide(main);
            flp_home.Controls.Add(foodSlide);
            foodSlide1 = foodSlide;
        }

        public void reload()
        {
            restaurants.init();
            foodSlide1.addFood();
        }

        public void setToAvoidConflict()
        {
            restaurants.setAvoidImageConflict();
        }

        public void setToAvoidConflictFood()
        {
            foodSlide1.setToAvoidConflict();
        }

        #region Reload function
        public void reloadRestaurant()
        {
            restaurants.init();
        }

        public void reloadFood()
        {
            foodSlide1.addFood();
        }

        public void reloadDistance()
        {
            foodSlide1.addDistance();
            restaurants.addDistance();
        }

        #endregion
        public void updateFoodAfterDelete()
        {
            foodSlide1.addFood();
        }

        public void reloadStar(string foodId)
        {
            foodSlide1.updateStar(foodId);

        }
        private void flp_home_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
