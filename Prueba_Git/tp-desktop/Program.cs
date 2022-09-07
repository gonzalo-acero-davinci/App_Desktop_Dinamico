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

            string clientId = "793072394942-5iv7b3vh0s449e97d5kl5lb47ld5lvbe.apps.googleusercontent.com";
            string clientSecret = "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";

            
        }
    }
}
