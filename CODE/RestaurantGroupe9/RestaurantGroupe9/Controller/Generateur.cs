using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SpriteLibrary;
using System.Drawing;


namespace RestaurantGroupe9
{
    class Generateur
    {
        public class GenerateurSalle
        {
            Model model;
            Views view;

            public GenerateurSalle(Model model, Views view)
            {
                this.model = model;
                this.view = view;
            }

            /// Maitre d'hôtel 
            public void GenererMaitreHotel()
            {
                model.gestionReception.maitreHotel.sprite = new Sprite(new Point(58, 111), view.reception.spriteController, RestaurantGroupe9.Properties.Resources.maitrehotel, 32, 32, 200, 2);
                model.gestionReception.maitreHotel.sprite.SetName("MaitreHotel");
                model.gestionReception.maitreHotel.sprite.PutBaseImageLocation(new Point(model.gestionReception.maitreHotel.posX, model.gestionReception.maitreHotel.posY));
                model.gestionReception.maitreHotel.sprite.CannotMoveOutsideBox = true;
                model.gestionReception.maitreHotel.sprite.SetSize(new Size(32, 32));
                model.gestionReception.maitreHotel.sprite.MoveTo(new Point(model.gestionReception.maitreHotel.posX, model.gestionReception.maitreHotel.posY));
                model.gestionReception.maitreHotel.sprite.AutomaticallyMoves = true;
                model.gestionReception.maitreHotel.sprite.MovementSpeed = 10;
            }

            // Chef de rang 
            public void GenererChefRang()
            {
                foreach (Carre carre in model.gestionReception.carre)
                {
                    carre.chefRang.sprite = new Sprite(new Point(93, 423), view.reception.spriteController, RestaurantGroupe9.Properties.Resources.Chefrang, 32, 32, 200, 3);
                    carre.chefRang.sprite.SetName("Chef Rang");
                    carre.chefRang.sprite.PutBaseImageLocation(new Point(carre.chefRang.posX, carre.chefRang.posY));
                    carre.chefRang.sprite.CannotMoveOutsideBox = true;
                    carre.chefRang.sprite.SetSize(new Size(32, 32));
                    carre.chefRang.sprite.MoveTo(new Point(carre.chefRang.posX, carre.chefRang.posY));
                    carre.chefRang.sprite.AutomaticallyMoves = true;
                    carre.chefRang.sprite.MovementSpeed = 10;
                }
            }


            /// Serveurs 
            public void GenererServeur()
            {
                foreach (Carre carre in model.gestionReception.carre)
                {
                    foreach (Serveur serveur in carre.serveur)
                    {
                        serveur.sprite = new Sprite(new Point(358, 423), view.reception.spriteController, RestaurantGroupe9.Properties.Resources.serveur, 32, 32, 200, 3);
                        serveur.sprite.SetName("Serveur");
                        serveur.sprite.PutBaseImageLocation(new Point(serveur.posX, serveur.posY));
                        serveur.sprite.CannotMoveOutsideBox = true;
                        serveur.sprite.SetSize(new Size(32, 32));
                        serveur.sprite.MoveTo(new Point(serveur.posX, serveur.posY));
                        serveur.sprite.AutomaticallyMoves = true;
                        serveur.sprite.MovementSpeed = 10;
                    }
                }
            }
        }

        public class GenerateurCuissine
        {
            Model model;
            Views view;

            public GenerateurCuissine(Model model, Views view)
            {
                this.model = model;
                this.view = view;
            }


            /// Plongeur 
            public void GenererPlongeur()
            {
                model.gestionCuisine.plongeur.sprite = new Sprite(new Point(76, 137), view.cuisine.spriteController, RestaurantGroupe9.Properties.Resources.commisstagiaires, 32, 32, 200, 3);
                model.gestionCuisine.plongeur.sprite.SetName("Plongeur");
                model.gestionCuisine.plongeur.sprite.PutBaseImageLocation(new Point(model.gestionCuisine.plongeur.posX, model.gestionCuisine.plongeur.posY));
                model.gestionCuisine.plongeur.sprite.AutomaticallyMoves = true;
                model.gestionCuisine.plongeur.sprite.CannotMoveOutsideBox = true;
                model.gestionCuisine.plongeur.sprite.SetSize(new Size(36, 36));
                model.gestionCuisine.plongeur.sprite.MovementSpeed = 10;
            }


            ///Chef partie cuisine
            public void GenererChefCuisine()
            {
                model.gestionCuisine.chefPartie.sprite = new Sprite(new Point(286, 0), view.cuisine.spriteController, RestaurantGroupe9.Properties.Resources.Chefcuisine, 32, 32, 200, 3);
                model.gestionCuisine.chefPartie.sprite.SetName("Chef");
                model.gestionCuisine.chefPartie.sprite.PutBaseImageLocation(new Point(model.gestionCuisine.chefPartie.posX, model.gestionCuisine.chefPartie.posY));
                model.gestionCuisine.chefPartie.sprite.CannotMoveOutsideBox = true;
                model.gestionCuisine.chefPartie.sprite.SetSize(new Size(32, 32));
                model.gestionCuisine.chefPartie.sprite.MoveTo(new Point(model.gestionCuisine.chefPartie.posX, model.gestionCuisine.chefPartie.posY));
                model.gestionCuisine.chefPartie.sprite.AutomaticallyMoves = true;
                model.gestionCuisine.chefPartie.sprite.MovementSpeed = 10;
            }

            ///Cuissons
            public void GenererCuisson()
            {
                foreach (Cuisson cuisson in model.gestionCuisine.cuissons)
                {
                    cuisson.sprite = new Sprite(new Point(96, 0), view.cuisine.spriteController, RestaurantGroupe9.Properties.Resources.Chefrang, 32, 32, 200, 3);
                    cuisson.sprite.SetName("Cook");
                    cuisson.sprite.PutBaseImageLocation(new Point(cuisson.posX, cuisson.posY));
                    cuisson.sprite.CannotMoveOutsideBox = true;
                    cuisson.sprite.SetSize(new Size(32, 32));
                    cuisson.sprite.MoveTo(new Point(cuisson.posX, cuisson.posY));
                    cuisson.sprite.AutomaticallyMoves = true;
                    cuisson.sprite.MovementSpeed = 10;
                }
            }
        }


        public class GenerateurClient
        {
            Model model;
            Views view;
            //Commandes tasksS = new Commandes();


            public GenerateurClient(Model model, Views view)
            {
                this.model = model;
                this.view = view;
            }

            public void GenererClient()
            {
                foreach (Client clients in model.gestionReception.clients)
                {
                    clients.sprite = new Sprite(new Point(286, 0), view.reception.spriteController, RestaurantGroupe9.Properties.Resources.clients, 32, 32, 200, 3);
                    clients.sprite.SetName("Client");
                    clients.sprite.PutBaseImageLocation(new Point(1375, 900));
                    clients.sprite.CannotMoveOutsideBox = true;
                    clients.sprite.SetSize(new Size(32, 32));
                    clients.sprite.AutomaticallyMoves = true;
                    clients.sprite.MovementSpeed = 10;
                }

            }

        }
    }
}
