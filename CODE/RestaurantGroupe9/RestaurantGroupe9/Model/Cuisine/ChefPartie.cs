using System;
using SpriteLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9.Model.Cuisine
{
    class ChefPartie
    {
        public int posX { get; set; }
        public int posY { get; set; }

        public Sprite sprite;

        public List<Commande> commands;

        public ChefPartie(int posX, int posY)

        {
            commands = new List<Commande>();
            this.posX = posX;
            this.posY = posY;
        }
    }
}
