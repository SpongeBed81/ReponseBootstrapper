using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ReponseBootstrapper
{
    public partial class alreadyinstalled : Form
    {
        public alreadyinstalled()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void alreadyinstalled_Load(object sender, EventArgs e)
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
            pictureBox1.Load("https://i.hizliresim.com/ouwqs9r.png");
        }
        Point lastPoint;

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

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
