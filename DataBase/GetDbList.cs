using System.Data;
using System.Data.SqlClient;
using System.Collections.Generic;

namespace DataBase
{
    static class GetDbList
    {
        public static List<string> GetList(string datasource)
        {
            try
            {
                SqlConnectionStringBuilder conStr = new SqlConnectionStringBuilder
                {
                    DataSource = datasource,
                    IntegratedSecurity = true
                };

                DataTable table = new DataTable("Dbs");

                using (SqlConnection connect = new SqlConnection(conStr.ToString()))
                {
                    new SqlDataAdapter("SELECT name FROM sys.databases WHERE database_id > 4", connect).Fill(table);
                }

                List<string> list = new List<string>();

                for (int i = 0; i < table.Rows.Count; i++)
                    list.Add(table.Rows[i][0].ToString());

                return list;
            }
            catch
            {
                return null;
            }
        }
    }
}