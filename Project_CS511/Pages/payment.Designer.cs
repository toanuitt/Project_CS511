namespace Project_CS511.Pages
{
    partial class payment
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
            this.addcard1 = new Project_CS511.Component.addcard();
            this.paymentlist1 = new Project_CS511.Component.paymentlist();
            this.paymentadvice1 = new Project_CS511.Component.paymentadvice();
            this.historypayment1 = new Project_CS511.Component.historypayment();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Controls.Add(this.addcard1);
            this.flowLayoutPanel1.Controls.Add(this.paymentlist1);
            this.flowLayoutPanel1.Controls.Add(this.paymentadvice1);
            this.flowLayoutPanel1.Controls.Add(this.historypayment1);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(533, 648);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // addcard1
            // 
            this.addcard1.Location = new System.Drawing.Point(3, 3);
            this.addcard1.Name = "addcard1";
            this.addcard1.Size = new System.Drawing.Size(527, 328);
            this.addcard1.TabIndex = 0;
            // 
            // paymentlist1
            // 
            this.paymentlist1.Location = new System.Drawing.Point(3, 337);
            this.paymentlist1.Name = "paymentlist1";
            this.paymentlist1.Size = new System.Drawing.Size(527, 178);
            this.paymentlist1.TabIndex = 1;
            // 
            // paymentadvice1
            // 
            this.paymentadvice1.Location = new System.Drawing.Point(3, 521);
            this.paymentadvice1.Name = "paymentadvice1";
            this.paymentadvice1.Size = new System.Drawing.Size(535, 185);
            this.paymentadvice1.TabIndex = 2;
            // 
            // historypayment1
            // 
            this.historypayment1.Location = new System.Drawing.Point(3, 712);
            this.historypayment1.Name = "historypayment1";
            this.historypayment1.Size = new System.Drawing.Size(527, 231);
            this.historypayment1.TabIndex = 3;
            // 
            // payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "payment";
            this.Size = new System.Drawing.Size(533, 648);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private Component.addcard addcard1;
        private Component.paymentlist paymentlist1;
        private Component.paymentadvice paymentadvice1;
        private Component.historypayment historypayment1;
    }
}
