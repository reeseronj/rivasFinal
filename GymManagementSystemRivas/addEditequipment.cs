using GymManagementSystemRivas.models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using static GymManagementSystemRivas.repositories.equipmentRepository;

namespace GymManagementSystemRivas
{
    public partial class addEditequipment : Form
    {
        private int equip_id;
        public addEditequipment()
        {
            InitializeComponent();
        }

        public void EditEquipment(Equipment equipment)
        {
            this.Text = "Edit Equipment";
            this.lblTitle.Text = "Edit Equipment";

            this.lblID.Text = "" + equipment.equip_id;
            this.txtEquipName.Text = equipment.name;
            this.txtQuantity.Text = equipment.quantity.ToString();
            this.txtStatus.Text = equipment.status;

            this.equip_id = equipment.equip_id;
        }

        private void lblTitle_Click(object sender, EventArgs e)
        {


        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            Equipment equipment = new Equipment();
            equipment.equip_id = this.equip_id;
            equipment.name = this.txtEquipName.Text;

            // Parsing quantity as an int based on your model
            int.TryParse(this.txtQuantity.Text, out equipment.quantity);

            equipment.status = this.txtStatus.Text;

            var repo = new equipRepository();

            if (equipment.equip_id == 0)
            {
                // Usually, we don't check for duplicate emails here, 
                // but you could check for duplicate names if needed.
                repo.createEquipment(equipment);
            }
            else
            {
                repo.updateEquipment(equipment);
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
