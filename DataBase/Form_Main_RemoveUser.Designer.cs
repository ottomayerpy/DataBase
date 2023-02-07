namespace DataBase
{
    partial class Form_Main_RemoveUser
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
            this.PanelMenu = new System.Windows.Forms.Panel();
            this.ImageTitle = new System.Windows.Forms.PictureBox();
            this.ButtonClose = new System.Windows.Forms.PictureBox();
            this.ButtonRemove = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.ToolTipHelp = new System.Windows.Forms.ToolTip(this.components);
            this.panel6 = new System.Windows.Forms.Panel();
            this.TxtID = new System.Windows.Forms.TextBox();
            this.PanelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImageTitle)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelMenu
            // 
            this.PanelMenu.BackColor = System.Drawing.Color.White;
            this.PanelMenu.Controls.Add(this.ImageTitle);
            this.PanelMenu.Controls.Add(this.ButtonClose);
            this.PanelMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelMenu.Location = new System.Drawing.Point(0, 0);
            this.PanelMenu.Name = "PanelMenu";
            this.PanelMenu.Size = new System.Drawing.Size(163, 27);
            this.PanelMenu.TabIndex = 23;
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
            this.ButtonClose.Location = new System.Drawing.Point(135, 1);
            this.ButtonClose.Name = "ButtonClose";
            this.ButtonClose.Size = new System.Drawing.Size(25, 25);
            this.ButtonClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ButtonClose.TabIndex = 11;
            this.ButtonClose.TabStop = false;
            this.ToolTipHelp.SetToolTip(this.ButtonClose, "Закрыть");
            this.ButtonClose.Click += new System.EventHandler(this.ButtonClose_Click);
            // 
            // ButtonRemove
            // 
            this.ButtonRemove.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ButtonRemove.Location = new System.Drawing.Point(46, 72);
            this.ButtonRemove.Name = "ButtonRemove";
            this.ButtonRemove.Size = new System.Drawing.Size(75, 23);
            this.ButtonRemove.TabIndex = 25;
            this.ButtonRemove.Text = "Удалить";
            this.ButtonRemove.UseVisualStyleBackColor = true;
            this.ButtonRemove.Click += new System.EventHandler(this.ButtonRemove_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 13);
            this.label1.TabIndex = 26;
            this.label1.Text = "Укажите ID пользователя:";
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
            this.panel6.Location = new System.Drawing.Point(8, 65);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(144, 1);
            this.panel6.TabIndex = 28;
            // 
            // TxtID
            // 
            this.TxtID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtID.Location = new System.Drawing.Point(11, 46);
            this.TxtID.Name = "TxtID";
            this.TxtID.Size = new System.Drawing.Size(140, 13);
            this.TxtID.TabIndex = 0;
            // 
            // Form_Main_RemoveUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(163, 106);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.TxtID);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonRemove);
            this.Controls.Add(this.PanelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form_Main_RemoveUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.PanelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImageTitle)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ButtonClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelMenu;
        private System.Windows.Forms.PictureBox ImageTitle;
        private System.Windows.Forms.PictureBox ButtonClose;
        private System.Windows.Forms.Button ButtonRemove;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolTip ToolTipHelp;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.TextBox TxtID;
    }
}