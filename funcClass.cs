using System.Windows.Forms;
using System.Drawing;
using FlatUI;
using System;
using System.IO;
using broski2._5.Properties;

namespace broski2._5
{
    class funcClass
    {
        readonly private static Random rnd = new Random();

        public static void GoToForm(Form currentForm, Form targetForm, bool hideCurrent)
        {
            if(hideCurrent)
            {
                currentForm.Hide();
                targetForm.Show();
            }
            else
                targetForm.Show();
        }

        public static void PopulateListBox(ListBox lsb, string Folder = "./Scripts", string FileType = "*.txt")
        {
            DirectoryInfo dinfo = new DirectoryInfo(Folder);
            FileInfo[] Files = dinfo.GetFiles(FileType);
            foreach (FileInfo file in Files)
            {
                lsb.Items.Add(file.Name);
            }
        }

        public static OpenFileDialog openFileDialog = new OpenFileDialog
        {
            Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*",
            FilterIndex = 1,
            RestoreDirectory = true,
            Title = "Acenoid 2.5"
        };

        public static SaveFileDialog saveFileDialog = new SaveFileDialog
        {
            InitialDirectory = Application.StartupPath + "\\Scripts",
            Title = "Acenoid 2.5",
            FilterIndex = 1,
            Filter = "Text Files (*.txt)|*.txt|All files (*.*)|*.*",
            RestoreDirectory = false
        };

        public static void ConfigureAPILabel(Label label, int APIChoice, LinkLabel linkLabel)
        {
            string EE = "Using EasyExploits API";
            string WD = "Using WeAreDevs API v2";
            string AX = "Using Axon API";

            if(APIChoice == 1)
            {
                label.Text = EE;
                Color randomColor = Color.FromArgb(255, rnd.Next(256), rnd.Next(256), rnd.Next(256));
                label.ForeColor = randomColor;
                linkLabel.Location = new Point(193, 10);
            }
            if(APIChoice == 2)
            {
                label.Text = WD;
                Color randomColor = Color.FromArgb(255, rnd.Next(256), rnd.Next(256), rnd.Next(256));
                label.ForeColor = randomColor;
                linkLabel.Location = new Point(210, 10);
            }
            if(APIChoice == 3)
            {
                label.Text = AX;
                Color randomColor = Color.FromArgb(255, rnd.Next(256), rnd.Next(256), rnd.Next(256));
                label.ForeColor = randomColor;
                linkLabel.Location = new Point(141, 10);
            }
        }

        public static void Execute(WebBrowser webBrowser1, bool useCheckBox, CheckBox checkBox)
        {
            if ((int)Settings.Default["APIChoice"] == 2)
            {
                HtmlDocument document = webBrowser1.Document;
                string scriptName = "GetText";
                object[] args = new string[0];
                object obj = document.InvokeScript(scriptName, args);
                string script = (string)obj;
                WeAreDevs.SendLimitedLuaScript(script);
            }
            if ((int)Settings.Default["APIChoice"] == 1)
            {
                HtmlDocument document = webBrowser1.Document;
                string scriptName = "GetText";
                object[] args = new string[0];
                object obj = document.InvokeScript(scriptName, args);
                string script = (string)obj;
                EasyExploits.Module api2 = new EasyExploits.Module();
                api2.ExecuteScript(script);
            }
            if ((int)Settings.Default["APIChoice"] == 3)
            {
                HtmlDocument document = webBrowser1.Document;
                string scriptName = "GetText";
                object[] args = new string[0];
                object obj = document.InvokeScript(scriptName, args);
                string script = (string)obj;
                Axon.Execute(script);
            }
        }

        public static void Inject()
        {
            if ((int)Settings.Default["APIChoice"] == 2)
            {
                WeAreDevs.LaunchExploit();
            }
            if ((int)Settings.Default["APIChoice"] == 1)
            {
                EasyExploits.Module api2 = new EasyExploits.Module();
                api2.LaunchExploit();
            }
            if ((int)Settings.Default["APIChoice"] == 3)
            {
                Axon.Inject();
            }
        }

        public static void StartSplash() => Application.Run(new splash());

        public static void Login(FlatTextBox textBox, string acceptedPasskey, Form currentForm, bool autoLogin)
        {
            if(autoLogin == true)
            {
                FormMain target = new FormMain();
                GoToForm(currentForm, target, true);
            }
            else
            {
                string enteredText = textBox.Text;
                if (enteredText == acceptedPasskey)
                {
                    FormMain target = new FormMain();
                    GoToForm(currentForm, target, true);
                }
                else
                    if (MessageBox.Show("Passkey incorrect. Please try again.", "Error", MessageBoxButtons.OKCancel, MessageBoxIcon.Error) == DialogResult.Cancel)
                    Environment.Exit(0);
            }
        }
    }
}
