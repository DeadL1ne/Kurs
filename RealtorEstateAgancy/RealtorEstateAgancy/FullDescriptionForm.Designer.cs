namespace RealtorEstateAgancy
{
    partial class FullDescriptionForm
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
            this.dealTypeDescLabel = new System.Windows.Forms.Label();
            this.localityDescLabel = new System.Windows.Forms.Label();
            this.addressDescLabel = new System.Windows.Forms.Label();
            this.areaDescLabel = new System.Windows.Forms.Label();
            this.roomNumberDescLabel = new System.Windows.Forms.Label();
            this.floorDescLabel = new System.Windows.Forms.Label();
            this.materialDescLabel = new System.Windows.Forms.Label();
            this.priceDescLabel = new System.Windows.Forms.Label();
            this.descriptionDescLabel = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // dealTypeDescLabel
            // 
            this.dealTypeDescLabel.AutoSize = true;
            this.dealTypeDescLabel.Location = new System.Drawing.Point(13, 9);
            this.dealTypeDescLabel.Name = "dealTypeDescLabel";
            this.dealTypeDescLabel.Size = new System.Drawing.Size(68, 13);
            this.dealTypeDescLabel.TabIndex = 0;
            this.dealTypeDescLabel.Text = "Тип сделки:";
            // 
            // localityDescLabel
            // 
            this.localityDescLabel.AutoSize = true;
            this.localityDescLabel.Location = new System.Drawing.Point(13, 39);
            this.localityDescLabel.Name = "localityDescLabel";
            this.localityDescLabel.Size = new System.Drawing.Size(41, 13);
            this.localityDescLabel.TabIndex = 1;
            this.localityDescLabel.Text = "Район:";
            // 
            // addressDescLabel
            // 
            this.addressDescLabel.AutoSize = true;
            this.addressDescLabel.Location = new System.Drawing.Point(13, 69);
            this.addressDescLabel.Name = "addressDescLabel";
            this.addressDescLabel.Size = new System.Drawing.Size(41, 13);
            this.addressDescLabel.TabIndex = 2;
            this.addressDescLabel.Text = "Адрес:";
            // 
            // areaDescLabel
            // 
            this.areaDescLabel.AutoSize = true;
            this.areaDescLabel.Location = new System.Drawing.Point(13, 102);
            this.areaDescLabel.Name = "areaDescLabel";
            this.areaDescLabel.Size = new System.Drawing.Size(57, 13);
            this.areaDescLabel.TabIndex = 3;
            this.areaDescLabel.Text = "Площадь:";
            // 
            // roomNumberDescLabel
            // 
            this.roomNumberDescLabel.AutoSize = true;
            this.roomNumberDescLabel.Location = new System.Drawing.Point(13, 132);
            this.roomNumberDescLabel.Name = "roomNumberDescLabel";
            this.roomNumberDescLabel.Size = new System.Drawing.Size(84, 13);
            this.roomNumberDescLabel.TabIndex = 4;
            this.roomNumberDescLabel.Text = "Кол-во комнат:";
            // 
            // floorDescLabel
            // 
            this.floorDescLabel.AutoSize = true;
            this.floorDescLabel.Location = new System.Drawing.Point(13, 162);
            this.floorDescLabel.Name = "floorDescLabel";
            this.floorDescLabel.Size = new System.Drawing.Size(36, 13);
            this.floorDescLabel.TabIndex = 5;
            this.floorDescLabel.Text = "Этаж:";
            // 
            // materialDescLabel
            // 
            this.materialDescLabel.AutoSize = true;
            this.materialDescLabel.Location = new System.Drawing.Point(11, 191);
            this.materialDescLabel.Name = "materialDescLabel";
            this.materialDescLabel.Size = new System.Drawing.Size(86, 13);
            this.materialDescLabel.TabIndex = 6;
            this.materialDescLabel.Text = "Материал стен:";
            // 
            // priceDescLabel
            // 
            this.priceDescLabel.AutoSize = true;
            this.priceDescLabel.Location = new System.Drawing.Point(11, 223);
            this.priceDescLabel.Name = "priceDescLabel";
            this.priceDescLabel.Size = new System.Drawing.Size(36, 13);
            this.priceDescLabel.TabIndex = 7;
            this.priceDescLabel.Text = "Цена:";
            // 
            // descriptionDescLabel
            // 
            this.descriptionDescLabel.AutoSize = true;
            this.descriptionDescLabel.Location = new System.Drawing.Point(13, 255);
            this.descriptionDescLabel.Name = "descriptionDescLabel";
            this.descriptionDescLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionDescLabel.TabIndex = 8;
            this.descriptionDescLabel.Text = "Описание:";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Enabled = false;
            this.richTextBox1.Location = new System.Drawing.Point(16, 284);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(256, 96);
            this.richTextBox1.TabIndex = 9;
            this.richTextBox1.Text = "";
            // 
            // FullDescriptionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 398);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.descriptionDescLabel);
            this.Controls.Add(this.priceDescLabel);
            this.Controls.Add(this.materialDescLabel);
            this.Controls.Add(this.floorDescLabel);
            this.Controls.Add(this.roomNumberDescLabel);
            this.Controls.Add(this.areaDescLabel);
            this.Controls.Add(this.addressDescLabel);
            this.Controls.Add(this.localityDescLabel);
            this.Controls.Add(this.dealTypeDescLabel);
            this.Name = "FullDescriptionForm";
            this.Text = "FullDescriptionForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dealTypeDescLabel;
        private System.Windows.Forms.Label localityDescLabel;
        private System.Windows.Forms.Label addressDescLabel;
        private System.Windows.Forms.Label areaDescLabel;
        private System.Windows.Forms.Label roomNumberDescLabel;
        private System.Windows.Forms.Label floorDescLabel;
        private System.Windows.Forms.Label materialDescLabel;
        private System.Windows.Forms.Label priceDescLabel;
        private System.Windows.Forms.Label descriptionDescLabel;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}