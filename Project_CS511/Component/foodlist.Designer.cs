namespace Project_CS511.Component
{
    partial class foodlist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foodlist));
            this.lbl_price = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pb_picture = new System.Windows.Forms.PictureBox();
            this.lbl_name = new System.Windows.Forms.RichTextBox();
            this.lb_star = new System.Windows.Forms.Label();
            this.pb_star = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_price
            // 
            this.lbl_price.AutoSize = true;
            this.lbl_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbl_price.Location = new System.Drawing.Point(139, 50);
            this.lbl_price.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_price.Name = "lbl_price";
            this.lbl_price.Size = new System.Drawing.Size(82, 24);
            this.lbl_price.TabIndex = 12;
            this.lbl_price.Text = "13.000 đ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(112, 49);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(22, 24);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 11;
            this.pictureBox3.TabStop = false;
            // 
            // pb_picture
            // 
            this.pb_picture.Image = ((System.Drawing.Image)(resources.GetObject("pb_picture.Image")));
            this.pb_picture.Location = new System.Drawing.Point(2, 1);
            this.pb_picture.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pb_picture.Name = "pb_picture";
            this.pb_picture.Size = new System.Drawing.Size(102, 101);
            this.pb_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_picture.TabIndex = 9;
            this.pb_picture.TabStop = false;
            this.pb_picture.Click += new System.EventHandler(this.pb_picture_Click);
            // 
            // lbl_name
            // 
            this.lbl_name.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lbl_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(109, 2);
            this.lbl_name.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(198, 45);
            this.lbl_name.TabIndex = 13;
            this.lbl_name.Text = "";
            // 
            // lb_star
            // 
            this.lb_star.AutoSize = true;
            this.lb_star.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_star.Location = new System.Drawing.Point(137, 78);
            this.lb_star.Name = "lb_star";
            this.lb_star.Size = new System.Drawing.Size(28, 19);
            this.lb_star.TabIndex = 15;
            this.lb_star.Text = "4.8";
            // 
            // pb_star
            // 
            this.pb_star.Image = global::Project_CS511.Properties.Resources.star;
            this.pb_star.Location = new System.Drawing.Point(112, 75);
            this.pb_star.Name = "pb_star";
            this.pb_star.Size = new System.Drawing.Size(25, 25);
            this.pb_star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_star.TabIndex = 14;
            this.pb_star.TabStop = false;
            // 
            // foodlist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_star);
            this.Controls.Add(this.pb_star);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.lbl_price);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pb_picture);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "foodlist";
            this.Size = new System.Drawing.Size(319, 103);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_price;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pb_picture;
        private System.Windows.Forms.RichTextBox lbl_name;
        private System.Windows.Forms.Label lb_star;
        private System.Windows.Forms.PictureBox pb_star;
    }
}
