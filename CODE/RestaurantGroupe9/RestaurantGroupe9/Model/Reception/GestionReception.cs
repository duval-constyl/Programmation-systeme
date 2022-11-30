using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9.Model.Reception
{
    class GestionReception
    {
        public List<Carre> carre;
        public MaitreHotel maitreHotel;
        public Commis commis;
        public List<Client> clients;
        public GestionReception()

        {
            carre = new List<Carre>();
            this.maitreHotel = new MaitreHotel(1310, 755);
            this.carre.Add(new Carre(1));
            this.carre.Add(new Carre(2));
            this.commis = new Commis(25, 125);
            clients = new List<Client>();
            clients.Add(new Client(3));

        }
    }
}
