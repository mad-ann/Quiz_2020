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
            DialogResult ablak = MessageBox.Show("A kvíz elindul az OK gomb megnoymása után. A kvíz 30 másodperces. Biztonsan készen áll? ", "", MessageBoxButtons.OKCancel);
            if (ablak.ToString() == "Yes")
            {
                AB ab = new AB();
                MySqlCommand command = new MySqlCommand("INSERT INTO `kategoriak`(`id`, `megnevezes`) VALUES (@id, @kategoria)", ab.GetConnection());
                

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
            DialogResult ablak = MessageBox.Show("A kvíz elindul az OK gomb megnoymása után. A kvíz 30 másodperces. Biztonsan készen áll? ", "", MessageBoxButtons.OKCancel);
            if (ablak.ToString() == "Yes")
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
            DialogResult ablak = MessageBox.Show("A kvíz elindul az OK gomb megnoymása után. A kvíz 30 másodperces. Biztonsan készen áll? ", "", MessageBoxButtons.OKCancel);
            if (ablak.ToString() == "Yes")
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
            DialogResult ablak = MessageBox.Show("A kvíz elindul az OK gomb megnoymása után. A kvíz 30 másodperces. Biztonsan készen áll? ", "", MessageBoxButtons.OKCancel);
            if (ablak.ToString() == "Yes")
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
    }
}
