
namespace UFB.Forms
{
    partial class FormAdmin
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.buttonMyUserUpdatePassword = new System.Windows.Forms.Button();
            this.checkBoxMyUserVisiblePassword = new System.Windows.Forms.CheckBox();
            this.textBoxMyUserPassword = new System.Windows.Forms.TextBox();
            this.labelMyUserPassword = new System.Windows.Forms.Label();
            this.labelMyUserName = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAddUser = new System.Windows.Forms.Button();
            this.dataGridViewUsers = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageCategories = new System.Windows.Forms.TabPage();
            this.buttonEditCategory = new System.Windows.Forms.Button();
            this.buttonAddCategory = new System.Windows.Forms.Button();
            this.dataGridViewCategories = new System.Windows.Forms.DataGridView();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column16 = new System.Windows.Forms.DataGridViewImageColumn();
            this.buttonDeleteCategory = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.buttonDeleteProduct = new System.Windows.Forms.Button();
            this.buttonEditProduct = new System.Windows.Forms.Button();
            this.buttonAddProduct = new System.Windows.Forms.Button();
            this.dataGridViewProducts = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.tabControlMain.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).BeginInit();
            this.tabPageCategories.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPage1);
            this.tabControlMain.Controls.Add(this.tabPage2);
            this.tabControlMain.Controls.Add(this.tabPageCategories);
            this.tabControlMain.Controls.Add(this.tabPage3);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1281, 617);
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.buttonMyUserUpdatePassword);
            this.tabPage1.Controls.Add(this.checkBoxMyUserVisiblePassword);
            this.tabPage1.Controls.Add(this.textBoxMyUserPassword);
            this.tabPage1.Controls.Add(this.labelMyUserPassword);
            this.tabPage1.Controls.Add(this.labelMyUserName);
            this.tabPage1.Controls.Add(this.labelTime);
            this.tabPage1.Location = new System.Drawing.Point(4, 29);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1273, 584);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "О себе";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // buttonMyUserUpdatePassword
            // 
            this.buttonMyUserUpdatePassword.Location = new System.Drawing.Point(12, 108);
            this.buttonMyUserUpdatePassword.Name = "buttonMyUserUpdatePassword";
            this.buttonMyUserUpdatePassword.Size = new System.Drawing.Size(177, 31);
            this.buttonMyUserUpdatePassword.TabIndex = 5;
            this.buttonMyUserUpdatePassword.Text = "Изменить пароль";
            this.buttonMyUserUpdatePassword.UseVisualStyleBackColor = true;
            this.buttonMyUserUpdatePassword.Click += new System.EventHandler(this.buttonMyUserUpdatePassword_Click);
            // 
            // checkBoxMyUserVisiblePassword
            // 
            this.checkBoxMyUserVisiblePassword.AutoSize = true;
            this.checkBoxMyUserVisiblePassword.Location = new System.Drawing.Point(81, 51);
            this.checkBoxMyUserVisiblePassword.Name = "checkBoxMyUserVisiblePassword";
            this.checkBoxMyUserVisiblePassword.Size = new System.Drawing.Size(108, 24);
            this.checkBoxMyUserVisiblePassword.TabIndex = 4;
            this.checkBoxMyUserVisiblePassword.Text = "Показать";
            this.checkBoxMyUserVisiblePassword.UseVisualStyleBackColor = true;
            // 
            // textBoxMyUserPassword
            // 
            this.textBoxMyUserPassword.Location = new System.Drawing.Point(12, 75);
            this.textBoxMyUserPassword.Name = "textBoxMyUserPassword";
            this.textBoxMyUserPassword.Size = new System.Drawing.Size(177, 26);
            this.textBoxMyUserPassword.TabIndex = 3;
            // 
            // labelMyUserPassword
            // 
            this.labelMyUserPassword.AutoSize = true;
            this.labelMyUserPassword.Location = new System.Drawing.Point(8, 52);
            this.labelMyUserPassword.Name = "labelMyUserPassword";
            this.labelMyUserPassword.Size = new System.Drawing.Size(67, 20);
            this.labelMyUserPassword.TabIndex = 2;
            this.labelMyUserPassword.Text = "Пароль";
            // 
            // labelMyUserName
            // 
            this.labelMyUserName.AutoSize = true;
            this.labelMyUserName.Location = new System.Drawing.Point(9, 27);
            this.labelMyUserName.Name = "labelMyUserName";
            this.labelMyUserName.Size = new System.Drawing.Size(118, 20);
            this.labelMyUserName.TabIndex = 1;
            this.labelMyUserName.Text = "Имя Отчество";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(8, 3);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(110, 20);
            this.labelTime.TabIndex = 0;
            this.labelTime.Text = "Добрый день";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.buttonDelete);
            this.tabPage2.Controls.Add(this.buttonEdit);
            this.tabPage2.Controls.Add(this.buttonAddUser);
            this.tabPage2.Controls.Add(this.dataGridViewUsers);
            this.tabPage2.Location = new System.Drawing.Point(4, 29);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1273, 584);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Пользователи";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(227, 314);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(101, 38);
            this.buttonDelete.TabIndex = 3;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Orange;
            this.buttonEdit.Location = new System.Drawing.Point(120, 314);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(101, 38);
            this.buttonEdit.TabIndex = 2;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAddUser
            // 
            this.buttonAddUser.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonAddUser.Location = new System.Drawing.Point(8, 314);
            this.buttonAddUser.Name = "buttonAddUser";
            this.buttonAddUser.Size = new System.Drawing.Size(105, 38);
            this.buttonAddUser.TabIndex = 1;
            this.buttonAddUser.Text = "Добавить";
            this.buttonAddUser.UseVisualStyleBackColor = false;
            this.buttonAddUser.Click += new System.EventHandler(this.buttonAddUser_Click);
            // 
            // dataGridViewUsers
            // 
            this.dataGridViewUsers.AllowUserToAddRows = false;
            this.dataGridViewUsers.AllowUserToDeleteRows = false;
            this.dataGridViewUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUsers.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12});
            this.dataGridViewUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewUsers.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewUsers.Name = "dataGridViewUsers";
            this.dataGridViewUsers.ReadOnly = true;
            this.dataGridViewUsers.RowHeadersWidth = 62;
            this.dataGridViewUsers.RowTemplate.Height = 28;
            this.dataGridViewUsers.Size = new System.Drawing.Size(1267, 297);
            this.dataGridViewUsers.TabIndex = 0;
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
            this.Column2.HeaderText = "Логин";
            this.Column2.MinimumWidth = 8;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Роль";
            this.Column3.MinimumWidth = 8;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "Фамилия";
            this.Column4.MinimumWidth = 8;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Имя";
            this.Column5.MinimumWidth = 8;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Отчество";
            this.Column6.MinimumWidth = 8;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Дата рождения";
            this.Column7.MinimumWidth = 8;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Должность";
            this.Column8.MinimumWidth = 8;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.HeaderText = "Номер телефона";
            this.Column9.MinimumWidth = 8;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.HeaderText = "E-Mail";
            this.Column10.MinimumWidth = 8;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.HeaderText = "Дата последнего входа";
            this.Column11.MinimumWidth = 8;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.HeaderText = "Статус";
            this.Column12.MinimumWidth = 8;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // tabPageCategories
            // 
            this.tabPageCategories.Controls.Add(this.buttonDeleteCategory);
            this.tabPageCategories.Controls.Add(this.buttonEditCategory);
            this.tabPageCategories.Controls.Add(this.buttonAddCategory);
            this.tabPageCategories.Controls.Add(this.dataGridViewCategories);
            this.tabPageCategories.Location = new System.Drawing.Point(4, 29);
            this.tabPageCategories.Name = "tabPageCategories";
            this.tabPageCategories.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageCategories.Size = new System.Drawing.Size(1273, 584);
            this.tabPageCategories.TabIndex = 2;
            this.tabPageCategories.Text = "Категории";
            this.tabPageCategories.UseVisualStyleBackColor = true;
            // 
            // buttonEditCategory
            // 
            this.buttonEditCategory.BackColor = System.Drawing.Color.Orange;
            this.buttonEditCategory.Location = new System.Drawing.Point(111, 309);
            this.buttonEditCategory.Name = "buttonEditCategory";
            this.buttonEditCategory.Size = new System.Drawing.Size(96, 36);
            this.buttonEditCategory.TabIndex = 2;
            this.buttonEditCategory.Text = "Изменить";
            this.buttonEditCategory.UseVisualStyleBackColor = false;
            this.buttonEditCategory.Click += new System.EventHandler(this.buttonEditCategory_Click);
            // 
            // buttonAddCategory
            // 
            this.buttonAddCategory.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonAddCategory.Location = new System.Drawing.Point(4, 310);
            this.buttonAddCategory.Name = "buttonAddCategory";
            this.buttonAddCategory.Size = new System.Drawing.Size(101, 36);
            this.buttonAddCategory.TabIndex = 1;
            this.buttonAddCategory.Text = "Добавить";
            this.buttonAddCategory.UseVisualStyleBackColor = false;
            this.buttonAddCategory.Click += new System.EventHandler(this.buttonAddCategory_Click);
            // 
            // dataGridViewCategories
            // 
            this.dataGridViewCategories.AllowUserToAddRows = false;
            this.dataGridViewCategories.AllowUserToDeleteRows = false;
            this.dataGridViewCategories.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCategories.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCategories.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column13,
            this.Column14,
            this.Column15,
            this.Column16});
            this.dataGridViewCategories.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewCategories.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewCategories.Name = "dataGridViewCategories";
            this.dataGridViewCategories.ReadOnly = true;
            this.dataGridViewCategories.RowHeadersWidth = 62;
            this.dataGridViewCategories.RowTemplate.Height = 28;
            this.dataGridViewCategories.Size = new System.Drawing.Size(1267, 300);
            this.dataGridViewCategories.TabIndex = 0;
            // 
            // Column13
            // 
            this.Column13.HeaderText = "ID";
            this.Column13.MinimumWidth = 8;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            this.Column13.Visible = false;
            // 
            // Column14
            // 
            this.Column14.HeaderText = "Название";
            this.Column14.MinimumWidth = 8;
            this.Column14.Name = "Column14";
            this.Column14.ReadOnly = true;
            // 
            // Column15
            // 
            this.Column15.HeaderText = "Описание";
            this.Column15.MinimumWidth = 8;
            this.Column15.Name = "Column15";
            this.Column15.ReadOnly = true;
            // 
            // Column16
            // 
            this.Column16.HeaderText = "Фото";
            this.Column16.MinimumWidth = 8;
            this.Column16.Name = "Column16";
            this.Column16.ReadOnly = true;
            // 
            // buttonDeleteCategory
            // 
            this.buttonDeleteCategory.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteCategory.Location = new System.Drawing.Point(214, 310);
            this.buttonDeleteCategory.Name = "buttonDeleteCategory";
            this.buttonDeleteCategory.Size = new System.Drawing.Size(102, 35);
            this.buttonDeleteCategory.TabIndex = 3;
            this.buttonDeleteCategory.Text = "Удалить";
            this.buttonDeleteCategory.UseVisualStyleBackColor = false;
            this.buttonDeleteCategory.Click += new System.EventHandler(this.buttonDeleteCategory_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.buttonDeleteProduct);
            this.tabPage3.Controls.Add(this.buttonEditProduct);
            this.tabPage3.Controls.Add(this.buttonAddProduct);
            this.tabPage3.Controls.Add(this.dataGridViewProducts);
            this.tabPage3.Location = new System.Drawing.Point(4, 29);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1273, 584);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Продукты";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteProduct
            // 
            this.buttonDeleteProduct.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteProduct.Location = new System.Drawing.Point(232, 200);
            this.buttonDeleteProduct.Name = "buttonDeleteProduct";
            this.buttonDeleteProduct.Size = new System.Drawing.Size(105, 35);
            this.buttonDeleteProduct.TabIndex = 8;
            this.buttonDeleteProduct.Text = "Удалить";
            this.buttonDeleteProduct.UseVisualStyleBackColor = false;
            this.buttonDeleteProduct.Click += new System.EventHandler(this.buttonDeleteProduct_Click);
            // 
            // buttonEditProduct
            // 
            this.buttonEditProduct.BackColor = System.Drawing.Color.Orange;
            this.buttonEditProduct.Location = new System.Drawing.Point(121, 200);
            this.buttonEditProduct.Name = "buttonEditProduct";
            this.buttonEditProduct.Size = new System.Drawing.Size(105, 35);
            this.buttonEditProduct.TabIndex = 7;
            this.buttonEditProduct.Text = "Изменить";
            this.buttonEditProduct.UseVisualStyleBackColor = false;
            this.buttonEditProduct.Click += new System.EventHandler(this.buttonEditProduct_Click);
            // 
            // buttonAddProduct
            // 
            this.buttonAddProduct.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonAddProduct.Location = new System.Drawing.Point(8, 200);
            this.buttonAddProduct.Name = "buttonAddProduct";
            this.buttonAddProduct.Size = new System.Drawing.Size(97, 35);
            this.buttonAddProduct.TabIndex = 6;
            this.buttonAddProduct.Text = "Добавить";
            this.buttonAddProduct.UseVisualStyleBackColor = false;
            this.buttonAddProduct.Click += new System.EventHandler(this.buttonAddProduct_Click);
            // 
            // dataGridViewProducts
            // 
            this.dataGridViewProducts.AllowUserToAddRows = false;
            this.dataGridViewProducts.AllowUserToDeleteRows = false;
            this.dataGridViewProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProducts.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewImageColumn1});
            this.dataGridViewProducts.Dock = System.Windows.Forms.DockStyle.Top;
            this.dataGridViewProducts.Location = new System.Drawing.Point(3, 3);
            this.dataGridViewProducts.Name = "dataGridViewProducts";
            this.dataGridViewProducts.ReadOnly = true;
            this.dataGridViewProducts.RowHeadersWidth = 62;
            this.dataGridViewProducts.RowTemplate.Height = 28;
            this.dataGridViewProducts.Size = new System.Drawing.Size(1267, 191);
            this.dataGridViewProducts.TabIndex = 5;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Visible = false;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Название";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Описание";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Стоимость";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Категория";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Фермер";
            this.dataGridViewTextBoxColumn6.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Номер фермера";
            this.dataGridViewTextBoxColumn7.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Оптимальная цена";
            this.dataGridViewTextBoxColumn8.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Изображение";
            this.dataGridViewImageColumn1.MinimumWidth = 8;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.ReadOnly = true;
            // 
            // FormAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1281, 617);
            this.Controls.Add(this.tabControlMain);
            this.Name = "FormAdmin";
            this.Text = "Форма Администратора";
            this.Load += new System.EventHandler(this.FormAdmin_Load);
            this.tabControlMain.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUsers)).EndInit();
            this.tabPageCategories.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCategories)).EndInit();
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProducts)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridViewUsers;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.Button buttonAddUser;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonMyUserUpdatePassword;
        private System.Windows.Forms.CheckBox checkBoxMyUserVisiblePassword;
        private System.Windows.Forms.TextBox textBoxMyUserPassword;
        private System.Windows.Forms.Label labelMyUserPassword;
        private System.Windows.Forms.Label labelMyUserName;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.TabPage tabPageCategories;
        private System.Windows.Forms.DataGridView dataGridViewCategories;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column14;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column15;
        private System.Windows.Forms.DataGridViewImageColumn Column16;
        private System.Windows.Forms.Button buttonAddCategory;
        private System.Windows.Forms.Button buttonEditCategory;
        private System.Windows.Forms.Button buttonDeleteCategory;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button buttonDeleteProduct;
        private System.Windows.Forms.Button buttonEditProduct;
        private System.Windows.Forms.Button buttonAddProduct;
        private System.Windows.Forms.DataGridView dataGridViewProducts;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
    }
}