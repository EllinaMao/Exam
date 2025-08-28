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
                txtQuestion.Text = selectedQuestion.Text;
                checkedListBoxAnswers.Items.Clear();

                // Загружаем варианты ответов
                for (int i = 0; i < selectedQuestion.Answers.Count; i++)
                {
                    int idx = checkedListBoxAnswers.Items.Add(selectedQuestion.Answers[i]);
                    // помечаем правильные варианты
                    if (selectedQuestion.CorrectIndexes.Contains(i))
                        checkedListBoxAnswers.SetItemChecked(idx, true);
                }
            }
        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
