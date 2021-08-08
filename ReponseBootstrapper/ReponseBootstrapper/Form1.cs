using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Text;
using System.IO;
using System.Net;
using System.IO.Compression;
namespace ReponseBootstrapper
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private void Form1_Load(object sender, EventArgs e)
        {
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            PrivateFontCollection pfc = new PrivateFontCollection();
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string filename = "Roboto-Bold.ttf";
            string fullpath = Path.Combine(path, filename);
            Console.WriteLine(fullpath);
            pfc.AddFontFile(fullpath);
            label1.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            gunaButton3.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
            gunaButton2.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
            gunaButton1.Font = new Font(pfc.Families[0], 10, FontStyle.Regular);
            //font yükleyici sistemi götünden sikeyim programı çökertiyor başka bi alternatifi varsa yazın dm den amk sikeyim böyle işi
        }
        Point lastPoint;
        private bool inCooldown = false;
        private ReponseDownload progressBarForm = new ReponseDownload();


        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.UseVisualStyleBackColor = false;
            button1.BackColor = Color.Red;
        }

        private void button1_MouseEnter_1(object sender, EventArgs e)
        {
            button1.UseVisualStyleBackColor = false;
            button1.BackColor = Color.FromArgb(181, 66, 58);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.UseVisualStyleBackColor = false;
            button1.BackColor = Color.FromArgb(38, 37, 37);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void gunaButton3_Click(object sender, EventArgs e)
        {
            gunaButton3.Visible = false;
            gunaButton2.Visible = false;
            gunaButton1.Visible = false;


            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string specificFolderamafolderolan = Path.Combine(folder, ".reponse");

            if (!Directory.Exists(specificFolderamafolderolan))
            {
                PrivateFontCollection pfc = new PrivateFontCollection();
                string path = AppDomain.CurrentDomain.BaseDirectory;
                string filename = "Roboto-Bold.ttf";
                string fullpath = Path.Combine(path, filename);
                Console.WriteLine(fullpath);
                pfc.AddFontFile(fullpath);
                string specificFolder = Path.Combine(folder, "reponse.zip");
               WebClient webClient = new WebClient();
              webClient.DownloadFileCompleted += new AsyncCompletedEventHandler(Completed);
               webClient.DownloadProgressChanged += new DownloadProgressChangedEventHandler(ProgressChanged);
               webClient.DownloadFileAsync(new Uri("http://cdn.reponse.tk/reponse.zip"), specificFolder);
                label1.Text = "Downloading";
                label1.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
                pictureBox1.Load("https://i.hizliresim.com/ouwqs9r.png");
                pictureBox1.Visible = true;
                gunaProgressBar1.Visible = true;
            } else
            {
                alreadyinstalled already = new alreadyinstalled();
                already.Show();
                this.Hide();
            }
        }


        private void ProgressChanged(object sender, DownloadProgressChangedEventArgs e)
        {
            gunaProgressBar1.Value = e.ProgressPercentage;
        }

        private void Completed(object sender, AsyncCompletedEventArgs e)
        {
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string targetFolder = @Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string sourceZipFile = Path.Combine(folder, "reponse.zip");
            ZipFile.ExtractToDirectory(sourceZipFile, targetFolder);
            ReponseDownload form2 = new ReponseDownload();
            form2.Show();
            this.Hide();
        }


        private void gunaButton1_Click(object sender, EventArgs e)
        {
           
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
