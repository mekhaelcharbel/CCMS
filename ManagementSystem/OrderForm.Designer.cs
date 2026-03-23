namespace SudentManagementSystem
{
    partial class OrderForm
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
            lebel = new Label();
            _customercode = new Label();
            _orderdate = new Label();
            label3 = new Label();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            label2 = new Label();
            customerNamelbl = new Label();
            label5 = new Label();
            dataGridView2 = new DataGridView();
            label4 = new Label();
            label6 = new Label();
            Unsoldfamilieslbl = new Label();
            label1 = new Label();
            ItemNumber = new TextBox();
            label7 = new Label();
            Itemdesc = new TextBox();
            last3months = new Label();
            label9 = new Label();
            dataGridView3 = new DataGridView();
            label8 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            SuspendLayout();
            // 
            // lebel
            // 
            lebel.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            lebel.AutoSize = true;
            lebel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            lebel.Location = new Point(130, 25);
            lebel.Name = "lebel";
            lebel.RightToLeft = RightToLeft.No;
            lebel.Size = new Size(130, 21);
            lebel.TabIndex = 33;
            lebel.Text = "CustomerCode :";
            // 
            // _customercode
            // 
            _customercode.AutoSize = true;
            _customercode.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            _customercode.ForeColor = Color.FromArgb(192, 0, 192);
            _customercode.Location = new Point(266, 18);
            _customercode.Name = "_customercode";
            _customercode.Size = new Size(0, 30);
            _customercode.TabIndex = 34;
            // 
            // _orderdate
            // 
            _orderdate.AutoSize = true;
            _orderdate.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            _orderdate.ForeColor = Color.FromArgb(192, 0, 192);
            _orderdate.Location = new Point(1090, 24);
            _orderdate.Name = "_orderdate";
            _orderdate.Size = new Size(17, 25);
            _orderdate.TabIndex = 36;
            _orderdate.Text = " ";
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(949, 27);
            label3.Name = "label3";
            label3.RightToLeft = RightToLeft.No;
            label3.Size = new Size(130, 21);
            label3.TabIndex = 35;
            label3.Text = "Last Order :";
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(22, 196);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(672, 238);
            dataGridView1.TabIndex = 37;
            // 
            // button2
            // 
            button2.Location = new Point(1240, 648);
            button2.Name = "button2";
            button2.Size = new Size(75, 47);
            button2.TabIndex = 40;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label2.Location = new Point(22, 151);
            label2.Name = "label2";
            label2.Size = new Size(231, 32);
            label2.TabIndex = 42;
            label2.Text = "Last Three Invoices";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // customerNamelbl
            // 
            customerNamelbl.AutoSize = true;
            customerNamelbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            customerNamelbl.ForeColor = Color.FromArgb(192, 0, 192);
            customerNamelbl.Location = new Point(647, 17);
            customerNamelbl.Name = "customerNamelbl";
            customerNamelbl.Size = new Size(0, 30);
            customerNamelbl.TabIndex = 44;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label5.Location = new Point(481, 25);
            label5.Name = "label5";
            label5.RightToLeft = RightToLeft.No;
            label5.Size = new Size(141, 21);
            label5.TabIndex = 43;
            label5.Text = "Customer Name :";
            // 
            // dataGridView2
            // 
            dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(726, 196);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            dataGridView2.RowTemplate.Height = 27;
            dataGridView2.Size = new Size(485, 238);
            dataGridView2.TabIndex = 45;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label4.Location = new Point(726, 151);
            label4.Name = "label4";
            label4.Size = new Size(161, 32);
            label4.TabIndex = 46;
            label4.Text = "Top 10 Items";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label6.Location = new Point(22, 446);
            label6.Name = "label6";
            label6.Size = new Size(206, 32);
            label6.TabIndex = 48;
            label6.Text = "Unsold Families :";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // Unsoldfamilieslbl
            // 
            Unsoldfamilieslbl.AutoSize = true;
            Unsoldfamilieslbl.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            Unsoldfamilieslbl.ForeColor = Color.Red;
            Unsoldfamilieslbl.Location = new Point(234, 446);
            Unsoldfamilieslbl.Margin = new Padding(0, 0, 3, 0);
            Unsoldfamilieslbl.Name = "Unsoldfamilieslbl";
            Unsoldfamilieslbl.Size = new Size(0, 30);
            Unsoldfamilieslbl.TabIndex = 49;
            Unsoldfamilieslbl.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(22, 56);
            label1.Name = "label1";
            label1.RightToLeft = RightToLeft.No;
            label1.Size = new Size(89, 15);
            label1.TabIndex = 51;
            label1.Text = "Item Number :";
            // 
            // ItemNumber
            // 
            ItemNumber.Location = new Point(22, 74);
            ItemNumber.Name = "ItemNumber";
            ItemNumber.RightToLeft = RightToLeft.No;
            ItemNumber.Size = new Size(194, 25);
            ItemNumber.TabIndex = 50;
            ItemNumber.TextChanged += Customercode_TextChanged;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            label7.Location = new Point(22, 102);
            label7.Name = "label7";
            label7.RightToLeft = RightToLeft.No;
            label7.Size = new Size(70, 15);
            label7.TabIndex = 53;
            label7.Text = "Item Desc :";
            // 
            // Itemdesc
            // 
            Itemdesc.Location = new Point(22, 120);
            Itemdesc.Name = "Itemdesc";
            Itemdesc.RightToLeft = RightToLeft.No;
            Itemdesc.Size = new Size(194, 25);
            Itemdesc.TabIndex = 52;
            Itemdesc.TextChanged += textBox1_TextChanged;
            // 
            // last3months
            // 
            last3months.AutoSize = true;
            last3months.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            last3months.ForeColor = Color.Red;
            last3months.Location = new Point(234, 494);
            last3months.Margin = new Padding(0, 0, 3, 0);
            last3months.Name = "last3months";
            last3months.Size = new Size(0, 30);
            last3months.TabIndex = 55;
            last3months.TextAlign = ContentAlignment.TopCenter;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label9.Location = new Point(22, 492);
            label9.Name = "label9";
            label9.Size = new Size(176, 32);
            label9.TabIndex = 54;
            label9.Text = "Sold Families :";
            label9.TextAlign = ContentAlignment.TopCenter;
            // 
            // dataGridView3
            // 
            dataGridView3.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView3.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView3.Location = new Point(22, 580);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.RowTemplate.Height = 25;
            dataGridView3.Size = new Size(1189, 145);
            dataGridView3.TabIndex = 56;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point);
            label8.Location = new Point(555, 545);
            label8.Name = "label8";
            label8.Size = new Size(123, 32);
            label8.TabIndex = 57;
            label8.Text = "Summary";
            label8.TextAlign = ContentAlignment.TopCenter;
            // 
            // OrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1327, 728);
            Controls.Add(label8);
            Controls.Add(dataGridView3);
            Controls.Add(last3months);
            Controls.Add(label9);
            Controls.Add(label7);
            Controls.Add(Itemdesc);
            Controls.Add(label1);
            Controls.Add(ItemNumber);
            Controls.Add(Unsoldfamilieslbl);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(dataGridView2);
            Controls.Add(customerNamelbl);
            Controls.Add(label5);
            Controls.Add(label2);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(_orderdate);
            Controls.Add(label3);
            Controls.Add(_customercode);
            Controls.Add(lebel);
            Name = "OrderForm";
            Text = "OrderForm";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lebel;
        private Label _customercode;
        private Label _orderdate;
        private Label label3;
        private DataGridView dataGridView1;
        private Button button2;
        private Label Amountlbl;
        private Label label2;
        private Label customerNamelbl;
        private Label label5;
        private DataGridView dataGridView2;
        private Label label4;
        private Label label6;
        private Label Unsoldfamilieslbl;
        private Label label1;
        private TextBox ItemNumber;
        private Label label7;
        private TextBox Itemdesc;
        private Label last3months;
        private Label label9;
        private DataGridView dataGridView3;
        private Label label8;
    }
}