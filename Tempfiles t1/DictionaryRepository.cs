using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ProjectLogic
{
    public class DictionaryRepository//список словарей
    {
        [JsonPropertyName("Словари")]
        public List<LanguageDictionary> dictionaries { get; set; } = new List<LanguageDictionary>();

        public void AddDictionary(LanguageDictionary dict)
        {
            dictionaries.Add(dict);
        }
    }
}
