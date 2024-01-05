namespace Project_CS511.Component
{
    partial class addLocation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addLocation));
            this.btn_addnew = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.btn_addnew)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_addnew
            // 
            this.btn_addnew.Image = ((System.Drawing.Image)(resources.GetObject("btn_addnew.Image")));
            this.btn_addnew.Location = new System.Drawing.Point(0, 0);
            this.btn_addnew.Name = "btn_addnew";
            this.btn_addnew.Size = new System.Drawing.Size(45, 37);
            this.btn_addnew.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btn_addnew.TabIndex = 0;
            this.btn_addnew.TabStop = false;
            this.btn_addnew.Click += new System.EventHandler(this.btn_addnew_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(53, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add new";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(-1, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(448, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "_______________________________________________________________";
            // 
            // addLocation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_addnew);
            this.Controls.Add(this.label2);
            this.Name = "addLocation";
            this.Size = new System.Drawing.Size(447, 60);
            ((System.ComponentModel.ISupportInitialize)(this.btn_addnew)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox btn_addnew;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}
