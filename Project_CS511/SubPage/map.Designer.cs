namespace Project_CS511.SubPage
{
    partial class map
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(map));
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_recent = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_mapchoose = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.PictureBox();
            this.location1 = new Project_CS511.Component.location();
            this.location2 = new Project_CS511.Component.location();
            this.location3 = new Project_CS511.Component.location();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.Menu;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(69, 7);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(417, 27);
            this.textBox1.TabIndex = 1;
            // 
            // btn_recent
            // 
            this.btn_recent.BackColor = System.Drawing.Color.LightCyan;
            this.btn_recent.FlatAppearance.BorderSize = 0;
            this.btn_recent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_recent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_recent.ForeColor = System.Drawing.Color.Green;
            this.btn_recent.Location = new System.Drawing.Point(35, 48);
            this.btn_recent.Name = "btn_recent";
            this.btn_recent.Size = new System.Drawing.Size(87, 34);
            this.btn_recent.TabIndex = 2;
            this.btn_recent.Text = "Recent";
            this.btn_recent.UseVisualStyleBackColor = false;
            this.btn_recent.Click += new System.EventHandler(this.btn_recent_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Gray;
            this.button3.Location = new System.Drawing.Point(142, 51);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(105, 34);
            this.button3.TabIndex = 4;
            this.button3.Text = "Saved";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.location1);
            this.flowLayoutPanel1.Controls.Add(this.location2);
            this.flowLayoutPanel1.Controls.Add(this.location3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(24, 88);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(484, 599);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btn_mapchoose
            // 
            this.btn_mapchoose.BackColor = System.Drawing.SystemColors.Control;
            this.btn_mapchoose.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_mapchoose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_mapchoose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mapchoose.Image = ((System.Drawing.Image)(resources.GetObject("btn_mapchoose.Image")));
            this.btn_mapchoose.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btn_mapchoose.Location = new System.Drawing.Point(0, 693);
            this.btn_mapchoose.Name = "btn_mapchoose";
            this.btn_mapchoose.Size = new System.Drawing.Size(533, 45);
            this.btn_mapchoose.TabIndex = 11;
            this.btn_mapchoose.Text = "Choose from map";
            this.btn_mapchoose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_mapchoose.UseVisualStyleBackColor = false;
            this.btn_mapchoose.Click += new System.EventHandler(this.btn_mapchoose_Click);
            // 
            // btn_back
            // 
            this.btn_back.Image = ((System.Drawing.Image)(resources.GetObject("btn_back.Image")));
            this.btn_back.Location = new System.Drawing.Point(0, 4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(43, 28);
            this.btn_back.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_back.TabIndex = 0;
            this.btn_back.TabStop = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // location1
            // 
            this.location1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.location1.Location = new System.Drawing.Point(3, 3);
            this.location1.Name = "location1";
            this.location1.Size = new System.Drawing.Size(450, 117);
            this.location1.TabIndex = 0;
            // 
            // location2
            // 
            this.location2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.location2.Location = new System.Drawing.Point(3, 126);
            this.location2.Name = "location2";
            this.location2.Size = new System.Drawing.Size(450, 117);
            this.location2.TabIndex = 1;
            // 
            // location3
            // 
            this.location3.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.location3.Location = new System.Drawing.Point(3, 249);
            this.location3.Name = "location3";
            this.location3.Size = new System.Drawing.Size(450, 117);
            this.location3.TabIndex = 2;
            // 
            // map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btn_mapchoose);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_recent);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_back);
            this.Name = "map";
            this.Size = new System.Drawing.Size(533, 738);
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_back;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_recent;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_mapchoose;
        private Component.location location1;
        private Component.location location2;
        private Component.location location3;
    }
}
