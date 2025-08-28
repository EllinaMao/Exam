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
            menuStrip1 = new MenuStrip();
            saveToFileToolStripMenuItem = new ToolStripMenuItem();
            создатьНовуюВикторинуToolStripMenuItem = new ToolStripMenuItem();
            сохранитьToolStripMenuItem = new ToolStripMenuItem();
            выходToolStripMenuItem = new ToolStripMenuItem();
            splitContainer1 = new SplitContainer();
            qiuzList = new ListBox();
            tableButtons = new TableLayoutPanel();
            edditButton = new Button();
            addButton = new Button();
            label1 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            tableButtons.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20 , 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { saveToFileToolStripMenuItem });
            menuStrip1.Location = new Point(0 , 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(7 , 3 , 0 , 3);
            menuStrip1.Size = new Size(914 , 30);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // saveToFileToolStripMenuItem
            // 
            saveToFileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { создатьНовуюВикторинуToolStripMenuItem , сохранитьToolStripMenuItem , выходToolStripMenuItem });
            saveToFileToolStripMenuItem.Name = "saveToFileToolStripMenuItem";
            saveToFileToolStripMenuItem.Size = new Size(70 , 24);
            saveToFileToolStripMenuItem.Text = "Файлы";
            // 
            // создатьНовуюВикторинуToolStripMenuItem
            // 
            создатьНовуюВикторинуToolStripMenuItem.Name = "создатьНовуюВикторинуToolStripMenuItem";
            создатьНовуюВикторинуToolStripMenuItem.Size = new Size(273 , 26);
            создатьНовуюВикторинуToolStripMenuItem.Text = "Создать новую викторину";
            // 
            // сохранитьToolStripMenuItem
            // 
            сохранитьToolStripMenuItem.Name = "сохранитьToolStripMenuItem";
            сохранитьToolStripMenuItem.Size = new Size(273 , 26);
            сохранитьToolStripMenuItem.Text = "Сохранить";
            // 
            // выходToolStripMenuItem
            // 
            выходToolStripMenuItem.Name = "выходToolStripMenuItem";
            выходToolStripMenuItem.Size = new Size(273 , 26);
            выходToolStripMenuItem.Text = "Выход";
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0 , 30);
            splitContainer1.Margin = new Padding(3 , 4 , 3 , 4);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label1);
            splitContainer1.Panel1.Controls.Add(qiuzList);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel1);
            splitContainer1.Panel2.Controls.Add(tableButtons);
            splitContainer1.Size = new Size(914 , 570);
            splitContainer1.SplitterDistance = 730;
            splitContainer1.SplitterWidth = 5;
            splitContainer1.TabIndex = 1;
            // 
            // qiuzList
            // 
            qiuzList.Dock = DockStyle.Fill;
            qiuzList.FormattingEnabled = true;
            qiuzList.Location = new Point(0 , 0);
            qiuzList.Margin = new Padding(3 , 4 , 3 , 4);
            qiuzList.Name = "qiuzList";
            qiuzList.Size = new Size(730 , 570);
            qiuzList.TabIndex = 0;
            // 
            // tableButtons
            // 
            tableButtons.ColumnCount = 1;
            tableButtons.ColumnStyles.Add(new ColumnStyle(SizeType.Percent , 50F));
            tableButtons.Controls.Add(edditButton , 0 , 1);
            tableButtons.Controls.Add(addButton , 0 , 0);
            tableButtons.Dock = DockStyle.Top;
            tableButtons.Location = new Point(0 , 0);
            tableButtons.Margin = new Padding(3 , 4 , 3 , 4);
            tableButtons.Name = "tableButtons";
            tableButtons.RowCount = 2;
            tableButtons.RowStyles.Add(new RowStyle(SizeType.Percent , 51.17371F));
            tableButtons.RowStyles.Add(new RowStyle(SizeType.Percent , 48.82629F));
            tableButtons.Size = new Size(179 , 123);
            tableButtons.TabIndex = 0;
            // 
            // edditButton
            // 
            edditButton.BackColor = Color.White;
            edditButton.Dock = DockStyle.Fill;
            edditButton.FlatAppearance.BorderSize = 0;
            edditButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128 , 128 , 255);
            edditButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192 , 192 , 255);
            edditButton.FlatStyle = FlatStyle.Flat;
            edditButton.Font = new Font("Tahoma" , 12F , FontStyle.Bold);
            edditButton.Location = new Point(3 , 66);
            edditButton.Margin = new Padding(3 , 4 , 3 , 4);
            edditButton.Name = "edditButton";
            edditButton.Size = new Size(173 , 53);
            edditButton.TabIndex = 2;
            edditButton.Text = "Редактировать";
            edditButton.UseVisualStyleBackColor = false;
            // 
            // addButton
            // 
            addButton.BackColor = Color.White;
            addButton.Dock = DockStyle.Fill;
            addButton.FlatAppearance.BorderSize = 0;
            addButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(128 , 128 , 255);
            addButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(192 , 192 , 255);
            addButton.FlatStyle = FlatStyle.Flat;
            addButton.Font = new Font("Tahoma" , 12F , FontStyle.Bold);
            addButton.Location = new Point(3 , 4);
            addButton.Margin = new Padding(3 , 4 , 3 , 4);
            addButton.Name = "addButton";
            addButton.Size = new Size(173 , 54);
            addButton.TabIndex = 1;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(677 , 550);
            label1.Name = "label1";
            label1.Size = new Size(50 , 20);
            label1.TabIndex = 1;
            label1.Text = "label1";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent , 100F));
            tableLayoutPanel1.Controls.Add(button1 , 0 , 1);
            tableLayoutPanel1.Controls.Add(button2 , 0 , 0);
            tableLayoutPanel1.Dock = DockStyle.Bottom;
            tableLayoutPanel1.Location = new Point(0 , 451);
            tableLayoutPanel1.Margin = new Padding(3 , 4 , 3 , 4);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent , 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent , 50F));
            tableLayoutPanel1.Size = new Size(179 , 119);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.BackColor = Color.White;
            button1.Dock = DockStyle.Fill;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = Color.FromArgb(128 , 128 , 255);
            button1.FlatAppearance.MouseOverBackColor = Color.FromArgb(192 , 192 , 255);
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Tahoma" , 12F , FontStyle.Bold);
            button1.Location = new Point(3 , 63);
            button1.Margin = new Padding(3 , 4 , 3 , 4);
            button1.Name = "button1";
            button1.Size = new Size(173 , 52);
            button1.TabIndex = 2;
            button1.Text = "Отмена";
            button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.BackColor = Color.White;
            button2.Dock = DockStyle.Fill;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = Color.FromArgb(128 , 128 , 255);
            button2.FlatAppearance.MouseOverBackColor = Color.FromArgb(192 , 192 , 255);
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Tahoma" , 12F , FontStyle.Bold);
            button2.Location = new Point(3 , 4);
            button2.Margin = new Padding(3 , 4 , 3 , 4);
            button2.Name = "button2";
            button2.Size = new Size(173 , 51);
            button2.TabIndex = 1;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F , 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Wheat;
            ClientSize = new Size(914 , 600);
            Controls.Add(splitContainer1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(3 , 4 , 3 , 4);
            Name = "Form1";
            Text = "pl";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            tableButtons.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private SplitContainer splitContainer1;
        private ListBox qiuzList;
        private TableLayoutPanel tableButtons;
        private ToolStripMenuItem saveToFileToolStripMenuItem;
        private Button edditButton;
        private Button addButton;
        private ToolStripMenuItem создатьНовуюВикторинуToolStripMenuItem;
        private ToolStripMenuItem сохранитьToolStripMenuItem;
        private ToolStripMenuItem выходToolStripMenuItem;
        private Label label1;
        private TableLayoutPanel tableLayoutPanel1;
        private Button button1;
        private Button button2;
    }
}