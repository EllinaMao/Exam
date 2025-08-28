using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GuessGame
{
    public static class QuizManager
    {
        public static List<Quiz> AllQuizzes { get; private set; } = new List<Quiz>();

        public static void AddQuiz(Quiz quiz)
        {
            if (quiz.Questions.Count != 20)
                throw new InvalidOperationException("Викторина должна содержать ровно 20 вопросов.");
            AllQuizzes.Add(quiz);
        }

        public static void LoadAllFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                throw new FileNotFoundException("Файл викторин не найден", filePath);

            var json = File.ReadAllText(filePath);
            var quizzes = JsonSerializer.Deserialize<List<Quiz>>(json);

            AllQuizzes.Clear();
            if (quizzes != null)
                AllQuizzes.AddRange(quizzes);
        }

        public static void SaveAllToDifferentFolder(string folderPath)
        {
            foreach (var quiz in AllQuizzes)
            {
                var filePath = Path.Combine(folderPath, quiz.Title + ".json");
                QuizStorage.SaveToFile(quiz, filePath);
            }
        }

        public static void SaveAllToFile(string filePath)
        {
            var json = JsonSerializer.Serialize(AllQuizzes, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }


    }
}