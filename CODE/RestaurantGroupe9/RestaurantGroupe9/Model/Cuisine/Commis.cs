using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9.Model.Cuisine
{
    class Commis
    {
        private Stock stock;

        private int posX { get; set; }
        private int posY { get; set; }

        public Commis()

        {
            this.stock = new Stock();
        }

        public Commis(int posX, int posY)

        {
            this.posX = posX;
            this.posY = posY;
        }
    }
}
