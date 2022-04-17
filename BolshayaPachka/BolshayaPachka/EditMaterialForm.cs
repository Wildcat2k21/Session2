using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;

namespace BolshayaPachka
{
    public partial class EditMaterialForm : Form
    {
        MSSconnection DB = new MSSconnection();
        private string imageName = "";
        private DataTable shipInfo;
        private List<int> deleteShipperList = new List<int>();
        private List<int> addShipperList = new List<int>();
        private List<TextBox> textBoxList;
        private List<ComboBox> comBoxList;
        private int materID, selMatId = 1;


        public EditMaterialForm()
        {
            InitializeComponent();
        }

        private void DeleteMaterial_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bolshayaPachkaDataSet1.Shipper". При необходимости она может быть перемещена или удалена.
            this.shipperTableAdapter.Fill(this.bolshayaPachkaDataSet1.Shipper);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "bolshayaPachkaDataSet.Material". При необходимости она может быть перемещена или удалена.
            this.materialTableAdapter.Fill(this.bolshayaPachkaDataSet.Material);

            shipperList.DisplayMember = "Title";
            shipperList.ValueMember = "ShipperID";
            selectMaterial.DisplayMember = "Title";
            selectMaterial.ValueMember = "ID";
            Type.DisplayMember = "Title";
            Type.ValueMember = "ID";
            Unit.DisplayMember = "Title";
            Unit.ValueMember = "ID";
            updateTitles();

            actionType.SelectedIndex = Main.selectedMaterialAction;
            actionType.Select();
        }

        //обновление полей с выбором материала в списке
        private void selectMaterial_SelectedValueChanged(object sender, EventArgs e)
        {
            if (selectMaterial.SelectedValue == null || actionType.SelectedIndex == 2) return;
            materID = (int)selectMaterial.SelectedValue;
            updateFilds();
        }

        //Выбор действия на форме
        private void actionType_SelectedValueChanged(object sender, EventArgs e)
        {
            if (selectMaterial.Text == "") return;

            List<Button> btnList = new List<Button>() {
                addShipper,
                clearAllShipperBtn,
                clearShipperBtn
            };

            bool flag = true;
            switch (actionType.SelectedIndex) {

                case 1:
                    selectMaterial.Enabled = true;
                    if (selectMaterial.Text != "") updateFilds();
                    break;

                case 0:
                    flag = false;
                    selectMaterial.Enabled = true;
                    updateFilds();
                    break;

                case 2:
                    ClearAddActionFields();
                    break;
            }

            //Показывать или скрывать элементы в зависимости от выбранного действия
            for (int i = 0; i < textBoxList.Count; i++) {
                if (i < comBoxList.Count) comBoxList[i].Enabled = flag;
                if (i < btnList.Count) btnList[i].Enabled = flag;
                textBoxList[i].Enabled = flag;
            }

            selectImage.Enabled = shipperList.Enabled = flag;
        }

        private void ClearAddActionFields() {
            for (int i = 0; i < textBoxList.Count; i++)
            {
                if (i < 2) comBoxList[i].SelectedValue = 0;
                textBoxList[i].Text = "";
            }

            shipperCh.SelectedIndex = 0;
            shipInfo.Clear();
            deleteShipperList.Clear();
            addShipperList.Clear();

            selectMaterial.Enabled = false;
            materialPreview.Image = new Bitmap(Directory.GetCurrentDirectory() + @"\bin\img\picture.png");
            imageName = "";
        }

