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
    public partial class addEditSubscription : Form
    {
        private int subscription_id;
        public addEditSubscription()
        {
            InitializeComponent();
        }
        public void EditSubscription(Subscription subscription)
        {
            this.Text = "Edit Subscription";
            this.lblTitle.Text = "Edit Subscription";

            this.lblID.Text = "" + subscription.subscription_id;
            this.txtPlan.Text = subscription.plan;
            this.txtDuration.Text = subscription.duration.ToString();
            this.txtPrice.Text = subscription.price.ToString();

            this.subscription_id = subscription.subscription_id;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Subscription subscription = new Subscription();
            subscription.subscription_id = this.subscription_id;
            subscription.plan = this.txtPlan.Text;

            // Convert string inputs to integers for the database
            int.TryParse(this.txtDuration.Text, out subscription.duration);
            int.TryParse(this.txtPrice.Text, out subscription.price);

            var repo = new subscriptionRepository();

            if (subscription.subscription_id == 0)
            {
                // Adding a new subscription
                repo.createSubscription(subscription);
            }
            else
            {
                // Updating an existing subscription
                repo.updateSubscription(subscription);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
