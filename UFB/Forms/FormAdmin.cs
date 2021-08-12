using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UFB.Classes;
using UFB.Classes.Codes.Loads;

namespace UFB.Forms
{
    public partial class FormAdmin : Form
    {
        public FormAdmin()
        {
            InitializeComponent();
            DataGridViews.Users(dataGridViewUsers);
            DataGridViews.Categories(dataGridViewCategories);
            DataGridViews.Products(dataGridViewProducts);
        }

        /// <summary>
        /// Обработчик инициализации формы регистрации пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddUser_Click(object sender, EventArgs e)
        {
            new FormUser(1, 0).ShowDialog();
            DataGridViews.Users(dataGridViewUsers);
        }

        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(dataGridViewUsers.SelectedRows.Count == 0) return;
            int ID = int.Parse(dataGridViewUsers.SelectedRows[0].Cells[0].Value.ToString());

            new FormUser(2, ID).ShowDialog();
            DataGridViews.Users(dataGridViewUsers);
        }

        /// <summary>
        /// Обработчик удаления пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (dataGridViewUsers.SelectedRows.Count == 0) return;
            int ID = int.Parse(dataGridViewUsers.SelectedRows[0].Cells[0].Value.ToString());

            if(Global.MyUser.ID == ID) return;

            User user = Global.DB.Users.FirstOrDefault(_user => _user.ID == ID);

            if (user.ID_Role == 2)
            {
                if (MessageBox.Show("Внимание!\nПри удалении фермера будут удалены все его товары!\nПродолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) return;
            }

            Global.DB.Users.Remove(user);
            Global.DB.SaveChanges();
            MessageBox.Show("Пользователь удалён успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DataGridViews.Users(dataGridViewUsers);
            DataGridViews.Products(dataGridViewProducts);
        }

        /// <summary>
        /// Обработчик изменения пароля своего пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMyUserUpdatePassword_Click(object sender, EventArgs e)
        {
            if(textBoxMyUserPassword.Text == String.Empty) return;
            if(Global.MyUser.Password == textBoxMyUserPassword.Text) return;

            Global.MyUser.Password = textBoxMyUserPassword.Text;
            Global.DB.SaveChanges();
            MessageBox.Show("Пароль изменён успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// Обработчик загрузки формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormAdmin_Load(object sender, EventArgs e)
        {
            labelMyUserName.Text = Global.MyUser.FirstName + " " + Global.MyUser.MiddleName;
            textBoxMyUserPassword.Text = Global.MyUser.Password;
        }

        /// <summary>
        /// Обработчик добавления категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddCategory_Click(object sender, EventArgs e)
        {
            new FormCategory(1, 0).ShowDialog();
            DataGridViews.Categories(dataGridViewCategories);
        }

        /// <summary>
        /// Обработчик изменения категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditCategory_Click(object sender, EventArgs e)
        {
            if(dataGridViewCategories.SelectedRows.Count == 0) return;
            int ID = int.Parse(dataGridViewCategories.SelectedRows[0].Cells[0].Value.ToString());
            new FormCategory(2, ID).ShowDialog();
            DataGridViews.Categories(dataGridViewCategories);
            DataGridViews.Products(dataGridViewProducts);
        }

        /// <summary>
        /// Обработчик удаления категории
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDeleteCategory_Click(object sender, EventArgs e)
        {
            if (dataGridViewCategories.SelectedRows.Count == 0) return;
            int ID = int.Parse(dataGridViewCategories.SelectedRows[0].Cells[0].Value.ToString());
            if (MessageBox.Show("Внимание!\nПри удалении категории будут удалены все товары из неё!\nПродолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) return;

            Category category = Global.DB.Categories.FirstOrDefault(_category => _category.ID == ID);

            Global.DB.Categories.Remove(category);

            Global.DB.SaveChanges();

            DataGridViews.Categories(dataGridViewCategories);
            DataGridViews.Products(dataGridViewProducts);

            MessageBox.Show("Категория с товарами успешно удалена!", "Успех", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        /// <summary>
        /// Обработчик добавления продукта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            new FormProduct(1, 0).ShowDialog();
            DataGridViews.Products(dataGridViewProducts);
        }

        /// <summary>
        /// Обработчик изменения продукта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEditProduct_Click(object sender, EventArgs e)
        {
            if (dataGridViewProducts.SelectedRows.Count == 0) return;
            int ID = int.Parse(dataGridViewProducts.SelectedRows[0].Cells[0].Value.ToString());

            new FormProduct(2, ID).ShowDialog();
            DataGridViews.Products(dataGridViewProducts);
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
