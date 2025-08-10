using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Tempfiles_t1
{
    public class LanguageDictionary//тут хранятся сами словари
    {
        public required string Name { get; set; } // English-Russian, German -English, etc.
        [JsonPropertyName("Слова")]
        public required Dictionary<string, DictionaryEntry> Words { get; set; } = new Dictionary<string, DictionaryEntry>();
        public LanguageDictionary(string name)
        {
            Name = name;
            Words = new Dictionary<string, DictionaryEntry>();
        }
    }
}
