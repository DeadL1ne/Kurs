namespace RealtorEstateAgancy
{
    partial class ShowPhotoForm
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
            this.previousBtn = new System.Windows.Forms.Button();
            this.nextBtn = new System.Windows.Forms.Button();
            this.photoPictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // previousBtn
            // 
            this.previousBtn.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.previousBtn.Location = new System.Drawing.Point(150, 333);
            this.previousBtn.Name = "previousBtn";
            this.previousBtn.Size = new System.Drawing.Size(93, 23);
            this.previousBtn.TabIndex = 5;
            this.previousBtn.Text = "Предыдущее";
            this.previousBtn.UseVisualStyleBackColor = true;
            this.previousBtn.Click += new System.EventHandler(this.previousBtn_Click);
            // 
            // nextBtn
            // 
            this.nextBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.nextBtn.Location = new System.Drawing.Point(249, 333);
            this.nextBtn.Name = "nextBtn";
            this.nextBtn.Size = new System.Drawing.Size(93, 23);
            this.nextBtn.TabIndex = 4;
            this.nextBtn.Text = "Следующее";
            this.nextBtn.UseVisualStyleBackColor = true;
            this.nextBtn.Click += new System.EventHandler(this.nextBtn_Click);
            // 
            // photoPictureBox
            // 
            this.photoPictureBox.Location = new System.Drawing.Point(56, 90);
            this.photoPictureBox.Name = "photoPictureBox";
            this.photoPictureBox.Size = new System.Drawing.Size(286, 237);
            this.photoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.photoPictureBox.TabIndex = 3;
            this.photoPictureBox.TabStop = false;
            // 
            // ShowPhotoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 446);
            this.Controls.Add(this.previousBtn);
            this.Controls.Add(this.nextBtn);
            this.Controls.Add(this.photoPictureBox);
            this.Name = "ShowPhotoForm";
            this.Text = "ShowPhotoForm";
            this.Load += new System.EventHandler(this.ShowPhotoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.photoPictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button previousBtn;
        private System.Windows.Forms.Button nextBtn;
        private System.Windows.Forms.PictureBox photoPictureBox;
    }
}