using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace BolshayaPachka
{
    class MSSconnection
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

        //подключение
        public SqlConnection getConnection() {
            return connection;
        }

        //Выполнение комманд sql
        public DataTable ExecuteSqlCommand(string sql) {
            SqlDataAdapter adapter = new SqlDataAdapter();
            SqlCommand command = new SqlCommand(sql, getConnection());
            DataTable table = new DataTable();
            adapter.SelectCommand = command;
            adapter.Fill(table);
            return table;
        }

        public void UpdateMainMaterial()
        {
            string sql = "DROP VIEW IF EXISTS [dbo].[MainInfo];";
            string sql2 = "CREATE VIEW [dbo].[MainInfo] AS SELECT[Material].[TItle] AS 'Наименование', [MaterialTypes].[Title] AS 'Тип', [Shipper].[Title] AS 'Поставщик', [Material].[Coast] AS 'Стоимость',[Material].[Amount] AS 'Количество', [Material].[MinAmount] AS 'Минимальное количество', [Material].[Package] AS 'В одной упаковке', [UnitTypes].[Title] AS 'Единицы' from[dbo].[TotalShippers] join [dbo].[Material] on [TotalShippers].[MaterialID] = [Material].[ID] join [dbo].[Shipper] on [TotalShippers].[ShipperID] = [Shipper].[ID] join [dbo].[MaterialTypes] ON [MaterialTypes].[ID] = [Material].[TypeID] join [dbo].[UnitTypes] ON [UnitTypes].[ID] = [Material].[UnitID];";
            SqlCommand commad = new SqlCommand(sql, getConnection());
            SqlCommand command2 = new SqlCommand(sql2, getConnection());
            commad.ExecuteNonQuery();
            command2.ExecuteNonQuery();
        }
        public void UpdateMainShipper()
        {
            string sql = "DROP VIEW IF EXISTS [dbo].[ShipperInfo];";
            string sql2 = "CREATE VIEW [dbo].[ShipperInfo] AS SELECT [Shipper].[Title] AS 'Наименование', [ShipperTypes].[Title] AS 'Тип организации', [INN] AS 'ИНН', [Quality]  AS 'Качество', [StartTime] AS 'Начало работы' FROM [dbo].[Shipper] join [dbo].[ShipperTypes] ON [ShipperTypes].[ID] = [Shipper].[TypeID];";
            SqlCommand commad = new SqlCommand(sql, getConnection());
            SqlCommand command2 = new SqlCommand(sql2, getConnection());
            commad.ExecuteNonQuery();
            command2.ExecuteNonQuery();
        }
    }
}
