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
using GuessGame;

namespace QuizFoms
{
    public partial class SelectQuizForm : Form
    {
        private string filePath = Path.Combine(QuizManager.QuizzesFolder, "allQuizzes.json");

        public SelectQuizForm()
        {
            if (!Directory.Exists(QuizManager.QuizzesFolder))
                Directory.CreateDirectory(QuizManager.QuizzesFolder);
            this.StartPosition = FormStartPosition.CenterScreen;
            InitializeComponent();
            QuizManager.LoadAllFromFile(filePath);
            RefreshQuizList();
        }
        private void RefreshQuizList()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = QuizManager.AllQuizzes; // обращаемся к статическому классу
            listBox1.DisplayMember = "Title"; // показываем название викторины
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem is Quiz quiz)
            {
            var game = new GameForm(quiz);
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
