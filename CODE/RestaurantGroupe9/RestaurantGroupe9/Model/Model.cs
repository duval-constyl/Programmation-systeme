using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9.Model
{
    class Model
    {
        public RestaurantGroupe9.Model.Cuisine.GestionCuisine gestionCuisine;
        public RestaurantGroupe9.Model.Reception.GestionReception gestionReception;
        public RestaurantGroupe9.Model.Cuisine.Menu menu;

       // public void tick() {}

        public Model()

        {
            gestionCuisine = new RestaurantGroupe9.Model.Cuisine.GestionCuisine();
            gestionReception = new RestaurantGroupe9.Model.Reception.GestionReception();
            menu = new RestaurantGroupe9.Model.Cuisine.Menu();
        }
    }
}
