using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using Microsoft.Win32;
using System.Diagnostics;
using broski2._5.Properties;
using System.Threading;
using System.Timers;

namespace broski2._5
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            Thread anotherStupidVariable = new Thread(new ThreadStart(funcClass.StartSplash));
            anotherStupidVariable.Start();
            Thread.Sleep(6000);
            InitializeComponent();
            anotherStupidVariable.Abort();
        }

        CheckBox LuaCCheckBox = new CheckBox();
        Point lastPoint; // Init
        readonly string defPath = Application.StartupPath + "//Monaco//"; // Init and define
        private void addIntel(string label, string kind, string detail, string insertText)
        {
            string text = "\"" + label + "\"";
            string text2 = "\"" + kind + "\"";
            string text3 = "\"" + detail + "\"";
            string text4 = "\"" + insertText + "\"";
            wb_Monaco.Document.InvokeScript("AddIntellisense", new object[]
            {
                label,
                kind,
                detail,
                insertText
            });
        }

        private void addGlobalF()
        {
            string[] array = File.ReadAllLines(this.defPath + "//globalf.txt");
            foreach (string text in array)
            {
                bool flag = text.Contains(':');
                if (flag)
                {
                    this.addIntel(text, "Function", text, text.Substring(1));
                }
                else
                {
                    this.addIntel(text, "Function", text, text);
                }
            }
        }

        private void addGlobalV()
        {
            foreach (string text in File.ReadLines(this.defPath + "//globalv.txt"))
            {
                this.addIntel(text, "Variable", text, text);
            }
        }

        private void addGlobalNS()
        {
            foreach (string text in File.ReadLines(this.defPath + "//globalns.txt"))
            {
                this.addIntel(text, "Class", text, text);
            }
        }

        private void addMath()
        {
            foreach (string text in File.ReadLines(this.defPath + "//classfunc.txt"))
            {
                this.addIntel(text, "Method", text, text);
            }
        }

        private void addBase()
        {
            foreach (string text in File.ReadLines(this.defPath + "//base.txt"))
            {
                this.addIntel(text, "Keyword", text, text);
            }
        }

        private async void FormMain_Load(object sender, EventArgs e)
        {
            try
            {
                RegistryKey registryKey = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Internet Explorer\\Main\\FeatureControl\\FEATURE_BROWSER_EMULATION", true);
                string friendlyName = AppDomain.CurrentDomain.FriendlyName;
                bool flag2 = registryKey.GetValue(friendlyName) == null;
                if (flag2)
                {
                    registryKey.SetValue(friendlyName, 11001, RegistryValueKind.DWord);
                }
                registryKey = null;
                friendlyName = null;
            }
            catch (Exception)
            {
            }
            wb_Monaco.Url = new Uri(string.Format("file:///{0}/Monaco/Monaco.html", Directory.GetCurrentDirectory()));
            await Task.Delay(500);
            wb_Monaco.Document.InvokeScript("SetTheme", new string[]
            {
                   "Dark" 
                   /*
                    Use strings "Dark" or "Light" for theming
                   */
            });
            addBase();
            addMath();
            addGlobalNS();
            addGlobalV();
            addGlobalF();
            wb_Monaco.Document.InvokeScript("SetText", new object[]
            {
                 "-- Acenoid 2.5 by awsomequickness --"
            });
            listBox.Items.Clear();
            funcClass.PopulateListBox(listBox);
            funcClass.PopulateListBox(listBox, "./Scripts", "*.lua");
        }

        private void btn_RefreshList_Click(object sender, EventArgs e)
        {
            listBox.Items.Clear();
            funcClass.PopulateListBox(listBox);
            funcClass.PopulateListBox(listBox, "./Scripts", "*.lua");
        }

        private void btn_Inject_Click(object sender, EventArgs e) => funcClass.Inject();

        private void panel1_MouseDown(object sender, MouseEventArgs e) => lastPoint = new Point(e.X, e.Y);

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void currentAPILabel_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                Left += e.X - lastPoint.X;
                Top += e.Y - lastPoint.Y;
            }
        }

        private void currentAPILabel_MouseDown(object sender, MouseEventArgs e)
        {
            lastPoint = new Point(e.X, e.Y);
        }

        private void changeAPILink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormChangeAPI target = new FormChangeAPI();
            funcClass.GoToForm(this, target, false);
        }

        private void btn_Exit_Click(object sender, EventArgs e) => Environment.Exit(0);

        private void btn_MinimizeWindow_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void listBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox.SelectedIndex != -1)
            {
                wb_Monaco.Document.InvokeScript("SetText", new object[1]
                {
                    File.ReadAllText("Scripts\\" + (string)listBox.SelectedItem)
                });
            }
        }

        private void btn_KillROBLOX_Click(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("RobloxPlayerBeta").Length != 0)
            {
                Process[] processesByName = Process.GetProcessesByName("RobloxPlayerBeta");
                for (int i = 0; i < processesByName.Length; i++)
                    processesByName[i].Kill();
            }
            else
                MessageBox.Show("RobloxPlayerBeta does not exist.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btn_SaveFile_Click(object sender, EventArgs e)
        {
            if (funcClass.saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                Stream fStream = funcClass.saveFileDialog.OpenFile();
                StreamWriter sWriter = new StreamWriter(fStream);
                HtmlDocument document = wb_Monaco.Document;
                string scriptName = "GetText";
                object[] args = new string[0];
                object obj = document.InvokeScript(scriptName, args);
                string script = (string)obj;

                try
                {
                    sWriter.Write(script);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: Could not write to disk. Original error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                sWriter.Close();
                fStream.Close();
                MessageBox.Show("Success! Reloading listbox...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btn_OpenFile_Click(object sender, EventArgs e)
        {
            if (funcClass.openFileDialog.ShowDialog() == DialogResult.OK)
                try
                {

                    string loadedString;
                    loadedString = File.ReadAllText(funcClass.openFileDialog.FileName);
                    wb_Monaco.Document.InvokeScript("SetText", new object[]
                    {
                          loadedString
                    });

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file from disk. Original error: " + ex.Message, "Error writing", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
        }

        private void FormMain_Shown(object sender, EventArgs e)
        {
            funcClass.ConfigureAPILabel(currentAPILabel, (int)Settings.Default["APIChoice"], changeAPILink);
            
            wb_Monaco.Document.InvokeScript("SetTheme", new string[]
            {
                   "Dark" 
                   /*
                    Use strings "Dark" or "Light" for theming
                   */
            });
            addBase();
            addMath();
            addGlobalNS();
            addGlobalV();
            addGlobalF();
            wb_Monaco.Document.InvokeScript("SetText", new object[]
            {
                 "-- Acenoid 2.5 by awsomequickness --"
            });
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            wb_Monaco.Document.InvokeScript("SetText", new object[]
            {
                ""
            });
        }

        private void btn_Execute_Click(object sender, EventArgs e)
        {
            bool useCheckBox;
            if ((int)Settings.Default["APIChoice"] == 2)
                useCheckBox = true;
            else
                useCheckBox = false;
            funcClass.Execute(wb_Monaco, useCheckBox, LuaCCheckBox);
        }

        private void btn_Config_Click(object sender, EventArgs e)
        {
            string file = Application.StartupPath + "\\Acenoid2.5.exe.config";
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "notepad.exe";
            startInfo.Arguments = file;
            Process.Start(startInfo);
        }

        private void TopmostCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if(TopmostCheckBox.Checked)
            {
                TopMost = true;
            }
            if(!TopmostCheckBox.Checked)
            {
                TopMost = false;
            }
        }

        private void AutoInjectCheckbox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void AutoInjectTimer_Tick(object sender, EventArgs e)
        {
            if (Process.GetProcessesByName("RobloxPlayerBeta").Length > 0)
            {
                System.Timers.Timer t = new System.Timers.Timer();
                t.Interval = 500; // In milliseconds
                t.AutoReset = false; // Stops it from repeating
                t.Elapsed += new ElapsedEventHandler(TimerElapsed);
                t.Start();
            }
        }

        void TimerElapsed(object sender, ElapsedEventArgs e)
        {
            funcClass.Inject();
            AutoInjectCheckbox.Checked = false;
        }
    }
}
