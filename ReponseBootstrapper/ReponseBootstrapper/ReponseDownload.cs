using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IWshRuntimeLibrary;
using CSharpLib;
namespace ReponseBootstrapper
{
    public partial class ReponseDownload : Form
    {
        public ReponseDownload()
        {
            InitializeComponent();
            //string folder = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
           // CreateShortcutToCurrentAssembly(folder);
        }


       
        private void ReponseDownload_Load(object sender, EventArgs e)
        {
            PrivateFontCollection pfc = new PrivateFontCollection();
            string path = AppDomain.CurrentDomain.BaseDirectory;
            string filename = "Roboto-Bold.ttf";
            string fullpath = Path.Combine(path, filename);
            Console.WriteLine(fullpath);
            pfc.AddFontFile(fullpath);
            label1.Font = new Font(pfc.Families[0], 15, FontStyle.Regular);
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            pictureBox1.Load("https://i.hizliresim.com/ouwqs9r.png");
            CSharpLib.Shortcut shortcut = new CSharpLib.Shortcut();
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string specificFolderamafolderolan = Path.Combine(folder, ".reponse");
            string specificFolderamafolderolan2 = Path.Combine(specificFolderamafolderolan, "reponse-win32-ia32-v0.3");
            string specificFolderamafolderolan3 = Path.Combine(specificFolderamafolderolan2, "reponse.exe");
            string pathbruh = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string combinetogether = Path.Combine(pathbruh, "Reponse.lnk");
            shortcut.CreateShortcutToFile(specificFolderamafolderolan3, combinetogether);
            string apppath = System.Reflection.Assembly.GetEntryAssembly().Location;
            string combinetogether2 = Path.Combine(pathbruh, "ReponseUpdater.lnk");
            Console.WriteLine(apppath);
            shortcut.CreateShortcutToFile(apppath, combinetogether2);
        }
        Point lastPoint;

    
        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Left += e.X - lastPoint.X;
                this.Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            button1.UseVisualStyleBackColor = false;
            button1.BackColor = Color.FromArgb(181, 66, 58);
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.UseVisualStyleBackColor = false;
            button1.BackColor = Color.FromArgb(38, 37, 37);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            //reponse-win32-ia32-v0.3
            string folder = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            string specificFolderamafolderolan = Path.Combine(folder, ".reponse");
            string specificFolderamafolderolan2 = Path.Combine(specificFolderamafolderolan, "reponse-win32-ia32-v0.3");
            string specificFolderamafolderolan3 = Path.Combine(specificFolderamafolderolan2, "reponse.exe");
            Process.Start(specificFolderamafolderolan3);
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void gunaButton2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
