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
//using static GuessGame.ForTests;//файл с вопросами для викторины что б вручную не заполнять

namespace QuizFoms
{

    public partial class QuizEditMainForm : Form
    {
        private string filePath = Path.Combine(QuizManager.QuizzesFolder, "allQuizzes.json");

        public QuizEditMainForm()
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
            qiuzList.DataSource = null;
            qiuzList.DataSource = QuizManager.AllQuizzes; // обращаемся к статическому классу
            qiuzList.DisplayMember = "Title"; // показываем название викторины
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Создаем новую викторину с пустым списком вопросов
            var quiz = new Quiz { Title = "Новая викторина" };
            QuizManager.AddQuiz(quiz);

            RefreshQuizList();
            qiuzList.SelectedItem = quiz;

            // Открываем редактор
            var editor = new QuizEditorForm(quiz);
            editor.ShowDialog();
            RefreshQuizList();

        }

        private void bthDelete_Click(object sender, EventArgs e)
        {
            if (qiuzList.SelectedItem is Quiz quiz)
            {
                // Удаляем из списка всех викторин
                QuizManager.AllQuizzes.Remove(quiz);

                // Обновляем ListBox
                qiuzList.DataSource = null;
                qiuzList.DataSource = QuizManager.AllQuizzes;
                qiuzList.DisplayMember = "Title";
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                QuizManager.SaveAllToFile(filePath);
                MessageBox.Show("Сохранено!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void loadFromFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                QuizManager.LoadAllFromFile(filePath);
                RefreshQuizList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void bthEddit_Click(object sender, EventArgs e)
        {
            if (qiuzList.SelectedItem is Quiz quiz)
            {
                var editor = new QuizEditorForm(quiz);
                editor.ShowDialog();

                // После редактирования обновляем список
                RefreshQuizList();
            }
        }
    }
}
