namespace SudentManagementSystem
{
    partial class Schedules
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
            Export_grid = new Button();
            button2 = new Button();
            dateTimePicker2 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker1 = new DateTimePicker();
            lebel = new Label();
            label1 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // Export_grid
            // 
            Export_grid.BackColor = Color.LightGray;
            Export_grid.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Export_grid.Location = new Point(804, 132);
            Export_grid.Margin = new Padding(0);
            Export_grid.Name = "Export_grid";
            Export_grid.Size = new Size(102, 36);
            Export_grid.TabIndex = 71;
            Export_grid.Text = "Export";
            Export_grid.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            button2.Location = new Point(723, 132);
            button2.Name = "button2";
            button2.Size = new Size(75, 36);
            button2.TabIndex = 68;
            button2.Text = "Find";
            button2.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(402, 143);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(233, 25);
            dateTimePicker2.TabIndex = 67;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(402, 116);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(26, 15);
            label2.TabIndex = 66;
            label2.Text = "To :";
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(80, 143);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(233, 25);
            dateTimePicker1.TabIndex = 65;
            // 
            // lebel
            // 
            lebel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lebel.AutoSize = true;
            lebel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lebel.Location = new Point(80, 116);
            lebel.Name = "lebel";
            lebel.RightToLeft = RightToLeft.No;
            lebel.Size = new Size(42, 15);
            lebel.TabIndex = 63;
            lebel.Text = "From :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(416, 9);
            label1.Name = "label1";
            label1.Size = new Size(144, 37);
            label1.TabIndex = 62;
            label1.Text = "Schedules";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // button1
            // 
            button1.Location = new Point(468, 488);
            button1.Name = "button1";
            button1.Size = new Size(75, 36);
            button1.TabIndex = 61;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(80, 203);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 27;
            dataGridView1.Size = new Size(823, 279);
            dataGridView1.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.Location = new Point(80, 55);
            label4.Name = "label4";
            label4.Size = new Size(81, 28);
            label4.TabIndex = 64;
            label4.Text = "Filters :";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // Schedules
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1006, 583);
            Controls.Add(Export_grid);
            Controls.Add(button2);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(label4);
            Controls.Add(lebel);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Schedules";
            Text = "Schedules";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Export_grid;
        private Button button2;
        private DateTimePicker dateTimePicker2;
        private Label label2;
        private DateTimePicker dateTimePicker1;
        private Label lebel;
        private Label label1;
        private Button button1;
        private DataGridView dataGridView1;
        private Label label4;
    }
}