using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using broski2._5.Properties;

namespace broski2._5
{
    public partial class FormChangeAPI : Form
    {
        public FormChangeAPI()
        {
            InitializeComponent();
        }

        readonly string EEDescription = "- EasyExploits API - \n\n The EasyExploits API is the recommended API for use with Acenoid. \n (ID = 1)"; // Init and define
        readonly string WDDescription = "- WeAreDevs API v2 - \n\n The WeAreDevs API v2 is a powerful C++ ROBLOX exploit API. Compatible with Lua C. \n (ID = 2)"; // Init and define
        readonly string AXDescription = "- Axon API - \n\n The Bloxsploits API is a average open-source API by rakion99. \n (ID = 3)"; // Init and define
        readonly string EEEntry = "EasyExploits API"; // Init and define
        readonly string WDEntry = "WeAreDevs API v2"; // Init and define
        readonly string AXEntry = "Axon API"; // Init and define
        readonly string succ = "Success saving! Please restart Acenoid."; // Init and define
        readonly string place_text = "(Please choose an API from the list)"; // Init and define

        readonly Bitmap place_image = Resources.placeholder; // Init and define

        readonly int EEPosition = 1; // Init and define
        readonly int WDPosition = 2; // Init and define
        readonly int AXPosition = 3; // Init and define

        Point lastPoint; // Init

        private void FormChangeAPI_Load(object sender, EventArgs e)
        {
            APIIcon.Image = place_image;
            Description.Text = place_text;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if((string)listBox.SelectedItem == EEEntry)
            {
                APIIcon.Image = Resources.EEIcon;
                Description.Text = EEDescription;
            }
            if((string)listBox.SelectedItem == WDEntry)
            {
                APIIcon.Image = Resources.WDIcon;
                Description.Text = WDDescription;
            }
            if((string)listBox.SelectedItem == AXEntry)
            {
                APIIcon.Image = Resources.AXIcon;
                Description.Text = AXDescription;
            }
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void btn_Use_Click(object sender, EventArgs e)
        {
            if ((string)listBox.SelectedItem == EEEntry)
            {
                try
                {
                    Settings.Default["APIChoice"] = EEPosition;
                    Settings.Default.Upgrade();
                    Settings.Default.Save();
                    Settings.Default.Upgrade();
                    Description.Text = succ;
                    MessageBox.Show("Finished saving! Please restart Acenoid. Selected option as ID: " + Settings.Default["APIChoice"] + ". Is this not correct? If so, then please change manually using the config option.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                APIIcon.Image = Resources.EEIcon;
            }
            if ((string)listBox.SelectedItem == WDEntry)
            {
                try
                {
                    Settings.Default["APIChoice"] = WDPosition;
                    Settings.Default.Upgrade();
                    Settings.Default.Save();
                    Settings.Default.Upgrade();
                    MessageBox.Show("Finished saving! Please restart Acenoid. Selected option as ID: " + Settings.Default["APIChoice"] + ". Is this not correct? If so, then please change manually using the config option.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Description.Text = succ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                APIIcon.Image = Resources.WDIcon;
            }
            if ((string)listBox.SelectedItem == AXEntry)
            {
                try
                {
                    Settings.Default["APIChoice"] = AXPosition;
                    Settings.Default.Upgrade();
                    Settings.Default.Save();
                    Settings.Default.Upgrade();
                    MessageBox.Show("Finished saving! Please restart Acenoid. Selected option as ID: " + Settings.Default["APIChoice"] + ". Is this not correct? If so, then please change manually using the config option.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Description.Text = succ;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error");
                }
                APIIcon.Image = Resources.AXIcon;
            }
            if (listBox.SelectedItem == null)
                MessageBox.Show("Please choose an item from the list first!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_MinimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

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
    }
}
