using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace tp_desktop
{
    internal class Model
    {
        public int register(Users users) 
        {
            MySqlConnection conexion = conexionABbdd.getConnection();
            conexion.Open();

            string sql = "INSERT INTO User (Usuario, Password, email, DNI, id_type) VALUES (@Usuario, @Password, @email, @DNI, @id_type)";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Usuario",users.Usuario1);
            comando.Parameters.AddWithValue("@Password", users.Password1);
            comando.Parameters.AddWithValue("@email", users.Email);
            comando.Parameters.AddWithValue("@DNI", users.DNI1);
            comando.Parameters.AddWithValue("@id_type", 1);

            int resultado = comando.ExecuteNonQuery();

            return resultado;

            
        }
        public bool userExists(string usuario) 
        {
            MySqlDataReader reader;
            
            MySqlConnection conexion = conexionABbdd.getConnection();
            conexion.Open();

            string sql = "SELECT ID from user WHERE Usuario LIKE @Usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Usuario", usuario);

            reader = comando.ExecuteReader();

            if (reader.HasRows)
            {
                return true;
            }
            else 
            {
                return false;
            }
        }

        public Users userlog(string usuario)
        {
            MySqlDataReader reader;

            MySqlConnection conexion = conexionABbdd.getConnection();
            conexion.Open();

            string sql = "SELECT ID, Password, DNI, email from user WHERE Usuario LIKE @Usuario";
            MySqlCommand comando = new MySqlCommand(sql, conexion);
            comando.Parameters.AddWithValue("@Usuario", usuario);

            reader = comando.ExecuteReader();

           Users usr = null;

            while (reader.Read()) 
            {
                usr = new Users();
                usr.ID1 = int.Parse(reader["ID"].ToString());
                usr.Password1 = reader["Password"].ToString();
                usr.DNI1 = reader["DNI"].ToString();
                usr.Email = reader["email"].ToString(); 
            }

            return usr;


        }
    }
}
