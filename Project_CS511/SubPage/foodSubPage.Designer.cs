namespace Project_CS511.SubPage
{
    partial class foodSubPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(foodSubPage));
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_store = new System.Windows.Forms.Label();
            this.lb_star = new System.Windows.Forms.Label();
            this.lb_price = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_success = new System.Windows.Forms.Button();
            this.pb_back = new System.Windows.Forms.PictureBox();
            this.pb_addToCart = new System.Windows.Forms.PictureBox();
            this.pb_star = new System.Windows.Forms.PictureBox();
            this.pb_food = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addToCart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_food)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_name.Font = new System.Drawing.Font("Candara", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(1, 223);
            this.lb_name.MaximumSize = new System.Drawing.Size(350, 66);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(240, 33);
            this.lb_name.TabIndex = 7;
            this.lb_name.Text = "Original Salt Coffee";
            // 
            // lb_store
            // 
            this.lb_store.AutoSize = true;
            this.lb_store.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_store.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_store.Location = new System.Drawing.Point(0, 202);
            this.lb_store.MaximumSize = new System.Drawing.Size(165, 17);
            this.lb_store.Name = "lb_store";
            this.lb_store.Size = new System.Drawing.Size(137, 17);
            this.lb_store.TabIndex = 9;
            this.lb_store.Text = "Tiệm Cà Phê Muối";
            // 
            // lb_star
            // 
            this.lb_star.AutoSize = true;
            this.lb_star.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_star.Font = new System.Drawing.Font("Impact", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_star.Location = new System.Drawing.Point(342, 297);
            this.lb_star.Name = "lb_star";
            this.lb_star.Size = new System.Drawing.Size(37, 26);
            this.lb_star.TabIndex = 12;
            this.lb_star.Text = "4.8";
            // 
            // lb_price
            // 
            this.lb_price.AutoSize = true;
            this.lb_price.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_price.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_price.ForeColor = System.Drawing.Color.DarkOliveGreen;
            this.lb_price.Location = new System.Drawing.Point(0, 297);
            this.lb_price.Name = "lb_price";
            this.lb_price.Size = new System.Drawing.Size(111, 32);
            this.lb_price.TabIndex = 13;
            this.lb_price.Text = "27.000₫";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Location = new System.Drawing.Point(-3, 330);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(409, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "___________________________________________________________________";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 455);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(409, 175);
            this.flowLayoutPanel1.TabIndex = 16;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // btn_success
            // 
            this.btn_success.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_success.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_success.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_success.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_success.Location = new System.Drawing.Point(122, 12);
            this.btn_success.Name = "btn_success";
            this.btn_success.Size = new System.Drawing.Size(142, 33);
            this.btn_success.TabIndex = 19;
            this.btn_success.Text = "Added to basket";
            this.btn_success.UseVisualStyleBackColor = false;
            this.btn_success.Visible = false;
            // 
            // pb_back
            // 
            this.pb_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_back.Image = global::Project_CS511.Properties.Resources.back;
            this.pb_back.Location = new System.Drawing.Point(3, 155);
            this.pb_back.Name = "pb_back";
            this.pb_back.Size = new System.Drawing.Size(40, 36);
            this.pb_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_back.TabIndex = 17;
            this.pb_back.TabStop = false;
            this.pb_back.Click += new System.EventHandler(this.pb_back_Click);
            // 
            // pb_addToCart
            // 
            this.pb_addToCart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_addToCart.Image = global::Project_CS511.Properties.Resources.add;
            this.pb_addToCart.Location = new System.Drawing.Point(131, 294);
            this.pb_addToCart.Name = "pb_addToCart";
            this.pb_addToCart.Size = new System.Drawing.Size(40, 36);
            this.pb_addToCart.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_addToCart.TabIndex = 14;
            this.pb_addToCart.TabStop = false;
            this.pb_addToCart.Click += new System.EventHandler(this.pb_addToCart_Click);
            // 
            // pb_star
            // 
            this.pb_star.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_star.Image = global::Project_CS511.Properties.Resources.star;
            this.pb_star.Location = new System.Drawing.Point(301, 291);
            this.pb_star.Name = "pb_star";
            this.pb_star.Size = new System.Drawing.Size(40, 36);
            this.pb_star.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_star.TabIndex = 11;
            this.pb_star.TabStop = false;
            // 
            // pb_food
            // 
            this.pb_food.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.pb_food.Image = ((System.Drawing.Image)(resources.GetObject("pb_food.Image")));
            this.pb_food.Location = new System.Drawing.Point(0, 0);
            this.pb_food.Name = "pb_food";
            this.pb_food.Size = new System.Drawing.Size(400, 149);
            this.pb_food.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pb_food.TabIndex = 0;
            this.pb_food.TabStop = false;
            // 
            // foodSubPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btn_success);
            this.Controls.Add(this.pb_back);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pb_addToCart);
            this.Controls.Add(this.lb_price);
            this.Controls.Add(this.lb_star);
            this.Controls.Add(this.pb_star);
            this.Controls.Add(this.lb_store);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.pb_food);
            this.Name = "foodSubPage";
            this.Size = new System.Drawing.Size(400, 600);
            ((System.ComponentModel.ISupportInitialize)(this.pb_back)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addToCart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_star)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_food)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_food;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_store;
        private System.Windows.Forms.Label lb_star;
        private System.Windows.Forms.PictureBox pb_star;
        private System.Windows.Forms.Label lb_price;
        private System.Windows.Forms.PictureBox pb_addToCart;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.PictureBox pb_back;
        private System.Windows.Forms.Button btn_success;
    }
}
