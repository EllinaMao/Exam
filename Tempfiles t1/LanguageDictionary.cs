using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectLogic
{
    public class LanguageDictionary//тут хранятся сами словари
    {
        public string Name { get; set; } // English-Russian, German -English, etc.
        [JsonPropertyName("Слова")]
        public Dictionary<string, DictionaryEntry> Words { get; set; } 
        public LanguageDictionary(string name)
        {
            Name = name;
            Words = new Dictionary<string, DictionaryEntry>();
        }

        public void AddWord(string word, List<string> translations)
        {
            Words[word] = new DictionaryEntry { Translations = translations };
        }
    }
}
