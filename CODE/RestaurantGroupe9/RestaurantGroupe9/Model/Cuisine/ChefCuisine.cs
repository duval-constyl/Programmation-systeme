using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9.Model.Cuisine
{
    class ChefCuisine
    {
        private Menu menu;
        private Stock stock;
        private Cuisson cuisson;

        public int posX { get; set; }
        public int posY { get; set; }

        public ChefCuisine()

        {
            this.cuisson = new Cuisson(posX, posY);
        }

        public ChefCuisine(int posX, int posY)

        {
            this.posX = posX;
            this.posY = posY;
        }
    }
}
