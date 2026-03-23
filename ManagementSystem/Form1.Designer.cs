namespace SudentManagementSystem
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            label7 = new Label();
            customername = new TextBox();
            Exit = new Button();
            label1 = new Label();
            Mobile = new TextBox();
            label3 = new Label();
            lebel = new Label();
            Customercode = new TextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            label2 = new Label();
            dateTimePicker2 = new DateTimePicker();
            label4 = new Label();
            label5 = new Label();
            button2 = new Button();
            button3 = new Button();
            dataGridView1 = new DataGridView();
            salesman = new Label();
            _customercount = new Label();
            export_grid = new Button();
            button4 = new Button();
            button6 = new Button();
            button7 = new Button();
            label8 = new Label();
            Remark = new TextBox();
            label9 = new Label();
            RefreshGrid = new Button();
            Hide = new Button();
            label6 = new Label();
            callcycle = new TextBox();
            label10 = new Label(); 
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(33, 142);
            label7.Name = "label7";
            label7.Size = new Size(97, 15);
            label7.TabIndex = 39;
            label7.Text = "Customer Name";
            // 
            // customername
            // 
            customername.Location = new Point(35, 160);
            customername.Name = "customername";
            customername.RightToLeft = RightToLeft.No;
            customername.Size = new Size(201, 23);
            customername.TabIndex = 38;
            customername.TextChanged += CustomerName_TextChanged;
            // 
            // Exit
            // 
            Exit.BackColor = Color.LightGray;
            Exit.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Exit.Image = (Image)resources.GetObject("Exit.Image");
            Exit.Location = new Point(1257, 149);
            Exit.Margin = new Padding(0);
            Exit.Name = "Exit";
            Exit.Size = new Size(43, 34);
            Exit.TabIndex = 37;
            Exit.UseVisualStyleBackColor = false;
            Exit.Click += Exit_Click;
            Exit.MouseLeave += Exit_MouseLeave;
            Exit.MouseHover += Exit_MouseHover;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(64, 0, 64);
            label1.Location = new Point(456, 9);
            label1.Name = "label1";
            label1.Size = new Size(434, 37);
            label1.TabIndex = 31;
            label1.Text = "Management System";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // Mobile
            // 
            Mobile.Location = new Point(242, 98);
            Mobile.Name = "Mobile";
            Mobile.RightToLeft = RightToLeft.No;
            Mobile.Size = new Size(208, 23);
            Mobile.TabIndex = 19;
            Mobile.TextChanged += Mobile_TextChanged;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(242, 80);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(91, 15);
            label3.TabIndex = 25;
            label3.Text = "Phone Number";
            // 
            // lebel
            // 
            lebel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lebel.AutoSize = true;
            lebel.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            lebel.Location = new Point(33, 80);
            lebel.Name = "lebel";
            lebel.RightToLeft = RightToLeft.No;
            lebel.Size = new Size(89, 15);
            lebel.TabIndex = 23;
            lebel.Text = "CustomerCode";
            // 
            // Customercode
            // 
            Customercode.Location = new Point(33, 98);
            Customercode.Name = "Customercode";
            Customercode.RightToLeft = RightToLeft.No;
            Customercode.Size = new Size(203, 23);
            Customercode.TabIndex = 17;
            Customercode.TextChanged += CustomerCode_TextChanged;
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            button1.Location = new Point(1311, 76);
            button1.Name = "button1";
            button1.Size = new Size(31, 22);
            button1.TabIndex = 43;
            button1.Text = "✔\r\n";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(1097, 78);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(208, 23);
            dateTimePicker1.TabIndex = 44;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label2
            // 
            label2.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(456, 80);
            label2.Name = "label2";
            label2.RightToLeft = RightToLeft.No;
            label2.Size = new Size(88, 15);
            label2.TabIndex = 46;
            label2.Text = "Schedule Date";
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(456, 98);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(207, 23);
            dateTimePicker2.TabIndex = 47;
            dateTimePicker2.ValueChanged += dateTimePicker2_ValueChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = SystemColors.ControlDark;
            label4.Location = new Point(33, 18);
            label4.Name = "label4";
            label4.Size = new Size(81, 28);
            label4.TabIndex = 48;
            label4.Text = "Filters :";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(943, 80);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(148, 20);
            label5.TabIndex = 49;
            label5.Text = "Pick Schedule Date :";
            // 
            // button2
            // 
            button2.BackColor = Color.LightGray;
            button2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button2.Image = (Image)resources.GetObject("button2.Image");
            button2.Location = new Point(1205, 112);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(43, 35);
            button2.TabIndex = 51;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            button2.MouseLeave += button2_MouseLeave;
            button2.MouseHover += button2_MouseHover;
            // 
            // button3
            // 
            button3.BackColor = Color.LightGray;
            button3.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button3.Image = (Image)resources.GetObject("button3.Image");
            button3.Location = new Point(1205, 151);
            button3.Margin = new Padding(0);
            button3.Name = "button3";
            button3.Size = new Size(43, 32);
            button3.TabIndex = 52;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            button3.MouseLeave += button3_MouseLeave;
            button3.MouseHover += button3_MouseHover;
            // 
            // dataGridView1
            // 
            // Disable default header styles so we can customize
            dataGridView1.EnableHeadersVisualStyles = false;

            // Remove borders for a clean look
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.GridColor = Color.LightGray;

            // Header styling
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(52, 73, 94); // Dark header
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dataGridView1.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            dataGridView1.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;

            // Rows styling
            dataGridView1.RowsDefaultCellStyle.BackColor = Color.White;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(245, 245, 245); // Light gray
            dataGridView1.RowsDefaultCellStyle.ForeColor = Color.Black;
            dataGridView1.RowsDefaultCellStyle.Font = new Font("Segoe UI", 9);
            dataGridView1.DefaultCellStyle.Padding = new Padding(5);

            // Selection styling
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.FromArgb(41, 128, 185); // Blue selection
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;

            // Other functional settings
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToOrderColumns = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            dataGridView1.Cursor = Cursors.Hand;
            dataGridView1.Location = new Point(33, 200);
            dataGridView1.MultiSelect = false;
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(1296, 450);
            dataGridView1.StandardTab = true;
            dataGridView1.TabIndex = 42;

            dataGridView1.CellContentClick += dataGridView1_CellContentClick_1;
            dataGridView1.CellContentDoubleClick += dataGridView1_CellContentDoubleClick;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            dataGridView1.ColumnHeaderMouseClick += dataGridView1_ColumnHeaderMouseClick;
            // 
            // salesman
            // 
            salesman.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            salesman.AutoSize = true;
            salesman.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            salesman.ForeColor = Color.Purple;
            salesman.Location = new Point(1187, 17);
            salesman.Name = "salesman";
            salesman.RightToLeft = RightToLeft.No;
            salesman.Size = new Size(13, 20);
            salesman.TabIndex = 53;
            salesman.Text = " ";
            // 
            // _customercount
            // 
            _customercount.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            _customercount.AutoSize = true;
            _customercount.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            _customercount.ForeColor = Color.Purple;
            _customercount.Location = new Point(1272, 48);
            _customercount.Name = "_customercount";
            _customercount.RightToLeft = RightToLeft.No;
            _customercount.Size = new Size(0, 15);
            _customercount.TabIndex = 57;
            // 
            // export_grid
            // 
            export_grid.BackColor = Color.LightGray;
            export_grid.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            export_grid.Image = (Image)resources.GetObject("export_grid.Image");
            export_grid.Location = new Point(1300, 112);
            export_grid.Margin = new Padding(0);
            export_grid.Name = "export_grid";
            export_grid.Size = new Size(42, 35);
            export_grid.TabIndex = 58;
            export_grid.UseVisualStyleBackColor = false;
            export_grid.Click += export_grid_Click;
            export_grid.MouseLeave += export_grid_MouseLeave;
            export_grid.MouseHover += export_grid_MouseHover;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.Location = new Point(669, 155);
            button4.Name = "button4";
            button4.Size = new Size(34, 34);   // slightly bigger for modern look
            button4.TabIndex = 59;

            button4.FlatStyle = FlatStyle.Flat;
            button4.FlatAppearance.BorderSize = 0;
            button4.BackColor = Color.White;
            button4.Cursor = Cursors.Hand;

            button4.UseVisualStyleBackColor = false;

            button4.Click += button4_Click;

            button4.MouseLeave += button4_MouseLeave;
            button4.MouseHover += button4_MouseHover;
            // 
            // button6
            // 
            button6.BackColor = Color.LightGray;
            button6.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.Location = new Point(1163, 151);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.Size = new Size(38, 32);
            button6.TabIndex = 61;
            button6.UseVisualStyleBackColor = false;
            button6.Click += button6_Click;
            button6.MouseLeave += button6_MouseLeave;
            button6.MouseHover += button6_MouseHover;
            // 
            // button7
            // 
            button7.BackColor = Color.LightGray;
            button7.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.Location = new Point(1162, 113);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.Size = new Size(38, 34);
            button7.TabIndex = 62;
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            button7.MouseLeave += button7_MouseLeave;
            button7.MouseHover += button7_MouseHover;
            // 
            // label8
            // 
            label8.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label8.Location = new Point(1163, 48);
            label8.Name = "label8";
            label8.RightToLeft = RightToLeft.No;
            label8.Size = new Size(97, 15);
            label8.TabIndex = 56;
            label8.Text = "Total Customer :";
            // 
            // Remark
            // 
            Remark.Location = new Point(242, 160);
            Remark.Name = "Remark";
            Remark.RightToLeft = RightToLeft.No;
            Remark.Size = new Size(208, 23);
            Remark.TabIndex = 63;
            Remark.TextChanged += Remark_TextChanged;
            // 
            // label9
            // 
            label9.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label9.Location = new Point(242, 142);
            label9.Name = "label9";
            label9.RightToLeft = RightToLeft.No;
            label9.Size = new Size(54, 15);
            label9.TabIndex = 64;
            label9.Text = "Remark ";
            // 
            // RefreshGrid
            // 
            RefreshGrid.BackColor = Color.LightGray;
            RefreshGrid.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            RefreshGrid.Image = (Image)resources.GetObject("RefreshGrid.Image");
            RefreshGrid.Location = new Point(1257, 112);
            RefreshGrid.Margin = new Padding(0);
            RefreshGrid.Name = "RefreshGrid";
            RefreshGrid.Size = new Size(43, 35);
            RefreshGrid.TabIndex = 66;
            RefreshGrid.UseVisualStyleBackColor = false;
            RefreshGrid.Click += RefreshGrid_Click;
            RefreshGrid.MouseLeave += RefreshGrid_MouseLeave;
            RefreshGrid.MouseHover += RefreshGrid_MouseHover;
            // 
            // Hide
            // 
            Hide.BackColor = Color.LightGray;
            Hide.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point);
            Hide.Image = (Image)resources.GetObject("Hide.Image");
            Hide.Location = new Point(1301, 150);
            Hide.Margin = new Padding(0);
            Hide.Name = "Hide";
            Hide.Size = new Size(40, 33);
            Hide.TabIndex = 68;
            Hide.UseVisualStyleBackColor = false;
            Hide.Click += Hide_Click;
            Hide.MouseLeave += Hide_MouseLeave;
            Hide.MouseHover += Hide_MouseHover;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label6.Location = new Point(456, 142);
            label6.Name = "label6";
            label6.RightToLeft = RightToLeft.No;
            label6.Size = new Size(58, 15);
            label6.TabIndex = 69;
            label6.Text = "Call Cycle";
            // 
            // callcycle
            // 
            callcycle.Location = new Point(456, 160);
            callcycle.Name = "callcycle";
            callcycle.RightToLeft = RightToLeft.No;
            callcycle.Size = new Size(207, 23);
            callcycle.TabIndex = 70;
            callcycle.TextChanged += callcycle_TextChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(1002, 160);
            label10.Name = "label10";
            label10.Size = new Size(0, 15);
            label10.TabIndex = 71;
            // 
            // button5
            // 
        
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 692); 
            Controls.Add(label10);
            Controls.Add(callcycle);
            Controls.Add(label6);
            Controls.Add(Hide);
            Controls.Add(RefreshGrid);
            Controls.Add(Remark);
            Controls.Add(label9);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button4);
            Controls.Add(export_grid);
            Controls.Add(_customercount);
            Controls.Add(label8);
            Controls.Add(salesman);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(dateTimePicker2);
            Controls.Add(label2);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Controls.Add(label7);
            Controls.Add(customername);
            Controls.Add(Exit);
            Controls.Add(label1);
            Controls.Add(Mobile);
            Controls.Add(label3);
            Controls.Add(lebel);
            Controls.Add(Customercode);
            Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            Name = "Form1";
            Text = "ManagementSystem";
            WindowState = FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label7;
        private TextBox customername;
        private Button Exit;
        private Label label1;
        private TextBox Mobile;
        private Label label3;
        private Label lebel;
        private TextBox Customercode;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private Label label2;
        private DateTimePicker dateTimePicker2;
        private Label label4;
        private Label label5;
        private Button button2;
        private Button button3;
        private Label salesman;
        private Label _customercount;
        private Button export_grid;
        private Button button4;
        private Button button6;
        private Button button7;
        private Label label8;
        private TextBox Remark;
        private Label label9;
        private Button RefreshGrid;
        private Button Hide;
        private Label label6;
        private TextBox callcycle;
        private Label label10; 
        public DataGridView dataGridView1;
    }
}