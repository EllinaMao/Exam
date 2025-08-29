namespace QuizFoms
{
    partial class ResultsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private DataGridView dgvMyResults;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button btnClose;
        private Panel panel1;
        private Label label1;
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
            dgvMyResults = new DataGridView();
            flowLayoutPanel1 = new FlowLayoutPanel();
            btnClose = new Button();
            panel1 = new Panel();
            label1 = new Label();

            SuspendLayout();

            // panel1 - заголовок
            panel1.Controls.Add(label1);
            panel1.Dock = DockStyle.Top;
            panel1.Height = 40;
            label1.Text = "Мои результаты:";
            label1.AutoSize = true;
            label1.Location = new Point(10, 10);

            // dgvMyResults
            dgvMyResults.Dock = DockStyle.Fill;
            dgvMyResults.ReadOnly = true;
            dgvMyResults.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // flowLayoutPanel1 - кнопка закрытия
            flowLayoutPanel1.Dock = DockStyle.Bottom;
            flowLayoutPanel1.Height = 40;
            flowLayoutPanel1.FlowDirection = FlowDirection.RightToLeft;
            flowLayoutPanel1.Controls.Add(btnClose);

            // btnClose
            btnClose.Text = "Закрыть";
            btnClose.Size = new Size(75, 25);
            btnClose.Click += btnClose_Click;

            // MyResultsForm
            ClientSize = new Size(400, 300);
            Controls.Add(dgvMyResults);
            Controls.Add(flowLayoutPanel1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Text = "Мои результаты";
            StartPosition = FormStartPosition.CenterParent;

            ResumeLayout(false);
        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion
    }
}
