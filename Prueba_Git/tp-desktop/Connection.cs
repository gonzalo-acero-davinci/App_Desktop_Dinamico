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
        public static MySqlConnection getConnection() {
            

             string server = "localhost";
             string bd = "users";
             string userbd = "root";
             string passwordbd = "root";
             string port = "3306";

            string connectionChain = "server=" + server + ";" + "port=" + port + ";" + "password=" + passwordbd + ";" + "database=" + bd + ";" + "user=" + userbd + ";";
            MySqlConnection conexion = new MySqlConnection(connectionChain);
            return conexion;

            /*public MySqlConnection establishConnection() 
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
            }*/
        }
    }
}