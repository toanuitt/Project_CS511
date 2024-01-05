namespace Project_CS511.Component
{
    partial class location
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(location));
            this.label1 = new System.Windows.Forms.Label();
            this.richtxtbox_address = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btn_choose = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_choose)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Current location";
            // 
            // richtxtbox_address
            // 
            this.richtxtbox_address.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.richtxtbox_address.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richtxtbox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richtxtbox_address.ForeColor = System.Drawing.Color.DimGray;
            this.richtxtbox_address.Location = new System.Drawing.Point(49, 30);
            this.richtxtbox_address.Name = "richtxtbox_address";
            this.richtxtbox_address.ReadOnly = true;
            this.richtxtbox_address.Size = new System.Drawing.Size(339, 70);
            this.richtxtbox_address.TabIndex = 5;
            this.richtxtbox_address.Text = "06 Trần Văn Ơn, Phú Hoà, Thủ Dầu Một, Bình Dương, Vietnam";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 16);
            this.label2.TabIndex = 7;
            this.label2.Text = "_______________________________________________________________";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(423, 30);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(21, 28);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // btn_choose
            // 
            this.btn_choose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_choose.Image = global::Project_CS511.Properties.Resources.clock;
            this.btn_choose.Location = new System.Drawing.Point(3, 30);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(40, 28);
            this.btn_choose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_choose.TabIndex = 0;
            this.btn_choose.TabStop = false;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // location
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.richtxtbox_address);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_choose);
            this.Name = "location";
            this.Size = new System.Drawing.Size(447, 117);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_choose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_choose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox richtxtbox_address;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label2;
    }
}
