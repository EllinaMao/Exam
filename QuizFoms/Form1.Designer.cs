namespace QuizFoms
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            splitContainer1 = new SplitContainer();
            qiuzList = new ListBox();
            tableButtons = new TableLayoutPanel();
            addButton = new Button();
            edditButton = new Button();
            deleteButton = new Button();
            saveToFileToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            создатьНовуюВикторинуToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableButtons.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { saveToFileToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 24);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(qiuzList);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableButtons);
            splitContainer1.Size = new Size(800, 426);
            splitContainer1.SplitterDistance = 639;
            splitContainer1.TabIndex = 1;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // qiuzList
            // 
            qiuzList.Dock = DockStyle.Fill;
            qiuzList.FormattingEnabled = true;
            qiuzList.ItemHeight = 15;
            qiuzList.Location = new Point(0, 0);
            qiuzList.Name = "qiuzList";
            qiuzList.Size = new Size(639, 426);
            qiuzList.TabIndex = 0;
            // 
            // tableButtons
            // 
            tableButtons.ColumnCount = 1;
            tableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableButtons.Controls.Add(deleteButton, 0, 2);
            tableButtons.Controls.Add(edditButton, 0, 1);
            tableButtons.Controls.Add(addButton, 0, 0);
            tableButtons.Dock = DockStyle.Top;
            tableButtons.Location = new Point(0, 0);
            tableButtons.Name = "tableButtons";
            tableButtons.RowCount = 3;
            tableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 51.17371F));
            tableButtons.RowStyles.Add(new RowStyle(SizeType.Percent, 48.82629F));
            tableButtons.RowStyles.Add(new RowStyle(SizeType.Absolute, 46F));
            tableButtons.Size = new Size(157, 143);
            tableButtons.TabIndex = 0;
            // 
            // addButton
            // 
            addButton.BackColor = Color.White;
            addButton.Dock = DockStyle.Fill;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            addButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            addButton.Location = new Point(3, 3);
            addButton.Name = "addButton";
            addButton.Size = new Size(151, 43);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            // 
            // edditButton
            // 
            edditButton.BackColor = Color.White;
            edditButton.Dock = DockStyle.Fill;
            edditButton.FlatAppearance.BorderSize = 0;
            edditButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            edditButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            edditButton.FlatStyle = FlatStyle.Flat;
            edditButton.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            edditButton.Location = new Point(3, 52);
            edditButton.Name = "edditButton";
            edditButton.Size = new Size(151, 41);
            edditButton.TabIndex = 2;
            edditButton.Text = "Редактировать";
            edditButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.White;
            deleteButton.Dock = DockStyle.Fill;
            deleteButton.FlatAppearance.BorderSize = 0;
            deleteButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128, 128, 255);
            deleteButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192, 192, 255);
            deleteButton.FlatStyle = FlatStyle.Flat;
            deleteButton.Font = new Font("Tahoma", 12F, FontStyle.Bold);
            deleteButton.Location = new Point(3, 99);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(151, 41);
            deleteButton.TabIndex = 3;
            deleteButton.Text = "Удалить";
            deleteButton.UseVisualStyleBackColor = false;
            // 
            // saveToFileToolStripMenuItem
            // 
            saveToFileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьНовуюВикторинуToolStripMenuItem, сохранитьToolStripMenuItem, выходToolStripMenuItem });
            saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            saveToFileToolStripMenuItem.Size = new Size(57, 20);
            saveToFileToolStripMenuItem.Text = "Файлы";
            saveToFileToolStripMenuItem.Click += saveToFileToolStripMenuItem_Click;
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(217, 22);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(217, 22);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // создатьНовуюВикторинуToolStripMenuItem
            // 
            создатьНовуюВикторинуToolStripMenuItem.Name = "создатьНовуюВикторинуToolStripMenuItem";
            создатьНовуюВикторинуToolStripMenuItem.Size = new Size(217, 22);
            создатьНовуюВикторинуToolStripMenuItem.Text = "Создать новую викторину";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(800, 450);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "pl";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private SplitContainer splitContainer1;
        private ListBox qiuzList;
        private TableLayoutPanel tableButtons;
        private ToolStripMenuItem saveToFileToolStripMenuItem;
        private Button deleteButton;
        private Button edditButton;
        private Button addButton;
        private ToolStripMenuItem создатьНовуюВикторинуToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
    }
}