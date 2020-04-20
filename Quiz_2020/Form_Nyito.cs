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
    public partial class Form_Nyito : Form
    {
        public Form_Nyito()
        {
            InitializeComponent();
        }

        private void button_kilepes_Click(object sender, EventArgs e)
        {
            DialogResult valasz = MessageBox.Show("Biztos ki akar lépni az alkalmazásból?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (valasz.ToString()=="Yes")
            {
                Application.Exit();
            }
        }

        private void button_regisztracio_Click(object sender, EventArgs e)
        {
            Form Regisztracio = new Form_Reg();
            Regisztracio.Show();
            
        }

        private void button_belepes_Click(object sender, EventArgs e)
        {
            Form Login = new Form_Login();
            Login.Show();
        }
}
}
