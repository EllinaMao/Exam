using System;
using System.Collections.Generic;

namespace Tempfiles_t1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Создаём репозиторий словарей
            var repository = new DictionaryRepository();

            // Создаём новый словарь (например, англо-русский)
            var engRusDict = new LanguageDictionary("Англо-русский");

            // Добавляем слово и его переводы
            engRusDict.AddWord("cat", new List<string> { "кот", "кошка" });
            engRusDict.AddWord("dog", new List<string> { "собака" });

            // Добавляем словарь в репозиторий
            repository.AddDictionary(engRusDict);

            // Сохраняем репозиторий в файл
            string filePath = "dictionaries.json";
            DictionaryStorage.Save(repository, filePath);

            Console.WriteLine($"Словари успешно сохранены в файл: {filePath}");ни 
        }
    }
}
