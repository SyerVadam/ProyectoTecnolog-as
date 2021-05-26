using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AplicacionEscritorioMunicipio.Modelo.bd
{
    class ConexionBD
    {
        private static String SERVER = "192.168.100.168";
        private static String PORT = "1433";
        private static String DATABASE = "GRSV";
        private static String USER = "GRSVAdmin";
        private static String PASSWORD = "0000";

        public static SqlConnection getConnection()
        {
            SqlConnection conn = null;
            try
            {
                String urlconn = String.Format("Data Source = {0}, {1}; Initial Catalog = {2}; Persist Security Info = True; User ID = {3}; Password = {4}", SERVER, PORT, DATABASE, USER, PASSWORD);
                conn = new SqlConnection(urlconn);
                conn.Open();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            return conn;
        }
    }
}
