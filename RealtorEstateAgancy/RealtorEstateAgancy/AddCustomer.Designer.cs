namespace RealtorEstateAgancy
{
    partial class AddCustomer
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
            this.FIOlabel = new System.Windows.Forms.Label();
            this.FIO_textbox = new System.Windows.Forms.TextBox();
            this.e_mail_textbox = new System.Windows.Forms.TextBox();
            this.e_mail_label = new System.Windows.Forms.Label();
            this.phone_textbox = new System.Windows.Forms.TextBox();
            this.phone_label = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // FIOlabel
            // 
            this.FIOlabel.AutoSize = true;
            this.FIOlabel.Location = new System.Drawing.Point(13, 13);
            this.FIOlabel.Name = "FIOlabel";
            this.FIOlabel.Size = new System.Drawing.Size(43, 13);
            this.FIOlabel.TabIndex = 0;
            this.FIOlabel.Text = "Ф.И.О.";
            // 
            // FIO_textbox
            // 
            this.FIO_textbox.Location = new System.Drawing.Point(16, 40);
            this.FIO_textbox.Name = "FIO_textbox";
            this.FIO_textbox.Size = new System.Drawing.Size(373, 20);
            this.FIO_textbox.TabIndex = 1;
            // 
            // e_mail_textbox
            // 
            this.e_mail_textbox.Location = new System.Drawing.Point(16, 100);
            this.e_mail_textbox.Name = "e_mail_textbox";
            this.e_mail_textbox.Size = new System.Drawing.Size(373, 20);
            this.e_mail_textbox.TabIndex = 3;
            // 
            // e_mail_label
            // 
            this.e_mail_label.AutoSize = true;
            this.e_mail_label.Location = new System.Drawing.Point(13, 73);
            this.e_mail_label.Name = "e_mail_label";
            this.e_mail_label.Size = new System.Drawing.Size(37, 13);
            this.e_mail_label.TabIndex = 2;
            this.e_mail_label.Text = "e_mail";
            // 
            // phone_textbox
            // 
            this.phone_textbox.Location = new System.Drawing.Point(16, 158);
            this.phone_textbox.Name = "phone_textbox";
            this.phone_textbox.Size = new System.Drawing.Size(373, 20);
            this.phone_textbox.TabIndex = 5;
            // 
            // phone_label
            // 
            this.phone_label.AutoSize = true;
            this.phone_label.Location = new System.Drawing.Point(13, 131);
            this.phone_label.Name = "phone_label";
            this.phone_label.Size = new System.Drawing.Size(93, 13);
            this.phone_label.TabIndex = 4;
            this.phone_label.Text = "Номер телефона";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(233, 199);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 19;
            this.addBtn.Text = "Добавить";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(314, 199);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(75, 23);
            this.cancelBtn.TabIndex = 18;
            this.cancelBtn.Text = "Отмена";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // AddCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 243);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.phone_textbox);
            this.Controls.Add(this.phone_label);
            this.Controls.Add(this.e_mail_textbox);
            this.Controls.Add(this.e_mail_label);
            this.Controls.Add(this.FIO_textbox);
            this.Controls.Add(this.FIOlabel);
            this.Name = "AddCustomer";
            this.Text = "AddCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label FIOlabel;
        private System.Windows.Forms.TextBox FIO_textbox;
        private System.Windows.Forms.TextBox e_mail_textbox;
        private System.Windows.Forms.Label e_mail_label;
        private System.Windows.Forms.TextBox phone_textbox;
        private System.Windows.Forms.Label phone_label;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button cancelBtn;
    }
}