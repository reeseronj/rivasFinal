namespace GymMamagementSystemRivas
{
    partial class loginPage
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
            panelBackground = new Panel();
            panelCard = new Panel();
            pictureLogo = new PictureBox();
            lblAppTitle = new Label();
            lblWelcome = new Label();
            txtEmail = new TextBox();
            underlineEmail = new Panel();
            txtPassword = new TextBox();
            underlinePassword = new Panel();
            checkBox1 = new CheckBox();
            linkForgot = new LinkLabel();
            button1 = new Button();
            linkSignup = new LinkLabel();
            label1 = new Label();
            panelCard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).BeginInit();
            SuspendLayout();
            // 
            // panelBackground
            // 
            panelBackground.BackColor = Color.FromArgb(18, 32, 56);
            panelBackground.Dock = DockStyle.Fill;
            panelBackground.Location = new Point(0, 0);
            panelBackground.Name = "panelBackground";
            panelBackground.Size = new Size(200, 100);
            panelBackground.TabIndex = 0;
            // 
            // panelCard
            // 
            panelCard.Anchor = AnchorStyles.None;
            panelCard.BackColor = Color.FromArgb(12, 24, 45);
            panelCard.Controls.Add(label1);
            panelCard.Controls.Add(linkSignup);
            panelCard.Controls.Add(pictureLogo);
            panelCard.Controls.Add(lblAppTitle);
            panelCard.Controls.Add(lblWelcome);
            panelCard.Controls.Add(txtEmail);
            panelCard.Controls.Add(underlineEmail);
            panelCard.Controls.Add(txtPassword);
            panelCard.Controls.Add(underlinePassword);
            panelCard.Controls.Add(checkBox1);
            panelCard.Controls.Add(linkForgot);
            panelCard.Controls.Add(button1);
            panelCard.Location = new Point(197, 76);
            panelCard.Margin = new Padding(3, 2, 3, 2);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(21, 18, 21, 18);
            panelCard.Size = new Size(368, 270);
            panelCard.TabIndex = 0;
            panelCard.Paint += panelCard_Paint;
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.White;
            pictureLogo.Location = new Point(21, 12);
            pictureLogo.Margin = new Padding(3, 2, 3, 2);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(42, 36);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(75, 18);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(151, 21);
            lblAppTitle.TabIndex = 1;
            lblAppTitle.Text = "Gym Management";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 9F);
            lblWelcome.ForeColor = Color.FromArgb(200, 200, 200);
            lblWelcome.Location = new Point(21, 60);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(244, 15);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome back! Please login to your account.";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(12, 24, 45);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.ForeColor = Color.LightGray;
            txtEmail.Location = new Point(21, 88);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(326, 16);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "Email or username";
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // underlineEmail
            // 
            underlineEmail.BackColor = Color.FromArgb(64, 64, 64);
            underlineEmail.Location = new Point(21, 105);
            underlineEmail.Margin = new Padding(3, 2, 3, 2);
            underlineEmail.Name = "underlineEmail";
            underlineEmail.Size = new Size(326, 1);
            underlineEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(12, 24, 45);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = Color.LightGray;
            txtPassword.Location = new Point(21, 123);
            txtPassword.Margin = new Padding(3, 2, 3, 2);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(326, 16);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "Password";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // underlinePassword
            // 
            underlinePassword.BackColor = Color.FromArgb(64, 64, 64);
            underlinePassword.Location = new Point(21, 140);
            underlinePassword.Margin = new Padding(3, 2, 3, 2);
            underlinePassword.Name = "underlinePassword";
            underlinePassword.Size = new Size(326, 1);
            underlinePassword.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.LightGray;
            checkBox1.Location = new Point(21, 150);
            checkBox1.Margin = new Padding(3, 2, 3, 2);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(108, 19);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show password";
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkForgot
            // 
            linkForgot.AutoSize = true;
            linkForgot.LinkColor = Color.SkyBlue;
            linkForgot.Location = new Point(262, 150);
            linkForgot.Name = "linkForgot";
            linkForgot.Size = new Size(47, 15);
            linkForgot.TabIndex = 8;
            linkForgot.TabStop = true;
            linkForgot.Text = "Forgot?";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(98, 0, 238);
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(21, 205);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(326, 27);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // linkSignup
            // 
            linkSignup.AutoSize = true;
            linkSignup.LinkColor = Color.SkyBlue;
            linkSignup.Location = new Point(212, 178);
            linkSignup.Name = "linkSignup";
            linkSignup.Size = new Size(44, 15);
            linkSignup.TabIndex = 10;
            linkSignup.TabStop = true;
            linkSignup.Text = "Signup";
            linkSignup.LinkClicked += linkLabel1_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F);
            label1.ForeColor = Color.FromArgb(200, 200, 200);
            label1.Location = new Point(75, 178);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 11;
            label1.Text = "Don't have an account?";
            label1.Click += label1_Click;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 32, 56);
            ClientSize = new Size(788, 450);
            Controls.Add(panelCard);
            Margin = new Padding(3, 2, 3, 2);
            MaximizeBox = false;
            Name = "loginPage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Gym Management System";
            panelCard.ResumeLayout(false);
            panelCard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelBackground;
        private Panel panelCard;
        private PictureBox pictureLogo;
        private Label lblAppTitle;
        private Label lblWelcome;
        private TextBox txtEmail;
        private Panel underlineEmail;
        private TextBox txtPassword;
        private Panel underlinePassword;
        private CheckBox checkBox1;
        private Button button1;
        private LinkLabel linkForgot;
        private LinkLabel linkSignup;
        private Label label1;
    }
}
