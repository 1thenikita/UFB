using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UFBLibrary;

namespace UFB.Classes.Codes.Loads
{
    public class DataGridViews
    {
        /// <summary>
        /// Обработчик заполнения информации о пользователе
        /// </summary>
        /// <param name="dataGridViewUsers"></param>
        public static void Users(DataGridView dataGridViewUsers)
        {
            dataGridViewUsers.Rows.Clear();
            List<User> users = Global.DB.Users.ToList();

            for (int i = 0; i < users.Count; i++)
            {
                string status = "Включен";
                if (users[i].Status == false)
                {
                    status = "Выключен";
                }

                dataGridViewUsers.Rows.Add(users[i].ID, users[i].Login, users[i].Role.Name, users[i].LastName,
                    users[i].FirstName, users[i].MiddleName, users[i].BirthDate.ToString(),
                    users[i].Position, users[i].Phone, users[i].EMail, users[i].DT_Entrance, status);
            }
        }

        /// <summary>
        /// Обработчик заполнения информации о продуктах
        /// </summary>
        /// <param name="dataGridViewUsers">DataGridView</param>
        public static void Products(DataGridView dataGridViewProducts)
        {
            dataGridViewProducts.Rows.Clear();
            List<Product> products = Global.DB.Products.ToList();

            for (int i = 0; i < products.Count; i++)
            {
                string Price = ProductL.CheckPrice(products[i].Price, products[i].Category.NormalPrice,
                    products[i].Category.DeltaPrice);
                dataGridViewProducts.Rows.Add(products[i].ID, products[i].Name, products[i].Description, products[i].Price.ToString(),
                    products[i].User.LastName + " " + products[i].User.FirstName + " " + products[i].User.MiddleName, products[i].User.Phone, Price);
            }
        }


        /// <summary>
        /// Обработчик заполнения информации о продуктах с заданной категорией
        /// </summary>
        /// <param name="dataGridViewProducts">DataGridView</param>
        /// <param name="category">Категория</param>
        public static void Products(DataGridView dataGridViewProducts, Category category)
        {
            dataGridViewProducts.Rows.Clear();
            List<Product> products = Global.DB.Products.Where(product => product.ID_Category == category.ID).ToList();

            for (int i = 0; i < products.Count; i++)
            {
                string Price = ProductL.CheckPrice(products[i].Price, products[i].Category.NormalPrice,
                    products[i].Category.DeltaPrice);
                dataGridViewProducts.Rows.Add(products[i].ID, products[i].Name, products[i].Description, products[i].Price.ToString(),
                    products[i].User.LastName + " " + products[i].User.FirstName + " " + products[i].User.MiddleName, products[i].User.Phone, Price);
            }
        }

        /// <summary>
        /// Обработчик заполнения информации о продуктах с заданным фермером
        /// </summary>
        /// <param name="dataGridViewProducts">DataGridView</param>
        /// <param name="user">Фермер</param>
        public static void Products(DataGridView dataGridViewProducts, User user)
        {
            dataGridViewProducts.Rows.Clear();
            List<Product> products = Global.DB.Products.Where(product => product.ID_User == user.ID).ToList();

            for (int i = 0; i < products.Count; i++)
            {
                string Price = ProductL.CheckPrice(products[i].Price, products[i].Category.NormalPrice,
                    products[i].Category.DeltaPrice);
                dataGridViewProducts.Rows.Add(products[i].ID, products[i].Name, products[i].Description, products[i].Price.ToString(),
                    products[i].Category.Name, products[i].User.LastName + " " + products[i].User.FirstName + " " + products[i].User.MiddleName, products[i].User.Phone, Price);
            }
        }

        /// <summary>
        /// Обработчик заполнения информации о категориях
        /// </summary>
        /// <param name="dataGridViewUsers"></param>
        public static void Categories(DataGridView dataGridViewCategories)
        {
            dataGridViewCategories.Rows.Clear();
            List<Category> categories = Global.DB.Categories.ToList();

            for (int i = 0; i < categories.Count; i++)
            {
                byte[] PhotoByte = categories[i].Photo;
                Stream stream = new MemoryStream();
                if (PhotoByte != null)
                {
                    stream.Write(PhotoByte, 0, PhotoByte.Length);
                    dataGridViewCategories.Rows.Add(categories[i].ID, categories[i].Name, categories[i].Description, Image.FromStream(stream));
                }
                if (PhotoByte == null)
                {
                    dataGridViewCategories.Rows.Add(categories[i].ID, categories[i].Name, categories[i].Description, null);
                }
                stream.Close();
            }
        }
    }
}
