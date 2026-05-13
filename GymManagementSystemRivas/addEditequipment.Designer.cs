namespace GymManagementSystemRivas
{
    partial class addEditequipment
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
            lblTitle = new Label();
            txtStatus = new TextBox();
            txtQuantity = new TextBox();
            txtEquipName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            lblID = new Label();
            label6 = new Label();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(220, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(180, 32);
            lblTitle.TabIndex = 28;
            lblTitle.Text = "Add Equipment";
            lblTitle.Click += lblTitle_Click;
            // 
            // txtStatus
            // 
            txtStatus.Location = new Point(331, 191);
            txtStatus.Name = "txtStatus";
            txtStatus.Size = new Size(145, 23);
            txtStatus.TabIndex = 49;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(331, 147);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(145, 23);
            txtQuantity.TabIndex = 48;
            // 
            // txtEquipName
            // 
            txtEquipName.Location = new Point(331, 107);
            txtEquipName.Name = "txtEquipName";
            txtEquipName.Size = new Size(145, 23);
            txtEquipName.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(175, 201);
            label4.Name = "label4";
            label4.Size = new Size(42, 15);
            label4.TabIndex = 46;
            label4.Text = "Status:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(175, 160);
            label3.Name = "label3";
            label3.Size = new Size(56, 15);
            label3.TabIndex = 45;
            label3.Text = "Quantity:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(174, 115);
            label2.Name = "label2";
            label2.Size = new Size(101, 15);
            label2.TabIndex = 44;
            label2.Text = "Equipment name:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(331, 79);
            lblID.Name = "lblID";
            lblID.Size = new Size(13, 15);
            lblID.TabIndex = 43;
            lblID.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(175, 79);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 42;
            label6.Text = "ID:";
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(331, 251);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 51;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(190, 251);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 50;
            btnSave.Text = " Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // addEditequipment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(646, 355);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtStatus);
            Controls.Add(txtQuantity);
            Controls.Add(txtEquipName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(lblID);
            Controls.Add(label6);
            Controls.Add(lblTitle);
            Name = "addEditequipment";
            Text = "addEditequipment";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        public TextBox txtStatus;
        public TextBox txtQuantity;
        public TextBox txtEquipName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label lblID;
        private Label label6;
        public Button btnCancel;
        public Button btnSave;
    }
}