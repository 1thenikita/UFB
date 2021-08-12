
namespace UFB.Forms
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBoxCategoriesData = new System.Windows.Forms.GroupBox();
            this.richTextBoxCategoriesDescription = new System.Windows.Forms.RichTextBox();
            this.labelCategoriesDescription = new System.Windows.Forms.Label();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.labelCategoriesName = new System.Windows.Forms.Label();
            this.comboBoxCategories = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPageFermers = new System.Windows.Forms.TabPage();
            this.groupBoxFermersData = new System.Windows.Forms.GroupBox();
            this.dataGridViewFermersProducts = new System.Windows.Forms.DataGridView();
            this.comboBoxFermersName = new System.Windows.Forms.ComboBox();
            this.labelFermersName = new System.Windows.Forms.Label();
            this.linkLabelLogin = new System.Windows.Forms.LinkLabel();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBoxCategoriesData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.tabPageFermers.SuspendLayout();
            this.groupBoxFermersData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFermersProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPageFermers);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1344, 611);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBoxCategoriesData);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1336, 578);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Категории";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBoxCategoriesData
            // 
            this.groupBoxCategoriesData.Controls.Add(this.richTextBoxCategoriesDescription);
            this.groupBoxCategoriesData.Controls.Add(this.labelCategoriesDescription);
            this.groupBoxCategoriesData.Controls.Add(this.dataGridViewCategories);
            this.groupBoxCategoriesData.Controls.Add(this.labelCategoriesName);
            this.groupBoxCategoriesData.Controls.Add(this.comboBoxCategories);
            this.groupBoxCategoriesData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxCategoriesData.Location = new System.Drawing.Point(3, 3);
            this.groupBoxCategoriesData.Name = "groupBoxCategoriesData";
            this.groupBoxCategoriesData.Size = new System.Drawing.Size(1330, 572);
            this.groupBoxCategoriesData.TabIndex = 2;
            this.groupBoxCategoriesData.TabStop = false;
            this.groupBoxCategoriesData.Text = "Данные";
            // 
            // richTextBoxCategoriesDescription
            // 
            this.richTextBoxCategoriesDescription.Enabled = false;
            this.richTextBoxCategoriesDescription.Location = new System.Drawing.Point(10, 104);
            this.richTextBoxCategoriesDescription.Name = "richTextBoxCategoriesDescription";
            this.richTextBoxCategoriesDescription.Size = new System.Drawing.Size(195, 257);
            this.richTextBoxCategoriesDescription.TabIndex = 4;
            this.richTextBoxCategoriesDescription.Text = "";
            // 
            // labelCategoriesDescription
            // 
            this.labelCategoriesDescription.AutoSize = true;
            this.labelCategoriesDescription.Location = new System.Drawing.Point(3, 81);
            this.labelCategoriesDescription.Name = "labelCategoriesDescription";
            this.labelCategoriesDescription.Size = new System.Drawing.Size(83, 20);
            this.labelCategoriesDescription.TabIndex = 3;
            this.labelCategoriesDescription.Text = "Описание";
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.AllowUserToAddRows = false;
            this.dataGridViewCategories.AllowUserToDeleteRows = false;
            this.dataGridViewCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column7,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column15,
            this.Column6});
            this.dataGridViewCategories.Location = new System.Drawing.Point(290, 15);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.ReadOnly = true;
            this.dataGridViewCategories.RowHeadersWidth = 62;
            this.dataGridViewCategories.RowTemplate.Height = 28;
            this.dataGridViewCategories.Size = new System.Drawing.Size(1034, 551);
            this.dataGridViewCategories.TabIndex = 2;
            // 
            // labelCategoriesName
            // 
            this.labelCategoriesName.AutoSize = true;
            this.labelCategoriesName.Location = new System.Drawing.Point(6, 22);
            this.labelCategoriesName.Name = "labelCategoriesName";
            this.labelCategoriesName.Size = new System.Drawing.Size(83, 20);
            this.labelCategoriesName.TabIndex = 0;
            this.labelCategoriesName.Text = "Название";
            // 
            // comboBoxCategories
            // 
            this.comboBoxCategories.FormattingEnabled = true;
            this.comboBoxCategories.Location = new System.Drawing.Point(10, 46);
            this.comboBoxCategories.Name = "comboBoxCategories";
            this.comboBoxCategories.Size = new System.Drawing.Size(195, 28);
            this.comboBoxCategories.TabIndex = 1;
            this.comboBoxCategories.SelectedIndexChanged += new System.EventHandler(this.comboBoxCategories_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1336, 578);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Продукты";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPageFermers
            // 
            this.tabPageFermers.Controls.Add(this.groupBoxFermersData);
            this.tabPageFermers.Location = new System.Drawing.Point(4, 29);
            this.tabPageFermers.Name = "tabPageFermers";
            this.tabPageFermers.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageFermers.Size = new System.Drawing.Size(1336, 578);
            this.tabPageFermers.TabIndex = 2;
            this.tabPageFermers.Text = "Фермеры";
            this.tabPageFermers.UseVisualStyleBackColor = true;
            // 
            // groupBoxFermersData
            // 
            this.groupBoxFermersData.Controls.Add(this.dataGridViewFermersProducts);
            this.groupBoxFermersData.Controls.Add(this.comboBoxFermersName);
            this.groupBoxFermersData.Controls.Add(this.labelFermersName);
            this.groupBoxFermersData.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBoxFermersData.Location = new System.Drawing.Point(3, 3);
            this.groupBoxFermersData.Name = "groupBoxFermersData";
            this.groupBoxFermersData.Size = new System.Drawing.Size(1330, 572);
            this.groupBoxFermersData.TabIndex = 0;
            this.groupBoxFermersData.TabStop = false;
            this.groupBoxFermersData.Text = "Данные";
            // 
            // dataGridViewFermersProducts
            // 
            this.dataGridViewFermersProducts.AllowUserToAddRows = false;
            this.dataGridViewFermersProducts.AllowUserToDeleteRows = false;
            this.dataGridViewFermersProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewFermersProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewFermersProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column17,
            this.Column12,
            this.Column13,
            this.Column16,
            this.Column14});
            this.dataGridViewFermersProducts.Location = new System.Drawing.Point(269, 13);
            this.dataGridViewFermersProducts.Name = "dataGridViewFermersProducts";
            this.dataGridViewFermersProducts.ReadOnly = true;
            this.dataGridViewFermersProducts.RowHeadersWidth = 62;
            this.dataGridViewFermersProducts.RowTemplate.Height = 28;
            this.dataGridViewFermersProducts.Size = new System.Drawing.Size(1056, 542);
            this.dataGridViewFermersProducts.TabIndex = 2;
            // 
            // comboBoxFermersName
            // 
            this.comboBoxFermersName.FormattingEnabled = true;
            this.comboBoxFermersName.Location = new System.Drawing.Point(7, 50);
            this.comboBoxFermersName.Name = "comboBoxFermersName";
            this.comboBoxFermersName.Size = new System.Drawing.Size(215, 28);
            this.comboBoxFermersName.TabIndex = 1;
            this.comboBoxFermersName.SelectedIndexChanged += new System.EventHandler(this.comboBoxFermersName_SelectedIndexChanged);
            // 
            // labelFermersName
            // 
            this.labelFermersName.AutoSize = true;
            this.labelFermersName.Location = new System.Drawing.Point(7, 26);
            this.labelFermersName.Name = "labelFermersName";
            this.labelFermersName.Size = new System.Drawing.Size(71, 20);
            this.labelFermersName.TabIndex = 0;
            this.labelFermersName.Text = "Фермер";
            // 
            // linkLabelLogin
            // 
            this.linkLabelLogin.AutoSize = true;
            this.linkLabelLogin.Location = new System.Drawing.Point(10, 625);
            this.linkLabelLogin.Name = "linkLabelLogin";
            this.linkLabelLogin.Size = new System.Drawing.Size(134, 20);
            this.linkLabelLogin.TabIndex = 1;
            this.linkLabelLogin.TabStop = true;
            this.linkLabelLogin.Text = "Войти в систему";
            this.linkLabelLogin.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabelLogin_LinkClicked);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "ID";
            this.Column1.MinimumWidth = 8;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Название продукта";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Описание";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Стоимость";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Фермер";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Номер фермера";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Оптимальная цена";
            this.Column15.MinimumWidth = 8;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Изображение";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "ID";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            this.Column8.Visible = false;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Название продукта";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "Описание";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Стоимость";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column17
            // 
            this.Column17.HeaderText = "Категория";
            this.Column17.MinimumWidth = 8;
            this.Column17.Name = "Column17";
            this.Column17.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Фермер";
            this.Column12.MinimumWidth = 8;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "Номер фермера";
            this.Column13.MinimumWidth = 8;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Оптимальная цена";
            this.Column16.MinimumWidth = 8;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Изображение";
            this.Column14.MinimumWidth = 8;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1344, 654);
            this.Controls.Add(this.linkLabelLogin);
            this.Controls.Add(this.tabControlMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Главная форма | Единая Фермерская База";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBoxCategoriesData.ResumeLayout(false);
            this.groupBoxCategoriesData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.tabPageFermers.ResumeLayout(false);
            this.groupBoxFermersData.ResumeLayout(false);
            this.groupBoxFermersData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewFermersProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPageFermers;
        private System.Windows.Forms.LinkLabel linkLabelLogin;
        private System.Windows.Forms.GroupBox groupBoxCategoriesData;
        private System.Windows.Forms.RichTextBox richTextBoxCategoriesDescription;
        private System.Windows.Forms.Label labelCategoriesDescription;
        private System.Windows.Forms.Label labelCategoriesName;
        private System.Windows.Forms.ComboBox comboBoxCategories;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.GroupBox groupBoxFermersData;
        private System.Windows.Forms.DataGridView dataGridViewFermersProducts;
        private System.Windows.Forms.ComboBox comboBoxFermersName;
        private System.Windows.Forms.Label labelFermersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewImageColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column17;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column16;
        private System.Windows.Forms.DataGridViewImageColumn Column14;
    }
}