using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    public class Quiz:IQuiz
    {
        public string Title { get; set; }
        public string Description => "A quiz to test your math skills.";
        public string Category => "Mathematics";
        public Dictionary<string, List<string>>? Questions { get; set; }

        public Dictionary<string , List<string>>? GetQuestions() =>
            Questions?.ToDictionary(
                entry => entry.Key ,
                entry => new List<string>(entry.Value)
            );

    }
}
