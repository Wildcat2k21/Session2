
namespace BolshayaPachka
{
    partial class EditMaterialForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditMaterialForm));
            this.actionType = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Title = new System.Windows.Forms.TextBox();
            this.selectMaterial = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.navBack = new System.Windows.Forms.Button();
            this.selectImage = new System.Windows.Forms.Button();
            this.Type = new System.Windows.Forms.ComboBox();
            this.Coast = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Unit = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Package = new System.Windows.Forms.TextBox();
            this.MinAmount = new System.Windows.Forms.TextBox();
            this.Amount = new System.Windows.Forms.TextBox();
            this.process = new System.Windows.Forms.Button();
            this.materialPreview = new System.Windows.Forms.PictureBox();
            this.bolshayaPachkaDataSet = new BolshayaPachka.BolshayaPachkaDataSet();
            this.materialBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.materialTableAdapter = new BolshayaPachka.BolshayaPachkaDataSetTableAdapters.MaterialTableAdapter();
            this.shipperList = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.shipperCh = new System.Windows.Forms.ComboBox();
            this.shipperBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bolshayaPachkaDataSet1 = new BolshayaPachka.BolshayaPachkaDataSet1();
            this.addShipper = new System.Windows.Forms.Button();
            this.clearShipperBtn = new System.Windows.Forms.Button();
            this.clearAllShipperBtn = new System.Windows.Forms.Button();
            this.shipperTableAdapter = new BolshayaPachka.BolshayaPachkaDataSet1TableAdapters.ShipperTableAdapter();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialPreview)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolshayaPachkaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipperBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolshayaPachkaDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // actionType
            // 
            this.actionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.actionType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actionType.FormattingEnabled = true;
            this.actionType.Items.AddRange(new object[] {
            "Удалить",
            "Изменить",
            "Добавить"});
            this.actionType.Location = new System.Drawing.Point(186, 10);
            this.actionType.Name = "actionType";
            this.actionType.Size = new System.Drawing.Size(144, 21);
            this.actionType.TabIndex = 1;
            this.actionType.SelectedValueChanged += new System.EventHandler(this.actionType_SelectedValueChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(120, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Действие";
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.BackColor = System.Drawing.Color.White;
            this.Title.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Title.Location = new System.Drawing.Point(195, 58);
            this.Title.MaxLength = 50;
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(224, 21);
            this.Title.TabIndex = 1;
            // 
            // selectMaterial
            // 
            this.selectMaterial.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.selectMaterial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.selectMaterial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectMaterial.FormattingEnabled = true;
            this.selectMaterial.Location = new System.Drawing.Point(531, 10);
            this.selectMaterial.Name = "selectMaterial";
            this.selectMaterial.Size = new System.Drawing.Size(216, 21);
            this.selectMaterial.TabIndex = 1;
            this.selectMaterial.SelectedValueChanged += new System.EventHandler(this.selectMaterial_SelectedValueChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.selectMaterial);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.navBack);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.actionType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(798, 40);
            this.panel1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(389, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Наименование товара";
            // 
            // navBack
            // 
            this.navBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.navBack.BackgroundImage = global::BolshayaPachka.Properties.Resources.backnavicon;
            this.navBack.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.navBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navBack.Location = new System.Drawing.Point(0, 0);
            this.navBack.Name = "navBack";
            this.navBack.Size = new System.Drawing.Size(40, 40);
            this.navBack.TabIndex = 15;
            this.navBack.UseVisualStyleBackColor = false;
            this.navBack.Click += new System.EventHandler(this.navBack_Click);
            // 
            // selectImage
            // 
            this.selectImage.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.selectImage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.selectImage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.selectImage.Location = new System.Drawing.Point(517, 308);
            this.selectImage.Name = "selectImage";
            this.selectImage.Size = new System.Drawing.Size(246, 30);
            this.selectImage.TabIndex = 8;
            this.selectImage.Text = "выбрать";
            this.selectImage.UseVisualStyleBackColor = false;
            this.selectImage.Click += new System.EventHandler(this.button1_Click);
            // 
            // Type
            // 
            this.Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Type.BackColor = System.Drawing.Color.White;
            this.Type.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(303, 101);
            this.Type.MaxLength = 50;
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(116, 21);
            this.Type.TabIndex = 2;
            // 
            // Coast
            // 
            this.Coast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Coast.BackColor = System.Drawing.Color.White;
            this.Coast.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Coast.Location = new System.Drawing.Point(303, 140);
            this.Coast.MaxLength = 6;
            this.Coast.Name = "Coast";
            this.Coast.Size = new System.Drawing.Size(79, 21);
            this.Coast.TabIndex = 3;
            this.Coast.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.packageAmount_KeyPress);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(388, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "руб.";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.label14);
            this.groupBox1.Controls.Add(this.label13);
            this.groupBox1.Controls.Add(this.label12);
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.Title);
            this.groupBox1.Controls.Add(this.Coast);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.Unit);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Package);
            this.groupBox1.Controls.Add(this.MinAmount);
            this.groupBox1.Controls.Add(this.Amount);
            this.groupBox1.Controls.Add(this.Type);
            this.groupBox1.Location = new System.Drawing.Point(12, 65);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(452, 570);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация о материале";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(27, 291);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(124, 13);
            this.label14.TabIndex = 3;
            this.label14.Text = "Единица измерения";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(28, 255);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(141, 13);
            this.label13.TabIndex = 3;
            this.label13.Text = "Материала в упаковке";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(28, 219);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(222, 13);
            this.label12.TabIndex = 3;
            this.label12.Text = "Минимальное количество материала";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(28, 179);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(140, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Количество материала";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(28, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 13);
            this.label10.TabIndex = 3;
            this.label10.Text = "Цена материала";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(28, 107);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(93, 13);
            this.label9.TabIndex = 3;
            this.label9.Text = "Тип материала";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(28, 66);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(128, 13);
            this.label8.TabIndex = 3;
            this.label8.Text = "Название материала";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(388, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "шт.";
            // 
            // Unit
            // 
            this.Unit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Unit.BackColor = System.Drawing.Color.White;
            this.Unit.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Unit.FormattingEnabled = true;
            this.Unit.Location = new System.Drawing.Point(303, 288);
            this.Unit.MaxLength = 2;
            this.Unit.Name = "Unit";
            this.Unit.Size = new System.Drawing.Size(58, 21);
            this.Unit.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(388, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "шт.";
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 224);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "шт.";
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(387, 296);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "ед.";
            // 
            // Package
            // 
            this.Package.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Package.BackColor = System.Drawing.Color.White;
            this.Package.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Package.Location = new System.Drawing.Point(303, 252);
            this.Package.MaxLength = 6;
            this.Package.Name = "Package";
            this.Package.Size = new System.Drawing.Size(79, 21);
            this.Package.TabIndex = 6;
            this.Package.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.packageAmount_KeyPress);
            // 
            // MinAmount
            // 
            this.MinAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinAmount.BackColor = System.Drawing.Color.White;
            this.MinAmount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MinAmount.Location = new System.Drawing.Point(303, 216);
            this.MinAmount.MaxLength = 6;
            this.MinAmount.Name = "MinAmount";
            this.MinAmount.Size = new System.Drawing.Size(79, 21);
            this.MinAmount.TabIndex = 5;
            this.MinAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.packageAmount_KeyPress);
            // 
            // Amount
            // 
            this.Amount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Amount.BackColor = System.Drawing.Color.White;
            this.Amount.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.Amount.Location = new System.Drawing.Point(303, 179);
            this.Amount.MaxLength = 6;
            this.Amount.Name = "Amount";
            this.Amount.Size = new System.Drawing.Size(79, 21);
            this.Amount.TabIndex = 4;
            this.Amount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.packageAmount_KeyPress);
            // 
            // process
            // 
            this.process.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.process.Location = new System.Drawing.Point(659, 590);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(104, 32);
            this.process.TabIndex = 14;
            this.process.Text = "Выполнить";
            this.process.UseVisualStyleBackColor = false;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // materialPreview
            // 
            this.materialPreview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.materialPreview.Image = global::BolshayaPachka.Properties.Resources.picture;
            this.materialPreview.Location = new System.Drawing.Point(517, 56);
            this.materialPreview.Name = "materialPreview";
            this.materialPreview.Size = new System.Drawing.Size(246, 246);
            this.materialPreview.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.materialPreview.TabIndex = 4;
            this.materialPreview.TabStop = false;
            // 
            // bolshayaPachkaDataSet
            // 
            this.bolshayaPachkaDataSet.DataSetName = "BolshayaPachkaDataSet";
            this.bolshayaPachkaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // materialBindingSource
            // 
            this.materialBindingSource.DataMember = "Material";
            this.materialBindingSource.DataSource = this.bolshayaPachkaDataSet;
            // 
            // materialTableAdapter
            // 
            this.materialTableAdapter.ClearBeforeFill = true;
            // 
            // shipperList
            // 
            this.shipperList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shipperList.BackColor = System.Drawing.Color.White;
            this.shipperList.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.shipperList.FormattingEnabled = true;
            this.shipperList.Location = new System.Drawing.Point(517, 417);
            this.shipperList.Name = "shipperList";
            this.shipperList.Size = new System.Drawing.Size(246, 106);
            this.shipperList.TabIndex = 11;
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(514, 361);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(78, 13);
            this.label15.TabIndex = 3;
            this.label15.Text = "Поставщики";
            // 
            // shipperCh
            // 
            this.shipperCh.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shipperCh.DataSource = this.shipperBindingSource;
            this.shipperCh.DisplayMember = "Title";
            this.shipperCh.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shipperCh.FormattingEnabled = true;
            this.shipperCh.Location = new System.Drawing.Point(517, 390);
            this.shipperCh.Name = "shipperCh";
            this.shipperCh.Size = new System.Drawing.Size(163, 21);
            this.shipperCh.TabIndex = 9;
            this.shipperCh.ValueMember = "ID";
            // 
            // shipperBindingSource
            // 
            this.shipperBindingSource.DataMember = "Shipper";
            this.shipperBindingSource.DataSource = this.bolshayaPachkaDataSet1;
            // 
            // bolshayaPachkaDataSet1
            // 
            this.bolshayaPachkaDataSet1.DataSetName = "BolshayaPachkaDataSet1";
            this.bolshayaPachkaDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // addShipper
            // 
            this.addShipper.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.addShipper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.addShipper.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addShipper.Location = new System.Drawing.Point(688, 390);
            this.addShipper.Name = "addShipper";
            this.addShipper.Size = new System.Drawing.Size(75, 23);
            this.addShipper.TabIndex = 10;
            this.addShipper.Text = "Добавить";
            this.addShipper.UseVisualStyleBackColor = false;
            this.addShipper.Click += new System.EventHandler(this.addShipper_Click);
            // 
            // clearShipperBtn
            // 
            this.clearShipperBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearShipperBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.clearShipperBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearShipperBtn.Location = new System.Drawing.Point(517, 529);
            this.clearShipperBtn.Name = "clearShipperBtn";
            this.clearShipperBtn.Size = new System.Drawing.Size(114, 23);
            this.clearShipperBtn.TabIndex = 12;
            this.clearShipperBtn.Text = "Убрать";
            this.clearShipperBtn.UseVisualStyleBackColor = false;
            this.clearShipperBtn.Click += new System.EventHandler(this.clearShipperBtn_Click);
            // 
            // clearAllShipperBtn
            // 
            this.clearAllShipperBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.clearAllShipperBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.clearAllShipperBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearAllShipperBtn.Location = new System.Drawing.Point(648, 529);
            this.clearAllShipperBtn.Name = "clearAllShipperBtn";
            this.clearAllShipperBtn.Size = new System.Drawing.Size(115, 23);
            this.clearAllShipperBtn.TabIndex = 13;
            this.clearAllShipperBtn.Text = "Очистить все";
            this.clearAllShipperBtn.UseVisualStyleBackColor = false;
            this.clearAllShipperBtn.Click += new System.EventHandler(this.clearAllShipperBtn_Click);
            // 
            // shipperTableAdapter
            // 
            this.shipperTableAdapter.ClearBeforeFill = true;
            // 
            // EditMaterialForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(798, 647);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.clearAllShipperBtn);
            this.Controls.Add(this.clearShipperBtn);
            this.Controls.Add(this.addShipper);
            this.Controls.Add(this.shipperList);
            this.Controls.Add(this.process);
            this.Controls.Add(this.shipperCh);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.selectImage);
            this.Controls.Add(this.materialPreview);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(814, 686);
            this.Name = "EditMaterialForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление материалом";
            this.Load += new System.EventHandler(this.DeleteMaterial_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.materialPreview)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolshayaPachkaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.materialBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shipperBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bolshayaPachkaDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox actionType;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.ComboBox selectMaterial;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox materialPreview;
        private System.Windows.Forms.Button selectImage;
        private System.Windows.Forms.ComboBox Type;
        private System.Windows.Forms.TextBox Coast;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox MinAmount;
        private System.Windows.Forms.TextBox Amount;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox Unit;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Package;
        private System.Windows.Forms.Button process;
        private BolshayaPachkaDataSet bolshayaPachkaDataSet;
        private System.Windows.Forms.BindingSource materialBindingSource;
        private BolshayaPachkaDataSetTableAdapters.MaterialTableAdapter materialTableAdapter;
        private System.Windows.Forms.ListBox shipperList;
        private System.Windows.Forms.Button clearShipperBtn;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button addShipper;
        private System.Windows.Forms.ComboBox shipperCh;
        private System.Windows.Forms.Button clearAllShipperBtn;
        private BolshayaPachkaDataSet1 bolshayaPachkaDataSet1;
        private System.Windows.Forms.BindingSource shipperBindingSource;
        private BolshayaPachkaDataSet1TableAdapters.ShipperTableAdapter shipperTableAdapter;
        private System.Windows.Forms.Button navBack;
    }
}