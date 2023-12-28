namespace Project_CS511.Component
{
    partial class foodSlide
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
            this.label2 = new System.Windows.Forms.Label();
            this.foodBlock3 = new Project_CS511.Component.foodBlock();
            this.foodBlock1 = new Project_CS511.Component.foodBlock();
            this.foodBlock4 = new Project_CS511.Component.foodBlock();
            this.foodBlock2 = new Project_CS511.Component.foodBlock();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.flowLayoutPanel1.Controls.Add(this.foodBlock3);
            this.flowLayoutPanel1.Controls.Add(this.foodBlock1);
            this.flowLayoutPanel1.Controls.Add(this.foodBlock4);
            this.flowLayoutPanel1.Controls.Add(this.foodBlock2);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(420, 250);
            this.flowLayoutPanel1.TabIndex = 0;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(143, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Food For You ➜";
            // 
            // foodBlock3
            // 
            this.foodBlock3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foodBlock3.Location = new System.Drawing.Point(3, 3);
            this.foodBlock3.Name = "foodBlock3";
            this.foodBlock3.Size = new System.Drawing.Size(166, 211);
            this.foodBlock3.TabIndex = 5;
            // 
            // foodBlock1
            // 
            this.foodBlock1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foodBlock1.Location = new System.Drawing.Point(175, 3);
            this.foodBlock1.Name = "foodBlock1";
            this.foodBlock1.Size = new System.Drawing.Size(166, 211);
            this.foodBlock1.TabIndex = 0;
            // 
            // foodBlock4
            // 
            this.foodBlock4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foodBlock4.Location = new System.Drawing.Point(347, 3);
            this.foodBlock4.Name = "foodBlock4";
            this.foodBlock4.Size = new System.Drawing.Size(166, 211);
            this.foodBlock4.TabIndex = 3;
            // 
            // foodBlock2
            // 
            this.foodBlock2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foodBlock2.Location = new System.Drawing.Point(519, 3);
            this.foodBlock2.Name = "foodBlock2";
            this.foodBlock2.Size = new System.Drawing.Size(166, 211);
            this.foodBlock2.TabIndex = 4;
            // 
            // foodSlide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.label2);
            this.Name = "foodSlide";
            this.Size = new System.Drawing.Size(400, 268);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private foodBlock foodBlock1;
        private foodBlock foodBlock4;
        private foodBlock foodBlock3;
        private foodBlock foodBlock2;
        private System.Windows.Forms.Label label2;
    }
}
