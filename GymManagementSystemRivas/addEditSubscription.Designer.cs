namespace GymManagementSystemRivas
{
    partial class addEditSubscription
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
            label4 = new Label();
            label3 = new Label();
            label10 = new Label();
            lblID = new Label();
            label6 = new Label();
            txtPrice = new TextBox();
            txtDuration = new TextBox();
            txtPlan = new TextBox();
            btnCancel = new Button();
            btnSave = new Button();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(232, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(130, 32);
            lblTitle.TabIndex = 28;
            lblTitle.Text = "Add Coach";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(174, 204);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 42;
            label4.Text = "Price:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(174, 163);
            label3.Name = "label3";
            label3.Size = new Size(83, 15);
            label3.TabIndex = 41;
            label3.Text = "Duration(day):";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(173, 118);
            label10.Name = "label10";
            label10.Size = new Size(33, 15);
            label10.TabIndex = 40;
            label10.Text = "Plan:";
            // 
            // lblID
            // 
            lblID.AutoSize = true;
            lblID.Location = new Point(330, 82);
            lblID.Name = "lblID";
            lblID.Size = new Size(13, 15);
            lblID.TabIndex = 39;
            lblID.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(174, 82);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 38;
            label6.Text = "ID:";
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(330, 202);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(145, 23);
            txtPrice.TabIndex = 45;
            // 
            // txtDuration
            // 
            txtDuration.Location = new Point(330, 155);
            txtDuration.Name = "txtDuration";
            txtDuration.Size = new Size(145, 23);
            txtDuration.TabIndex = 44;
            // 
            // txtPlan
            // 
            txtPlan.Location = new Point(330, 115);
            txtPlan.Name = "txtPlan";
            txtPlan.Size = new Size(145, 23);
            txtPlan.TabIndex = 43;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(344, 267);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 30);
            btnCancel.TabIndex = 47;
            btnCancel.Text = "Cancel";
            btnCancel.UseVisualStyleBackColor = true;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(203, 267);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 30);
            btnSave.TabIndex = 46;
            btnSave.Text = " Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // addEditSubscription
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(619, 344);
            Controls.Add(btnCancel);
            Controls.Add(btnSave);
            Controls.Add(txtPrice);
            Controls.Add(txtDuration);
            Controls.Add(txtPlan);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label10);
            Controls.Add(lblID);
            Controls.Add(label6);
            Controls.Add(lblTitle);
            Name = "addEditSubscription";
            Text = "addEditSubscription";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitle;
        private Label label4;
        private Label label3;
        private Label label10;
        private Label lblID;
        private Label label6;
        public TextBox txtPrice;
        public TextBox txtDuration;
        public TextBox txtPlan;
        public Button btnCancel;
        public Button btnSave;
    }
}