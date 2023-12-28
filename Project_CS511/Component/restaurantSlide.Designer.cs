namespace Project_CS511.Component
{
    partial class restaurantSlide
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.restaurantBlock1 = new Project_CS511.Component.restaurantBlock();
            this.restaurantBlock2 = new Project_CS511.Component.restaurantBlock();
            this.restaurantBlock3 = new Project_CS511.Component.restaurantBlock();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.restaurantBlock1);
            this.flowLayoutPanel1.Controls.Add(this.restaurantBlock2);
            this.flowLayoutPanel1.Controls.Add(this.restaurantBlock3);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(422, 210);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // restaurantBlock1
            // 
            this.restaurantBlock1.Location = new System.Drawing.Point(3, 3);
            this.restaurantBlock1.Name = "restaurantBlock1";
            this.restaurantBlock1.Size = new System.Drawing.Size(166, 182);
            this.restaurantBlock1.TabIndex = 0;
            // 
            // restaurantBlock2
            // 
            this.restaurantBlock2.AutoScroll = true;
            this.restaurantBlock2.Location = new System.Drawing.Point(175, 3);
            this.restaurantBlock2.Name = "restaurantBlock2";
            this.restaurantBlock2.Size = new System.Drawing.Size(166, 182);
            this.restaurantBlock2.TabIndex = 1;
            // 
            // restaurantBlock3
            // 
            this.restaurantBlock3.Location = new System.Drawing.Point(347, 3);
            this.restaurantBlock3.Name = "restaurantBlock3";
            this.restaurantBlock3.Size = new System.Drawing.Size(166, 182);
            this.restaurantBlock3.TabIndex = 2;
            // 
            // restaurantSlide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "restaurantSlide";
            this.Size = new System.Drawing.Size(400, 185);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private restaurantBlock restaurantBlock1;
        private restaurantBlock restaurantBlock2;
        private restaurantBlock restaurantBlock3;
    }
}
