using System;
using System.Collections.Generic;
using System.IO;

namespace ProjectLogic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var engRusDict = new LanguageDictionary("Англо-русский");

            // Массив пар: английское слово и список переводов
            var words = new (string, List<string>)[]
            {
                ("cat", new List<string> { "кот", "кошка" }),
                ("dog", new List<string> { "собака" }),
                ("house", new List<string> { "дом" }),
                ("car", new List<string> { "машина", "автомобиль" }),
                ("tree", new List<string> { "дерево" }),
                ("book", new List<string> { "книга" }),
                ("water", new List<string> { "вода" }),
                ("sun", new List<string> { "солнце" }),
                ("moon", new List<string> { "луна" }),
                ("star", new List<string> { "звезда" }),
                ("table", new List<string> { "стол" }),
                ("chair", new List<string> { "стул" }),
                ("window", new List<string> { "окно" }),
                ("door", new List<string> { "дверь" }),
                ("pen", new List<string> { "ручка" }),
                ("pencil", new List<string> { "карандаш" }),
                ("paper", new List<string> { "бумага" }),
                ("phone", new List<string> { "телефон" }),
                ("computer", new List<string> { "компьютер" }),
                ("mouse", new List<string> { "мышь" }),
                ("keyboard", new List<string> { "клавиатура" }),
                ("screen", new List<string> { "экран" }),
                ("lamp", new List<string> { "лампа" }),
                ("bed", new List<string> { "кровать" }),
                ("pillow", new List<string> { "подушка" }),
                ("blanket", new List<string> { "одеяло" }),
                ("shirt", new List<string> { "рубашка" }),
                ("pants", new List<string> { "брюки", "штаны" }),
                ("shoes", new List<string> { "обувь", "ботинки" }),
                ("sock", new List<string> { "носок" }),
                ("hat", new List<string> { "шляпа", "кепка" }),
                ("coat", new List<string> { "пальто" }),
                ("dress", new List<string> { "платье" }),
                ("skirt", new List<string> { "юбка" }),
                ("glove", new List<string> { "перчатка" }),
                ("scarf", new List<string> { "шарф" }),
                ("bag", new List<string> { "сумка" }),
                ("wallet", new List<string> { "кошелёк" }),
                ("money", new List<string> { "деньги" }),
                ("ticket", new List<string> { "билет" }),
                ("train", new List<string> { "поезд" }),
                ("bus", new List<string> { "автобус" }),
                ("plane", new List<string> { "самолёт" }),
                ("ship", new List<string> { "корабль" }),
                ("bicycle", new List<string> { "велосипед" }),
                ("road", new List<string> { "дорога" }),
                ("street", new List<string> { "улица" }),
                ("city", new List<string> { "город" }),
                ("village", new List<string> { "деревня" }),
                ("country", new List<string> { "страна" }),
                ("river", new List<string> { "река" }),
                ("lake", new List<string> { "озеро" }),
                ("sea", new List<string> { "море" }),
                ("ocean", new List<string> { "океан" }),
                ("mountain", new List<string> { "гора" }),
                ("forest", new List<string> { "лес" }),
                ("field", new List<string> { "поле" }),
                ("flower", new List<string> { "цветок" }),
                ("grass", new List<string> { "трава" }),
                ("fruit", new List<string> { "фрукт" }),
                ("apple", new List<string> { "яблоко" }),
                ("banana", new List<string> { "банан" }),
                ("orange", new List<string> { "апельсин" }),
                ("lemon", new List<string> { "лимон" }),
                ("grape", new List<string> { "виноград" }),
                ("peach", new List<string> { "персик" }),
                ("pear", new List<string> { "груша" }),
                ("cherry", new List<string> { "вишня" }),
                ("strawberry", new List<string> { "клубника" }),
                ("melon", new List<string> { "дыня" }),
                ("watermelon", new List<string> { "арбуз" }),
                ("potato", new List<string> { "картофель" }),
                ("carrot", new List<string> { "морковь" }),
                ("onion", new List<string> { "лук" }),
                ("garlic", new List<string> { "чеснок" }),
                ("tomato", new List<string> { "помидор" }),
                ("cucumber", new List<string> { "огурец" }),
                ("pepper", new List<string> { "перец" }),
                ("salt", new List<string> { "соль" }),
                ("sugar", new List<string> { "сахар" }),
                ("bread", new List<string> { "хлеб" }),
                ("butter", new List<string> { "масло" }),
                ("cheese", new List<string> { "сыр" }),
                ("egg", new List<string> { "яйцо" }),
                ("milk", new List<string> { "молоко" }),
                ("meat", new List<string> { "мясо" }),
                ("fish", new List<string> { "рыба" }),
                ("chicken", new List<string> { "курица" }),
                ("soup", new List<string> { "суп" }),
                ("tea", new List<string> { "чай" }),
                ("coffee", new List<string> { "кофе" }),
                ("juice", new List<string> { "сок" }),
                ("cake", new List<string> { "торт" }),
                ("cookie", new List<string> { "печенье" }),
                ("ice cream", new List<string> { "мороженое" }),
                ("honey", new List<string> { "мёд" }),
                ("jam", new List<string> { "варенье" }),
                ("salt", new List<string> { "соль" }),
                ("pepper", new List<string> { "перец" }),
                ("oil", new List<string> { "масло" }),
                ("rice", new List<string> { "рис" }),
                ("noodle", new List<string> { "лапша" }),
                ("bread", new List<string> { "хлеб" }),
            };

            // Добавляем все слова в англо-русский словарь
            foreach (var (word, translations) in words)
            {
                if (!engRusDict.Words.ContainsKey(word))
                    DictionaryManager.AddWord(engRusDict, word, translations);
            }

            // Создаём русско-английский словарь
            var rusEngDict = new LanguageDictionary("Русско-английский");

            // Заполняем русско-английский словарь на основе англо-русского
            foreach (var (eng, rusList) in words)
            {
                foreach (var rus in rusList)
                {
                    if (!rusEngDict.Words.ContainsKey(rus))
                        rusEngDict.Words[rus] = new DictionaryEntry { Translations = new List<string>() };
                    if (!rusEngDict.Words[rus].Translations.Contains(eng))
                        rusEngDict.Words[rus].Translations.Add(eng);
                }
            }


            string filePath = "russ-eng.json";
            string filePath2 = "eng-russ.json";
            DictionaryStorage.Save(rusEngDict, filePath);
            DictionaryStorage.Save(engRusDict, filePath2);



        }
    }
}
