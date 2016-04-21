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
    public delegate int estateId();
    public partial class EstateObjectFrame : Form
    {
        public EstateObjectFrame()
        {
            InitializeComponent();
        }

        int GetId()
        {
            int id;
            return id = Convert.ToInt32(dgvEstateObjects.CurrentRow.Cells[0].Value);
        }

        SQLitekurs.SQLite db = new SQLitekurs.SQLite();
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            btnUpdate.Enabled = false;
            db.DropEstateObjectTable();
            UpdateDataGrid();
            updateBW.RunWorkerAsync();     
        }
        private void UpdateDataGrid()
        {
            dgvEstateObjects.DataSource = db.DisplayAllData();
        }
        private void DataBase_Load(object sender, EventArgs e)
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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEstateObjectForm addEstate = new AddEstateObjectForm();
            addEstate.Show();
        }

        private void updateBW_DoWork(object sender, DoWorkEventArgs e)
        {
            db.Update();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            db.RemoveEstateObject(Convert.ToInt32(dgvEstateObjects.CurrentRow.Cells[0].Value));
            dgvEstateObjects.Rows.RemoveAt(dgvEstateObjects.CurrentRow.Index);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            dgvEstateObjects.DataSource = db.SearchByAddress(tbSearch.Text);  
        }

        private void dgvEstateObjects_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            FullDescriptionForm descForm = new FullDescriptionForm(new estateId(GetId));
            descForm.ShowDialog();
        }

        //private void writeDgv_DoWork(object sender, DoWorkEventArgs e)
        //{
        //    UpdateDataGrid();
        //}
    }
}
