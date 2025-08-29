using GuessGame;
using System.Data;

namespace QuizFoms
{
    public partial class TopForm : Form
    {
        public TopForm()
        {
            InitializeComponent();
            var quizTitles = QuizResultService
                .GetAllResults()
                .Select(r => r.QuizTitle)
                .Distinct()
                .ToList();

            cbQuizzes.Items.Clear();
            cbQuizzes.Items.AddRange(quizTitles.ToArray());
            if (cbQuizzes.Items.Count > 0)
            {
                cbQuizzes.SelectedIndex = 0;
                LoadTopResults();
            }
        }
        private void LoadTopResults()
        {
            if (cbQuizzes.SelectedItem == null)
                return;

            string quizTitle = cbQuizzes.SelectedItem.ToString();

            var topPlayers = QuizResultService.GetTopResults(quizTitle, 20)
                .Select((r, index) => new
                {
                    Место = index + 1,
                    Игрок = r.UserLogin,
                    Очки = r.Score,
                    Дата = r.Date.ToString("dd.MM.yyyy HH:mm")
                })
                .ToList();

            dgvTopPlayers.DataSource = topPlayers;
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cbQuizzes_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTopResults();
        }
    }
}
