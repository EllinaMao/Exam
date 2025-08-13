namespace Task_1_Dictionary
{
    partial class Form1
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
            menuStrip1 = new MenuStrip();
            toolStripMenuItem1 = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            CreateNewFileToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            listBoxWords = new ListBox();
            listBoxTranslations = new ListBox();
            panelButtons = new TableLayoutPanel();
            saveToFile = new Button();
            addNew = new Button();
            change = new Button();
            remove = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            panelButtons.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20 , 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 });
            menuStrip1.Location = new Point(0 , 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(914 , 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem , saveFileToolStripMenuItem , CreateNewFileToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(70 , 24);
            toolStripMenuItem1.Text = "Файлы";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.O;
            openFileToolStripMenuItem.Size = new Size(289 , 26);
            openFileToolStripMenuItem.Text = "Открыть файл";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.S;
            saveFileToolStripMenuItem.Size = new Size(289 , 26);
            saveFileToolStripMenuItem.Text = "Сохранить файл";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // CreateNewFileToolStripMenuItem
            // 
            CreateNewFileToolStripMenuItem.Name = "CreateNewFileToolStripMenuItem";
            CreateNewFileToolStripMenuItem.ShortcutKeys = Keys.Control | Keys.N;
            CreateNewFileToolStripMenuItem.Size = new Size(289 , 26);
            CreateNewFileToolStripMenuItem.Text = "Создать новый файл";
            CreateNewFileToolStripMenuItem.Click += createNewFileToolStripMenuItem_Click;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0 , 28);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(panelButtons);
            splitContainer1.Size = new Size(914 , 572);
            splitContainer1.SplitterDistance = 751;
            splitContainer1.TabIndex = 3;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0 , 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(listBoxWords);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(listBoxTranslations);
            splitContainer2.Size = new Size(751 , 572);
            splitContainer2.SplitterDistance = 185;
            splitContainer2.TabIndex = 8;
            // 
            // listBoxWords
            // 
            listBoxWords.BorderStyle = BorderStyle.None;
            listBoxWords.Dock = DockStyle.Fill;
            listBoxWords.FormattingEnabled = true;
            listBoxWords.Location = new Point(0 , 0);
            listBoxWords.Name = "listBoxWords";
            listBoxWords.Size = new Size(185 , 572);
            listBoxWords.TabIndex = 5;
            // 
            // listBoxTranslations
            // 
            listBoxTranslations.BorderStyle = BorderStyle.None;
            listBoxTranslations.Dock = DockStyle.Fill;
            listBoxTranslations.FormattingEnabled = true;
            listBoxTranslations.Location = new Point(0 , 0);
            listBoxTranslations.Name = "listBoxTranslations";
            listBoxTranslations.Size = new Size(562 , 572);
            listBoxTranslations.TabIndex = 7;
            // 
            // panelButtons
            // 
            panelButtons.ColumnCount = 1;
            panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent , 50F));
            panelButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent , 50F));
            panelButtons.Controls.Add(saveToFile , 0 , 3);
            panelButtons.Controls.Add(addNew , 0 , 0);
            panelButtons.Controls.Add(change , 0 , 1);
            panelButtons.Controls.Add(remove , 0 , 2);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(0 , 0);
            panelButtons.Name = "panelButtons";
            panelButtons.RowCount = 4;
            panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent , 30.9927368F));
            panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent , 33.0561333F));
            panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent , 35.9667358F));
            panelButtons.RowStyles.Add(new RowStyle(SizeType.Absolute , 125F));
            panelButtons.Size = new Size(159 , 572);
            panelButtons.TabIndex = 9;
            panelButtons.Visible = false;
            // 
            // saveToFile
            // 
            saveToFile.Dock = DockStyle.Fill;
            saveToFile.FlatStyle = FlatStyle.Flat;
            saveToFile.Location = new Point(3 , 448);
            saveToFile.Name = "saveToFile";
            saveToFile.Size = new Size(153 , 121);
            saveToFile.TabIndex = 3;
            saveToFile.Text = "Экспортировать слово в файл";
            saveToFile.UseVisualStyleBackColor = true;
            saveToFile.Click += saveToFile_Click;
            // 
            // addNew
            // 
            addNew.Dock = DockStyle.Fill;
            addNew.FlatStyle = FlatStyle.Flat;
            addNew.Location = new Point(3 , 3);
            addNew.Name = "addNew";
            addNew.Size = new Size(153 , 132);
            addNew.TabIndex = 0;
            addNew.Text = "Добавить";
            addNew.UseVisualStyleBackColor = true;
            addNew.Click += addNew_Click;
            // 
            // change
            // 
            change.Dock = DockStyle.Fill;
            change.FlatStyle = FlatStyle.Flat;
            change.Location = new Point(3 , 141);
            change.Name = "change";
            change.Size = new Size(153 , 141);
            change.TabIndex = 1;
            change.Text = "Изменить";
            change.UseVisualStyleBackColor = true;
            change.Click += change_Click;
            // 
            // remove
            // 
            remove.Dock = DockStyle.Fill;
            remove.FlatStyle = FlatStyle.Flat;
            remove.Location = new Point(3 , 288);
            remove.Name = "remove";
            remove.Size = new Size(153 , 154);
            remove.TabIndex = 2;
            remove.Text = "Удалить";
            remove.UseVisualStyleBackColor = true;
            remove.Click += remove_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F , 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914 , 600);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            Margin = new Padding(3 , 4 , 3 , 4);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            panelButtons.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private ListBox listBoxWords;
        private ListBox listBoxTranslations;
        private TableLayoutPanel panelButtons;
        private Button addNew;
        private Button change;
        private Button remove;
        private Button saveToFile;
        private ToolStripMenuItem CreateNewFileToolStripMenuItem;
    }
}
