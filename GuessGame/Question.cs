using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace GuessGame
{
    public class Question
    {
        [JsonPropertyName("Текст вопроса")]
        public string Text { get; set; }

        [JsonPropertyName("Варианты ответов")]
        public List<string> Answers { get; set; }

        [JsonPropertyName("Номера правильных ответов")]
        public List<int> CorrectIndexes { get; set; }  //правильные ответы

        public Question()
        {
            Text = string.Empty;
            Answers = new List<string>();
            CorrectIndexes = new List<int>();
        }
        // Конструктор для нескольких правильных ответов
        public Question(string text, List<string> answers, List<int> correctIndexes)
        {
            Text = text;
            Answers = answers;
            CorrectIndexes = correctIndexes;
        }

        // Конструктор для одного правильного ответа
        public Question(string text, List<string> answers, int correctIndex)
        {
            Text = text;
            Answers = answers;
            CorrectIndexes = new List<int> { correctIndex };
        }

        // Проверка: выбранные ответы совпадают со всеми правильными
        public bool IsCorrect(List<int> selectedIndexes)
        {
            // Сравниваем множества: количество выбранных совпадает с количеством правильных
            return selectedIndexes.Count == CorrectIndexes.Count &&
                   !CorrectIndexes.Except(selectedIndexes).Any();
        }
        // Метод Except из LINQ берёт первую коллекцию и убирает из неё все элементы, которые есть во второй коллекции.
        //Метод Any() проверяет, есть ли в коллекции хотя бы один элемент.
        //если список пустой - значит пользователь ответил правильно. Если Count больше чем количество правильных вариантов - значит пользователь выбрал лишние ответы


    }
}
