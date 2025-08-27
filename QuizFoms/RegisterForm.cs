using login_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizFoms
{
    public partial class RegisterForm : Form
    {
        AuthService authService;
        public RegisterForm(AuthService authService)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.authService = authService;
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            txtPassword.UseSystemPasswordChar = !txtPassword.UseSystemPasswordChar;
        }

        private void registrationButton_Click(object sender, EventArgs e)
        {
            try
            {
                var login = txtLogin.Text;
                var tpassword = txtPassword.Text;
                var birthDate = DateOnly.FromDateTime(dateTimeBox.Value);

                authService.Register(login, tpassword, birthDate);

                MessageBox.Show("Регистрация прошла успешно!");
                this.DialogResult = DialogResult.OK; // чтобы можно было проверить результат
                this.Close();
            }

            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
