using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace GuessGame
{
    public static class QuizStorage
    {
        public static void SaveToFile(this Quiz quiz, string filePath)
        {
            var json = JsonSerializer.Serialize(quiz, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(filePath, json);
        }

        public static Quiz LoadFromFile(string filePath)
        {
            var json = File.ReadAllText(filePath);
            return JsonSerializer.Deserialize<Quiz>(json)!;
        }
    }
}
