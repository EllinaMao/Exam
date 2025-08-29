using GuessGame;
using login_logic;


namespace QuizFoms
{
    public partial class MenuForm : Form
    {
        private User? user { get; set; }

        public MenuForm(User user_)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.user = user_;
            InitializeComponent();
            userGreetinglb.Text = $"Привет {user.Login.ToString()}!";
            QuizResultService.LoadFromFile(QuizResultService.FilePath);
            QuizManager.LoadAllFromFile(QuizManager.Filepath);
        }

        private void btnNewQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var selectForm = new SelectQuizForm(user))
            {
                selectForm.ShowDialog();
            }
            this.Show();
        }


        private void settingsBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var selectForm = new SettingsForm(user))
            {
                var result = selectForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    AuthService.SaveUsers();
                    MessageBox.Show("Настройки успешно сохранены!");
                }
                else
                {
                    MessageBox.Show("Изменения отменены.");
                }
            }
            this.Show();
        }


        private void Top20Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var selectForm = new TopForm())
            {
                selectForm.ShowDialog();

            }
            this.Show();
        }

        private void myResBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            using (var selectForm = new ResultsForm(user))
            {
                selectForm.ShowDialog();

            }
            this.Show();
        }

        private void editBtn_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Пока!");
            this.Close();
        }


    }
}
