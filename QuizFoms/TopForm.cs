using GuessGame;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

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
        private void btnShow_Click(object sender, EventArgs e)
        {
            if (cbQuizzes.SelectedItem == null)
            {
                MessageBox.Show("Выберите викторину!");
                return;

            }
            string? quizTitle = cbQuizzes.SelectedItem.ToString();

            // Берём топ-20 игроков через твой сервис
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
