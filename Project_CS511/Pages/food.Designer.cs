namespace Project_CS511.Pages
{
    partial class food
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(food));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_dinner = new System.Windows.Forms.Button();
            this.btn_delivery = new System.Windows.Forms.Button();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.foodlist4 = new Project_CS511.Component.foodlist();
            this.foodlist3 = new Project_CS511.Component.foodlist();
            this.foodlist2 = new Project_CS511.Component.foodlist();
            this.foodlist1 = new Project_CS511.Component.foodlist();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.Controls.Add(this.pictureBox4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(49, 89);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(434, 58);
            this.panel1.TabIndex = 19;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(9, 13);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(32, 34);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 8;
            this.pictureBox4.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.DarkGray;
            this.textBox1.Location = new System.Drawing.Point(41, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(376, 34);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = "What shall we deliver?";
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Controls.Add(this.foodlist4);
            this.panel2.Controls.Add(this.foodlist3);
            this.panel2.Controls.Add(this.foodlist2);
            this.panel2.Controls.Add(this.foodlist1);
            this.panel2.Location = new System.Drawing.Point(49, 236);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(453, 411);
            this.panel2.TabIndex = 23;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(43, 201);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(292, 32);
            this.label3.TabIndex = 22;
            this.label3.Text = "Popular Restaurants";
            // 
            // btn_dinner
            // 
            this.btn_dinner.BackColor = System.Drawing.SystemColors.Control;
            this.btn_dinner.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_dinner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_dinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dinner.Image = ((System.Drawing.Image)(resources.GetObject("btn_dinner.Image")));
            this.btn_dinner.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_dinner.Location = new System.Drawing.Point(277, 153);
            this.btn_dinner.Name = "btn_dinner";
            this.btn_dinner.Size = new System.Drawing.Size(173, 45);
            this.btn_dinner.TabIndex = 21;
            this.btn_dinner.Text = "Dine-in";
            this.btn_dinner.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_dinner.UseVisualStyleBackColor = false;
            this.btn_dinner.Click += new System.EventHandler(this.btn_dinner_Click);
            // 
            // btn_delivery
            // 
            this.btn_delivery.BackColor = System.Drawing.Color.LightCyan;
            this.btn_delivery.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_delivery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delivery.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delivery.ForeColor = System.Drawing.Color.Teal;
            this.btn_delivery.Image = ((System.Drawing.Image)(resources.GetObject("btn_delivery.Image")));
            this.btn_delivery.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_delivery.Location = new System.Drawing.Point(94, 153);
            this.btn_delivery.Name = "btn_delivery";
            this.btn_delivery.Size = new System.Drawing.Size(177, 45);
            this.btn_delivery.TabIndex = 20;
            this.btn_delivery.Text = "Delivery";
            this.btn_delivery.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_delivery.UseVisualStyleBackColor = false;
            this.btn_delivery.Click += new System.EventHandler(this.btn_delivery_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox5.BackgroundImage")));
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(492, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(29, 20);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox3.BackgroundImage")));
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(441, 2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(32, 20);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 17;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Aquamarine;
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(15, 15);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 34);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.lbl_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.Color.Black;
            this.lbl_address.Location = new System.Drawing.Point(76, 33);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(274, 32);
            this.lbl_address.TabIndex = 16;
            this.lbl_address.Text = "31/35/15 Ung Van ...";
            this.lbl_address.Click += new System.EventHandler(this.lbl_address_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(78, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 20);
            this.label1.TabIndex = 15;
            this.label1.Text = "Deliver to";
            // 
            // foodlist4
            // 
            this.foodlist4.Location = new System.Drawing.Point(3, 540);
            this.foodlist4.Name = "foodlist4";
            this.foodlist4.Size = new System.Drawing.Size(421, 127);
            this.foodlist4.TabIndex = 3;
            // 
            // foodlist3
            // 
            this.foodlist3.Location = new System.Drawing.Point(3, 407);
            this.foodlist3.Name = "foodlist3";
            this.foodlist3.Size = new System.Drawing.Size(421, 127);
            this.foodlist3.TabIndex = 2;
            // 
            // foodlist2
            // 
            this.foodlist2.Location = new System.Drawing.Point(3, 268);
            this.foodlist2.Name = "foodlist2";
            this.foodlist2.Size = new System.Drawing.Size(421, 127);
            this.foodlist2.TabIndex = 1;
            // 
            // foodlist1
            // 
            this.foodlist1.Location = new System.Drawing.Point(3, 131);
            this.foodlist1.Name = "foodlist1";
            this.foodlist1.Size = new System.Drawing.Size(421, 127);
            this.foodlist1.TabIndex = 0;
            // 
            // food
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_address);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btn_dinner);
            this.Controls.Add(this.btn_delivery);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Name = "food";
            this.Size = new System.Drawing.Size(533, 648);
            this.Load += new System.EventHandler(this.food_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Component.foodlist foodlist3;
        private Component.foodlist foodlist1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.TextBox textBox1;
        private Component.foodlist foodlist4;
        private System.Windows.Forms.Panel panel2;
        private Component.foodlist foodlist2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_dinner;
        private System.Windows.Forms.Button btn_delivery;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.Label label1;
    }
}
