using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace tp_desktop
{
    

    class conexionABbdd
    {
        MySqlConnection conexion = new MySqlConnection();

        static string server = "localhost";
        static string bd = "users";
        static string userbd = "root";
        static string passwordbd = "root";
        static string port = "3306";

        string connectionChain = "server=" + server + ";" + "port=" + port + ";" + "password=" + passwordbd + ";" + "database=" + bd + ";" + "user=" + userbd + ";";

        public MySqlConnection establishConnection() 
        {
            try
            {
                conexion.ConnectionString = connectionChain;
                conexion.Open();
                MessageBox.Show("Conectado correctamente");
            }
            catch (MySqlException e) 
            {
                MessageBox.Show("No se pudo conectar a bbdd" + e.ToString());
            }

            return conexion;    
        }
    }
}
