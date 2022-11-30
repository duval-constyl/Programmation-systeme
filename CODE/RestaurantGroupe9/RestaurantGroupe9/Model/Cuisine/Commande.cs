using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9.Model.Cuisine
{
    class Commande
    {
        public List<string> plats { get; set; }

        public Commande()

        {
            plats = new List<string>();
        }
    }
}
