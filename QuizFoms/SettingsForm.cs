using login_logic;


namespace QuizFoms
{
    public partial class SettingsForm : Form
    {
        User ThisUser {  get; set; }
        public SettingsForm(User user)
        {
            this.StartPosition = FormStartPosition.CenterScreen;
            ThisUser = user;
            InitializeComponent();
            dateOfBitrhPick.Value = ThisUser.DateOfBirth.ToDateTime(new TimeOnly(0, 0));

        }
        private void SetPassword()
        {
            if (passwField.Text.Trim() == passwFieldConfirm.Text.Trim())
            {
                ThisUser.ChangePassword(passwField.Text.Trim());
            }
            else
            {
                MessageBox.Show("Пароли не совпадают");
            }
        }
        private void SetDateOfBirth()
        {
            ThisUser.DateOfBirth = DateOnly.FromDateTime(dateOfBitrhPick.Value);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            SetPassword();
            SetDateOfBirth();
            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void CanselBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
