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
        List<Question> Questions { get; }
    }
}
