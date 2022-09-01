using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tp_desktop
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void ingresar_Click(object sender, EventArgs e)
        {
            ValidarUsuario vusuario = new ValidarUsuario();
            vusuario.iniciarSesion(textBoxUsuario.Text, textBoxContraseña.Text);
            MessageBox.Show(vusuario.resultado);

            if (vusuario.validarInicioSesion(textBoxUsuario.Text, textBoxContraseña.Text) == true) 
            {
                Program.form2.Hide();
                Form1 form1 = new Form1();
                form1.Show();

            }
            
           /* if (textBoxUsuario.Text == "gonzalo.acero@hotmail.com" && textBoxContraseña.Text == "1234")
            {
                //Login as Hardcoded User
                MessageBox.Show("Se ingreso correctamente");


            }
            else 
            {
                MessageBox.Show("Credenciales invalidas");
                this.Close();
            }
            Program.form2.Hide();
            Form1 form1 = new Form1();
            form1.Show();*/
        }
    }
}
