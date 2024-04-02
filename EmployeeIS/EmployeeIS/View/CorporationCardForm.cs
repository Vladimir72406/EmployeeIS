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
        private Corporation corporation;
        private ManagerCorporation managerCorporation = new ManagerCorporation();
        public CorporationCardForm(int corporation_id)
        {
            GetCorporation(corporation_id);
            InitializeComponent();

            refreshField();
        }

        private void GetCorporation(int corporation_id)
        {
            if (corporation_id > 0)
            {
                corporation = managerCorporation.getCorporationById(corporation_id);
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
    }
}
