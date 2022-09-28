using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tp_desktop
{
    internal class Users
    {
        int ID, id_type;
        string Usuario, Password, email, DNI, conPassword;

       

       
        public int Id_type { get => id_type; set => id_type = value; }
        public int ID1 { get => ID; set => ID = value; }
        public string Usuario1 { get => Usuario; set => Usuario = value; }
        public string Password1 { get => Password; set => Password = value; }
        public string Email { get => email; set => email = value; }
        public string DNI1 { get => DNI; set => DNI = value; }
        public string ConPassword { get => conPassword; set => conPassword = value; }
    }
}
