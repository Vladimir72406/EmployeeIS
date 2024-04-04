using EmployeeIS.DataBase;
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
    public partial class CorporationListForm : Form
    {
        private List<Corporation> lstCorporation;
        ManagerCorporation managerCorporation = new ManagerCorporation();
        public CorporationListForm()
        {
            getCorporation();
            InitializeComponent();
        }

        private void getCorporation()
        {
            lstCorporation = managerCorporation.getCorporationList();
        }

        public void refreshCorporationList()
        {
            lstCorporation = managerCorporation.getCorporationList();
            dataGridView1.DataSource = lstCorporation;
        }

        private void CorporationListForm_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = lstCorporation;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CorporationCardForm corporationCard = new CorporationCardForm(0, this);
            corporationCard.MdiParent = this.MdiParent;
            corporationCard.Show();

            getCorporation();
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            int corporation_id;
            corporation_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["corporation_id"].Value);

            CorporationCardForm corporationCard = new CorporationCardForm(corporation_id, this);
            corporationCard.MdiParent = this.MdiParent;
            corporationCard.Show();

            getCorporation();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int corporation_id;
            corporation_id = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["corporation_id"].Value);

            Result resultDeleteCorporation = managerCorporation.deleteCorporation(corporation_id);

            if (resultDeleteCorporation.hasError == true)
            {
                MessageBox.Show(resultDeleteCorporation.error);
            }
            else
            {
                refreshCorporationList();
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {            
            ManagerExport managerExport = new ManagerExport();
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            DialogResult result = folderBrowserDialog.ShowDialog();
            String selectedFolderForSaveFile = "";

            if (result == DialogResult.OK)
            {
                selectedFolderForSaveFile = folderBrowserDialog.SelectedPath.ToString();

                var resultExport = managerExport.export(this.lstCorporation, selectedFolderForSaveFile);
                if (resultExport.hasError == true)
                    MessageBox.Show(resultExport.error);

            }
        }

        private void btnImport_Click(object sender, EventArgs e)
        {
            ManagerImport managerImport = new ManagerImport();

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "All Files (*.*)|*.csv";
            openFileDialog.FilterIndex = 2;
            openFileDialog.Multiselect = false;

            DialogResult resultSelect = openFileDialog.ShowDialog();

            if (resultSelect == DialogResult.OK)
            {
                string _selectedFileName = openFileDialog.FileName;
                ResultImportCorporation resultLoad = managerImport.import(_selectedFileName);

                if (resultLoad.hasError == true)
                    MessageBox.Show(resultLoad.error);
                else
                {
                    saveList(resultLoad.listCorporation);
                    showImportedCorporation(resultLoad.listCorporation);
                }

            }
        }

        private void showImportedCorporation(List<Corporation> _lst)
        {
            dataGridView1.DataSource = _lst;            
        }

        private void saveList(List<Corporation> _lst)
        {
            foreach (var item in _lst)//последствия неправлильной архитектуры.
            {
                item.corporation_id = 0;
            }

            ManagerCorporation managerCorporation = new ManagerCorporation();
            managerCorporation.saveListCorporation(_lst);
        }
    }
}
