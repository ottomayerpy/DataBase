using System;
using System.Data.Common;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Drawing;
using DataBase.Properties;

namespace DataBase
{
    public partial class Form_Main : Form
    {
        // EditRowTable  Коректное исполнения события редактирования таблицы в DataGridTable
        // EditTable     Управление кнопкой вкл/выкл редактирование таблицы
        // Maximize      Управление кнопкой развернуть/восстановить окно
        bool EditRowTable, EditTable, Maximize;
        Form form; // Для экземпляра Form_Login

        protected override void OnPaint(PaintEventArgs e)
        {
            Rectangle rc = new Rectangle(ClientSize.Width - 16, ClientSize.Height - 16, 16, 16);
            ControlPaint.DrawSizeGrip(e.Graphics, BackColor, rc);
            rc = new Rectangle(0, 0, ClientSize.Width, 32);
            e.Graphics.FillRectangle(Brushes.DarkBlue, rc);

            if (WindowState == FormWindowState.Maximized)
            {
                Maximize = true;
                ToolTipHelp.SetToolTip(ButtonMaximize, "Восстановить");
                ButtonMaximize.Image = Resources.Restoration_Window;
            }
            if (WindowState == FormWindowState.Normal)
            {
                Maximize = false;
                ToolTipHelp.SetToolTip(ButtonMaximize, "Развернуть");
                ButtonMaximize.Image = Resources.Maximize;
            }
        }

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                Point pos = new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16);
                pos = PointToClient(pos);

                if (pos.Y < 32)
                {
                    m.Result = (IntPtr)2;
                    return;
                }

