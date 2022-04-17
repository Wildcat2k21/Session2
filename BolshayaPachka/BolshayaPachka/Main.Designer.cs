
namespace BolshayaPachka
{
    partial class Main
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.viewMaterial = new System.Windows.Forms.TabControl();
            this.mainTabs = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.filtrSearch = new System.Windows.Forms.TextBox();
            this.filtrColumn = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.materialGrid = new System.Windows.Forms.DataGridView();
            this.viewShipper = new System.Windows.Forms.TabPage();
            this.panel2 = new System.Windows.Forms.Panel();
            this.filtrSearch2 = new System.Windows.Forms.TextBox();
            this.filtrColumn2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.shipperGrid = new System.Windows.Forms.DataGridView();
            this.viewMaterial.SuspendLayout();
            this.mainTabs.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialGrid)).BeginInit();
            this.viewShipper.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.shipperGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // viewMaterial
            // 
            this.viewMaterial.Controls.Add(this.mainTabs);
            this.viewMaterial.Controls.Add(this.viewShipper);
            this.viewMaterial.Dock = System.Windows.Forms.DockStyle.Fill;
            this.viewMaterial.ItemSize = new System.Drawing.Size(150, 25);
            this.viewMaterial.Location = new System.Drawing.Point(0, 0);
            this.viewMaterial.MinimumSize = new System.Drawing.Size(815, 502);
            this.viewMaterial.Name = "viewMaterial";
            this.viewMaterial.SelectedIndex = 0;
            this.viewMaterial.Size = new System.Drawing.Size(815, 502);
            this.viewMaterial.TabIndex = 0;
            // 
            // mainTabs
            // 
            this.mainTabs.Controls.Add(this.panel1);
            this.mainTabs.Controls.Add(this.groupBox1);
            this.mainTabs.Controls.Add(this.materialGrid);
            this.mainTabs.Location = new System.Drawing.Point(4, 29);
            this.mainTabs.Margin = new System.Windows.Forms.Padding(0);
            this.mainTabs.Name = "mainTabs";
            this.mainTabs.Size = new System.Drawing.Size(807, 469);
            this.mainTabs.TabIndex = 0;
            this.mainTabs.Text = "Просмотр материалов";
            this.mainTabs.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.filtrSearch);
            this.panel1.Controls.Add(this.filtrColumn);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(807, 40);
            this.panel1.TabIndex = 6;
            // 
            // filtrSearch
            // 
            this.filtrSearch.Location = new System.Drawing.Point(360, 10);
            this.filtrSearch.Name = "filtrSearch";
            this.filtrSearch.Size = new System.Drawing.Size(204, 21);
            this.filtrSearch.TabIndex = 2;
            this.filtrSearch.TextChanged += new System.EventHandler(this.filtrSearch_TextChanged);
            // 
            // filtrColumn
            // 
            this.filtrColumn.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrColumn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtrColumn.FormattingEnabled = true;
            this.filtrColumn.Items.AddRange(new object[] {
            "Наименование",
            "Тип",
            "Поставщик",
            "Стоимость",
            "Количество",
            "Минимальное количество",
            "В одной упаковке",
            "Единицы"});
            this.filtrColumn.Location = new System.Drawing.Point(133, 10);
            this.filtrColumn.Name = "filtrColumn";
            this.filtrColumn.Size = new System.Drawing.Size(182, 21);
            this.filtrColumn.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Искать по";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(569, 44);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(234, 421);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Управление";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(29, 132);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(164, 23);
            this.button3.TabIndex = 5;
            this.button3.Text = "Добавить новый";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Location = new System.Drawing.Point(29, 84);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 23);
            this.button2.TabIndex = 4;
            this.button2.Text = "Редактирование";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(29, 33);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Удаление материала";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // materialGrid
            // 
            this.materialGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.materialGrid.BackgroundColor = System.Drawing.Color.White;
            this.materialGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.materialGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.materialGrid.Location = new System.Drawing.Point(0, 37);
            this.materialGrid.Name = "materialGrid";
            this.materialGrid.Size = new System.Drawing.Size(564, 432);
            this.materialGrid.TabIndex = 6;
            // 
            // viewShipper
            // 
            this.viewShipper.Controls.Add(this.panel2);
            this.viewShipper.Controls.Add(this.groupBox2);
            this.viewShipper.Controls.Add(this.shipperGrid);
            this.viewShipper.Location = new System.Drawing.Point(4, 29);
            this.viewShipper.Name = "viewShipper";
            this.viewShipper.Padding = new System.Windows.Forms.Padding(3);
            this.viewShipper.Size = new System.Drawing.Size(807, 469);
            this.viewShipper.TabIndex = 1;
            this.viewShipper.Text = "Просмотр поставщиков";
            this.viewShipper.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.panel2.Controls.Add(this.filtrSearch2);
            this.panel2.Controls.Add(this.filtrColumn2);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(807, 40);
            this.panel2.TabIndex = 5;
            // 
            // filtrSearch2
            // 
            this.filtrSearch2.Location = new System.Drawing.Point(360, 10);
            this.filtrSearch2.Name = "filtrSearch2";
            this.filtrSearch2.Size = new System.Drawing.Size(204, 21);
            this.filtrSearch2.TabIndex = 8;
            this.filtrSearch2.TextChanged += new System.EventHandler(this.filtrSearch2_TextChanged);
            // 
            // filtrColumn2
            // 
            this.filtrColumn2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.filtrColumn2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.filtrColumn2.FormattingEnabled = true;
            this.filtrColumn2.Items.AddRange(new object[] {
            "Наименование",
            "Тип организации",
            "ИНН",
            "Качество",
            "Начало работы"});
            this.filtrColumn2.Location = new System.Drawing.Point(133, 10);
            this.filtrColumn2.Name = "filtrColumn2";
            this.filtrColumn2.Size = new System.Drawing.Size(182, 21);
            this.filtrColumn2.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Искать по";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.button5);
            this.groupBox2.Controls.Add(this.button6);
            this.groupBox2.Controls.Add(this.button7);
            this.groupBox2.Location = new System.Drawing.Point(569, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(234, 424);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Управление";
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button5.Location = new System.Drawing.Point(29, 33);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(164, 23);
            this.button5.TabIndex = 9;
            this.button5.Text = "Удаление поставщика";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button6.Location = new System.Drawing.Point(29, 84);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(164, 23);
            this.button6.TabIndex = 10;
            this.button6.Text = "Редактирование";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button7.Location = new System.Drawing.Point(29, 132);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(164, 23);
            this.button7.TabIndex = 11;
            this.button7.Text = "Добавить новый";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // shipperGrid
            // 
            this.shipperGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.shipperGrid.BackgroundColor = System.Drawing.Color.White;
            this.shipperGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.shipperGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.shipperGrid.Location = new System.Drawing.Point(0, 37);
            this.shipperGrid.Name = "shipperGrid";
            this.shipperGrid.Size = new System.Drawing.Size(564, 432);
            this.shipperGrid.TabIndex = 12;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 502);
            this.Controls.Add(this.viewMaterial);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(831, 541);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Большая пачка";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.viewMaterial.ResumeLayout(false);
            this.mainTabs.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.materialGrid)).EndInit();
            this.viewShipper.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.shipperGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl viewMaterial;
        private System.Windows.Forms.TabPage mainTabs;
        private System.Windows.Forms.TabPage viewShipper;
        private System.Windows.Forms.DataGridView materialGrid;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox filtrColumn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox filtrSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox filtrSearch2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox filtrColumn2;
        private System.Windows.Forms.DataGridView shipperGrid;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}

