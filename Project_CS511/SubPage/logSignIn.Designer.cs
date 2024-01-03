namespace Project_CS511.SubPage
{
    partial class logSignIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(logSignIn));
            this.lb_name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_notification = new System.Windows.Forms.Label();
            this.lb_chat = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pb_notification = new System.Windows.Forms.PictureBox();
            this.pb_chat = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_notification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_chat)).BeginInit();
            this.SuspendLayout();
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_name.Font = new System.Drawing.Font("Candara", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.Location = new System.Drawing.Point(29, 27);
            this.lb_name.MaximumSize = new System.Drawing.Size(350, 66);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(346, 42);
            this.lb_name.TabIndex = 8;
            this.lb_name.Text = "Welcome to FoodApp";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 101);
            this.panel1.TabIndex = 9;
            // 
            // lb_notification
            // 
            this.lb_notification.AutoSize = true;
            this.lb_notification.BackColor = System.Drawing.Color.Transparent;
            this.lb_notification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_notification.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_notification.ForeColor = System.Drawing.Color.DarkGreen;
            this.lb_notification.Location = new System.Drawing.Point(231, 134);
            this.lb_notification.Name = "lb_notification";
            this.lb_notification.Size = new System.Drawing.Size(109, 33);
            this.lb_notification.TabIndex = 13;
            this.lb_notification.Text = "Sign Up";
            this.lb_notification.Click += new System.EventHandler(this.lb_notification_Click_1);
            // 
            // lb_chat
            // 
            this.lb_chat.AutoSize = true;
            this.lb_chat.BackColor = System.Drawing.Color.Transparent;
            this.lb_chat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_chat.Font = new System.Drawing.Font("Bahnschrift SemiBold", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_chat.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_chat.Location = new System.Drawing.Point(69, 134);
            this.lb_chat.Name = "lb_chat";
            this.lb_chat.Size = new System.Drawing.Size(89, 33);
            this.lb_chat.TabIndex = 12;
            this.lb_chat.Text = "Log In";
            this.lb_chat.Click += new System.EventHandler(this.lb_chat_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel2.Location = new System.Drawing.Point(0, 530);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(400, 70);
            this.panel2.TabIndex = 10;
            // 
            // pb_notification
            // 
            this.pb_notification.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_notification.Image = ((System.Drawing.Image)(resources.GetObject("pb_notification.Image")));
            this.pb_notification.Location = new System.Drawing.Point(197, 122);
            this.pb_notification.Name = "pb_notification";
            this.pb_notification.Size = new System.Drawing.Size(166, 57);
            this.pb_notification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_notification.TabIndex = 11;
            this.pb_notification.TabStop = false;
            this.pb_notification.Click += new System.EventHandler(this.lb_notification_Click_1);
            // 
            // pb_chat
            // 
            this.pb_chat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_chat.Image = ((System.Drawing.Image)(resources.GetObject("pb_chat.Image")));
            this.pb_chat.Location = new System.Drawing.Point(32, 122);
            this.pb_chat.Name = "pb_chat";
            this.pb_chat.Size = new System.Drawing.Size(166, 57);
            this.pb_chat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_chat.TabIndex = 10;
            this.pb_chat.TabStop = false;
            this.pb_chat.Click += new System.EventHandler(this.lb_chat_Click);
            // 
            // logSignIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.lb_notification);
            this.Controls.Add(this.lb_chat);
            this.Controls.Add(this.pb_notification);
            this.Controls.Add(this.pb_chat);
            this.Controls.Add(this.panel1);
            this.Name = "logSignIn";
            this.Size = new System.Drawing.Size(400, 600);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_notification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_chat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_notification;
        private System.Windows.Forms.Label lb_chat;
        private System.Windows.Forms.PictureBox pb_notification;
        private System.Windows.Forms.PictureBox pb_chat;
        private System.Windows.Forms.Panel panel2;
    }
}
