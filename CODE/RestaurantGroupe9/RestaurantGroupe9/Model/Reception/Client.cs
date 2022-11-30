using System;
using SpriteLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9.Model.Reception
{
    class Client
    {
        public Etat etat;
        public enum Etat { Arrive, attente, assis, commande, mange, finisRepas, payer, Fini };


        public int numeroTable { get; set; }
        public Boolean reserver { get; set; }
        public Boolean commander { get; set; }
        public int addition { get; set; }
        public int nombreClients { get; set; }
        public Sprite sprite { get; set; }
        

        public Client(int nombreClients)
        {
            etat = Etat.Arrive;
            this.addition = 0;
            commander = false;
            this.nombreClients = nombreClients;
            this.reserver = false;
            
        }
    }
}
