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

        public void AddQuestion(Question q) => Questions.Add(q);

        public void RemoveQuestion(int index)
        {
            if (index >= 0 && index < Questions.Count)
                Questions.RemoveAt(index);
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
