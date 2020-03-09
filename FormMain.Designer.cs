namespace broski2._5
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.TopmostCheckBox = new System.Windows.Forms.CheckBox();
            this.changeAPILink = new System.Windows.Forms.LinkLabel();
            this.currentAPILabel = new System.Windows.Forms.Label();
            this.btn_MinimizeWindow = new FlatUI.FlatButton();
            this.btn_Exit = new FlatUI.FlatButton();
            this.wb_Monaco = new System.Windows.Forms.WebBrowser();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btn_Execute = new FlatUI.FlatButton();
            this.btn_Inject = new FlatUI.FlatButton();
            this.btn_RefreshList = new FlatUI.FlatButton();
            this.btn_OpenFile = new FlatUI.FlatButton();
            this.btn_SaveFile = new FlatUI.FlatButton();
            this.btn_Config = new FlatUI.FlatButton();
            this.btn_KillROBLOX = new FlatUI.FlatButton();
            this.btn_Clear = new FlatUI.FlatButton();
            this.AutoInjectCheckbox = new System.Windows.Forms.CheckBox();
            this.AutoInjectTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.AutoInjectCheckbox);
            this.panel1.Controls.Add(this.TopmostCheckBox);
            this.panel1.Controls.Add(this.changeAPILink);
            this.panel1.Controls.Add(this.currentAPILabel);
            this.panel1.Controls.Add(this.btn_MinimizeWindow);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(854, 35);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // TopmostCheckBox
            // 
            this.TopmostCheckBox.AutoSize = true;
            this.TopmostCheckBox.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.TopmostCheckBox.ForeColor = System.Drawing.SystemColors.Control;
            this.TopmostCheckBox.Location = new System.Drawing.Point(707, 9);
            this.TopmostCheckBox.Name = "TopmostCheckBox";
            this.TopmostCheckBox.Size = new System.Drawing.Size(78, 21);
            this.TopmostCheckBox.TabIndex = 5;
            this.TopmostCheckBox.Text = "Topmost";
            this.TopmostCheckBox.UseVisualStyleBackColor = true;
            this.TopmostCheckBox.CheckedChanged += new System.EventHandler(this.TopmostCheckBox_CheckedChanged);
            // 
            // changeAPILink
            // 
            this.changeAPILink.AutoSize = true;
            this.changeAPILink.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F);
            this.changeAPILink.LinkColor = System.Drawing.Color.Cyan;
            this.changeAPILink.Location = new System.Drawing.Point(126, 10);
            this.changeAPILink.Name = "changeAPILink";
            this.changeAPILink.Size = new System.Drawing.Size(88, 16);
            this.changeAPILink.TabIndex = 4;
            this.changeAPILink.TabStop = true;
            this.changeAPILink.Text = "Change API...";
            this.changeAPILink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.changeAPILink_LinkClicked);
            // 
            // currentAPILabel
            // 
            this.currentAPILabel.AutoSize = true;
            this.currentAPILabel.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.currentAPILabel.ForeColor = System.Drawing.Color.Firebrick;
            this.currentAPILabel.Location = new System.Drawing.Point(7, 6);
            this.currentAPILabel.Name = "currentAPILabel";
            this.currentAPILabel.Size = new System.Drawing.Size(113, 23);
            this.currentAPILabel.TabIndex = 3;
            this.currentAPILabel.Text = "Unknown API";
            this.currentAPILabel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.currentAPILabel_MouseDown);
            this.currentAPILabel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.currentAPILabel_MouseMove);
            // 
            // btn_MinimizeWindow
            // 
            this.btn_MinimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.btn_MinimizeWindow.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_MinimizeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MinimizeWindow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_MinimizeWindow.Location = new System.Drawing.Point(791, 5);
            this.btn_MinimizeWindow.Name = "btn_MinimizeWindow";
            this.btn_MinimizeWindow.Rounded = true;
            this.btn_MinimizeWindow.Size = new System.Drawing.Size(23, 25);
            this.btn_MinimizeWindow.TabIndex = 2;
            this.btn_MinimizeWindow.Text = "_";
            this.btn_MinimizeWindow.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_MinimizeWindow.UseCustomColor = false;
            this.btn_MinimizeWindow.Click += new System.EventHandler(this.btn_MinimizeWindow_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.Transparent;
            this.btn_Exit.BaseColor = System.Drawing.Color.Firebrick;
            this.btn_Exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Exit.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Exit.Location = new System.Drawing.Point(820, 5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Rounded = true;
            this.btn_Exit.Size = new System.Drawing.Size(23, 25);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "x";
            this.btn_Exit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_Exit.UseCustomColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // wb_Monaco
            // 
            this.wb_Monaco.Location = new System.Drawing.Point(8, 41);
            this.wb_Monaco.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_Monaco.Name = "wb_Monaco";
            this.wb_Monaco.Size = new System.Drawing.Size(661, 341);
            this.wb_Monaco.TabIndex = 2;
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.listBox.ForeColor = System.Drawing.SystemColors.Control;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Location = new System.Drawing.Point(675, 41);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(171, 345);
            this.listBox.TabIndex = 3;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // btn_Execute
            // 
            this.btn_Execute.BackColor = System.Drawing.Color.Transparent;
            this.btn_Execute.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_Execute.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Execute.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Execute.Location = new System.Drawing.Point(8, 390);
            this.btn_Execute.Name = "btn_Execute";
            this.btn_Execute.Rounded = true;
            this.btn_Execute.Size = new System.Drawing.Size(110, 35);
            this.btn_Execute.TabIndex = 4;
            this.btn_Execute.Text = "Execute";
            this.btn_Execute.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_Execute.UseCustomColor = false;
            this.btn_Execute.Click += new System.EventHandler(this.btn_Execute_Click);
            // 
            // btn_Inject
            // 
            this.btn_Inject.BackColor = System.Drawing.Color.Transparent;
            this.btn_Inject.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_Inject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Inject.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Inject.Location = new System.Drawing.Point(124, 390);
            this.btn_Inject.Name = "btn_Inject";
            this.btn_Inject.Rounded = true;
            this.btn_Inject.Size = new System.Drawing.Size(89, 35);
            this.btn_Inject.TabIndex = 5;
            this.btn_Inject.Text = "Inject";
            this.btn_Inject.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_Inject.UseCustomColor = false;
            this.btn_Inject.Click += new System.EventHandler(this.btn_Inject_Click);
            // 
            // btn_RefreshList
            // 
            this.btn_RefreshList.BackColor = System.Drawing.Color.Transparent;
            this.btn_RefreshList.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_RefreshList.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_RefreshList.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_RefreshList.Location = new System.Drawing.Point(675, 391);
            this.btn_RefreshList.Name = "btn_RefreshList";
            this.btn_RefreshList.Rounded = true;
            this.btn_RefreshList.Size = new System.Drawing.Size(171, 35);
            this.btn_RefreshList.TabIndex = 6;
            this.btn_RefreshList.Text = "Refresh List";
            this.btn_RefreshList.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_RefreshList.UseCustomColor = false;
            this.btn_RefreshList.Click += new System.EventHandler(this.btn_RefreshList_Click);
            // 
            // btn_OpenFile
            // 
            this.btn_OpenFile.BackColor = System.Drawing.Color.Transparent;
            this.btn_OpenFile.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_OpenFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_OpenFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_OpenFile.Location = new System.Drawing.Point(307, 391);
            this.btn_OpenFile.Name = "btn_OpenFile";
            this.btn_OpenFile.Rounded = true;
            this.btn_OpenFile.Size = new System.Drawing.Size(92, 35);
            this.btn_OpenFile.TabIndex = 7;
            this.btn_OpenFile.Text = "Open File";
            this.btn_OpenFile.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_OpenFile.UseCustomColor = false;
            this.btn_OpenFile.Click += new System.EventHandler(this.btn_OpenFile_Click);
            // 
            // btn_SaveFile
            // 
            this.btn_SaveFile.BackColor = System.Drawing.Color.Transparent;
            this.btn_SaveFile.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_SaveFile.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_SaveFile.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_SaveFile.Location = new System.Drawing.Point(405, 391);
            this.btn_SaveFile.Name = "btn_SaveFile";
            this.btn_SaveFile.Rounded = true;
            this.btn_SaveFile.Size = new System.Drawing.Size(76, 35);
            this.btn_SaveFile.TabIndex = 8;
            this.btn_SaveFile.Text = "Save File";
            this.btn_SaveFile.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_SaveFile.UseCustomColor = false;
            this.btn_SaveFile.Click += new System.EventHandler(this.btn_SaveFile_Click);
            // 
            // btn_Config
            // 
            this.btn_Config.BackColor = System.Drawing.Color.Transparent;
            this.btn_Config.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_Config.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Config.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Config.Location = new System.Drawing.Point(600, 391);
            this.btn_Config.Name = "btn_Config";
            this.btn_Config.Rounded = true;
            this.btn_Config.Size = new System.Drawing.Size(69, 35);
            this.btn_Config.TabIndex = 9;
            this.btn_Config.Text = "Config";
            this.btn_Config.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_Config.UseCustomColor = false;
            this.btn_Config.Click += new System.EventHandler(this.btn_Config_Click);
            // 
            // btn_KillROBLOX
            // 
            this.btn_KillROBLOX.BackColor = System.Drawing.Color.Transparent;
            this.btn_KillROBLOX.BaseColor = System.Drawing.Color.Firebrick;
            this.btn_KillROBLOX.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_KillROBLOX.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_KillROBLOX.Location = new System.Drawing.Point(487, 391);
            this.btn_KillROBLOX.Name = "btn_KillROBLOX";
            this.btn_KillROBLOX.Rounded = true;
            this.btn_KillROBLOX.Size = new System.Drawing.Size(107, 35);
            this.btn_KillROBLOX.TabIndex = 10;
            this.btn_KillROBLOX.Text = "Kill ROBLOX";
            this.btn_KillROBLOX.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_KillROBLOX.UseCustomColor = true;
            this.btn_KillROBLOX.Click += new System.EventHandler(this.btn_KillROBLOX_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_Clear.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_Clear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Clear.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Clear.Location = new System.Drawing.Point(219, 390);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Rounded = true;
            this.btn_Clear.Size = new System.Drawing.Size(82, 35);
            this.btn_Clear.TabIndex = 11;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_Clear.UseCustomColor = false;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // AutoInjectCheckbox
            // 
            this.AutoInjectCheckbox.AutoSize = true;
            this.AutoInjectCheckbox.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.AutoInjectCheckbox.ForeColor = System.Drawing.SystemColors.Control;
            this.AutoInjectCheckbox.Location = new System.Drawing.Point(612, 9);
            this.AutoInjectCheckbox.Name = "AutoInjectCheckbox";
            this.AutoInjectCheckbox.Size = new System.Drawing.Size(89, 21);
            this.AutoInjectCheckbox.TabIndex = 6;
            this.AutoInjectCheckbox.Text = "Auto-Inject";
            this.AutoInjectCheckbox.UseVisualStyleBackColor = true;
            this.AutoInjectCheckbox.CheckedChanged += new System.EventHandler(this.AutoInjectCheckbox_CheckedChanged);
            // 
            // AutoInjectTimer
            // 
            this.AutoInjectTimer.Tick += new System.EventHandler(this.AutoInjectTimer_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(854, 433);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_KillROBLOX);
            this.Controls.Add(this.btn_Config);
            this.Controls.Add(this.btn_SaveFile);
            this.Controls.Add(this.btn_OpenFile);
            this.Controls.Add(this.btn_RefreshList);
            this.Controls.Add(this.btn_Inject);
            this.Controls.Add(this.btn_Execute);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.wb_Monaco);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acenoid 2.5";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.Shown += new System.EventHandler(this.FormMain_Shown);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FlatUI.FlatButton btn_MinimizeWindow;
        private FlatUI.FlatButton btn_Exit;
        private System.Windows.Forms.WebBrowser wb_Monaco;
        private System.Windows.Forms.ListBox listBox;
        private FlatUI.FlatButton btn_Execute;
        private FlatUI.FlatButton btn_Inject;
        private FlatUI.FlatButton btn_RefreshList;
        private FlatUI.FlatButton btn_OpenFile;
        private FlatUI.FlatButton btn_SaveFile;
        private FlatUI.FlatButton btn_Config;
        private FlatUI.FlatButton btn_KillROBLOX;
        private System.Windows.Forms.Label currentAPILabel;
        private System.Windows.Forms.LinkLabel changeAPILink;
        private FlatUI.FlatButton btn_Clear;
        private System.Windows.Forms.CheckBox TopmostCheckBox;
        private System.Windows.Forms.CheckBox AutoInjectCheckbox;
        private System.Windows.Forms.Timer AutoInjectTimer;
    }
}