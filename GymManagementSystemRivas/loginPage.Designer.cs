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
            panelCard.Location = new Point(225, 102);
            panelCard.Name = "panelCard";
            panelCard.Padding = new Padding(24);
            panelCard.Size = new Size(420, 360);
            panelCard.TabIndex = 0;
            // 
            // pictureLogo
            // 
            pictureLogo.BackColor = Color.White;
            pictureLogo.Location = new Point(24, 16);
            pictureLogo.Name = "pictureLogo";
            pictureLogo.Size = new Size(48, 48);
            pictureLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureLogo.TabIndex = 0;
            pictureLogo.TabStop = false;
            // 
            // lblAppTitle
            // 
            lblAppTitle.AutoSize = true;
            lblAppTitle.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            lblAppTitle.ForeColor = Color.White;
            lblAppTitle.Location = new Point(86, 24);
            lblAppTitle.Name = "lblAppTitle";
            lblAppTitle.Size = new Size(186, 28);
            lblAppTitle.TabIndex = 1;
            lblAppTitle.Text = "Gym Management";
            // 
            // lblWelcome
            // 
            lblWelcome.AutoSize = true;
            lblWelcome.Font = new Font("Segoe UI", 9F);
            lblWelcome.ForeColor = Color.FromArgb(200, 200, 200);
            lblWelcome.Location = new Point(24, 80);
            lblWelcome.Name = "lblWelcome";
            lblWelcome.Size = new Size(304, 20);
            lblWelcome.TabIndex = 2;
            lblWelcome.Text = "Welcome back! Please login to your account.";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.FromArgb(12, 24, 45);
            txtEmail.BorderStyle = BorderStyle.None;
            txtEmail.ForeColor = Color.LightGray;
            txtEmail.Location = new Point(24, 118);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(372, 20);
            txtEmail.TabIndex = 3;
            txtEmail.Text = "Email or username";
            txtEmail.Enter += txtEmail_Enter;
            txtEmail.Leave += txtEmail_Leave;
            // 
            // underlineEmail
            // 
            underlineEmail.BackColor = Color.FromArgb(64, 64, 64);
            underlineEmail.Location = new Point(24, 140);
            underlineEmail.Name = "underlineEmail";
            underlineEmail.Size = new Size(372, 1);
            underlineEmail.TabIndex = 4;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.FromArgb(12, 24, 45);
            txtPassword.BorderStyle = BorderStyle.None;
            txtPassword.ForeColor = Color.LightGray;
            txtPassword.Location = new Point(24, 164);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(372, 20);
            txtPassword.TabIndex = 5;
            txtPassword.Text = "Password";
            txtPassword.Enter += txtPassword_Enter;
            txtPassword.Leave += txtPassword_Leave;
            // 
            // underlinePassword
            // 
            underlinePassword.BackColor = Color.FromArgb(64, 64, 64);
            underlinePassword.Location = new Point(24, 186);
            underlinePassword.Name = "underlinePassword";
            underlinePassword.Size = new Size(372, 1);
            underlinePassword.TabIndex = 6;
            // 
            // checkBox1
            // 
            checkBox1.AutoSize = true;
            checkBox1.ForeColor = Color.LightGray;
            checkBox1.Location = new Point(24, 200);
            checkBox1.Name = "checkBox1";
            checkBox1.Size = new Size(134, 24);
            checkBox1.TabIndex = 7;
            checkBox1.Text = "Show password";
            checkBox1.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // linkForgot
            // 
            linkForgot.AutoSize = true;
            linkForgot.LinkColor = Color.SkyBlue;
            linkForgot.Location = new Point(300, 200);
            linkForgot.Name = "linkForgot";
            linkForgot.Size = new Size(60, 20);
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
            button1.Location = new Point(24, 232);
            button1.Name = "button1";
            button1.Size = new Size(372, 36);
            button1.TabIndex = 9;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // loginPage
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(18, 32, 56);
            ClientSize = new Size(900, 600);
            Controls.Add(panelCard);
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
    }
}
