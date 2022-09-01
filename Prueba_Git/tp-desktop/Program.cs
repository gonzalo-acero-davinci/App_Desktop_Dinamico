using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_desktop
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        public static Form1 form1;
        public static Form2 form2;
        [STAThread]
        
        static void Main()
        {
            
            //Program.form1.Hide();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form2 = new Form2());
            //Application.Run(form1 = new Form1());
        }
    }
}
