namespace DataBase
{
    partial class Form_Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.DataGridTable = new System.Windows.Forms.DataGridView();
            this.ComboBoxTable = new System.Windows.Forms.ComboBox();
            this.ComboBoxDataBase = new System.Windows.Forms.ComboBox();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.ButtonSettings = new System.Windows.Forms.PictureBox();
            this.ButtonEditTable = new System.Windows.Forms.PictureBox();
            this.ButtonRemoveUser = new System.Windows.Forms.PictureBox();
            this.ButtonRefresh = new System.Windows.Forms.PictureBox();
            this.ButtonAddUser = new System.Windows.Forms.PictureBox();
            this.ButtonUserExit = new System.Windows.Forms.PictureBox();
            this.ImageTitle = new System.Windows.Forms.PictureBox();
            this.ButtonMaximize = new System.Windows.Forms.PictureBox();
            this.ButtonMinimize = new System.Windows.Forms.PictureBox();
            this.ButtonClose = new System.Windows.Forms.PictureBox();
            this.ToolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTable)).BeginInit();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSettings)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonEditTable)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRemoveUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRefresh)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonUserExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMaximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridTable
            // 
            this.DataGridTable.AllowUserToAddRows = false;
            this.DataGridTable.AllowUserToDeleteRows = false;
            this.DataGridTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGridTable.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.DataGridTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridTable.Location = new System.Drawing.Point(-2, 26);
            this.DataGridTable.Name = "DataGridTable";
            this.DataGridTable.ReadOnly = true;
            this.DataGridTable.Size = new System.Drawing.Size(998, 369);
            this.DataGridTable.TabIndex = 10;
            this.DataGridTable.CurrentCellDirtyStateChanged += new System.EventHandler(this.DataGridTable_CurrentCellDirtyStateChanged);
            // 
            // ComboBoxTable
            // 
            this.ComboBoxTable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxTable.FormattingEnabled = true;
            this.ComboBoxTable.Location = new System.Drawing.Point(352, 3);
            this.ComboBoxTable.Name = "ComboBoxTable";
            this.ComboBoxTable.Size = new System.Drawing.Size(189, 21);
            this.ComboBoxTable.TabIndex = 13;
            this.ToolTipHelp.SetToolTip(this.ComboBoxTable, "Выбор таблицы");
            this.ComboBoxTable.SelectedIndexChanged += new System.EventHandler(this.ComboBoxTable_SelectedIndexChanged);
            // 
            // ComboBoxDataBase
            // 
            this.ComboBoxDataBase.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBoxDataBase.FormattingEnabled = true;
            this.ComboBoxDataBase.Location = new System.Drawing.Point(157, 3);
            this.ComboBoxDataBase.Name = "ComboBoxDataBase";
            this.ComboBoxDataBase.Size = new System.Drawing.Size(189, 21);
            this.ComboBoxDataBase.TabIndex = 20;
            this.ToolTipHelp.SetToolTip(this.ComboBoxDataBase, "Выбор базы данных");
            this.ComboBoxDataBase.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDataBase_SelectedIndexChanged);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.White;
            this.PanelMenu.Controls.Add(this.ButtonSettings);
            this.PanelMenu.Controls.Add(this.ButtonEditTable);
            this.PanelMenu.Controls.Add(this.ComboBoxTable);
            this.PanelMenu.Controls.Add(this.ComboBoxDataBase);
            this.PanelMenu.Controls.Add(this.ButtonRemoveUser);
            this.PanelMenu.Controls.Add(this.ButtonRefresh);
            this.PanelMenu.Controls.Add(this.ButtonAddUser);
            this.PanelMenu.Controls.Add(this.ButtonUserExit);
            this.PanelMenu.Controls.Add(this.ImageTitle);
            this.PanelMenu.Controls.Add(this.ButtonMaximize);
            this.PanelMenu.Controls.Add(this.ButtonMinimize);
            this.PanelMenu.Controls.Add(this.ButtonClose);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(995, 27);
            this.PanelMenu.TabIndex = 22;
            this.PanelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMenu_MouseDown);
            // 
            // ButtonSettings
            // 
            this.ButtonSettings.Image = global::DataBase.Properties.Resources.Settings;
            this.ButtonSettings.Location = new System.Drawing.Point(578, 1);
            this.ButtonSettings.Name = "ButtonSettings";
            this.ButtonSettings.Size = new System.Drawing.Size(25, 25);
            this.ButtonSettings.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonSettings.TabIndex = 22;
            this.ButtonSettings.TabStop = false;
            this.ToolTipHelp.SetToolTip(this.ButtonSettings, "Настройки");
            this.ButtonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            // 
            // ButtonEditTable
            // 
            this.ButtonEditTable.Image = global::DataBase.Properties.Resources.EditUser;
            this.ButtonEditTable.Location = new System.Drawing.Point(547, 1);
            this.ButtonEditTable.Name = "ButtonEditTable";
            this.ButtonEditTable.Size = new System.Drawing.Size(25, 25);
            this.ButtonEditTable.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonEditTable.TabIndex = 21;
            this.ButtonEditTable.TabStop = false;
            this.ToolTipHelp.SetToolTip(this.ButtonEditTable, "Включить редактирование таблицы");
            this.ButtonEditTable.Click += new System.EventHandler(this.ButtonEditTable_Click);
            // 
            // ButtonRemoveUser
            // 
            this.ButtonRemoveUser.Image = global::DataBase.Properties.Resources.RemoveUser;
            this.ButtonRemoveUser.Location = new System.Drawing.Point(95, 1);
            this.ButtonRemoveUser.Name = "ButtonRemoveUser";
            this.ButtonRemoveUser.Size = new System.Drawing.Size(25, 25);
            this.ButtonRemoveUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonRemoveUser.TabIndex = 18;
            this.ButtonRemoveUser.TabStop = false;
            this.ToolTipHelp.SetToolTip(this.ButtonRemoveUser, "Удалить пользователя");
            this.ButtonRemoveUser.Click += new System.EventHandler(this.ButtonRemoveUser_Click);
            // 
            // ButtonRefresh
            // 
            this.ButtonRefresh.Image = global::DataBase.Properties.Resources.Refresh;
            this.ButtonRefresh.Location = new System.Drawing.Point(126, 1);
            this.ButtonRefresh.Name = "ButtonRefresh";
            this.ButtonRefresh.Size = new System.Drawing.Size(25, 25);
            this.ButtonRefresh.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonRefresh.TabIndex = 17;
            this.ButtonRefresh.TabStop = false;
            this.ToolTipHelp.SetToolTip(this.ButtonRefresh, "Перезагрузить таблицу");
            this.ButtonRefresh.Click += new System.EventHandler(this.ButtonRefresh_Click);
            // 
            // ButtonAddUser
            // 
            this.ButtonAddUser.Image = global::DataBase.Properties.Resources.Adduser;
            this.ButtonAddUser.Location = new System.Drawing.Point(64, 1);
            this.ButtonAddUser.Name = "ButtonAddUser";
            this.ButtonAddUser.Size = new System.Drawing.Size(25, 25);
            this.ButtonAddUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonAddUser.TabIndex = 15;
            this.ButtonAddUser.TabStop = false;
            this.ToolTipHelp.SetToolTip(this.ButtonAddUser, "Добавить пользователя");
            this.ButtonAddUser.Click += new System.EventHandler(this.ButtonAddUser_Click);
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
            // ButtonMaximize
            // 
            this.ButtonMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMaximize.Image = global::DataBase.Properties.Resources.Maximize;
            this.ButtonMaximize.Location = new System.Drawing.Point(936, 1);
            this.ButtonMaximize.Name = "ButtonMaximize";
            this.ButtonMaximize.Size = new System.Drawing.Size(25, 25);
            this.ButtonMaximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonMaximize.TabIndex = 12;
            this.ButtonMaximize.TabStop = false;
            this.ToolTipHelp.SetToolTip(this.ButtonMaximize, "Развернуть");
            this.ButtonMaximize.Click += new System.EventHandler(this.ButtonMaximize_Click);
            // 
            // ButtonMinimize
            // 
            this.ButtonMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonMinimize.Image = global::DataBase.Properties.Resources.Minimize;
            this.ButtonMinimize.Location = new System.Drawing.Point(905, 1);
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
            this.ButtonClose.Location = new System.Drawing.Point(967, 1);
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
            // Form_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(995, 410);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.DataGridTable);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(995, 410);
            this.Name = "Form_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "База данных";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Main_FormClosed);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridTable)).EndInit();
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ButtonSettings)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonEditTable)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRemoveUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonRefresh)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonAddUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonUserExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ImageTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMaximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView DataGridTable;
        private System.Windows.Forms.ComboBox ComboBoxTable;
        private System.Windows.Forms.ComboBox ComboBoxDataBase;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox ButtonMinimize;
        private System.Windows.Forms.PictureBox ButtonClose;
        private System.Windows.Forms.PictureBox ButtonMaximize;
        private System.Windows.Forms.PictureBox ImageTitle;
        private System.Windows.Forms.PictureBox ButtonUserExit;
        private System.Windows.Forms.PictureBox ButtonAddUser;
        private System.Windows.Forms.PictureBox ButtonRefresh;
        private System.Windows.Forms.PictureBox ButtonRemoveUser;
        private System.Windows.Forms.PictureBox ButtonEditTable;
        private System.Windows.Forms.ToolTip ToolTipHelp;
        private System.Windows.Forms.PictureBox ButtonSettings;
    }
}

