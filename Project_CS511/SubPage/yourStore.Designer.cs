namespace Project_CS511.SubPage
{
    partial class yourStore
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(yourStore));
            this.panel4 = new System.Windows.Forms.Panel();
            this.cb_filter = new System.Windows.Forms.ComboBox();
            this.pb_search = new System.Windows.Forms.PictureBox();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lb_address = new System.Windows.Forms.Label();
            this.pb_picture = new System.Windows.Forms.PictureBox();
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_phone = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_back = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cb_foodType = new System.Windows.Forms.ComboBox();
            this.pb_newImg = new System.Windows.Forms.PictureBox();
            this.tb_price = new System.Windows.Forms.TextBox();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.btn_update = new System.Windows.Forms.Button();
            this.btn_success = new System.Windows.Forms.Button();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_newImg)).BeginInit();
            this.SuspendLayout();
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel4.Controls.Add(this.cb_filter);
            this.panel4.Controls.Add(this.pb_search);
            this.panel4.Controls.Add(this.tb_search);
            this.panel4.Location = new System.Drawing.Point(0, 121);
            this.panel4.Margin = new System.Windows.Forms.Padding(2);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(400, 47);
            this.panel4.TabIndex = 25;
            // 
            // cb_filter
            // 
            this.cb_filter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_filter.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_filter.FormattingEnabled = true;
            this.cb_filter.Location = new System.Drawing.Point(296, 11);
            this.cb_filter.Name = "cb_filter";
            this.cb_filter.Size = new System.Drawing.Size(94, 27);
            this.cb_filter.TabIndex = 9;
            this.cb_filter.SelectedIndexChanged += new System.EventHandler(this.cb_filter_SelectedIndexChanged_1);
            // 
            // pb_search
            // 
            this.pb_search.Image = ((System.Drawing.Image)(resources.GetObject("pb_search.Image")));
            this.pb_search.Location = new System.Drawing.Point(7, 11);
            this.pb_search.Margin = new System.Windows.Forms.Padding(2);
            this.pb_search.Name = "pb_search";
            this.pb_search.Size = new System.Drawing.Size(24, 28);
            this.pb_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_search.TabIndex = 8;
            this.pb_search.TabStop = false;
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Bahnschrift SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.ForeColor = System.Drawing.Color.Black;
            this.tb_search.Location = new System.Drawing.Point(31, 11);
            this.tb_search.Margin = new System.Windows.Forms.Padding(2);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(249, 27);
            this.tb_search.TabIndex = 0;
            this.tb_search.Text = "What shall we deliver?";
            this.tb_search.Click += new System.EventHandler(this.tb_search_Click);
            this.tb_search.TextChanged += new System.EventHandler(this.tb_search_TextChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Wheat;
            this.panel3.Controls.Add(this.lb_address);
            this.panel3.Controls.Add(this.pb_picture);
            this.panel3.Controls.Add(this.lb_name);
            this.panel3.Controls.Add(this.lb_phone);
            this.panel3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(0, 32);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(400, 90);
            this.panel3.TabIndex = 22;
            // 
            // lb_address
            // 
            this.lb_address.AutoSize = true;
            this.lb_address.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_address.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_address.Location = new System.Drawing.Point(94, 50);
            this.lb_address.MaximumSize = new System.Drawing.Size(300, 40);
            this.lb_address.Name = "lb_address";
            this.lb_address.Size = new System.Drawing.Size(296, 36);
            this.lb_address.TabIndex = 28;
            this.lb_address.Text = "129 Thạnh Xuân 43, Thạnh Xuân, Quận 12, Thành phố Hồ Chí Minh, Vietnam";
            // 
            // pb_picture
            // 
            this.pb_picture.Image = ((System.Drawing.Image)(resources.GetObject("pb_picture.Image")));
            this.pb_picture.Location = new System.Drawing.Point(3, 7);
            this.pb_picture.Name = "pb_picture";
            this.pb_picture.Size = new System.Drawing.Size(83, 74);
            this.pb_picture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_picture.TabIndex = 27;
            this.pb_picture.TabStop = false;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_name.Font = new System.Drawing.Font("Candara", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(92, 7);
            this.lb_name.MaximumSize = new System.Drawing.Size(300, 50);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(188, 26);
            this.lb_name.TabIndex = 26;
            this.lb_name.Text = "Original Salt Coffee";
            // 
            // lb_phone
            // 
            this.lb_phone.AutoSize = true;
            this.lb_phone.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_phone.Font = new System.Drawing.Font("Bahnschrift Light Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_phone.Location = new System.Drawing.Point(94, 31);
            this.lb_phone.MaximumSize = new System.Drawing.Size(165, 17);
            this.lb_phone.Name = "lb_phone";
            this.lb_phone.Size = new System.Drawing.Size(99, 17);
            this.lb_phone.TabIndex = 25;
            this.lb_phone.Text = "Phone: 0981452131";
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(-4, 173);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(409, 295);
            this.flowLayoutPanel1.TabIndex = 24;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.ForeColor = System.Drawing.Color.DarkSeaGreen;
            this.panel2.Location = new System.Drawing.Point(-4, 573);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(409, 27);
            this.panel2.TabIndex = 23;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.panel1.Controls.Add(this.btn_back);
            this.panel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.panel1.Location = new System.Drawing.Point(-4, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(409, 33);
            this.panel1.TabIndex = 21;
            // 
            // btn_back
            // 
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(2, 2);
            this.btn_back.Margin = new System.Windows.Forms.Padding(2);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(28, 25);
            this.btn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_back.TabIndex = 11;
            this.btn_back.TabStop = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_success);
            this.groupBox1.Controls.Add(this.cb_foodType);
            this.groupBox1.Controls.Add(this.pb_newImg);
            this.groupBox1.Controls.Add(this.tb_price);
            this.groupBox1.Controls.Add(this.tb_name);
            this.groupBox1.Controls.Add(this.btn_update);
            this.groupBox1.Location = new System.Drawing.Point(0, 474);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(400, 93);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            // 
            // cb_foodType
            // 
            this.cb_foodType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_foodType.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_foodType.FormattingEnabled = true;
            this.cb_foodType.Location = new System.Drawing.Point(201, 56);
            this.cb_foodType.Name = "cb_foodType";
            this.cb_foodType.Size = new System.Drawing.Size(90, 27);
            this.cb_foodType.TabIndex = 41;
            // 
            // pb_newImg
            // 
            this.pb_newImg.Image = ((System.Drawing.Image)(resources.GetObject("pb_newImg.Image")));
            this.pb_newImg.Location = new System.Drawing.Point(7, 13);
            this.pb_newImg.Name = "pb_newImg";
            this.pb_newImg.Size = new System.Drawing.Size(79, 74);
            this.pb_newImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_newImg.TabIndex = 37;
            this.pb_newImg.TabStop = false;
            this.pb_newImg.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tb_price
            // 
            this.tb_price.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_price.ForeColor = System.Drawing.Color.Black;
            this.tb_price.Location = new System.Drawing.Point(91, 54);
            this.tb_price.Margin = new System.Windows.Forms.Padding(2);
            this.tb_price.MaxLength = 7;
            this.tb_price.Name = "tb_price";
            this.tb_price.Size = new System.Drawing.Size(105, 30);
            this.tb_price.TabIndex = 40;
            this.tb_price.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_price_KeyPress);
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.ForeColor = System.Drawing.Color.Black;
            this.tb_name.Location = new System.Drawing.Point(91, 13);
            this.tb_name.Margin = new System.Windows.Forms.Padding(2);
            this.tb_name.MaxLength = 50;
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(200, 30);
            this.tb_name.TabIndex = 38;
            // 
            // btn_update
            // 
            this.btn_update.BackColor = System.Drawing.Color.LightBlue;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(304, 13);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(86, 70);
            this.btn_update.TabIndex = 39;
            this.btn_update.Text = "Add product";
            this.btn_update.UseVisualStyleBackColor = false;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // btn_success
            // 
            this.btn_success.BackColor = System.Drawing.Color.OliveDrab;
            this.btn_success.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_success.Font = new System.Drawing.Font("Bahnschrift Condensed", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_success.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_success.Location = new System.Drawing.Point(134, 55);
            this.btn_success.Name = "btn_success";
            this.btn_success.Size = new System.Drawing.Size(142, 33);
            this.btn_success.TabIndex = 42;
            this.btn_success.Text = "Product Added Success";
            this.btn_success.UseVisualStyleBackColor = false;
            this.btn_success.Visible = false;
            // 
            // yourStore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "yourStore";
            this.Size = new System.Drawing.Size(400, 600);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_picture)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_newImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox cb_filter;
        private System.Windows.Forms.PictureBox pb_search;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lb_address;
        private System.Windows.Forms.PictureBox pb_picture;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_phone;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_back;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cb_foodType;
        private System.Windows.Forms.PictureBox pb_newImg;
        private System.Windows.Forms.TextBox tb_price;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Button btn_update;
        private System.Windows.Forms.Button btn_success;
    }
}
