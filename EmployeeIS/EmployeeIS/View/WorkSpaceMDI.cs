using EmployeeIS.DataBase;
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
    public partial class WorkSpaceMDI : Form
    {
        public WorkSpaceMDI()
        {
            InitializeComponent();
            //this.Text = "Employee Information System";
            this.Text = "Информационная система сотрудников компаний.";
            connectToDb();
        }

        private void connectToDb()
        {
            var dba = InstanceDB.getInstance();
            try
            {
                dba.connect();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка подключения к бд; "); // + e.Message.ToString());; // ;
            }
        }

        private void CorporationListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CorporationListForm corporationListForm = new CorporationListForm();
            corporationListForm.MdiParent = this;
            corporationListForm.Show();
        }

        private void EmployeeListToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EmployeeListForm employeeListForm = new EmployeeListForm(0);
            employeeListForm.MdiParent = this;
            employeeListForm.Show();

        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void WorkSpaceMDI_FormClosing(object sender, FormClosingEventArgs e)
        {
            disconnectDB();
        }

        private void disconnectDB()
        {
            var dba = InstanceDB.getInstance();
            try
            {
                dba.disconnect();
            }
            catch (Exception e)
            {
                MessageBox.Show("Ошибка завршения сеанса бд; " + e.Message.ToString());
            }
        }
    }
}
