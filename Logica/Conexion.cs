using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PollosHermanosRP.Logica
{

    class Conexion
    {
        public static string conexion = "server=localhost;user=root;database=polloshermanosdb;port=3306;password=1234";
        
        public static MySqlConnection con = new MySqlConnection(conexion);

        public static void  Abrir() {
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
        }
        public static void Cerrar()
        {
            if (con.State == ConnectionState.Open)
            {
                con.Close();
            }
        }
    }
}
