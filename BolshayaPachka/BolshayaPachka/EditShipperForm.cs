using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace BolshayaPachka
{
    public partial class EditShipperForm : Form
    {
        private List<TextBox> txtBoxList;
        MSSconnection DB = new MSSconnection();
        int selId, actionId, selType = 1;

        public EditShipperForm()
        {
            InitializeComponent();
        }

        private void EditShipperForm_Load(object sender, EventArgs e)
        {
            actionType.SelectedIndex = actionId = Main.selectedShipperAction;
            shipperList.DisplayMember = Type.DisplayMember = "Title";
            shipperList.ValueMember = Type.ValueMember = "ID";
            actionType.Focus();
            updateShipperList();
        }

        //обновление подсказок и данных
        private void updateShipperList() {
            DataTable table = DB.ExecuteSqlCommand("SELECT [ID], [Title] FROM [dbo].[Shipper]");
            DataTable table2 = DB.ExecuteSqlCommand("SELECT * FROM [dbo].[ShipperTypes]");
            Type.DataSource = table2;
            shipperList.DataSource = table;
            if(actionId == 2) Type.SelectedValue = 0;
        }

        //Присвоение полям значений из  таблицы поставщиков с объединением
        private void shipperList_SelectedValueChanged(object sender, EventArgs e)
        {
            if (shipperList.SelectedValue == null || actionId == 2) return;
            UpdateAllFieldsOnForm();
        }

        private void UpdateAllFieldsOnForm() {
            selId = Convert.ToInt32(shipperList.SelectedValue);
            string sql = $"SELECT [Shipper].[ID], [Shipper].[Title], [ShipperTypes].[Title] AS 'Type', [INN], [Quality], [StartTime] FROM [dbo].[Shipper] JOIN [dbo].[ShipperTypes] ON [ShipperTypes].[ID] = [Shipper].[TypeID] WHERE [Shipper].[ID] = {selId}";
            DataTable table = DB.ExecuteSqlCommand(sql);

            Type.Text = (string)table.Rows[0]["Type"];
            StartTime.Value = (DateTime)table.Rows[0]["StartTime"];
            for (int i = 0; i < txtBoxList.Count; i++)
                foreach (DataColumn col in table.Columns)
                    if (col.ColumnName == txtBoxList[i].Name) txtBoxList[i].Text = table.Rows[0][col.ColumnName].ToString();
        }

        private void process_Click(object sender, EventArgs e)
        {
            switch (actionId) {
                case 0:
                    DeleteData();
                    break;
                case 1:
                    UpdateData();
                    break;
                case 2:
                    AddData();
                    break;
            }
        }

        //В зависимости от действия, делать поля доступными или очищать их
        private void actionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            bool clearIt = false, flag = false, listIsNull = false;
            if (shipperList.SelectedValue == null) listIsNull = true;
            actionId = actionType.SelectedIndex;

            txtBoxList = new List<TextBox>() {
                Title,
                INN,
                Quality
            };

            switch (actionId)
            {
                case 0:
                    flag = false;
                    if(!listIsNull) UpdateAllFieldsOnForm();
                    if(!shipperList.Enabled) shipperList.Enabled = true;
                    break;
                case 1:
                    flag = true;
                    if (!listIsNull) UpdateAllFieldsOnForm();
                    if (!shipperList.Enabled) shipperList.Enabled = true;
                    break;
                case 2:
                    flag = true;
                    clearIt = true;
                    if (shipperList.Enabled) shipperList.Enabled = false;
                    break;
            }

            for (int i = 0; i < txtBoxList.Count; i++) {
                txtBoxList[i].Enabled = flag;
                if (clearIt) txtBoxList[i].Text = "";
            }

            StartTime.Enabled = Type.Enabled = flag;
            if (clearIt) Type.Text = "";
        }

        //Удаление выбранной записи
        private void DeleteData() {
            string sql = $"DELETE FROM [dbo].[Shipper] WHERE [ID] = {selId}";
            SqlCommand command = new SqlCommand(sql, DB.getConnection());
            Attension attension = new Attension("Удаление приведет к потере данных о поставках.");
            attension.ShowDialog();

            if (attension.GetAction()) return;
            DB.openConnection();

            try {
                command.ExecuteNonQuery();
                MessageBox.Show("Данные были успешно удалены","Успех");
                DB.UpdateMainShipper();
                DB.UpdateMainMaterial();
                updateShipperList();
            }
            catch(Exception exp) {
                MessageBox.Show($"Не удалось выполнить операцию:\n{exp.Message}", "Ошибка");
            }
            finally {
                DB.closeConnection();
            }
        }

        //Проверка полей на корректное заполнение
        private bool CheckFields() {
            bool correct = true;
            foreach (TextBox tbox in txtBoxList) if (tbox.Text == "") correct = false;
            if (Type.Text == "") correct = false;
            return correct;
        }


        //Обновление полей в таблице поставщика
        private void UpdateData() {

            if (!CheckFields())
            {
                MessageBox.Show("Пропущены обязательные поля для ввода, примите изменения и повторите попытку", "Ошибка");
                return;
            }

            selType = Convert.ToInt32(Type.SelectedValue);
            if (selType == 0)
            {
                string setNewTypeSql = $"INSERT INTO [dbo].[ShipperTypes] VALUES ('{Type.Text}'); SELECT MAX(ID) AS 'ID' FROM [dbo].[ShipperTypes];";
                DataTable validTypeTable = DB.ExecuteSqlCommand(setNewTypeSql);
                selType = (int)validTypeTable.Rows[0]["ID"];
            }

            List<string> updateStrings = new List<string>();
            updateStrings.Add("UPDATE [dbo].[Shipper] SET");
            foreach (TextBox tbox in txtBoxList) {
                updateStrings.Add($" [{tbox.Name}] = '{tbox.Text}', ");
            }

            
            string sql = string.Join("", updateStrings) + $"[TypeID] = '{selType}', [StartTime] = '{StartTime.Value}' WHERE [ID] = {selId};";
            SqlCommand command = new SqlCommand(sql, DB.getConnection());
            DB.openConnection();

            try
            {
                command.ExecuteNonQuery();
                MessageBox.Show("Данные были успешно изменены", "Успех");
                DB.UpdateMainShipper();
                DB.UpdateMainMaterial();
                updateShipperList();
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Не удалось выполнить операцию:\n{exp.Message}", "Ошибка");
            }
            finally
            {
                DB.closeConnection();
            }
        }

        private void navBack_Click(object sender, EventArgs e)
        {
            Main form = new Main();
            form.Show();
            Hide();
        }

        //Ввод только чисел в числовые поля для отправки в бд
        private void INN_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true;
        }

        //Не допустить рейтинг выше 100 в поле
        private void Quality_Leave(object sender, EventArgs e)
        {
            if (Quality.Text == "") return;
            if (Convert.ToInt32(Quality.Text) > 100) Quality.Text = "100";
        }

        //добавление в таблицу поставщиков новой записи
        private void AddData()
        {

            if (!CheckFields())
            {
                MessageBox.Show("Пропущены обязательные поля для ввода, примите изменения и повторите попытку", "Ошибка");
                return;
            }

            selType = Convert.ToInt32(Type.SelectedValue);
            if (selType == 0)
            {
               string setNewTypeSql = $"INSERT INTO [dbo].[ShipperTypes] VALUES ('{Type.Text}'); SELECT MAX(ID) AS 'ID' FROM [dbo].[ShipperTypes];";
               DataTable validTypeTable = DB.ExecuteSqlCommand(setNewTypeSql);
               selType = (int)validTypeTable.Rows[0]["ID"];
            }

            List<string> addStrings = new List<string>();
            string sym;
            addStrings.Add("INSERT INTO [dbo].[Shipper]([Title], [INN], [Quality], [TypeID], [StartTime]) VALUES ");
            foreach (TextBox tbox in txtBoxList)
            {
                if (tbox.Name == "Title") sym = "(";
                else sym = "";
                addStrings.Add($"{sym}'{tbox.Text}', ");
            }

            string sql = string.Join("", addStrings) + $" '{selType}', '{StartTime.Value}'); SELECT MAX(ID) AS 'ID' FROM [dbo].[Shipper]";
            DataTable validShipperId;
            DB.openConnection();

            try
            {
                validShipperId = DB.ExecuteSqlCommand(sql);
                updateShipperList();
                actionType.SelectedIndex = 1;
                shipperList.SelectedValue = validShipperId.Rows[0]["ID"];
                DB.UpdateMainShipper();
                MessageBox.Show("Данные были успешно добавлены", "Успех");
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Не удалось выполнить операцию:\n{exp.Message}", "Ошибка");
            }
            finally
            {
                DB.closeConnection();
            }
        }
    }
}
