using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9
{
    class ControllerMaitreHotel
    {
        Model model;
        Commande commands;
        private object carre;

        public ControllerMaitreHotel(Model model)
        {
            this.model = model;
            Task butlerTask = new Task(() => WatchLoop());
            butlerTask.Start();
        }

        public void WatchLoop()
        {
            Console.WriteLine("Le Task (thread) WatchLoop du tableController est appelé");
            bool getOfLoop = false;
            while (true)
            {
                getOfLoop = false;


                foreach (Client clients in model.gestionReception.clients)
                {
                    if (clients.etat == Client.Etat.Arrive)
                    {
                        foreach (Carre carre in model.gestionReception.carre)
                        {
                            foreach (Rang rang in carre.rang)
                            {
                                foreach (Table table in rang.tables)
                                {
                                    if (table.disponible == true && table.nombrePlace >= clients.nombreClients)
                                    {
                                        Console.WriteLine("la table " + table.nombreTable + " a été assigné");
                                        table.disponible = false;
                                        table.client = clients;
                                        //Added
                                        clients.numeroTable = table.nombreTable;
                                        clients.etat = Client.Etat.attente;
                                        Console.WriteLine(clients.etat);
                                        clients.numeroTable = table.nombreTable;
                                        // model.restaurationRoom.clients.Remove(client);
                                        getOfLoop = true;
                                        break;
                                    }
                                }
                                break;
                            }
                            break;
                        }

                    }
                }

            }
        }
    }
}
