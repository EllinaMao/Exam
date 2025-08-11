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
            Eddit = new ToolStripMenuItem();
            addWordToolStripMenuItem = new ToolStripMenuItem();
            addNewWordToolStripMenuItem = new ToolStripMenuItem();
            addTranslationToolStripMenuItem = new ToolStripMenuItem();
            findWordFToolStripMenuItem = new ToolStripMenuItem();
            replaceWordToolStripMenuItem = new ToolStripMenuItem();
            replaceWordToolStripMenuItem1 = new ToolStripMenuItem();
            replaceTranslationToolStripMenuItem = new ToolStripMenuItem();
            listBoxWords = new ListBox();
            listBoxTranslations = new ListBox();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20 , 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1 , Eddit });
            menuStrip1.Location = new Point(0 , 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(914 , 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem , saveFileToolStripMenuItem });
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(52 , 24);
            toolStripMenuItem1.Text = "Files";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(153 , 26);
            openFileToolStripMenuItem.Text = "Open file";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(153 , 26);
            saveFileToolStripMenuItem.Text = "Save File";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // Eddit
            // 
            Eddit.DropDownItems.AddRange(new ToolStripItem[] { addWordToolStripMenuItem , findWordFToolStripMenuItem , replaceWordToolStripMenuItem });
            Eddit.Name = "Eddit";
            Eddit.Size = new Size(58 , 24);
            Eddit.Text = "Eddit";
            Eddit.Click += toolStripMenuItem2_Click;
            // 
            // addWordToolStripMenuItem
            // 
            addWordToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { addNewWordToolStripMenuItem , addTranslationToolStripMenuItem });
            addWordToolStripMenuItem.Name = "addWordToolStripMenuItem";
            addWordToolStripMenuItem.Size = new Size(224 , 26);
            addWordToolStripMenuItem.Text = "AddWord";
            // 
            // addNewWordToolStripMenuItem
            // 
            addNewWordToolStripMenuItem.Name = "addNewWordToolStripMenuItem";
            addNewWordToolStripMenuItem.Size = new Size(224 , 26);
            addNewWordToolStripMenuItem.Text = "Add new word";
            addNewWordToolStripMenuItem.Click += addNewWordToolStripMenuItem_Click;
            // 
            // addTranslationToolStripMenuItem
            // 
            addTranslationToolStripMenuItem.Name = "addTranslationToolStripMenuItem";
            addTranslationToolStripMenuItem.Size = new Size(224 , 26);
            addTranslationToolStripMenuItem.Text = "Add translation";
            addTranslationToolStripMenuItem.Click += addTranslationToolStripMenuItem_Click;
            // 
            // findWordFToolStripMenuItem
            // 
            findWordFToolStripMenuItem.Name = "findWordFToolStripMenuItem";
            findWordFToolStripMenuItem.Size = new Size(224 , 26);
            findWordFToolStripMenuItem.Text = "Find Word";
            findWordFToolStripMenuItem.Click += findWordFToolStripMenuItem_Click;
            // 
            // replaceWordToolStripMenuItem
            // 
            replaceWordToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { replaceWordToolStripMenuItem1 , replaceTranslationToolStripMenuItem });
            replaceWordToolStripMenuItem.Name = "replaceWordToolStripMenuItem";
            replaceWordToolStripMenuItem.Size = new Size(224 , 26);
            replaceWordToolStripMenuItem.Text = "Replace Word";
            // 
            // replaceWordToolStripMenuItem1
            // 
            replaceWordToolStripMenuItem1.Name = "replaceWordToolStripMenuItem1";
            replaceWordToolStripMenuItem1.Size = new Size(219 , 26);
            replaceWordToolStripMenuItem1.Text = "Replace word";
            replaceWordToolStripMenuItem1.Click += replaceWordToolStripMenuItem1_Click;
            // 
            // replaceTranslationToolStripMenuItem
            // 
            replaceTranslationToolStripMenuItem.Name = "replaceTranslationToolStripMenuItem";
            replaceTranslationToolStripMenuItem.Size = new Size(219 , 26);
            replaceTranslationToolStripMenuItem.Text = "Replace translation";
            // 
            // listBoxWords
            // 
            listBoxWords.BorderStyle = BorderStyle.None;
            listBoxWords.Dock = DockStyle.Left;
            listBoxWords.FormattingEnabled = true;
            listBoxWords.Location = new Point(0 , 28);
            listBoxWords.Name = "listBoxWords";
            listBoxWords.Size = new Size(189 , 572);
            listBoxWords.TabIndex = 1;
            // 
            // listBoxTranslations
            // 
            listBoxTranslations.BorderStyle = BorderStyle.None;
            listBoxTranslations.Dock = DockStyle.Left;
            listBoxTranslations.FormattingEnabled = true;
            listBoxTranslations.Location = new Point(189 , 28);
            listBoxTranslations.Name = "listBoxTranslations";
            listBoxTranslations.Size = new Size(719 , 572);
            listBoxTranslations.TabIndex = 2;
            listBoxTranslations.SelectedIndexChanged += listBoxTranslations_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F , 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914 , 600);
            Controls.Add(listBoxTranslations);
            Controls.Add(listBoxWords);
            Controls.Add(menuStrip1);
            Margin = new Padding(3 , 4 , 3 , 4);
            Name = "Form1";
            Text = "Form1";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ListBox listBoxWords;
        private ListBox listBoxTranslations;
        private ToolStripMenuItem Eddit;
        private ToolStripMenuItem addWordToolStripMenuItem;
        private ToolStripMenuItem findWordFToolStripMenuItem;
        private ToolStripMenuItem replaceWordToolStripMenuItem;
        private ToolStripMenuItem replaceWordToolStripMenuItem1;
        private ToolStripMenuItem replaceTranslationToolStripMenuItem;
        private ToolStripMenuItem addNewWordToolStripMenuItem;
        private ToolStripMenuItem addTranslationToolStripMenuItem;
    }
}
