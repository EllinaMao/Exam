using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    public class QuizResultService
    {
        private List<QuizResult> results = new();

        public void AddResult(string login , QuizResult result) =>
            results.Add(result);

        public List<QuizResult> GetResultsByUser(string login) =>
            results.Where(r => r.UserLogin == login).ToList();

        public List<QuizResult> GetTopResults(string quizTitle , int top = 20) =>
            results
                .Where(r => r.QuizTitle == quizTitle)
                .OrderByDescending(r => r.Score)
                .Take(top)
                .ToList();
    }
}
