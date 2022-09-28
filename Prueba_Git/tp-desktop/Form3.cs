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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Hide();
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void Register_Click(object sender, EventArgs e)
        {
            Users users = new Users();

            users.Usuario1 = Usertext.Text;
            users.Password1 = PassText.Text;
            users.Email = MailText.Text;
            users.DNI1 = DNIText.Text;
            users.ConPassword = ConPassText.Text;


            try {
                Controller control = new Controller();
                string respuesta = control.controllerRegister(users);

                if (respuesta.Length > 0)
                {
                    MessageBox.Show(respuesta, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(respuesta, "Usuario Registrado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }



            } catch (Exception ex) 
            {
                MessageBox.Show(ex.Message);
            }
            }
    } }


