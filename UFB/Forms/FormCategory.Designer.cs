
namespace UFB.Forms
{
    partial class FormCategory
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
            this.groupBoxData = new System.Windows.Forms.GroupBox();
            this.pictureBoxImage = new System.Windows.Forms.PictureBox();
            this.labelImage = new System.Windows.Forms.Label();
            this.richTextBoxDescription = new System.Windows.Forms.RichTextBox();
            this.labelDescription = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.textBoxID = new System.Windows.Forms.TextBox();
            this.labelID = new System.Windows.Forms.Label();
            this.buttonLoadImage = new System.Windows.Forms.Button();
            this.openFileDialogImage = new System.Windows.Forms.OpenFileDialog();
            this.groupBoxAction = new System.Windows.Forms.GroupBox();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.buttonEdit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBoxOptions = new System.Windows.Forms.GroupBox();
            this.buttonDeleteImage = new System.Windows.Forms.Button();
            this.labelNormalPrice = new System.Windows.Forms.Label();
            this.numericUpDownNormalPrice = new System.Windows.Forms.NumericUpDown();
            this.labelDeltaPrice = new System.Windows.Forms.Label();
            this.numericUpDownDeltaPrice = new System.Windows.Forms.NumericUpDown();
            this.groupBoxData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).BeginInit();
            this.groupBoxAction.SuspendLayout();
            this.groupBoxOptions.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNormalPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeltaPrice)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxData
            // 
            this.groupBoxData.Controls.Add(this.numericUpDownDeltaPrice);
            this.groupBoxData.Controls.Add(this.labelDeltaPrice);
            this.groupBoxData.Controls.Add(this.numericUpDownNormalPrice);
            this.groupBoxData.Controls.Add(this.labelNormalPrice);
            this.groupBoxData.Controls.Add(this.pictureBoxImage);
            this.groupBoxData.Controls.Add(this.labelImage);
            this.groupBoxData.Controls.Add(this.richTextBoxDescription);
            this.groupBoxData.Controls.Add(this.labelDescription);
            this.groupBoxData.Controls.Add(this.textBoxName);
            this.groupBoxData.Controls.Add(this.labelName);
            this.groupBoxData.Controls.Add(this.textBoxID);
            this.groupBoxData.Controls.Add(this.labelID);
            this.groupBoxData.Location = new System.Drawing.Point(13, 13);
            this.groupBoxData.Name = "groupBoxData";
            this.groupBoxData.Size = new System.Drawing.Size(224, 572);
            this.groupBoxData.TabIndex = 0;
            this.groupBoxData.TabStop = false;
            this.groupBoxData.Text = "Данные";
            // 
            // pictureBoxImage
            // 
            this.pictureBoxImage.Location = new System.Drawing.Point(11, 291);
            this.pictureBoxImage.Name = "pictureBoxImage";
            this.pictureBoxImage.Size = new System.Drawing.Size(207, 150);
            this.pictureBoxImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxImage.TabIndex = 7;
            this.pictureBoxImage.TabStop = false;
            // 
            // labelImage
            // 
            this.labelImage.AutoSize = true;
            this.labelImage.Location = new System.Drawing.Point(7, 267);
            this.labelImage.Name = "labelImage";
            this.labelImage.Size = new System.Drawing.Size(111, 20);
            this.labelImage.TabIndex = 6;
            this.labelImage.Text = "Изображение";
            // 
            // richTextBoxDescription
            // 
            this.richTextBoxDescription.Location = new System.Drawing.Point(11, 164);
            this.richTextBoxDescription.Name = "richTextBoxDescription";
            this.richTextBoxDescription.Size = new System.Drawing.Size(207, 96);
            this.richTextBoxDescription.TabIndex = 5;
            this.richTextBoxDescription.Text = "";
            // 
            // labelDescription
            // 
            this.labelDescription.AutoSize = true;
            this.labelDescription.Location = new System.Drawing.Point(11, 140);
            this.labelDescription.Name = "labelDescription";
            this.labelDescription.Size = new System.Drawing.Size(83, 20);
            this.labelDescription.TabIndex = 4;
            this.labelDescription.Text = "Описание";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(11, 107);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(207, 26);
            this.textBoxName.TabIndex = 3;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(11, 83);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(83, 20);
            this.labelName.TabIndex = 2;
            this.labelName.Text = "Название";
            // 
            // textBoxID
            // 
            this.textBoxID.Enabled = false;
            this.textBoxID.Location = new System.Drawing.Point(11, 50);
            this.textBoxID.Name = "textBoxID";
            this.textBoxID.Size = new System.Drawing.Size(207, 26);
            this.textBoxID.TabIndex = 1;
            // 
            // labelID
            // 
            this.labelID.AutoSize = true;
            this.labelID.Location = new System.Drawing.Point(7, 26);
            this.labelID.Name = "labelID";
            this.labelID.Size = new System.Drawing.Size(26, 20);
            this.labelID.TabIndex = 0;
            this.labelID.Text = "ID";
            // 
            // buttonLoadImage
            // 
            this.buttonLoadImage.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonLoadImage.Location = new System.Drawing.Point(6, 45);
            this.buttonLoadImage.Name = "buttonLoadImage";
            this.buttonLoadImage.Size = new System.Drawing.Size(188, 51);
            this.buttonLoadImage.TabIndex = 3;
            this.buttonLoadImage.Text = "Загрузить изображение";
            this.buttonLoadImage.UseVisualStyleBackColor = false;
            this.buttonLoadImage.Click += new System.EventHandler(this.buttonLoadImage_Click);
            // 
            // openFileDialogImage
            // 
            this.openFileDialogImage.Filter = "PNG файл|*.png|JPG файл|*.jpg|JPEG файл|*.jpeg";
            this.openFileDialogImage.Title = "Загрузка изображения";
            // 
            // groupBoxAction
            // 
            this.groupBoxAction.Controls.Add(this.buttonDelete);
            this.groupBoxAction.Controls.Add(this.buttonEdit);
            this.groupBoxAction.Controls.Add(this.buttonAdd);
            this.groupBoxAction.Location = new System.Drawing.Point(243, 13);
            this.groupBoxAction.Name = "groupBoxAction";
            this.groupBoxAction.Size = new System.Drawing.Size(200, 260);
            this.groupBoxAction.TabIndex = 1;
            this.groupBoxAction.TabStop = false;
            this.groupBoxAction.Text = "Действия";
            // 
            // buttonDelete
            // 
            this.buttonDelete.BackColor = System.Drawing.Color.Red;
            this.buttonDelete.Location = new System.Drawing.Point(6, 114);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(186, 38);
            this.buttonDelete.TabIndex = 2;
            this.buttonDelete.Text = "Удалить";
            this.buttonDelete.UseVisualStyleBackColor = false;
            this.buttonDelete.Click += new System.EventHandler(this.buttonDelete_Click);
            // 
            // buttonEdit
            // 
            this.buttonEdit.BackColor = System.Drawing.Color.Orange;
            this.buttonEdit.Location = new System.Drawing.Point(8, 70);
            this.buttonEdit.Name = "buttonEdit";
            this.buttonEdit.Size = new System.Drawing.Size(187, 38);
            this.buttonEdit.TabIndex = 1;
            this.buttonEdit.Text = "Изменить";
            this.buttonEdit.UseVisualStyleBackColor = false;
            this.buttonEdit.Click += new System.EventHandler(this.buttonEdit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.LawnGreen;
            this.buttonAdd.Location = new System.Drawing.Point(7, 26);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(187, 38);
            this.buttonAdd.TabIndex = 0;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // groupBoxOptions
            // 
            this.groupBoxOptions.Controls.Add(this.buttonDeleteImage);
            this.groupBoxOptions.Controls.Add(this.buttonLoadImage);
            this.groupBoxOptions.Location = new System.Drawing.Point(244, 280);
            this.groupBoxOptions.Name = "groupBoxOptions";
            this.groupBoxOptions.Size = new System.Drawing.Size(200, 180);
            this.groupBoxOptions.TabIndex = 2;
            this.groupBoxOptions.TabStop = false;
            this.groupBoxOptions.Text = "Опции";
            // 
            // buttonDeleteImage
            // 
            this.buttonDeleteImage.BackColor = System.Drawing.Color.Red;
            this.buttonDeleteImage.Location = new System.Drawing.Point(6, 102);
            this.buttonDeleteImage.Name = "buttonDeleteImage";
            this.buttonDeleteImage.Size = new System.Drawing.Size(188, 51);
            this.buttonDeleteImage.TabIndex = 4;
            this.buttonDeleteImage.Text = "Удалить изображение";
            this.buttonDeleteImage.UseVisualStyleBackColor = false;
            this.buttonDeleteImage.Click += new System.EventHandler(this.buttonDeleteImage_Click);
            // 
            // labelNormalPrice
            // 
            this.labelNormalPrice.AutoSize = true;
            this.labelNormalPrice.Location = new System.Drawing.Point(6, 449);
            this.labelNormalPrice.Name = "labelNormalPrice";
            this.labelNormalPrice.Size = new System.Drawing.Size(145, 20);
            this.labelNormalPrice.TabIndex = 8;
            this.labelNormalPrice.Text = "Нормальная цена";
            // 
            // numericUpDownNormalPrice
            // 
            this.numericUpDownNormalPrice.DecimalPlaces = 2;
            this.numericUpDownNormalPrice.Location = new System.Drawing.Point(11, 472);
            this.numericUpDownNormalPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownNormalPrice.Name = "numericUpDownNormalPrice";
            this.numericUpDownNormalPrice.Size = new System.Drawing.Size(207, 26);
            this.numericUpDownNormalPrice.TabIndex = 9;
            // 
            // labelDeltaPrice
            // 
            this.labelDeltaPrice.AutoSize = true;
            this.labelDeltaPrice.Location = new System.Drawing.Point(6, 502);
            this.labelDeltaPrice.Name = "labelDeltaPrice";
            this.labelDeltaPrice.Size = new System.Drawing.Size(210, 20);
            this.labelDeltaPrice.TabIndex = 10;
            this.labelDeltaPrice.Text = "Допустимый расброс цены";
            // 
            // numericUpDownDeltaPrice
            // 
            this.numericUpDownDeltaPrice.DecimalPlaces = 2;
            this.numericUpDownDeltaPrice.Location = new System.Drawing.Point(11, 525);
            this.numericUpDownDeltaPrice.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.numericUpDownDeltaPrice.Name = "numericUpDownDeltaPrice";
            this.numericUpDownDeltaPrice.Size = new System.Drawing.Size(207, 26);
            this.numericUpDownDeltaPrice.TabIndex = 11;
            // 
            // FormCategory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 597);
            this.Controls.Add(this.groupBoxOptions);
            this.Controls.Add(this.groupBoxAction);
            this.Controls.Add(this.groupBoxData);
            this.Name = "FormCategory";
            this.Text = "Форма добавления/изменения категории";
            this.groupBoxData.ResumeLayout(false);
            this.groupBoxData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxImage)).EndInit();
            this.groupBoxAction.ResumeLayout(false);
            this.groupBoxOptions.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownNormalPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownDeltaPrice)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxData;
        private System.Windows.Forms.PictureBox pictureBoxImage;
        private System.Windows.Forms.Label labelImage;
        private System.Windows.Forms.RichTextBox richTextBoxDescription;
        private System.Windows.Forms.Label labelDescription;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.TextBox textBoxID;
        private System.Windows.Forms.Label labelID;
        private System.Windows.Forms.Button buttonLoadImage;
        private System.Windows.Forms.OpenFileDialog openFileDialogImage;
        private System.Windows.Forms.GroupBox groupBoxAction;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.Button buttonEdit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBoxOptions;
        private System.Windows.Forms.Button buttonDeleteImage;
        private System.Windows.Forms.NumericUpDown numericUpDownDeltaPrice;
        private System.Windows.Forms.Label labelDeltaPrice;
        private System.Windows.Forms.NumericUpDown numericUpDownNormalPrice;
        private System.Windows.Forms.Label labelNormalPrice;
    }
}