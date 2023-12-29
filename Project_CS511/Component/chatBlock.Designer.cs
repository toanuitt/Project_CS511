namespace Project_CS511.Component
{
    partial class chatBlock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(chatBlock));
            this.lb_name = new System.Windows.Forms.Label();
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_chat = new System.Windows.Forms.Label();
            this.pb_avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_name.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(81, 7);
            this.lb_name.MaximumSize = new System.Drawing.Size(165, 17);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(137, 17);
            this.lb_name.TabIndex = 9;
            this.lb_name.Text = "Tiệm Cà Phê Muối";
            this.lb_name.MouseEnter += new System.EventHandler(this.pb_avatar_MouseEnter);
            this.lb_name.MouseLeave += new System.EventHandler(this.lb_time_MouseLeave);
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_time.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Location = new System.Drawing.Point(306, 7);
            this.lb_time.MaximumSize = new System.Drawing.Size(165, 17);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(43, 17);
            this.lb_time.TabIndex = 10;
            this.lb_time.Text = "11:02";
            this.lb_time.MouseEnter += new System.EventHandler(this.pb_avatar_MouseEnter);
            this.lb_time.MouseLeave += new System.EventHandler(this.lb_time_MouseLeave);
            // 
            // lb_chat
            // 
            this.lb_chat.AutoSize = true;
            this.lb_chat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_chat.Font = new System.Drawing.Font("Bahnschrift", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chat.Location = new System.Drawing.Point(81, 38);
            this.lb_chat.MaximumSize = new System.Drawing.Size(165, 17);
            this.lb_chat.Name = "lb_chat";
            this.lb_chat.Size = new System.Drawing.Size(162, 17);
            this.lb_chat.TabIndex = 11;
            this.lb_chat.Text = "Some part of new chat here";
            this.lb_chat.MouseEnter += new System.EventHandler(this.pb_avatar_MouseEnter);
            // 
            // pb_avatar
            // 
            this.pb_avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_avatar.Image = ((System.Drawing.Image)(resources.GetObject("pb_avatar.Image")));
            this.pb_avatar.Location = new System.Drawing.Point(8, 7);
            this.pb_avatar.Name = "pb_avatar";
            this.pb_avatar.Size = new System.Drawing.Size(67, 57);
            this.pb_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_avatar.TabIndex = 0;
            this.pb_avatar.TabStop = false;
            this.pb_avatar.MouseEnter += new System.EventHandler(this.pb_avatar_MouseEnter);
            this.pb_avatar.MouseLeave += new System.EventHandler(this.lb_time_MouseLeave);
            // 
            // chatBlock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_chat);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.lb_name);
            this.Controls.Add(this.pb_avatar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "chatBlock";
            this.Size = new System.Drawing.Size(400, 75);
            this.MouseEnter += new System.EventHandler(this.pb_avatar_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.lb_time_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_avatar;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_chat;
    }
}
