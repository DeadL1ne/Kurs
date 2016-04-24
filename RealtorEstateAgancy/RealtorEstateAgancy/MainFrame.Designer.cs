namespace RealtorEstateAgancy
{
    partial class MainFrame
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
            this.btnEstate = new System.Windows.Forms.Button();
            this.btnRequest = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnEstate
            // 
            this.btnEstate.Location = new System.Drawing.Point(176, 22);
            this.btnEstate.Name = "btnEstate";
            this.btnEstate.Size = new System.Drawing.Size(96, 23);
            this.btnEstate.TabIndex = 0;
            this.btnEstate.Text = "Недвижимость";
            this.btnEstate.UseVisualStyleBackColor = true;
            this.btnEstate.Click += new System.EventHandler(this.btnEstate_Click);
            // 
            // btnRequest
            // 
            this.btnRequest.Location = new System.Drawing.Point(176, 62);
            this.btnRequest.Name = "btnRequest";
            this.btnRequest.Size = new System.Drawing.Size(96, 23);
            this.btnRequest.TabIndex = 1;
            this.btnRequest.Text = "Заявки";
            this.btnRequest.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRequest.UseVisualStyleBackColor = true;
            this.btnRequest.Click += new System.EventHandler(this.btnRequest_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Location = new System.Drawing.Point(176, 104);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(96, 23);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Клиенты";
            this.btnCustomer.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnCustomer.UseVisualStyleBackColor = true;
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.btnCustomer);
            this.Controls.Add(this.btnRequest);
            this.Controls.Add(this.btnEstate);
            this.Name = "MainFrame";
            this.Text = "Риэлтор 3000";
            this.Load += new System.EventHandler(this.MainFrame_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnEstate;
        private System.Windows.Forms.Button btnRequest;
        private System.Windows.Forms.Button btnCustomer;
    }
}

