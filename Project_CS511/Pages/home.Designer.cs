namespace Project_CS511.Pages
{
    partial class home
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(home));
            this.flp_home = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.restaurantSlide1 = new Project_CS511.Component.restaurantSlide();
            this.label2 = new System.Windows.Forms.Label();
            this.pic_advertisement = new System.Windows.Forms.PictureBox();
            this.flp_home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_advertisement)).BeginInit();
            this.SuspendLayout();
            // 
            // flp_home
            // 
            this.flp_home.AutoScroll = true;
            this.flp_home.Controls.Add(this.pic_advertisement);
            this.flp_home.Controls.Add(this.label1);
            this.flp_home.Controls.Add(this.restaurantSlide1);
            this.flp_home.Controls.Add(this.label2);
            this.flp_home.Location = new System.Drawing.Point(-4, -5);
            this.flp_home.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.flp_home.Name = "flp_home";
            this.flp_home.Size = new System.Drawing.Size(563, 667);
            this.flp_home.TabIndex = 0;
            this.flp_home.Paint += new System.Windows.Forms.PaintEventHandler(this.flp_home_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 205);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Restaurants you may like ➜";
            // 
            // restaurantSlide1
            // 
            this.restaurantSlide1.Location = new System.Drawing.Point(5, 239);
            this.restaurantSlide1.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.restaurantSlide1.Name = "restaurantSlide1";
            this.restaurantSlide1.Size = new System.Drawing.Size(533, 228);
            this.restaurantSlide1.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(4, 472);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(153, 29);
            this.label2.TabIndex = 5;
            this.label2.Text = "Quảng cáo ➜";
            // 
            // pic_advertisement
            // 
            this.pic_advertisement.Image = ((System.Drawing.Image)(resources.GetObject("pic_advertisement.Image")));
            this.pic_advertisement.Location = new System.Drawing.Point(4, 4);
            this.pic_advertisement.Margin = new System.Windows.Forms.Padding(4);
            this.pic_advertisement.Name = "pic_advertisement";
            this.pic_advertisement.Size = new System.Drawing.Size(533, 197);
            this.pic_advertisement.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_advertisement.TabIndex = 1;
            this.pic_advertisement.TabStop = false;
            // 
            // home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.flp_home);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "home";
            this.Size = new System.Drawing.Size(533, 640);
            this.flp_home.ResumeLayout(false);
            this.flp_home.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_advertisement)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flp_home;
        private System.Windows.Forms.PictureBox pic_advertisement;
        private System.Windows.Forms.Label label1;
        private Component.restaurantSlide restaurantSlide1;
        private System.Windows.Forms.Label label2;
    }
}
