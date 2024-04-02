using EmployeeIS.DataBase;
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
    public partial class CorporationListForm : Form
    {
        private List<Corporation> lstCorporation = new List<Corporation>();
        public CorporationListForm()
        {
            getCorporation();
            InitializeComponent();
        }

        private void getCorporation()
        {
            lstCorporation = new List<Corporation>();
            var dba = InstanceDB.getInstance();
            lstCorporation = dba.getListCorporation();            
        }

        private void CorporationListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lstCorporation;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
