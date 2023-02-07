namespace DataBase
{
    partial class Form_User
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
            this.label1 = new System.Windows.Forms.Label();
            this.LabelName = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.LabelID = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.LabelLevel = new System.Windows.Forms.Label();
            this.GroupBoxSettings = new System.Windows.Forms.GroupBox();
            this.ButtonEditPassword = new System.Windows.Forms.Button();
            this.ButtonEditLogin = new System.Windows.Forms.Button();
            this.ButtonEditSubname = new System.Windows.Forms.Button();
            this.ButtonEditName = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.ButtonUserExit = new System.Windows.Forms.PictureBox();
            this.ImageTitle = new System.Windows.Forms.PictureBox();
            this.ButtonMinimize = new System.Windows.Forms.PictureBox();
            this.ButtonClose = new System.Windows.Forms.PictureBox();
            this.ToolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.GroupBoxSettings.SuspendLayout();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonUserExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(9, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Добро пожаловать: ";
            // 
            // LabelName
            // 
            this.LabelName.AutoSize = true;
            this.LabelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelName.Location = new System.Drawing.Point(152, 35);
            this.LabelName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelName.Name = "LabelName";
            this.LabelName.Size = new System.Drawing.Size(42, 16);
            this.LabelName.TabIndex = 1;
            this.LabelName.Text = "name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(9, 58);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ваш ID:";
            // 
            // LabelID
            // 
            this.LabelID.AutoSize = true;
            this.LabelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelID.Location = new System.Drawing.Point(68, 58);
            this.LabelID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.LabelID.Name = "LabelID";
            this.LabelID.Size = new System.Drawing.Size(19, 16);
            this.LabelID.TabIndex = 3;
            this.LabelID.Text = "id";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(9, 81);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ваш Уровень:";
            // 
            // LabelLevel
            // 
            this.LabelLevel.AutoSize = true;
            this.LabelLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LabelLevel.Location = new System.Drawing.Point(109, 81);
            this.LabelLevel.Margin = new System.Windows.Forms.Padding(1, 4, 3, 4);
            this.LabelLevel.Name = "LabelLevel";
            this.LabelLevel.Size = new System.Drawing.Size(37, 16);
            this.LabelLevel.TabIndex = 5;
            this.LabelLevel.Text = "level";
            // 
            // GroupBoxSettings
            // 
            this.GroupBoxSettings.Controls.Add(this.ButtonEditPassword);
            this.GroupBoxSettings.Controls.Add(this.ButtonEditLogin);
            this.GroupBoxSettings.Controls.Add(this.ButtonEditSubname);
            this.GroupBoxSettings.Controls.Add(this.ButtonEditName);
            this.GroupBoxSettings.Location = new System.Drawing.Point(12, 104);
            this.GroupBoxSettings.Name = "GroupBoxSettings";
            this.GroupBoxSettings.Size = new System.Drawing.Size(326, 78);
            this.GroupBoxSettings.TabIndex = 8;
            this.GroupBoxSettings.TabStop = false;
            this.GroupBoxSettings.Text = "Настройки профиля";
            // 
            // ButtonEditPassword
            // 
            this.ButtonEditPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditPassword.Location = new System.Drawing.Point(166, 48);
            this.ButtonEditPassword.Name = "ButtonEditPassword";
            this.ButtonEditPassword.Size = new System.Drawing.Size(154, 23);
            this.ButtonEditPassword.TabIndex = 3;
            this.ButtonEditPassword.Text = "Изменить пароль";
            this.ButtonEditPassword.UseVisualStyleBackColor = true;
            this.ButtonEditPassword.Click += new System.EventHandler(this.ButtonEditPassword_Click);
            // 
            // ButtonEditLogin
            // 
            this.ButtonEditLogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditLogin.Location = new System.Drawing.Point(166, 19);
            this.ButtonEditLogin.Name = "ButtonEditLogin";
            this.ButtonEditLogin.Size = new System.Drawing.Size(154, 23);
            this.ButtonEditLogin.TabIndex = 2;
            this.ButtonEditLogin.Text = "Изменить логин";
            this.ButtonEditLogin.UseVisualStyleBackColor = true;
            this.ButtonEditLogin.Click += new System.EventHandler(this.ButtonEditLogin_Click);
            // 
            // ButtonEditSubname
            // 
            this.ButtonEditSubname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditSubname.Location = new System.Drawing.Point(6, 48);
            this.ButtonEditSubname.Name = "ButtonEditSubname";
            this.ButtonEditSubname.Size = new System.Drawing.Size(154, 23);
            this.ButtonEditSubname.TabIndex = 1;
            this.ButtonEditSubname.Text = "Изменить фамилию";
            this.ButtonEditSubname.UseVisualStyleBackColor = true;
            this.ButtonEditSubname.Click += new System.EventHandler(this.ButtonEditSubname_Click);
            // 
            // ButtonEditName
            // 
            this.ButtonEditName.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonEditName.Location = new System.Drawing.Point(6, 19);
            this.ButtonEditName.Name = "ButtonEditName";
            this.ButtonEditName.Size = new System.Drawing.Size(154, 23);
            this.ButtonEditName.TabIndex = 0;
            this.ButtonEditName.Text = "Изменить имя";
            this.ButtonEditName.UseVisualStyleBackColor = true;
            this.ButtonEditName.Click += new System.EventHandler(this.ButtonEditName_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.White;
            this.PanelMenu.Controls.Add(this.ButtonUserExit);
            this.PanelMenu.Controls.Add(this.ImageTitle);
            this.PanelMenu.Controls.Add(this.ButtonMinimize);
            this.PanelMenu.Controls.Add(this.ButtonClose);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(350, 27);
            this.PanelMenu.TabIndex = 23;
            this.PanelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMenu_MouseDown);
            // 
            // ButtonUserExit
            // 
            this.ButtonUserExit.Image = global::DataBase.Properties.Resources.Exit;
            this.ButtonUserExit.Location = new System.Drawing.Point(33, 1);
            this.ButtonUserExit.Name = "ButtonUserExit";
            this.ButtonUserExit.Size = new System.Drawing.Size(25, 25);
            this.ButtonUserExit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonUserExit.TabIndex = 14;
            this.ButtonUserExit.TabStop = false;
            this.ToolTipHelp.SetToolTip(this.ButtonUserExit, "Выход");
            this.ButtonUserExit.Click += new System.EventHandler(this.ButtonUserExit_Click);
            // 
            // ImageTitle
            // 
            this.ImageTitle.Image = global::DataBase.Properties.Resources.Database;
            this.ImageTitle.Location = new System.Drawing.Point(2, 1);
            this.ImageTitle.Name = "ImageTitle";
            this.ImageTitle.Size = new System.Drawing.Size(25, 25);
            this.ImageTitle.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ImageTitle.TabIndex = 13;
            this.ImageTitle.TabStop = false;
            this.ToolTipHelp.SetToolTip(this.ImageTitle, "DataBase");
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMinimize.Image = global::DataBase.Properties.Resources.Minimize;
            this.ButtonMinimize.Location = new System.Drawing.Point(291, 1);
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
            this.ButtonClose.Location = new System.Drawing.Point(322, 1);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(25, 25);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonClose.TabIndex = 11;
            this.ButtonClose.TabStop = false;
            this.ToolTipHelp.SetToolTip(this.ButtonClose, "Закрыть");
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ToolTipHelp
            // 
            this.ToolTipHelp.AutoPopDelay = 5000;
            this.ToolTipHelp.InitialDelay = 200;
            this.ToolTipHelp.ReshowDelay = 100;
            this.ToolTipHelp.UseAnimation = false;
            // 
            // Form_User
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(350, 193);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.GroupBoxSettings);
            this.Controls.Add(this.LabelLevel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.LabelID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LabelName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_User";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_User_FormClosed);
            this.GroupBoxSettings.ResumeLayout(false);
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonUserExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LabelName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label LabelID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label LabelLevel;
        private System.Windows.Forms.GroupBox GroupBoxSettings;
        private System.Windows.Forms.Button ButtonEditPassword;
        private System.Windows.Forms.Button ButtonEditLogin;
        private System.Windows.Forms.Button ButtonEditSubname;
        private System.Windows.Forms.Button ButtonEditName;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox ButtonUserExit;
        private System.Windows.Forms.PictureBox ImageTitle;
        private System.Windows.Forms.PictureBox ButtonMinimize;
        private System.Windows.Forms.PictureBox ButtonClose;
        private System.Windows.Forms.ToolTip ToolTipHelp;
    }
}