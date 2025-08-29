using GuessGame;
using login_logic;
using System.Windows.Forms;

namespace QuizFoms
{
    public partial class AuthForm : Form
    {
        AuthService authService;
        User? ThisUser { get; set; }
        public AuthForm()
        {
            if (!Directory.Exists(QuizManager.QuizzesFolder))
                Directory.CreateDirectory(QuizManager.QuizzesFolder);

            this.StartPosition = FormStartPosition.CenterScreen;
            authService = new();
            authService.LoadUsers();
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                ThisUser = authService.Login(login_box.Text, password_box.Text);
                if (ThisUser != null)
                {
                    VisibleMenu(false);
                }
            }
            catch (InvalidLoginOrPasswordException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VisibleMenu(bool show)
        {
            text_boxes_panel.Visible = show;
            name_register_panel.Visible = show;
            AuthText.Visible = show;
            pictureBox3.Visible = show;
            GameChoicePanel.Visible = !show;

        }

        private void backToLoginScreen_Click(object sender, EventArgs e)
        {
            ThisUser = null;
            VisibleMenu(true);
        }

        private void register_button_Click(object sender, EventArgs e)
        {
            //тут вызываем отдельную форму которая сама разбирается с ошибками
            var registerForm = new RegisterForm(authService);
            var result = registerForm.ShowDialog();
            if (result == DialogResult.OK)
            {
                MessageBox.Show("Теперь можете войти под своим логином и паролем.");
            }

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            password_box.UseSystemPasswordChar = !password_box.UseSystemPasswordChar;
        }

        private void enterGame_Click(object sender, EventArgs e)
        {
            this.Hide(); // скрываем текущую форму
            var game = new MenuForm(ThisUser);
            game.ShowDialog();
            this.Show(); // показываем форму снова после закрытия редактора
            authService.SaveUsers();
        }

        private void enter_Edditor_Click(object sender, EventArgs e)
        {
            this.Hide(); // скрываем текущую форму
            var eddit = new QuizEditMainForm();
            eddit.ShowDialog();
            this.Show(); // показываем форму снова после закрытия редактора
        }
    }
}
