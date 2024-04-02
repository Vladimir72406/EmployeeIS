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
        List<Employee> lstEmployee = new List<Employee>();
        ManagerEmployee managerEmployee = new ManagerEmployee();
        public EmployeeListForm()
        {
            getEmployeeList();
            InitializeComponent();
        }

        private void getEmployeeList()
        {
            managerEmployee.getEmployeeList();            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {

        }
    }
}
