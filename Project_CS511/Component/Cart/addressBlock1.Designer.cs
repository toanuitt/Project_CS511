namespace Project_CS511.Component.Cart
{
    partial class addressBlock1
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
            this.lb_adDescription = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.lb_address = new System.Windows.Forms.Label();
            this.pb_ad = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_ad)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_adDescription
            // 
            this.lb_adDescription.AutoSize = true;
            this.lb_adDescription.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_adDescription.Location = new System.Drawing.Point(30, 6);
            this.lb_adDescription.MaximumSize = new System.Drawing.Size(316, 19);
            this.lb_adDescription.Name = "lb_adDescription";
            this.lb_adDescription.Size = new System.Drawing.Size(134, 19);
            this.lb_adDescription.TabIndex = 5;
            this.lb_adDescription.Text = "Delivery Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 36);
            this.label1.MaximumSize = new System.Drawing.Size(316, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 19);
            this.label1.TabIndex = 6;
            this.label1.Text = "Phone Number   |";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.Location = new System.Drawing.Point(157, 36);
            this.lb_phone.MaximumSize = new System.Drawing.Size(316, 19);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(75, 19);
            this.lb_phone.TabIndex = 7;
            this.lb_phone.Text = "099238423";
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(8, 59);
            this.lb_address.MaximumSize = new System.Drawing.Size(350, 40);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(61, 19);
            this.lb_address.TabIndex = 8;
            this.lb_address.Text = "Address";
            this.lb_address.Click += new System.EventHandler(this.lb_address_Click);
            // 
            // pb_ad
            // 
            this.pb_ad.Image = global::Project_CS511.Properties.Resources.marker;
            this.pb_ad.Location = new System.Drawing.Point(3, 3);
            this.pb_ad.Name = "pb_ad";
            this.pb_ad.Size = new System.Drawing.Size(29, 26);
            this.pb_ad.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_ad.TabIndex = 4;
            this.pb_ad.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(349, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 31);
            this.label2.TabIndex = 10;
            this.label2.Text = ">";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addressBlock1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lb_address);
            this.Controls.Add(this.lb_phone);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_adDescription);
            this.Controls.Add(this.pb_ad);
            this.Name = "addressBlock1";
            this.Size = new System.Drawing.Size(400, 96);
            ((System.ComponentModel.ISupportInitialize)(this.pb_ad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_ad;
        private System.Windows.Forms.Label lb_adDescription;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.Label label2;
    }
}
