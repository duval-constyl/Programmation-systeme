using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9.Model.Cuisine
{
    class Menu
    {
        public List<string> plats { get; set; }

        public Menu()

        {
            plats = new List<string>();

            plats.Add("Plat1");
            plats.Add("Plat2");
            plats.Add("Plat3");
            plats.Add("Plat4");
            plats.Add("Plat5");
            plats.Add("Plat6");
            plats.Add("Plat7");
            plats.Add("Plat8");
            plats.Add("Plat9");
            plats.Add("Plat10");
        }
    }
}
