using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Quiz_2020
{
  
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
        public static Form form_reg = null;
        public static Form form_regisztracio = null;
        public static Form form_osszegzo = null;
        public static Form form_indito = null;
        public static List<Kategoria> kategoria = new List<Kategoria>();
        public static List<User> felhasznalok = new List<User>();
        public static List<Kviz> kerdesek = new List<Kviz>();
        public static List<Kviz> valaszok = new List<Kviz>();
        public static Kategoria Valasztott_kategoria;
        public static User user;

        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "bioquiz";
            sb.CharacterSet = "UTF8";
            conn = new MySqlConnection(sb.ToString());
            try
            {
                conn.Open(); 
                sql = conn.CreateCommand();
                KategoriaBetolt();    
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
            form_quiz = new Form_Quiz();
            form_reg = new Form_Reg();
            form_osszegzo = new Form1_Osszegzo();
            form_indito = new Form_indito();

            Application.Run(form_nyito);
        }


        static void KategoriaBetolt()
        {
            sql.CommandText = "SELECT `id`,`megnevezes` FROM `kategoriak`";
            using (MySqlDataReader dr = sql.ExecuteReader())
            {
                while (dr.Read())
                {
                    kategoria.Add(new Kategoria(dr.GetInt32("id"), dr.GetString("megnevezes")));
                }
            }

        }
    }
}
