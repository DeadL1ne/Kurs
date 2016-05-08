using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.IO;
using System.Windows.Forms;
using SQLitekurs;
using System.Data.SQLite;

namespace RealtorEstateAgancy
{
    public partial class CustomerForm : Form
    {
        public CustomerForm()
        {
            InitializeComponent();

        }
        public void UpdateDataForm()
        {
            UpdateDataGrid();
        }

        SQLitekurs.SQLite db = new SQLitekurs.SQLite();
        private void btnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddCustomer addCustomerForm = new AddCustomer();
            addCustomerForm.Show();
            UpdateDataGrid();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            db.RemoveCustomer(Convert.ToInt32(dgvCustomer.CurrentRow.Cells[0].Value));
            UpdateDataGrid();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void btnAddRequest_Click(object sender, EventArgs e)
        {
            AddRequest addRequest = new AddRequest(Convert.ToInt32(dgvCustomer.CurrentRow.Cells[0].Value));
            addRequest.Show();
        }

        private void CustomerForm_Load(object sender, EventArgs e)
        {
            string path = @"C:\BD\RealtorEstateAgancy.sqlite";
            db.Connect(@"C:\BD\RealtorEstateAgancy.sqlite");
            if (!File.Exists(path))
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.InitialDirectory = "C:\\";
                fileDialog.Filter = "SQLite files (*.sqlite)|*.sqlite|All files (*.*)|*.*";
                fileDialog.FilterIndex = 1;
                fileDialog.RestoreDirectory = true;
                fileDialog.CheckFileExists = true;
                fileDialog.Title = "Выберите файл с БД";
                path = fileDialog.DereferenceLinks + fileDialog.FileName;
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    db.Connect(path);
                }
            }
            UpdateDataGrid();
        }
        private void UpdateDataGrid()
        {
            dgvCustomer.DataSource = db.DisplayAllDataCustomer();
        }


        private void dgvCustomer_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
             AddRequest addRequest = new AddRequest(Convert.ToUInt32(dgvCustomer.CurrentRow.Cells[0].Value));
            addRequest.Show();
        }

        private void CustomerForm_Activated(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }
    }
}
