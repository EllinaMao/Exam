using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tempfiles_t1
{
    public static class DictionaryManager
    {
        public static void AddWord(this LanguageDictionary dictionary, string word, List<string> translations)
        {
            dictionary.Entries.Add(new DictionaryEntry { Word = word, Translations = translations });
        }
        public static void ReplaceWord(this LanguageDictionary dict, string oldWord, string newWord)
        {
            var change = dict.Entries.FirstOrDefault(e => e.Word == oldWord);
            if (change != null) { change.Word = newWord; }
        }

        public static void ReplaceTranslation(this LanguageDictionary dict, string word, string oldTrans, string newTrans)
        {
            var change = dict.Entries.FirstOrDefault(c => c.Word == oldTrans);
            if (change == null) {
                throw new ArgumentException("This word not in list");
            }
            int index = change.Translations.IndexOf(oldTrans);
            if (index <= -1|| index > change.Translations.Count)
            {
                throw new ArgumentException("index out of range");
            }
            change.Translations[index] = newTrans;
        }
        public static void DeleteWord(this LanguageDictionary dictionary, string word)
        {
            dictionary.Entries.RemoveAll(e => e.Word == word);
        }

    }
}
