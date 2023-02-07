using DataBase.Properties;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form_UserSettings : Form
    {
        public Form_UserSettings(string set)
        {
            InitializeComponent();

            Icon = Icon.FromHandle(Resources.Database.GetHicon());
            PanelMenu.BackColor = ButtonSave.BackColor = Settings.Default.PanelMenuColor;

            LabelSet.Text = set;

            if (set == "Введите новый пароль:")
                TxtSet.UseSystemPasswordChar = true;
        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            LabelSet.Focus();

            if (TxtSet.Text != "")
            {
                switch (LabelSet.Text)
                {
                    case "Введите новое имя:":
                        SQLServerConnect(string.Format(
                        "update InfoUsers set Name='{0}' where ID = {1}", TxtSet.Text, User.ID));
                        break;
                    case "Введите новую фамилию:":
                        SQLServerConnect(string.Format(
                        "update InfoUsers set Subname='{0}' where ID = {1}", TxtSet.Text, User.ID));
                        break;
                    case "Введите новый логин:":
                        SQLServerConnect(string.Format(
                        "update RegUsers set Login='{0}' where ID = {1}", TxtSet.Text, User.ID));
                        break;
                    case "Введите новый пароль:":
                        SQLServerConnect(string.Format(
                        "update RegUsers set Password='{0}' where ID = {1}", TxtSet.Text, User.ID));
                        break;
                }
                Close();
            }
        }

        private void SQLServerConnect(string command)
        {
            SqlConnection connect = new SqlConnection(string.Format(
                "Data Source={0}; Initial Catalog=DbUsers; Integrated Security = true;", User.Server));

            try
            {
                connect.Open();
                new SqlCommand(command, connect).ExecuteReader();
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

        private void ButtonClose_Click(object sender, EventArgs e) => Close();

        private void PanelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            PanelMenu.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }
    }
}