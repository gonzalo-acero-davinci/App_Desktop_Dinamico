using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;

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
                Program.form3.Hide();
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

        /* private void Conexion_Click(object sender, EventArgs e)
         {
             conexionABbdd connectionobject = new conexionABbdd();
             connectionobject.establishConnection();
         }*/

        public static int GetRandomUnusedPort()
        {
            var listener = new TcpListener(IPAddress.Loopback, 0);
            listener.Start();
            var port = ((IPEndPoint)listener.LocalEndpoint).Port;
            listener.Stop();
            return port;
        }

        const string clientID = "";
        const string clientSecret = "";
        const string authorizationEndpoint = "https://accounts.google.com/o/oauth2/v2/auth";
        const string tokenEndpoint = "https://www.googleapis.com/oauth2/v4/token";
        const string userInfoEndpoint = "https://www.googleapis.com/oauth2/v3/userinfo";
        private void button1_Click(object sender, EventArgs e)
        {
            Program.form3.Hide();
            Form3 form3 = new Form3();
            form3.Show();
        }
        public static string randomDataBase64url(uint length)
        {
            RNGCryptoServiceProvider rng = new RNGCryptoServiceProvider();
            byte[] bytes = new byte[length];
            rng.GetBytes(bytes);
            return base64urlencodeNoPadding(bytes);
        }
        public static string base64urlencodeNoPadding(byte[] buffer)
        {
            string base64 = Convert.ToBase64String(buffer);

            // Converts base64 to base64url.
            base64 = base64.Replace("+", "-");
            base64 = base64.Replace("/", "_");
            // Strips padding.
            base64 = base64.Replace("=", "");

            return base64;
        }
        public static byte[] sha256(string inputStirng)
        {
            byte[] bytes = Encoding.ASCII.GetBytes(inputStirng);
            SHA256Managed sha256 = new SHA256Managed();
            return sha256.ComputeHash(bytes);
        }

        private async void Google_Click(object sender, EventArgs e)
        {
            
                // Generates state and PKCE values.
                string state = randomDataBase64url(32);
                string code_verifier = randomDataBase64url(32);
                string code_challenge = base64urlencodeNoPadding(sha256(code_verifier));
                const string code_challenge_method = "S256";

                // Creates a redirect URI using an available port on the loopback address.
                string redirectURI = string.Format("http://{0}:{1}/", IPAddress.Loopback, GetRandomUnusedPort());


                // Creates an HttpListener to listen for requests on that redirect URI.
                var http = new HttpListener();
                http.Prefixes.Add(redirectURI);

                http.Start();

                // Creates the OAuth 2.0 authorization request.
                string authorizationRequest = string.Format("{0}?response_type=code&scope=openid%20profile&redirect_uri={1}&client_id={2}&state={3}&code_challenge={4}&code_challenge_method={5}",
                    authorizationEndpoint,
                    System.Uri.EscapeDataString(redirectURI),
                    clientID,
                    state,
                    code_challenge,
                    code_challenge_method);

                // Opens request in the browser.
                System.Diagnostics.Process.Start(authorizationRequest);

                // Waits for the OAuth authorization response.
                var context = await http.GetContextAsync();

                // Brings this app back to the foreground.
                this.Activate();

                // Sends an HTTP response to the browser.
                var response = context.Response;
                string responseString = string.Format("<html><head><meta http-equiv='refresh' content='10;url=https://google.com'></head><body>Please return to the app.</body></html>");
                var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
                response.ContentLength64 = buffer.Length;
                var responseOutput = response.OutputStream;
                Task responseTask = responseOutput.WriteAsync(buffer, 0, buffer.Length).ContinueWith((task) =>
                {
                    responseOutput.Close();
                    http.Stop();
                    Console.WriteLine("HTTP server stopped.");
                });

            }
        }
}
