using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace RestaurantGroupe9.View
{
    public partial class Reservation : UserControl
    {
        public Reservation()
        {
            InitializeComponent();
        }

        private void bt_ajouter_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0128M94;Initial Catalog=restaurantdb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into RESERVATION values (@Nombre_Client,@Menu_Choisir,@Date_Reservation)", con);
            cmd.Parameters.AddWithValue("@Nombre_Client", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Menu_Choisir", textBox3.Text);
            cmd.Parameters.AddWithValue("@Date_Reservation", textBox4.Text);
            _ = cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Reservation bien enregistrer");
        }

        private void bt_supprimer_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0128M94;Initial Catalog=restaurantdb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Delete RESERVATION where Id_Reservation=@Id_Reservation", con);
            cmd.Parameters.AddWithValue("@Id_Reservation", int.Parse(textBox1.Text));
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Reservation supprimer");
        }

        private void bt_modifier_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=DESKTOP-0128M94;Initial Catalog=restaurantdb;Integrated Security=True");
            con.Open();
            SqlCommand cmd = new SqlCommand("Update RESERVATION set Nombre_Client=@Nombre_Client,Menu_Choisir=@Menu_Choisir,Date_Reservation=@Date_Reservation where Id_Reservation=@Id_Reservation",con);
            cmd.Parameters.AddWithValue("@Id_Reservation", int.Parse(textBox1.Text));
            cmd.Parameters.AddWithValue("@Nombre_Client", int.Parse(textBox2.Text));
            cmd.Parameters.AddWithValue("@Menu_Choisir", textBox3.Text);
            cmd.Parameters.AddWithValue("@Date_Reservation", textBox4.Text);
            cmd.ExecuteNonQuery();

            con.Close();
            MessageBox.Show("Reservation modifier");
        }

        private void bt_enregistrer_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
