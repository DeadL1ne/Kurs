namespace RealtorEstateAgancy
{
    partial class EstateObjectFrame
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
            this.dgvEstateObjects = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnRemove = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.writeDgv = new System.ComponentModel.BackgroundWorker();
            this.updateBW = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstateObjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvEstateObjects
            // 
            this.dgvEstateObjects.AllowUserToAddRows = false;
            this.dgvEstateObjects.AllowUserToDeleteRows = false;
            this.dgvEstateObjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvEstateObjects.Location = new System.Drawing.Point(12, 42);
            this.dgvEstateObjects.Name = "dgvEstateObjects";
            this.dgvEstateObjects.ReadOnly = true;
            this.dgvEstateObjects.Size = new System.Drawing.Size(898, 613);
            this.dgvEstateObjects.TabIndex = 0;
            this.dgvEstateObjects.RowHeaderMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvEstateObjects_RowHeaderMouseDoubleClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(916, 13);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Поиск";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(916, 42);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Добавить";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnRemove
            // 
            this.btnRemove.Location = new System.Drawing.Point(916, 71);
            this.btnRemove.Name = "btnRemove";
            this.btnRemove.Size = new System.Drawing.Size(75, 23);
            this.btnRemove.TabIndex = 3;
            this.btnRemove.Text = "Удалить";
            this.btnRemove.UseVisualStyleBackColor = true;
            this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(12, 13);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(898, 20);
            this.tbSearch.TabIndex = 5;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(916, 100);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Обновить";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // writeDgv
            // 
            this.writeDgv.WorkerReportsProgress = true;
            // 
            // updateBW
            // 
            this.updateBW.WorkerReportsProgress = true;
            this.updateBW.DoWork += new System.ComponentModel.DoWorkEventHandler(this.updateBW_DoWork);
            // 
            // EstateObjectFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 682);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnRemove);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.dgvEstateObjects);
            this.Name = "EstateObjectFrame";
            this.Text = "Недвижимость";
            this.Load += new System.EventHandler(this.DataBase_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvEstateObjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvEstateObjects;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnRemove;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Button btnUpdate;
        private System.ComponentModel.BackgroundWorker writeDgv;
        private System.ComponentModel.BackgroundWorker updateBW;
    }
}