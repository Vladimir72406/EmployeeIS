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
    public partial class EmployeeListForm : Form
    {
        private List<Employee> lstEmployee = new List<Employee>();
        private ManagerEmployee managerEmployee = new ManagerEmployee();
        public EmployeeListForm()
        {
            getEmployeeList(0);
            InitializeComponent();
        }

        public EmployeeListForm(int corporation_id)
        {
            getEmployeeList(corporation_id);
            InitializeComponent();
        }

        private void getEmployeeList(int corporation_id)
        {
            lstEmployee = managerEmployee.getEmployeeList(corporation_id);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EmployeeListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lstEmployee;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            EmployeeCard employeeCard = new EmployeeCard(0);
            employeeCard.MdiParent = this.MdiParent;
            employeeCard.Show();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            int employee_id;
            
            employee_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["employee_id"].Value);

            EmployeeCard employeeCard = new EmployeeCard(employee_id);
            employeeCard.MdiParent = this.MdiParent;
            employeeCard.Show();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int employee_id;
            employee_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["employee_id"].Value);

            Result resultDeleteCorporation = managerEmployee.deleteEmployee(employee_id);

            if (resultDeleteCorporation.hasError == true)
            {
                MessageBox.Show(resultDeleteCorporation.error);
            }
        }
    }
}
