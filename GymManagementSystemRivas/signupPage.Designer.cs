namespace GymManagementSystemRivas
{
    partial class signupPage
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
            cmbRole = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtFname = new TextBox();
            txtLname = new TextBox();
            txtEmail = new TextBox();
            txtPassword = new TextBox();
            checkBox1 = new CheckBox();
            btnSignup = new Button();
            SuspendLayout();
            // 
            // cmbRole
            // 
            cmbRole.FormattingEnabled = true;
            cmbRole.Items.AddRange(new object[] { "Member", "Coach" });
            cmbRole.Location = new Point(350, 53);
            cmbRole.Name = "cmbRole";
            cmbRole.Size = new Size(145, 23);
            cmbRole.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(228, 56);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 1;
            label1.Text = "Choose role:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(228, 98);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 2;
            label2.Text = "First name:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(229, 133);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 3;
            label3.Text = "Last name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(229, 174);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 4;
            label4.Text = "Email:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(228, 215);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 5;
            label5.Text = "Password:";
            // 
            // txtFname
            // 
            txtFname.Location = new Point(350, 90);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(145, 23);
            txtFname.TabIndex = 6;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(350, 130);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(145, 23);
            txtLname.TabIndex = 7;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(350, 174);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(145, 23);
            txtEmail.TabIndex = 8;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(350, 212);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(145, 23);
            txtPassword.TabIndex = 9;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.Black;
            checkBox1.Location = new Point(387, 240);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 10;
            checkBox1.Text = "Show password";
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // btnSignup
            // 
            btnSignup.Location = new Point(361, 292);
            btnSignup.Name = "btnSignup";
            btnSignup.Size = new Size(75, 23);
            btnSignup.TabIndex = 11;
            btnSignup.Text = "Sign Up";
            btnSignup.UseVisualStyleBackColor = true;
            btnSignup.Click += btnSignup_Click;
            // 
            // signupPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(748, 348);
            Controls.Add(btnSignup);
            Controls.Add(checkBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbRole);
            Name = "signupPage";
            Text = "signupPage";
            Load += signupPage_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cmbRole;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox txtFname;
        private TextBox txtLname;
        private TextBox txtEmail;
        private TextBox txtPassword;
        private CheckBox checkBox1;
        private Button btnSignup;
    }
}