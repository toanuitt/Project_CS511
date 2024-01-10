namespace Project_CS511.Pages
{
    partial class message
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(message));
            this.label1 = new System.Windows.Forms.Label();
            this.lb_chat = new System.Windows.Forms.Label();
            this.lb_notification = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pb_notification = new System.Windows.Forms.PictureBox();
            this.pb_chat = new System.Windows.Forms.PictureBox();
            this.pb_trash = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pb_notification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_chat)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_trash)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(161, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "Messages";
            // 
            // lb_chat
            // 
            this.lb_chat.AutoSize = true;
            this.lb_chat.BackColor = System.Drawing.Color.Transparent;
            this.lb_chat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_chat.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_chat.Location = new System.Drawing.Point(18, 71);
            this.lb_chat.Name = "lb_chat";
            this.lb_chat.Size = new System.Drawing.Size(124, 23);
            this.lb_chat.TabIndex = 7;
            this.lb_chat.Text = "All Messages";
            this.lb_chat.Click += new System.EventHandler(this.lb_food_Click);
            // 
            // lb_notification
            // 
            this.lb_notification.AutoSize = true;
            this.lb_notification.BackColor = System.Drawing.Color.Transparent;
            this.lb_notification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_notification.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_notification.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_notification.Location = new System.Drawing.Point(190, 71);
            this.lb_notification.Name = "lb_notification";
            this.lb_notification.Size = new System.Drawing.Size(48, 23);
            this.lb_notification.TabIndex = 8;
            this.lb_notification.Text = "New";
            this.lb_notification.Click += new System.EventHandler(this.lb_notification_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 110);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(412, 424);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // pb_notification
            // 
            this.pb_notification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_notification.Image = ((System.Drawing.Image)(resources.GetObject("pb_notification.Image")));
            this.pb_notification.Location = new System.Drawing.Point(147, 62);
            this.pb_notification.Name = "pb_notification";
            this.pb_notification.Size = new System.Drawing.Size(140, 42);
            this.pb_notification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_notification.TabIndex = 6;
            this.pb_notification.TabStop = false;
            this.pb_notification.Click += new System.EventHandler(this.lb_notification_Click);
            // 
            // pb_chat
            // 
            this.pb_chat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_chat.Image = ((System.Drawing.Image)(resources.GetObject("pb_chat.Image")));
            this.pb_chat.Location = new System.Drawing.Point(10, 62);
            this.pb_chat.Name = "pb_chat";
            this.pb_chat.Size = new System.Drawing.Size(140, 42);
            this.pb_chat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_chat.TabIndex = 5;
            this.pb_chat.TabStop = false;
            this.pb_chat.Click += new System.EventHandler(this.lb_food_Click);
            // 
            // pb_trash
            // 
            this.pb_trash.Image = global::Project_CS511.Properties.Resources.trash;
            this.pb_trash.Location = new System.Drawing.Point(356, 18);
            this.pb_trash.Name = "pb_trash";
            this.pb_trash.Size = new System.Drawing.Size(23, 30);
            this.pb_trash.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_trash.TabIndex = 4;
            this.pb_trash.TabStop = false;
            this.pb_trash.Click += new System.EventHandler(this.pb_trash_Click);
            // 
            // message
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.lb_notification);
            this.Controls.Add(this.lb_chat);
            this.Controls.Add(this.pb_notification);
            this.Controls.Add(this.pb_chat);
            this.Controls.Add(this.pb_trash);
            this.Controls.Add(this.label1);
            this.Name = "message";
            this.Size = new System.Drawing.Size(400, 520);
            ((System.ComponentModel.ISupportInitialize)(this.pb_notification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_chat)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_trash)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_trash;
        private System.Windows.Forms.PictureBox pb_chat;
        private System.Windows.Forms.PictureBox pb_notification;
        private System.Windows.Forms.Label lb_chat;
        private System.Windows.Forms.Label lb_notification;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
    }
}
