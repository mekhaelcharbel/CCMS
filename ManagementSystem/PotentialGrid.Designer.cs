namespace SudentManagementSystem
{
    partial class PotentialGrid
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
            TextBox txtSearch = new TextBox();
            dataGridView1 = new DataGridView();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // 
            // FORM
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1200, 650);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Potential Customers";

            // 
            // label1 (Title)
            // 
            label1.AutoSize = false;
            label1.Dock = DockStyle.Top;
            label1.Height = 80;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold, GraphicsUnit.Point);
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "Potential Customers";
            label1.ForeColor = Color.FromArgb(33, 37, 41);
            ////
            // 
            // txtSearch (Live Customer Filter)
            // 
            txtSearch.PlaceholderText = "Search Customer Name...";
            txtSearch.Location = new Point(40, 70);
            txtSearch.Size = new Size(300, 30);
            txtSearch.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            txtSearch.TextChanged += txtSearch_TextChanged;

            Controls.Add(txtSearch);
            // 
            // dataGridView1 (Modern Grid)
            // 
            dataGridView1.Location = new Point(40, 100);
            dataGridView1.Size = new Size(1120, 460);
            dataGridView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;

            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            dataGridView1.RowTemplate.Height = 35;

            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.FromArgb(230, 230, 230);

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersHeight = 45;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(0, 120, 215);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font =
                new Font("Segoe UI", 10F, FontStyle.Bold);

            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(204, 228, 247);
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;

            dataGridView1.RowHeadersVisible = false;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;

            // 
            // button1 (Exit)
            // 
            button1.Size = new Size(150, 40);
            button1.Location = new Point((ClientSize.Width / 2) - 75, 580);
            button1.Anchor = AnchorStyles.Bottom;
            button1.Text = "Exit";
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = Color.FromArgb(220, 53, 69);
            button1.ForeColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.Click += button1_Click;

            // 
            // Controls
            // 
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(dataGridView1);

            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private Label label1;
        private Button button1;
    }
}
