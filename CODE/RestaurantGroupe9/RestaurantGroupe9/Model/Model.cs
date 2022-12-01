using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9
{
    class Model
    {
        public GestionCuisine gestionCuisine;
        public GestionReception gestionReception;
        public Menu menu;

       // public void tick() {}

        public Model()

        {
            gestionCuisine = new GestionCuisine();
            gestionReception = new GestionReception();
            menu = new Menu();
        }
    }
}
