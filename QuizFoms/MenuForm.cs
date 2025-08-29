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
    public partial class MenuForm : Form
    {
        User? user { get; set; }
        public MenuForm(User user_)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            this.user = user_;
            InitializeComponent();
            userGreetinglb.Text = $"Привет {user.Login.ToString()}!";
        }

        private void btnNewQuiz_Click(object sender, EventArgs e)
        {
            this.Hide();
            var game = new SelectQuizForm(user);
            this.Show();
        }
    }
}
