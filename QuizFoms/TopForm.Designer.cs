namespace QuizFoms
{
    partial class TopForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            flowLayoutPanelBottom = new FlowLayoutPanel();
            btnClose = new Button();
            panelTop = new Panel();
            lblTitle = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            lblQuiz = new Label();
            cbQuizzes = new ComboBox();
            dgvTopPlayers = new DataGridView();
            flowLayoutPanelBottom.SuspendLayout();
            panelTop.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopPlayers).BeginInit();
            SuspendLayout();
            // 
            // flowLayoutPanelBottom
            // 
            flowLayoutPanelBottom.Controls.Add(btnClose);
            flowLayoutPanelBottom.Dock = DockStyle.Bottom;
            flowLayoutPanelBottom.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanelBottom.Location = new Point(0, 419);
            flowLayoutPanelBottom.Name = "flowLayoutPanelBottom";
            flowLayoutPanelBottom.Size = new Size(400, 45);
            flowLayoutPanelBottom.TabIndex = 0;
            // 
            // btnClose
            // 
            btnClose.Location = new Point(322, 3);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(75, 23);
            btnClose.TabIndex = 0;
            btnClose.Text = "Закрыть";
            btnClose.UseVisualStyleBackColor = true;
            btnClose.Click += btnClose_Click;
            // 
            // panelTop
            // 
            panelTop.Controls.Add(lblTitle);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(400, 41);
            panelTop.TabIndex = 1;
            // 
            // lblTitle
            // 
            lblTitle.Dock = DockStyle.Fill;
            lblTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblTitle.Location = new Point(0, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(400, 41);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Топ-20 игроков";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel1.Controls.Add(lblQuiz, 0, 0);
            tableLayoutPanel1.Controls.Add(cbQuizzes, 1, 0);
            tableLayoutPanel1.Location = new Point(20, 50);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Size = new Size(360, 30);
            tableLayoutPanel1.TabIndex = 2;
            // 
            // lblQuiz
            // 
            lblQuiz.AutoSize = true;
            lblQuiz.Dock = DockStyle.Fill;
            lblQuiz.Location = new Point(3, 0);
            lblQuiz.Name = "lblQuiz";
            lblQuiz.Size = new Size(102, 30);
            lblQuiz.TabIndex = 0;
            lblQuiz.Text = "Викторина:";
            lblQuiz.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // cbQuizzes
            // 
            cbQuizzes.Dock = DockStyle.Fill;
            cbQuizzes.DropDownStyle = ComboBoxStyle.DropDownList;
            cbQuizzes.FormattingEnabled = true;
            cbQuizzes.Location = new Point(111, 3);
            cbQuizzes.Name = "cbQuizzes";
            cbQuizzes.Size = new Size(246, 23);
            cbQuizzes.TabIndex = 1;
            cbQuizzes.SelectedIndexChanged += cbQuizzes_SelectedIndexChanged;
            // 
            // dgvTopPlayers
            // 
            dgvTopPlayers.AllowUserToAddRows = false;
            dgvTopPlayers.AllowUserToDeleteRows = false;
            dgvTopPlayers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvTopPlayers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvTopPlayers.Location = new Point(20, 90);
            dgvTopPlayers.Name = "dgvTopPlayers";
            dgvTopPlayers.ReadOnly = true;
            dgvTopPlayers.Size = new Size(360, 320);
            dgvTopPlayers.TabIndex = 3;
            // 
            // TopForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 464);
            Controls.Add(dgvTopPlayers);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(panelTop);
            Controls.Add(flowLayoutPanelBottom);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "TopForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Топ игроков";
            flowLayoutPanelBottom.ResumeLayout(false);
            panelTop.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvTopPlayers).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private FlowLayoutPanel flowLayoutPanelBottom;
        private Button btnClose;
        private Panel panelTop;
        private Label lblTitle;
        private TableLayoutPanel tableLayoutPanel1;
        private Label lblQuiz;
        private ComboBox cbQuizzes;
        private DataGridView dgvTopPlayers;
    }
}
