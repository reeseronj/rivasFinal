namespace GymManagementSystemRivas
{
    partial class addEditStaff
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
            checkBox1 = new CheckBox();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtLname = new TextBox();
            txtFname = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            btnSave = new Button();
            btnCancel = new Button();
            txtRole = new TextBox();
            lblTitle = new Label();
            label6 = new Label();
            lblID = new Label();
            SuspendLayout();
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.Black;
            checkBox1.Location = new Point(290, 273);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 19;
            checkBox1.Text = "Show password";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(268, 245);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(145, 23);
            txtPassword.TabIndex = 18;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(268, 207);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(145, 23);
            txtEmail.TabIndex = 17;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(268, 163);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(145, 23);
            txtLname.TabIndex = 16;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(268, 123);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(145, 23);
            txtFname.TabIndex = 15;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(146, 248);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 14;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(147, 207);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 13;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(147, 166);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 12;
            label3.Text = "Last name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(146, 121);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 11;
            label2.Text = "First name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(147, 86);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 20;
            label1.Text = "Role:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(151, 310);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 22;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(290, 310);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 23;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // txtRole
            // 
            txtRole.Location = new Point(268, 88);
            txtRole.Name = "txtRole";
            txtRole.Size = new Size(145, 23);
            txtRole.TabIndex = 24;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(212, 19);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(112, 32);
            lblTitle.TabIndex = 25;
            lblTitle.Text = "Add Staff";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(146, 60);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 26;
            label6.Text = "ID:";
            label6.Click += label6_Click;
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(268, 60);
            lblID.Name = "lblID";
            lblID.Size = new Size(13, 15);
            lblID.TabIndex = 27;
            lblID.Text = "0";
            // 
            // addEditStaff
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(538, 356);
            Controls.Add(lblID);
            Controls.Add(label6);
            Controls.Add(lblTitle);
            Controls.Add(txtRole);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(label1);
            Controls.Add(checkBox1);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Name = "addEditStaff";
            Text = "Form1";
            Load += addStaff_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBox1;
        private TextBox txtPassword;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        public TextBox txtEmail;
        public TextBox txtFname;
        public TextBox txtLname;
        public Button btnSave;
        public Button btnCancel;
        public TextBox txtRole;
        private Label lblTitle;
        private Label label6;
        private Label lblID;
    }
}