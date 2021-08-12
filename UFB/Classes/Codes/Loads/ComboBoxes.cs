using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UFB.Classes.Codes.Loads
{
    public class ComboBoxes
    {
        /// <summary>
        /// Обработчик загрузки комбобокса с категориями
        /// </summary>
        /// <param name="comboBox"></param>
        public static void Categories(ComboBox comboBox)
        {
            List<Category> categories = Global.DB.Categories.ToList();

            comboBox.DataSource = categories;
            comboBox.DisplayMember = "Name";
        }

        /// <summary>
        /// Обработчик загрузки комбобокса с фермерами
        /// </summary>
        /// <param name="comboBox"></param>
        public static void Fermers(ComboBox comboBox)
        {
            List<User> users = Global.DB.Users.Where(_user => _user.ID_Role == 2).ToList();

            comboBox.DataSource = users;
            comboBox.DisplayMember = "FirstName";
        }
    }
}
