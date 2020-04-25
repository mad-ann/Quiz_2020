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
    
    public partial class Form_Reg : Form
    {
        
        public Form_Reg()
        {
            InitializeComponent();
        }

        
        private void button_reg_Click(object sender, EventArgs e)
        {
            //új felhasználó regisztrálása

            string nev = textBox_nev.Text;
            string fnev = textBox_fnev.Text;
            string email = textBox_email.Text;
            string jelszo = textBox_jelszo.Text;
            DateTime szulido = dateTimePicker_szulido.Value;


            Program.sql.CommandText = "INSERT INTO user ( `nev` ,`felhasznalonev`, `jelszo`, " +
                "`neme`, `szuletesi_ido`, `email`) VALUES ( @nev, @fnev, @jelszo, " +
                "@neme, @szulido, @email);";

            Program.sql.Parameters.Clear();
            Program.sql.Parameters.AddWithValue("@nev", nev);
            Program.sql.Parameters.AddWithValue("@fnev", fnev);
            Program.sql.Parameters.AddWithValue("@email", email);
            Program.sql.Parameters.AddWithValue("@jelszo", jelszo);
            Program.sql.Parameters.AddWithValue("@szulido", szulido);

            if (radioButton_ffi.Checked)
            {
                Program.sql.Parameters.AddWithValue("@neme", "F");
            }
            else
            {
                Program.sql.Parameters.AddWithValue("@neme", "N");
            }

            try
            {
                Program.sql.ExecuteNonQuery();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "Sikertelen a regisztráció"); //1062 duplicates
                return;
            }
            

            //ellenorzesek

            /* if (!checkKitoltes())
             {
                 if (checkFelhasznalonev())
                 {
                     DialogResult letezik = MessageBox.Show("Ez a felhasználónév már létezik", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                 }
                 else
                 {

                     this.Hide();
                     Program.form_profil.Show();
                 }
             }
             else
             {
                 MessageBox.Show("Minden mezőt ki kell töltenie a sikeres regisztrációhoz!"); 
             }*/
        }

        //a felhasználó nevet használja-e már valaki
        /*public Boolean checkFelhasznalonev()
        {
           string felhasznalonev = textBox_fnev.Text.Trim();
           
           Program.sql.CommandText = "SELECT `felhasznalonev` FROM `user`;";

           Program.sql.Parameters.AddWithValue("@fnev", felhasznalonev);
           using (MySqlDataReader dr = Program.sql.ExecuteReader())
           {
                if (dr.Read())
                {
                    
                        return true;
                    
                }
                else
                {
                    return false;
                }
           }  
        }*/

        //ellenorzés, hogy minden ki van-e töltve
        public Boolean checkKitoltes()
        {
            string nev = textBox_nev.Text;
            string fnev = textBox_fnev.Text;
            string email = textBox_email.Text;
            string jelszo = textBox_jelszo.Text;
            DateTime szulido = dateTimePicker_szulido.Value;

            if (nev.Equals("") || fnev.Equals("") || jelszo.Equals("")||email.Equals("") || szulido.Equals(""))
            {
                return true;
            }
            else { return false; }
        }
        private void kezdolapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztos félbeszakítja a regisztrációt? Félbeszakítás esetén az adatai el fognak veszni.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz.ToString() == "Yes")
            {
                this.Hide();
                Program.form_nyito.Show();
            }
        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztos kilép az alkalmazásból?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void textBox_nev_TextChanged(object sender, EventArgs e)
        {
            string nev = textBox_nev.Text;
        }

        private void textBox_fnev_TextChanged(object sender, EventArgs e)
        {
            string fnev = textBox_fnev.Text;
        }

        private void dateTimePicker_szulido_ValueChanged(object sender, EventArgs e)
        {
            DateTime szulido = dateTimePicker_szulido.Value;
        }

        private void textBox_jelszo_TextChanged(object sender, EventArgs e)
        {
            string jelszo = textBox_jelszo.Text;
            
        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {
            string email = textBox_email.Text;
        }

        private void radioButton_no_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void Form_Reg_Load(object sender, EventArgs e)
        {

        }
    }
}
