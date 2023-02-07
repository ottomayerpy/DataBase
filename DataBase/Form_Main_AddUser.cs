using DataBase.Properties;
using System;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form_Main_AddUser : Form
    {
        int NewID;
        string typeuser = "User";

        public Form_Main_AddUser()
        {
            InitializeComponent();
            Icon = Icon.FromHandle(Resources.Database.GetHicon());
            PanelMenu.BackColor = ButtonAdd.BackColor = Settings.Default.PanelMenuColor;
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            if (AddUser(TxtName.Text, TxtSubname.Text, TxtLogin.Text, TxtPassword.Text, typeuser))
                MessageBox.Show("Пользователь успешно добавлен.", "Успех");
            else
                MessageBox.Show("Данный логин уже занят!", "Ошибка регистрации", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public bool AddUser(string name, string subname, string login, string password, string type)
        {
            if (!SQLServerConnect("select * from RegUsers", "GetLogin", login))
                return false;

            SQLServerConnect("select * from RegUsers", "GetID");

            SQLServerConnect(string.Format(
                    "INSERT INTO RegUsers (Login, Password, ID) VALUES ('{0}', '{1}', '{2}')", login, password, NewID));

            SQLServerConnect(string.Format(
                    "INSERT INTO InfoUsers (Name, Subname, Type, ID) VALUES ('{0}', '{1}', '{2}', '{3}')", name, subname, type, NewID));
            Close();
            return true;
        }

        private bool SQLServerConnect(string command, string mode = null, string reglogin = null)
        {
            SqlConnection connect = new SqlConnection(string.Format(
                "Data Source={0}; Initial Catalog=DbUsers; Integrated Security = true;", User.Server));

            try
            {
                connect.Open();
                using (DbDataReader reader = new SqlCommand(command, connect).ExecuteReader())
                {
                    if (mode == "GetID")
                    {
                        while (reader.Read())
                            NewID = Convert.ToInt32(reader.GetValue(reader.GetOrdinal("ID")));
                        NewID++;
                    }
                    else if (mode == "GetLogin")
                    {
                        while (reader.Read())
                            if (reglogin == reader.GetValue(reader.GetOrdinal("Login")).ToString())
                                return false;
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

            return true;
        }

        private void TxtName_Enter(object sender, EventArgs e)
        {
            TxtName.ForeColor = Color.Black;
            TxtName.Text = null;
            TxtName.Enter -= TxtName_Enter;
        }

        private void TxtSubname_Enter(object sender, EventArgs e)
        {
            TxtSubname.ForeColor = Color.Black;
            TxtSubname.Text = null;
            TxtSubname.Enter -= TxtSubname_Enter;
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
        }

        private void RButton_Changed(object sender, EventArgs e)
        {
            if (RButtonAdmin.Checked)
            {
                RButtonUser.Checked = false;
                typeuser = "Admin";
            }
            else
            {
                RButtonAdmin.Checked = false;
                typeuser = "User";
            }
        }

        private void ButtonAddActive(object sender, EventArgs e)
        {
            if (TxtLogin.Text != "" && TxtName.Text != "" && TxtPassword.Text != "" && TxtSubname.Text != "" && TxtName.ForeColor != Color.Gray && TxtSubname.ForeColor != Color.Gray && TxtLogin.ForeColor != Color.Gray && TxtPassword.ForeColor != Color.Gray)
                ButtonAdd.Enabled = true;
            else
                ButtonAdd.Enabled = false;
        }

        private void LeaveText()
        {
            if (TxtName.Text == "")
            {
                TxtName.ForeColor = Color.Gray;
                TxtName.Text = "Введите имя";
                TxtName.Enter += TxtName_Enter;
            }

            if (TxtSubname.Text == "")
            {
                TxtSubname.ForeColor = Color.Gray;
                TxtSubname.Text = "Введите фамилию";
                TxtSubname.Enter += TxtSubname_Enter;
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
            }
        }

        private void ButtonClose_Click(object sender, EventArgs e) => Close();

        private void Txt_Leave(object sender, EventArgs e) => LeaveText();

        private void PanelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            PanelMenu.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
    }
}
