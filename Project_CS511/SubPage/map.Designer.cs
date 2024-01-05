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
            this.txtbox_address = new System.Windows.Forms.TextBox();
            this.btn_recent = new System.Windows.Forms.Button();
            this.btn_saved = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btn_mapchoose = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).BeginInit();
            this.SuspendLayout();
            // 
            // txtbox_address
            // 
            this.txtbox_address.BackColor = System.Drawing.SystemColors.Menu;
            this.txtbox_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtbox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_address.Location = new System.Drawing.Point(69, 7);
            this.txtbox_address.Name = "txtbox_address";
            this.txtbox_address.Size = new System.Drawing.Size(417, 27);
            this.txtbox_address.TabIndex = 1;
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
            // btn_saved
            // 
            this.btn_saved.BackColor = System.Drawing.Color.White;
            this.btn_saved.FlatAppearance.BorderSize = 0;
            this.btn_saved.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_saved.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saved.ForeColor = System.Drawing.Color.Gray;
            this.btn_saved.Location = new System.Drawing.Point(139, 48);
            this.btn_saved.Name = "btn_saved";
            this.btn_saved.Size = new System.Drawing.Size(105, 34);
            this.btn_saved.TabIndex = 4;
            this.btn_saved.Text = "Saved";
            this.btn_saved.UseVisualStyleBackColor = false;
            this.btn_saved.Click += new System.EventHandler(this.btn_saved_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
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
            // map
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.btn_mapchoose);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.btn_saved);
            this.Controls.Add(this.btn_recent);
            this.Controls.Add(this.txtbox_address);
            this.Controls.Add(this.btn_back);
            this.Name = "map";
            this.Size = new System.Drawing.Size(533, 738);
            this.Load += new System.EventHandler(this.map_Load);
            ((System.ComponentModel.ISupportInitialize)(this.btn_back)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_back;
        private System.Windows.Forms.TextBox txtbox_address;
        private System.Windows.Forms.Button btn_recent;
        private System.Windows.Forms.Button btn_saved;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btn_mapchoose;
    }
}
