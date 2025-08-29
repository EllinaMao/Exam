using GuessGame;
using login_logic;


namespace QuizFoms
{
    public partial class MenuForm : Form
    {
        private User? user { get; set; }
        private string filepathQuiz;
        private string filePathResult = Path.Combine(QuizResultService.QuizzesFolder, "Allresults.json");

        public MenuForm(User user_, string quiz)
        {
            filepathQuiz = quiz;
            if (!Directory.Exists(QuizResultService.QuizzesFolder))
                Directory.CreateDirectory(QuizManager.QuizzesFolder);
            this.StartPosition = FormStartPosition.CenterScreen;
            this.user = user_;
            InitializeComponent();
            userGreetinglb.Text = $"Привет {user.Login.ToString()}!";
        }

        private void btnNewQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            var game = new SelectQuizForm(user, filepathQuiz, filePathResult);
            game.ShowDialog();
            this.Show();
        }


        private void editBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Пока!");
            this.Close();
        }

        private void shuffleBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
