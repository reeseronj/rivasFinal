using GymManagementSystemRivas.models;
using GymManagementSystemRivas.repositories;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymManagementSystemRivas
{

    public partial class addEditStaff : Form
    {
        public addEditStaff()
        {
            InitializeComponent();
        }

        private int admin_id = 0;

        public void EditAdmin(admin admin)
        {
            this.Text = "Edit Admin";
            this.lblTitle.Text = "Edit Admin";

            this.lblID.Text = "" + admin.admin_id;
            this.txtFname.Text = admin.admin_fname;
            this.txtLname.Text = admin.admin_lname;
            this.txtEmail.Text = admin.admin_email;
            this.txtRole.Text = admin.admin_role;

            this.admin_id = admin.admin_id;
        }
        private void btnSave_Click(object sender, EventArgs e)
        {

            string emailInput = txtEmail.Text.Trim();
       
            admin admin = new admin();
            admin.admin_id = this.admin_id;
            admin.admin_fname = this.txtFname.Text;
            admin.admin_lname = this.txtLname.Text;
            admin.admin_email = this.txtEmail.Text;
            admin.admin_role = this.txtRole.Text;
            admin.admin_password = this.txtPassword.Text;

            var repo = new adminRepository();

            if (admin.admin_id == 0)
            {
                if (config.IsEmailDuplicate(emailInput))
                {
                    MessageBox.Show("This email is already registered. Please use a different one or log in.");
                    return;
                }
                repo.createAdmin(admin);
            }
            else
            {
                repo.updateAdmin(admin);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void addStaff_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
