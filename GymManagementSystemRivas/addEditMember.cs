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
    public partial class addEditMember : Form
    {
        private int mem_id = 0;
        public addEditMember()
        {
            InitializeComponent();
        }
        public void EditMember(Member member)
        {
            this.Text = "Edit Member";
            this.lblTitle.Text = "Edit Member";

            this.lblID.Text = "" + member.mem_id;
            this.txtFname.Text = member.mem_fname;
            this.txtLname.Text = member.mem_lname;
            this.txtEmail.Text = member.mem_email;

            this.mem_id = member.mem_id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string emailInput = txtEmail.Text.Trim();

            Member member = new Member();
            member.mem_id = this.mem_id;
            member.mem_fname = this.txtFname.Text;
            member.mem_lname = this.txtLname.Text;
            member.mem_email = this.txtEmail.Text;
            member.mem_password = this.txtPassword.Text;

            var repo = new memRepository();

            if (member.mem_id == 0)
            {
                if (config.IsEmailDuplicate(emailInput))
                {
                    MessageBox.Show("This email is already registered. Please use a different one or log in.");
                    return;
                }
                repo.createMember(member);
            }
            else
            {
                repo.updateMember(member);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
    
}
