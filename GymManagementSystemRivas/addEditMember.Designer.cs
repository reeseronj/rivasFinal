namespace GymManagementSystemRivas
{
    partial class addEditMember
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
            lblTitle = new Label();
            label6 = new Label();
            lblID = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            txtPassword = new TextBox();
            txtEmail = new TextBox();
            txtLname = new TextBox();
            txtFname = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            checkBox1 = new CheckBox();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(203, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(155, 32);
            lblTitle.TabIndex = 26;
            lblTitle.Text = "Add Member";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(146, 45);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 27;
            label6.Text = "ID:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(302, 45);
            lblID.Name = "lblID";
            lblID.Size = new Size(13, 15);
            lblID.TabIndex = 28;
            lblID.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(145, 208);
            label5.Name = "label5";
            label5.Size = new Size(60, 15);
            label5.TabIndex = 32;
            label5.Text = "Password:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(146, 167);
            label4.Name = "label4";
            label4.Size = new Size(39, 15);
            label4.TabIndex = 31;
            label4.Text = "Email:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(146, 126);
            label3.Name = "label3";
            label3.Size = new Size(64, 15);
            label3.TabIndex = 30;
            label3.Text = "Last name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 81);
            label2.Name = "label2";
            label2.Size = new Size(65, 15);
            label2.TabIndex = 29;
            label2.Text = "First name:";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(278, 203);
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '*';
            txtPassword.Size = new Size(145, 23);
            txtPassword.TabIndex = 37;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(278, 165);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(145, 23);
            txtEmail.TabIndex = 36;
            // 
            // txtLname
            // 
            txtLname.Location = new Point(278, 121);
            txtLname.Name = "txtLname";
            txtLname.Size = new Size(145, 23);
            txtLname.TabIndex = 35;
            // 
            // txtFname
            // 
            txtFname.Location = new Point(278, 81);
            txtFname.Name = "txtFname";
            txtFname.Size = new Size(145, 23);
            txtFname.TabIndex = 34;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(287, 260);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 40;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(146, 260);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 39;
            btnSave.Text = " Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.Black;
            checkBox1.Location = new Point(315, 231);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 41;
            checkBox1.Text = "Show password";
            // 
            // addEditMember
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(570, 333);
            Controls.Add(checkBox1);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(txtLname);
            Controls.Add(txtFname);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblID);
            Controls.Add(label6);
            Controls.Add(lblTitle);
            Name = "addEditMember";
            Text = "addEditMember";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label6;
        private Label lblID;
        private Label label1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        public TextBox txtRole;
        private TextBox txtPassword;
        public TextBox txtEmail;
        public TextBox txtLname;
        public TextBox txtFname;
        public Button btnCancel;
        public Button btnSave;
        private CheckBox checkBox1;
    }
}