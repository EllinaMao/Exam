using GuessGame;
using login_logic;
namespace QuizFoms
{
    public partial class SelectQuizForm : Form
    {
        User ThisUser { get; set; }
        private readonly QuizResultService resultService;
        private string filePathResult;
        private string filePathQuiz;

        public SelectQuizForm(User user, string filepathQ, string filepathR)
        {
            filePathQuiz= filepathQ;
            filePathResult = filepathR; 
            this.StartPosition = FormStartPosition.CenterScreen;
            ThisUser = user;
            resultService = new QuizResultService();

            InitializeComponent();
            try
            {
            resultService.LoadFromFile(filePathResult);

            QuizManager.LoadAllFromFile(filePathQuiz);
            RefreshQuizList();
            }
            catch
            {
                MessageBox.Show("Проблема с загрузкой викторины");
                this.Close();
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
            var game = new GameForm(quiz, ThisUser.Login, resultService, filePathResult);
            this.Hide();
            game.ShowDialog();
            this.Show();

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
