using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9.Model.Reception
{
    class Table
    {
        public int nombrePlace { get; set; }
        public int nombreTable { get; set; }
        public Boolean disponible { get; set; }
        public Boolean pain { get; set; }
        public Boolean eau { get; set; }
        public Boolean servir { get; set; }

        public int posX { get; set; }
        public int posY { get; set; }

        public Client client { get; set; }

        public Table(int posX, int posY, int nombrePlace, int nombreTable)

        {
            this.disponible = true;
            this.pain = false;
            this.eau = false;
            this.posX = posX;
            this.posY = posY;
            this.nombreTable = nombreTable;
            this.nombrePlace = nombrePlace;
        }
    }
}
