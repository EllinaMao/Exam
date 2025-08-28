namespace QuizFoms
{
    partial class QuizEditorForm
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
            groupBox1 = new GroupBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtName = new TextBox();
            txtDescription = new TextBox();
            txtCategory = new TextBox();
            splitContainer3 = new SplitContainer();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            listBoxQuestions = new ListBox();
            gQuizList = new GroupBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btAddQuestion = new Button();
            btChangeQuestion = new Button();
            btDeleteQuestion = new Button();
            splitContainer4 = new SplitContainer();
            checkedListBox1 = new CheckedListBox();
            flowLayoutPanel2 = new FlowLayoutPanel();
            btAddAnswer = new Button();
            btChangeAnswer = new Button();
            btDeleteAnswer = new Button();
            gbQuestionList = new GroupBox();
            panel1 = new Panel();
            btCansel = new Button();
            btSave = new Button();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            flowLayoutPanel2.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Margin = new Padding(3, 2, 3, 2);
            groupBox1.Name = "groupBox1";
            groupBox1.Padding = new Padding(3, 2, 3, 2);
            groupBox1.Size = new Size(1047, 95);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Редактор вопросов";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15.11335F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 84.88665F));
            tableLayoutPanel1.Controls.Add(label1, 0, 0);
            tableLayoutPanel1.Controls.Add(label2, 0, 1);
            tableLayoutPanel1.Controls.Add(label3, 0, 2);
            tableLayoutPanel1.Controls.Add(txtName, 1, 0);
            tableLayoutPanel1.Controls.Add(txtDescription, 1, 1);
            tableLayoutPanel1.Controls.Add(txtCategory, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(3, 18);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(572, 75);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(80, 25);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 25);
            label2.Name = "label2";
            label2.Size = new Size(80, 25);
            label2.TabIndex = 1;
            label2.Text = "Описание";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 50);
            label3.Name = "label3";
            label3.Size = new Size(80, 25);
            label3.TabIndex = 2;
            label3.Text = "Категория";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(89, 2);
            txtName.Margin = new Padding(3, 2, 3, 2);
            txtName.Name = "txtName";
            txtName.Size = new Size(480, 23);
            txtName.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Dock = DockStyle.Top;
            txtDescription.Location = new Point(89, 27);
            txtDescription.Margin = new Padding(3, 2, 3, 2);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(480, 23);
            txtDescription.TabIndex = 4;
            // 
            // txtCategory
            // 
            txtCategory.Dock = DockStyle.Fill;
            txtCategory.Location = new Point(89, 52);
            txtCategory.Margin = new Padding(3, 2, 3, 2);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(480, 23);
            txtCategory.TabIndex = 5;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 95);
            splitContainer3.Name = "splitContainer3";
            splitContainer3.Orientation = Orientation.Horizontal;
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(splitContainer1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(panel1);
            splitContainer3.Size = new Size(1047, 489);
            splitContainer3.SplitterDistance = 458;
            splitContainer3.TabIndex = 2;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer4);
            splitContainer1.Panel2.Controls.Add(gbQuestionList);
            splitContainer1.Size = new Size(1047, 458);
            splitContainer1.SplitterDistance = 357;
            splitContainer1.TabIndex = 2;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(3, 2, 3, 2);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(listBoxQuestions);
            splitContainer2.Panel1.Controls.Add(gQuizList);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer2.Size = new Size(357, 458);
            splitContainer2.SplitterDistance = 425;
            splitContainer2.SplitterWidth = 3;
            splitContainer2.TabIndex = 0;
            // 
            // listBoxQuestions
            // 
            listBoxQuestions.Dock = DockStyle.Fill;
            listBoxQuestions.FormattingEnabled = true;
            listBoxQuestions.ItemHeight = 15;
            listBoxQuestions.Location = new Point(0, 25);
            listBoxQuestions.Margin = new Padding(3, 2, 3, 2);
            listBoxQuestions.Name = "listBoxQuestions";
            listBoxQuestions.Size = new Size(357, 400);
            listBoxQuestions.TabIndex = 4;
            listBoxQuestions.SelectedIndexChanged += listBoxQuestions_SelectedIndexChanged;
            // 
            // gQuizList
            // 
            gQuizList.Dock = DockStyle.Top;
            gQuizList.Location = new Point(0, 0);
            gQuizList.Name = "gQuizList";
            gQuizList.Size = new Size(357, 25);
            gQuizList.TabIndex = 0;
            gQuizList.TabStop = false;
            gQuizList.Text = "Список вопросов";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(btAddQuestion);
            flowLayoutPanel1.Controls.Add(btChangeQuestion);
            flowLayoutPanel1.Controls.Add(btDeleteQuestion);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(357, 30);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // btAddQuestion
            // 
            btAddQuestion.Location = new Point(3, 2);
            btAddQuestion.Margin = new Padding(3, 2, 3, 2);
            btAddQuestion.Name = "btAddQuestion";
            btAddQuestion.Size = new Size(82, 22);
            btAddQuestion.TabIndex = 0;
            btAddQuestion.Text = "+";
            btAddQuestion.UseVisualStyleBackColor = true;
            // 
            // btChangeQuestion
            // 
            btChangeQuestion.Location = new Point(91, 2);
            btChangeQuestion.Margin = new Padding(3, 2, 3, 2);
            btChangeQuestion.Name = "btChangeQuestion";
            btChangeQuestion.Size = new Size(82, 22);
            btChangeQuestion.TabIndex = 1;
            btChangeQuestion.Text = "Изменить";
            btChangeQuestion.UseVisualStyleBackColor = true;
            // 
            // btDeleteQuestion
            // 
            btDeleteQuestion.Location = new Point(179, 2);
            btDeleteQuestion.Margin = new Padding(3, 2, 3, 2);
            btDeleteQuestion.Name = "btDeleteQuestion";
            btDeleteQuestion.Size = new Size(82, 22);
            btDeleteQuestion.TabIndex = 2;
            btDeleteQuestion.Text = "-";
            btDeleteQuestion.UseVisualStyleBackColor = true;
            // 
            // splitContainer4
            // 
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 25);
            splitContainer4.Name = "splitContainer4";
            splitContainer4.Orientation = Orientation.Horizontal;
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(checkedListBox1);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(flowLayoutPanel2);
            splitContainer4.Size = new Size(686, 433);
            splitContainer4.SplitterDistance = 400;
            splitContainer4.TabIndex = 2;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Dock = DockStyle.Fill;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Location = new Point(0, 0);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(686, 400);
            checkedListBox1.TabIndex = 7;
            checkedListBox1.SelectedIndexChanged += checkedListBox1_SelectedIndexChanged;
            // 
            // flowLayoutPanel2
            // 
            flowLayoutPanel2.Controls.Add(btAddAnswer);
            flowLayoutPanel2.Controls.Add(btChangeAnswer);
            flowLayoutPanel2.Controls.Add(btDeleteAnswer);
            flowLayoutPanel2.Dock = DockStyle.Fill;
            flowLayoutPanel2.Location = new Point(0, 0);
            flowLayoutPanel2.Name = "flowLayoutPanel2";
            flowLayoutPanel2.Size = new Size(686, 29);
            flowLayoutPanel2.TabIndex = 7;
            // 
            // btAddAnswer
            // 
            btAddAnswer.Location = new Point(3, 2);
            btAddAnswer.Margin = new Padding(3, 2, 3, 2);
            btAddAnswer.Name = "btAddAnswer";
            btAddAnswer.Size = new Size(82, 22);
            btAddAnswer.TabIndex = 4;
            btAddAnswer.Text = "+";
            btAddAnswer.UseVisualStyleBackColor = true;
            // 
            // btChangeAnswer
            // 
            btChangeAnswer.Location = new Point(91, 2);
            btChangeAnswer.Margin = new Padding(3, 2, 3, 2);
            btChangeAnswer.Name = "btChangeAnswer";
            btChangeAnswer.Size = new Size(82, 22);
            btChangeAnswer.TabIndex = 5;
            btChangeAnswer.Text = "Изменить";
            btChangeAnswer.UseVisualStyleBackColor = true;
            // 
            // btDeleteAnswer
            // 
            btDeleteAnswer.Location = new Point(179, 2);
            btDeleteAnswer.Margin = new Padding(3, 2, 3, 2);
            btDeleteAnswer.Name = "btDeleteAnswer";
            btDeleteAnswer.Size = new Size(82, 22);
            btDeleteAnswer.TabIndex = 6;
            btDeleteAnswer.Text = "-";
            btDeleteAnswer.UseVisualStyleBackColor = true;
            // 
            // gbQuestionList
            // 
            gbQuestionList.Dock = DockStyle.Top;
            gbQuestionList.Location = new Point(0, 0);
            gbQuestionList.Name = "gbQuestionList";
            gbQuestionList.Size = new Size(686, 25);
            gbQuestionList.TabIndex = 1;
            gbQuestionList.TabStop = false;
            gbQuestionList.Text = "Редактор вопросов";
            // 
            // panel1
            // 
            panel1.Controls.Add(btCansel);
            panel1.Controls.Add(btSave);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 2, 3, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1047, 27);
            panel1.TabIndex = 1;
            // 
            // btCansel
            // 
            btCansel.Location = new Point(844, 0);
            btCansel.Margin = new Padding(3, 2, 3, 2);
            btCansel.Name = "btCansel";
            btCansel.Size = new Size(82, 22);
            btCansel.TabIndex = 7;
            btCansel.Text = "Отмена";
            btCansel.UseVisualStyleBackColor = true;
            // 
            // btSave
            // 
            btSave.Location = new Point(953, 0);
            btSave.Margin = new Padding(3, 2, 3, 2);
            btSave.Name = "btSave";
            btSave.Size = new Size(82, 22);
            btSave.TabIndex = 8;
            btSave.Text = "Сохранить";
            btSave.UseVisualStyleBackColor = true;
            // 
            // QuizEditorForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1047, 584);
            Controls.Add(splitContainer3);
            Controls.Add(groupBox1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 2, 3, 2);
            Name = "QuizEditorForm";
            Text = " ";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            flowLayoutPanel2.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtName;
        private TextBox txtDescription;
        private TextBox txtCategory;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private FlowLayoutPanel flowLayoutPanel1;
        private Panel panel1;
        private GroupBox gbQuestionList;
        private Button btCansel;
        private Button btSave;
        private ListBox listBoxQuestions;
        private GroupBox gQuizList;
        private Button btAddQuestion;
        private Button btChangeQuestion;
        private Button btDeleteQuestion;
        private SplitContainer splitContainer4;
        private CheckedListBox checkedListBox1;
        private FlowLayoutPanel flowLayoutPanel2;
        private Button btAddAnswer;
        private Button btChangeAnswer;
        private Button btDeleteAnswer;
    }
}