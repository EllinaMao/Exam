using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GuessGame
{
    public class QuizResultService
    {
        private List<QuizResult> results = new();
        public static string QuizzesFolder => Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Results");
        public void AddResult(string login , QuizResult result) =>
            results.Add(result);

        public List<QuizResult> GetResultsByUser(string login) =>
            results.Where(r => r.UserLogin == login).ToList();

        public int GetPlace(string login, QuizResult result)
        {
            var top = results
                .Where(r => r.QuizTitle == result.QuizTitle)
                .OrderByDescending(r => r.Score)
                .ThenBy(r => r.Date)
                .ToList();

            return top.FindIndex(r => r.UserLogin == login && r.Date == result.Date) + 1;
        }


        public List<QuizResult> GetTopResults(string quizTitle , int top = 20) =>
            results
                .Where(r => r.QuizTitle == quizTitle)
                .OrderByDescending(r => r.Score)
                .Take(top)
                .ToList();

        //сохранение
        public void SaveToFile(string filePath)
        {
            var json = JsonSerializer.Serialize(results, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        // Загрузка из файла
        public void LoadFromFile(string filePath)
        {
            // Создаём папку, если её нет
            var folder = Path.GetDirectoryName(filePath);
            if (!Directory.Exists(folder))
                Directory.CreateDirectory(folder);

            // Если файла нет — просто создаём пустой список
            if (!File.Exists(filePath))
            {
                results = new List<QuizResult>();
                SaveToFile(filePath); // чтобы файл появился
                return;
            }

            var json = File.ReadAllText(filePath);
            var loadedResults = JsonSerializer.Deserialize<List<QuizResult>>(json);
            if (loadedResults != null)
                results = loadedResults;
        }

    }
}
