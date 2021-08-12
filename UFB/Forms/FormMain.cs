using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UFB.Classes;
using UFB.Classes.Codes.Loads;

namespace UFB.Forms
{
    public partial class FormMain : Form
    {
        /// <summary>
        /// Инициализация формы и соединения с БД
        /// </summary>
        public FormMain()
        {
            InitializeComponent();
            try
            {
                Global.DB = new UFBEntities();
            }
            catch
            {
                MessageBox.Show("Критическая ошибка!\nРабота программы невозможна!", "Ошибка!", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                this.Close();
            }
        }

        /// <summary>
        /// Обработчик открытия формы аутентификации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new FormLogin().ShowDialog();
            this.Show();
            UpdateDatas();
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormMain_Load(object sender, EventArgs e)
        {
            UpdateDatas();
        }

        /// <summary>
        /// Обработчик загрузки или обновления данных
        /// </summary>
        private void UpdateDatas()
        {
            DataGridViews.Products(dataGridViewCategories);
            ComboBoxes.Categories(comboBoxCategories);
            ComboBoxes.Fermers(comboBoxFermersName);
        }

        /// <summary>
        /// Обработчик изменения категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            Category category = (Category) comboBoxCategories.SelectedItem;
            richTextBoxCategoriesDescription.Text = category.Description;
            
            DataGridViews.Products(dataGridViewCategories, category);
        }

        /// <summary>
        /// Обработчик изменения фермера
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxFermersName_SelectedIndexChanged(object sender, EventArgs e)
        {
            User fermer = (User) comboBoxFermersName.SelectedItem;

            DataGridViews.Products(dataGridViewFermersProducts, fermer);
        }
    }
}
