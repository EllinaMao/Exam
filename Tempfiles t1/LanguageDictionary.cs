using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempfiles_t1
{
    public class LanguageDictionary
    {
        public required string Name { get; set; } // English-Russian, German -English, etc.
        public List<DictionaryEntry> Entries { get; set; } = new();// List of dictionary entries

        public LanguageDictionary(string name)
        {
            Name = name;
        }
    }
}
