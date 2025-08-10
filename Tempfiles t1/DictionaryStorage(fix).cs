using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Encodings.Web;
using System.Text.Json;
using System.Threading.Tasks;

namespace Tempfiles_t1
{

    public static class DictionaryStorage
    {
        // *  ■ Словари должны храниться в файлах.
        public static void Save(this DictionaryRepository dict , string filePath)
        {
            string json = JsonSerializer.Serialize(dict, new JsonSerializerOptions
            {
                WriteIndented = true,
                Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
            File.WriteAllText(filePath, json);
        }

        public static DictionaryRepository Load(string filePath)
        {
            string json = File.ReadAllText(filePath);
            var result = JsonSerializer.Deserialize<DictionaryRepository>(json);
            if (result == null) { 
                throw new InvalidOperationException("Deserialization returned null.");
            }
            return result;
        }
 //  ■ Слово и варианты его переводов можно экспортировать в отдельный файл результата.
        public static void ExportWordToFile(LanguageDictionary dict, string word, string filePath)
        {
            var entry = dict.Words.TryGetValue(word, out DictionaryEntry? value) ? value : null;
            if (entry == null)
            {
                throw new ArgumentException("Слово не найдено в словаре.");
            }
            string json = JsonSerializer.Serialize(entry, new JsonSerializerOptions
            {
                WriteIndented = true,
            });
            File.WriteAllText(filePath, json);
        }
    }
}