        private void updateFilds() {

            DataTable tableMatInfo;
            string sql = $"SELECT [Material].[Title], [MaterialTypes].[Title] AS 'Type', [Material].[ImagePath], [Material].[Coast], [Material].[Amount], [Material].[MinAmount], [Material].[Package], [UnitTypes].[Title] AS 'Unit' from [dbo].[Material] join [dbo].[MaterialTypes] ON [MaterialTypes].[ID] = [Material].[TypeID] join [dbo].[UnitTypes] ON [UnitTypes].[ID] = [Material].[UnitID] WHERE [Material].[ID] = {materID}";
            tableMatInfo = DB.ExecuteSqlCommand(sql);

            textBoxList = new List<TextBox>() {
                Title,
                Coast,
                Amount,
                MinAmount,
                Package
            };

            comBoxList = new List<ComboBox>() {
                Type,
                Unit,
                shipperCh
            };

            imageName = tableMatInfo.Rows[0][2].ToString();
            for (int i = 0; i < textBoxList.Count; i++) {
                foreach (DataColumn col in tableMatInfo.Columns)
                {
                    if (col.ColumnName == textBoxList[i].Name) textBoxList[i].Text = tableMatInfo.Rows[0][col.ColumnName].ToString();
                    if (i < comBoxList.Count && col.ColumnName == comBoxList[i].Name) comBoxList[i].Text = tableMatInfo.Rows[0][col.ColumnName].ToString();
                }
            }

            //Получение списка поставщиков для материала
            string sql2 = $"SELECT [ShipperID], [Title] from [dbo].[TotalShippers] join [Shipper] ON [ID] = [ShipperID] WHERE [MaterialID] = {materID};";
            shipInfo = DB.ExecuteSqlCommand(sql2);

            shipperList.DataSource = shipInfo;
            deleteShipperList.Clear();
            addShipperList.Clear();

            if (imageName == "") materialPreview.Image = new Bitmap(Directory.GetCurrentDirectory() + @"\bin\img\picture.png");
            else materialPreview.Image = new Bitmap(Directory.GetCurrentDirectory() + $@"\img\{imageName}");
        }

