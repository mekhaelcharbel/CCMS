namespace LoginApplication
{
    partial class frmLogin
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            txt_UserName = new TextBox();
            txt_Password = new TextBox();
            btn_Submit = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            SuspendLayout();

            // 
            // label1 - Username
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(50, 50, 50);
            label1.Location = new Point(40, 50);
            label1.Name = "label1";
            label1.Size = new Size(90, 20);
            label1.Text = "User Name";

            // 
            // label2 - Password
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(50, 50, 50);
            label2.Location = new Point(40, 120);
            label2.Name = "label2";
            label2.Size = new Size(78, 20);
            label2.Text = "Password";

            // 
            // txt_UserName
            // 
            txt_UserName.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_UserName.Location = new Point(40, 75);
            txt_UserName.Size = new Size(300, 30);
            txt_UserName.ForeColor = Color.Gray;
            txt_UserName.Text = "Enter username";
            txt_UserName.GotFocus += (s, e) =>
            {
                if (txt_UserName.Text == "Enter username")
                {
                    txt_UserName.Text = "";
                    txt_UserName.ForeColor = Color.Black;
                }
            };
            txt_UserName.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt_UserName.Text))
                {
                    txt_UserName.Text = "Enter username";
                    txt_UserName.ForeColor = Color.Gray;
                }
            };
            txt_UserName.BorderStyle = BorderStyle.FixedSingle;

            // 
            // txt_Password
            // 
            txt_Password.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Point);
            txt_Password.Location = new Point(40, 145);
            txt_Password.Size = new Size(300, 30);
            txt_Password.ForeColor = Color.Gray;
            txt_Password.Text = "Enter password";
            txt_Password.UseSystemPasswordChar = false;
            txt_Password.GotFocus += (s, e) =>
            {
                if (txt_Password.Text == "Enter password")
                {
                    txt_Password.Text = "";
                    txt_Password.ForeColor = Color.Black;
                    txt_Password.UseSystemPasswordChar = true;
                }
            };
            txt_Password.LostFocus += (s, e) =>
            {
                if (string.IsNullOrWhiteSpace(txt_Password.Text))
                {
                    txt_Password.UseSystemPasswordChar = false;
                    txt_Password.Text = "Enter password";
                    txt_Password.ForeColor = Color.Gray;
                }
            };
            txt_Password.BorderStyle = BorderStyle.FixedSingle;

            // 
            // btn_Submit
            // 
            btn_Submit.Text = "Login";
            btn_Submit.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point);
            btn_Submit.BackColor = Color.FromArgb(75, 135, 240);
            btn_Submit.ForeColor = Color.White;
            btn_Submit.FlatStyle = FlatStyle.Flat;
            btn_Submit.FlatAppearance.BorderSize = 0;
            btn_Submit.Size = new Size(120, 35);
            btn_Submit.Location = new Point(110, 200);
            btn_Submit.Cursor = Cursors.Hand;
            btn_Submit.Click += button1_Click;
            btn_Submit.MouseEnter += (s, e) => btn_Submit.BackColor = Color.FromArgb(50, 110, 220);
            btn_Submit.MouseLeave += (s, e) => btn_Submit.BackColor = Color.FromArgb(75, 135, 240);

            // 
            // panel1 - background panel
            // 
            panel1.Dock = DockStyle.Fill;
            panel1.BackColor = Color.White;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(txt_UserName);
            panel1.Controls.Add(txt_Password);
            panel1.Controls.Add(btn_Submit);

            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(400, 280);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txt_UserName;
        private TextBox txt_Password;
        private Button btn_Submit;
        private Panel panel1;
        private Panel panel2;
    }
}
