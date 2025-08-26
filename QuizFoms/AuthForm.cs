using login_logic;

namespace QuizFoms
{
    public partial class AuthForm : Form
    {
        AuthService authService;
        public AuthForm()
        {
            authService = new();
            authService.LoadUsers();
            InitializeComponent();
        }

        private void login_button_Click(object sender, EventArgs e)
        {
            try
            {
                authService.Login(login_box.Text, password_box.Text);
            }
            catch
            
        }




    }
}
