namespace SudentManagementSystem
{
    partial class CustomerPotential
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
            customerNametxt = new TextBox();
            phonetxt = new TextBox();
            emailtxt = new TextBox();
            addtxt = new TextBox();
            channeltxt = new TextBox();
            label1 = new Label();
            rmktxt = new RichTextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            _addCustomer = new Button();
            SuspendLayout();

            // ===== FORM SETTINGS =====
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(950, 600);
            Font = new Font("Segoe UI", 10F);
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Add Potential Customer";

            // ===== TITLE =====
            label1.Dock = DockStyle.Top;
            label1.Height = 80;
            label1.Font = new Font("Segoe UI", 22F, FontStyle.Bold);
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Text = "Add Potential Customer";
            label1.ForeColor = Color.FromArgb(33, 37, 41);

            // ===== LEFT SIDE LABELS =====
            int leftLabelX = 80;
            int leftInputX = 230;
            int startY = 120;
            int gap = 60;

            // Customer Name
            label2.Location = new Point(leftLabelX, startY);
            label2.Text = "Customer Name:";
            label2.AutoSize = true;

            customerNametxt.Location = new Point(leftInputX, startY - 5);
            customerNametxt.Size = new Size(280, 30);
            customerNametxt.BorderStyle = BorderStyle.FixedSingle;

            // Phone
            label4.Location = new Point(leftLabelX, startY + gap);
            label4.Text = "Phone Number:";
            label4.AutoSize = true;

            phonetxt.Location = new Point(leftInputX, startY + gap - 5);
            phonetxt.Size = new Size(280, 30);
            phonetxt.BorderStyle = BorderStyle.FixedSingle;

            // Email
            label5.Location = new Point(leftLabelX, startY + gap * 2);
            label5.Text = "E-mail:";
            label5.AutoSize = true;

            emailtxt.Location = new Point(leftInputX, startY + gap * 2 - 5);
            emailtxt.Size = new Size(280, 30);
            emailtxt.BorderStyle = BorderStyle.FixedSingle;

            // Address
            label6.Location = new Point(leftLabelX, startY + gap * 3);
            label6.Text = "Address:";
            label6.AutoSize = true;

            addtxt.Location = new Point(leftInputX, startY + gap * 3 - 5);
            addtxt.Size = new Size(280, 30);
            addtxt.BorderStyle = BorderStyle.FixedSingle;

            // Channel
            label7.Location = new Point(leftLabelX, startY + gap * 4);
            label7.Text = "Channel:";
            label7.AutoSize = true;

            channeltxt.Location = new Point(leftInputX, startY + gap * 4 - 5);
            channeltxt.Size = new Size(280, 30);
            channeltxt.BorderStyle = BorderStyle.FixedSingle;

            // ===== RIGHT SIDE REMARK =====
            label8.Location = new Point(580, 150);
            label8.Text = "Remark:";
            label8.AutoSize = true;

            rmktxt.Location = new Point(580, 180);
            rmktxt.Size = new Size(280, 200);
            rmktxt.BorderStyle = BorderStyle.FixedSingle;
            rmktxt.BackColor = Color.FromArgb(248, 249, 250);

            // ===== BUTTON =====
            _addCustomer.Size = new Size(200, 45);
            _addCustomer.Location = new Point(580, 420);
            _addCustomer.Text = "Add Customer";
            _addCustomer.FlatStyle = FlatStyle.Flat;
            _addCustomer.FlatAppearance.BorderSize = 0;
            _addCustomer.BackColor = Color.FromArgb(0, 120, 215);
            _addCustomer.ForeColor = Color.White;
            _addCustomer.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            _addCustomer.Cursor = Cursors.Hand;
            _addCustomer.Click += _addCustomer_Click;

            // ===== ADD CONTROLS =====
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(customerNametxt);
            Controls.Add(phonetxt);
            Controls.Add(emailtxt);
            Controls.Add(addtxt);
            Controls.Add(channeltxt);
            Controls.Add(rmktxt);
            Controls.Add(_addCustomer);

            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox customerNametxt;
        private TextBox phonetxt;
        private TextBox emailtxt;
        private TextBox addtxt;
        private TextBox channeltxt;
        private Label label1;
        private RichTextBox rmktxt;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button _addCustomer;
    }
}
