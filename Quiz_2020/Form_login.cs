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
            AB ab = new AB();

            string felhasznalonev = textBox_fnev.Text;
            string jelszo = textBox_password.Text;

            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            MySqlCommand command = new MySqlCommand("SELECT * FROM `user` WHERE `felhasznalonev`= @fnev AND `jelszo`= @jelszo", ab.GetConnection());
            
            command.Parameters.Add("@fnev", MySqlDbType.VarChar).Value = felhasznalonev;
            command.Parameters.Add("@jelszo", MySqlDbType.VarChar).Value = jelszo;

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if (table.Rows.Count > 0)
            {
                /*amennyiben létezik és helyes adatokat adott meg a felhasználó,
                akkor átirányitja a profil oldalra a felhasználót a program.*/
                this.Hide();
                Program.form_profil.Show();
            }
            
                /*amennyiben nincs megfelelő adat, vagy nincsenek kitöltve a mezők,
                 egy felugró ablak figyelmeztet.*/            
            else
            {
                DialogResult figy = MessageBox.Show("Érvénytelen felhasználónév vagy jelszó", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void kezdolapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_nyito.Show();
        }

        private void textBox_fnev_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
