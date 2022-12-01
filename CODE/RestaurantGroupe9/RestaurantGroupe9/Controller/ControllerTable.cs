using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantGroupe9
{
    class ControllerTable
    {
        Model model;
        ControllerCommande commands;
        public ControllerTable(Model model)
        {
            this.model = model;
            this.commands = new ControllerCommande(model);
            Task butlerTask = new Task(() => WatchLoop());
            butlerTask.Start();
        }

        public void WatchLoop()
        {
            Console.WriteLine("Le Task (thread) WatchLoop du tableController est appelé");
            bool getOfLoop = false;
            while (true)
            {
                foreach (Carre carre in model.gestionReception.carre)
                {
                    foreach (Serveur serveur in carre.serveur)
                    {
                        foreach (Rang rang in carre.rang)
                        {
                            foreach (Table table in rang.tables)
                            {
                                if (serveur.disponible == true)
                                {
                                    if (table.client.commander == false)
                                    {
                                        Console.WriteLine("Le client à la table " + table.nombreTable + " passe une commande");
                                        table.client.commander = true;
                                    }
                                    if (table.pain == false)
                                    {
                                        //commandes pour aller au pain
                                        commands.Go4Bread(serveur.sprite);
                                        commands.GoToTable(serveur.sprite, table.nombreTable);
                                        table.pain = true;
                                        Console.WriteLine("On va apporter le pain à la table: " + table.nombreTable);
                                    }
                                    if (table.servir == false)
                                    {
                                        commands.GoToKitchenPLAT(serveur.sprite);
                                        Console.WriteLine("On va chercher les repas table: " + table.nombreTable);
                                        commands.GoToTable(serveur.sprite, table.nombreTable);
                                    }
                                    getOfLoop = true;
                                }

                            }
                            if (getOfLoop) break;
                        }
                        if (getOfLoop) break;
                    }
                    if (getOfLoop) break;
                }
                if (getOfLoop) break;
            }
        }
    }
}
