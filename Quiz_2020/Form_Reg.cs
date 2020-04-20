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

            
            MySqlCommand command = new MySqlCommand("INSERT INTO `user`(`nev`, `felhasznalonev`," +
                " `jelszo`,`neme`, `szuletesi_ido`, `email`) " +
                "VALUES (@nev, @fnev, @jelszo, @neme, @szulido, @email)", ab.GetConnection());
               
            command.Parameters.Add("@nev", MySqlDbType.VarChar).Value = textBox_nev.Text;
            command.Parameters.Add("@fnev", MySqlDbType.VarChar).Value = textBox_fnev.Text;
            command.Parameters.Add("@jelszo", MySqlDbType.VarChar).Value = textBox_jelszo.Text;

            if (radioButton_ffi.Checked)
            {
                command.Parameters.Add("@neme", MySqlDbType.Enum).Value = 'F';
            }
            else
            {
                command.Parameters.Add("@neme", MySqlDbType.Enum).Value = 'N';
            }
            

            command.Parameters.Add("@szulido", MySqlDbType.DateTime).Value = dateTimePicker_szulido.Value;
            command.Parameters.Add("@email", MySqlDbType.VarChar).Value = textBox_email.Text;
            

            //konnektor kapcsolás
            ab.openConnection();
            command.ExecuteNonQuery();

            if (!checkKitoltes())
            {
                if (checkFelhasznalonev())
                {
                    DialogResult letezik = MessageBox.Show("Ez a felhasználónév már létezik", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    //MessageBox.Show("Sikeres regisztráció");
                    this.Hide();
                    Program.form_nyito.Show();
                }
            }
            else
            {
                MessageBox.Show("Minden mezőt ki kell töltenie a sikeres regisztrációhoz!"); 
            }
            

            //konnektor megszakítása
            ab.closeConnection();
        }

        //a felhasználó nevet használja-e már valaki
        public Boolean checkFelhasznalonev()
        {
            

            string felhasznalonev = textBox_fnev.Text;


             Program.sql.CommandText ="SELECT * FROM `user` WHERE `felhasznalonev`= @fnev";

            Program.sql.Parameters.AddWithValue("@fnev", felhasznalonev);
            using (MySqlDataReader dr=Program.sql.ExecuteReader())
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
           
        }

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
                return false;
            }
            else { return true; }
        }
        private void kezdolapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztos félbeszakítja a regisztrációt? Félbeszakítás esetén az adatai el fognak veszni.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz.ToString() == "Yes")
            {
                Application.Exit();
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
    }
}
