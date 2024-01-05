namespace Project_CS511.Component.Cart
{
    partial class OrderBlock
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
            this.lb_shopName = new System.Windows.Forms.Label();
            this.flp_order = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // lb_shopName
            // 
            this.lb_shopName.AutoSize = true;
            this.lb_shopName.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_shopName.Location = new System.Drawing.Point(3, 9);
            this.lb_shopName.MaximumSize = new System.Drawing.Size(316, 40);
            this.lb_shopName.Name = "lb_shopName";
            this.lb_shopName.Size = new System.Drawing.Size(94, 23);
            this.lb_shopName.TabIndex = 7;
            this.lb_shopName.Text = "Shop Name";
            // 
            // flp_order
            // 
            this.flp_order.Location = new System.Drawing.Point(2, 40);
            this.flp_order.Name = "flp_order";
            this.flp_order.Size = new System.Drawing.Size(388, 159);
            this.flp_order.TabIndex = 8;
            // 
            // OrderBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flp_order);
            this.Controls.Add(this.lb_shopName);
            this.Name = "OrderBlock";
            this.Size = new System.Drawing.Size(380, 200);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_shopName;
        private System.Windows.Forms.FlowLayoutPanel flp_order;
    }
}
