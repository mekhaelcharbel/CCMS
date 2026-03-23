namespace SudentManagementSystem
{
    partial class CustomerPicker
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
            _customerpotential = new Button();
            _viewPotential = new Button();
            button1 = new Button();
            SuspendLayout();

            // 
            // CustomerPicker (FORM)
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(600, 400);
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            StartPosition = FormStartPosition.CenterScreen;
            MaximizeBox = false;
            MinimizeBox = false;
            Text = "Customer Picker";

            // 
            // _customerpotential (Primary Button)
            // 
            _customerpotential.Name = "_customerpotential";
            _customerpotential.Size = new Size(220, 45);
            _customerpotential.Location = new Point(190, 100);
            _customerpotential.Text = "Add Customer";
            _customerpotential.TabIndex = 0;
            _customerpotential.FlatStyle = FlatStyle.Flat;
            _customerpotential.FlatAppearance.BorderSize = 0;
            _customerpotential.BackColor = Color.FromArgb(0, 120, 215); // Modern Blue
            _customerpotential.ForeColor = Color.White;
            _customerpotential.Cursor = Cursors.Hand;
            _customerpotential.Click += _customerpotential_Click;

            // 
            // _viewPotential (Secondary Button)
            // 
            _viewPotential.Name = "_viewPotential";
            _viewPotential.Size = new Size(220, 45);
            _viewPotential.Location = new Point(190, 165);
            _viewPotential.Text = "View";
            _viewPotential.TabIndex = 1;
            _viewPotential.FlatStyle = FlatStyle.Flat;
            _viewPotential.FlatAppearance.BorderSize = 0;
            _viewPotential.BackColor = Color.FromArgb(240, 240, 240);
            _viewPotential.ForeColor = Color.Black;
            _viewPotential.Cursor = Cursors.Hand;
            _viewPotential.Click += _viewPotential_Click;

            // 
            // button1 (Cancel Button)
            // 
            button1.Name = "button1";
            button1.Size = new Size(220, 45);
            button1.Location = new Point(190, 260);
            button1.Text = "Cancel";
            button1.TabIndex = 2;
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = Color.FromArgb(220, 53, 69); // Modern Red
            button1.ForeColor = Color.White;
            button1.Cursor = Cursors.Hand;
            button1.Click += button1_Click;

            // 
            // Controls
            // 
            Controls.Add(button1);
            Controls.Add(_viewPotential);
            Controls.Add(_customerpotential);

            ResumeLayout(false);
        }

        #endregion

        private Button _customerpotential;
        private Button _viewPotential;
        private Button button1;
    }
}
