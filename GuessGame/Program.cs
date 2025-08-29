using System;
using System.Collections.Generic;

namespace GuessGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Создаем викторины по категориям
            var mathQuiz = new Quiz(
                "Математика",
                "Викторина по математике",
                "Математика",
                new List<Question>
                {
                    new Question("2 + 2 = ?", new List<string>{"3","4","5"}, new List<int>{1}),
                    new Question("Выберите чётные числа", new List<string>{"1","2","3","4"}, new List<int>{1,3}),
                    new Question("12 / 4 = ?", new List<string>{"3","4","6"}, new List<int>{0}),
                    new Question("7 - 5 = ?", new List<string>{"2","3","1"}, new List<int>{0}),
                    new Question("Выберите простые числа", new List<string>{"3","5","6","7"}, new List<int>{1,3})
                });

            var biologyQuiz = new Quiz(
                "Биология",
                "Викторина по биологии",
                "Биология",
                new List<Question>
                {
                    new Question("Основная молекула хранения генетической информации?", new List<string>{"ДНК","РНК","Белок"}, new List<int>{0}),
                    new Question("Выберите органы дыхательной системы человека", new List<string>{"Лёгкие","Сердце","Нос"}, new List<int>{0,2}),
                    new Question("Какая клетка отвечает за фотосинтез?", new List<string>{"Растительная","Животная","Бактериальная"}, new List<int>{0}),
                    new Question("Число хромосом у человека?", new List<string>{"46","23","44"}, new List<int>{0}),
                    new Question("Какая ткань соединяет кости?", new List<string>{"Хрящ","Мышечная","Эпителиальная"}, new List<int>{0})
                });

            var chemistryQuiz = new Quiz(
                "Химия",
                "Викторина по химии",
                "Химия",
                new List<Question>
                {
                    new Question("Символ водорода?", new List<string>{"H","O","He"}, new List<int>{0}),
                    new Question("Выберите кислоты", new List<string>{"HCl","NaOH","H2SO4"}, new List<int>{0,2}),
                    new Question("Молекула воды состоит из?", new List<string>{"H2O","CO2","O2"}, new List<int>{0}),
                    new Question("pH нейтральной среды ≈ ?", new List<string>{"7","0","14"}, new List<int>{0}),
                    new Question("Элемент с атомным номером 6?", new List<string>{"Углерод","Азот","Кислород"}, new List<int>{0})
                });

            var lolQuiz = new Quiz(
                "League of Legends",
                "Викторина по Лиге Легенд",
                "Игры",
                new List<Question>
                {
                    new Question("У какого чемпиона настоящее имя — Сара?",
                                 new List<string>{"Самира", "Нила", "Мисс Фортуна", "Рек`сай"}, new List<int>{2}),
                    new Question("Кто из перечисленных чемпионов является вастаи", new List<string>{"Сивир","Ари", "Шая"}, new List<int>{1,2}),
                    new Question("Кто создал Блицкранка?",
                                 new List<string>{"Виктор", "Джейс", "Хеймердингер"}, new List<int>{0}),
                    new Question("Какой чемпион из перечисленных ниже имеет самое неопределенное происхождение в Лиге?" ,
                                 new List<string>{ "Джакс", "Бард", "Шако"}, new List<int>{2}),
                    new Question("Кто же они, изначальные демоны страха и радости?",
                                 new List<string>{ "Ноктюрн и Шако", "Фиддлстикс и Шако", "Ноктюрн и Эшлеш", "Фиддлстикс и Эшлеш"}, new List<int>{3})
                });


            // 2. Добавляем викторины в менеджер
            QuizManager.AddQuiz(mathQuiz);
            QuizManager.AddQuiz(biologyQuiz);
            QuizManager.AddQuiz(chemistryQuiz);
            QuizManager.AddQuiz(lolQuiz);

            // 3. Сохраняем все викторины в один файл
            string filePath = "allQuizzes.json";
            QuizManager.SaveAllToFile(filePath);

            // 4. Загружаем все викторины обратно (для примера)
            QuizManager.LoadAllFromFile(filePath);

            // 5. Выводим все викторины и их вопросы
            foreach (var quiz in QuizManager.AllQuizzes)
            {
                Console.WriteLine($"Викторина: {quiz.Title} ({quiz.Category})");
                foreach (var q in quiz.Questions)
                {
                    Console.WriteLine($"  Вопрос: {q.Text}");
                    for (int i = 0; i < q.Answers.Count; i++)
                    {
                        Console.WriteLine($"    {i + 1}. {q.Answers[i]}");
                    }
                    for (int i = 0; i < q.CorrectIndexes.Count; i++)
                    {
                        int correctIdx = q.CorrectIndexes[i];
                        Console.WriteLine($"    Правильный ответ: {q.Answers[correctIdx]}");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
