namespace DataBase
{
    partial class Form_Main_AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Main_AddUser));
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.RButtonAdmin = new System.Windows.Forms.RadioButton();
            this.RButtonUser = new System.Windows.Forms.RadioButton();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.ImageTitle = new System.Windows.Forms.PictureBox();
            this.ButtonClose = new System.Windows.Forms.PictureBox();
            this.ObjectFocus = new System.Windows.Forms.TextBox();
            this.ToolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.panel5 = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.TxtSubname = new System.Windows.Forms.TextBox();
            this.TxtName = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.TxtPassword = new System.Windows.Forms.TextBox();
            this.TxtLogin = new System.Windows.Forms.TextBox();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Enabled = false;
            this.ButtonAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonAdd.Location = new System.Drawing.Point(78, 160);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(75, 23);
            this.ButtonAdd.TabIndex = 7;
            this.ButtonAdd.Text = "Добавить";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // RButtonAdmin
            // 
            this.RButtonAdmin.AutoSize = true;
            this.RButtonAdmin.Location = new System.Drawing.Point(13, 137);
            this.RButtonAdmin.Name = "RButtonAdmin";
            this.RButtonAdmin.Size = new System.Drawing.Size(104, 17);
            this.RButtonAdmin.TabIndex = 5;
            this.RButtonAdmin.TabStop = true;
            this.RButtonAdmin.Text = "Администратор";
            this.RButtonAdmin.UseVisualStyleBackColor = true;
            this.RButtonAdmin.CheckedChanged += new System.EventHandler(this.RButton_Changed);
            // 
            // RButtonUser
            // 
            this.RButtonUser.AutoSize = true;
            this.RButtonUser.Checked = true;
            this.RButtonUser.Location = new System.Drawing.Point(123, 137);
            this.RButtonUser.Name = "RButtonUser";
            this.RButtonUser.Size = new System.Drawing.Size(98, 17);
            this.RButtonUser.TabIndex = 6;
            this.RButtonUser.TabStop = true;
            this.RButtonUser.Text = "Пользователь";
            this.RButtonUser.UseVisualStyleBackColor = true;
            this.RButtonUser.CheckedChanged += new System.EventHandler(this.RButton_Changed);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.White;
            this.PanelMenu.Controls.Add(this.ImageTitle);
            this.PanelMenu.Controls.Add(this.ButtonClose);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(232, 27);
            this.PanelMenu.TabIndex = 13;
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
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.Image = global::DataBase.Properties.Resources.Close;
            this.ButtonClose.Location = new System.Drawing.Point(204, 1);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(25, 25);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonClose.TabIndex = 11;
            this.ButtonClose.TabStop = false;
            this.ToolTipHelp.SetToolTip(this.ButtonClose, "Закрыть");
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ObjectFocus
            // 
            this.ObjectFocus.Location = new System.Drawing.Point(-100, -100);
            this.ObjectFocus.Name = "ObjectFocus";
            this.ObjectFocus.Size = new System.Drawing.Size(100, 20);
            this.ObjectFocus.TabIndex = 0;
            // 
            // ToolTipHelp
            // 
            this.ToolTipHelp.AutoPopDelay = 5000;
            this.ToolTipHelp.InitialDelay = 200;
            this.ToolTipHelp.ReshowDelay = 100;
            this.ToolTipHelp.UseAnimation = false;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel5.Location = new System.Drawing.Point(33, 78);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(194, 1);
            this.panel5.TabIndex = 19;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::DataBase.Properties.Resources.UserPublic;
            this.pictureBox5.Location = new System.Drawing.Point(2, 33);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(25, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 22;
            this.pictureBox5.TabStop = false;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel6.Location = new System.Drawing.Point(33, 52);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(194, 1);
            this.panel6.TabIndex = 24;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = global::DataBase.Properties.Resources.UserPublic;
            this.pictureBox6.Location = new System.Drawing.Point(2, 59);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(25, 20);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 23;
            this.pictureBox6.TabStop = false;
            // 
            // TxtSubname
            // 
            this.TxtSubname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSubname.ForeColor = System.Drawing.Color.Gray;
            this.TxtSubname.Location = new System.Drawing.Point(36, 59);
            this.TxtSubname.Name = "TxtSubname";
            this.TxtSubname.Size = new System.Drawing.Size(190, 13);
            this.TxtSubname.TabIndex = 2;
            this.TxtSubname.Text = "Введите фамилию";
            this.TxtSubname.TextChanged += new System.EventHandler(this.ButtonAddActive);
            this.TxtSubname.Enter += new System.EventHandler(this.TxtSubname_Enter);
            this.TxtSubname.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // TxtName
            // 
            this.TxtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtName.ForeColor = System.Drawing.Color.Gray;
            this.TxtName.Location = new System.Drawing.Point(36, 33);
            this.TxtName.Name = "TxtName";
            this.TxtName.Size = new System.Drawing.Size(190, 13);
            this.TxtName.TabIndex = 1;
            this.TxtName.Text = "Введите имя";
            this.TxtName.TextChanged += new System.EventHandler(this.ButtonAddActive);
            this.TxtName.Enter += new System.EventHandler(this.TxtName_Enter);
            this.TxtName.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel3.Location = new System.Drawing.Point(33, 130);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(194, 1);
            this.panel3.TabIndex = 0;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::DataBase.Properties.Resources.User;
            this.pictureBox3.Location = new System.Drawing.Point(2, 85);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(25, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel4.Location = new System.Drawing.Point(33, 104);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(194, 1);
            this.panel4.TabIndex = 15;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(2, 111);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(25, 20);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 14;
            this.pictureBox4.TabStop = false;
            // 
            // TxtPassword
            // 
            this.TxtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtPassword.ForeColor = System.Drawing.Color.Gray;
            this.TxtPassword.Location = new System.Drawing.Point(36, 111);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.Size = new System.Drawing.Size(190, 13);
            this.TxtPassword.TabIndex = 4;
            this.TxtPassword.Text = "Введите пароль";
            this.TxtPassword.TextChanged += new System.EventHandler(this.ButtonAddActive);
            this.TxtPassword.Enter += new System.EventHandler(this.TxtPassword_Enter);
            this.TxtPassword.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // TxtLogin
            // 
            this.TxtLogin.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtLogin.ForeColor = System.Drawing.Color.Gray;
            this.TxtLogin.Location = new System.Drawing.Point(36, 85);
            this.TxtLogin.Name = "TxtLogin";
            this.TxtLogin.Size = new System.Drawing.Size(190, 13);
            this.TxtLogin.TabIndex = 3;
            this.TxtLogin.Text = "Введите логин";
            this.TxtLogin.TextChanged += new System.EventHandler(this.ButtonAddActive);
            this.TxtLogin.Enter += new System.EventHandler(this.TxtLogin_Enter);
            this.TxtLogin.Leave += new System.EventHandler(this.Txt_Leave);
            // 
            // Form_Main_AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(232, 188);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.ObjectFocus);
            this.Controls.Add(this.RButtonUser);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.TxtLogin);
            this.Controls.Add(this.RButtonAdmin);
            this.Controls.Add(this.TxtPassword);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.TxtSubname);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.TxtName);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.panel3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.Name = "Form_Main_AddUser";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавить пользователя";
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.RadioButton RButtonAdmin;
        private System.Windows.Forms.RadioButton RButtonUser;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox ImageTitle;
        private System.Windows.Forms.PictureBox ButtonClose;
        private System.Windows.Forms.TextBox ObjectFocus;
        private System.Windows.Forms.ToolTip ToolTipHelp;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.TextBox TxtSubname;
        private System.Windows.Forms.TextBox TxtName;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox TxtPassword;
        private System.Windows.Forms.TextBox TxtLogin;
    }
}