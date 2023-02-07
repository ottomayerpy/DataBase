namespace DataBase
{
    partial class Form_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Login));
            this.ButtonLogin = new System.Windows.Forms.Button();
            this.ComboBoxServer = new System.Windows.Forms.ComboBox();
            this.ButtonReg = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.ImageTitle = new System.Windows.Forms.PictureBox();
            this.ButtonMinimize = new System.Windows.Forms.PictureBox();
            this.ButtonClose = new System.Windows.Forms.PictureBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.ToolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBoxLogin = new System.Windows.Forms.GroupBox();
            this.LinkLabelPasswordRecovery = new System.Windows.Forms.LinkLabel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.ButtonRegistr = new System.Windows.Forms.Button();
            this.GroupBoxReg = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.TxtNewSubname = new System.Windows.Forms.TextBox();
            this.TxtNewName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TxtNewPassword = new System.Windows.Forms.TextBox();
            this.TxtNewLogin = new System.Windows.Forms.TextBox();
            this.ImageBD = new System.Windows.Forms.PictureBox();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            this.GroupBoxLogin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.GroupBoxReg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBD)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonLogin.Enabled = false;
            this.ButtonLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonLogin.Location = new System.Drawing.Point(25, 71);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(85, 23);
            this.ButtonLogin.TabIndex = 3;
            this.ButtonLogin.Text = "Войти";
            this.ButtonLogin.UseVisualStyleBackColor = false;
            this.ButtonLogin.Click += new System.EventHandler(this.ButtonLogin_Click);
            // 
            // ComboBoxServer
            // 
            this.ComboBoxServer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxServer.FormattingEnabled = true;
            this.ComboBoxServer.Location = new System.Drawing.Point(12, 144);
            this.ComboBoxServer.Name = "ComboBoxServer";
            this.ComboBoxServer.Size = new System.Drawing.Size(245, 21);
            this.ComboBoxServer.TabIndex = 0;
            this.ToolTipHelp.SetToolTip(this.ComboBoxServer, "Выбор сервера");
            this.ComboBoxServer.SelectedIndexChanged += new System.EventHandler(this.ComboBoxServer_SelectedIndexChanged);
            this.ComboBoxServer.TextChanged += new System.EventHandler(this.ButtonLoginActive);
            // 
            // ButtonReg
            // 
            this.ButtonReg.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonReg.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonReg.Location = new System.Drawing.Point(145, 33);
            this.ButtonReg.Name = "ButtonReg";
            this.ButtonReg.Size = new System.Drawing.Size(98, 23);
            this.ButtonReg.TabIndex = 40;
            this.ButtonReg.Text = "Регистрация";
            this.ButtonReg.UseVisualStyleBackColor = false;
            this.ButtonReg.Click += new System.EventHandler(this.ButtonReg_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.White;
            this.PanelMenu.Controls.Add(this.ImageTitle);
            this.PanelMenu.Controls.Add(this.ButtonMinimize);
            this.PanelMenu.Controls.Add(this.ButtonClose);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(271, 27);
            this.PanelMenu.TabIndex = 12;
            this.PanelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMenu_MouseDown);
            // 
            // ImageTitle
            // 
            this.ImageTitle.Image = global::DataBase.Properties.Resources.Database;
            this.ImageTitle.Location = new System.Drawing.Point(2, 1);
            this.ImageTitle.Name = "ImageTitle";
            this.ImageTitle.Size = new System.Drawing.Size(25, 25);
            this.ImageTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageTitle.TabIndex = 12;
            this.ImageTitle.TabStop = false;
            this.ToolTipHelp.SetToolTip(this.ImageTitle, "DataBase");
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMinimize.Image = global::DataBase.Properties.Resources.Minimize;
            this.ButtonMinimize.Location = new System.Drawing.Point(215, 1);
            this.ButtonMinimize.Name = "ButtonMinimize";
            this.ButtonMinimize.Size = new System.Drawing.Size(25, 25);
            this.ButtonMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonMinimize.TabIndex = 10;
            this.ButtonMinimize.TabStop = false;
            this.ToolTipHelp.SetToolTip(this.ButtonMinimize, "Свернуть");
            this.ButtonMinimize.Click += new System.EventHandler(this.ButtonMinimize_Click);
            // 
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.Image = global::DataBase.Properties.Resources.Close;
            this.ButtonClose.Location = new System.Drawing.Point(243, 1);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(25, 25);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonClose.TabIndex = 11;
            this.ButtonClose.TabStop = false;
            this.ToolTipHelp.SetToolTip(this.ButtonClose, "Закрыть");
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.ForeColor = System.Drawing.Color.Gray;
            this.TxtPassword.Location = new System.Drawing.Point(40, 45);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(190, 13);
            this.TxtPassword.TabIndex = 2;
            this.TxtPassword.Text = "Введите пароль";
            this.TxtPassword.TextChanged += new System.EventHandler(this.ButtonLoginActive);
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.TxtLeave);
            // 
            // TxtLogin
            // 
            this.TxtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLogin.ForeColor = System.Drawing.Color.Gray;
            this.TxtLogin.Location = new System.Drawing.Point(40, 19);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(190, 13);
            this.TxtLogin.TabIndex = 1;
            this.TxtLogin.Text = "Введите логин";
            this.TxtLogin.TextChanged += new System.EventHandler(this.ButtonLoginActive);
            this.TxtLogin.Enter += new System.EventHandler(this.TxtLogin_Enter);
            this.TxtLogin.Leave += new System.EventHandler(this.TxtLeave);
            // 
            // ToolTipHelp
            // 
            this.ToolTipHelp.AutoPopDelay = 5000;
            this.ToolTipHelp.InitialDelay = 200;
            this.ToolTipHelp.ReshowDelay = 100;
            this.ToolTipHelp.UseAnimation = false;
            // 
            // GroupBoxLogin
            // 
            this.GroupBoxLogin.Controls.Add(this.LinkLabelPasswordRecovery);
            this.GroupBoxLogin.Controls.Add(this.panel2);
            this.GroupBoxLogin.Controls.Add(this.pictureBox1);
            this.GroupBoxLogin.Controls.Add(this.panel1);
            this.GroupBoxLogin.Controls.Add(this.ButtonLogin);
            this.GroupBoxLogin.Controls.Add(this.pictureBox2);
            this.GroupBoxLogin.Controls.Add(this.TxtPassword);
            this.GroupBoxLogin.Controls.Add(this.TxtLogin);
            this.GroupBoxLogin.Location = new System.Drawing.Point(12, 171);
            this.GroupBoxLogin.Name = "GroupBoxLogin";
            this.GroupBoxLogin.Size = new System.Drawing.Size(245, 101);
            this.GroupBoxLogin.TabIndex = 15;
            this.GroupBoxLogin.TabStop = false;
            // 
            // LinkLabelPasswordRecovery
            // 
            this.LinkLabelPasswordRecovery.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.LinkLabelPasswordRecovery.AutoSize = true;
            this.LinkLabelPasswordRecovery.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(129)))), ((int)(((byte)(184)))));
            this.LinkLabelPasswordRecovery.Location = new System.Drawing.Point(124, 75);
            this.LinkLabelPasswordRecovery.Name = "LinkLabelPasswordRecovery";
            this.LinkLabelPasswordRecovery.Size = new System.Drawing.Size(91, 13);
            this.LinkLabelPasswordRecovery.TabIndex = 17;
            this.LinkLabelPasswordRecovery.TabStop = true;
            this.LinkLabelPasswordRecovery.Text = "Забыли пароль?";
            this.LinkLabelPasswordRecovery.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkLabelPasswordRecovery_LinkClicked);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel2.Location = new System.Drawing.Point(37, 64);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(194, 1);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::DataBase.Properties.Resources.User;
            this.pictureBox1.Location = new System.Drawing.Point(6, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(25, 20);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel1.Location = new System.Drawing.Point(37, 38);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(194, 1);
            this.panel1.TabIndex = 15;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(6, 45);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(25, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // ButtonRegistr
            // 
            this.ButtonRegistr.BackColor = System.Drawing.SystemColors.Window;
            this.ButtonRegistr.Enabled = false;
            this.ButtonRegistr.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRegistr.Location = new System.Drawing.Point(64, 123);
            this.ButtonRegistr.Name = "ButtonRegistr";
            this.ButtonRegistr.Size = new System.Drawing.Size(123, 23);
            this.ButtonRegistr.TabIndex = 5;
            this.ButtonRegistr.Text = "Зарегистрироваться";
            this.ButtonRegistr.UseVisualStyleBackColor = false;
            this.ButtonRegistr.Click += new System.EventHandler(this.ButtonRegistr_Click);
            // 
            // GroupBoxReg
            // 
            this.GroupBoxReg.Controls.Add(this.ButtonRegistr);
            this.GroupBoxReg.Controls.Add(this.panel5);
            this.GroupBoxReg.Controls.Add(this.pictureBox5);
            this.GroupBoxReg.Controls.Add(this.panel6);
            this.GroupBoxReg.Controls.Add(this.pictureBox6);
            this.GroupBoxReg.Controls.Add(this.TxtNewSubname);
            this.GroupBoxReg.Controls.Add(this.TxtNewName);
            this.GroupBoxReg.Controls.Add(this.panel3);
            this.GroupBoxReg.Controls.Add(this.pictureBox3);
            this.GroupBoxReg.Controls.Add(this.panel4);
            this.GroupBoxReg.Controls.Add(this.pictureBox4);
            this.GroupBoxReg.Controls.Add(this.TxtNewPassword);
            this.GroupBoxReg.Controls.Add(this.TxtNewLogin);
            this.GroupBoxReg.Location = new System.Drawing.Point(12, 171);
            this.GroupBoxReg.Name = "GroupBoxReg";
            this.GroupBoxReg.Size = new System.Drawing.Size(245, 154);
            this.GroupBoxReg.TabIndex = 19;
            this.GroupBoxReg.TabStop = false;
            this.GroupBoxReg.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel5.Location = new System.Drawing.Point(37, 64);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 1);
            this.panel5.TabIndex = 19;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DataBase.Properties.Resources.UserPublic;
            this.pictureBox5.Location = new System.Drawing.Point(6, 19);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel6.Location = new System.Drawing.Point(37, 38);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(194, 1);
            this.panel6.TabIndex = 24;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DataBase.Properties.Resources.UserPublic;
            this.pictureBox6.Location = new System.Drawing.Point(6, 45);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // TxtNewSubname
            // 
            this.TxtNewSubname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNewSubname.ForeColor = System.Drawing.Color.Gray;
            this.TxtNewSubname.Location = new System.Drawing.Point(40, 45);
            this.TxtNewSubname.Name = "TxtNewSubname";
            this.TxtNewSubname.Size = new System.Drawing.Size(190, 13);
            this.TxtNewSubname.TabIndex = 2;
            this.TxtNewSubname.Text = "Введите фамилию";
            this.TxtNewSubname.TextChanged += new System.EventHandler(this.ButtonRegActive);
            this.TxtNewSubname.Enter += new System.EventHandler(this.TxtNewSubname_Enter);
            this.TxtNewSubname.Leave += new System.EventHandler(this.TxtLeave);
            // 
            // TxtNewName
            // 
            this.TxtNewName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNewName.ForeColor = System.Drawing.Color.Gray;
            this.TxtNewName.Location = new System.Drawing.Point(40, 19);
            this.TxtNewName.Name = "TxtNewName";
            this.TxtNewName.Size = new System.Drawing.Size(190, 13);
            this.TxtNewName.TabIndex = 1;
            this.TxtNewName.Text = "Введите имя";
            this.TxtNewName.TextChanged += new System.EventHandler(this.ButtonRegActive);
            this.TxtNewName.Enter += new System.EventHandler(this.TxtNewName_Enter);
            this.TxtNewName.Leave += new System.EventHandler(this.TxtLeave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Location = new System.Drawing.Point(37, 116);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 1);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DataBase.Properties.Resources.User;
            this.pictureBox3.Location = new System.Drawing.Point(6, 71);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel4.Location = new System.Drawing.Point(37, 90);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 1);
            this.panel4.TabIndex = 15;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(6, 97);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNewPassword.ForeColor = System.Drawing.Color.Gray;
            this.TxtNewPassword.Location = new System.Drawing.Point(40, 97);
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.Size = new System.Drawing.Size(190, 13);
            this.TxtNewPassword.TabIndex = 4;
            this.TxtNewPassword.Text = "Введите пароль";
            this.TxtNewPassword.TextChanged += new System.EventHandler(this.ButtonRegActive);
            this.TxtNewPassword.Enter += new System.EventHandler(this.TxtNewPassword_Enter);
            this.TxtNewPassword.Leave += new System.EventHandler(this.TxtLeave);
            // 
            // TxtNewLogin
            // 
            this.TxtNewLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtNewLogin.ForeColor = System.Drawing.Color.Gray;
            this.TxtNewLogin.Location = new System.Drawing.Point(40, 71);
            this.TxtNewLogin.Name = "TxtNewLogin";
            this.TxtNewLogin.Size = new System.Drawing.Size(190, 13);
            this.TxtNewLogin.TabIndex = 3;
            this.TxtNewLogin.Text = "Введите логин";
            this.TxtNewLogin.TextChanged += new System.EventHandler(this.ButtonRegActive);
            this.TxtNewLogin.Enter += new System.EventHandler(this.TxtNewLogin_Enter);
            this.TxtNewLogin.Leave += new System.EventHandler(this.TxtLeave);
            // 
            // ImageBD
            // 
            this.ImageBD.BackColor = System.Drawing.SystemColors.Window;
            this.ImageBD.Image = global::DataBase.Properties.Resources.DataLogin;
            this.ImageBD.Location = new System.Drawing.Point(37, 33);
            this.ImageBD.Name = "ImageBD";
            this.ImageBD.Size = new System.Drawing.Size(100, 100);
            this.ImageBD.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageBD.TabIndex = 7;
            this.ImageBD.TabStop = false;
            // 
            // Form_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(271, 279);
            this.Controls.Add(this.GroupBoxLogin);
            this.Controls.Add(this.GroupBoxReg);
            this.Controls.Add(this.ButtonReg);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.ImageBD);
            this.Controls.Add(this.ComboBoxServer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            this.GroupBoxLogin.ResumeLayout(false);
            this.GroupBoxLogin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.GroupBoxReg.ResumeLayout(false);
            this.GroupBoxReg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageBD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button ButtonLogin;
        private System.Windows.Forms.ComboBox ComboBoxServer;
        private System.Windows.Forms.PictureBox ImageBD;
        private System.Windows.Forms.Button ButtonReg;
        private System.Windows.Forms.PictureBox ButtonMinimize;
        private System.Windows.Forms.PictureBox ButtonClose;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox ImageTitle;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtLogin;
        private System.Windows.Forms.ToolTip ToolTipHelp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox GroupBoxLogin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.LinkLabel LinkLabelPasswordRecovery;
        private System.Windows.Forms.Button ButtonRegistr;
        private System.Windows.Forms.GroupBox GroupBoxReg;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox TxtNewSubname;
        private System.Windows.Forms.TextBox TxtNewName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox TxtNewPassword;
        private System.Windows.Forms.TextBox TxtNewLogin;
    }
}