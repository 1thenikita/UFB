
namespace UFB.Forms
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.buttonLogin = new System.Windows.Forms.Button();
            this.checkBoxVisiblePassword = new System.Windows.Forms.CheckBox();
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.groupBoxData.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelLogin
            // 
            this.labelLogin.AutoSize = true;
            this.labelLogin.Location = new System.Drawing.Point(14, 22);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(55, 20);
            this.labelLogin.TabIndex = 0;
            this.labelLogin.Text = "Логин";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Location = new System.Drawing.Point(18, 46);
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(165, 26);
            this.textBoxLogin.TabIndex = 1;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(14, 75);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 20);
            this.labelPassword.TabIndex = 2;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(18, 98);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(165, 26);
            this.textBoxPassword.TabIndex = 3;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // buttonLogin
            // 
            this.buttonLogin.Location = new System.Drawing.Point(18, 130);
            this.buttonLogin.Name = "buttonLogin";
            this.buttonLogin.Size = new System.Drawing.Size(165, 35);
            this.buttonLogin.TabIndex = 4;
            this.buttonLogin.Text = "Войти";
            this.buttonLogin.UseVisualStyleBackColor = true;
            this.buttonLogin.Click += new System.EventHandler(this.buttonLogin_Click);
            // 
            // checkBoxVisiblePassword
            // 
            this.checkBoxVisiblePassword.AutoSize = true;
            this.checkBoxVisiblePassword.Location = new System.Drawing.Point(18, 25);
            this.checkBoxVisiblePassword.Name = "checkBoxVisiblePassword";
            this.checkBoxVisiblePassword.Size = new System.Drawing.Size(167, 24);
            this.checkBoxVisiblePassword.TabIndex = 5;
            this.checkBoxVisiblePassword.Text = "Показать пароль";
            this.checkBoxVisiblePassword.UseVisualStyleBackColor = true;
            this.checkBoxVisiblePassword.CheckedChanged += new System.EventHandler(this.checkBoxVisiblePassword_CheckedChanged);
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.labelLogin);
            this.groupBoxData.Controls.Add(this.textBoxLogin);
            this.groupBoxData.Controls.Add(this.buttonLogin);
            this.groupBoxData.Controls.Add(this.labelPassword);
            this.groupBoxData.Controls.Add(this.textBoxPassword);
            this.groupBoxData.Location = new System.Drawing.Point(88, 42);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(208, 182);
            this.groupBoxData.TabIndex = 6;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Данные";
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.checkBoxVisiblePassword);
            this.groupBoxOptions.Location = new System.Drawing.Point(88, 230);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(208, 86);
            this.groupBoxOptions.TabIndex = 7;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Опции";
            // 
            // FormLogin
            // 
            this.AcceptButton = this.buttonLogin;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(392, 343);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.groupBoxData);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.Text = "Аутентификация";
            this.Load += new System.EventHandler(this.FormLogin_Load);
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            this.groupBoxOptions.ResumeLayout(false);
            this.groupBoxOptions.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelLogin;
        private System.Windows.Forms.TextBox textBoxLogin;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Button buttonLogin;
        private System.Windows.Forms.CheckBox checkBoxVisiblePassword;
        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.GroupBox groupBoxOptions;
    }
}

