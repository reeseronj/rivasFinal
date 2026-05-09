using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystemRivas
{
    public partial class signupPage : Form
    {
        public signupPage()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = checkBox1.Checked ? '\0' : '*';
        }

        private void btnSignup_Click(object sender, EventArgs e)
        {
            string emailInput = txtEmail.Text.Trim();
            if (config.IsEmailDuplicate(emailInput))
            {
                MessageBox.Show("This email is already registered. Please use a different one or log in.");
                return;
            }
            string role = cmbRole.Text;
            if (config.RegisterUser(role, txtFname.Text, txtLname.Text, emailInput, txtPassword.Text))
            {
                MessageBox.Show("Registration successful! Status set to Inactive.");
                this.Close();
            }
        }
    }
}
