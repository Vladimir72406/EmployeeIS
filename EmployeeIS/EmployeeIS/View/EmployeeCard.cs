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
    public partial class EmployeeCard : Form
    {
        private Employee employee;
        private ManagerEmployee managerEmployee = new ManagerEmployee();
        private int corporation_id;
        EmployeeListForm employeeListForm;
        public EmployeeCard(int employee_id, int _corporation_id, EmployeeListForm _employeeListForm)
        {
            this.corporation_id = _corporation_id;
            this.employeeListForm = _employeeListForm;
            GetEmployee(employee_id);
            InitializeComponent();

            refreshField();
        }

        private void GetEmployee(int employee_id)
        {
            if (employee_id > 0)
            {
                employee = managerEmployee.getEmployeeById(employee_id);
            }
            else
            {
                employee = new Employee(0, "", "", "", new DateTime(1900, 1, 1), this.corporation_id);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void refreshField()
        {
            txtEmployeeId.Text = employee.employee_id.ToString();
            txtSurname.Text = employee.surname.ToString();
            txtName.Text = employee.name.ToString();
            txtMiddleName.Text = employee.middle_name.ToString();
            dtpBirthDay.Value = employee.birthday;
            //txtEmployeeId.Text = employee.employee_id.ToString();

            this.Text = "Карточка сотрудника";
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
            employee.employee_id = Convert.ToInt32(txtEmployeeId.Text);
            employee.surname = txtSurname.Text;
            employee.name = txtName.Text;
            employee.middle_name = txtMiddleName.Text;
            employee.birthday = dtpBirthDay.Value;

            if (employee.employee_id == 0)
                employee.corporation_id = corporation_id;

            resultSave = managerEmployee.saveEmployee(employee);
            return resultSave;

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            Result resultSave = save();
            if (resultSave.hasError == false) Close();
            else MessageBox.Show(resultSave.error);
        }

        private void EmployeeCard_FormClosing(object sender, FormClosingEventArgs e)
        {
            employeeListForm.refreshEmployeeList();
        }
    }
}
