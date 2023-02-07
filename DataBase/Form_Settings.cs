using System;
using System.Drawing;
using System.Windows.Forms;
using DataBase.Properties;

namespace DataBase
{
    public partial class Form_Settings : Form
    {
        public Form_Settings()
        {
            InitializeComponent();
            Icon = Icon.FromHandle(Resources.Database.GetHicon());
            PanelMenu.BackColor = ButtonChangeColor.BackColor = Settings.Default.PanelMenuColor;
            LabelColor.Text = Settings.Default.PanelMenuColor.Name;
        }

        private void ButtonChangeColor_Click(object sender, EventArgs e)
        {
            ColorDialog col = new ColorDialog
            {
                FullOpen = true,
                Color = Settings.Default.PanelMenuColor
            };

            if (col.ShowDialog() == DialogResult.Cancel)
                return;
            Settings.Default.PanelMenuColor = col.Color;
            Settings.Default.Save();
            LabelColor.Text = Settings.Default.PanelMenuColor.Name;
        }

        private void PanelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            PanelMenu.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void ButtonClose_Click(object sender, EventArgs e) => Close();
    }
}
