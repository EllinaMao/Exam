using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempfiles_t1
{
    public class LanguageDictionary
    {
        public string Name { get; set; } // Например: "Англо-Русский"
        public List<DictionaryEntry> Entries { get; set; } = new();
    }
}