                if (pos.X >= ClientSize.Width - 16 && pos.Y >= ClientSize.Height - 16)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }
            base.WndProc(ref m);
        }

        public Form_Main(Form form)
        {
            InitializeComponent();
            DoubleBuffered = true;
            SetStyle(ControlStyles.ResizeRedraw, true);
            Icon = Icon.FromHandle(Resources.Database.GetHicon()); // Ставим иконку
            PanelMenu.BackColor = Settings.Default.PanelMenuColor; // Ставим цвет верхней панели

            if (form != null)
                this.form = form; // Передаем экземпляр в глобальную переменную

            foreach (string s in GetDbList.GetList(User.Server))
                ComboBoxDataBase.Items.Add(s); // Получаем имена баз данных сервера
        }

        private void SQLServerConnect(string command, string mode, string DataBase = null)
        {
            if (DataBase == null)
                DataBase = ComboBoxDataBase.SelectedItem.ToString();

            SqlConnection connect = new SqlConnection(string.Format(
                "Data Source={0}; Initial Catalog={1}; Integrated Security = true;", User.Server, DataBase));
            connect.Open();

            try
            {
                using (DbDataReader reader = new SqlCommand(command, connect).ExecuteReader())
                {
                    switch (mode)
                    {
                        case "GetColumnTable": // Добавляем колонки в гриде
                            while (reader.Read())
                                DataGridTable.Columns.Add(reader.GetString(0), reader.GetString(0));
                            break;
                        case "GetValueTable": // Заполняем значения строк в гриде
                            while (reader.Read())
                            {
                                int n = DataGridTable.Rows.Add();
                                for (int i = 0; i < DataGridTable.ColumnCount; i++)
                                    DataGridTable.Rows[n].Cells[i].Value = reader[i].ToString();
                            }
                            break;
                        case "GetCountListTable": // Заполняем ComboBoxTable списком таблиц в базе
                            while (reader.Read())
                                ComboBoxTable.Items.Add(reader.GetString(0));
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

        private void ComboBoxTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Убрать
            ButtonEditTable.Image = Resources.EditUser;
            DataGridTable.ReadOnly = true;
            EditTable = false;
            ToolTipHelp.SetToolTip(ButtonEditTable, "Включить редактирование таблицы");
            // Убрать

            RefreshTable();
        }

        private void RefreshTable()
        {
            DataGridTable.Columns.Clear(); // Чистим DataGrid
            SQLServerConnect(string.Format("SELECT COLUMN_NAME FROM {1}.INFORMATION_SCHEMA.COLUMNS WHERE TABLE_NAME = '{0}'"
                , ComboBoxTable.SelectedItem.ToString(), ComboBoxDataBase.SelectedItem.ToString()), "GetColumnTable"); // Получаем информацию о столбцах в таблице
            SQLServerConnect("select * from " + ComboBoxTable.SelectedItem.ToString(), "GetValueTable"); // Получаем значения таблицы

            for (int i = 0; i <= DataGridTable.Columns.Count - 1; i++)
                DataGridTable.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill; // Задаем динамическое изменение ширины столбцов относительно формы
        }

        private void ComboBoxDataBase_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Убрать
            ButtonEditTable.Image = Resources.EditUser;
            DataGridTable.ReadOnly = true;
            EditTable = false;
            ToolTipHelp.SetToolTip(ButtonEditTable, "Включить редактирование таблицы");
            // Убрать

            ComboBoxTable.Items.Clear();
            DataGridTable.Columns.Clear();
            SQLServerConnect("SELECT TABLE_NAME FROM information_schema.tables", "GetCountListTable"); // Получаем список таблиц из базы данных
        }

        private void DataGridTable_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (EditRowTable)
            {
                EditRowTable = false;
                int Column = 0;

                for (int i = 0; i < DataGridTable.Columns.Count; i++)
                    if (DataGridTable.Columns[i].HeaderText.ToString() == "ID")
                    {
                        Column = i;
                        break;
                    }

                SQLServerConnect(string.Format("update {0} set {1}='{2}' where ID = {3}",
                    ComboBoxTable.SelectedItem.ToString(),
                    DataGridTable.Columns[DataGridTable.CurrentCell.ColumnIndex].HeaderText.ToString(),
                    DataGridTable.CurrentCell.Value,
                    DataGridTable[Column, DataGridTable.CurrentCell.RowIndex].Value
                    ), null);
            }
            else
                EditRowTable = true;
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e) => Application.Exit();

        private void ButtonMaximize_Click(object sender, EventArgs e) => WindowState = !Maximize ? FormWindowState.Maximized : FormWindowState.Normal;

        private void ButtonMinimize_Click(object sender, EventArgs e) => WindowState = FormWindowState.Minimized;

        private void ButtonClose_Click(object sender, EventArgs e) => Application.Exit();

        private void PanelMenu_MouseDown(object sender, MouseEventArgs e)
        {
            PanelMenu.Capture = false;
            Message m = Message.Create(Handle, 0xa1, new IntPtr(2), IntPtr.Zero);
            WndProc(ref m);
        }

        private void ButtonUserExit_Click(object sender, EventArgs e)
        {
            Hide();
            form.Show();
        }

        private void ButtonAddUser_Click(object sender, EventArgs e)
        {
            DarkBackground(true);
            new Form_Main_AddUser().ShowDialog();
            DarkBackground(false);
        }

        private void ButtonRefresh_Click(object sender, EventArgs e)
        {
            if (ComboBoxTable.SelectedItem != null)
                RefreshTable();
        }

        private void DarkBackground(bool dark)
        {
            if (dark)
            {
                BackColor = SystemColors.ControlDark;
                DataGridTable.BackgroundColor = SystemColors.ControlDark;
                for (int u = 0; u < DataGridTable.Columns.Count; u++)
                {
                    DataGridTable.Columns[u].HeaderCell.Style.BackColor = SystemColors.ControlDark;
                    for (int i = 0; i < DataGridTable.RowCount; i++)
                        DataGridTable[u, i].Style.BackColor = SystemColors.ControlDark;
                }

                DataGridTable.RowHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
                DataGridTable.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
                DataGridTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // изменить вид границы по вкусу
                DataGridTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None; // изменить вид границы по вкусу
                DataGridTable.EnableHeadersVisualStyles = false;
            }
            else
            {
                BackColor = SystemColors.ControlLightLight;
                DataGridTable.BackgroundColor = SystemColors.ControlLightLight;
                for (int u = 0; u < DataGridTable.Columns.Count; u++)
                {
                    DataGridTable.Columns[u].HeaderCell.Style.BackColor = SystemColors.ControlLightLight;
                    for (int i = 0; i < DataGridTable.RowCount; i++)
                        DataGridTable[u, i].Style.BackColor = SystemColors.ControlLightLight;
                }

                DataGridTable.RowHeadersDefaultCellStyle.BackColor = SystemColors.ControlLightLight;
                DataGridTable.ColumnHeadersDefaultCellStyle.BackColor = SystemColors.ControlLightLight;
                DataGridTable.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single; // изменить вид границы по вкусу
                DataGridTable.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single; // изменить вид границы по вкусу
                DataGridTable.EnableHeadersVisualStyles = true;
            }
        }

        private void ButtonRemoveUser_Click(object sender, EventArgs e)
        {
            DarkBackground(true);
            new Form_Main_RemoveUser().ShowDialog();
            DarkBackground(false);
        }

        private void ButtonEditTable_Click(object sender, EventArgs e) => EditingTabel();

        private void EditingTabel()
        {
            if ((ComboBoxTable.SelectedItem != null || ComboBoxTable.SelectedItem != null) && ComboBoxDataBase.SelectedItem != null)
                if ((ComboBoxTable.SelectedItem.ToString() == "RegUsers" || ComboBoxTable.SelectedItem.ToString() == "InfoUsers") && ComboBoxDataBase.SelectedItem.ToString() == "DbUsers")
                    if (EditTable)
                    {
                        ButtonEditTable.Image = Resources.EditUser;
                        DataGridTable.ReadOnly = true;
                        EditTable = false;
                        ToolTipHelp.SetToolTip(ButtonEditTable, "Включить редактирование таблицы");
                    }
                    else
                    {
                        ButtonEditTable.Image = Resources.Edit;
                        DataGridTable.ReadOnly = false;
                        DataGridTable.Columns["ID"].ReadOnly = true;
                        EditTable = true;
                        ToolTipHelp.SetToolTip(ButtonEditTable, "Выключить редактирование таблицы");
                    }
                else
                    MessageBox.Show("Не возможно редактировать данную таблицу!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            DarkBackground(true);
            new Form_Settings().ShowDialog();
            DarkBackground(false);
        }
    }
}