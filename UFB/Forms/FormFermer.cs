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
    public partial class FormFermer : Form
    {
        /// <summary>
        /// Инициализация формы
        /// </summary>
        public FormFermer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Закрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormFermer_Load(object sender, EventArgs e)
        {
            CheckedVisible();
        }

        /// <summary>
        /// Обработчик изменения продукта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if(dataGridViewProducts.SelectedRows.Count == 0) return;
            int ID = int.Parse(dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString());

            new FormProduct(2, ID).ShowDialog();
            CheckedVisible();
        }

        private void CheckedVisible()
        {
            switch (checkBoxVisibleMyProduct.Checked)
            {
                case true:
                {
                    DataGridViews.Products(dataGridViewProducts, Global.MyUser);
                    buttonDeleteProduct.Enabled = true;
                    buttonEditProduct.Enabled = true;
                    break;
                }
                case false:
                {
                    DataGridViews.Products(dataGridViewProducts);
                    buttonDeleteProduct.Enabled = false;
                    buttonEditProduct.Enabled = false;
                    break;
                }
            }
        }

        /// <summary>
        /// Обработчик просмотра только своих продуктов
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxVisibleMyProduct_CheckedChanged(object sender, EventArgs e)
        {
            CheckedVisible();
        }

        /// <summary>
        /// Обработчик добавления продукта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            new FormProduct(1, 0).ShowDialog();
            CheckedVisible();
        }

        /// <summary>
        /// Обработчик удаления продукта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0) return;
            int ID = int.Parse(dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString());

            Product product = Global.DB.Products.FirstOrDefault(_product => _product.ID == ID);
            Global.DB.Products.Remove(product);
            Global.DB.SaveChanges();
            MessageBox.Show("Продукт удалён успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridViews.Products(dataGridViewProducts);
        }
    }
}
