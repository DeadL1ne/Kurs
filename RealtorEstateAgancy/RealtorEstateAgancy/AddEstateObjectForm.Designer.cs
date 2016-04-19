namespace RealtorEstateAgancy
{
    partial class AddEstateObjectForm
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
            this.dealTypeLabel = new System.Windows.Forms.Label();
            this.dealTypeComboBox = new System.Windows.Forms.ComboBox();
            this.localityLabel = new System.Windows.Forms.Label();
            this.localityComboBox = new System.Windows.Forms.ComboBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.areaLabel = new System.Windows.Forms.Label();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.roomNumberLabel = new System.Windows.Forms.Label();
            this.roomNumberComboBox = new System.Windows.Forms.ComboBox();
            this.floorLabel = new System.Windows.Forms.Label();
            this.floorTextBox = new System.Windows.Forms.TextBox();
            this.maxFloorLabel = new System.Windows.Forms.Label();
            this.maxFloorTextBox = new System.Windows.Forms.TextBox();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.descriptionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.priceLabel = new System.Windows.Forms.Label();
            this.priceTextBox = new System.Windows.Forms.TextBox();
            this.materialLabel = new System.Windows.Forms.Label();
            this.materialTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // dealTypeLabel
            // 
            this.dealTypeLabel.AutoSize = true;
            this.dealTypeLabel.Location = new System.Drawing.Point(12, 9);
            this.dealTypeLabel.Name = "dealTypeLabel";
            this.dealTypeLabel.Size = new System.Drawing.Size(68, 13);
            this.dealTypeLabel.TabIndex = 0;
            this.dealTypeLabel.Text = "Тип сделки:";
            // 
            // dealTypeComboBox
            // 
            this.dealTypeComboBox.FormattingEnabled = true;
            this.dealTypeComboBox.Items.AddRange(new object[] {
            "Продажа",
            "Покупка",
            "Сдача",
            "Съём"});
            this.dealTypeComboBox.Location = new System.Drawing.Point(86, 6);
            this.dealTypeComboBox.Name = "dealTypeComboBox";
            this.dealTypeComboBox.Size = new System.Drawing.Size(302, 21);
            this.dealTypeComboBox.TabIndex = 1;
            // 
            // localityLabel
            // 
            this.localityLabel.AutoSize = true;
            this.localityLabel.Location = new System.Drawing.Point(12, 43);
            this.localityLabel.Name = "localityLabel";
            this.localityLabel.Size = new System.Drawing.Size(41, 13);
            this.localityLabel.TabIndex = 2;
            this.localityLabel.Text = "Район:";
            // 
            // localityComboBox
            // 
            this.localityComboBox.FormattingEnabled = true;
            this.localityComboBox.Items.AddRange(new object[] {
            "р-н. Ленинский",
            "р-н. Железнодорожный",
            "р-н. Засвияжский",
            "р-н. Заволжский"});
            this.localityComboBox.Location = new System.Drawing.Point(59, 40);
            this.localityComboBox.Name = "localityComboBox";
            this.localityComboBox.Size = new System.Drawing.Size(329, 21);
            this.localityComboBox.TabIndex = 3;
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(12, 78);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(41, 13);
            this.addressLabel.TabIndex = 4;
            this.addressLabel.Text = "Адрес:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(59, 78);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(329, 20);
            this.addressTextBox.TabIndex = 5;
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(12, 113);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(57, 13);
            this.areaLabel.TabIndex = 6;
            this.areaLabel.Text = "Площадь:";
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(75, 110);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(313, 20);
            this.areaTextBox.TabIndex = 7;
            // 
            // roomNumberLabel
            // 
            this.roomNumberLabel.AutoSize = true;
            this.roomNumberLabel.Location = new System.Drawing.Point(12, 147);
            this.roomNumberLabel.Name = "roomNumberLabel";
            this.roomNumberLabel.Size = new System.Drawing.Size(84, 13);
            this.roomNumberLabel.TabIndex = 8;
            this.roomNumberLabel.Text = "Кол-во комнат:";
            // 
            // roomNumberComboBox
            // 
            this.roomNumberComboBox.FormattingEnabled = true;
            this.roomNumberComboBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.roomNumberComboBox.Location = new System.Drawing.Point(103, 147);
            this.roomNumberComboBox.Name = "roomNumberComboBox";
            this.roomNumberComboBox.Size = new System.Drawing.Size(285, 21);
            this.roomNumberComboBox.TabIndex = 9;
            // 
            // floorLabel
            // 
            this.floorLabel.AutoSize = true;
            this.floorLabel.Location = new System.Drawing.Point(12, 179);
            this.floorLabel.Name = "floorLabel";
            this.floorLabel.Size = new System.Drawing.Size(36, 13);
            this.floorLabel.TabIndex = 10;
            this.floorLabel.Text = "Этаж:";
            // 
            // floorTextBox
            // 
            this.floorTextBox.Location = new System.Drawing.Point(59, 179);
            this.floorTextBox.Name = "floorTextBox";
            this.floorTextBox.Size = new System.Drawing.Size(329, 20);
            this.floorTextBox.TabIndex = 11;
            // 
            // maxFloorLabel
            // 
            this.maxFloorLabel.AutoSize = true;
            this.maxFloorLabel.Location = new System.Drawing.Point(12, 213);
            this.maxFloorLabel.Name = "maxFloorLabel";
            this.maxFloorLabel.Size = new System.Drawing.Size(104, 13);
            this.maxFloorLabel.TabIndex = 12;
            this.maxFloorLabel.Text = "Этажность здания:";
            // 
            // maxFloorTextBox
            // 
            this.maxFloorTextBox.Location = new System.Drawing.Point(126, 213);
            this.maxFloorTextBox.Name = "maxFloorTextBox";
            this.maxFloorTextBox.Size = new System.Drawing.Size(262, 20);
            this.maxFloorTextBox.TabIndex = 13;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Location = new System.Drawing.Point(9, 316);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(60, 13);
            this.descriptionLabel.TabIndex = 14;
            this.descriptionLabel.Text = "Описание:";
            // 
            // descriptionRichTextBox
            // 
            this.descriptionRichTextBox.Location = new System.Drawing.Point(12, 344);
            this.descriptionRichTextBox.Name = "descriptionRichTextBox";
            this.descriptionRichTextBox.Size = new System.Drawing.Size(376, 96);
            this.descriptionRichTextBox.TabIndex = 15;
            this.descriptionRichTextBox.Text = "";
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(327, 458);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 16;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(246, 458);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 17;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // priceLabel
            // 
            this.priceLabel.AutoSize = true;
            this.priceLabel.Location = new System.Drawing.Point(12, 286);
            this.priceLabel.Name = "priceLabel";
            this.priceLabel.Size = new System.Drawing.Size(36, 13);
            this.priceLabel.TabIndex = 18;
            this.priceLabel.Text = "Цена:";
            // 
            // priceTextBox
            // 
            this.priceTextBox.Location = new System.Drawing.Point(63, 283);
            this.priceTextBox.Name = "priceTextBox";
            this.priceTextBox.Size = new System.Drawing.Size(327, 20);
            this.priceTextBox.TabIndex = 19;
            // 
            // materialLabel
            // 
            this.materialLabel.AutoSize = true;
            this.materialLabel.Location = new System.Drawing.Point(12, 251);
            this.materialLabel.Name = "materialLabel";
            this.materialLabel.Size = new System.Drawing.Size(99, 13);
            this.materialLabel.TabIndex = 20;
            this.materialLabel.Text = "Материал здания:";
            // 
            // materialTextBox
            // 
            this.materialTextBox.Location = new System.Drawing.Point(120, 248);
            this.materialTextBox.Name = "materialTextBox";
            this.materialTextBox.Size = new System.Drawing.Size(270, 20);
            this.materialTextBox.TabIndex = 21;
            // 
            // AddEstateObjectForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 490);
            this.Controls.Add(this.materialTextBox);
            this.Controls.Add(this.materialLabel);
            this.Controls.Add(this.priceTextBox);
            this.Controls.Add(this.priceLabel);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.descriptionRichTextBox);
            this.Controls.Add(this.descriptionLabel);
            this.Controls.Add(this.maxFloorTextBox);
            this.Controls.Add(this.maxFloorLabel);
            this.Controls.Add(this.floorTextBox);
            this.Controls.Add(this.floorLabel);
            this.Controls.Add(this.roomNumberComboBox);
            this.Controls.Add(this.roomNumberLabel);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.localityComboBox);
            this.Controls.Add(this.localityLabel);
            this.Controls.Add(this.dealTypeComboBox);
            this.Controls.Add(this.dealTypeLabel);
            this.Name = "AddEstateObjectForm";
            this.Text = "Добавление объекта недвижимости";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label dealTypeLabel;
        private System.Windows.Forms.ComboBox dealTypeComboBox;
        private System.Windows.Forms.Label localityLabel;
        private System.Windows.Forms.ComboBox localityComboBox;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.TextBox addressTextBox;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.TextBox areaTextBox;
        private System.Windows.Forms.Label roomNumberLabel;
        private System.Windows.Forms.ComboBox roomNumberComboBox;
        private System.Windows.Forms.Label floorLabel;
        private System.Windows.Forms.TextBox floorTextBox;
        private System.Windows.Forms.Label maxFloorLabel;
        private System.Windows.Forms.TextBox maxFloorTextBox;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.RichTextBox descriptionRichTextBox;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Label priceLabel;
        private System.Windows.Forms.TextBox priceTextBox;
        private System.Windows.Forms.Label materialLabel;
        private System.Windows.Forms.TextBox materialTextBox;
    }
}