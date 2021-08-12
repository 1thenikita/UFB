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

namespace UFB.Forms
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Инициализация формы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Обработчик кнопки аутентификации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxLogin.Text == String.Empty || textBoxPassword.Text == String.Empty)
            {
                MessageBox.Show("Заполните все поля!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Global.MyUser = Global.DB.Users.FirstOrDefault(user => 
                (user.Login == textBoxLogin.Text || user.EMail == textBoxLogin.Text) 
                && user.Password == textBoxPassword.Text);

            if (Global.MyUser == null)
            {
                MessageBox.Show("Пользователь не найден!\nПроверьте ввод данных!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (Global.MyUser.Status == false)
            {
                MessageBox.Show("Ваш Аккаунт заблокирован!\nОбратитесь к администратору для получения дополнительной информации!", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Global.MyUser.DT_Entrance = DateTime.Now;
            Global.DB.SaveChanges();

            this.Hide();
            switch (Global.MyUser.ID_Role)
            {
                case 1:
                {
                    new FormAdmin().ShowDialog();
                    break;
                }
                case 2:
                {
                    new FormFermer().ShowDialog();
                    break;
                }
            }

            this.Show();

            textBoxLogin.Clear();
            textBoxPassword.Clear();
        }

        /// <summary>
        /// Обработчик показа пароля
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void checkBoxVisiblePassword_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !checkBoxVisiblePassword.Checked;
        }
    }
}
