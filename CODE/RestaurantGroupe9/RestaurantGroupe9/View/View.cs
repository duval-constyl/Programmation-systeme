using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9
{
    class Views
    {
        public Form1 form1;
        public Restaurant restaurant;
        public Reception reception;
        public Cuisine cuisine;


        public Views()
        {
            form1 = new Form1();
            restaurant = new Restaurant();
            reception = new Reception();
            cuisine = new Cuisine();
        }
    }
}
