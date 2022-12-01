using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace RestaurantGroupe9
{
    class ControllerCuisson
    {
        Model model;
        ControllerCommande commands;
        public ControllerCuisson(Model model)
        {
            this.model = model;
            this.commands = new ControllerCommande(model);
            Task cookTask = new Task(() => WatchLoop());
            cookTask.Start();
        }


        public void WatchLoop()
        {
            Console.WriteLine("Le Task (thread) WatchLoop du cookController est appelé");
            bool getOfLoop = false;
            while (true)
            {
                foreach (Cuisson cuisson in model.gestionCuisine.cuissons)
                {
                    if (cuisson.isAvailable == false)
                    {
                        Thread.Sleep(7000);
                        commands.GoToFridge(cuisson.sprite);
                        Console.WriteLine("Le cuisinier " + cuisson.sprite.SpriteName + "va vers le frigo pour prendre des ingrédients");
                        cuisson.commands.Remove(cuisson.commands[0]);
                        Thread.Sleep(3000);
                        commands.GoToKitchenPLAT(cuisson.sprite);
                        cuisson.isAvailable = true;
                        Console.WriteLine("Le cuisinier " + cuisson.sprite.SpriteName + "va déposer des plats pour le serveur");
                        //Pas fait la manipulation dans la base de données
                    }
                }
            }

        }
    }
}
