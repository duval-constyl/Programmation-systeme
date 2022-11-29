using System;
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
        public static int speed = 10;
        public bool verif = true;
        public Restaurant()
        {
            InitializeComponent();
        }

        private void Restaurant_Load(object sender, EventArgs e)
        {

        }

        private void pause_Click(object sender, EventArgs e)
        {
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

    }
}
