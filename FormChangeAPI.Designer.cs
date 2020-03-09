namespace broski2._5
{
    partial class FormChangeAPI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangeAPI));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_MinimizeWindow = new FlatUI.FlatButton();
            this.btn_Exit = new FlatUI.FlatButton();
            this.listBox = new System.Windows.Forms.ListBox();
            this.btn_Use = new FlatUI.FlatButton();
            this.Description = new System.Windows.Forms.RichTextBox();
            this.APIIcon = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.APIIcon)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.panel1.Controls.Add(this.btn_MinimizeWindow);
            this.panel1.Controls.Add(this.btn_Exit);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(619, 35);
            this.panel1.TabIndex = 1;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btn_MinimizeWindow
            // 
            this.btn_MinimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.btn_MinimizeWindow.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_MinimizeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MinimizeWindow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_MinimizeWindow.Location = new System.Drawing.Point(560, 5);
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
            this.btn_Exit.Location = new System.Drawing.Point(589, 5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Rounded = true;
            this.btn_Exit.Size = new System.Drawing.Size(23, 25);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "x";
            this.btn_Exit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_Exit.UseCustomColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // listBox
            // 
            this.listBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.listBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox.Font = new System.Drawing.Font("Segoe UI", 9.25F);
            this.listBox.ForeColor = System.Drawing.SystemColors.Control;
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 15;
            this.listBox.Items.AddRange(new object[] {
            "EasyExploits API",
            "Axon API",
            "WeAreDevs API v2"});
            this.listBox.Location = new System.Drawing.Point(8, 45);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(188, 345);
            this.listBox.TabIndex = 2;
            this.listBox.SelectedIndexChanged += new System.EventHandler(this.listBox_SelectedIndexChanged);
            // 
            // btn_Use
            // 
            this.btn_Use.BackColor = System.Drawing.Color.Transparent;
            this.btn_Use.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_Use.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Use.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Use.Location = new System.Drawing.Point(308, 355);
            this.btn_Use.Name = "btn_Use";
            this.btn_Use.Rounded = true;
            this.btn_Use.Size = new System.Drawing.Size(192, 35);
            this.btn_Use.TabIndex = 5;
            this.btn_Use.Text = "Use";
            this.btn_Use.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_Use.UseCustomColor = false;
            this.btn_Use.Click += new System.EventHandler(this.btn_Use_Click);
            // 
            // Description
            // 
            this.Description.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.Description.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Description.Font = new System.Drawing.Font("Segoe UI", 12.25F);
            this.Description.ForeColor = System.Drawing.SystemColors.Control;
            this.Description.Location = new System.Drawing.Point(202, 137);
            this.Description.Name = "Description";
            this.Description.Size = new System.Drawing.Size(405, 212);
            this.Description.TabIndex = 6;
            this.Description.Text = "(Please choose an API from the list)";
            // 
            // APIIcon
            // 
            this.APIIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(69)))), ((int)(((byte)(69)))));
            this.APIIcon.Image = global::broski2._5.Properties.Resources.placeholder;
            this.APIIcon.Location = new System.Drawing.Point(202, 45);
            this.APIIcon.Name = "APIIcon";
            this.APIIcon.Size = new System.Drawing.Size(405, 86);
            this.APIIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.APIIcon.TabIndex = 3;
            this.APIIcon.TabStop = false;
            // 
            // FormChangeAPI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(619, 400);
            this.Controls.Add(this.Description);
            this.Controls.Add(this.btn_Use);
            this.Controls.Add(this.APIIcon);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormChangeAPI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acenoid 2.5";
            this.Load += new System.EventHandler(this.FormChangeAPI_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.APIIcon)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FlatUI.FlatButton btn_MinimizeWindow;
        private FlatUI.FlatButton btn_Exit;
        private System.Windows.Forms.ListBox listBox;
        private System.Windows.Forms.PictureBox APIIcon;
        private FlatUI.FlatButton btn_Use;
        private System.Windows.Forms.RichTextBox Description;
    }
}