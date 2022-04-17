
namespace BolshayaPachka
{
    partial class EditShipperForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditShipperForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.navBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.labelInfo = new System.Windows.Forms.Label();
            this.shipperList = new System.Windows.Forms.ComboBox();
            this.actionType = new System.Windows.Forms.ComboBox();
            this.entityCommand1 = new System.Data.Entity.Core.EntityClient.EntityCommand();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.StartTime = new System.Windows.Forms.DateTimePicker();
            this.Quality = new System.Windows.Forms.TextBox();
            this.INN = new System.Windows.Forms.TextBox();
            this.Title = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.Type = new System.Windows.Forms.ComboBox();
            this.process = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(43)))), ((int)(((byte)(57)))));
            this.panel1.Controls.Add(this.navBack);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.labelInfo);
            this.panel1.Controls.Add(this.shipperList);
            this.panel1.Controls.Add(this.actionType);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(692, 40);
            this.panel1.TabIndex = 0;
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
            this.navBack.TabIndex = 2;
            this.navBack.UseVisualStyleBackColor = false;
            this.navBack.Click += new System.EventHandler(this.navBack_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(355, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "поставщики";
            // 
            // labelInfo
            // 
            this.labelInfo.AutoSize = true;
            this.labelInfo.Location = new System.Drawing.Point(103, 18);
            this.labelInfo.Name = "labelInfo";
            this.labelInfo.Size = new System.Drawing.Size(61, 13);
            this.labelInfo.TabIndex = 1;
            this.labelInfo.Text = "действие";
            // 
            // shipperList
            // 
            this.shipperList.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.shipperList.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.shipperList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.shipperList.FormattingEnabled = true;
            this.shipperList.Location = new System.Drawing.Point(438, 10);
            this.shipperList.Name = "shipperList";
            this.shipperList.Size = new System.Drawing.Size(184, 21);
            this.shipperList.TabIndex = 0;
            this.shipperList.SelectedValueChanged += new System.EventHandler(this.shipperList_SelectedValueChanged);
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
            this.actionType.Location = new System.Drawing.Point(170, 10);
            this.actionType.Name = "actionType";
            this.actionType.Size = new System.Drawing.Size(147, 21);
            this.actionType.TabIndex = 0;
            this.actionType.SelectedIndexChanged += new System.EventHandler(this.actionType_SelectedIndexChanged);
            // 
            // entityCommand1
            // 
            this.entityCommand1.CommandTimeout = 0;
            this.entityCommand1.CommandTree = null;
            this.entityCommand1.Connection = null;
            this.entityCommand1.EnablePlanCaching = true;
            this.entityCommand1.Transaction = null;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.StartTime);
            this.groupBox1.Controls.Add(this.Quality);
            this.groupBox1.Controls.Add(this.INN);
            this.groupBox1.Controls.Add(this.Title);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.Type);
            this.groupBox1.Location = new System.Drawing.Point(27, 88);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(514, 283);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Информация";
            // 
            // StartTime
            // 
            this.StartTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.StartTime.Location = new System.Drawing.Point(265, 214);
            this.StartTime.Name = "StartTime";
            this.StartTime.Size = new System.Drawing.Size(200, 21);
            this.StartTime.TabIndex = 2;
            // 
            // Quality
            // 
            this.Quality.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Quality.Location = new System.Drawing.Point(308, 150);
            this.Quality.MaxLength = 3;
            this.Quality.Name = "Quality";
            this.Quality.Size = new System.Drawing.Size(157, 21);
            this.Quality.TabIndex = 1;
            this.Quality.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.INN_KeyPress);
            this.Quality.Leave += new System.EventHandler(this.Quality_Leave);
            // 
            // INN
            // 
            this.INN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.INN.Location = new System.Drawing.Point(308, 117);
            this.INN.MaxLength = 10;
            this.INN.Name = "INN";
            this.INN.Size = new System.Drawing.Size(157, 21);
            this.INN.TabIndex = 1;
            this.INN.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.INN_KeyPress);
            // 
            // Title
            // 
            this.Title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Title.Location = new System.Drawing.Point(308, 52);
            this.Title.MaxLength = 45;
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(157, 21);
            this.Title.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(56, 220);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(126, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Дата начало работы";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(56, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Качество";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(56, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "ИНН";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(56, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Тип организации";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(56, 60);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Наименование поставщика";
            // 
            // Type
            // 
            this.Type.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Type.FormattingEnabled = true;
            this.Type.Location = new System.Drawing.Point(308, 84);
            this.Type.MaxLength = 3;
            this.Type.Name = "Type";
            this.Type.Size = new System.Drawing.Size(157, 21);
            this.Type.TabIndex = 0;
            // 
            // process
            // 
            this.process.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.process.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(193)))), ((int)(((byte)(193)))));
            this.process.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.process.Location = new System.Drawing.Point(562, 333);
            this.process.Name = "process";
            this.process.Size = new System.Drawing.Size(103, 38);
            this.process.TabIndex = 2;
            this.process.Text = "Приминить";
            this.process.UseVisualStyleBackColor = false;
            this.process.Click += new System.EventHandler(this.process_Click);
            // 
            // EditShipperForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(692, 403);
            this.Controls.Add(this.process);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(708, 442);
            this.Name = "EditShipperForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Управление поставщиками";
            this.Load += new System.EventHandler(this.EditShipperForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ComboBox actionType;
        private System.Data.Entity.Core.EntityClient.EntityCommand entityCommand1;
        private System.Windows.Forms.Button navBack;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox shipperList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button process;
        private System.Windows.Forms.TextBox Title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker StartTime;
        private System.Windows.Forms.TextBox Quality;
        private System.Windows.Forms.TextBox INN;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Type;
    }
}