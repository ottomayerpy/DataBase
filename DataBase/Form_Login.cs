using System;
using System.Data.Common;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using DataBase.Properties;

namespace DataBase
{
    public partial class Form_Login : Form
    {
        Form form_main, form_user;
        bool TrueLoad = false;

        public Form_Login(Form form_main = null, Form form_user = null)
        {
            InitializeComponent();
            Icon = Icon.FromHandle(Resources.Database.GetHicon());
            PanelMenu.BackColor = ButtonLogin.BackColor = ButtonReg.BackColor = ButtonRegistr.BackColor = Settings.Default.PanelMenuColor;

            if (form_main != null)
                this.form_main = form_main;

            if (form_user != null)
                this.form_user = form_user;

            foreach (string name in GetServerList.GetSQLServerList())
                ComboBoxServer.Items.Add(name);

            if (ComboBoxServer.Items.Count == 0)
                ComboBoxServer.DropDownStyle = ComboBoxStyle.Simple;
            else
                ComboBoxServer.SelectedIndex = 0;
        }

        private void ButtonMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void ButtonClose_Click(object sender, EventArgs e) => Application.Exit();

        private void ButtonLogin_Click(object sender, EventArgs e)
        {
            ImageTitle.Focus();
            SQLServerConnect("select * from RegUsers", "Login"); // Получаем значения таблицы
            if (TrueLoad)
            {
                TrueLoad = false;
                SQLServerConnect("select * from InfoUsers", "Info");
            }
            else
                MessageBox.Show("Неверный логин или пароль!", "Ошибка авторизации", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void SQLServerConnect(string command, string mode)
        {
            SqlConnection connect = null;

            if (ComboBoxServer.DropDownStyle == ComboBoxStyle.Simple)
                connect = new SqlConnection(string.Format("Data Source={0}; Initial Catalog=DbUsers; Integrated Security = true;", ComboBoxServer.Text));
            else
                connect = new SqlConnection(string.Format("Data Source={0}; Initial Catalog=DbUsers; Integrated Security = true;", ComboBoxServer.SelectedItem.ToString()));

            connect.Open();

            try
            {
                using (DbDataReader reader = new SqlCommand(command, connect).ExecuteReader())
                {
                    switch (mode)
                    {
                        case "Login":
                            while (reader.Read())
                                if (reader.GetValue(reader.GetOrdinal("Login")).ToString() == TxtLogin.Text)
                                    if (reader.GetValue(reader.GetOrdinal("Password")).ToString() == TxtPassword.Text)
                                    {
                                        User.ID = reader.GetValue(reader.GetOrdinal("ID")).ToString();
                                        TrueLoad = true;
                                        break;
                                    }
                            break;
                        case "Info":
                            while (reader.Read())
                                if (reader.GetValue(reader.GetOrdinal("ID")).ToString() == User.ID)
                                {
                                    User.Name = reader.GetValue(reader.GetOrdinal("Name")).ToString();
                                    User.Subname = reader.GetValue(reader.GetOrdinal("Subname")).ToString();
                                    User.Type = reader.GetValue(reader.GetOrdinal("Type")).ToString();
                                    break;
                                }

                            Hide();
                            TxtLogin.Text = "";
                            TxtPassword.Text = "";
                            LeaveText();

                            switch (User.Type)
                            {
                                case "Admin":
                                    if (form_main != null)
                                        form_main.Show();
                                    else
                                        new Form_Main(FindForm()).ShowDialog();
                                    break;
                                case "User":
                                    if (form_user != null)
                                        form_user.Show();
                                    else
                                        new Form_User(FindForm()).ShowDialog();
                                    break;
                            }
                            break;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error: " + e);
            }
            finally
            {
                connect.Close(); // Закрыть соединение
                connect.Dispose(); // Разрушить объект, освободить ресурс
            }
        }

        private void ChangeMode()
        {
            ImageTitle.Focus();
            if (ButtonReg.Text == "Регистрация")
            {
                ButtonReg.Text = "Авторизация";
                ImageBD.Image = Resources.DataReg;
                GroupBoxLogin.Visible = false;
                GroupBoxReg.Visible = true;
                Size = new Size(271, 333);
            }
            else
            {
                ButtonReg.Text = "Регистрация";
                ImageBD.Image = Resources.DataLogin;
                GroupBoxLogin.Visible = true;
                GroupBoxReg.Visible = false;
                Size = new Size(271, 280);
            }
        }

        private void ButtonReg_Click(object sender, EventArgs e) => ChangeMode();

        private void PanelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            PanelMenu.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void TxtNewName_Enter(object sender, EventArgs e)
        {
            TxtNewName.ForeColor = Color.Black;
            TxtNewName.Text = null;
            TxtNewName.Enter -= TxtNewName_Enter;
        }

        private void TxtNewSubname_Enter(object sender, EventArgs e)
        {
            TxtNewSubname.ForeColor = Color.Black;
            TxtNewSubname.Text = null;
            TxtNewSubname.Enter -= TxtNewSubname_Enter;
        }

        private void TxtNewLogin_Enter(object sender, EventArgs e)
        {
            TxtNewLogin.ForeColor = Color.Black;
            TxtNewLogin.Text = null;
            TxtNewLogin.Enter -= TxtNewLogin_Enter;
        }

        private void TxtNewPassword_Enter(object sender, EventArgs e)
        {
            TxtNewPassword.ForeColor = Color.Black;
            TxtNewPassword.Text = null;
            TxtNewPassword.Enter -= TxtNewPassword_Enter;
            TxtNewPassword.UseSystemPasswordChar = true;
        }

        private void TxtLogin_Enter(object sender, EventArgs e)
        {
            TxtLogin.ForeColor = Color.Black;
            TxtLogin.Text = null;
            TxtLogin.Enter -= TxtLogin_Enter;
        }

        private void TxtPassword_Enter(object sender, EventArgs e)
        {
            TxtPassword.ForeColor = Color.Black;
            TxtPassword.Text = null;
            TxtPassword.Enter -= TxtPassword_Enter;
            TxtPassword.UseSystemPasswordChar = true;
        }

        private void TxtLeave(object sender, EventArgs e) => LeaveText();

        private void LeaveText()
        {
            if (TxtNewName.Text == "")
            {
                TxtNewName.ForeColor = Color.Gray;
                TxtNewName.Text = "Введите имя";
                TxtNewName.Enter += TxtNewName_Enter;
            }

            if (TxtNewSubname.Text == "")
            {
                TxtNewSubname.ForeColor = Color.Gray;
                TxtNewSubname.Text = "Введите фамилию";
                TxtNewSubname.Enter += TxtNewSubname_Enter;
            }

            if (TxtNewLogin.Text == "")
            {
                TxtNewLogin.ForeColor = Color.Gray;
                TxtNewLogin.Text = "Введите логин";
                TxtNewLogin.Enter += TxtNewLogin_Enter;
            }

            if (TxtNewPassword.Text == "")
            {
                TxtNewPassword.ForeColor = Color.Gray;
                TxtNewPassword.Text = "Введите пароль";
                TxtNewPassword.Enter += TxtNewPassword_Enter;
                TxtNewPassword.UseSystemPasswordChar = false;
            }

            if (TxtLogin.Text == "")
            {
                TxtLogin.ForeColor = Color.Gray;
                TxtLogin.Text = "Введите логин";
                TxtLogin.Enter += TxtLogin_Enter;
            }

            if (TxtPassword.Text == "")
            {
                TxtPassword.ForeColor = Color.Gray;
                TxtPassword.Text = "Введите пароль";
                TxtPassword.Enter += TxtPassword_Enter;
                TxtPassword.UseSystemPasswordChar = false;
            }
        }

        private void ButtonLoginActive(object sender, EventArgs e)
        {
            if (TxtLogin.Text != "" && TxtLogin.ForeColor != Color.Gray && TxtPassword.Text != "" && TxtPassword.ForeColor != Color.Gray && ComboBoxServer.SelectedItem != null)
                ButtonLogin.Enabled = true;
            else
                ButtonLogin.Enabled = false;
        }

        private void ButtonRegActive(object sender, EventArgs e)
        {
            if (TxtNewLogin.Text != "" && TxtNewName.Text != "" && TxtNewPassword.Text != "" && TxtNewSubname.Text != "" && TxtNewName.ForeColor != Color.Gray && TxtNewSubname.ForeColor != Color.Gray && TxtNewLogin.ForeColor != Color.Gray && TxtNewPassword.ForeColor != Color.Gray)
                ButtonRegistr.Enabled = true;
            else
                ButtonRegistr.Enabled = false;
        }

        private void ComboBoxServer_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBoxServer.DropDownStyle == ComboBoxStyle.Simple)
                User.Server = ComboBoxServer.Text;
            else
                User.Server = ComboBoxServer.SelectedItem.ToString();
        }

        private void LinkLabelPasswordRecovery_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e) => MessageBox.Show("Форма восстановления пароля в разработке...", "Оповещение");

        private void ButtonRegistr_Click(object sender, EventArgs e)
        {
            if (ComboBoxServer.SelectedItem != null)
            {
                ImageTitle.Focus();
                if (new Form_Main_AddUser().AddUser(TxtNewName.Text, TxtNewSubname.Text, TxtNewLogin.Text, TxtNewPassword.Text, "User"))
                {
                    ChangeMode();
                    MessageBox.Show("Регистрация прошла успешно.", "Успех");
                }
                else
                    MessageBox.Show("Данный логин уже занят!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
                MessageBox.Show("Прежде укажите сервер!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
    }
}