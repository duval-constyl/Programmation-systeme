using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9
{
    class CommisK
    {
        private Stock stock;

        private int posX { get; set; }
        private int posY { get; set; }

        public CommisK()

        {
            this.stock = new Stock();
        }

        public CommisK(int posX, int posY)

        {
            this.posX = posX;
            this.posY = posY;
        }
    }
}
