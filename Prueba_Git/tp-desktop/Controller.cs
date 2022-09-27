using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace tp_desktop
{
    internal class Controller
    {
        public string controllerRegister(Users usuario) 
        {
            Model model = new Model();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Usuario) || string.IsNullOrEmpty(usuario.Password) ||
                string.IsNullOrEmpty(usuario.DNI) || string.IsNullOrEmpty(usuario.
                email) || string.IsNullOrEmpty(usuario.conPassword))
            {
                respuesta = "se deben llenar todos los campos";
            }
            if (usuario.Password == usuario.conPassword)
            {
                if (model.userExists(usuario.Usuario))
                {
                    respuesta = "El usuario ya existe";
                }
                else
                {
                    usuario.Password = generarSHAU1(usuario.Password);
                    model.register(usuario);

                }
            }
            else 
            {
                respuesta = "Las contraseñas no coinciden";
            }

            return respuesta;
        }

        private string generarSHAU1(string cadena)
        {
            UTF8Encoding enc = new UTF8Encoding();
            byte[] data = enc.GetBytes(cadena);
            byte[] result;

            SHA1CryptoServiceProvider sha = new SHA1CryptoServiceProvider();


            result = sha.ComputeHash(data);


            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < result.Length; i++)
            {

                if (result[i] < 16)
                {
                    sb.Append("0");
                }
                sb.Append(result[i].ToString("x"));
            }

            return sb.ToString();
        }
    }
}


