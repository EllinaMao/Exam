using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Transactions;

namespace ProjectLogic
{
    public class DictionaryEntry
    {
        // список с переводами слова.
        [JsonPropertyName("Перевод")]
        public List<string> Translations { get; set; } = new List<string>();
    }
}
 