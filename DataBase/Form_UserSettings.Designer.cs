namespace DataBase
{
    partial class Form_UserSettings
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
            this.LabelSet = new System.Windows.Forms.Label();
            this.ButtonSave = new System.Windows.Forms.Button();
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.ImageTitle = new System.Windows.Forms.PictureBox();
            this.ButtonClose = new System.Windows.Forms.PictureBox();
            this.ToolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.TxtSet = new System.Windows.Forms.TextBox();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelSet
            // 
            this.LabelSet.AutoSize = true;
            this.LabelSet.Location = new System.Drawing.Point(9, 30);
            this.LabelSet.Name = "LabelSet";
            this.LabelSet.Size = new System.Drawing.Size(49, 13);
            this.LabelSet.TabIndex = 2;
            this.LabelSet.Text = "LabelSet";
            // 
            // ButtonSave
            // 
            this.ButtonSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonSave.Location = new System.Drawing.Point(211, 44);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(75, 23);
            this.ButtonSave.TabIndex = 4;
            this.ButtonSave.Text = "Сохранить";
            this.ButtonSave.UseVisualStyleBackColor = true;
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.White;
            this.PanelMenu.Controls.Add(this.ImageTitle);
            this.PanelMenu.Controls.Add(this.ButtonClose);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(296, 27);
            this.PanelMenu.TabIndex = 24;
            this.PanelMenu.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PanelMenu_MouseDown);
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
            // ButtonClose
            // 
            this.ButtonClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ButtonClose.Image = global::DataBase.Properties.Resources.Close;
            this.ButtonClose.Location = new System.Drawing.Point(268, 1);
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
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.panel6.Location = new System.Drawing.Point(12, 68);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(194, 1);
            this.panel6.TabIndex = 26;
            // 
            // TxtSet
            // 
            this.TxtSet.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtSet.Location = new System.Drawing.Point(15, 49);
            this.TxtSet.Name = "TxtSet";
            this.TxtSet.Size = new System.Drawing.Size(190, 13);
            this.TxtSet.TabIndex = 0;
            // 
            // Form_UserSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(296, 77);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.TxtSet);
            this.Controls.Add(this.PanelMenu);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.LabelSet);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form_UserSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Настройки профиля";
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label LabelSet;
        private System.Windows.Forms.Button ButtonSave;
        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox ImageTitle;
        private System.Windows.Forms.PictureBox ButtonClose;
        private System.Windows.Forms.ToolTip ToolTipHelp;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox TxtSet;
    }
}