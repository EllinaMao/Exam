namespace QuizFoms
{
    partial class QuizEditMainForm
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
            qiuzList = new ListBox();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnExit = new Button();
            bthDelete = new Button();
            bthEddit = new Button();
            btnAdd = new Button();
            menuStrip1 = new MenuStrip();
            filesToolStripMenuItem = new ToolStripMenuItem();
            saveToFileToolStripMenuItem = new ToolStripMenuItem();
            loadFromFileToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(qiuzList);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(flowLayoutPanel1);
            splitContainer1.Size = new Size(800, 426);
            splitContainer1.SplitterDistance = 387;
            splitContainer1.TabIndex = 1;
            // 
            // qiuzList
            // 
            qiuzList.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            qiuzList.FormattingEnabled = true;
            qiuzList.ItemHeight = 15;
            qiuzList.Location = new Point(209, 0);
            qiuzList.Name = "qiuzList";
            qiuzList.Size = new Size(365, 394);
            qiuzList.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.BackColor = SystemColors.Control;
            flowLayoutPanel1.Controls.Add(btnExit);
            flowLayoutPanel1.Controls.Add(bthDelete);
            flowLayoutPanel1.Controls.Add(bthEddit);
            flowLayoutPanel1.Controls.Add(btnAdd);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(800, 35);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // btnExit
            // 
            btnExit.Location = new Point(722, 3);
            btnExit.Name = "btnExit";
            btnExit.Size = new Size(75, 23);
            btnExit.TabIndex = 0;
            btnExit.Text = "Выйти";
            btnExit.UseVisualStyleBackColor = true;
            btnExit.Click += saveToFileToolStripMenuItem_Click;
            btnExit.Click += btnExit_Click;

            // 
            // bthDelete
            // 
            bthDelete.Location = new Point(641, 3);
            bthDelete.Name = "bthDelete";
            bthDelete.Size = new Size(75, 23);
            bthDelete.TabIndex = 1;
            bthDelete.Text = "➖";
            bthDelete.UseVisualStyleBackColor = true;
            bthDelete.Click += bthDelete_Click;
            // 
            // bthEddit
            // 
            bthEddit.Location = new Point(560, 3);
            bthEddit.Name = "bthEddit";
            bthEddit.Size = new Size(75, 23);
            bthEddit.TabIndex = 3;
            bthEddit.Text = "✏";
            bthEddit.UseVisualStyleBackColor = true;
            bthEddit.Click += bthEddit_Click;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(479, 3);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 2;
            btnAdd.Text = "➕";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { filesToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // filesToolStripMenuItem
            // 
            filesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { saveToFileToolStripMenuItem, loadFromFileToolStripMenuItem });
            filesToolStripMenuItem.Name = "filesToolStripMenuItem";
            filesToolStripMenuItem.Size = new Size(57, 20);
            filesToolStripMenuItem.Text = "Файлы";
            // 
            // saveToFileToolStripMenuItem
            // 
            saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            saveToFileToolStripMenuItem.Size = new Size(180, 22);
            saveToFileToolStripMenuItem.Text = "Сохранить в файл";
            saveToFileToolStripMenuItem.Click += saveToFileToolStripMenuItem_Click;
            // 
            // loadFromFileToolStripMenuItem
            // 
            loadFromFileToolStripMenuItem.Name = "loadFromFileToolStripMenuItem";
            loadFromFileToolStripMenuItem.Size = new Size(180, 22);
            loadFromFileToolStripMenuItem.Text = "Загрузить с файла";
            loadFromFileToolStripMenuItem.Click += loadFromFileToolStripMenuItem_Click;
            // 
            // QuizEditMainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "QuizEditMainForm";
            Text = "pl";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private SplitContainer splitContainer1;
        private ListBox qiuzList;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnExit;
        private Button bthDelete;
        private Button btnAdd;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem filesToolStripMenuItem;
        private ToolStripMenuItem saveToFileToolStripMenuItem;
        private ToolStripMenuItem loadFromFileToolStripMenuItem;
        private Button bthEddit;
    }
}