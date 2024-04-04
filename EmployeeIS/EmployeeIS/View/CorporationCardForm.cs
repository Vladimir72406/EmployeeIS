using EmployeeIS.Logic;
using EmployeeIS.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EmployeeIS.View
{
    public partial class CorporationCardForm : Form
    {
        private CorporationListForm corporationListForm;

        private Corporation corporation;
        private List<Address> listAddress = new List<Address>();

        private ManagerCorporation managerCorporation = new ManagerCorporation();
        private ManagerAddress managerAddress = new ManagerAddress();
        public CorporationCardForm(int corporation_id, CorporationListForm _corporationListForm)
        {
            GetCorporation(corporation_id);
            InitializeComponent();

            refreshField();
            corporationListForm = _corporationListForm;
        }

        private void GetCorporation(int corporation_id)
        {
            if (corporation_id > 0)
            {
                corporation = managerCorporation.getCorporationById(corporation_id);
                listAddress = managerAddress.getListAddressByCorporationId(corporation.corporation_id);
            }
            else
            {
                corporation = new Corporation();
            }
        }

        private void refreshField()
        {            
            this.txtCorporationId.Text = corporation.corporation_id.ToString();
            this.txtInn.Text = corporation.corporation_inn;
            this.txtName.Text = corporation.corporation_name;

            this.Text = corporation.corporation_name;

            dgvListAddress.DataSource = listAddress;

            if (corporation.corporation_id == 0)
            {
                btnAddAddress.Enabled = false;
                btnDeleteAddress.Enabled = false;
                btnOpenAddress.Enabled = false;
            }
            else
            {
                btnAddAddress.Enabled = true;
                btnDeleteAddress.Enabled = true;
                btnOpenAddress.Enabled = true;
            }
        }

        public void refreshAddressList()
        {            
            listAddress = managerAddress.getListAddressByCorporationId(corporation.corporation_id);
            dgvListAddress.DataSource = listAddress;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Result resultSave = save();
            if (resultSave.hasError == false) Close();
            else MessageBox.Show(resultSave.error);            
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Result resultSave = save();
            if (resultSave.hasError == true) MessageBox.Show(resultSave.error);
            refreshField();
        }

        private Result save()
        {
            Result resultSave;
            corporation.corporation_id = Convert.ToInt32(txtCorporationId.Text);
            corporation.corporation_inn = txtInn.Text;
            corporation.corporation_name = txtName.Text;

            resultSave = managerCorporation.saveCorporation(corporation);            
            return resultSave;

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void OpenListEmployee_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm(this.corporation.corporation_id);
            employeeListForm.MdiParent = this.MdiParent;
            employeeListForm.Show();
        }

        private void CorporationCardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            corporationListForm.refreshCorporationList();
        }

        private void btnOpenAddress_Click(object sender, EventArgs e)
        {
            int address_id;
            if (dgvListAddress.SelectedRows.Count > 0)
            {
                address_id = Convert.ToInt32(dgvListAddress.SelectedRows[0].Cells["address_id"].Value);

                AddressCardForm addressCardForm = new AddressCardForm(address_id, this, corporation.corporation_id);
                addressCardForm.MdiParent = this.MdiParent;
                addressCardForm.Show(); // Dialog();
            }
        }

        private void btnAddAddress_Click(object sender, EventArgs e)
        {
            AddressCardForm addressCardForm = new AddressCardForm(0, this, corporation.corporation_id);
            addressCardForm.MdiParent = this.MdiParent;            
            addressCardForm.Show();//addressCardForm.ShowDialog();
        }

        private void btnDeleteAddress_Click(object sender, EventArgs e)
        {
            int address_id;
            if (dgvListAddress.SelectedRows.Count > 0)
            {
                address_id = Convert.ToInt32(dgvListAddress.SelectedRows[0].Cells["address_id"].Value);

                Result resultDeleteAddress = managerAddress.deleteAddress(address_id);

                if (resultDeleteAddress.hasError == true)
                {
                    MessageBox.Show(resultDeleteAddress.error);
                }
            }
        }
    }
}
