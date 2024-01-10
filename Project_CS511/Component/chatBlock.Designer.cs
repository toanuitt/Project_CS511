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
            this.lb_time = new System.Windows.Forms.Label();
            this.lb_chat = new System.Windows.Forms.Label();
            this.lb_messageType = new System.Windows.Forms.Label();
            this.pb_trash = new System.Windows.Forms.PictureBox();
            this.pb_avatar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_trash)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_time
            // 
            this.lb_time.AutoSize = true;
            this.lb_time.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_time.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_time.Location = new System.Drawing.Point(78, 67);
            this.lb_time.MaximumSize = new System.Drawing.Size(165, 17);
            this.lb_time.Name = "lb_time";
            this.lb_time.Size = new System.Drawing.Size(41, 17);
            this.lb_time.TabIndex = 10;
            this.lb_time.Text = "11:02";
            this.lb_time.MouseEnter += new System.EventHandler(this.pb_avatar_MouseEnter);
            this.lb_time.MouseLeave += new System.EventHandler(this.lb_time_MouseLeave);
            // 
            // lb_chat
            // 
            this.lb_chat.AutoSize = true;
            this.lb_chat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_chat.Font = new System.Drawing.Font("Bahnschrift SemiLight SemiConde", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chat.Location = new System.Drawing.Point(80, 28);
            this.lb_chat.MaximumSize = new System.Drawing.Size(300, 40);
            this.lb_chat.Name = "lb_chat";
            this.lb_chat.Size = new System.Drawing.Size(277, 36);
            this.lb_chat.TabIndex = 11;
            this.lb_chat.Text = "Some part ______________________of new chat here";
            this.lb_chat.MouseEnter += new System.EventHandler(this.pb_avatar_MouseEnter);
            this.lb_chat.MouseLeave += new System.EventHandler(this.lb_time_MouseLeave);
            // 
            // lb_messageType
            // 
            this.lb_messageType.AutoSize = true;
            this.lb_messageType.Font = new System.Drawing.Font("Bahnschrift SemiCondensed", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_messageType.Location = new System.Drawing.Point(80, 2);
            this.lb_messageType.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_messageType.Name = "lb_messageType";
            this.lb_messageType.Size = new System.Drawing.Size(137, 23);
            this.lb_messageType.TabIndex = 12;
            this.lb_messageType.Text = "Giao dịch gần đây";
            this.lb_messageType.MouseEnter += new System.EventHandler(this.pb_avatar_MouseEnter);
            this.lb_messageType.MouseLeave += new System.EventHandler(this.lb_time_MouseLeave);
            // 
            // pb_trash
            // 
            this.pb_trash.Image = global::Project_CS511.Properties.Resources.trash;
            this.pb_trash.Location = new System.Drawing.Point(355, 58);
            this.pb_trash.Name = "pb_trash";
            this.pb_trash.Size = new System.Drawing.Size(26, 31);
            this.pb_trash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_trash.TabIndex = 13;
            this.pb_trash.TabStop = false;
            this.pb_trash.Click += new System.EventHandler(this.pb_trash_Click);
            this.pb_trash.MouseEnter += new System.EventHandler(this.pb_avatar_MouseEnter);
            this.pb_trash.MouseLeave += new System.EventHandler(this.lb_time_MouseLeave);
            // 
            // pb_avatar
            // 
            this.pb_avatar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_avatar.Image = ((System.Drawing.Image)(resources.GetObject("pb_avatar.Image")));
            this.pb_avatar.Location = new System.Drawing.Point(8, 7);
            this.pb_avatar.Name = "pb_avatar";
            this.pb_avatar.Size = new System.Drawing.Size(66, 59);
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
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.pb_trash);
            this.Controls.Add(this.lb_messageType);
            this.Controls.Add(this.lb_chat);
            this.Controls.Add(this.lb_time);
            this.Controls.Add(this.pb_avatar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "chatBlock";
            this.Size = new System.Drawing.Size(392, 89);
            this.MouseEnter += new System.EventHandler(this.pb_avatar_MouseEnter);
            this.MouseLeave += new System.EventHandler(this.lb_time_MouseLeave);
            ((System.ComponentModel.ISupportInitialize)(this.pb_trash)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pb_avatar;
        private System.Windows.Forms.Label lb_time;
        private System.Windows.Forms.Label lb_chat;
        private System.Windows.Forms.Label lb_messageType;
        private System.Windows.Forms.PictureBox pb_trash;
    }
}
