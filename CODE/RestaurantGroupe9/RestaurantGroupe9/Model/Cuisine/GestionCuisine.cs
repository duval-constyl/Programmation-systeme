using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9.Model.Cuisine
{
    class GestionCuisine
    {
        public ChefPartie chefPartie;
        public List<Cuisson> cuissons;
        public Plongeur plongeur;
        public List<Commande> commande;

        public GestionCuisine()

        {
            cuissons = new List<Cuisson>();

            plongeur = new Plongeur(765, 110);

            chefPartie = new ChefPartie(1055, 110);

            cuissons.Add(new Cuisson(955, 110));
            cuissons.Add(new Cuisson(1212, 110));

            commande = new List<Commande>();


        }
    }
}
