using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BolshayaPachkaLibrary
{
    public class PachkaClass
    {
        static string conenctionString = ConfigurationManager.ConnectionStrings["MSSconnection"].ConnectionString;
        private SqlConnection connection = new SqlConnection(conenctionString);

        //открыть подключение
        public void openConnection()
        {
            if (connection.State == ConnectionState.Closed)
            {
                connection.Open();
            }
        }

        //закрыть  подключение
        public void closeConnection()
        {
            if (connection.State == ConnectionState.Open)
            {
                connection.Close();
            }
        }

        public int SelectMaxID(string tableName) {
            DataTable table = ExecuteSqlCommand($"SELECT MAX(ID) AS 'ID' FROM [dbo].[${tableName}]");
            int maxid = (int)table.Rows[0]["ID"];
            return maxid;
        }

        //подключение
        public SqlConnection getConnection()
        {
            return connection;
        }

        //Выполнение комманд sql
        public DataTable ExecuteSqlCommand(string sql)
        {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(sql, getConnection());
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }
    }
}
