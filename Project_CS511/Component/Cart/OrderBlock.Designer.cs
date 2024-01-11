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
            this.label1 = new System.Windows.Forms.Label();
            this.lb_shipping = new System.Windows.Forms.Label();
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
            this.flp_order.AutoScroll = true;
            this.flp_order.Location = new System.Drawing.Point(2, 40);
            this.flp_order.Name = "flp_order";
            this.flp_order.Size = new System.Drawing.Size(388, 159);
            this.flp_order.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiLight Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(228, 12);
            this.label1.MaximumSize = new System.Drawing.Size(316, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Shipping Fee:";
            // 
            // lb_shipping
            // 
            this.lb_shipping.AutoSize = true;
            this.lb_shipping.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_shipping.Location = new System.Drawing.Point(304, 13);
            this.lb_shipping.Name = "lb_shipping";
            this.lb_shipping.Size = new System.Drawing.Size(55, 19);
            this.lb_shipping.TabIndex = 10;
            this.lb_shipping.Text = "1000000";
            // 
            // OrderBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.Controls.Add(this.lb_shipping);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_shipping;
    }
}
