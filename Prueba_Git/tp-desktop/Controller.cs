using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace tp_desktop
{
    internal class Controller
    {
        public string controllerRegister(Users usuario)
        {
            Model model = new Model();
            string respuesta = "";

            if (string.IsNullOrEmpty(usuario.Usuario1) || string.IsNullOrEmpty(usuario.Password1) ||
                string.IsNullOrEmpty(usuario.DNI1) || string.IsNullOrEmpty(usuario.
                ConPassword) || string.IsNullOrEmpty(usuario.Email))
            {
                respuesta = "Se deben llenar todos los campos";
            }
            else
            {
                if (usuario.Password1 == usuario.ConPassword)
                {
                    if (model.userExists(usuario.Usuario1))
                    {
                        respuesta = "El usuario ya existe";
                    }
                    else
                    {
                        usuario.Password1 = generarSHA1(usuario.Password1);
                        model.register(usuario);

                    }
                }
                else
                {
                    respuesta = "Las contraseñas no coinciden";
                }

                
            }
            return respuesta;
        }

       

    public string controllerLogIn(string usuario, string password) 
    {
        Model model = new Model();
        string respuesta = "";
        Users datosuser = null;

        if (string.IsNullOrEmpty(usuario) || string.IsNullOrEmpty(password))
        {
            respuesta = "Se deben llenar todos los campos";
        }
        else 
        {
            datosuser = model.userlog(usuario);
            if (datosuser == null)
            {
                respuesta = "Credenciales Invalidas";
            }
            else 
            {
                    if (datosuser.Password1 != generarSHA1(password))
                    {
                        respuesta = "Credenciales Invalidas";
                    }
                   
            }
               
        }
            return respuesta;
        }

        private string generarSHA1(string cadena)
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



