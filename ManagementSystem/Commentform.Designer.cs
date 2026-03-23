namespace SudentManagementSystem
{
    partial class Commentform
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
            label4 = new Label();
            button2 = new Button();
            label1 = new Label();
            Phonenumbertxt = new TextBox();
            label2 = new Label();
            contactpersontxt = new TextBox();
            label3 = new Label();
            emailtxt = new TextBox();
            checkedListBox1 = new CheckedListBox();
            label5 = new Label();
            Freeremarktxt = new TextBox();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label4.ForeColor = Color.FromArgb(50, 50, 50);
            label4.Location = new Point(12, 109);
            label4.Name = "label4";
            label4.Size = new Size(95, 28);
            label4.TabIndex = 49;
            label4.Text = "Remark :";
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(52, 152, 219);
            button2.FlatStyle = FlatStyle.Flat;
            button2.FlatAppearance.BorderSize = 0;
            button2.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point);
            button2.ForeColor = Color.White;
            button2.Location = new Point(403, 402);
            button2.Margin = new Padding(0);
            button2.Name = "button2";
            button2.Size = new Size(102, 35);
            button2.TabIndex = 52;
            button2.Text = "Submit";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(50, 50, 50);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(165, 28);
            label1.TabIndex = 54;
            label1.Text = "Phone Number :";
            // 
            // Phonenumbertxt
            // 
            Phonenumbertxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Phonenumbertxt.BackColor = Color.WhiteSmoke;
            Phonenumbertxt.BorderStyle = BorderStyle.FixedSingle;
            Phonenumbertxt.Location = new Point(183, 12);
            Phonenumbertxt.Multiline = true;
            Phonenumbertxt.Name = "Phonenumbertxt";
            Phonenumbertxt.Size = new Size(177, 47);
            Phonenumbertxt.TabIndex = 53;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label2.ForeColor = Color.FromArgb(50, 50, 50);
            label2.Location = new Point(403, 12);
            label2.Name = "label2";
            label2.Size = new Size(165, 28);
            label2.TabIndex = 56;
            label2.Text = "Contact Person :";
            // 
            // contactpersontxt
            // 
            contactpersontxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            contactpersontxt.BackColor = Color.WhiteSmoke;
            contactpersontxt.BorderStyle = BorderStyle.FixedSingle;
            contactpersontxt.Location = new Point(584, 12);
            contactpersontxt.Multiline = true;
            contactpersontxt.Name = "contactpersontxt";
            contactpersontxt.Size = new Size(185, 47);
            contactpersontxt.TabIndex = 55;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label3.ForeColor = Color.FromArgb(50, 50, 50);
            label3.Location = new Point(403, 109);
            label3.Name = "label3";
            label3.Size = new Size(75, 28);
            label3.TabIndex = 58;
            label3.Text = "Email :";
            // 
            // emailtxt
            // 
            emailtxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            emailtxt.BackColor = Color.WhiteSmoke;
            emailtxt.BorderStyle = BorderStyle.FixedSingle;
            emailtxt.Location = new Point(584, 109);
            emailtxt.Multiline = true;
            emailtxt.Name = "emailtxt";
            emailtxt.Size = new Size(185, 46);
            emailtxt.TabIndex = 57;
            // 
            // checkedListBox1
            // 
            checkedListBox1.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            checkedListBox1.BackColor = Color.WhiteSmoke;
            checkedListBox1.BorderStyle = BorderStyle.FixedSingle;
            checkedListBox1.FormattingEnabled = true;
            checkedListBox1.Items.AddRange(new object[] { "Blank", "Delivery", "Quotation", "Follow up", "No sell", "No answer", "Sold", "Line not valid", "Person not reachable", "Wrong phone #", "Incoming call", "Outcoming call", "To close ", "Low consumption", "Have stock", "Prices", "Payment Method" });
            checkedListBox1.Location = new Point(183, 109);
            checkedListBox1.Name = "checkedListBox1";
            checkedListBox1.Size = new Size(177, 324);
            checkedListBox1.TabIndex = 59;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 14F, FontStyle.Bold, GraphicsUnit.Point);
            label5.ForeColor = Color.FromArgb(50, 50, 50);
            label5.Location = new Point(403, 241);
            label5.Name = "label5";
            label5.Size = new Size(141, 28);
            label5.TabIndex = 61;
            label5.Text = "Free Remark :";
            // 
            // Freeremarktxt
            // 
            Freeremarktxt.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            Freeremarktxt.BackColor = Color.WhiteSmoke;
            Freeremarktxt.BorderStyle = BorderStyle.FixedSingle;
            Freeremarktxt.Location = new Point(584, 241);
            Freeremarktxt.Multiline = true;
            Freeremarktxt.Name = "Freeremarktxt";
            Freeremarktxt.Size = new Size(185, 140);
            Freeremarktxt.TabIndex = 60;
            // 
            // Commentform
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 510);
            Controls.Add(label5);
            Controls.Add(Freeremarktxt);
            Controls.Add(checkedListBox1);
            Controls.Add(label3);
            Controls.Add(emailtxt);
            Controls.Add(label2);
            Controls.Add(contactpersontxt);
            Controls.Add(label1);
            Controls.Add(Phonenumbertxt);
            Controls.Add(button2);
            Controls.Add(label4);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "Commentform";
            Text = "Comment";
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion
        private Label label4;
        private Button button2;
        private Label label1;
        private TextBox Phonenumbertxt;
        private Label label2;
        private TextBox contactpersontxt;
        private Label label3;
        private TextBox emailtxt;
        private CheckedListBox checkedListBox1;
        private Label label5;
        private TextBox Freeremarktxt;
    }
}