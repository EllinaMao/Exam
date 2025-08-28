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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            button2 = new Button();
            flowLayoutPanel1 = new FlowLayoutPanel();
            button3 = new Button();
            button1 = new Button();
            listBox1 = new ListBox();
            button4 = new Button();
            panel1 = new Panel();
            groupBox1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tableLayoutPanel1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0 , 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(1209 , 127);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "groupBox1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent , 15.11335F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent , 84.88665F));
            tableLayoutPanel1.Controls.Add(label1 , 0 , 0);
            tableLayoutPanel1.Controls.Add(label2 , 0 , 1);
            tableLayoutPanel1.Controls.Add(label3 , 0 , 2);
            tableLayoutPanel1.Controls.Add(txtName , 1 , 0);
            tableLayoutPanel1.Controls.Add(txtDescription , 1 , 1);
            tableLayoutPanel1.Controls.Add(txtCategory , 1 , 2);
            tableLayoutPanel1.Dock = DockStyle.Left;
            tableLayoutPanel1.Location = new Point(3 , 23);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent , 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent , 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent , 33.3333321F));
            tableLayoutPanel1.Size = new Size(654 , 101);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Location = new Point(3 , 0);
            label1.Name = "label1";
            label1.Size = new Size(92 , 33);
            label1.TabIndex = 0;
            label1.Text = "Название";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3 , 33);
            label2.Name = "label2";
            label2.Size = new Size(92 , 33);
            label2.TabIndex = 1;
            label2.Text = "Описание";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3 , 66);
            label3.Name = "label3";
            label3.Size = new Size(92 , 35);
            label3.TabIndex = 2;
            label3.Text = "Категория";
            // 
            // txtName
            // 
            txtName.Dock = DockStyle.Fill;
            txtName.Location = new Point(101 , 3);
            txtName.Name = "txtName";
            txtName.Size = new Size(550 , 27);
            txtName.TabIndex = 3;
            // 
            // txtDescription
            // 
            txtDescription.Dock = DockStyle.Top;
            txtDescription.Location = new Point(101 , 36);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(550 , 27);
            txtDescription.TabIndex = 4;
            // 
            // txtCategory
            // 
            txtCategory.Dock = DockStyle.Fill;
            txtCategory.Location = new Point(101 , 69);
            txtCategory.Name = "txtCategory";
            txtCategory.Size = new Size(550 , 27);
            txtCategory.TabIndex = 5;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0 , 127);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1209 , 388);
            splitContainer1.SplitterDistance = 401;
            splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0 , 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(listBox1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer2.Size = new Size(401 , 388);
            splitContainer2.SplitterDistance = 333;
            splitContainer2.TabIndex = 0;
            // 
            // button2
            // 
            button2.Location = new Point(303 , 3);
            button2.Name = "button2";
            button2.Size = new Size(94 , 29);
            button2.TabIndex = 1;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(button1);
            flowLayoutPanel1.Controls.Add(button3);
            flowLayoutPanel1.Controls.Add(button4);
            flowLayoutPanel1.Controls.Add(button2);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(0 , 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(401 , 51);
            flowLayoutPanel1.TabIndex = 3;
            // 
            // button3
            // 
            button3.Location = new Point(103 , 3);
            button3.Name = "button3";
            button3.Size = new Size(94 , 29);
            button3.TabIndex = 2;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            button1.Location = new Point(3 , 3);
            button1.Name = "button1";
            button1.Size = new Size(94 , 29);
            button1.TabIndex = 0;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Right;
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(251 , 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(150 , 333);
            listBox1.TabIndex = 3;
            // 
            // button4
            // 
            button4.Location = new Point(203 , 3);
            button4.Name = "button4";
            button4.Size = new Size(94 , 29);
            button4.TabIndex = 3;
            button4.Text = "button4";
            button4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Location = new Point(532 , 483);
            panel1.Name = "panel1";
            panel1.Size = new Size(250 , 32);
            panel1.TabIndex = 2;
            // 
            // QuizEditorForm
            // 
            AutoScaleDimensions = new SizeF(8F , 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1209 , 515);
            Controls.Add(panel1);
            Controls.Add(splitContainer1);
            Controls.Add(groupBox1);
            Name = "QuizEditorForm";
            Text = " ";
            groupBox1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
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
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private ListBox listBox1;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button button1;
        private Button button3;
        private Button button4;
        private Button button2;
        private Panel panel1;
    }
}