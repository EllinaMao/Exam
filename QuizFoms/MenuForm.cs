using GuessGame;
using login_logic;


namespace QuizFoms
{
    public partial class MenuForm : Form
    {
        private User? user { get; set; }

        public  MenuForm(User user_)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.user = user_;
            InitializeComponent();
            userGreetinglb.Text = $"Привет {user.Login.ToString()}!";
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


        private void editBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пока!");
            this.Close();
        }


        private void settingsBtn_Click(object sender, EventArgs e)
        {

        }

        private void Top20Btn_Click(object sender, EventArgs e)
        {

        }

        private void myResBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
