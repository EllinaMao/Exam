using System.Text.Encodings.Web;
using System.Text.Json;

namespace ProjectLogic
{

    public static class DictionaryStorage
    {
        // *  ■ Словари должны храниться в файлах.
        public static void Save(this LanguageDictionary dict , string filePath)
        {
            var Filepath = Path.Combine("Savefiles", filePath);
            string json = JsonSerializer.Serialize(dict, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            }); 
            var directory = Path.GetDirectoryName(Filepath);
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory!);
            }
            File.WriteAllText(Filepath, json);
        }

        public static LanguageDictionary Load(string filePath)
        {
            string fullPath = Path.Combine("Savefiles", filePath);
            if (!File.Exists(fullPath))
            {
                throw new FileNotFoundException($"File not found: ");
            }
            string json = File.ReadAllText(fullPath);

            var result = JsonSerializer.Deserialize<LanguageDictionary>(json);
            if (result == null)
            {
                throw new InvalidOperationException("Deserialization returned null.");
            }
            return result;
        }
 //  ■ Слово и варианты его переводов можно экспортировать в отдельный файл результата.
        public static void ExportWordToFile(LanguageDictionary dict, string word, string filePath)
        {
            var FilePath = Path.Combine("Translations", filePath);
            var entry = dict.Words.TryGetValue(word, out DictionaryEntry? value) ? value : null;
            if (entry == null)
            {
                throw new ArgumentException("Слово не найдено в словаре.");
            }
            string json = JsonSerializer.Serialize(entry, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping

            });

            File.WriteAllText(FilePath, json);
        }
    }
}
