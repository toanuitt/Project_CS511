namespace Project_CS511.Component.Cart
{
    partial class foodBlockCart
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
            this.lb_foodName = new System.Windows.Forms.Label();
            this.lb_number = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_money = new System.Windows.Forms.Label();
            this.pb_foodPic = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_foodPic)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_foodName
            // 
            this.lb_foodName.AutoSize = true;
            this.lb_foodName.Font = new System.Drawing.Font("Bahnschrift SemiLight", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_foodName.Location = new System.Drawing.Point(109, 3);
            this.lb_foodName.MaximumSize = new System.Drawing.Size(180, 46);
            this.lb_foodName.Name = "lb_foodName";
            this.lb_foodName.Size = new System.Drawing.Size(92, 19);
            this.lb_foodName.TabIndex = 8;
            this.lb_foodName.Text = "Food Name";
            // 
            // lb_number
            // 
            this.lb_number.AutoSize = true;
            this.lb_number.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_number.Location = new System.Drawing.Point(65, 3);
            this.lb_number.MaximumSize = new System.Drawing.Size(200, 46);
            this.lb_number.Name = "lb_number";
            this.lb_number.Size = new System.Drawing.Size(14, 19);
            this.lb_number.TabIndex = 9;
            this.lb_number.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 3);
            this.label1.MaximumSize = new System.Drawing.Size(200, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 19);
            this.label1.TabIndex = 10;
            this.label1.Text = "X";
            // 
            // lb_money
            // 
            this.lb_money.AutoSize = true;
            this.lb_money.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_money.Location = new System.Drawing.Point(295, 17);
            this.lb_money.MaximumSize = new System.Drawing.Size(200, 46);
            this.lb_money.Name = "lb_money";
            this.lb_money.Size = new System.Drawing.Size(65, 19);
            this.lb_money.TabIndex = 11;
            this.lb_money.Text = "10.000D";
            // 
            // pb_foodPic
            // 
            this.pb_foodPic.Image = global::Project_CS511.Properties.Resources.marker;
            this.pb_foodPic.Location = new System.Drawing.Point(3, 3);
            this.pb_foodPic.Name = "pb_foodPic";
            this.pb_foodPic.Size = new System.Drawing.Size(56, 51);
            this.pb_foodPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_foodPic.TabIndex = 5;
            this.pb_foodPic.TabStop = false;
            // 
            // foodBlockCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_money);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lb_number);
            this.Controls.Add(this.lb_foodName);
            this.Controls.Add(this.pb_foodPic);
            this.Name = "foodBlockCart";
            this.Size = new System.Drawing.Size(370, 56);
            ((System.ComponentModel.ISupportInitialize)(this.pb_foodPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_foodPic;
        private System.Windows.Forms.Label lb_foodName;
        private System.Windows.Forms.Label lb_number;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_money;
    }
}
