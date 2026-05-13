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
    public partial class addEditCoach : Form
    {
        private int coach_id = 0;
        public addEditCoach()
        {
            InitializeComponent();
        }

        public void EditCoach(Coach coach)
        {
            this.Text = "Edit Coach";
            this.lblTitle.Text = "Edit Coach";

            this.lblID.Text = "" + coach.coach_id;
            this.txtFname.Text = coach.coach_fname;
            this.txtLname.Text = coach.coach_lname;
            this.txtEmail.Text = coach.email;

            this.coach_id = coach.coach_id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string emailInput = txtEmail.Text.Trim();

            Coach coach = new Coach();
            coach.coach_id = this.coach_id;
            coach.coach_fname = this.txtFname.Text;
            coach.coach_lname = this.txtLname.Text;
            coach.email = this.txtEmail.Text;
            coach.password = this.txtPassword.Text;

            var repo = new coachRepository();

            if (coach.coach_id == 0)
            {
                if (config.IsEmailDuplicate(emailInput))
                {
                    MessageBox.Show("This email is already registered. Please use a different one or log in.");
                    return;
                }
                repo.createCoach(coach);
            }
            else
            {
                repo.updateCoach(coach);
            }

            this.DialogResult = DialogResult.OK;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }
    }
}
