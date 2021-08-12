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

namespace UFB.Forms
{
    public partial class FormUser : Form
    {
        /// <summary>
        /// Инициализация формы работы с пользователем
        /// </summary>
        /// <param name="ModeCode">Код режима</param>
        public FormUser(int ModeCode, int UserID)
        {
            InitializeComponent();
            LoadComboBoxRoles();

            switch (ModeCode)
            {
                case 1:
                {
                    this.Text = "Регистрация Пользователя";
                    buttonEdit.Enabled = false;
                    buttonDelete.Enabled = false;
                    break;
                }
                case 2:
                {
                    this.Text = "Изменение Пользователя";
                    LoadUser(UserID);
                    break;
                }
            }
        }

        /// <summary>
        /// Метод загрузки сущности пользователя
        /// </summary>
        /// <param name="UserID">ID пользователя</param>
        private void LoadUser(int UserID)
        {
            User user = Global.DB.Users.FirstOrDefault(_user => _user.ID == _user.ID);
            if (user == null) return;

            if (user == Global.MyUser)
            {
                buttonDelete.Enabled = false;
                checkBoxStatus.Enabled = false;
            }

            textBoxID.Text = user.ID.ToString();
            textBoxLogin.Text = user.Login;
            textBoxPassword.Text = user.Password;
            textBoxFirstName.Text = user.FirstName;
            textBoxMiddleName.Text = user.MiddleName;
            textBoxLastName.Text = user.LastName;
            dateTimePickerBirthDate.Value = user.BirthDate;
            maskedTextBoxPhone.Text = user.Phone;
            textBoxEMail.Text = user.EMail;
            textBoxPosition.Text = user.Position;

            checkBoxChangePassword.Checked = user.Password_Change;
            checkBoxStatus.Checked = !user.Status;
            comboBoxRole.SelectedText = user.Role.Name;
        }

        /// <summary>
        /// Обработчик заполения ролей
        /// </summary>
        private void LoadComboBoxRoles()
        {
            List<Role> role = Global.DB.Roles.ToList();

            comboBoxRole.DataSource = role;
            comboBoxRole.DisplayMember = "Name";
        }

        /// <summary>
        /// Обработчик проверки на наличие обязательных параметров
        /// </summary>
        /// <returns></returns>
        private bool CheckRequiedParams()
        {
            if (textBoxLogin.Text == String.Empty || textBoxPassword.Text == String.Empty ||
                textBoxEMail.Text == String.Empty ||
                textBoxFirstName.Text == String.Empty || textBoxLastName.Text == String.Empty ||
                textBoxPosition.Text == String.Empty ||
                maskedTextBoxPhone.Text == String.Empty)
            {
                MessageBox.Show("Заполните обязательные поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        /// <summary>
        /// Обработчик добавления пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!CheckRequiedParams()) return;

            User user = new User()
            {
                Login = textBoxLogin.Text,
                Password = textBoxPassword.Text,
                LastName = textBoxLastName.Text,
                FirstName = textBoxFirstName.Text,
                MiddleName = textBoxMiddleName.Text,
                Role = (Role) comboBoxRole.SelectedItem,
                BirthDate = dateTimePickerBirthDate.Value,
                DT_Entrance = DateTime.Today,
                EMail = textBoxEMail.Text,
                Phone = maskedTextBoxPhone.Text,
                Password_Change = checkBoxChangePassword.Checked,
                Status = !checkBoxStatus.Checked,
                Position = textBoxPosition.Text,
            };

            Global.DB.Users.Add(user);
            Global.DB.SaveChanges();
            textBoxID.Text = user.ID.ToString();

            MessageBox.Show("Пользователь добавлен успешно!", "Успех", MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }
        
        /// <summary>
        /// Обработчик изменения пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEdit_Click(object sender, EventArgs e)
        {
            if (!CheckRequiedParams()) return;

            int ID = int.Parse(textBoxID.Text);

            User user = Global.DB.Users.FirstOrDefault(_user => _user.ID == ID);

            user.Login = textBoxLogin.Text;
            user.Password = textBoxPassword.Text;
            user.LastName = textBoxLastName.Text;
            user.FirstName = textBoxFirstName.Text;
            user.MiddleName = textBoxMiddleName.Text;
            user.Role = (Role)comboBoxRole.SelectedItem;
            user.BirthDate = dateTimePickerBirthDate.Value;
            user.DT_Entrance = DateTime.Today;
            user.EMail = textBoxEMail.Text;
            user.Phone = maskedTextBoxPhone.Text;
            user.Password_Change = checkBoxChangePassword.Checked;
            user.Status = !checkBoxStatus.Checked;
            user.Position = textBoxPosition.Text;

            Global.DB.SaveChanges();

            MessageBox.Show("Пользователь изменён успешно!", "Успех", MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            buttonDelete.Enabled = true;
            buttonEdit.Enabled = true;
        }

        /// <summary>
        /// Обработчик удаления пользователя
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            int ID = int.Parse(textBoxID.Text);

            User user = Global.DB.Users.FirstOrDefault(_user => _user.ID == ID);

            if (user.ID_Role == 2)
            {
                if (MessageBox.Show("Внимание!\nПри удалении фермера будут удалены все его товары!\nПродолжить?", "Внимание", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.No) return;
            }

            Global.DB.Users.Remove(user);
            Global.DB.SaveChanges();

            MessageBox.Show("Пользователь успешно удалён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
