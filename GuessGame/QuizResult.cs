using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuessGame
{
    public class QuizResult
    {
        public string UserLogin { get; set; }   // кто проходил
        public string QuizTitle { get; set; }
        public int Score { get; set; }
        public DateTime Date { get; set; }
    }
}
