namespace Project_CS511.Component
{
    partial class favouriteBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(favouriteBlock));
            this.pb_like = new System.Windows.Forms.PictureBox();
            this.lb_store = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.pb_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_like)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // pb_like
            // 
            this.pb_like.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_like.Image = global::Project_CS511.Properties.Resources.heart_on;
            this.pb_like.Location = new System.Drawing.Point(334, 22);
            this.pb_like.Name = "pb_like";
            this.pb_like.Size = new System.Drawing.Size(40, 36);
            this.pb_like.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_like.TabIndex = 21;
            this.pb_like.TabStop = false;
            this.pb_like.Click += new System.EventHandler(this.pb_like_Click);
            // 
            // lb_store
            // 
            this.lb_store.AutoSize = true;
            this.lb_store.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_store.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_store.Location = new System.Drawing.Point(83, 3);
            this.lb_store.MaximumSize = new System.Drawing.Size(165, 17);
            this.lb_store.Name = "lb_store";
            this.lb_store.Size = new System.Drawing.Size(94, 17);
            this.lb_store.TabIndex = 22;
            this.lb_store.Text = "Tiệm Cà Phê Muối";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_name.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(82, 22);
            this.lb_name.MaximumSize = new System.Drawing.Size(210, 50);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(167, 23);
            this.lb_name.TabIndex = 23;
            this.lb_name.Text = "Original Salt Coffee";
            // 
            // pb_picture
            // 
            this.pb_picture.Image = ((System.Drawing.Image)(resources.GetObject("pb_picture.Image")));
            this.pb_picture.Location = new System.Drawing.Point(3, 3);
            this.pb_picture.Name = "pb_picture";
            this.pb_picture.Size = new System.Drawing.Size(74, 74);
            this.pb_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_picture.TabIndex = 24;
            this.pb_picture.TabStop = false;
            // 
            // favouriteBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Tan;
            this.Controls.Add(this.pb_picture);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.lb_store);
            this.Controls.Add(this.pb_like);
            this.Name = "favouriteBlock";
            this.Size = new System.Drawing.Size(390, 80);
            ((System.ComponentModel.ISupportInitialize)(this.pb_like)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_like;
        private System.Windows.Forms.Label lb_store;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.PictureBox pb_picture;
    }
}
