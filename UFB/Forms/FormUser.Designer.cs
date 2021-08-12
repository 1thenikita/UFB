
namespace UFB.Forms
{
    partial class FormUser
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
            this.labelID = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.textBoxEMail = new System.Windows.Forms.TextBox();
            this.labelEMail = new System.Windows.Forms.Label();
            this.maskedTextBoxPhone = new System.Windows.Forms.MaskedTextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPosition = new System.Windows.Forms.TextBox();
            this.labelPosition = new System.Windows.Forms.Label();
            this.dateTimePickerBirthDate = new System.Windows.Forms.DateTimePicker();
            this.labelBirthDate = new System.Windows.Forms.Label();
            this.textBoxMiddleName = new System.Windows.Forms.TextBox();
            this.labelMiddleName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.comboBoxRole = new System.Windows.Forms.ComboBox();
            this.labelRole = new System.Windows.Forms.Label();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.checkBoxChangePassword = new System.Windows.Forms.CheckBox();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxData.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.groupBoxAction.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(6, 31);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(10, 54);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(200, 26);
            this.textBoxID.TabIndex = 1;
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(6, 83);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(55, 20);
            this.labelLogin.TabIndex = 2;
            this.labelLogin.Text = "Логин";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(10, 107);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(200, 26);
            this.textBoxLogin.TabIndex = 3;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(6, 136);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 20);
            this.labelPassword.TabIndex = 4;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(10, 160);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(200, 26);
            this.textBoxPassword.TabIndex = 5;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.textBoxEMail);
            this.groupBoxData.Controls.Add(this.labelEMail);
            this.groupBoxData.Controls.Add(this.maskedTextBoxPhone);
            this.groupBoxData.Controls.Add(this.labelPhone);
            this.groupBoxData.Controls.Add(this.textBoxPosition);
            this.groupBoxData.Controls.Add(this.labelPosition);
            this.groupBoxData.Controls.Add(this.dateTimePickerBirthDate);
            this.groupBoxData.Controls.Add(this.labelBirthDate);
            this.groupBoxData.Controls.Add(this.textBoxMiddleName);
            this.groupBoxData.Controls.Add(this.labelMiddleName);
            this.groupBoxData.Controls.Add(this.textBoxFirstName);
            this.groupBoxData.Controls.Add(this.labelFirstName);
            this.groupBoxData.Controls.Add(this.textBoxLastName);
            this.groupBoxData.Controls.Add(this.labelLastName);
            this.groupBoxData.Controls.Add(this.comboBoxRole);
            this.groupBoxData.Controls.Add(this.labelRole);
            this.groupBoxData.Controls.Add(this.labelID);
            this.groupBoxData.Controls.Add(this.textBoxPassword);
            this.groupBoxData.Controls.Add(this.textBoxID);
            this.groupBoxData.Controls.Add(this.labelPassword);
            this.groupBoxData.Controls.Add(this.labelLogin);
            this.groupBoxData.Controls.Add(this.textBoxLogin);
            this.groupBoxData.Location = new System.Drawing.Point(12, 12);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(459, 557);
            this.groupBoxData.TabIndex = 6;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Данные";
            // 
            // textBoxEMail
            // 
            this.textBoxEMail.Location = new System.Drawing.Point(231, 107);
            this.textBoxEMail.Name = "textBoxEMail";
            this.textBoxEMail.Size = new System.Drawing.Size(200, 26);
            this.textBoxEMail.TabIndex = 21;
            // 
            // labelEMail
            // 
            this.labelEMail.AutoSize = true;
            this.labelEMail.Location = new System.Drawing.Point(227, 83);
            this.labelEMail.Name = "labelEMail";
            this.labelEMail.Size = new System.Drawing.Size(53, 20);
            this.labelEMail.TabIndex = 20;
            this.labelEMail.Text = "E-Mail";
            // 
            // maskedTextBoxPhone
            // 
            this.maskedTextBoxPhone.Location = new System.Drawing.Point(231, 54);
            this.maskedTextBoxPhone.Mask = "+7 (000) 000-00 00";
            this.maskedTextBoxPhone.Name = "maskedTextBoxPhone";
            this.maskedTextBoxPhone.Size = new System.Drawing.Size(200, 26);
            this.maskedTextBoxPhone.TabIndex = 19;
            // 
            // labelPhone
            // 
            this.labelPhone.AutoSize = true;
            this.labelPhone.Location = new System.Drawing.Point(227, 30);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(142, 20);
            this.labelPhone.TabIndex = 18;
            this.labelPhone.Text = "Номер телефона";
            // 
            // textBoxPosition
            // 
            this.textBoxPosition.Location = new System.Drawing.Point(10, 476);
            this.textBoxPosition.Name = "textBoxPosition";
            this.textBoxPosition.Size = new System.Drawing.Size(200, 26);
            this.textBoxPosition.TabIndex = 17;
            // 
            // labelPosition
            // 
            this.labelPosition.AutoSize = true;
            this.labelPosition.Location = new System.Drawing.Point(6, 453);
            this.labelPosition.Name = "labelPosition";
            this.labelPosition.Size = new System.Drawing.Size(95, 20);
            this.labelPosition.TabIndex = 16;
            this.labelPosition.Text = "Должность";
            // 
            // dateTimePickerBirthDate
            // 
            this.dateTimePickerBirthDate.Location = new System.Drawing.Point(10, 420);
            this.dateTimePickerBirthDate.Name = "dateTimePickerBirthDate";
            this.dateTimePickerBirthDate.Size = new System.Drawing.Size(200, 26);
            this.dateTimePickerBirthDate.TabIndex = 15;
            // 
            // labelBirthDate
            // 
            this.labelBirthDate.AutoSize = true;
            this.labelBirthDate.Location = new System.Drawing.Point(6, 397);
            this.labelBirthDate.Name = "labelBirthDate";
            this.labelBirthDate.Size = new System.Drawing.Size(128, 20);
            this.labelBirthDate.TabIndex = 14;
            this.labelBirthDate.Text = "Дата рождения";
            // 
            // textBoxMiddleName
            // 
            this.textBoxMiddleName.Location = new System.Drawing.Point(10, 368);
            this.textBoxMiddleName.Name = "textBoxMiddleName";
            this.textBoxMiddleName.Size = new System.Drawing.Size(200, 26);
            this.textBoxMiddleName.TabIndex = 13;
            // 
            // labelMiddleName
            // 
            this.labelMiddleName.AutoSize = true;
            this.labelMiddleName.Location = new System.Drawing.Point(6, 345);
            this.labelMiddleName.Name = "labelMiddleName";
            this.labelMiddleName.Size = new System.Drawing.Size(192, 20);
            this.labelMiddleName.TabIndex = 12;
            this.labelMiddleName.Text = "Отчество (при наличии)";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(10, 316);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(200, 26);
            this.textBoxFirstName.TabIndex = 11;
            // 
            // labelFirstName
            // 
            this.labelFirstName.AutoSize = true;
            this.labelFirstName.Location = new System.Drawing.Point(6, 293);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(40, 20);
            this.labelFirstName.TabIndex = 10;
            this.labelFirstName.Text = "Имя";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(10, 264);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(200, 26);
            this.textBoxLastName.TabIndex = 9;
            // 
            // labelLastName
            // 
            this.labelLastName.AutoSize = true;
            this.labelLastName.Location = new System.Drawing.Point(6, 243);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(81, 20);
            this.labelLastName.TabIndex = 8;
            this.labelLastName.Text = "Фамилия";
            // 
            // comboBoxRole
            // 
            this.comboBoxRole.FormattingEnabled = true;
            this.comboBoxRole.Location = new System.Drawing.Point(10, 212);
            this.comboBoxRole.Name = "comboBoxRole";
            this.comboBoxRole.Size = new System.Drawing.Size(200, 28);
            this.comboBoxRole.TabIndex = 7;
            // 
            // labelRole
            // 
            this.labelRole.AutoSize = true;
            this.labelRole.Location = new System.Drawing.Point(6, 189);
            this.labelRole.Name = "labelRole";
            this.labelRole.Size = new System.Drawing.Size(47, 20);
            this.labelRole.TabIndex = 6;
            this.labelRole.Text = "Роль";
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Location = new System.Drawing.Point(6, 25);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(154, 24);
            this.checkBoxStatus.TabIndex = 22;
            this.checkBoxStatus.Text = "Заблокировать";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.checkBoxChangePassword);
            this.groupBoxOptions.Controls.Add(this.checkBoxStatus);
            this.groupBoxOptions.Location = new System.Drawing.Point(487, 201);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(176, 151);
            this.groupBoxOptions.TabIndex = 23;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Опции";
            // 
            // checkBoxChangePassword
            // 
            this.checkBoxChangePassword.AutoSize = true;
            this.checkBoxChangePassword.Location = new System.Drawing.Point(6, 73);
            this.checkBoxChangePassword.Name = "checkBoxChangePassword";
            this.checkBoxChangePassword.Size = new System.Drawing.Size(165, 44);
            this.checkBoxChangePassword.TabIndex = 23;
            this.checkBoxChangePassword.Text = "Сменить пароль \r\nпри входе";
            this.checkBoxChangePassword.UseVisualStyleBackColor = true;
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.buttonDelete);
            this.groupBoxAction.Controls.Add(this.buttonEdit);
            this.groupBoxAction.Controls.Add(this.buttonAdd);
            this.groupBoxAction.Location = new System.Drawing.Point(487, 12);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(176, 166);
            this.groupBoxAction.TabIndex = 7;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "Действия";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(7, 117);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(164, 34);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Orange;
            this.buttonEdit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.buttonEdit.Location = new System.Drawing.Point(6, 76);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(165, 35);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonAdd.Location = new System.Drawing.Point(6, 35);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(165, 35);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // FormUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 581);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.groupBoxAction);
            this.Controls.Add(this.groupBoxData);
            this.Name = "FormUser";
            this.Text = "Форма редактирования/удаления пользователя";
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.groupBoxAction.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.ComboBox comboBoxRole;
        private System.Windows.Forms.Label labelRole;
        private System.Windows.Forms.MaskedTextBox maskedTextBoxPhone;
        private System.Windows.Forms.Label labelPhone;
        private System.Windows.Forms.TextBox textBoxPosition;
        private System.Windows.Forms.Label labelPosition;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthDate;
        private System.Windows.Forms.Label labelBirthDate;
        private System.Windows.Forms.TextBox textBoxMiddleName;
        private System.Windows.Forms.Label labelMiddleName;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.Label labelFirstName;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Label labelLastName;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.CheckBox checkBoxChangePassword;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.TextBox textBoxEMail;
        private System.Windows.Forms.Label labelEMail;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
    }
}