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
            this.StartPosition = FormStartPosition.CenterScreen;

            this.quiz = quiz;
            InitializeComponent();
            lbControl.Text = $"{quiz.Questions.Count}/{quiz.questionLimit}";
            btnSave.Enabled = false;

            txtName.Text = quiz.Title;
            txtDescription.Text = quiz.Description;
            txtCategory.Text = quiz.Category;

            RefreshQuestions();

        }

        private void RefreshQuestions()
        {
            listBoxQuestions.DataSource = null;
            listBoxQuestions.DataSource = quiz.Questions;
            listBoxQuestions.DisplayMember = "Text";

            if (listBoxQuestions.Items.Count > 0)
                listBoxQuestions.SelectedIndex = 0;

            UpdateControlsState();
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
        private void UpdateControlsState()
        {
            // Обновляем состояние кнопки Сохранить
            btnSave.Enabled = quiz.Questions.Count == quiz.questionLimit;

            // Обновляем Label с прогрессом
            lbControl.Text = $"{quiz.Questions.Count}/{quiz.questionLimit}";

        }


        private void btAddQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtQuestionTxt.Text == string.Empty)
                {
                    throw new ArgumentException("Введите название вопроса");
                }
                var q = new Question(txtQuestionTxt.Text, new List<string> { "Вариант 1", "Вариант 2", "Вариант 3", "Вариант 4" }, 0);
                quiz.AddQuestion(q);
                RefreshQuestions();
                listBoxQuestions.SelectedItem = q; // сразу выделяем новый вопрос
                txtQuestionTxt.Text = string.Empty;

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
            if (listBoxQuestions.SelectedItem is Question q)
            {
                q.Text = txtQuestionTxt.Text;
                RefreshQuestions();
                listBoxQuestions.SelectedItem = q;
            }
        }

        private void btnDeleteAnswer_Click(object sender, EventArgs e)
        {
            if (checkedListAnswers.SelectedIndex >= 0 && listBoxQuestions.SelectedItem is Question q)
            {
                int idx = checkedListAnswers.SelectedIndex;
                checkedListAnswers.Items.RemoveAt(idx);
                q.Answers.RemoveAt(idx);

                // Если был выбран этот вариант как правильный — убираем
                q.CorrectIndexes.Remove(idx);

                // Исправляем индексы правильных ответов, если они выше удалённого
                for (int i = 0; i < q.CorrectIndexes.Count; i++)
                {
                    if (q.CorrectIndexes[i] > idx)
                        q.CorrectIndexes[i]--;
                }
            }
        }

        private void btnAddAnswer_Click(object sender, EventArgs e)
        {
            string newAnswer = Microsoft.VisualBasic.Interaction.InputBox(
             "Введите новый вариант ответа:", "Добавить ответ", "Новый вариант");

            if (!string.IsNullOrWhiteSpace(newAnswer))
            {
                checkedListAnswers.Items.Add(newAnswer);

                // Если есть выбранный вопрос — добавляем в его список ответов
                if (listBoxQuestions.SelectedItem is Question q)
                    q.Answers.Add(newAnswer);
            }
        }

        private void btnChangeAnswer_Click(object sender, EventArgs e)
        {
            if (checkedListAnswers.SelectedIndex >= 0 && listBoxQuestions.SelectedItem is Question q)
            {
                string? currentAnswer = checkedListAnswers.SelectedItem?.ToString();
                string newAnswer = Microsoft.VisualBasic.Interaction.InputBox(
                    "Измените вариант ответа:", "Изменить ответ", currentAnswer ?? string.Empty);

                if (!string.IsNullOrWhiteSpace(newAnswer))
                {
                    int idx = checkedListAnswers.SelectedIndex;
                    checkedListAnswers.Items[idx] = newAnswer;
                    q.Answers[idx] = newAnswer;
                }
            }
        }

        private void btCansel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


        private void checkedListAnswers_ItemCheck(object sender, ItemCheckEventArgs e)
        {
            if (listBoxQuestions.SelectedItem is Question q)
            {
                if (e.NewValue == CheckState.Checked)
                {
                    if (!q.CorrectIndexes.Contains(e.Index))
                        q.CorrectIndexes.Add(e.Index);
                }
                else
                {
                    q.CorrectIndexes.Remove(e.Index);
                }
            }
        }

        private void btnSaveQuestion_Click(object sender, EventArgs e)
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

        private void btSave_Click(object sender, EventArgs e)
        {
            quiz.Title = txtName.Text;
            quiz.Description = txtDescription.Text;
            quiz.Category = txtCategory.Text;
            this.DialogResult = DialogResult.OK; // говорим, что всё прошло успешно
            this.Close(); // закрываем форму
        }
    }
}
