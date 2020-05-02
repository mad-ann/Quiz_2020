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
    public partial class Form_indito : Form
    {
        public Form_indito()
        {
            InitializeComponent();
        }

        private void button_megsem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Program.form_nyito.Show();
        }

        private void button_ok_Click(object sender, EventArgs e)
        {

            this.Hide();
            Program.form_quiz.ShowDialog();
        }

        
    }
}
