using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Tempfiles_t1
{
    public class DictionaryRepository//список словарей
    {
        [JsonPropertyName("Словари")]
        List<LanguageDictionary> dictionaries = new List<LanguageDictionary>();

        public void AddDictionary(LanguageDictionary dict)
        {

        }
    }
}
