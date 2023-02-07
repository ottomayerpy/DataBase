using DataBase.Properties;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form_User : Form
    {
        Form form;

        public Form_User(Form form)
        {
            InitializeComponent();

            Icon = Icon.FromHandle(Resources.Database.GetHicon());
            PanelMenu.BackColor = ButtonEditName.BackColor = ButtonEditSubname.BackColor = ButtonEditLogin.BackColor = ButtonEditPassword.BackColor = Settings.Default.PanelMenuColor;

            this.form = form;
            LabelName.Text = User.Name + " " + User.Subname;
            LabelID.Text = User.ID;
            LabelLevel.Text = User.Type;
        }

        private void Form_User_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void ButtonSettings(string set)
        {
            GroupBoxSettings.Focus();
            new Form_UserSettings(set).ShowDialog();
        }

        private void ButtonEditName_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.ControlDark;
            ButtonSettings("Введите новое имя:");
            BackColor = SystemColors.ControlLightLight;
        }

        private void ButtonEditSubname_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.ControlDark;
            ButtonSettings("Введите новую фамилию:");
            BackColor = SystemColors.ControlLightLight;
        }

        private void ButtonEditLogin_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.ControlDark;
            ButtonSettings("Введите новый логин:");
            BackColor = SystemColors.ControlLightLight;
        }

        private void ButtonEditPassword_Click(object sender, EventArgs e)
        {
            BackColor = SystemColors.ControlDark;
            ButtonSettings("Введите новый пароль:");
            BackColor = SystemColors.ControlLightLight;
        }

        private void ButtonUserExit_Click(object sender, EventArgs e)
        {
            Hide();
            form.Show();
        }

        private void ButtonMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void ButtonClose_Click(object sender, EventArgs e) => Application.Exit();

        private void PanelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            PanelMenu.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
    }
}