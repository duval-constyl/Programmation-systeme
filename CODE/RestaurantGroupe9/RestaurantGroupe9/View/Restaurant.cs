﻿using System;
using SpriteLibrary;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RestaurantGroupe9
{
    public partial class Restaurant : Form
    {
        //private RestaurantGroupe9.Model.Model resto;
        public static int speed = 10;
        public bool verif = true;
        public SpriteController spriteController;
        /* private bool appLancee = false;
         private bool appEnPause;
         private int compteurMinute = 1;
         private int compteurHeure = 12;
         private int tickMax = 0;
         private string stats = "";*/
      


        public Restaurant()
        {
            InitializeComponent();
        }
       /* private void timer1_Tick(object sender, EventArgs e)
        {
            tickMax += 1;
            resto.tick();
            if (this.compteurMinute < 10)
            {
                this.label1.Text = this.compteurHeure + " H 0" + this.compteurMinute;
            }
            else
            {
                this.label1.Text = this.compteurHeure + " H " + this.compteurMinute;
            }
            this.compteurMinute += 1;
            if (this.compteurMinute == 60)
            {
                this.compteurHeure += 1;
                this.compteurMinute = 0;
            }

        }*/
        private void Restaurant_Load(object sender, EventArgs e)
        {

        }

        private void pause_Click(object sender, EventArgs e)
        {
            /*if (this.appLancee == true)
            {
                if (this.timer1.Enabled == true)
                {
                    this.timer1.Enabled = false;
                    this.appEnPause = true;
                }
                else
                {
                    this.timer1.Enabled = true;
                    this.appEnPause = false;
                }
            }
            else
            {
                MessageBox.Show("Aucune simulation de lancée");
            }*/

           if (verif == true)
            {
                speed = 0;
                verif = false;
            }
            else
            {
                speed = 10;
                verif = true;
            }
        }

        //Affichage de la fenetre reception
        private void reception_Click(object sender, EventArgs e)
        {
            cuisine1.Hide();
            reservation1.Hide();
            reception1.Show();
            reception1.BringToFront();
        }

        //Affichage de la fenetre cuisine
        private void cuisine_Click(object sender, EventArgs e)
        {
            reservation1.Hide();
            reception1.Hide();
            cuisine1.Show();
            cuisine1.BringToFront();
        }

        //Affichage de la fenetre reservation
        private void reserver_Click(object sender, EventArgs e)
        {
            cuisine1.Hide();
            reception1.Hide();
            reservation1.Show();
            reservation1.BringToFront();
        }

        private void stop_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void reception1_Load(object sender, EventArgs e)
        {

        }

        private void minimal_Click(object sender, EventArgs e)
        {

        }

        private void maximum_Click(object sender, EventArgs e)
        {

        }

        private void reception1_Load_1(object sender, EventArgs e)
        {

        }
    }
}
