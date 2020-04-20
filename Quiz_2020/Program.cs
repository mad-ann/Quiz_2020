using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quiz_2020
{
   
    

    public class Kategoria
    {
        private List<Kategoria> kategoriak;

        public int id
        {
            get { return id; }
            set { id = value; }
        }

        public string megnevezes
        {
            get { return megnevezes; }
            set { megnevezes = value; }
        }

        public List<Kategoria> Kategoriak { get; set; }

    }

   

    public class Kerdes
    {
        public int id {
            get { return id; }
            set { id = value; }
        }

        public string szoveg {
            get { return szoveg; }
            set { szoveg = value; }
        }

        public int kategoria_id
        {
            get { return kategoria_id; }
            set { kategoria_id = value; }
        }

        /*public List<Kerdes> kerdesek { get; set; }
        int k;
        Random rand = new Random();

        public Kerdes()
        {
            kerdesek = new List<Kerdes>;
            k = 0;
        }
        public Kerdes GetKerdes()
        {
            int k = rand.Next() % Kerdes.Count;
            return Kerdes[k];
        }*/
    }

    public class Valasz
    {
        public int id
        {
            get { return id; }
            set { id = value; }
        }

        public int kerdes_id
        {
            get { return kerdes_id; }
            set { kerdes_id = value; }
        }
        public int valasz
        {
            get { return valasz; }
            set { valasz = value; }
        }

        public enum helyes { };

    }

    static class Program
    {
        /// <summary>
        /// Madarász Anna
        /// 
        /// 
        /// 
        /// </summary>
       
        public static MySqlConnection conn = null;
        public static MySqlCommand sql = null;
        public static Form form_nyito = null;
        public static Form form_login = null;
        public static Form form_profil = null;
        public static Form form_quiz = null;
        public static Form form_regisztracio = null;
        public static Form form_osszegzo = null;
        public static Form form_indito = null;

        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "quizz";
            sb.CharacterSet = "UTF8";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open(); 
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            
            
            form_login = new Form_Login();
            form_nyito = new Form_Nyito();
            form_profil = new Form_Profil();
            form_profil = new Form_Quiz();
            form_profil = new Form_Reg();
            form_profil = new Form1_Osszegzo();
            form_indito = new Form1_indito();

            Application.Run(form_nyito);
        }
    }
}
