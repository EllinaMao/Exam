using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace GuessGame
{
    public static class QuizFactory
    {
        private static readonly Dictionary<string , Type> quizTypes;

        static QuizFactory()
        {
            //Берем все типы (классы, интерфейсы, структуры) из сборки, в которой сейчас выполняется код
            quizTypes = Assembly.GetExecutingAssembly()
                .GetTypes()//Фильтрует только те типы, которые:не являются интерфейсом и не абстрактный класс
                .Where(t => typeof(IQuiz).IsAssignableFrom(t) && !t.IsInterface && !t.IsAbstract)//
                .Select(t => (IQuiz)Activator.CreateInstance(t)!)
                .ToDictionary(q => q.Title, q => q.GetType(), StringComparer.OrdinalIgnoreCase);
        }
        public static IQuiz CreateQuiz(string quizType)
        {
            if (quizTypes.TryGetValue(quizType, out var type))
                return (IQuiz)Activator.CreateInstance(type)!;

            throw new ArgumentException($"Викторина '{quizType}' не найдена.");
        }

        public static IEnumerable<string> GetAvailableQuizzes() => quizTypes.Keys;
    }
}
