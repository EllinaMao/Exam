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
        public static void Save(LanguageDictionary dict, string filePath)
        {
            string json = JsonSerializer.Serialize(dict, new JsonSerializerOptions
            {
                WriteIndented = true,
            //Encoder = JavaScriptEncoder.UnsafeRelaxedJsonEscaping
            });
            File.WriteAllText(filePath, json);
        }

        public static LanguageDictionary Load(string filePath)
        {
            string json = File.ReadAllText(filePath);
            var result = JsonSerializer.Deserialize<LanguageDictionary>(json);
            if (result == null) { 
                throw new InvalidOperationException("Deserialization returned null.");
            }
            return result;
        }
    }
}
