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
        public string Title { get; }
        [JsonPropertyName("Описание")]
        public string Description { get; }
        [JsonPropertyName("Категория")]
        public string Category { get; }
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

    }
}
