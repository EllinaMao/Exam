using GuessGame;
using login_logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizFoms
{
    public partial class ResultsForm : Form
    {
        User ThisUser {  get; set; }
        public ResultsForm(User user)
        {
            InitializeComponent();
            ThisUser = user;

            LoadUserResults();

        }
        private void LoadUserResults()
        {
            var myResults = QuizResultService.GetResultsByUser(ThisUser.Login)
                .OrderByDescending(r => r.Date)
                .Select((r, index) => new
                {
                    Index = index + 1,       // номер по порядку
                    Quiz = r.QuizTitle,      // название викторины
                    Score = r.Score,         // очки
                    Date = r.Date.ToString("dd.MM.yyyy HH:mm") // дата
                })
                .ToList();

            dgvMyResults.DataSource = myResults;
        }


    }
}
