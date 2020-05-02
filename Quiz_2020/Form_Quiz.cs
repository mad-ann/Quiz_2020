using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quiz_2020
{
    public partial class Form_Quiz : Form
    {
        Kviz teszt = new Kviz();
        int kerdes_index = 0;

        public Form_Quiz()
        {
            InitializeComponent();
        }

        
        
        private void Form_Quiz_Load(object sender, EventArgs e)
        {
            label_kat_TextChange();
            KerdesValasz();
            Feltoltes();
            timer1.Start();
        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (DialogResult.Yes == MessageBox.Show("Biztos ki akar lépni az alkalmazásból?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                Application.Exit();
            }
            
        }

        private void button_befejezes_Click(object sender, EventArgs e)
        {
 
            if (DialogResult.Yes == MessageBox.Show("Biztosan kilép a kvízből? A most elért pontjai el fognak veszni!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Hide();
                Program.form_profil.Show();
            }
            
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            if (DialogResult.Yes == MessageBox.Show("Biztos félbeszakítja a kvízt? A megszerzett pontjai el fognak veszni.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
            {
                this.Hide();
                Program.form_profil.Show();
            }
            
            
        }

        private void radioButton_valasz_A_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           
            
        }

        private void textBox_kategoria_TextChanged(object sender, EventArgs e)
        {
            
        }

        void label_kat_TextChange()
        {
            try
            {
                if (Program.Valasztott_kategoria == Program.kategoria[0])
                {
                    label_kat.Text = "Mikrobiológia";
                }else{
                    if (Program.Valasztott_kategoria == Program.kategoria[1])
                    {
                        label_kat.Text = "Immunológia";   } else
                    {
                        if (Program.Valasztott_kategoria == Program.kategoria[2])
                        {
                            label_kat.Text = "Biokémia";   } else
                        {
                            if (Program.Valasztott_kategoria == Program.kategoria[3])
                            {
                                label_kat.Text = "Növényrendszertan"; }  else
                            {
                                label_kat.Text = "Hiba";
                            } } } } }
            
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "Kérdések betöltése nem sikerült.");
                return;
            }
        }

        
        
        void KerdesValasz()
        {
            Program.sql.CommandText = "SELECT kerdes.id, kerdes.szoveg, kerdes.kategoria_id, valasz.id AS" +
                " valaszid, valasz.valasz, valasz.helyes FROM kerdes JOIN " +
                "valasz ON kerdes.id=valasz.kerdes_id WHERE" +
                " kerdes.kategoria_id = 1 ORDER BY kerdes.id";
            Program.sql.Parameters.Clear();
            
            try
            {                
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    int kerdes_id = -1;
                    int i = -1;
                    while (dr.Read())
                    {

                        if (kerdes_id != dr.GetInt32("id"))
                        {
                            i++;
                            kerdes_id = dr.GetInt32("id");
                            teszt.Kerdesek.Add(new Kerdes(dr.GetInt32("id"), dr.GetString("szoveg"), dr.GetInt32("kategoria_id")));
                            teszt.Kerdesek[i].Valaszok.Add(new Valasz(dr.GetInt32("valaszid"), dr.GetString("valasz"), 
                                dr.GetInt32("id"), dr.GetString("helyes")));
                        }
                        else
                        {
                            teszt.Kerdesek[i].Valaszok.Add(new Valasz(dr.GetInt32("valaszid"), 
                                dr.GetString("valasz"), dr.GetInt32("id"), dr.GetString("helyes")));
                        }
                    }
                    Random r = new Random();
                    kerdes_index = r.Next(teszt.Kerdesek.Count);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "Kérdések betöltése nem siekrült.");
                return;
            }
        }

        void Feltoltes()
        {
            textBox_kerdes.Text = teszt.Kerdesek[kerdes_index].Szoveg;
            radioButton_valasz_A.Text = teszt.Kerdesek[kerdes_index].Valaszok[0].ValasZ;
            radioButton_valasz_B.Text = teszt.Kerdesek[kerdes_index].Valaszok[1].ValasZ;
            radioButton_valasz_C.Text = teszt.Kerdesek[kerdes_index].Valaszok[2].ValasZ;
        
        }

        private void button_tovabb_Click(object sender, EventArgs e)
        {
            if (teszt.Kerdesek[kerdes_index].Valaszok[0].Helyes == "IGAZ" && radioButton_valasz_A.Checked)
            {
                teszt.Kerdesek[kerdes_index].Helyes = true;
            }
            else if (teszt.Kerdesek[kerdes_index].Valaszok[1].Helyes == "IGAZ" && radioButton_valasz_B.Checked)
            {
                teszt.Kerdesek[kerdes_index].Helyes = true;
            }
            else if (teszt.Kerdesek[kerdes_index].Valaszok[2].Helyes == "IGAZ" && radioButton_valasz_C.Checked)
            {
                teszt.Kerdesek[kerdes_index].Helyes = true;
            }

            teszt.Kerdesek.RemoveAt(kerdes_index);
            
            Random r = new Random();
            kerdes_index = r.Next(teszt.Kerdesek.Count);
            Feltoltes();
        }

    }

}
