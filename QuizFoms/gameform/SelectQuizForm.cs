using GuessGame;
using login_logic;
namespace QuizFoms
{
    public partial class SelectQuizForm : Form
    {
        User ThisUser { get; set; }

        public SelectQuizForm(User user)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            ThisUser = user;

            InitializeComponent();
            try
            {
                QuizResultService.LoadFromFile(QuizResultService.FilePath);

                QuizManager.LoadAllFromFile(QuizManager.Filepath);
                RefreshQuizList();
            }
            catch
            {
                MessageBox.Show("Проблема с загрузкой викторины");
            }
        }
        private void RefreshQuizList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = QuizManager.AllQuizzes; // обращаемся к статическому классу
            listBox1.DisplayMember = "Title"; // показываем название викторины
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Quiz quiz)
            {
                var game = new GameForm(quiz, ThisUser.Login);
                this.Hide();
                game.ShowDialog();
                this.Show();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void randomBtn_Click(object sender, EventArgs e)
        {
            var shuffledQuiz = new Quiz
            {
                Title = "Смешанная викторина",
                Description = "Вопросы из всех разделов",
                Category = "Mixed"
            };
            var allQuestions = QuizManager.AllQuizzes
            .SelectMany(q => q.Questions)
            .ToList();
            var rnd = new Random();
            var randomQuestions = allQuestions.OrderBy(q => rnd.Next())
                                              .Take(shuffledQuiz.questionLimit)
                                              .ToList();

            shuffledQuiz.Questions = randomQuestions;

            var game = new GameForm(shuffledQuiz, ThisUser.Login);
            this.Hide();
            game.ShowDialog();
            this.Show();


        }
    }
}
