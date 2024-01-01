namespace Project_CS511.Component
{
    partial class adBlock
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(adBlock));
            this.lb_adDescription = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_ad = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ad)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_adDescription
            // 
            this.lb_adDescription.AutoSize = true;
            this.lb_adDescription.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_adDescription.Location = new System.Drawing.Point(4, 222);
            this.lb_adDescription.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lb_adDescription.MaximumSize = new System.Drawing.Size(421, 23);
            this.lb_adDescription.Name = "lb_adDescription";
            this.lb_adDescription.Size = new System.Drawing.Size(216, 23);
            this.lb_adDescription.TabIndex = 1;
            this.lb_adDescription.Text = "McDonald\'s - Hồ Gươm";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Đặt ngay ➤";
            // 
            // pb_ad
            // 
            this.pb_ad.Image = ((System.Drawing.Image)(resources.GetObject("pb_ad.Image")));
            this.pb_ad.Location = new System.Drawing.Point(0, 36);
            this.pb_ad.Margin = new System.Windows.Forms.Padding(4);
            this.pb_ad.Name = "pb_ad";
            this.pb_ad.Size = new System.Drawing.Size(413, 182);
            this.pb_ad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ad.TabIndex = 0;
            this.pb_ad.TabStop = false;
            this.pb_ad.Click += new System.EventHandler(this.pb_ad_Click);
            // 
            // adBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_adDescription);
            this.Controls.Add(this.pb_ad);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "adBlock";
            this.Size = new System.Drawing.Size(421, 251);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_ad;
        private System.Windows.Forms.Label lb_adDescription;
        private System.Windows.Forms.Label label2;
    }
}
