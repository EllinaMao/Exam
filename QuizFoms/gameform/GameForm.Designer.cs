namespace QuizFoms
{
    partial class GameForm
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
            panel1 = new Panel();
            Next = new Button();
            panel2 = new Panel();
            tableLayoutPanel1 = new TableLayoutPanel();
            questionTextLb = new Label();
            checkedListBox1 = new CheckedListBox();
            questionNumberLb = new Label();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(Next);
            panel1.Dock = DockStyle.Bottom;
            panel1.Location = new Point(0, 410);
            panel1.Name = "panel1";
            panel1.Size = new Size(527, 40);
            panel1.TabIndex = 0;
            // 
            // Next
            // 
            Next.Location = new Point(440, 7);
            Next.Name = "Next";
            Next.Size = new Size(75, 23);
            Next.TabIndex = 0;
            Next.Text = "Далее";
            Next.UseVisualStyleBackColor = true;
            Next.Click += Next_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(tableLayoutPanel1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(527, 49);
            panel2.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(questionNumberLb, 0, 0);
            tableLayoutPanel1.Controls.Add(questionTextLb, 0, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(527, 49);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // questionTextLb
            // 
            questionTextLb.AutoSize = true;
            questionTextLb.Dock = DockStyle.Left;
            questionTextLb.Location = new Point(3, 24);
            questionTextLb.Name = "questionTextLb";
            questionTextLb.Size = new Size(102, 25);
            questionTextLb.TabIndex = 1;
            questionTextLb.Text = "Я - текст вопроса";
            // 
            // checkedListBox1
            // 
            checkedListBox1.Dock = DockStyle.Fill;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(0, 49);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(527, 361);
            checkedListBox1.TabIndex = 3;
            // 
            // questionNumberLb
            // 
            questionNumberLb.AutoSize = true;
            questionNumberLb.Dock = DockStyle.Left;
            questionNumberLb.Location = new Point(3, 0);
            questionNumberLb.Name = "questionNumberLb";
            questionNumberLb.Size = new Size(110, 24);
            questionNumberLb.TabIndex = 2;
            questionNumberLb.Text = "Я - номер вопроса";
            // 
            // GameForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 450);
            Controls.Add(checkedListBox1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "GameForm";
            Text = "GameForm";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private CheckedListBox checkedListBox1;
        private Button Next;
        private TableLayoutPanel tableLayoutPanel1;
        private Label questionTextLb;
        private Label questionNumberLb;
    }
}