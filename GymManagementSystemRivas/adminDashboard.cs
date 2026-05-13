using GymManagementSystemRivas;
using GymManagementSystemRivas.models;
using GymManagementSystemRivas.repositories;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static GymManagementSystemRivas.repositories.equipmentRepository;

namespace GymMamagementSystemRivas
{

    public partial class adminDashboard : Form
    {
        private string _username;

        public adminDashboard()
        {
            InitializeComponent();
            readAdmin();
            readMember();
            readCoach();
            readSubscription();
            readEquipment();
            btnDashboard.Click += BtnDashboard_Click;
            btnSalesOrders.Click += BtnSalesOrders_Click;
            btnPurchases.Click += BtnPurchases_Click;
            btnProducts.Click += BtnProducts_Click;
            btnSuppliers.Click += BtnSuppliers_Click;
            btnCustomers.Click += BtnCustomers_Click;
            btnSettings.Click += BtnSettings_Click;
        }

        private void readAdmin()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("First Name");
            dataTable.Columns.Add("Last Name");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Role");
            dataTable.Columns.Add("Password");

            var repo = new adminRepository();
            var admins = repo.GetAdmins();

            foreach (var admin in admins)
            {
                var row = dataTable.NewRow();

                row["ID"] = admin.admin_id;
                row["First Name"] = admin.admin_fname;
                row["Last Name"] = admin.admin_lname;
                row["Email"] = admin.admin_email;
                row["Role"] = admin.admin_role;
                row["Password"] = admin.admin_password;

                dataTable.Rows.Add(row);
            }
            this.adminTable.DataSource = dataTable;
        }

        private void readMember()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("First Name");
            dataTable.Columns.Add("Last Name");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Password");

            var repo = new memRepository();
            var members = repo.GetMembers();

