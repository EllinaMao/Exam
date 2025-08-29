namespace QuizFoms
{
    partial class MenuForm
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
            splitContainer1 = new SplitContainer();
            userGreetinglb = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            editBtn = new Button();
            settingsBtn = new Button();
            Top20Btn = new Button();
            myResBtn = new Button();
            btnNewQuiz = new Button();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.BackColor = Color.LightSkyBlue;
            splitContainer1.Panel1.Controls.Add(userGreetinglb);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.BackColor = Color.Wheat;
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Size = new Size(318, 428);
            splitContainer1.SplitterDistance = 38;
            splitContainer1.TabIndex = 0;
            // 
            // userGreetinglb
            // 
            userGreetinglb.AutoSize = true;
            userGreetinglb.Font = new Font("Tahoma", 12F);
            userGreetinglb.Location = new Point(27, 15);
            userGreetinglb.Name = "userGreetinglb";
            userGreetinglb.Size = new Size(62, 19);
            userGreetinglb.TabIndex = 0;
            userGreetinglb.Text = "Привет";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(editBtn, 0, 4);
            tableLayoutPanel1.Controls.Add(settingsBtn, 0, 3);
            tableLayoutPanel1.Controls.Add(Top20Btn, 0, 2);
            tableLayoutPanel1.Controls.Add(myResBtn, 0, 1);
            tableLayoutPanel1.Controls.Add(btnNewQuiz, 0, 0);
            tableLayoutPanel1.Location = new Point(51, 37);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.666666F));
            tableLayoutPanel1.Size = new Size(220, 300);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // editBtn
            // 
            editBtn.BackColor = Color.WhiteSmoke;
            editBtn.Dock = DockStyle.Fill;
            editBtn.FlatStyle = FlatStyle.Flat;
            editBtn.Location = new Point(3, 243);
            editBtn.Name = "editBtn";
            editBtn.Size = new Size(214, 54);
            editBtn.TabIndex = 22;
            editBtn.Text = "Выход";
            editBtn.UseVisualStyleBackColor = false;
            // 
            // settingsBtn
            // 
            settingsBtn.BackColor = Color.WhiteSmoke;
            settingsBtn.Dock = DockStyle.Fill;
            settingsBtn.FlatStyle = FlatStyle.Flat;
            settingsBtn.Location = new Point(3, 183);
            settingsBtn.Name = "settingsBtn";
            settingsBtn.Size = new Size(214, 54);
            settingsBtn.TabIndex = 21;
            settingsBtn.Text = "Настройки";
            settingsBtn.UseVisualStyleBackColor = false;
            settingsBtn.Click += settingsBtn_Click;
            // 
            // Top20Btn
            // 
            Top20Btn.BackColor = Color.WhiteSmoke;
            Top20Btn.Dock = DockStyle.Fill;
            Top20Btn.FlatStyle = FlatStyle.Flat;
            Top20Btn.Location = new Point(3, 123);
            Top20Btn.Name = "Top20Btn";
            Top20Btn.Size = new Size(214, 54);
            Top20Btn.TabIndex = 20;
            Top20Btn.Text = "Топ-20 игроков";
            Top20Btn.UseVisualStyleBackColor = false;
            Top20Btn.Click += Top20Btn_Click;
            // 
            // myResBtn
            // 
            myResBtn.BackColor = Color.WhiteSmoke;
            myResBtn.Dock = DockStyle.Fill;
            myResBtn.FlatStyle = FlatStyle.Flat;
            myResBtn.Location = new Point(3, 63);
            myResBtn.Name = "myResBtn";
            myResBtn.Size = new Size(214, 54);
            myResBtn.TabIndex = 19;
            myResBtn.Text = "Мои результаты";
            myResBtn.UseVisualStyleBackColor = false;
            myResBtn.Click += myResBtn_Click;
            // 
            // btnNewQuiz
            // 
            btnNewQuiz.BackColor = Color.WhiteSmoke;
            btnNewQuiz.Dock = DockStyle.Fill;
            btnNewQuiz.FlatStyle = FlatStyle.Flat;
            btnNewQuiz.Location = new Point(3, 3);
            btnNewQuiz.Name = "btnNewQuiz";
            btnNewQuiz.Size = new Size(214, 54);
            btnNewQuiz.TabIndex = 0;
            btnNewQuiz.Text = "Новая викторина";
            btnNewQuiz.UseVisualStyleBackColor = false;
            btnNewQuiz.Click += btnNewQuiz_Click;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(318, 428);
            Controls.Add(splitContainer1);
            Name = "MenuForm";
            Text = "MenuForm";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private Label userGreetinglb;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnNewQuiz;
        private Button editBtn;
        private Button settingsBtn;
        private Button Top20Btn;
        private Button myResBtn;
    }
}