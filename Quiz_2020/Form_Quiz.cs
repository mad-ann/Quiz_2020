using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
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
        
        public Form_Quiz()
        {
            InitializeComponent();
        }

        
        
        private void Form_Quiz_Load(object sender, EventArgs e)
        {
            
            AB ab = new AB();

            Kategoria kategoria = new Kategoria();
            DataTable table = new DataTable();
            MySqlDataAdapter adapter = new MySqlDataAdapter();
            adapter.SelectCommand = new MySqlCommand("INSERT INTO `kategoriak`(`id`, `megnevezes`) VALUES (@id, @megnevezes)", ab.GetConnection());

            DataSet dataSet = new DataSet();
            adapter.Fill(dataSet);

            
            
            
        }

        private void kilepesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztos ki akar lépni az alkalmazásból?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz.ToString() == "Yes")
            {
                Application.Exit();
            }
        }

        private void button_befejezes_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztosan kilép a kvízből? A most elért pontjai el fognak veszni!", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz.ToString() == "Yes")
            {
                Application.Exit();
            }

            this.Hide();
            Program.form_nyito.Show();
        }

        private void profilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztos félbeszakítja a kvízt? A megszerzett pontjai el fognak veszni.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz.ToString() == "Yes")
            {
                Application.Exit();
            }

            this.Hide();
            Program.form_profil.Show();
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

        
        
    }
}
