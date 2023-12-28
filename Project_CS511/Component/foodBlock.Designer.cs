namespace Project_CS511.Component
{
    partial class foodBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foodBlock));
            this.lb_price = new System.Windows.Forms.Label();
            this.lb_name = new System.Windows.Forms.Label();
            this.pb_store = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pb_picture = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.Location = new System.Drawing.Point(7, 187);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(80, 22);
            this.lb_price.TabIndex = 7;
            this.lb_price.Text = "27.000₫";
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(7, 108);
            this.lb_name.MaximumSize = new System.Drawing.Size(165, 50);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(122, 44);
            this.lb_name.TabIndex = 6;
            this.lb_name.Text = "Original Salt Coffee";
            // 
            // pb_store
            // 
            this.pb_store.AutoSize = true;
            this.pb_store.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pb_store.Location = new System.Drawing.Point(8, 166);
            this.pb_store.MaximumSize = new System.Drawing.Size(165, 17);
            this.pb_store.Name = "pb_store";
            this.pb_store.Size = new System.Drawing.Size(127, 17);
            this.pb_store.TabIndex = 8;
            this.pb_store.Text = "Tiệm Cà Phê Muối";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Location = new System.Drawing.Point(8, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "________________________";
            // 
            // pb_picture
            // 
            this.pb_picture.Image = ((System.Drawing.Image)(resources.GetObject("pb_picture.Image")));
            this.pb_picture.Location = new System.Drawing.Point(11, 3);
            this.pb_picture.Name = "pb_picture";
            this.pb_picture.Size = new System.Drawing.Size(149, 97);
            this.pb_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_picture.TabIndex = 5;
            this.pb_picture.TabStop = false;
            // 
            // foodBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_store);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.pb_picture);
            this.Name = "foodBlock";
            this.Size = new System.Drawing.Size(166, 211);
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.PictureBox pb_picture;
        private System.Windows.Forms.Label pb_store;
        private System.Windows.Forms.Label label2;
    }
}
