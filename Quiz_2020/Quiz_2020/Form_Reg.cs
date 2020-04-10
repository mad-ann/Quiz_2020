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
    public partial class Form_Reg : Form
    {
        public Form_Reg()
        {
            InitializeComponent();
        }

        private void button_reg_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_nyito.Show();
        }

        private void kezdőlapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztos félbeszakítja a regisztráicót? Félbeszakítás esetén az adatai el fognak veszni.", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz.ToString() == "Yes")
            {
                Application.Exit();
            }
            
            this.Hide();
            Program.form_nyito.Show();
        }

        private void kilépésToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztos kilép az alkalmazásból?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz.ToString() == "Yes")
            {
                Application.Exit();
            }
        }
    }
}
