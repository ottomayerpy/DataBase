using DataBase.Properties;
using System;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace DataBase
{
    public partial class Form_Main_RemoveUser : Form
    {
        public Form_Main_RemoveUser()
        {
            InitializeComponent();
            Icon = Icon.FromHandle(Resources.Database.GetHicon());
            PanelMenu.BackColor = ButtonRemove.BackColor = Settings.Default.PanelMenuColor;
        }

        private void ButtonRemove_Click(object sender, EventArgs e)
        {
            if (TxtID.Text != "")
            {
                SQLServerConnect(string.Format("DELETE FROM RegUsers WHERE ID = '{0}'", TxtID.Text));
                SQLServerConnect(string.Format("DELETE FROM InfoUsers WHERE ID = '{0}'", TxtID.Text));
                TxtID.Text = null;
                TxtID.Focus();
            }
        }

        private void SQLServerConnect(string command)
        {
            SqlConnection connect = new SqlConnection(string.Format(
                "Data Source={0}; Initial Catalog=DbUsers; Integrated Security = true;", User.Server));
            connect.Open();

            try
            {
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

        private void TxtID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}