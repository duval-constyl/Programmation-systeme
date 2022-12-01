using System;
using SpriteLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9
{
    class ChefRang
    {
        public int posX { get; set; }
        public int posY { get; set; }
        public Sprite sprite { get; set; }

        public ChefRang(int posX, int posY)
        {
            this.posX = posX;
            this.posY = posY;
        }
    }
}
