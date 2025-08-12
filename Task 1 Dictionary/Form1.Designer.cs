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
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            listBoxWords = new ListBox();
            listBoxTranslations = new ListBox();
            panelButtons = new TableLayoutPanel();
            addNew = new Button();
            change = new Button();
            remove = new Button();
            saveToFile = new Button();
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
            panelButtons.Controls.Add(addNew , 0 , 0);
            panelButtons.Controls.Add(change , 0 , 1);
            panelButtons.Controls.Add(remove , 0 , 2);
            panelButtons.Controls.Add(saveToFile , 0 , 3);
            panelButtons.Dock = DockStyle.Fill;
            panelButtons.Location = new Point(0 , 0);
            panelButtons.Name = "panelButtons";
            panelButtons.RowCount = 4;
            panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent , 46.0606079F));
            panelButtons.RowStyles.Add(new RowStyle(SizeType.Percent , 53.9393921F));
            panelButtons.RowStyles.Add(new RowStyle(SizeType.Absolute , 132F));
            panelButtons.RowStyles.Add(new RowStyle(SizeType.Absolute , 121F));
            panelButtons.Size = new Size(159 , 572);
            panelButtons.TabIndex = 9;
            panelButtons.Visible = false;
            panelButtons.Paint += tableLayoutPanel1_Paint;
            // 
            // addNew
            // 
            addNew.Dock = DockStyle.Fill;
            addNew.Location = new Point(3 , 3);
            addNew.Name = "addNew";
            addNew.Size = new Size(153 , 140);
            addNew.TabIndex = 0;
            addNew.Text = "Add";
            addNew.UseVisualStyleBackColor = true;
            // 
            // change
            // 
            change.Dock = DockStyle.Fill;
            change.Location = new Point(3 , 149);
            change.Name = "change";
            change.Size = new Size(153 , 166);
            change.TabIndex = 1;
            change.Text = "Change";
            change.UseVisualStyleBackColor = true;
            // 
            // remove
            // 
            remove.Dock = DockStyle.Fill;
            remove.Location = new Point(3 , 321);
            remove.Name = "remove";
            remove.Size = new Size(153 , 126);
            remove.TabIndex = 2;
            remove.Text = "Remove";
            remove.UseVisualStyleBackColor = true;
            // 
            // saveToFile
            // 
            saveToFile.Dock = DockStyle.Fill;
            saveToFile.Location = new Point(3 , 453);
            saveToFile.Name = "saveToFile";
            saveToFile.Size = new Size(153 , 116);
            saveToFile.TabIndex = 3;
            saveToFile.Text = "Save to file";
            saveToFile.UseVisualStyleBackColor = false;
            saveToFile.Visible = false;
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
    }
}
