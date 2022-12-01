using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RestaurantGroupe9
{
    class ControllerChefCuisine
    {
        Model model;
        ControllerCommande commands;
        public ControllerChefCuisine(Model model)
        {
            this.model = model;
            this.commands = new ControllerCommande(model);
            Task butlerTask = new Task(() => WatchLoop());
            butlerTask.Start();


        }

        public void WatchLoop()
        {
            int count = 0;

            while (true)
            {
                Thread.Sleep(8000);
                if (model.gestionCuisine.commande.Count > 0)
                {

                    Console.WriteLine("Le thread de gestion du chef de cuisine est lancé");
                    var x = model.gestionCuisine.commande.Count;
                    for (int i = 0; i < model.gestionCuisine.commande.Count; i++)
                    {
                        model.gestionCuisine.chefPartie.commands.Add(model.gestionCuisine.commande[i]);
                        foreach (Commande com in model.gestionCuisine.chefPartie.commands)
                        {
                            Console.WriteLine(model.gestionCuisine.commande[0].plats[0]);
                            com.plats.Add(model.gestionCuisine.commande[i].plats[0]);
                            model.gestionCuisine.commande[i].plats.Remove(model.gestionCuisine.commande[i].plats[0]);
                        }
                    }
                }



                if (model.gestionCuisine.chefPartie.commands.Count > 0)
                {
                    Console.WriteLine(model.gestionCuisine.chefPartie.commands.Count);
                    if (count % 2 == 0)
                    {
                        model.gestionCuisine.cuissons[0].commands.Add(model.gestionCuisine.chefPartie.commands[0]);
                        model.gestionCuisine.chefPartie.commands.Remove(model.gestionCuisine.chefPartie.commands[0]);
                        model.gestionCuisine.cuissons[0].isAvailable = false;
                        Console.WriteLine("Le plat " + model.gestionCuisine.cuissons[0].commands[0].plats[0] + " à été affecté au chef 0");
                    }
                    else
                    {
                        model.gestionCuisine.cuissons[1].commands.Add(model.gestionCuisine.chefPartie.commands[0]);
                        model.gestionCuisine.chefPartie.commands.Remove(model.gestionCuisine.chefPartie.commands[0]);
                        model.gestionCuisine.cuissons[1].isAvailable = false;
                        Console.WriteLine("Le plat " + model.gestionCuisine.cuissons[1].commands[0].plats[0] + " à été affecté au chef 1");
                    }
                    count++;
                }




            }
        }
    }
}
