using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace RestaurantGroupe9
{
    class Controller
    {
        //CreationClient creationClient;
        Generateur.GenerateurSalle creationSalle;
        Generateur.GenerateurCuissine creationCuisine;
        Generateur.GenerateurClient creationClient;
        ControllerCommande commands;
        ControllerChefCuisine kit;
        ControllerMaitreHotel butlerController;
        ControllerCuisson cook;
        ControllerTable tabf;
        Model model;
        Views view;

        public Controller()
        {
            model = new Model();

            Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            view = new Views();


            butlerController = new ControllerMaitreHotel(model);
            creationSalle = new Generateur.GenerateurSalle(model, view);
            creationCuisine = new Generateur.GenerateurCuissine(model, view);
            creationClient = new Generateur.GenerateurClient(model, view);
            commands = new ControllerCommande(model);
            kit = new ControllerChefCuisine(model);
            cook = new ControllerCuisson(model);
            tabf = new ControllerTable(model);

            InitPerson();

            Task test = new Task(() => this.Test());
            Task butlerTask = new Task(() => this.Asign());
            Task chief = new Task(() => this.Delegue());
            Task cookT = new Task(() => this.Cooker());

            butlerTask.Start();
            test.Start();
            chief.Start();
            cookT.Start();
            Application.Run(new Form1());
        }
        public void InitPerson()
        {
            // SALLE //
            creationSalle.GenererMaitreHotel();
            creationSalle.GenererServeur();
            creationSalle.GenererChefRang();

            // CUISINE //
            creationCuisine.GenererChefCuisine();
            creationCuisine.GenererCuisson();
            creationCuisine.GenererPlongeur();

            // CLIENT //
            creationClient.GenererClient();
        }
        public void Asign()
        {
            butlerController.WatchLoop();
        }


        public void Delegue()
        {
            kit.WatchLoop();
        }

        public void Cooker()
        {
            cook.WatchLoop();
        }


        public void Test()
        {

            while (true)
            {

                if (model.gestionReception.clients[0].etat == Client.Etat.attente)
                {
                    commands.GoToButler(model.gestionReception.clients[0].sprite);
                    commands.GoToButler(model.gestionReception.carre[0].chefRang.sprite);

                    model.gestionReception.clients[0].etat = Client.Etat.assis;



                    /*commandes.GoToButler(model.restaurationRoom.clients[0].sprite);
                    commandes.GoToButler(model.restaurationRoom.squares[0].headWaiter.sprite);
                    commandes.GoToTable(model.restaurationRoom.squares[0].waiters[0].sprite, 3);
                    commandes.GoToTable(model.restaurationRoom.clients[0].sprite, 3);
                    Console.WriteLine("Le client va maintenant passer une commande");
                    commandes.LetsOrder(model.restaurationRoom.clients[0]);

                    Thread.Sleep(2000);
                    Console.WriteLine("Le serveur va déclarer les ordres au chef");
                    commandes.GoToKitchenChief(model.restaurationRoom.squares[0].waiters[0].sprite);
                    kit.WatchLoop();*/


                }
                else if (model.gestionReception.clients[0].etat == Client.Etat.assis)
                {
                    commands.GoToTable(model.gestionReception.carre[0].chefRang.sprite, model.gestionReception.clients[0].numeroTable);
                    commands.GoToTable(model.gestionReception.clients[0].sprite, model.gestionReception.clients[0].numeroTable);
                    model.gestionReception.clients[0].etat = Client.Etat.commande;
                }
                else if (model.gestionReception.clients[0].etat == Client.Etat.commande)
                {

                    commands.GoToTable(model.gestionReception.carre[0].serveur[0].sprite, model.gestionReception.clients[0].numeroTable);
                    commands.LetsOrder(model.gestionReception.clients[0]);
                    Thread.Sleep(2000);
                    commands.GoToKitchenChief(model.gestionReception.carre[0].serveur[0].sprite);
                    int a = model.gestionCuisine.commande.Count;
                    Console.WriteLine(a);
                    model.gestionReception.clients[0].etat = Client.Etat.mange;



                }
                else if (model.gestionReception.clients[0].etat == Client.Etat.mange)
                {

                }
                else if (model.gestionReception.clients[0].etat == Client.Etat.finisRepas)
                {

                }
                else if (model.gestionReception.clients[0].etat == Client.Etat.payer)
                {

                }
                else if (model.gestionReception.clients[0].etat == Client.Etat.Fini)
                {

                }
            }

            //commandes.GoToTable(model.restaurationRoom.clients[0].sprite, model.restaurationRoom.clients[0].tableNumber);
        }
    }
}
