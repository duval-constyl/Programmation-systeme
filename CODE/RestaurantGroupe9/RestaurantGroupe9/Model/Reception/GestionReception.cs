using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9
{
    class GestionReception
    {
        public List<Carre> carre;
        public MaitreHotel maitreHotel;
        public CommisR commis;
        public List<Client> clients;
        public GestionReception()

        {
            carre = new List<Carre>();
            this.maitreHotel = new MaitreHotel(82, 95);
            this.carre.Add(new Carre(1));
            this.carre.Add(new Carre(2));
            this.commis = new CommisR(68, 285);
            clients = new List<Client>();
            clients.Add(new Client(3));

        }
    }
}
