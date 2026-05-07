using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GymMamagementSystemRivas
{
    public partial class adminDashboard : Form
    {
        private string _username;

        public adminDashboard()
        {
            InitializeComponent();
            // wire sidebar buttons to tab pages (except logout which already has its handler)
            btnDashboard.Click += BtnDashboard_Click;
            btnSalesOrders.Click += BtnSalesOrders_Click;
            btnPurchases.Click += BtnPurchases_Click;
            btnProducts.Click += BtnProducts_Click;
            btnSuppliers.Click += BtnSuppliers_Click;
            btnCustomers.Click += BtnCustomers_Click;
            btnSettings.Click += BtnSettings_Click;
        }


        public adminDashboard(string username) : this()
        {
            _username = username;


            try
            {

                var lbl = this.Controls.Find("lblUsername", true);
                if (lbl.Length > 0 && lbl[0] is Label usernameLabel)
                {
                    usernameLabel.Text = _username;
                }
            }
            catch
            {

            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("r u sure u want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {

                var login = new loginPage();
                login.Show();
                this.Close();
            }

        }

        private void panelTop_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblDate_Click(object sender, EventArgs e)
        {

        }

        // Sidebar navigation handlers
        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            if (tabControl1 != null && tabPage1 != null)
                tabControl1.SelectedTab = tabPage1;
        }

        private void BtnSalesOrders_Click(object sender, EventArgs e)
        {
            if (tabControl1 != null && tabPage2 != null)
                tabControl1.SelectedTab = tabPage2;
        }

        private void BtnPurchases_Click(object sender, EventArgs e)
        {
            if (tabControl1 != null && tabPage3 != null)
                tabControl1.SelectedTab = tabPage3;
        }

        private void BtnProducts_Click(object sender, EventArgs e)
        {
            if (tabControl1 != null && tabPage4 != null)
                tabControl1.SelectedTab = tabPage4;
        }

        private void BtnSuppliers_Click(object sender, EventArgs e)
        {
            if (tabControl1 != null && tabPage5 != null)
                tabControl1.SelectedTab = tabPage5;
        }

        private void BtnCustomers_Click(object sender, EventArgs e)
        {
            if (tabControl1 != null && tabPage6 != null)
                tabControl1.SelectedTab = tabPage6;
        }

        private void BtnSettings_Click(object sender, EventArgs e)
        {
            if (tabControl1 != null && tabPage7 != null)
                tabControl1.SelectedTab = tabPage7;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
