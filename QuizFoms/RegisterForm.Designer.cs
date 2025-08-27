namespace QuizFoms
{
    partial class RegisterForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            dateOfBirthLabel = new Label();
            password = new Label();
            loginField = new Label();
            txtLogin = new TextBox();
            txtPassword = new TextBox();
            dateTimeBox = new DateTimePicker();
            tableLayoutPanel2 = new TableLayoutPanel();
            cancelButton = new Button();
            registrationButton = new Button();
            pictureBox1 = new PictureBox();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.8842964F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 66.1157F));
            tableLayoutPanel1.Controls.Add(dateOfBirthLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(password, 0, 1);
            tableLayoutPanel1.Controls.Add(loginField, 0, 0);
            tableLayoutPanel1.Controls.Add(txtLogin, 1, 0);
            tableLayoutPanel1.Controls.Add(txtPassword, 1, 1);
            tableLayoutPanel1.Controls.Add(dateTimeBox, 1, 2);
            tableLayoutPanel1.Location = new Point(59, 56);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(242, 96);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // dateOfBirthLabel
            // 
            dateOfBirthLabel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dateOfBirthLabel.AutoSize = true;
            dateOfBirthLabel.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            dateOfBirthLabel.Location = new Point(3, 64);
            dateOfBirthLabel.Name = "dateOfBirthLabel";
            dateOfBirthLabel.Size = new Size(76, 32);
            dateOfBirthLabel.TabIndex = 5;
            dateOfBirthLabel.Text = "Дата рождения";
            dateOfBirthLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // password
            // 
            password.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            password.AutoSize = true;
            password.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            password.Location = new Point(3, 32);
            password.Name = "password";
            password.Size = new Size(76, 32);
            password.TabIndex = 3;
            password.Text = "Пароль";
            password.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // loginField
            // 
            loginField.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            loginField.AutoSize = true;
            loginField.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            loginField.Location = new Point(3, 0);
            loginField.Name = "loginField";
            loginField.Size = new Size(76, 32);
            loginField.TabIndex = 1;
            loginField.Text = "Логин";
            loginField.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtLogin
            // 
            txtLogin.Dock = DockStyle.Fill;
            txtLogin.Font = new Font("Segoe UI", 12F);
            txtLogin.Location = new Point(85, 3);
            txtLogin.Name = "txtLogin";
            txtLogin.Size = new Size(154, 29);
            txtLogin.TabIndex = 6;
            // 
            // txtPassword
            // 
            txtPassword.Dock = DockStyle.Fill;
            txtPassword.Font = new Font("Segoe UI", 12F);
            txtPassword.Location = new Point(85, 35);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(154, 29);
            txtPassword.TabIndex = 7;
            txtPassword.UseSystemPasswordChar = true;
            // 
            // dateTimeBox
            // 
            dateTimeBox.CalendarFont = new Font("Segoe UI", 12F);
            dateTimeBox.Dock = DockStyle.Bottom;
            dateTimeBox.Location = new Point(85, 70);
            dateTimeBox.Name = "dateTimeBox";
            dateTimeBox.Size = new Size(154, 23);
            dateTimeBox.TabIndex = 8;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(cancelButton, 1, 0);
            tableLayoutPanel2.Controls.Add(registrationButton, 0, 0);
            tableLayoutPanel2.Location = new Point(50, 223);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(279, 37);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // cancelButton
            // 
            cancelButton.BackColor = Color.White;
            cancelButton.Dock = DockStyle.Fill;
            cancelButton.FlatAppearance.BorderSize = 0;
            cancelButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            cancelButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            cancelButton.FlatStyle = FlatStyle.Flat;
            cancelButton.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            cancelButton.Location = new Point(142, 3);
            cancelButton.Name = "cancelButton";
            cancelButton.Size = new Size(134, 31);
            cancelButton.TabIndex = 6;
            cancelButton.Text = "Отмена";
            cancelButton.UseVisualStyleBackColor = false;
            cancelButton.Click += CancelButton_Click;
            // 
            // registrationButton
            // 
            registrationButton.BackColor = Color.White;
            registrationButton.Dock = DockStyle.Fill;
            registrationButton.FlatAppearance.BorderSize = 0;
            registrationButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            registrationButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            registrationButton.FlatStyle = FlatStyle.Flat;
            registrationButton.Font = new Font("Tahoma", 9F, FontStyle.Bold);
            registrationButton.Location = new Point(3, 3);
            registrationButton.Name = "registrationButton";
            registrationButton.Size = new Size(133, 31);
            registrationButton.TabIndex = 5;
            registrationButton.Text = "Регистрация";
            registrationButton.UseVisualStyleBackColor = false;
            registrationButton.Click += registrationButton_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.view;
            pictureBox1.Location = new Point(304, 92);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(25, 29);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // RegisterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(364, 329);
            Controls.Add(pictureBox1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "RegisterForm";
            Text = "RegisterForm";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label loginField;
        private Label dateOfBirthLabel;
        private Label password;
        private Button cancelButton;
        private Button registrationButton;
        private TextBox txtLogin;
        private TextBox txtPassword;
        private PictureBox pictureBox1;
        private DateTimePicker dateTimeBox;
    }
}