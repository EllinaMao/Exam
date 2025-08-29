namespace QuizFoms
{
    partial class AuthForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            text_boxes_panel = new TableLayoutPanel();
            password_box = new TextBox();
            login_box = new TextBox();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            Backcolor = new Panel();
            AuthText = new Label();
            name_register_panel = new TableLayoutPanel();
            register_button = new Button();
            login_button = new Button();
            GameChoicePanel = new TableLayoutPanel();
            backToLoginScreen = new Button();
            enter_Edditor = new Button();
            enterGame = new Button();
            pictureBox3 = new PictureBox();
            text_boxes_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Backcolor.SuspendLayout();
            name_register_panel.SuspendLayout();
            GameChoicePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // text_boxes_panel
            // 
            text_boxes_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            text_boxes_panel.ColumnCount = 2;
            text_boxes_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20.25F));
            text_boxes_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 79.75F));
            text_boxes_panel.Controls.Add(password_box, 1, 1);
            text_boxes_panel.Controls.Add(login_box, 1, 0);
            text_boxes_panel.Controls.Add(pictureBox1, 0, 0);
            text_boxes_panel.Controls.Add(pictureBox2, 0, 1);
            text_boxes_panel.Location = new Point(166, 154);
            text_boxes_panel.Name = "text_boxes_panel";
            text_boxes_panel.RowCount = 2;
            text_boxes_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            text_boxes_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            text_boxes_panel.Size = new Size(400, 108);
            text_boxes_panel.TabIndex = 0;
            // 
            // password_box
            // 
            password_box.BorderStyle = BorderStyle.None;
            password_box.Dock = DockStyle.Fill;
            password_box.Font = new Font("Segoe UI", 15F);
            password_box.Location = new Point(84, 57);
            password_box.Name = "password_box";
            password_box.PlaceholderText = "password";
            password_box.Size = new Size(313, 27);
            password_box.TabIndex = 9;
            password_box.UseSystemPasswordChar = true;
            // 
            // login_box
            // 
            login_box.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left;
            login_box.BorderStyle = BorderStyle.None;
            login_box.Font = new Font("Segoe UI", 15F);
            login_box.Location = new Point(84, 3);
            login_box.Name = "login_box";
            login_box.PlaceholderText = "login";
            login_box.Size = new Size(313, 27);
            login_box.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.secretary_12832595;
            pictureBox1.Location = new Point(3, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(75, 48);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 7;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Dock = DockStyle.Fill;
            pictureBox2.Image = Properties.Resources.key_5066640;
            pictureBox2.Location = new Point(3, 57);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(75, 48);
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // Backcolor
            // 
            Backcolor.BackColor = Color.Wheat;
            Backcolor.Controls.Add(AuthText);
            Backcolor.Dock = DockStyle.Top;
            Backcolor.Location = new Point(0, 0);
            Backcolor.Name = "Backcolor";
            Backcolor.Size = new Size(800, 100);
            Backcolor.TabIndex = 1;
            // 
            // AuthText
            // 
            AuthText.AccessibleRole = AccessibleRole.TitleBar;
            AuthText.BackColor = Color.Transparent;
            AuthText.Dock = DockStyle.Fill;
            AuthText.Font = new Font("Tahoma", 21.75F, FontStyle.Bold);
            AuthText.ForeColor = SystemColors.Desktop;
            AuthText.Location = new Point(0, 0);
            AuthText.Name = "AuthText";
            AuthText.Size = new Size(800, 100);
            AuthText.TabIndex = 0;
            AuthText.Text = "Авторизация";
            AuthText.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // name_register_panel
            // 
            name_register_panel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            name_register_panel.ColumnCount = 2;
            name_register_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            name_register_panel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            name_register_panel.Controls.Add(register_button, 1, 0);
            name_register_panel.Controls.Add(login_button, 0, 0);
            name_register_panel.Location = new Point(250, 292);
            name_register_panel.Name = "name_register_panel";
            name_register_panel.RowCount = 1;
            name_register_panel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            name_register_panel.RowStyles.Add(new RowStyle(SizeType.Absolute, 49F));
            name_register_panel.Size = new Size(318, 49);
            name_register_panel.TabIndex = 2;
            // 
            // register_button
            // 
            register_button.BackColor = Color.White;
            register_button.Dock = DockStyle.Fill;
            register_button.FlatAppearance.BorderSize = 0;
            register_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            register_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            register_button.FlatStyle = FlatStyle.Flat;
            register_button.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            register_button.Location = new Point(162, 3);
            register_button.Name = "register_button";
            register_button.Size = new Size(153, 43);
            register_button.TabIndex = 1;
            register_button.Text = "Регистрация";
            register_button.UseVisualStyleBackColor = false;
            register_button.Click += register_button_Click;
            // 
            // login_button
            // 
            login_button.BackColor = Color.White;
            login_button.Dock = DockStyle.Fill;
            login_button.FlatAppearance.BorderSize = 0;
            login_button.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            login_button.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            login_button.FlatStyle = FlatStyle.Flat;
            login_button.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            login_button.Location = new Point(3, 3);
            login_button.Name = "login_button";
            login_button.Size = new Size(153, 43);
            login_button.TabIndex = 0;
            login_button.Text = "Залогиниться";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;
            // 
            // GameChoicePanel
            // 
            GameChoicePanel.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            GameChoicePanel.ColumnCount = 1;
            GameChoicePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            GameChoicePanel.Controls.Add(backToLoginScreen, 0, 2);
            GameChoicePanel.Controls.Add(enter_Edditor, 0, 1);
            GameChoicePanel.Controls.Add(enterGame, 0, 0);
            GameChoicePanel.Location = new Point(241, 133);
            GameChoicePanel.Name = "GameChoicePanel";
            GameChoicePanel.RowCount = 3;
            GameChoicePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GameChoicePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GameChoicePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            GameChoicePanel.Size = new Size(318, 143);
            GameChoicePanel.TabIndex = 3;
            GameChoicePanel.Visible = false;
            // 
            // backToLoginScreen
            // 
            backToLoginScreen.BackColor = Color.White;
            backToLoginScreen.Dock = DockStyle.Fill;
            backToLoginScreen.FlatAppearance.BorderSize = 0;
            backToLoginScreen.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            backToLoginScreen.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            backToLoginScreen.FlatStyle = FlatStyle.Flat;
            backToLoginScreen.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            backToLoginScreen.Location = new Point(3, 97);
            backToLoginScreen.Name = "backToLoginScreen";
            backToLoginScreen.Size = new Size(312, 43);
            backToLoginScreen.TabIndex = 3;
            backToLoginScreen.Text = "Выйти с аккаунта";
            backToLoginScreen.UseVisualStyleBackColor = false;
            backToLoginScreen.Click += backToLoginScreen_Click;
            // 
            // enter_Edditor
            // 
            enter_Edditor.BackColor = Color.White;
            enter_Edditor.Dock = DockStyle.Fill;
            enter_Edditor.FlatAppearance.BorderSize = 0;
            enter_Edditor.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            enter_Edditor.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            enter_Edditor.FlatStyle = FlatStyle.Flat;
            enter_Edditor.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            enter_Edditor.Location = new Point(3, 50);
            enter_Edditor.Name = "enter_Edditor";
            enter_Edditor.Size = new Size(312, 41);
            enter_Edditor.TabIndex = 2;
            enter_Edditor.Text = "Открыть еддитор";
            enter_Edditor.UseVisualStyleBackColor = false;
            enter_Edditor.Click += enter_Edditor_Click;
            // 
            // enterGame
            // 
            enterGame.BackColor = Color.White;
            enterGame.Dock = DockStyle.Fill;
            enterGame.FlatAppearance.BorderSize = 0;
            enterGame.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            enterGame.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            enterGame.FlatStyle = FlatStyle.Flat;
            enterGame.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            enterGame.Location = new Point(3, 3);
            enterGame.Name = "enterGame";
            enterGame.Size = new Size(312, 41);
            enterGame.TabIndex = 0;
            enterGame.Text = "Начать игру";
            enterGame.UseVisualStyleBackColor = false;
            enterGame.Click += enterGame_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.view;
            pictureBox3.Location = new Point(572, 211);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(25, 29);
            pictureBox3.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox3);
            Controls.Add(GameChoicePanel);
            Controls.Add(name_register_panel);
            Controls.Add(Backcolor);
            Controls.Add(text_boxes_panel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "AuthForm";
            Text = "Authorisation window";
            text_boxes_panel.ResumeLayout(false);
            text_boxes_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            Backcolor.ResumeLayout(false);
            name_register_panel.ResumeLayout(false);
            GameChoicePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel text_boxes_panel;
        private Panel Backcolor;
        private TextBox password_box;
        private TextBox login_box;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TableLayoutPanel name_register_panel;
        private Button register_button;
        private Button login_button;
        private TableLayoutPanel GameChoicePanel;
        private Button enter_Edditor;
        private Button enterGame;
        private Button backToLoginScreen;
        private Label AuthText;
        private PictureBox pictureBox3;
    }
}
