using GymManagementSystemRivas;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GymMamagementSystemRivas
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string emailInput = txtEmail.Text.Trim();
            string passwordInput = txtPassword.Text;

            string userRole = config.GetUserRole(emailInput, passwordInput);

            switch (userRole)
            {
                case "Admin":
                    MessageBox.Show("Welcome, Admin!");
                    new adminDashboard().Show();
                    this.Hide();
                    break;

                case "Coach":
                    // You can show a specific message or a Coach Dashboard here
                    MessageBox.Show("Welcome, Coach! Accessing Coach portal.");
                    break;

                case "Member":
                    MessageBox.Show("Welcome, Member!");
                    break;

                default:
                    MessageBox.Show("Invalid Email or Password.");
                    break;
            }
        }

        // Placeholder behavior for professional textboxes
        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "Email or username")
            {
                txtEmail.Text = "";
                txtEmail.ForeColor = Color.White;
            }
        }

        private void txtEmail_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                txtEmail.Text = "Email or username";
                txtEmail.ForeColor = Color.LightGray;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "Password")
            {
                txtPassword.Text = "";
                txtPassword.ForeColor = Color.White;
                txtPassword.PasswordChar = '*';
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                txtPassword.PasswordChar = '\0';
                txtPassword.Text = "Password";
                txtPassword.ForeColor = Color.LightGray;
            }
        }

        private void panelCard_Paint(object sender, PaintEventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form signupPage = new signupPage();
            signupPage.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
