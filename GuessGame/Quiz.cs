using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GuessGame
{
    public class Quiz : IQuiz
    {
        [JsonPropertyName("Название")]
        public string Title { get; set; }
        [JsonPropertyName("Описание")]
        public string Description { get; set; }
        [JsonPropertyName("Категория")]
        public string Category { get; set; }
        [JsonPropertyName("Вопросы и варианты ответов")]
        public List<Question> Questions { get; set; }

        public int questionLimit { get; } = 20;
        public Quiz()
        {
            Title = string.Empty;
            Description = string.Empty;
            Category = string.Empty;
            Questions = new List<Question>();
        }
        [JsonConstructor]
        public Quiz(string title, string description, string category, List<Question> questions)
        {
            Title = title;
            Description = description;
            Category = category;
            Questions = questions;
        }

        public void AddQuestion(Question q)
        {
            if (Questions.Count == questionLimit)
            {
                throw new InvalidOperationException($"Нельзя добавить больше {questionLimit} вопросов");
            }
            if(q == null)
            {
                throw new ArgumentNullException(nameof(q), "Вопрос не может быть null");
            }
            if (string.IsNullOrWhiteSpace(q.Text))
            {
                throw new ArgumentException("Текст вопроса не может быть пустым или состоять только из пробелов", nameof(q));
            }
            if (q.Answers == null || q.Answers.Count < 4)
            {
                throw new ArgumentException("Вопрос должен содержать четыре варианта ответа", nameof(q));
            }
            if (q.CorrectIndexes == null || q.CorrectIndexes.Count == 0 || q.CorrectIndexes.Any(i => i < 0 || i >= q.Answers.Count))
            {
                throw new ArgumentException("Вопрос должен содержать хотя бы один правильный ответ, и индексы правильных ответов должны быть в пределах количества вариантов ответа", nameof(q));
            }
            if (Questions.Any(existingQ => existingQ.Text.Equals(q.Text, StringComparison.OrdinalIgnoreCase)))
            {
                throw new InvalidOperationException("Вопрос с таким текстом уже существует в викторине");
            }
            Questions.Add(q);
        }


        public void EditQuestion(int index, Question newQuestion)
        {
            if (index >= 0 && index < Questions.Count)
                Questions[index] = newQuestion;
        }

        public void MoveQuestion(int oldIndex, int newIndex)
        {
            if (oldIndex >= 0 && oldIndex < Questions.Count &&
                newIndex >= 0 && newIndex < Questions.Count)
            {
                var q = Questions[oldIndex];
                Questions.RemoveAt(oldIndex);
                Questions.Insert(newIndex, q);
            }
        }






    }
}
