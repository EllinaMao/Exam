namespace QuizFoms
{
    partial class SettingsForm
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
            label1 = new Label();
            panel2 = new Panel();
            flowLayoutPanel1 = new FlowLayoutPanel();
            CanselBtn = new Button();
            saveBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            passwField = new TextBox();
            passwFieldConfirm = new TextBox();
            dateOfBitrhPick = new DateTimePicker();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            flowLayoutPanel1.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(334, 32);
            panel1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 9);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Настройки";
            // 
            // panel2
            // 
            panel2.Controls.Add(flowLayoutPanel1);
            panel2.Dock = DockStyle.Bottom;
            panel2.Location = new Point(0, 142);
            panel2.Name = "panel2";
            panel2.Size = new Size(334, 33);
            panel2.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.Controls.Add(CanselBtn);
            flowLayoutPanel1.Controls.Add(saveBtn);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Location = new Point(0, 0);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(334, 33);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // CanselBtn
            // 
            CanselBtn.Location = new Point(256, 3);
            CanselBtn.Name = "CanselBtn";
            CanselBtn.Size = new Size(75, 23);
            CanselBtn.TabIndex = 1;
            CanselBtn.Text = "Отмена";
            CanselBtn.UseVisualStyleBackColor = true;
            CanselBtn.Click += CanselBtn_Click;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(175, 3);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(75, 23);
            saveBtn.TabIndex = 0;
            saveBtn.Text = "Сохранить";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 41.91617F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 58.08383F));
            tableLayoutPanel1.Controls.Add(label2, 0, 0);
            tableLayoutPanel1.Controls.Add(label3, 0, 1);
            tableLayoutPanel1.Controls.Add(label4, 0, 2);
            tableLayoutPanel1.Controls.Add(passwField, 1, 0);
            tableLayoutPanel1.Controls.Add(passwFieldConfirm, 1, 1);
            tableLayoutPanel1.Controls.Add(dateOfBitrhPick, 1, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 32);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(334, 110);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(134, 36);
            label2.TabIndex = 1;
            label2.Text = "Новый пароль:";
            label2.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Location = new Point(3, 36);
            label3.Name = "label3";
            label3.Size = new Size(134, 36);
            label3.TabIndex = 2;
            label3.Text = "Подтвердить пароль:";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Location = new Point(3, 72);
            label4.Name = "label4";
            label4.Size = new Size(134, 38);
            label4.TabIndex = 3;
            label4.Text = "Дата рождения:";
            label4.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // passwField
            // 
            passwField.Dock = DockStyle.Fill;
            passwField.Font = new Font("Segoe UI", 11F);
            passwField.Location = new Point(143, 3);
            passwField.Name = "passwField";
            passwField.Size = new Size(188, 27);
            passwField.TabIndex = 4;
            // 
            // passwFieldConfirm
            // 
            passwFieldConfirm.Dock = DockStyle.Fill;
            passwFieldConfirm.Font = new Font("Segoe UI", 11F);
            passwFieldConfirm.Location = new Point(143, 39);
            passwFieldConfirm.Name = "passwFieldConfirm";
            passwFieldConfirm.Size = new Size(188, 27);
            passwFieldConfirm.TabIndex = 5;
            // 
            // dateOfBitrhPick
            // 
            dateOfBitrhPick.Dock = DockStyle.Fill;
            dateOfBitrhPick.Font = new Font("Segoe UI", 11F);
            dateOfBitrhPick.Location = new Point(143, 75);
            dateOfBitrhPick.Name = "dateOfBitrhPick";
            dateOfBitrhPick.Size = new Size(188, 27);
            dateOfBitrhPick.TabIndex = 6;
            // 
            // SettingsForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(334, 175);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SettingsForm";
            Text = "SettingsForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            flowLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label2;
        private Button saveBtn;
        private Button CanselBtn;
        private Label label3;
        private Label label4;
        private TextBox passwField;
        private TextBox passwFieldConfirm;
        private DateTimePicker dateOfBitrhPick;
    }
}