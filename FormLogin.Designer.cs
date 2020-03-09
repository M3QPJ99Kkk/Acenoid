namespace broski2._5
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_MinimizeWindow = new FlatUI.FlatButton();
            this.btn_Exit = new FlatUI.FlatButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox = new FlatUI.FlatTextBox();
            this.btn_Login = new FlatUI.FlatButton();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.panel1.Size = new System.Drawing.Size(602, 35);
            this.panel1.TabIndex = 0;
            this.panel1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseDown);
            this.panel1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.panel1_MouseMove);
            // 
            // btn_MinimizeWindow
            // 
            this.btn_MinimizeWindow.BackColor = System.Drawing.Color.Transparent;
            this.btn_MinimizeWindow.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_MinimizeWindow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_MinimizeWindow.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_MinimizeWindow.Location = new System.Drawing.Point(544, 5);
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
            this.btn_Exit.Location = new System.Drawing.Point(573, 5);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Rounded = true;
            this.btn_Exit.Size = new System.Drawing.Size(23, 25);
            this.btn_Exit.TabIndex = 1;
            this.btn_Exit.Text = "x";
            this.btn_Exit.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_Exit.UseCustomColor = true;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(179, 24);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 227);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // textBox
            // 
            this.textBox.BackColor = System.Drawing.Color.Transparent;
            this.textBox.FocusOnHover = false;
            this.textBox.Hint = "";
            this.textBox.Location = new System.Drawing.Point(83, 242);
            this.textBox.MaxLength = 32767;
            this.textBox.Multiline = false;
            this.textBox.Name = "textBox";
            this.textBox.ReadOnly = false;
            this.textBox.Size = new System.Drawing.Size(441, 29);
            this.textBox.TabIndex = 2;
            this.textBox.Text = "Passkey";
            this.textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.textBox.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.textBox.UseSystemPasswordChar = false;
            this.textBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.textBox_KeyDown);
            this.textBox.TextChanged += new System.EventHandler(this.textBox_TextChanged);
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.Transparent;
            this.btn_Login.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(168)))), ((int)(((byte)(109)))));
            this.btn_Login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Login.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.btn_Login.Location = new System.Drawing.Point(235, 278);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Rounded = true;
            this.btn_Login.Size = new System.Drawing.Size(129, 34);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "OK";
            this.btn_Login.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_Login.UseCustomColor = false;
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(75)))), ((int)(((byte)(75)))));
            this.ClientSize = new System.Drawing.Size(602, 325);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.textBox);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Acenoid 2.5";
            this.Shown += new System.EventHandler(this.FormLogin_Shown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private FlatUI.FlatButton btn_MinimizeWindow;
        private FlatUI.FlatButton btn_Exit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private FlatUI.FlatTextBox textBox;
        private FlatUI.FlatButton btn_Login;
    }
}

