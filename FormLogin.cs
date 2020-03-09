using System;
using System.Drawing;
using System.Net;
using System.Windows.Forms;
using broski2._5.Properties;

namespace broski2._5
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
            acceptedPasskey = "https://pastebin.com/raw/brXFv4Cd"; // Change to passkey link if needed.
        }

        readonly WebClient webClient = new WebClient(); // Init
        readonly string acceptedPasskey; // Init
        Point lastPoint; // Init

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0); // Uh... I'll mark this as self-explanatory
        }

        private void btn_MinimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized; // I'll also mark this as self-explanatory
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            textBox.UseSystemPasswordChar = true;
        }

        private void btn_Login_Click(object sender, EventArgs e)
        {
            // Example of me being too lazy to type things out
            funcClass.Login(textBox, webClient.DownloadString(acceptedPasskey), this, false);
        }

        private void textBox_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter) // Another example of me being too lazy to type things out
                btn_Login_Click(this, new EventArgs());
        }

        private void FormLogin_Shown(object sender, EventArgs e)
        {
            if((bool)Settings.Default["AutoLogin"] == true)
                funcClass.Login(textBox, webClient.DownloadString(acceptedPasskey), this, true);
        }
    }
}
