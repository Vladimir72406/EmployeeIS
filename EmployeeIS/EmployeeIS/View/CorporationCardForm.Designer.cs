
namespace EmployeeIS.View
{
    partial class CorporationCardForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnApply = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtInn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCorporationId = new System.Windows.Forms.TextBox();
            this.OpenListEmployee = new System.Windows.Forms.Button();
            this.dgvListAddress = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnAddAddress = new System.Windows.Forms.Button();
            this.btnOpenAddress = new System.Windows.Forms.Button();
            this.btnDeleteAddress = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAddress)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnApply
            // 
            this.btnApply.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApply.Location = new System.Drawing.Point(508, 328);
            this.btnApply.Name = "btnApply";
            this.btnApply.Size = new System.Drawing.Size(75, 23);
            this.btnApply.TabIndex = 0;
            this.btnApply.Text = "Применить";
            this.btnApply.UseVisualStyleBackColor = true;
            this.btnApply.Click += new System.EventHandler(this.btnApply_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(427, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Отмена";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(346, 328);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "Ок";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Наименование :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "ИНН :";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(155, 38);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(222, 20);
            this.txtName.TabIndex = 5;
            // 
            // txtInn
            // 
            this.txtInn.Location = new System.Drawing.Point(155, 64);
            this.txtInn.Name = "txtInn";
            this.txtInn.Size = new System.Drawing.Size(222, 20);
            this.txtInn.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 15);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "ID компании :";
            // 
            // txtCorporationId
            // 
            this.txtCorporationId.Enabled = false;
            this.txtCorporationId.Location = new System.Drawing.Point(155, 12);
            this.txtCorporationId.Name = "txtCorporationId";
            this.txtCorporationId.Size = new System.Drawing.Size(222, 20);
            this.txtCorporationId.TabIndex = 8;
            // 
            // OpenListEmployee
            // 
            this.OpenListEmployee.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.OpenListEmployee.Location = new System.Drawing.Point(12, 328);
            this.OpenListEmployee.Name = "OpenListEmployee";
            this.OpenListEmployee.Size = new System.Drawing.Size(140, 23);
            this.OpenListEmployee.TabIndex = 9;
            this.OpenListEmployee.Text = "Список сотрудников";
            this.OpenListEmployee.UseVisualStyleBackColor = true;
            this.OpenListEmployee.Click += new System.EventHandler(this.OpenListEmployee_Click);
            // 
            // dgvListAddress
            // 
            this.dgvListAddress.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListAddress.Location = new System.Drawing.Point(8, 19);
            this.dgvListAddress.Name = "dgvListAddress";
            this.dgvListAddress.ReadOnly = true;
            this.dgvListAddress.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListAddress.Size = new System.Drawing.Size(562, 140);
            this.dgvListAddress.TabIndex = 10;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDeleteAddress);
            this.groupBox1.Controls.Add(this.btnOpenAddress);
            this.groupBox1.Controls.Add(this.btnAddAddress);
            this.groupBox1.Controls.Add(this.dgvListAddress);
            this.groupBox1.Location = new System.Drawing.Point(7, 110);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(576, 194);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Адреса";
            // 
            // btnAddAddress
            // 
            this.btnAddAddress.Location = new System.Drawing.Point(8, 165);
            this.btnAddAddress.Name = "btnAddAddress";
            this.btnAddAddress.Size = new System.Drawing.Size(75, 23);
            this.btnAddAddress.TabIndex = 11;
            this.btnAddAddress.Text = "Добавить";
            this.btnAddAddress.UseVisualStyleBackColor = true;
            this.btnAddAddress.Click += new System.EventHandler(this.btnAddAddress_Click);
            // 
            // btnOpenAddress
            // 
            this.btnOpenAddress.Location = new System.Drawing.Point(90, 165);
            this.btnOpenAddress.Name = "btnOpenAddress";
            this.btnOpenAddress.Size = new System.Drawing.Size(75, 23);
            this.btnOpenAddress.TabIndex = 12;
            this.btnOpenAddress.Text = "Открыть";
            this.btnOpenAddress.UseVisualStyleBackColor = true;
            this.btnOpenAddress.Click += new System.EventHandler(this.btnOpenAddress_Click);
            // 
            // btnDeleteAddress
            // 
            this.btnDeleteAddress.Location = new System.Drawing.Point(172, 165);
            this.btnDeleteAddress.Name = "btnDeleteAddress";
            this.btnDeleteAddress.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteAddress.TabIndex = 13;
            this.btnDeleteAddress.Text = "Удалить";
            this.btnDeleteAddress.UseVisualStyleBackColor = true;
            this.btnDeleteAddress.Click += new System.EventHandler(this.btnDeleteAddress_Click);
            // 
            // CorporationCardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(595, 363);
            this.Controls.Add(this.OpenListEmployee);
            this.Controls.Add(this.txtCorporationId);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtInn);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnApply);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "CorporationCardForm";
            this.Text = "CorporationCardForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.CorporationCardForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dgvListAddress)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnApply;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtInn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCorporationId;
        private System.Windows.Forms.Button OpenListEmployee;
        private System.Windows.Forms.DataGridView dgvListAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnDeleteAddress;
        private System.Windows.Forms.Button btnOpenAddress;
        private System.Windows.Forms.Button btnAddAddress;
    }
}