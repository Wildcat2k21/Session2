using System;
using System.Windows.Forms;

namespace BolshayaPachka
{
    public partial class Main : Form
    {
        //подключение бд и выбранные дейстивя для передачи в формы управления
        MSSconnection DB = new MSSconnection();
        public static int selectedMaterialAction;
        public static int selectedShipperAction;

        public Main()
        {
            InitializeComponent();
        }
        
        //Фильтр по поиску
        private void filtrSearch_TextChanged(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM [dbo].[MainInfo] WHERE [{filtrColumn.Text}] LIKE '%{filtrSearch.Text}%'";
            materialGrid.DataSource = DB.ExecuteSqlCommand(sql);
        }

        //инициализация данных в таблицы
        private void Form1_Load(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM [dbo].[MainInfo]";
            materialGrid.DataSource = DB.ExecuteSqlCommand(sql);
            filtrColumn.SelectedIndex = 0;

            string sql2 = "SELECT * from [dbo].[ShipperInfo]";
            shipperGrid.DataSource = DB.ExecuteSqlCommand(sql2);
            filtrColumn2.SelectedIndex = 0;
        }

        //выбор колонки по которой будет применяться поиск
        private void filtrSearch2_TextChanged(object sender, EventArgs e)
        {
            string sql = $"SELECT * FROM [dbo].[ShipperInfo] WHERE [{filtrColumn2.Text}] LIKE '%{filtrSearch2.Text}%'";
            shipperGrid.DataSource = DB.ExecuteSqlCommand(sql);
        }

        //выбрать действие удалить и показать форму управления материалом
        private void button1_Click(object sender, EventArgs e)
        {
            selectedMaterialAction = 0;
            MaterialEdit();
        }

        //выбрать действие изменть и показать форму управления материалом
        private void button2_Click(object sender, EventArgs e)
        {
            selectedMaterialAction = 1;
            MaterialEdit();
        }

        //выбрать действие добавить и показать форму управления материалом
        private void button3_Click(object sender, EventArgs e)
        {
            selectedMaterialAction = 2;
            MaterialEdit();
        }

        private void MaterialEdit() {
            EditMaterialForm edit = new EditMaterialForm();
            this.Hide();
            edit.Show();
        }

        //выбрать действие удалить и показать форму управления поставщиков
        private void button5_Click(object sender, EventArgs e)
        {
            selectedShipperAction = 0;
            OpenEditShipForm();
        }

        //выбрать действие добавить и показать форму управления поставщиков
        private void button6_Click(object sender, EventArgs e)
        {
            selectedShipperAction = 1;
            OpenEditShipForm();
        }

        //выбрать действие изменить и показать форму управления поставщиков
        private void button7_Click(object sender, EventArgs e)
        {
            selectedShipperAction = 2;
            OpenEditShipForm();
        }

        private void OpenEditShipForm() {
            EditShipperForm form = new EditShipperForm();
            form.Show();
            Hide();
        }
    }
}
