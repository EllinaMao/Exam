using login_logic;

namespace QuizFoms
{
    public partial class AuthForm : Form
    {
        AuthService authService;
        User? ThisUser { get; set; }

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
                ThisUser = authService.Login(login_box.Text, password_box.Text);
                if (ThisUser != null)
                {
                    VisibleMenu(false);
                }
            }
            catch (InvalidLoginOrPasswordException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void VisibleMenu(bool show)
        {
            text_boxes_panel.Visible = show;
            name_register_panel.Visible = show;
            AuthText.Visible = show;
            GameChoicePanel.Visible = !show;

        }

        private void backToLoginScreen_Click(object sender, EventArgs e)
        {
            ThisUser = null;
            VisibleMenu(true);
        }
        
        private void register_button_Click(object sender, EventArgs e)
        {
            try
            {
                authService.Register(login_box.Text, password_box.Text);

            }
            catch
        }

    }
}
