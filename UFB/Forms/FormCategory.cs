using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlTypes;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UFB.Classes;

namespace UFB.Forms
{
    public partial class FormCategory : Form
    {
        byte[] Photo;
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public FormCategory(int ModeCode, int CategoryID)
        {
            InitializeComponent();

            switch (ModeCode)
            {
                case 1:
                {
                    this.Text = "Регистрация Категории";
                    buttonEdit.Enabled = false;
                    buttonDelete.Enabled = false;
                    break;
                }
                case 2:
                {
                    this.Text = "Изменение Категории";
                    LoadCategory(CategoryID);
                    break;
                }
            }
        }

        /// <summary>
        /// Метод загрузки сущности категории
        /// </summary>
        /// <param name="ID"></param>
        private void LoadCategory(int ID)
        {
            Category category = Global.DB.Categories.FirstOrDefault(_category => _category.ID == _category.ID);
            if (category == null) return;

            textBoxID.Text = category.ID.ToString();
            textBoxName.Text = category.Name;
            richTextBoxDescription.Text = category.Description;
            numericUpDownNormalPrice.Value = category.NormalPrice;
            numericUpDownDeltaPrice.Value = category.DeltaPrice;

            category.Photo = Photo;
            if (Photo != null)
            {
                Stream stream = new MemoryStream();
                stream.Write(Photo, 0, Photo.Length);
            }
        }

        /// <summary>
        /// Обработчик проверки на наличие обязательных параметров
        /// </summary>
        /// <returns></returns>
        private bool CheckRequiedParams()
        {
            if (textBoxName.Text == String.Empty || richTextBoxDescription.Text == String.Empty || numericUpDownDeltaPrice.Text == String.Empty || numericUpDownNormalPrice.Text == String.Empty)
            {
                MessageBox.Show("Заполните обязательные поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Обработчик кнопки добавления
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(CheckRequiedParams() == false) return;

            Category category = new Category()
            {
                Name = textBoxName.Text,
                Description = richTextBoxDescription.Text,
                Photo = Photo,
                NormalPrice = numericUpDownNormalPrice.Value,
                DeltaPrice = numericUpDownDeltaPrice.Value
            };

            Global.DB.Categories.Add(category);
            Global.DB.SaveChanges();

            textBoxID.Text = category.ID.ToString();

            MessageBox.Show("Категория добавлена успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonDelete.Enabled = true;
            buttonEdit.Enabled = true;
        }

        /// <summary>
        /// Обработчик загрузки изображения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLoadImage_Click(object sender, EventArgs e)
        {
            if(openFileDialogImage.ShowDialog() == DialogResult.Cancel) return;

            using (Stream s = new FileStream(openFileDialogImage.FileName, FileMode.Open))
            {
                Photo = new byte[s.Length];
                s.Read(Photo, 0, Photo.Length);
                pictureBoxImage.Image = Image.FromStream(s);
                s.Close();
            }
        }

        /// <summary>
        /// Обработчик удаления изображения
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteImage_Click(object sender, EventArgs e)
        {
            //pictureBoxImage.Image = null;
            //Photo = null;
        }

        /// <summary>
        /// Обработчик изменения категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!CheckRequiedParams()) return;

            int ID = int.Parse(textBoxID.Text);

            Category category = Global.DB.Categories.FirstOrDefault(_category => _category.ID == ID);

            category.Name = textBoxName.Text;
            category.Description = richTextBoxDescription.Text;
            category.Photo = Photo;
            category.NormalPrice = numericUpDownNormalPrice.Value;
            category.DeltaPrice = numericUpDownDeltaPrice.Value;

            Global.DB.SaveChanges();

            MessageBox.Show("Категория изменена успешно!", "Успех", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Обработчик удаления категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Внимание!\nПри удалении категории будут удалены все товары из неё!\nПродолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) return;

            int ID = int.Parse(textBoxID.Text);

            Category category = Global.DB.Categories.FirstOrDefault(_category => _category.ID == ID);
            Global.DB.Categories.Remove(category);
            Global.DB.SaveChanges();

            MessageBox.Show("Категория успешно удалена!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
