using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GuessGame
{
    public static class QuizResultService
    {
        private static List<QuizResult> results = new();
        public static string QuizzesFolder
        {
            get
            {
                var folder = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Results");
                if (!Directory.Exists(folder))
                    Directory.CreateDirectory(folder);
                return folder;
            }
        }
        public static string FilePath => Path.Combine(QuizzesFolder, "AllResults.json");

        public static void AddResult(string login , QuizResult result) =>
            results.Add(result);

        public static List<QuizResult> GetResultsByUser(string login) =>
            results.Where(r => r.UserLogin == login).ToList();

        public static int GetPlace(string login, QuizResult result)
        {
            var top = results
                .Where(r => r.QuizTitle == result.QuizTitle)
                .OrderByDescending(r => r.Score)
                .ThenBy(r => r.Date)
                .ToList();

            return top.FindIndex(r => r.UserLogin == login && r.Date == result.Date) + 1;
        }


        public static List<QuizResult> GetTopResults(string quizTitle , int top = 20) =>
            results
                .Where(r => r.QuizTitle == quizTitle)
                .OrderByDescending(r => r.Score)
                .Take(top)
                .ToList();

        //сохранение
        public static void SaveToFile(string filePath)
        {
            var json = JsonSerializer.Serialize(results, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        // Загрузка из файла. Я оставила путь потому что функция уже используется и я не хочу ее переписывать
        public static void LoadFromFile(string filePath)
        {
            if (!File.Exists(FilePath))
            {
                results = new List<QuizResult>();
                SaveToFile(filePath);
                return;
            }

            var json = File.ReadAllText(filePath);
            var loadedResults = JsonSerializer.Deserialize<List<QuizResult>>(json);
            if (loadedResults != null)
                results = loadedResults;
        }

    }
}
