using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


namespace Quiz_2020
{
    public partial class Form_Login : Form
    {
       
        public Form_Login()
        {
            InitializeComponent();
        }

        private void button_belepes_Click(object sender, EventArgs e)
        {
            string felhasznalonev = textBox_fnev.Text;
            string jelszo = textBox_password.Text;

            Program.sql.CommandText = "SELECT * FROM `user` WHERE" +
                " `felhasznalonev`= @fnev AND `jelszo`= @jelszo;";

            Program.sql.Parameters.Clear();
            Program.sql.Parameters.AddWithValue("@fnev", felhasznalonev);
            Program.sql.Parameters.AddWithValue("@jelszo", jelszo);
            this.Hide();
            Program.form_profil.Show();
        }

        /*using (MySqlDataReader dr = Program.sql.ExecuteReader())
        {
            if (dr.FieldCount > 0)
            {
                this.Hide();
                Program.form_profil.Show();
            }
            else
            {
                DialogResult figy = MessageBox.Show("Érvénytelen felhasználónév vagy jelszó", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }*/


        private void kezdolapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_nyito.Show();
        }

        private void textBox_fnev_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form_Login_Load(object sender, EventArgs e)
        {

        }
    }
}
