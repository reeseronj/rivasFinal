namespace GymMamagementSystemRivas
{
    partial class adminDashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelTop = new Panel();
            pictureBoxLogo = new PictureBox();
            btnClose = new Button();
            btnMaximize = new Button();
            btnMinimize = new Button();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            memberTable = new DataGridView();
            btnDeleteMember = new Button();
            btnEditMember = new Button();
            btnAddMember = new Button();
            label4 = new Label();
            tabPage2 = new TabPage();
            subscriptionTable = new DataGridView();
            btnDeleteSubscription = new Button();
            btnEditSubscription = new Button();
            btnAddSubscription = new Button();
            label7 = new Label();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            tabPage5 = new TabPage();
            coachTable = new DataGridView();
            btnDeleteCoach = new Button();
            btnEditCoach = new Button();
            btnAddCoach = new Button();
            label5 = new Label();
            tabPage6 = new TabPage();
            btnDeleteEquipment = new Button();
            btnEditEquipment = new Button();
            btnAddEquipment = new Button();
            label6 = new Label();
            equipmentTable = new DataGridView();
            tabPage7 = new TabPage();
            tabPage8 = new TabPage();
            adminTable = new DataGridView();
            btnDeleteAdmin = new Button();
            btnEditAdmin = new Button();
            btnAddAdmin = new Button();
            label3 = new Label();
            panelLeft = new Panel();
            btnStaff = new Button();
            btnLogout = new Button();
            btnSettings = new Button();
            btnCustomers = new Button();
            btnSuppliers = new Button();
            btnProducts = new Button();
            btnPurchases = new Button();
            btnSalesOrders = new Button();
            btnDashboard = new Button();
            panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).BeginInit();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)memberTable).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)subscriptionTable).BeginInit();
            tabPage5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)coachTable).BeginInit();
            tabPage6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)equipmentTable).BeginInit();
            tabPage8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)adminTable).BeginInit();
            panelLeft.SuspendLayout();
            SuspendLayout();
            // 
            // panelTop
            // 
            panelTop.BackColor = Color.FromArgb(3, 71, 72);
            panelTop.Controls.Add(pictureBoxLogo);
            panelTop.Controls.Add(btnClose);
            panelTop.Controls.Add(btnMaximize);
            panelTop.Controls.Add(btnMinimize);
            panelTop.Dock = DockStyle.Top;
            panelTop.Location = new Point(0, 0);
            panelTop.Margin = new Padding(3, 2, 3, 2);
            panelTop.Name = "panelTop";
            panelTop.Size = new Size(1072, 48);
            panelTop.TabIndex = 2;
            panelTop.Paint += panelTop_Paint;
            // 
            // pictureBoxLogo
            // 
            pictureBoxLogo.BackColor = Color.White;
            pictureBoxLogo.Location = new Point(7, 6);
            pictureBoxLogo.Margin = new Padding(3, 2, 3, 2);
            pictureBoxLogo.Name = "pictureBoxLogo";
            pictureBoxLogo.Size = new Size(42, 36);
            pictureBoxLogo.TabIndex = 0;
            pictureBoxLogo.TabStop = false;
            // 
            // btnClose
            // 
            btnClose.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnClose.FlatStyle = FlatStyle.Flat;
            btnClose.ForeColor = Color.White;
            btnClose.Location = new Point(1876, 14);
            btnClose.Margin = new Padding(3, 2, 3, 2);
            btnClose.Name = "btnClose";
            btnClose.Size = new Size(32, 21);
            btnClose.TabIndex = 3;
            btnClose.Text = "X";
            btnClose.Visible = false;
            // 
            // btnMaximize
            // 
            btnMaximize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMaximize.FlatStyle = FlatStyle.Flat;
            btnMaximize.ForeColor = Color.White;
            btnMaximize.Location = new Point(1838, 14);
            btnMaximize.Margin = new Padding(3, 2, 3, 2);
            btnMaximize.Name = "btnMaximize";
            btnMaximize.Size = new Size(32, 21);
            btnMaximize.TabIndex = 4;
            btnMaximize.Text = "▢";
            btnMaximize.Visible = false;
            // 
            // btnMinimize
            // 
            btnMinimize.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnMinimize.FlatStyle = FlatStyle.Flat;
            btnMinimize.ForeColor = Color.White;
            btnMinimize.Location = new Point(1800, 14);
            btnMinimize.Margin = new Padding(3, 2, 3, 2);
            btnMinimize.Name = "btnMinimize";
            btnMinimize.Size = new Size(32, 21);
            btnMinimize.TabIndex = 5;
            btnMinimize.Text = "_";
            btnMinimize.Visible = false;
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage6);
            tabControl1.Controls.Add(tabPage7);
            tabControl1.Controls.Add(tabPage8);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.ItemSize = new Size(0, 1);
            tabControl1.Location = new Point(175, 48);
            tabControl1.Margin = new Padding(3, 2, 3, 2);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(897, 537);
            tabControl1.SizeMode = TabSizeMode.Fixed;
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.DimGray;
            tabPage1.Controls.Add(memberTable);
            tabPage1.Controls.Add(btnDeleteMember);
            tabPage1.Controls.Add(btnEditMember);
            tabPage1.Controls.Add(btnAddMember);
            tabPage1.Controls.Add(label4);
            tabPage1.Location = new Point(4, 5);
            tabPage1.Margin = new Padding(3, 2, 3, 2);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3, 2, 3, 2);
            tabPage1.Size = new Size(889, 528);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "tabPage1";
            tabPage1.Click += tabPage1_Click;
            // 
            // memberTable
            // 
            memberTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            memberTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            memberTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            memberTable.Location = new Point(12, 91);
            memberTable.MultiSelect = false;
            memberTable.Name = "memberTable";
            memberTable.RowHeadersVisible = false;
            memberTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            memberTable.Size = new Size(869, 429);
            memberTable.TabIndex = 6;
            // 
            // btnDeleteMember
            // 
            btnDeleteMember.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteMember.Location = new Point(793, 63);
            btnDeleteMember.Name = "btnDeleteMember";
            btnDeleteMember.Size = new Size(75, 23);
            btnDeleteMember.TabIndex = 5;
            btnDeleteMember.Text = "Delete";
            btnDeleteMember.UseVisualStyleBackColor = true;
            btnDeleteMember.Click += btnDeleteMember_Click;
            // 
            // btnEditMember
            // 
            btnEditMember.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditMember.Location = new Point(682, 63);
            btnEditMember.Name = "btnEditMember";
            btnEditMember.Size = new Size(89, 23);
            btnEditMember.TabIndex = 4;
            btnEditMember.Text = "Edit Member";
            btnEditMember.UseVisualStyleBackColor = true;
            btnEditMember.Click += btnEditMember_Click;
            // 
            // btnAddMember
            // 
            btnAddMember.Location = new Point(19, 63);
            btnAddMember.Name = "btnAddMember";
            btnAddMember.Size = new Size(95, 23);
            btnAddMember.TabIndex = 3;
            btnAddMember.Text = "Add Member";
            btnAddMember.UseVisualStyleBackColor = true;
            btnAddMember.Click += btnAddMember_Click;
            // 
            // label4
            // 
            label4.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label4.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(5, 2);
            label4.Name = "label4";
            label4.Size = new Size(878, 32);
            label4.TabIndex = 2;
            label4.Text = "Members";
            label4.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.Gray;
            tabPage2.Controls.Add(subscriptionTable);
            tabPage2.Controls.Add(btnDeleteSubscription);
            tabPage2.Controls.Add(btnEditSubscription);
            tabPage2.Controls.Add(btnAddSubscription);
            tabPage2.Controls.Add(label7);
            tabPage2.Location = new Point(4, 5);
            tabPage2.Margin = new Padding(3, 2, 3, 2);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3, 2, 3, 2);
            tabPage2.Size = new Size(889, 528);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "tabPage2";
            tabPage2.Click += tabPage2_Click;
            // 
            // subscriptionTable
            // 
            subscriptionTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            subscriptionTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            subscriptionTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            subscriptionTable.Location = new Point(14, 79);
            subscriptionTable.MultiSelect = false;
            subscriptionTable.Name = "subscriptionTable";
            subscriptionTable.RowHeadersVisible = false;
            subscriptionTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            subscriptionTable.Size = new Size(869, 429);
            subscriptionTable.TabIndex = 12;
            // 
            // btnDeleteSubscription
            // 
            btnDeleteSubscription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteSubscription.Location = new Point(789, 50);
            btnDeleteSubscription.Name = "btnDeleteSubscription";
            btnDeleteSubscription.Size = new Size(75, 23);
            btnDeleteSubscription.TabIndex = 11;
            btnDeleteSubscription.Text = "Delete";
            btnDeleteSubscription.UseVisualStyleBackColor = true;
            btnDeleteSubscription.Click += btnDeleteSubscription_Click;
            // 
            // btnEditSubscription
            // 
            btnEditSubscription.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditSubscription.Location = new Point(661, 50);
            btnEditSubscription.Name = "btnEditSubscription";
            btnEditSubscription.Size = new Size(106, 23);
            btnEditSubscription.TabIndex = 10;
            btnEditSubscription.Text = "Edit Subscription";
            btnEditSubscription.UseVisualStyleBackColor = true;
            btnEditSubscription.Click += btnEditSubscription_Click;
            // 
            // btnAddSubscription
            // 
            btnAddSubscription.Location = new Point(15, 50);
            btnAddSubscription.Name = "btnAddSubscription";
            btnAddSubscription.Size = new Size(110, 23);
            btnAddSubscription.TabIndex = 9;
            btnAddSubscription.Text = "Add Subscription";
            btnAddSubscription.UseVisualStyleBackColor = true;
            btnAddSubscription.Click += btnAddSubscription_Click;
            // 
            // label7
            // 
            label7.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(0, 2);
            label7.Name = "label7";
            label7.Size = new Size(878, 32);
            label7.TabIndex = 4;
            label7.Text = "Subscription";
            label7.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.DarkGray;
            tabPage3.Location = new Point(4, 5);
            tabPage3.Margin = new Padding(3, 2, 3, 2);
            tabPage3.Name = "tabPage3";
            tabPage3.Size = new Size(889, 528);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "tabPage3";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.Silver;
            tabPage4.Location = new Point(4, 5);
            tabPage4.Margin = new Padding(3, 2, 3, 2);
            tabPage4.Name = "tabPage4";
            tabPage4.Size = new Size(889, 528);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "tabPage4";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.LightGray;
            tabPage5.Controls.Add(coachTable);
            tabPage5.Controls.Add(btnDeleteCoach);
            tabPage5.Controls.Add(btnEditCoach);
            tabPage5.Controls.Add(btnAddCoach);
            tabPage5.Controls.Add(label5);
            tabPage5.Location = new Point(4, 5);
            tabPage5.Margin = new Padding(3, 2, 3, 2);
            tabPage5.Name = "tabPage5";
            tabPage5.Size = new Size(889, 528);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "tabPage5";
            // 
            // coachTable
            // 
            coachTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            coachTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            coachTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            coachTable.Location = new Point(3, 73);
            coachTable.MultiSelect = false;
            coachTable.Name = "coachTable";
            coachTable.RowHeadersVisible = false;
            coachTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            coachTable.Size = new Size(869, 429);
            coachTable.TabIndex = 9;
            // 
            // btnDeleteCoach
            // 
            btnDeleteCoach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteCoach.Location = new Point(776, 42);
            btnDeleteCoach.Name = "btnDeleteCoach";
            btnDeleteCoach.Size = new Size(75, 23);
            btnDeleteCoach.TabIndex = 8;
            btnDeleteCoach.Text = "Delete";
            btnDeleteCoach.UseVisualStyleBackColor = true;
            btnDeleteCoach.Click += btnDeleteCoach_Click;
            // 
            // btnEditCoach
            // 
            btnEditCoach.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditCoach.Location = new Point(665, 42);
            btnEditCoach.Name = "btnEditCoach";
            btnEditCoach.Size = new Size(89, 23);
            btnEditCoach.TabIndex = 7;
            btnEditCoach.Text = "Edit Coach";
            btnEditCoach.UseVisualStyleBackColor = true;
            btnEditCoach.Click += btnEditCoach_Click;
            // 
            // btnAddCoach
            // 
            btnAddCoach.Location = new Point(2, 42);
            btnAddCoach.Name = "btnAddCoach";
            btnAddCoach.Size = new Size(95, 23);
            btnAddCoach.TabIndex = 6;
            btnAddCoach.Text = "Add Coach";
            btnAddCoach.UseVisualStyleBackColor = true;
            btnAddCoach.Click += btnAddCoach_Click;
            // 
            // label5
            // 
            label5.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label5.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(2, 0);
            label5.Name = "label5";
            label5.Size = new Size(878, 32);
            label5.TabIndex = 3;
            label5.Text = "Coaches";
            label5.TextAlign = ContentAlignment.TopCenter;
            // 
            // tabPage6
            // 
            tabPage6.BackColor = Color.RosyBrown;
            tabPage6.Controls.Add(btnDeleteEquipment);
            tabPage6.Controls.Add(btnEditEquipment);
            tabPage6.Controls.Add(btnAddEquipment);
            tabPage6.Controls.Add(label6);
            tabPage6.Controls.Add(equipmentTable);
            tabPage6.Location = new Point(4, 5);
            tabPage6.Margin = new Padding(3, 2, 3, 2);
            tabPage6.Name = "tabPage6";
            tabPage6.Size = new Size(889, 528);
            tabPage6.TabIndex = 5;
            tabPage6.Text = "tabPage6";
            // 
            // btnDeleteEquipment
            // 
            btnDeleteEquipment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteEquipment.Location = new Point(797, 62);
            btnDeleteEquipment.Name = "btnDeleteEquipment";
            btnDeleteEquipment.Size = new Size(75, 23);
            btnDeleteEquipment.TabIndex = 14;
            btnDeleteEquipment.Text = "Delete";
            btnDeleteEquipment.UseVisualStyleBackColor = true;
            btnDeleteEquipment.Click += btnDeleteEquipment_Click;
            // 
            // btnEditEquipment
            // 
            btnEditEquipment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditEquipment.Location = new Point(674, 62);
            btnEditEquipment.Name = "btnEditEquipment";
            btnEditEquipment.Size = new Size(101, 23);
            btnEditEquipment.TabIndex = 13;
            btnEditEquipment.Text = "Edit Equipment";
            btnEditEquipment.UseVisualStyleBackColor = true;
            btnEditEquipment.Click += btnEditEquipment_Click;
            // 
            // btnAddEquipment
            // 
            btnAddEquipment.Location = new Point(23, 62);
            btnAddEquipment.Name = "btnAddEquipment";
            btnAddEquipment.Size = new Size(106, 23);
            btnAddEquipment.TabIndex = 12;
            btnAddEquipment.Text = "Add Equipment";
            btnAddEquipment.UseVisualStyleBackColor = true;
            btnAddEquipment.Click += btnAddEquipment_Click;
            // 
            // label6
            // 
            label6.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(8, 2);
            label6.Name = "label6";
            label6.Size = new Size(878, 32);
            label6.TabIndex = 11;
            label6.Text = "Equipments";
            label6.TextAlign = ContentAlignment.TopCenter;
            // 
            // equipmentTable
            // 
            equipmentTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            equipmentTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            equipmentTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            equipmentTable.Location = new Point(12, 91);
            equipmentTable.MultiSelect = false;
            equipmentTable.Name = "equipmentTable";
            equipmentTable.RowHeadersVisible = false;
            equipmentTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            equipmentTable.Size = new Size(869, 429);
            equipmentTable.TabIndex = 10;
            // 
            // tabPage7
            // 
            tabPage7.BackColor = Color.LightCoral;
            tabPage7.Location = new Point(4, 5);
            tabPage7.Margin = new Padding(3, 2, 3, 2);
            tabPage7.Name = "tabPage7";
            tabPage7.Size = new Size(889, 528);
            tabPage7.TabIndex = 6;
            tabPage7.Text = "tabPage7";
            // 
            // tabPage8
            // 
            tabPage8.BackColor = Color.Chocolate;
            tabPage8.Controls.Add(adminTable);
            tabPage8.Controls.Add(btnDeleteAdmin);
            tabPage8.Controls.Add(btnEditAdmin);
            tabPage8.Controls.Add(btnAddAdmin);
            tabPage8.Controls.Add(label3);
            tabPage8.Location = new Point(4, 5);
            tabPage8.Margin = new Padding(3, 2, 3, 2);
            tabPage8.Name = "tabPage8";
            tabPage8.Size = new Size(889, 528);
            tabPage8.TabIndex = 7;
            tabPage8.Text = "tabPage8";
            // 
            // adminTable
            // 
            adminTable.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            adminTable.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            adminTable.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            adminTable.Location = new Point(12, 91);
            adminTable.MultiSelect = false;
            adminTable.Name = "adminTable";
            adminTable.RowHeadersVisible = false;
            adminTable.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            adminTable.Size = new Size(869, 429);
            adminTable.TabIndex = 5;
            // 
            // btnDeleteAdmin
            // 
            btnDeleteAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnDeleteAdmin.Location = new Point(781, 62);
            btnDeleteAdmin.Name = "btnDeleteAdmin";
            btnDeleteAdmin.Size = new Size(83, 23);
            btnDeleteAdmin.TabIndex = 4;
            btnDeleteAdmin.Text = "Delete";
            btnDeleteAdmin.UseVisualStyleBackColor = true;
            btnDeleteAdmin.Click += btnDeleteAdmin_Click;
            // 
            // btnEditAdmin
            // 
            btnEditAdmin.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnEditAdmin.Location = new Point(685, 62);
            btnEditAdmin.Name = "btnEditAdmin";
            btnEditAdmin.Size = new Size(83, 23);
            btnEditAdmin.TabIndex = 3;
            btnEditAdmin.Text = "Edit Admin";
            btnEditAdmin.UseVisualStyleBackColor = true;
            btnEditAdmin.Click += btnEditAdmin_Click;
            // 
            // btnAddAdmin
            // 
            btnAddAdmin.Location = new Point(24, 62);
            btnAddAdmin.Name = "btnAddAdmin";
            btnAddAdmin.Size = new Size(83, 23);
            btnAddAdmin.TabIndex = 2;
            btnAddAdmin.Text = "Add Admin";
            btnAddAdmin.UseVisualStyleBackColor = true;
            btnAddAdmin.Click += btnAddAdmin_Click;
            // 
            // label3
            // 
            label3.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(3, 15);
            label3.Name = "label3";
            label3.Size = new Size(878, 32);
            label3.TabIndex = 1;
            label3.Text = "Staff Management";
            label3.TextAlign = ContentAlignment.TopCenter;
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(2, 67, 66);
            panelLeft.Controls.Add(btnStaff);
            panelLeft.Controls.Add(btnLogout);
            panelLeft.Controls.Add(btnSettings);
            panelLeft.Controls.Add(btnCustomers);
            panelLeft.Controls.Add(btnSuppliers);
            panelLeft.Controls.Add(btnProducts);
            panelLeft.Controls.Add(btnPurchases);
            panelLeft.Controls.Add(btnSalesOrders);
            panelLeft.Controls.Add(btnDashboard);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 48);
            panelLeft.Margin = new Padding(3, 2, 3, 2);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(175, 537);
            panelLeft.TabIndex = 1;
            // 
            // btnStaff
            // 
            btnStaff.Dock = DockStyle.Bottom;
            btnStaff.FlatStyle = FlatStyle.Flat;
            btnStaff.ForeColor = Color.White;
            btnStaff.Location = new Point(0, 420);
            btnStaff.Margin = new Padding(3, 2, 3, 2);
            btnStaff.Name = "btnStaff";
            btnStaff.Size = new Size(175, 39);
            btnStaff.TabIndex = 8;
            btnStaff.Text = "Staff Management";
            btnStaff.TextAlign = ContentAlignment.MiddleLeft;
            btnStaff.UseVisualStyleBackColor = true;
            btnStaff.Click += btnStaff_Click;
            // 
            // btnLogout
            // 
            btnLogout.Dock = DockStyle.Bottom;
            btnLogout.FlatStyle = FlatStyle.Flat;
            btnLogout.ForeColor = Color.White;
            btnLogout.Location = new Point(0, 459);
            btnLogout.Margin = new Padding(3, 2, 3, 2);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(175, 39);
            btnLogout.TabIndex = 0;
            btnLogout.Text = "  Logout";
            btnLogout.TextAlign = ContentAlignment.MiddleLeft;
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // btnSettings
            // 
            btnSettings.Dock = DockStyle.Bottom;
            btnSettings.FlatStyle = FlatStyle.Flat;
            btnSettings.ForeColor = Color.White;
            btnSettings.Location = new Point(0, 498);
            btnSettings.Margin = new Padding(3, 2, 3, 2);
            btnSettings.Name = "btnSettings";
            btnSettings.Size = new Size(175, 39);
            btnSettings.TabIndex = 1;
            btnSettings.Text = "  Settings";
            btnSettings.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnCustomers
            // 
            btnCustomers.Dock = DockStyle.Top;
            btnCustomers.FlatStyle = FlatStyle.Flat;
            btnCustomers.ForeColor = Color.White;
            btnCustomers.Location = new Point(0, 195);
            btnCustomers.Margin = new Padding(3, 2, 3, 2);
            btnCustomers.Name = "btnCustomers";
            btnCustomers.Size = new Size(175, 39);
            btnCustomers.TabIndex = 2;
            btnCustomers.Text = "Equipments";
            btnCustomers.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSuppliers
            // 
            btnSuppliers.Dock = DockStyle.Top;
            btnSuppliers.FlatStyle = FlatStyle.Flat;
            btnSuppliers.ForeColor = Color.White;
            btnSuppliers.Location = new Point(0, 156);
            btnSuppliers.Margin = new Padding(3, 2, 3, 2);
            btnSuppliers.Name = "btnSuppliers";
            btnSuppliers.Size = new Size(175, 39);
            btnSuppliers.TabIndex = 3;
            btnSuppliers.Text = "Coaches";
            btnSuppliers.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnProducts
            // 
            btnProducts.Dock = DockStyle.Top;
            btnProducts.FlatStyle = FlatStyle.Flat;
            btnProducts.ForeColor = Color.White;
            btnProducts.Location = new Point(0, 117);
            btnProducts.Margin = new Padding(3, 2, 3, 2);
            btnProducts.Name = "btnProducts";
            btnProducts.Size = new Size(175, 39);
            btnProducts.TabIndex = 4;
            btnProducts.Text = "Activity Logs";
            btnProducts.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnPurchases
            // 
            btnPurchases.Dock = DockStyle.Top;
            btnPurchases.FlatStyle = FlatStyle.Flat;
            btnPurchases.ForeColor = Color.White;
            btnPurchases.Location = new Point(0, 78);
            btnPurchases.Margin = new Padding(3, 2, 3, 2);
            btnPurchases.Name = "btnPurchases";
            btnPurchases.Size = new Size(175, 39);
            btnPurchases.TabIndex = 5;
            btnPurchases.Text = "Payment History";
            btnPurchases.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnSalesOrders
            // 
            btnSalesOrders.Dock = DockStyle.Top;
            btnSalesOrders.FlatStyle = FlatStyle.Flat;
            btnSalesOrders.ForeColor = Color.White;
            btnSalesOrders.Location = new Point(0, 39);
            btnSalesOrders.Margin = new Padding(3, 2, 3, 2);
            btnSalesOrders.Name = "btnSalesOrders";
            btnSalesOrders.Size = new Size(175, 39);
            btnSalesOrders.TabIndex = 6;
            btnSalesOrders.Text = "Subscriptions";
            btnSalesOrders.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // btnDashboard
            // 
            btnDashboard.Dock = DockStyle.Top;
            btnDashboard.FlatStyle = FlatStyle.Flat;
            btnDashboard.ForeColor = Color.White;
            btnDashboard.Location = new Point(0, 0);
            btnDashboard.Margin = new Padding(3, 2, 3, 2);
            btnDashboard.Name = "btnDashboard";
            btnDashboard.Size = new Size(175, 39);
            btnDashboard.TabIndex = 7;
            btnDashboard.Text = "Members";
            btnDashboard.TextAlign = ContentAlignment.MiddleLeft;
            btnDashboard.Click += btnDashboard_Click_1;
            // 
            // adminDashboard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1072, 585);
            Controls.Add(tabControl1);
            Controls.Add(panelLeft);
            Controls.Add(panelTop);
            Margin = new Padding(3, 2, 3, 2);
            Name = "adminDashboard";
            Text = " ";
            WindowState = FormWindowState.Maximized;
            Load += adminDashboard_Load;
            panelTop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBoxLogo).EndInit();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)memberTable).EndInit();
            tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)subscriptionTable).EndInit();
            tabPage5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)coachTable).EndInit();
            tabPage6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)equipmentTable).EndInit();
            tabPage8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)adminTable).EndInit();
            panelLeft.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTop;
        private PictureBox pictureBoxLogo;
        private Panel panelUser;
        private Label lblDate;
        private Label lblTime;
        private Label lblRole;
        private Label lblFullName;
        private Label lblUsername;
        private Button btnClose;
        private Button btnMaximize;
        private Button btnMinimize;
        private Panel panelLeft;
        private Button btnSettings;
        private Button btnCustomers;
        private Button btnSuppliers;
        private Button btnProducts;
        private Button btnPurchases;
        private Button btnSalesOrders;
        private Button btnDashboard;
        private Label label1;
        private Button btnLogout;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private TabPage tabPage6;
        private TabPage tabPage7;
        private TabPage tabPage8;
        private Panel panel1;
        private Label label2;
        private TabControl tabControl2;
        private TabPage tabPage9;
        private TabPage tabPage10;
        private TabPage tabPage11;
        private TabPage tabPage12;
        private TabPage tabPage13;
        private TabPage tabPage14;
        private TabPage tabPage15;
        private TabPage tabPage16;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnStaff;
        private Button btnAddAdmin;
        private Label label3;
        private Button btnEditMember;
        private Button btnEditAdmin;
        private Button btnDeleteAdmin;
        private DataGridView adminTable;
        private Button btnAddMember;
        private Label label4;
        private Button btnDeleteMember;
        private DataGridView dataMember;
        private DataGridView memberTable;
        private DataGridView dataGridView1;
        private Button button1;
        private Button button2;
        private Button btnAddCoach;
        private Label label5;
        private DataGridView coachTable;
        private Button btnDeleteCoach;
        private Button btnEditCoach;
        private Button btnDeleteEquipment;
        private Button btnEditEquipment;
        private Button btnAddEquipment;
        private Label label6;
        private DataGridView equipmentTable;
        private DataGridView subscriptionTable;
        private Button btnDeleteSubscription;
        private Button btnEditSubscription;
        private Button btnAddSubscription;
        private Label label7;
    }
}