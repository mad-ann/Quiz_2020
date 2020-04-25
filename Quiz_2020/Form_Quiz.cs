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
        
        public Form_Quiz()
        {
            InitializeComponent();
        }

        
        
        private void Form_Quiz_Load(object sender, EventArgs e)
        {

            KerdesBetolt();
            label_kat_TextChange();
            KerdesValasz();
            
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
                }

                else
                {
                    if (Program.Valasztott_kategoria == Program.kategoria[1])
                    {

                        label_kat.Text = "Immunológia";
                    }
                    else
                    {
                        if (Program.Valasztott_kategoria == Program.kategoria[2])
                        {

                            label_kat.Text = "Biokémia";
                        }
                        else
                        {
                            if (Program.Valasztott_kategoria == Program.kategoria[3])
                            {

                                label_kat.Text = "Növényrendszertan";
                            }
                            else
                            {
                                label_kat.Text = "Hiba";
                            }
                        }
                    }
                }
            }
            
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "Kérdések betöltése nem sikerült.");
                return;
            }
        }

        void KerdesBetolt()
        {
            Program.sql.CommandText = "SELECT kerdes.id, kerdes.szoveg, kerdes.kategoria_id," +
                " valasz.id AS valaszid, valasz.valasz, valasz.helyes FROM kerdes JOIN valasz " +
                "ON kerdes.id=valasz.kerdes_id" +
                " WHERE `kategoria_id` = @kategoria_id";
            Program.sql.Parameters.Clear();

            Program.sql.Parameters.AddWithValue("@kategoria_id", Program.Valasztott_kategoria);

            try
            {
                int kerdes=0;
                Kviz uj = new Kviz();
                
                using (MySqlDataReader dr=Program.sql.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        
                        if (kerdes==dr.GetInt32("id"))
                        {
                            uj.Valaszok.Add(new Valasz(dr.GetInt32("valaszid"), dr.GetString("valasz"), dr.GetInt32("id"), dr.GetString("helyes")));
                        }
                        else
                        {
                            uj = new Kviz();
                            uj.Id = dr.GetInt32("id");
                            uj.Szoveg = dr.GetString("szoveg");
                            uj.Valaszok.Add(new Valasz(dr.GetInt32("valaszid"), dr.GetString("valasz"), dr.GetInt32("id"), dr.GetString("helyes")));
                            kerdes = dr.GetInt32("id");
;                        }
                    }  
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "Kérdések betöltése nem sikerült.");
                return;
            }
        }

        void KerdesValasz()
        {
            Program.sql.CommandText = "SELECT kerdes.id, kerdes.szoveg, kerdes.kategoria_id," +
                   " valasz.id AS valaszid, valasz.valasz, valasz.helyes FROM kerdes JOIN valasz " +
                   "ON kerdes.id=valasz.kerdes_id" +
                   " WHERE `kategoria_id` = @kategoria_id ORDER BY kerdes_id";
            Program.sql.Parameters.Clear();
            Program.sql.Parameters.AddWithValue("@kategoria_id", Program.Valasztott_kategoria);
            try
            {
                Random r = new Random();
                Kviz teszt = new Kviz();
                int Random = r.Next();
                using (MySqlDataReader dr = Program.sql.ExecuteReader())
                {
                    int kerdes_id = -1;
                    while (dr.Read())
                    {
                        if (kerdes_id != dr.GetInt32("id"))
                        {

                            kerdes_id = dr.GetInt32("id");
                            teszt.Kerdesek.Add(new Kerdes(dr.GetInt32("id"), dr.GetString("szoveg"), dr.GetInt32("kategoria_id")));

                        }

                        teszt.Kerdesek.vala
                    }

                    if (Program.Valasztott_kategoria == Program.kategoria[1]
                        )
                    {
                        for (int i = 0; i < teszt.Kerdesek.Count; i++)
                        {
                            teszt.Kategoria_id = 1;
                            //kerdes.Id[i] = i + 1;
                            KerdesBetolt();
                            textBox_kerdes.Text = Random.ToString(teszt.Szoveg);
                        }
                    }

                       
                    
                    
                    
                }

            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message + "Kérdések betöltése nem siekrült.");
                return;
            }
        }

        
    }

    internal struct NewStruct
    {
        public string Item1;
        public Kategoria Valasztott_kategoria;

        public NewStruct(string item1, Kategoria valasztott_kategoria)
        {
            Item1 = item1;
            Valasztott_kategoria = valasztott_kategoria;
        }

        public override bool Equals(object obj)
        {
            return obj is NewStruct other &&
                   Item1 == other.Item1 &&
                   EqualityComparer<Kategoria>.Default.Equals(Valasztott_kategoria, other.Valasztott_kategoria);
        }

        public override int GetHashCode()
        {
            int hashCode = 888787176;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Item1);
            hashCode = hashCode * -1521134295 + EqualityComparer<Kategoria>.Default.GetHashCode(Valasztott_kategoria);
            return hashCode;
        }

        public void Deconstruct(out string item1, out Kategoria valasztott_kategoria)
        {
            item1 = Item1;
            valasztott_kategoria = Valasztott_kategoria;
        }

        public static implicit operator (string, Kategoria Valasztott_kategoria)(NewStruct value)
        {
            return (value.Item1, value.Valasztott_kategoria);
        }

        public static implicit operator NewStruct((string, Kategoria Valasztott_kategoria) value)
        {
            return new NewStruct(value.Item1, value.Valasztott_kategoria);
        }
    }
}
