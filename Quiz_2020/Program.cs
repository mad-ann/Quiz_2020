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
       
        static MySqlConnection conn = null;
        static MySqlCommand sql = null;

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
                conn.Open(); //-- K
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form_Nyito());
        }
    }
}
