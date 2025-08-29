using login_logic;
using GuessGame;

namespace QuizFoms
{
    public partial class GameForm : Form
    {
        private readonly string userLogin;
        private Quiz ThisQuiz { get; set; }
        private int currentQuestionIndex = 0;
        private int score = 0;
        private List<Question> questions;
        public GameForm(Quiz quiz, string login)
        {

            ThisQuiz = quiz;
            userLogin = login;
            this.StartPosition = FormStartPosition.CenterScreen;

            InitializeComponent();

            var rnd = new Random();
            questions = ThisQuiz.Questions.OrderBy(q => rnd.Next()).ToList();

            ShowQuestion();
        }

        private void ShowQuestion()
        {
            if (currentQuestionIndex >= questions.Count)
            {
                FinishQuiz();
                return;
            }

            var q = questions[currentQuestionIndex];

            questionNumberLb.Text = $"Вопрос {currentQuestionIndex + 1}/{questions.Count}";
            questionTextLb.Text = q.Text;

            // Заполняем варианты ответов
            checkedListBox1.Items.Clear();
            foreach (var ans in q.Answers)
                checkedListBox1.Items.Add(ans);
        }

        private void Next_Click(object sender, EventArgs e)
        {
            var q = questions[currentQuestionIndex];

            // Собираем выбранные индексы
            var selectedIndexes = new List<int>();
            for (int i = 0; i < checkedListBox1.Items.Count; i++)
                if (checkedListBox1.GetItemChecked(i))
                    selectedIndexes.Add(i);

            // Проверка правильности
            if (q.IsCorrect(selectedIndexes))
                score++;

            currentQuestionIndex++;
            ShowQuestion();
        }
        private void FinishQuiz()
        {
            // Создаём объект результата
            var result = new QuizResult
            {
                UserLogin = userLogin,
                QuizTitle = ThisQuiz.Title,
                Score = score,
                Date = DateTime.Now
            };

            // Сохраняем в сервис
            QuizResultService.AddResult(userLogin, result);
            QuizResultService.SaveToFile(QuizResultService.FilePath);
            // Определяем место игрока в рейтинге
            int place = QuizResultService.GetPlace(userLogin, result);

            MessageBox.Show(
           $"Викторина завершена!\n" +
            $"Ваш результат: {score} из {questions.Count} правильных.\n" +
            $"Ваше место в рейтинге: {place}",
            "Результат");

            this.Close();
        }


    }
}
