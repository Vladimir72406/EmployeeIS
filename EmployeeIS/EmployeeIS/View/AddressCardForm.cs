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
    public partial class AddressCardForm : Form
    {
        private Address address;
        private int corporation_id;
        private CorporationCardForm corporationCardForm;
        private ManagerAddress managerAddress = new ManagerAddress();

        public AddressCardForm(int _address_id, CorporationCardForm _corporationCardForm, int _corporation_id)
        {
            this.Text = "Адрес компании";
            corporationCardForm = _corporationCardForm;
            corporation_id = _corporation_id;
            GetAddress(_address_id);
            InitializeComponent();

            refreshField();
        }

        private void refreshField()
        {
            txtAddressID.Text = address.address_id.ToString();            
            txtAddressType.Text = address.address_type;
            txtCoutry.Text = address.country;
            txtCity.Text = address.city;
            txtStreet.Text = address.street;
            txtHome.Text = address.home;
            txtApartment.Text = address.apartment;

            if (address.address_id > 0) txtCorporationId.Text = address.corporation_id.ToString();
            else txtCorporationId.Text = corporation_id.ToString();
        }

        private void GetAddress(int _address_id)
        {
            this.address = managerAddress.getAddressById(_address_id);
        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            Result resultSave = save();
            if (resultSave.hasError == true) MessageBox.Show(resultSave.error);
            refreshField();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Result resultSave = save();
            if (resultSave.hasError == false) Close();
            else MessageBox.Show(resultSave.error);
        }

        private Result save()
        {
            Result resultSave;            

            address.address_id = Convert.ToInt32(txtAddressID.Text);
            address.corporation_id = Convert.ToInt32(txtCorporationId.Text);
            address.address_type = txtAddressType.Text;
            address.country = txtCoutry.Text;
            address.city = txtCity.Text;
            address.street = txtStreet.Text;
            address.home = txtHome.Text;
            address.apartment = txtApartment.Text;

            resultSave = managerAddress.saveAddress(address);
            return resultSave;
        }

        private void AddressCardForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            corporationCardForm.refreshAddressList();
        }
    }
}