            foreach (var member in members)
            {
                var row = dataTable.NewRow();

                row["ID"] = member.mem_id;
                row["First Name"] = member.mem_fname;
                row["Last Name"] = member.mem_lname;
                row["Email"] = member.mem_email;
                row["Password"] = member.mem_password;

                dataTable.Rows.Add(row);
            }
            this.memberTable.DataSource = dataTable;
        }

        private void readCoach()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("First Name");
            dataTable.Columns.Add("Last Name");
            dataTable.Columns.Add("Email");
            dataTable.Columns.Add("Password");

            var repo = new coachRepository();
            var coaches = repo.GetCoach();

            foreach (var coach in coaches)
            {
                var row = dataTable.NewRow();

                row["ID"] = coach.coach_id;
                row["First Name"] = coach.coach_fname;
                row["Last Name"] = coach.coach_lname;
                row["Email"] = coach.email;
                row["Password"] = coach.password;

                dataTable.Rows.Add(row);
            }
            this.coachTable.DataSource = dataTable;
        }
        private void readEquipment()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Name");
            dataTable.Columns.Add("Quantity");
            dataTable.Columns.Add("Status");

            var repo = new equipRepository();
            var equipments = repo.GetEquipments();

            foreach (var equipment in equipments)
            {
                var row = dataTable.NewRow();

                row["ID"] = equipment.equip_id;
                row["Name"] = equipment.name;
                row["Quantity"] = equipment.quantity;
                row["Status"] = equipment.status;

                dataTable.Rows.Add(row);
            }
            this.equipmentTable.DataSource = dataTable;
        }

        private void readSubscription()
        {
            DataTable dataTable = new DataTable();

            dataTable.Columns.Add("ID");
            dataTable.Columns.Add("Plan");
            dataTable.Columns.Add("Duration (Days)");
            dataTable.Columns.Add("Price");

            var repo = new subscriptionRepository();
            var subscriptions = repo.GetSubscriptions();

            foreach (var sub in subscriptions)
            {
                var row = dataTable.NewRow();

                row["ID"] = sub.subscription_id;
                row["Plan"] = sub.plan;
                row["Duration (Days)"] = sub.duration;
                row["Price"] = sub.price;

                dataTable.Rows.Add(row);
            }
            this.subscriptionTable.DataSource = dataTable;
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
            var result = MessageBox.Show("Are you sure you want to log out?", "Confirm Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void adminDashboard_Load(object sender, EventArgs e)
        {
        }

        private void panelLeft_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelUser_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelUser_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void btnCustomers_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStaffManagement_Click(object sender, EventArgs e)
        {
            if (tabControl1 != null && tabPage8 != null)
                tabControl1.SelectedTab = tabPage8;
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new addEditStaff().Show();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDashboard_Click_1(object sender, EventArgs e)
        {

        }

        private void btnProducts_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBoxLogo_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnStaff_Click(object sender, EventArgs e)
        {
            if (tabControl1 != null && tabPage8 != null)
                tabControl1.SelectedTab = tabPage8;
        }

        private void btnAddAdmin_Click(object sender, EventArgs e)
        {
            addEditStaff form = new addEditStaff();
            if (form.ShowDialog() == DialogResult.OK)
            {
                readAdmin();
            }
        }

        private void btnEditAdmin_Click(object sender, EventArgs e)
        {
            if (this.adminTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an entire row by clicking the far left header.");
                return;
            }
            var val = this.adminTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int admin_id = int.Parse(val);

            var repo = new adminRepository();
            var admin = repo.GetAdmin(admin_id);


            addEditStaff form = new addEditStaff();
            form.EditAdmin(admin);
            if (form.ShowDialog() == DialogResult.OK)
            {
                readAdmin();
            }
        }

        private void btnDeleteAdmin_Click(object sender, EventArgs e)
        {
            var val = this.adminTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int admin_id = int.Parse(val);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            var repo = new adminRepository();
            repo.deleteAdmin(admin_id);
            readAdmin();

        }

        private void btnAddMember_Click(object sender, EventArgs e)
        {
            addEditMember form = new addEditMember();
            if (form.ShowDialog() == DialogResult.OK)
            {
                readMember();
            }
        }

        private void btnEditMember_Click(object sender, EventArgs e)
        {
            if (this.memberTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an entire row by clicking the far left header.");
                return;
            }
            var val = this.memberTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int member_id = int.Parse(val);

            var repo = new memRepository();
            var member = repo.GetMember(member_id);


            addEditMember form = new addEditMember();
            form.EditMember(member);
            if (form.ShowDialog() == DialogResult.OK)
            {
                readMember();
            }
        }

        private void btnDeleteMember_Click(object sender, EventArgs e)
        {
            var val = this.memberTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int member_id = int.Parse(val);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            var repo = new memRepository();
            repo.deleteMember(member_id);
            readMember();
        }

        private void btnAddCoach_Click(object sender, EventArgs e)
        {
            addEditCoach form = new addEditCoach();
            if (form.ShowDialog() == DialogResult.OK)
            {
                readCoach();
            }
        }

        private void btnEditCoach_Click(object sender, EventArgs e)
        {
            if (this.coachTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an entire row by clicking the far left header.");
                return;
            }
            var val = this.coachTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int coach_id = int.Parse(val);

            var repo = new coachRepository();
            var coach = repo.GetCoach(coach_id);


            addEditCoach form = new addEditCoach();
            form.EditCoach(coach);
            if (form.ShowDialog() == DialogResult.OK)
            {
                readCoach();
            }
        }

        private void btnDeleteCoach_Click(object sender, EventArgs e)
        {
            var val = this.coachTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int coach_id = int.Parse(val);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }
            var repo = new coachRepository();
            repo.deleteCoach(coach_id);
            readCoach();
        }

        private void btnAddEquipment_Click(object sender, EventArgs e)
        {
            addEditequipment form = new addEditequipment();
            if (form.ShowDialog() == DialogResult.OK)
            {
                readEquipment();
            }
        }

        private void btnEditEquipment_Click(object sender, EventArgs e)
        {
            if (this.equipmentTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an entire row by clicking the far left header.");
                return;
            }

            var val = this.equipmentTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int equip_id = int.Parse(val);

            var repo = new equipRepository();
            var equipment = repo.GetEquipment(equip_id);

            addEditequipment form = new addEditequipment();
            form.EditEquipment(equipment);

            if (form.ShowDialog() == DialogResult.OK)
            {
                readEquipment();
            }

        }

        private void btnDeleteEquipment_Click(object sender, EventArgs e)
        {
            var val = this.equipmentTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int equip_id = int.Parse(val);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var repo = new equipRepository();
            repo.deleteEquipment(equip_id);
            readEquipment();
        }

        private void btnAddSubscription_Click(object sender, EventArgs e)
        {
            addEditSubscription form = new addEditSubscription();
            if (form.ShowDialog() == DialogResult.OK)
            {
                readEquipment();
            }
        }

        private void btnEditSubscription_Click(object sender, EventArgs e)
        {
            if (this.subscriptionTable.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an entire row by clicking the far left header.");
                return;
            }

            var val = this.subscriptionTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int subscription_id = int.Parse(val);

            var repo = new subscriptionRepository();
            var subscription = repo.GetSubscription(subscription_id);

      
            addEditSubscription form = new addEditSubscription();
        
            if (form.ShowDialog() == DialogResult.OK)
            {
                readSubscription();
            }
        }

        private void btnDeleteSubscription_Click(object sender, EventArgs e)
        {
            var val = this.subscriptionTable.SelectedRows[0].Cells[0].Value.ToString();
            if (val == null || val.Length == 0) return;

            int subscription_id = int.Parse(val);

            DialogResult dialogResult = MessageBox.Show("Are you sure you want to delete?", "Confirm Delete", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.No)
            {
                return;
            }

            var repo = new subscriptionRepository();
            repo.deleteSubscription(subscription_id);
            readSubscription();
        }
    }
}
