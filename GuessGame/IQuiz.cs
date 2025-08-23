using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace GuessGame
{
    public interface IQuiz
    {
        string Title { get; }
        string Description { get; }
        string Category { get; }
        Dictionary<string , List<string>> GetQuestions();
    }
}
