using Google.Apis.Auth.OAuth2;
using Google.Apis.Gmail.v1;
using Google.Apis.Services;
using Google.Apis.Util;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Threading;
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
        public static Form2 form3;
        [STAThread]
        


        static void Main()
        {
            
            //Program.form1.Hide();
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(form3 = new Form2());
            //Application.Run(form1 = new Form1());

            
            string[] scopes = { "https://www.googleapis.com/auth/gmail.readonly" };
            var credentials = GoogleWebAuthorizationBroker.AuthorizeAsync(
                new ClientSecrets
                {
                    ClientId = clientId,
                    ClientSecret = clientSecret,
                }, 
                scopes, "user", CancellationToken.None).Result;

            if (credentials.Token.IsExpired(SystemClock.Default))
                credentials.RefreshTokenAsync(CancellationToken.None).Wait();

            var service = new GmailService(new BaseClientService.Initializer()
            {
                HttpClientInitializer = credentials
            });

            var profile = service.Users.GetProfile("gonzalo.acero@davinci.edu.ar").Execute();
            Console.WriteLine(profile.MessagesTotal);
            Console.ReadLine();
            

        }

        const string clientId = "";
        const string clientSecret = "";
        


    }
}