        //выбор картинки
        private void button1_Click(object sender, EventArgs e)
        {
            Bitmap image;
            OpenFileDialog file = new OpenFileDialog();
            file.Filter = "Image Files(*.JPG;*.PNG;*.JPEG)|*.JPG;*.PNG;*.JPEG|All files (*.*)|*.*";
            file.InitialDirectory = Directory.GetCurrentDirectory() + @"\img";
            if (file.ShowDialog() == DialogResult.OK)
            {
                imageName = Path.GetFileNameWithoutExtension(file.FileName) + ".jpeg";
                if (imageName.Length > 50) {
                    MessageBox.Show("Название выбранного файла не должно превышать 45-ти символов");
                    return;
                }

                materialPreview.Image = image = new Bitmap(file.FileName);

                try {
                    if (!File.Exists(Directory.GetCurrentDirectory() + $@"\img\{imageName}")) {
                        image.Save(@"img\" + imageName);
                    }
                }
                catch (Exception exp) {
                    MessageBox.Show($"Не удалось открыть файл: \n {exp.Message}", "Внимание");
                }
            }
        }

        //Выполнения выбранного действия на форме по кнопке "Выполнить"
        private void process_Click(object sender, EventArgs e)
        {
            if (actionType.SelectedIndex == 1) updateData();
            else if (actionType.SelectedIndex == 0) deleteData();
            else addData();
        }

        //Ограничение на ввод соответствующих данных бд
        private void packageAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar)) e.Handled = true; ;
        }

        //Режим удаления полей
        private void deleteData() {
            string sql;
            Attension att = new Attension("Удаление этой записи приведет к потери данных о поставках");
            att.ShowDialog();
            if (!att.GetAction()) {
                sql = $"DELETE FROM [dbo].[Material] WHERE [ID] = {materID}";
                SqlCommand command = new SqlCommand(sql, DB.getConnection());
                DB.openConnection();
                try
                {
                    command.ExecuteNonQuery();
                    DB.UpdateMainMaterial();
                    MessageBox.Show("Запись успешно удалена", "Успех");
                }
                catch (Exception exp)
                {
                    MessageBox.Show($"Ошибка выполнения операции \n {exp.Message}", "Ошибка");
                }
                finally
                {
                    DB.closeConnection();
                    updateTitles();
                }
            }
        }

        //режим добавления записи
        private void addData() {

            if (InCorrectDataFields())
                MessageBox.Show("Не удалось сохранить изменения, так как некоторые поля не заполнены, примините изменения и повторите попытку.", "Ошибка");
            else
            {

                int validMatType = Convert.ToInt32(Type.SelectedValue);
                int validUnitType = Convert.ToInt32(Unit.SelectedValue);

                if (validMatType == 0)
                {
                    string setNewTypeSql = $"INSERT INTO [dbo].[MaterialTypes] VALUES ('{Type.Text}'); SELECT MAX(ID) AS 'ID' FROM [dbo].[MaterialTypes];";
                    DataTable validTypeTable = DB.ExecuteSqlCommand(setNewTypeSql);
                    validMatType = (int)validTypeTable.Rows[0]["ID"];
                }

                if (validUnitType == 0)
                {
                    string setNewUnitSql = $"INSERT INTO [dbo].[UnitTypes] VALUES ('{Unit.Text}'); SELECT MAX(ID) AS 'ID' FROM [dbo].[UnitTypes];";
                    DataTable validUnitTable = DB.ExecuteSqlCommand(setNewUnitSql);
                    validUnitType = (int)validUnitTable.Rows[0]["ID"];
                }

                string[] textb = new string[8]{
                    Title.Text,
                    validMatType.ToString(),
                    imageName,
                    Coast.Text,
                    Amount.Text,
                    MinAmount.Text,
                    Package.Text,
                    validUnitType.ToString()
                };

                string sql1 = $"INSERT INTO [dbo].[Material] VALUES ('{textb[0]}','{textb[1]}','{textb[2]}',{textb[3]},{textb[4]},{textb[5]},'{textb[6]}','{textb[7]}') SELECT MAX(ID) AS 'ID' FROM [dbo].[Material]";

                DB.openConnection();
                try
                {
                    DataTable table = DB.ExecuteSqlCommand(sql1);
                    selMatId = (int)table.Rows[0]["ID"];
                    if (addShipperList.Count != 0)
                    {
                        string sql2 = ShipAddSqlPropare(selMatId);
                        SqlCommand shipAdd = new SqlCommand(sql2, DB.getConnection());
                        shipAdd.ExecuteNonQuery();
                        DB.UpdateMainMaterial();
                    }
                    
                    MessageBox.Show("Данные были успешно добавлены", "Успех");
                }
                catch(Exception exp)
                {
                    MessageBox.Show($"Не удалось сохранить изменения, детали\n{exp.Message}", "Ошибка");
                }
                finally {
                    DB.closeConnection();
                    updateTitles();
                    actionType.SelectedIndex = 1;
                    selectMaterial.SelectedValue = selMatId;
                }
            }
        }

        //обновление полей о записях в форме
        private void updateTitles() {
            string sql = "SELECT [Title], [ID] FROM [dbo].[Material]";
            string sql2 = "SELECT [Title], [ID] FROM [dbo].[MaterialTypes]";
            string sql3 = "SELECT [Title], [ID] FROM [dbo].[UnitTypes]";
            DataTable table = DB.ExecuteSqlCommand(sql);
            DataTable table2 = DB.ExecuteSqlCommand(sql2);
            DataTable table3 = DB.ExecuteSqlCommand(sql3);
            selectMaterial.DataSource = table;
            Type.DataSource = table2;
            Unit.DataSource = table3;
        }

        //дополнительные проверки соответствия ввода 
        private bool InCorrectDataFields() {
            bool err = false;

            List<TextBox> fields = new List<TextBox>() {
                Title,
                Coast,
                Amount,
                MinAmount,
                Package
            };

            List<ComboBox> fields2 = new List<ComboBox>() {
                Type,
                Unit
            };

            for (int i = 0; i < fields.Count; i++)
            {
                if (i < fields2.Count && fields2[i].Text.Length == 0) err = true;
                if (fields[i].Text.Length == 0) err = true;
            }

            return err;
        }

        //Режим обновления полей
        private void updateData(){

            if (InCorrectDataFields())
            {
                MessageBox.Show("Не удалось сохранить изменения, так как некоторые поля не заполнены, примините изменения и повторите попытку.", "Ошибка");
                return;
            }

            int validMatType = Convert.ToInt32(Type.SelectedValue);
            int validUnitType = Convert.ToInt32(Unit.SelectedValue);
            if (validMatType == 0)
            {
                string setNewTypeSql = $"INSERT INTO [dbo].[MaterialTypes] VALUES ('{Type.Text}'); SELECT MAX(ID) AS 'ID' FROM [dbo].[MaterialTypes];";
                DataTable validTypeTable = DB.ExecuteSqlCommand(setNewTypeSql);
                validMatType = (int)validTypeTable.Rows[0]["ID"];
            }

            if (validUnitType == 0)
            {
                string setNewUnitSql = $"INSERT INTO [dbo].[UnitTypes] VALUES ('{Unit.Text}'); SELECT MAX(ID) AS 'ID' FROM [dbo].[UnitTypes];";
                DataTable validUnitTable = DB.ExecuteSqlCommand(setNewUnitSql);
                validUnitType = (int)validUnitTable.Rows[0]["ID"];
            }

            string sql = $"UPDATE [dbo].[Material] SET [Title] = '{Title.Text}', [TypeID] = '{validMatType}', [imagePath] = '{imageName}', [Coast] = {Coast.Text}, [Amount] = {Amount.Text}, [MinAmount] = {MinAmount.Text}, [Package] = {Package.Text}, [UnitID] = '{validUnitType}' WHERE [ID] = {materID}";
            string sql2 = "";
            string sql3 = "";
            int lastValueSelect = Convert.ToInt32(selectMaterial.SelectedValue);

            //синтаксис для одной записи (удалить)
            if (deleteShipperList.Count == 1)
                sql2 = $"DELETE FROM [dbo].[TotalShippers] WHERE [ShipperID] = {deleteShipperList[0]} AND [MaterialID] = {materID}";

            //синтаксис для большего числа записей (удалить)
            if (deleteShipperList.Count > 1)
            {
                sql2 = $"DELETE FROM [dbo].[TotalShippers] WHERE ([ShipperID] = {deleteShipperList[0]}";
                for (int i = 1; i < deleteShipperList.Count; i++) sql2 += $" OR [ShipperID] = {deleteShipperList[i]}";
                sql2 += $") AND [MaterialID] = {materID}";
            }

            sql3 = ShipAddSqlPropare(materID);

            SqlCommand command = new SqlCommand(sql, DB.getConnection());
            SqlCommand delShip = new SqlCommand(sql2, DB.getConnection());
            SqlCommand addShip = new SqlCommand(sql3, DB.getConnection());

            DB.openConnection();
            try
            {
                command.ExecuteNonQuery();
                if (deleteShipperList.Count != 0) delShip.ExecuteNonQuery();
                if (addShipperList.Count != 0) addShip.ExecuteNonQuery();
                MessageBox.Show("Изменения были успешно применены.", "Успех");
            }
            catch (Exception exp)
            {
                MessageBox.Show($"Не удалось приминить изменения вследствии:\n{exp.Message}", "Ошибка");
            }
            finally
            {
                DB.closeConnection();
                deleteShipperList.Clear();
                addShipperList.Clear();
                updateTitles();
                selectMaterial.SelectedValue = lastValueSelect;
            }
        }

        //Добавить в списке на удаление и обновления если устловия А и Б соблюдены (Ограничение первичного ключа таблицы поставщиков и товаров)
        private void addShipper_Click(object sender, EventArgs e)
        {
           int addID = Convert.ToInt32(shipperCh.SelectedValue);
           bool iDexist = shipInfo.AsEnumerable().Any(rowd => addID == rowd.Field<int>("ShipperID"));
            if (iDexist || addShipperList.Contains(addID)) return; //А: поля на добавления не представлены в списке; Б: поля на удаление представлены в списке

           addShipperList.Add(addID);
           DataRow row = shipInfo.NewRow();
           row["ShipperID"] = 0;
           row["Title"] = shipperCh.Text;
           shipInfo.Rows.Add(row);
        }

        //создание синтаксиса команды на добавление с множеством записей (или единичным) в таблицы поставщиков и товаров
        private string ShipAddSqlPropare(int materialID) {
            List<string> sqlCommandFullText = new List<string>();
            string sym = "";
            sqlCommandFullText.Add("INSERT INTO [dbo].[TotalShippers] VALUES");
            for (int k = 0; k < addShipperList.Count; k++)
            {
                if (k > 0) sym = ",";
                sqlCommandFullText.Add($"{sym}({materialID},{addShipperList[k]})");
            }

            return string.Join(" ", sqlCommandFullText);
        }

        //Очистка списка поставщиков для материала по одному
        private void clearShipperBtn_Click(object sender, EventArgs e)
        {
            if (shipperList.SelectedValue == null) return;
            int member = Convert.ToInt32(shipperList.SelectedValue);
            if (member != 0) deleteShipperList.Add(member);
            shipInfo.Rows.RemoveAt(shipperList.SelectedIndex);
        }

        //полная очистка списка поставщиков для материала
        private void clearAllShipperBtn_Click(object sender, EventArgs e)
        {
            foreach (DataRow row in shipInfo.Rows) {
                deleteShipperList.Add((int)row[0]);
            }

            shipInfo.Rows.Clear();
        }

        private void navBack_Click(object sender, EventArgs e)
        {
            Close();
            Main main = new Main();
            main.Show();
        }
    }
}
