namespace Project_CS511.Component
{
    partial class adSlide
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
            this.adBlock1 = new Project_CS511.Component.adBlock();
            this.adBlock2 = new Project_CS511.Component.adBlock();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.flowLayoutPanel1.Controls.Add(this.adBlock1);
            this.flowLayoutPanel1.Controls.Add(this.adBlock2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(418, 233);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // adBlock1
            // 
            this.adBlock1.Location = new System.Drawing.Point(3, 3);
            this.adBlock1.Name = "adBlock1";
            this.adBlock1.Size = new System.Drawing.Size(316, 204);
            this.adBlock1.TabIndex = 0;
            // 
            // adBlock2
            // 
            this.adBlock2.Location = new System.Drawing.Point(325, 3);
            this.adBlock2.Name = "adBlock2";
            this.adBlock2.Size = new System.Drawing.Size(316, 204);
            this.adBlock2.TabIndex = 1;
            // 
            // adSlide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "adSlide";
            this.Size = new System.Drawing.Size(400, 215);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private adBlock adBlock1;
        private adBlock adBlock2;
    }
}
