using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_desktop
{
    internal class ValidarUsuario
    {
        public String usuario;
        public String contraseña;
        public String resultado;

     

        public ValidarUsuario()
        {
            this.usuario = "gonzalo.acero@hotmail.com";
            this.contraseña = "1234";


        }

        public String iniciarSesion(String usuario, String contraseña)
        {
            if (usuario == "gonzalo.acero@hotmail.com" && contraseña == "1234")
            {
                //Login as Hardcoded User
                resultado = "Se ingreso correctamente";


            }
            else
            {
                resultado = "Credenciales invalidas";

            }
            return resultado;
        }

        public Boolean validarInicioSesion(String usuario, String contraseña) 
        {
            if (usuario == "gonzalo.acero@hotmail.com" && contraseña == "1234")
            {
                return true;
            }

            else 
            {
                return false;
            }
        }
    }
}
