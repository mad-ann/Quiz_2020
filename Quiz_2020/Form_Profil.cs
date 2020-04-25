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
    public partial class Form_Profil : Form
    {
        public Form_Profil()
        {
            InitializeComponent();
        }
        private void kezdolapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_nyito.Show();
        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            {
                DialogResult valasz = MessageBox.Show("Biztos, hogy kilép az alkalmazásból?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (valasz.ToString() == "Yes")
                {
                    Application.Exit();
                }
            }
        }
        

        private void mikrobiologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Valasztott_kategoria = Program.kategoria[0];
            
            if (DialogResult.OK == MessageBox.Show("A kvíz elindul az OK gomb megnyomása után. A kvíz 30 másodperces. Biztonsan készen áll? ", "", MessageBoxButtons.OKCancel))
            {
               this.Hide();
               Program.form_indito.Show();
            }
            else
            {
                this.Hide();
                Program.form_profil.Show();
            }
        }

        private void immunologiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Valasztott_kategoria = Program.kategoria[1];
            if (DialogResult.OK == MessageBox.Show("A kvíz elindul az OK gomb megnyomása után. A kvíz 30 másodperces. Biztonsan készen áll? ", "", MessageBoxButtons.OKCancel))
            {
                this.Hide();
                Program.form_indito.Show();
            }
            else
            {
                this.Hide();
                Program.form_profil.Show();
            }
        }

        private void biokemiaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Valasztott_kategoria = Program.kategoria[2];
            if (DialogResult.OK == MessageBox.Show("A kvíz elindul az OK gomb megnyomása után. A kvíz 30 másodperces. Biztonsan készen áll? ", "", MessageBoxButtons.OKCancel))
            {
                this.Hide();
                Program.form_indito.Show();
            }
            else
            {
                this.Hide();
                Program.form_profil.Show();
            }
        }

        private void novenyrendszertanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Program.Valasztott_kategoria = Program.kategoria[3];
            if (DialogResult.OK == MessageBox.Show("A kvíz elindul az OK gomb megnyomása után. A kvíz 30 másodperces. Biztonsan készen áll? ", "", MessageBoxButtons.OKCancel))
            {
                this.Hide();
                Program.form_indito.Show();
            }
            else
            {
                this.Hide();
                Program.form_profil.Show();
            }
        }

        private void kategoriakToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (mikrobiologiaToolStripMenuItem.Selected)
            {
                    
            }
        }

        private void Form_Profil_Load(object sender, EventArgs e)
        {
            AdatokBetolt();
        }

        void AdatokBetolt()
        {
            Program.sql.CommandText = "SELECT user.id, user.nev, user.felhasznalonev," +
                " user.pontszam, user.szuletesi_ido, user.email FROM user WHERE `user.id`=@user_id" +
                "`user.felhasznalonev`=@fnev";
            
            Program.sql.Parameters.Clear();

            Program.sql.Parameters.AddWithValue("@fnev", Program.user);

            try
            {
               
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "Kérdések betöltése nem sikerült.");
                return;
            }

        }
    }
}
