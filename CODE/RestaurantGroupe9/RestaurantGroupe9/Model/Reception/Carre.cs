using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9
{
    class Carre
    {
        private int nombreCarre { get; set; }
        public List<Rang> rang;
        public ChefRang chefRang;
        public List<Serveur> serveur;


        public Carre(int numberSquare)

        {
            serveur = new List<Serveur>();
            rang = new List<Rang>();
            switch (nombreCarre)
            {
                case 1:
                    rang.Add(new Rang(1));
                    rang.Add(new Rang(2));

                    chefRang = new ChefRang(93, 423);

                    serveur.Add(new Serveur(358, 423));
                    serveur.Add(new Serveur(628, 165));
                    break;
                default:
                    this.rang = null;
                    break;

            }
            this.nombreCarre = nombreCarre;




        }
    }
}
