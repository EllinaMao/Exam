using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GuessGame
{//он статический что бы быть в единственном экземляре
    public static class QuizManager
    {
        public static List<Quiz> AllQuizzes { get; private set; } = new List<Quiz>();

        // Папка для хранения викторин
        public static string QuizzesFolder => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Quizzes");

        public static void AddQuiz(Quiz quiz)
        {
            AllQuizzes.Add(quiz);
        }
        public static void DeleteQuiz(Quiz quiz)
        {
            AllQuizzes.Remove(quiz);
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