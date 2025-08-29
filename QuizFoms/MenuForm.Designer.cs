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
            btnNewQuiz = new Button();
            btnMyResults = new Button();
            btnTop = new Button();
            btnSettings = new Button();
            btnExit = new Button();
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
            splitContainer1.Size = new Size(299, 404);
            splitContainer1.SplitterDistance = 46;
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
            tableLayoutPanel1.Controls.Add(btnNewQuiz, 0, 0);
            tableLayoutPanel1.Controls.Add(btnMyResults, 0, 1);
            tableLayoutPanel1.Controls.Add(btnTop, 0, 2);
            tableLayoutPanel1.Controls.Add(btnSettings, 0, 3);
            tableLayoutPanel1.Controls.Add(btnExit, 0, 4);
            tableLayoutPanel1.Location = new Point(51, 37);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 5;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(200, 264);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // btnNewQuiz
            // 
            btnNewQuiz.BackColor = Color.WhiteSmoke;
            btnNewQuiz.Dock = DockStyle.Fill;
            btnNewQuiz.FlatStyle = FlatStyle.Flat;
            btnNewQuiz.Location = new Point(3, 3);
            btnNewQuiz.Name = "btnNewQuiz";
            btnNewQuiz.Size = new Size(194, 46);
            btnNewQuiz.TabIndex = 0;
            btnNewQuiz.Text = "Новая викторина";
            btnNewQuiz.UseVisualStyleBackColor = false;
            btnNewQuiz.Click += btnNewQuiz_Click;
            // 
            // btnMyResults
            // 
            btnMyResults.BackColor = Color.WhiteSmoke;
            btnMyResults.Dock = DockStyle.Fill;
            btnMyResults.FlatStyle = FlatStyle.Flat;
            btnMyResults.Location = new Point(3, 55);
            btnMyResults.Name = "btnMyResults";
            btnMyResults.Size = new Size(194, 46);
            btnMyResults.TabIndex = 1;
            btnMyResults.Text = "Мои результаты";
            btnMyResults.UseVisualStyleBackColor = false;
            // 
            // btnTop
            // 
            btnTop.BackColor = Color.WhiteSmoke;
            btnTop.Dock = DockStyle.Fill;
            btnTop.FlatStyle = FlatStyle.Flat;
            btnTop.Location = new Point(3, 107);
            btnTop.Name = "btnTop";
            btnTop.Size = new Size(194, 46);
            btnTop.TabIndex = 2;
            btnTop.Text = "Топ-20 игроков";
            btnTop.UseVisualStyleBackColor = false;
            // 
            // btnSettings
            // 
            btnSettings.BackColor = Color.WhiteSmoke;
            btnSettings.Dock = DockStyle.Fill;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.Location = new Point(3, 159);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(194, 46);
            btnSettings.TabIndex = 3;
            btnSettings.Text = "Настройки";
            btnSettings.UseVisualStyleBackColor = false;
            // 
            // btnExit
            // 
            btnExit.BackColor = Color.WhiteSmoke;
            btnExit.Dock = DockStyle.Fill;
            btnExit.FlatStyle = FlatStyle.Flat;
            btnExit.Location = new Point(3, 211);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(194, 50);
            btnExit.TabIndex = 4;
            btnExit.Text = "Выход";
            btnExit.UseVisualStyleBackColor = false;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(299, 404);
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
        private Button btnMyResults;
        private Button btnTop;
        private Button btnSettings;
        private Button btnExit;
    }
}