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

namespace QuizFoms
{
    /*win+. - эмодзи*/

    public partial class QuizEditorForm : Form
    {
        Quiz quiz;

        public QuizEditorForm(Quiz quiz)
        {
            this.quiz = quiz;
            InitializeComponent();
        }

        private void RefreshQuestions()
        {
            listBoxQuestions.DataSource = null;
            listBoxQuestions.DataSource = quiz.Questions; // quiz — текущая викторина
            listBoxQuestions.DisplayMember = "Text";    // он сам полезет искать в Questions

            // Выбираем первый элемент по умолчанию
            if (listBoxQuestions.Items.Count > 0)
                listBoxQuestions.SelectedIndex = 0;
        }

        private void listBoxQuestions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxQuestions.SelectedItem is Question selectedQuestion)
            {
                txtQuestionTxt.Text = selectedQuestion.Text;
                checkedListAnswers.Items.Clear();

                // Загружаем варианты ответов
                for (int i = 0; i < selectedQuestion.Answers.Count; i++)
                {
                    int idx = checkedListAnswers.Items.Add(selectedQuestion.Answers[i]);
                    // помечаем правильные варианты
                    if (selectedQuestion.CorrectIndexes.Contains(i))
                        checkedListAnswers.SetItemChecked(idx, true);
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void btAddQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                var q = new Question("Новый вопрос", new List<string> { "Вариант 1", "Вариант 2", "Вариант 3", "Вариант 4" }, 0);
                quiz.AddQuestion(q);
                RefreshQuestions();
                listBoxQuestions.SelectedItem = q; // сразу выделяем новый вопрос
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message);

            }
            catch (InvalidOperationException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btDeleteQuestion_Click(object sender, EventArgs e)
        {
            if (listBoxQuestions.SelectedItem is Question q)
            {
                quiz.Questions.Remove(q);
                RefreshQuestions();
            }
        }

        private void btChangeQuestion_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();

        }

        private void btSave_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteAnswer_Click(object sender, EventArgs e)
        {
            //ne sdelano 
        }

        private void btnSaveQuestin_Click(object sender, EventArgs e)
        {
            if (listBoxQuestions.SelectedItem is Question q)
            {
                // обновляем текст вопроса
                q.Text = txtQuestionTxt.Text;

                // обновляем список ответов
                q.Answers.Clear();
                q.CorrectIndexes.Clear();

                for (int i = 0; i < checkedListAnswers.Items.Count; i++)
                {
                    q.Answers.Add(checkedListAnswers.Items[i].ToString()!);

                    if (checkedListAnswers.GetItemChecked(i))
                        q.CorrectIndexes.Add(i);
                }

                RefreshQuestions();
                listBoxQuestions.SelectedItem = q; // остаёмся на том же вопросе
            }
        }
    }
}
