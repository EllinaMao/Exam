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
            text_boxes_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            Backcolor.SuspendLayout();
            name_register_panel.SuspendLayout();
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
            register_button.Text = "Register";
            register_button.UseVisualStyleBackColor = false;
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
            login_button.Text = "Log in";
            login_button.UseVisualStyleBackColor = false;
            login_button.Click += login_button_Click;
            // 
            // AuthForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.CornflowerBlue;
            ClientSize = new Size(800, 450);
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
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel text_boxes_panel;
        private Panel Backcolor;
        private Label AuthText;
        private TextBox password_box;
        private TextBox login_box;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private TableLayoutPanel name_register_panel;
        private Button register_button;
        private Button login_button;
    }
}
