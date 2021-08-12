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
    public partial class FormProduct : Form
    {
        /// <summary>
        /// Инициализации формы
        /// </summary>
        public FormProduct(int ModeCode, int ProductID)
        {
            InitializeComponent();

            switch (ModeCode)
            {
                case 1:
                {
                    buttonDelete.Enabled = false;
                    buttonEdit.Enabled = false;
                    this.Text = "Форма добавления Продукта";
                    break;
                }
                case 2:
                {
                    LoadProduct(ProductID);
                    this.Text = "Форма изменения Продукта";
                    break;
                }
            }
        }

        /// <summary>
        /// Метод загрузки сущности продукта
        /// </summary>
        /// <param name="ProductID">ID продукта</param>
        private void LoadProduct(int ProductID)
        {
            Product product = Global.DB.Products.FirstOrDefault(_product => _product.ID == _product.ID);
            if (product == null) return;

            textBoxID.Text = product.ID.ToString();
            textBoxName.Text = product.Name;
            numericUpDownPrice.Value = product.Price;
            richTextBoxDescription.Text = product.Description;

            comboBoxCategory.SelectedText = product.Category.Name;
            comboBoxFermer.SelectedText = product.User.LastName;
        }

        /// <summary>
        /// Загрузка формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormProduct_Load(object sender, EventArgs e)
        {
            ComboBoxes.Categories(comboBoxCategory);
            ComboBoxes.Fermers(comboBoxFermer);

            if (Global.MyUser.ID_Role == 2)
            {
                labelFermer.Visible = false;
                comboBoxFermer.Visible = false;
            }
        }

        /// <summary>
        /// Обработчик проверки на наличие обязательных параметров
        /// </summary>
        /// <returns></returns>
        private bool CheckRequiedParams()
        {
            if (textBoxName.Text == String.Empty || richTextBoxDescription.Text == String.Empty ||
                numericUpDownPrice.Text == String.Empty)
            {
                MessageBox.Show("Заполните обязательные поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Обработчик добавления продукта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if(!CheckRequiedParams()) return;

            Product product = new Product()
            {
                Name = textBoxName.Text,
                Category = (Category) comboBoxCategory.SelectedItem,
                Description = richTextBoxDescription.Text,
                User = Global.MyUser,
                Price = numericUpDownPrice.Value
            };

            if (Global.MyUser.ID_Role == 1)
            {
                product.User = (User) comboBoxFermer.SelectedItem;
            }

            Global.DB.Products.Add(product);
            Global.DB.SaveChanges();
            textBoxID.Text = product.ID.ToString();
            MessageBox.Show("Продукт добавлен успешно!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
            buttonEdit.Enabled = true;
            buttonDelete.Enabled = true;
        }

        /// <summary>
        /// Обработчик изменения продукта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if(!CheckRequiedParams()) return;

            int ID = int.Parse(textBoxID.Text);

            Product product = Global.DB.Products.FirstOrDefault(_product => _product.ID == ID);

            product.Name = textBoxName.Text;
            product.Price = numericUpDownPrice.Value;
            product.Description = richTextBoxDescription.Text;
            product.User = Global.MyUser;
            product.Category = (Category) comboBoxCategory.SelectedItem;

            if (Global.MyUser.ID_Role == 1)
            {
                product.User = (User)comboBoxFermer.SelectedItem;
            }

            Global.DB.SaveChanges();

            MessageBox.Show("Продукт изменён успешно!", "Успех", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            buttonDelete.Enabled = true;
            buttonEdit.Enabled = true;
        }

        /// <summary>
        /// Обработчик удаления продукта
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(textBoxID.Text);

            Product product = Global.DB.Products.FirstOrDefault(_product => _product.ID == ID);

            Global.DB.Products.Remove(product);
            Global.DB.SaveChanges();

            MessageBox.Show("Продукт успешно удалён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
