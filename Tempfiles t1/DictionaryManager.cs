using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 *  Создать приложение «Словари».
 *  Основная задача проекта: хранить словари на разных языках и разрешать пользователю находить перевод нужного слова или фразы.
 *  Интерфейс приложения должен предоставлять такие возможности:
 *  ■ Создавать словарь. При создании нужно указать тип словаря.Например, англо-русский или русско-английский.
 *  ■ Добавлять слово и его перевод в уже существующий словарь. Так как у слова может быть несколько переводов, необходимо поддерживать возможность создания нескольких вариантов перевода.
 *  ■ Заменять слово или его перевод в словаре.
 *  ■ Удалять слово или перевод. Если удаляется слово, все его переводы удаляются вместе с ним. Нельзя удалить перевод слова, если это последний вариант перевода.
 *  ■ Искать перевод слова.
 *  ■ Словари должны храниться в файлах.
 *  ■ Слово и варианты его переводов можно экспортировать в отдельный файл результата.
 *  
 *  ■ При старте программы необходимо показывать меню для работы с программой.
 *  Если выбор пункта меню открывает подменю, то тогда в нем требуется предусмотреть возможность возврата в предыдущее меню.*/
namespace ProjectLogic
{
    public static class DictionaryManager
    {//■ Добавлять слово и его перевод в уже существующий словарь.
        public static void AddWord(this LanguageDictionary dictionary, string word, List<string> translations)
        {
            if (dictionary.Words.ContainsKey(word)) {
                throw new ArgumentException("Слово уже существует в словаре.");
            }
            if (translations == null || translations.Count == 0) {
                throw new ArgumentException("Переводы не могут быть пустыми.");
            }
            var entry = new DictionaryEntry { Translations = translations };
            dictionary.Words.Add(word, entry);
        }
        // ■ Заменять слово или его перевод в словаре.
        public static void AddTranslation(this LanguageDictionary dictionary, string word, string translation)
        {
            if (!dictionary.Words.TryGetValue(word, out var entry)) {
                throw new ArgumentException("Слово не найдено в словаре.");
            }
            if (!entry.Translations.Contains(translation)) {
                entry.Translations.Add(translation);
            }
        }
        public static List<string> GetTranslations(this LanguageDictionary dictionary, string word)
        {
            var entry = dictionary.Words.TryGetValue(word , out DictionaryEntry? value) ? value : null;
            if (entry == null) {
                throw new ArgumentException("Слово не найдено в словаре.");
            }
            return entry.Translations;
        }
        //■ Искать перевод слова.
        public static List<string>? FindTranslation(this LanguageDictionary dictionary, string word)
        {
            return dictionary.Words.TryGetValue(word, out var entry) ? entry.Translations : null;
        }

        // Заменить слово в словаре
        public static void ReplaceWord(this LanguageDictionary dict , string oldWord , string newWord)
        {
            if (!dict.Words.TryGetValue(oldWord , out var entry))
            {
                throw new ArgumentException("Слово не найдено в словаре.");
            }
            if (dict.Words.ContainsKey(newWord))
            {
                throw new ArgumentException("Новое слово уже существует в словаре.");
            }
            dict.Words.Remove(oldWord);
            dict.Words.Add(newWord, entry);
        }

        // Заменить перевод слова
        public static void ReplaceTranslation(this LanguageDictionary dict , string word , string oldTrans , string newTrans)
        {
            if (!dict.Words.TryGetValue(word , out var entry))
            {
                throw new ArgumentException("Слово не найдено в словаре.");
            }
            int index = entry.Translations.IndexOf(oldTrans);
            if (index == -1)
            {
                throw new ArgumentException("Перевод не найден.");
            }
            entry.Translations[index] = newTrans;
        }
        // Удалить слово и все его переводы
        public static void DeleteWord(this LanguageDictionary dictionary , string word)
        {
            dictionary.Words.Remove(word);
        }
        // Удалить перевод слова (если не последний)
        public static void DeleteTranslation(this LanguageDictionary dictionary , string word , string translation)
        {
            if (!dictionary.Words.TryGetValue(word , out var entry))
            {
                throw new ArgumentException("Слово не найдено в словаре.");
            }
            if (entry.Translations.Count <= 1)
            {
                throw new InvalidOperationException("Нельзя удалить последний перевод слова.");
            }
            if (!entry.Translations.Remove(translation))
            {
                throw new ArgumentException("Перевод не найден.");
            }
        }

        

    }
}
