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
            // Simple role-based login (example accounts)
            var user = txtEmail.Text?.Trim();
            var pass = txtPassword.Text;

            // hardcoded demo accounts - replace with real auth in production
            bool isAdmin = (string.Equals(user, "admin", StringComparison.OrdinalIgnoreCase) || string.Equals(user, "admin@example.com", StringComparison.OrdinalIgnoreCase)) && pass == "admin123";
            bool isClient = (string.Equals(user, "client", StringComparison.OrdinalIgnoreCase) || string.Equals(user, "client@example.com", StringComparison.OrdinalIgnoreCase)) && pass == "client123";

            if (isAdmin)
            {
                var admin = new adminDashboard(user);
                admin.Show();
                this.Hide();
                return;
            }

            if (isClient)
            {
                var client = new clientDashboard(user);
                client.Show();
                this.Hide();
                return;
            }

            MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
    }
}
