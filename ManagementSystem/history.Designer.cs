namespace SudentManagementSystem
{
    partial class history
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
            button1 = new Button();
            label1 = new Label();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            lebel = new Label();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            button2 = new Button();
            customercodelbl = new Label();
            label5 = new Label();
            Export_grid = new Button();

            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();

            // --- Form ---
            BackColor = Color.WhiteSmoke;
            Font = new Font("Segoe UI", 10F, FontStyle.Regular);
            WindowState = FormWindowState.Maximized; // Full Screen
            Text = "Customer History";

            // --- Title Label ---
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 28F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(30, 30, 30);
            label1.Location = new Point(400, 10);
            label1.Text = "Customer History";

            // --- Filters Label ---
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            label4.ForeColor = Color.FromArgb(30, 30, 30);
            label4.Location = new Point(50, 60);
            label4.Text = "Filters :";

            // --- From Label ---
            lebel.AutoSize = true;
            lebel.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            lebel.ForeColor = Color.FromArgb(60, 60, 60);
            lebel.Location = new Point(50, 100);
            lebel.Text = "From:";

            // --- To Label ---
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            label2.ForeColor = Color.FromArgb(60, 60, 60);
            label2.Location = new Point(350, 100);
            label2.Text = "To:";

            // --- DateTimePickers ---
            dateTimePicker1.Location = new Point(50, 125);
            dateTimePicker1.Width = 250;
            dateTimePicker1.Format = DateTimePickerFormat.Short;

            dateTimePicker2.Location = new Point(350, 125);
            dateTimePicker2.Width = 250;
            dateTimePicker2.Format = DateTimePickerFormat.Short;

            // --- Find Button ---
            button2.Text = "Find";
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button2.BackColor = Color.FromArgb(0, 120, 215);
            button2.ForeColor = Color.White;
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.Size = new Size(100, 35);
            button2.Location = new Point(630, 125);
            button2.Click += button2_Click;

            // --- Customer Code Label ---
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            label5.ForeColor = Color.FromArgb(30, 30, 30);
            label5.Location = new Point(770, 60);
            label5.Text = "Customer Code:";

            customercodelbl.AutoSize = true;
            customercodelbl.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            customercodelbl.ForeColor = Color.FromArgb(0, 120, 215);
            customercodelbl.Location = new Point(950, 60);
            customercodelbl.Text = " ";

            // --- Export Button ---
            Export_grid.Text = "Export";
            Export_grid.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            Export_grid.BackColor = Color.FromArgb(0, 150, 136);
            Export_grid.ForeColor = Color.White;
            Export_grid.FlatStyle = FlatStyle.Flat;
            Export_grid.FlatAppearance.BorderSize = 0;
            Export_grid.Size = new Size(100, 35);
            Export_grid.Location = new Point(760, 125);
            Export_grid.Click += Export_grid_Click;

            // --- Cancel Button ---
            button1.Text = "Cancel";
            button1.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            button1.BackColor = Color.FromArgb(232, 17, 35);
            button1.ForeColor = Color.White;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.Size = new Size(100, 35);
            button1.Location = new Point(1100, 540);
            button1.Click += button1_Click;

            // --- DataGridView ---
            dataGridView1.Location = new Point(50, 180);
            dataGridView1.Size = new Size(1150, 340);
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.ForeColor = Color.Black;
            dataGridView1.GridColor = Color.LightGray;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(240, 240, 240);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.RowTemplate.Height = 30;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.MultiSelect = false;
            dataGridView1.BorderStyle = BorderStyle.FixedSingle;

            // --- Add Controls ---
            Controls.Add(label1);
            Controls.Add(label4);
            Controls.Add(lebel);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(dateTimePicker2);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(customercodelbl);
            Controls.Add(Export_grid);
            Controls.Add(button1);
            Controls.Add(dataGridView1);

            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Label label1;
        private DataGridView dataGridView1;
        private Label label4;
        private Label lebel;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private Button button2;
        private Label customercodelbl;
        private Label label5;
        private Button Export_grid;
    }
}
