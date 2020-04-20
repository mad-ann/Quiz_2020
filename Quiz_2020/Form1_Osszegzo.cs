using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Quiz_2020
{
    public partial class Form1_Osszegzo : Form
    {
        public Form1_Osszegzo()
        {
            InitializeComponent();
        }

        private void button_kezdolap_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_nyito.Show();
        }

        private void button_kilepes_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztos kilépsz az alkalmazásból?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz.ToString() == "Yes")
            {
                Application.Exit();
            }
        }
    }
}
