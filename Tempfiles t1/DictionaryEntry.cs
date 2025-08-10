using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempfiles_t1
{
    public class DictionaryEntry
    {
        // Represents a single entry in the dictionary with a word and its translations.
        public string Word { get; set; } = "";
        public List<string> Translations { get; set; } = new();

    }
}
