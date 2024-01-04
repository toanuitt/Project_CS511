namespace Project_CS511
{
    partial class testDatabase
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.flp_addCollection = new System.Windows.Forms.FlowLayoutPanel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // flp_addCollection
            // 
            this.flp_addCollection.AutoScroll = true;
            this.flp_addCollection.Location = new System.Drawing.Point(10, 5);
            this.flp_addCollection.Name = "flp_addCollection";
            this.flp_addCollection.Size = new System.Drawing.Size(120, 262);
            this.flp_addCollection.TabIndex = 2;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(136, 5);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(361, 262);
            this.flowLayoutPanel1.TabIndex = 3;
            // 
            // testDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 294);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.flp_addCollection);
            this.Name = "testDatabase";
            this.Text = "testDatabase";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel flp_addCollection;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}