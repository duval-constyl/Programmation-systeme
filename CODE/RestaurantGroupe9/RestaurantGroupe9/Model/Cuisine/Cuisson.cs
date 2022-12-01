using System;
using SpriteLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9
{
    class Cuisson
    {
        public int posX { get; set; }
        public int posY { get; set; }

        public Sprite sprite;
        public List<Commande> commands;

        public bool isAvailable;

        public Cuisson(int posX, int posY)

        {
            commands = new List<Commande>();
            this.posX = posX;
            this.posY = posY;
            isAvailable = true;
        }
    }
}
