namespace Project_CS511.Component.shopSubPage
{
    partial class shopFoodBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(shopFoodBlock));
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_store = new System.Windows.Forms.Label();
            this.pb_picture = new System.Windows.Forms.PictureBox();
            this.pb_like = new System.Windows.Forms.PictureBox();
            this.lb_price = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lb_star = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_like)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_name.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(79, 18);
            this.lb_name.MaximumSize = new System.Drawing.Size(270, 50);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(167, 23);
            this.lb_name.TabIndex = 27;
            this.lb_name.Text = "Original Salt Coffee";
            this.lb_name.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // lb_store
            // 
            this.lb_store.AutoSize = true;
            this.lb_store.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_store.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_store.Location = new System.Drawing.Point(80, 3);
            this.lb_store.MaximumSize = new System.Drawing.Size(165, 17);
            this.lb_store.Name = "lb_store";
            this.lb_store.Size = new System.Drawing.Size(94, 17);
            this.lb_store.TabIndex = 26;
            this.lb_store.Text = "Tiệm Cà Phê Muối";
            this.lb_store.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // pb_picture
            // 
            this.pb_picture.Image = ((System.Drawing.Image)(resources.GetObject("pb_picture.Image")));
            this.pb_picture.Location = new System.Drawing.Point(0, 3);
            this.pb_picture.Name = "pb_picture";
            this.pb_picture.Size = new System.Drawing.Size(74, 74);
            this.pb_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_picture.TabIndex = 28;
            this.pb_picture.TabStop = false;
            this.pb_picture.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // pb_like
            // 
            this.pb_like.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_like.Image = global::Project_CS511.Properties.Resources.heart_off;
            this.pb_like.Location = new System.Drawing.Point(332, 9);
            this.pb_like.Name = "pb_like";
            this.pb_like.Size = new System.Drawing.Size(40, 36);
            this.pb_like.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_like.TabIndex = 25;
            this.pb_like.TabStop = false;
            this.pb_like.Click += new System.EventHandler(this.pb_like_Click_1);
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_price.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(79, 60);
            this.lb_price.MaximumSize = new System.Drawing.Size(210, 50);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(80, 22);
            this.lb_price.TabIndex = 29;
            this.lb_price.Text = "25.000D";
            this.lb_price.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Candara", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(186, 59);
            this.label1.MaximumSize = new System.Drawing.Size(210, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 19);
            this.label1.TabIndex = 30;
            this.label1.Text = "|";
            this.label1.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(236, 58);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(22, 20);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 31;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // lb_star
            // 
            this.lb_star.AutoSize = true;
            this.lb_star.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_star.Font = new System.Drawing.Font("Bahnschrift Condensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_star.Location = new System.Drawing.Point(259, 56);
            this.lb_star.MaximumSize = new System.Drawing.Size(210, 50);
            this.lb_star.Name = "lb_star";
            this.lb_star.Size = new System.Drawing.Size(29, 23);
            this.lb_star.TabIndex = 32;
            this.lb_star.Text = "4.8";
            this.lb_star.Click += new System.EventHandler(this.lb_name_Click);
            // 
            // shopFoodBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.Controls.Add(this.lb_star);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.pb_picture);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_store);
            this.Controls.Add(this.pb_like);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "shopFoodBlock";
            this.Size = new System.Drawing.Size(380, 80);
            this.Load += new System.EventHandler(this.shopFoodBlock_Load);
            this.Click += new System.EventHandler(this.lb_name_Click);
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_like)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_picture;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_store;
        private System.Windows.Forms.PictureBox pb_like;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lb_star;
    }
}
