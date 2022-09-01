using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace tp_desktop
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = "D:\\";
            openFileDialog1.Filter = "Arhivo de entrada (*.mp4)|*.mp4|avi files(.avi)|.avi | mpeg files(.mpeg) |.mpeg | flv files(.flv) |.flv | All files(.) |.";
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string str_RutaArchivo = openFileDialog1.FileName;
                        textBox1.Text = str_RutaArchivo;
                    }

                    catch (Exception)
                    {
                        throw;
                    }
                }
            }
        }

        private void openFileDialog1_FileOk(object sender, CancelEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String r;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Seleccione un archivo");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Debe escoger un nombre para el archivo");
            }
            else if (checkBox1.Checked)
            {
                r = ruta();
                convertirArchivo(textBox1.Text, checkBox1.Text, r, textBox2.Text);
            }
            else if (checkBox2.Checked)
            {
                r = ruta();
                convertirArchivo(textBox1.Text, checkBox2.Text, r, textBox2.Text);
            }
            else if (checkBox3.Checked)
            {

                r = ruta();
                convertirArchivo(textBox1.Text, checkBox3.Text, r, textBox2.Text);
            }
            else if (checkBox4.Checked)
            {

                r = ruta();
                convertirArchivo(textBox1.Text, checkBox4.Text, r, textBox2.Text);
            }
            else 
            {
                MessageBox.Show("Tiene que seleccionar una opcion");
            }
        }

        public String ruta() 
        {
            String rutas = "";
            FolderBrowserDialog folder = new FolderBrowserDialog();
            if (folder.ShowDialog() == DialogResult.OK) 
                {
                    folder.Description = "Guardar en ";
                    rutas = folder.SelectedPath;
                }
            return rutas;
        }
        
        public void convertirArchivo (String archivo, String formato, String ruta, String nuevoNombre )
        {
            // string archivo string ruta string nuevoNombre string formato
            //String comando = $"/c ffmpeg -i {archivo} {archivo}.{ruta} ";
            String comando = $"/c ffmpeg -i {archivo} {ruta}\\{nuevoNombre}.{formato} ";
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = comando;
            process.StartInfo = startInfo;
            process.Start();
            Console.WriteLine(comando);

            MessageBox.Show("Archivo convertido con exito");
            textBox1.Text = comando;
            textBox2.Text = "";

        }

        public void cambiar_Formato_Click_1(object sender, EventArgs e) 
        {
            String r;

            if (textBox1.Text == "")
            {
                MessageBox.Show("Seleccione un archivo");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Debe escoger un nombre para el archivo");
            }
            else if (checkBox1.Checked)
            {
                r = ruta();
                convertirArchivo(textBox1.Text, checkBox1.Text, r, textBox2.Text);
            }
            else if (checkBox2.Checked)
            {
                r = ruta();
                convertirArchivo(textBox1.Text, checkBox2.Text, r, textBox2.Text);
            }
            else if (checkBox3.Checked)
            {

                r = ruta();
                convertirArchivo(textBox1.Text, checkBox3.Text, r, textBox2.Text);
            }
            else if (checkBox4.Checked) 
            {

                r = ruta();
                convertirArchivo(textBox1.Text, checkBox4.Text, r, textBox2.Text);
            }
            else
            {
                MessageBox.Show("Tiene que seleccionar una opcion");
            }

        }

        public void convertirArchivoAMp3(String archivo, String ruta, String nuevoNombre)
        {

            String comando = $"/c ffmpeg -i {archivo} {ruta}\\{nuevoNombre}.mp3 ";
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = comando;
            process.StartInfo = startInfo;
            process.Start();
            Console.WriteLine(comando);

            MessageBox.Show("Archivo convertido con exito");
            textBox1.Text = comando;
            textBox2.Text = "";
        }


        private void button4_Click(object sender, EventArgs e)
        {
            String r;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Seleccione un archivo");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Debe escoger un nombre para el archivo");
            }
            else 
            {
                r = ruta();
                convertirArchivoAMp3(textBox1.Text, r, textBox2.Text);
            }
        }
        
        
        
        public void videoSinAudio(String archivo, String ruta, String nuevoNombre, String formato)
        {
            String comando = $"/c ffmpeg -i {archivo} -c copy -an {ruta}\\{nuevoNombre}.{formato} ";
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = comando;
            process.StartInfo = startInfo;
            process.Start();
            Console.WriteLine(comando);

            MessageBox.Show("Video sin audio completo");
            textBox1.Text = comando;
            textBox2.Text = "";
        }
        
        
        private void button3_Click(object sender, EventArgs e)
        {
            String r;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Seleccine un archivo");

            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Debe escoger un nombre para el archivo");
            }
            else 
            {
                r = ruta();
                videoSinAudio(textBox1.Text, r, textBox2.Text, "mp4");
            }
        }


        public void cambiarResolucion(String archivo, String resolucion, String nuevoNombre,String ruta, String formato) 
        {
            String comando = $"/c ffmpeg -i {archivo} -vf scale={resolucion} {ruta}\\{nuevoNombre}.{formato}";
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = comando;
            process.StartInfo = startInfo;
            process.Start();
            Console.WriteLine(comando);

            MessageBox.Show("Video cambiado de resolucion");
            textBox1.Text = comando;
            textBox2.Text = "";
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            String r;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Seleccine un archivo");
            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Debe escoger un nombre para el archivo");
            }
            else if (checkBox5.Checked) 
            {
                r = ruta();
                cambiarResolucion(textBox1.Text, checkBox5.Text, textBox2.Text, r, "mp4");
            }
            else if (checkBox6.Checked)
            {
                r = ruta();
                cambiarResolucion(textBox1.Text, checkBox6.Text, textBox2.Text, r, "mp4");
            }
            else if (checkBox7.Checked)
            {
                r = ruta();
                cambiarResolucion(textBox1.Text, checkBox7.Text, textBox2.Text, r, "mp4");
            }
            else if (checkBox8.Checked)
            {
                r = ruta();
                cambiarResolucion(textBox1.Text, checkBox8.Text, textBox2.Text, r,"mp4");
            }

        }

        public void extraerFrame(String archivo, String ruta, String tiempo, String nuevoNombre) 
        {
            String comando = $"/c ffmpeg -i {archivo} -ss {tiempo} {nuevoNombre}\\{ruta}.png ";
            Process process = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.FileName = "cmd.exe";
            startInfo.Arguments = comando;
            process.StartInfo = startInfo;
            process.Start();
            Console.WriteLine(comando);

            MessageBox.Show("Frame capturado con exito");
            textBox1.Text = comando;
            textBox2.Text = "";
            textBox3.Text = "00:00:00";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            String r;
            if (textBox1.Text == "")
            {
                MessageBox.Show("Seleccine un archivo");

            }
            else if (textBox2.Text == "")
            {
                MessageBox.Show("Debe escoger un nombre para el archivo");
            }
            else if (textBox3.Text == "") 
            {
                MessageBox.Show("Debe escoger el tiempo, ej: 00:00:00");
            }
            else
            {
                r = ruta();
                extraerFrame(textBox1.Text, textBox2.Text, textBox3.Text, r);
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            //this.Close();
            Application.Exit();
            
        }
    }
}

