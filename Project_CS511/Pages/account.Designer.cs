namespace Project_CS511.Pages
{
    partial class account
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(account));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lb_name = new System.Windows.Forms.Label();
            this.pn_changeUsername = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lb_updateInfo = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_yourLocation = new System.Windows.Forms.Label();
            this.pn_changePassword = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.lb_favourites = new System.Windows.Forms.Label();
            this.pn_favourites = new System.Windows.Forms.Panel();
            this.pn_savedPlaces = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.lb_savedPlaces = new System.Windows.Forms.Label();
            this.pn_payment = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.lb_store = new System.Windows.Forms.Label();
            this.lb_logOut = new System.Windows.Forms.Label();
            this.pb_logOut = new System.Windows.Forms.PictureBox();
            this.pb_edit = new System.Windows.Forms.PictureBox();
            this.pb_avatar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.pn_changeUsername.SuspendLayout();
            this.pn_changePassword.SuspendLayout();
            this.pn_favourites.SuspendLayout();
            this.pn_savedPlaces.SuspendLayout();
            this.pn_payment.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_edit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkGreen;
            this.panel1.Controls.Add(this.pb_edit);
            this.panel1.Controls.Add(this.pb_avatar);
            this.panel1.Controls.Add(this.lb_name);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(400, 128);
            this.panel1.TabIndex = 0;
            // 
            // lb_name
            // 
            this.lb_name.AutoSize = true;
            this.lb_name.BackColor = System.Drawing.Color.Transparent;
            this.lb_name.Font = new System.Drawing.Font("Bahnschrift SemiBold", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_name.ForeColor = System.Drawing.SystemColors.Control;
            this.lb_name.Location = new System.Drawing.Point(13, 36);
            this.lb_name.Name = "lb_name";
            this.lb_name.Size = new System.Drawing.Size(108, 39);
            this.lb_name.TabIndex = 4;
            this.lb_name.Text = "Admin";
            // 
            // pn_changeUsername
            // 
            this.pn_changeUsername.Controls.Add(this.label1);
            this.pn_changeUsername.Controls.Add(this.lb_updateInfo);
            this.pn_changeUsername.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_changeUsername.Location = new System.Drawing.Point(2, 143);
            this.pn_changeUsername.Name = "pn_changeUsername";
            this.pn_changeUsername.Size = new System.Drawing.Size(398, 58);
            this.pn_changeUsername.TabIndex = 1;
            this.pn_changeUsername.Click += new System.EventHandler(this.lb_updateInfo_Click);
            this.pn_changeUsername.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_changeUsername_Paint);
            this.pn_changeUsername.MouseEnter += new System.EventHandler(this.lb_changeUsername_MouseEnter);
            this.pn_changeUsername.MouseLeave += new System.EventHandler(this.pn_changeUsername_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label1.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(355, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = ">";
            this.label1.Click += new System.EventHandler(this.lb_updateInfo_Click);
            this.label1.MouseEnter += new System.EventHandler(this.lb_changeUsername_MouseEnter);
            // 
            // lb_updateInfo
            // 
            this.lb_updateInfo.AutoSize = true;
            this.lb_updateInfo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_updateInfo.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_updateInfo.Location = new System.Drawing.Point(14, 16);
            this.lb_updateInfo.Name = "lb_updateInfo";
            this.lb_updateInfo.Size = new System.Drawing.Size(178, 22);
            this.lb_updateInfo.TabIndex = 8;
            this.lb_updateInfo.Text = "Update Infomation";
            this.lb_updateInfo.Click += new System.EventHandler(this.lb_updateInfo_Click);
            this.lb_updateInfo.MouseEnter += new System.EventHandler(this.lb_changeUsername_MouseEnter);
            this.lb_updateInfo.MouseLeave += new System.EventHandler(this.pn_changeUsername_MouseLeave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label2.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(355, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 31);
            this.label2.TabIndex = 9;
            this.label2.Text = ">";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            this.label2.MouseEnter += new System.EventHandler(this.lb_changePassword_MouseEnter);
            // 
            // lb_yourLocation
            // 
            this.lb_yourLocation.AutoSize = true;
            this.lb_yourLocation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_yourLocation.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_yourLocation.Location = new System.Drawing.Point(14, 16);
            this.lb_yourLocation.Name = "lb_yourLocation";
            this.lb_yourLocation.Size = new System.Drawing.Size(140, 22);
            this.lb_yourLocation.TabIndex = 8;
            this.lb_yourLocation.Text = "Your Location";
            this.lb_yourLocation.Click += new System.EventHandler(this.lb_yourLocation_Click);
            this.lb_yourLocation.MouseEnter += new System.EventHandler(this.lb_changePassword_MouseEnter);
            this.lb_yourLocation.MouseLeave += new System.EventHandler(this.pn_changePassword_MouseLeave);
            // 
            // pn_changePassword
            // 
            this.pn_changePassword.Controls.Add(this.label2);
            this.pn_changePassword.Controls.Add(this.lb_yourLocation);
            this.pn_changePassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_changePassword.Location = new System.Drawing.Point(3, 200);
            this.pn_changePassword.Name = "pn_changePassword";
            this.pn_changePassword.Size = new System.Drawing.Size(397, 58);
            this.pn_changePassword.TabIndex = 10;
            this.pn_changePassword.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_changePassword_Paint);
            this.pn_changePassword.MouseEnter += new System.EventHandler(this.lb_changePassword_MouseEnter);
            this.pn_changePassword.MouseLeave += new System.EventHandler(this.pn_changePassword_MouseLeave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(355, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(28, 31);
            this.label3.TabIndex = 9;
            this.label3.Text = ">";
            this.label3.Click += new System.EventHandler(this.lb_favourites_Click);
            this.label3.MouseEnter += new System.EventHandler(this.lb_favourites_MouseEnter);
            // 
            // lb_favourites
            // 
            this.lb_favourites.AutoSize = true;
            this.lb_favourites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_favourites.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_favourites.Location = new System.Drawing.Point(14, 16);
            this.lb_favourites.Name = "lb_favourites";
            this.lb_favourites.Size = new System.Drawing.Size(109, 22);
            this.lb_favourites.TabIndex = 8;
            this.lb_favourites.Text = "Favourites";
            this.lb_favourites.Click += new System.EventHandler(this.lb_favourites_Click);
            this.lb_favourites.MouseEnter += new System.EventHandler(this.lb_favourites_MouseEnter);
            this.lb_favourites.MouseLeave += new System.EventHandler(this.pn_favourites_MouseLeave);
            // 
            // pn_favourites
            // 
            this.pn_favourites.Controls.Add(this.label3);
            this.pn_favourites.Controls.Add(this.lb_favourites);
            this.pn_favourites.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_favourites.Location = new System.Drawing.Point(3, 371);
            this.pn_favourites.Name = "pn_favourites";
            this.pn_favourites.Size = new System.Drawing.Size(397, 58);
            this.pn_favourites.TabIndex = 10;
            this.pn_favourites.Click += new System.EventHandler(this.lb_favourites_Click);
            this.pn_favourites.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_favourites_Paint);
            this.pn_favourites.MouseEnter += new System.EventHandler(this.lb_favourites_MouseEnter);
            this.pn_favourites.MouseLeave += new System.EventHandler(this.pn_favourites_MouseLeave);
            // 
            // pn_savedPlaces
            // 
            this.pn_savedPlaces.Controls.Add(this.label4);
            this.pn_savedPlaces.Controls.Add(this.lb_savedPlaces);
            this.pn_savedPlaces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_savedPlaces.Location = new System.Drawing.Point(3, 314);
            this.pn_savedPlaces.Name = "pn_savedPlaces";
            this.pn_savedPlaces.Size = new System.Drawing.Size(397, 58);
            this.pn_savedPlaces.TabIndex = 10;
            this.pn_savedPlaces.Click += new System.EventHandler(this.lb_savedPlaces_Click);
            this.pn_savedPlaces.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_savedPlaces_Paint);
            this.pn_savedPlaces.MouseEnter += new System.EventHandler(this.lb_savedPlaces_MouseEnter);
            this.pn_savedPlaces.MouseLeave += new System.EventHandler(this.pn_savedPlaces_MouseLeave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label4.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(355, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(28, 31);
            this.label4.TabIndex = 9;
            this.label4.Text = ">";
            this.label4.MouseEnter += new System.EventHandler(this.lb_savedPlaces_MouseEnter);
            // 
            // lb_savedPlaces
            // 
            this.lb_savedPlaces.AutoSize = true;
            this.lb_savedPlaces.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_savedPlaces.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_savedPlaces.Location = new System.Drawing.Point(14, 15);
            this.lb_savedPlaces.Name = "lb_savedPlaces";
            this.lb_savedPlaces.Size = new System.Drawing.Size(123, 22);
            this.lb_savedPlaces.TabIndex = 8;
            this.lb_savedPlaces.Text = "Your Basket";
            this.lb_savedPlaces.Click += new System.EventHandler(this.lb_savedPlaces_Click);
            this.lb_savedPlaces.MouseEnter += new System.EventHandler(this.lb_savedPlaces_MouseEnter);
            this.lb_savedPlaces.MouseLeave += new System.EventHandler(this.pn_savedPlaces_MouseLeave);
            // 
            // pn_payment
            // 
            this.pn_payment.Controls.Add(this.label5);
            this.pn_payment.Controls.Add(this.lb_store);
            this.pn_payment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pn_payment.Location = new System.Drawing.Point(3, 257);
            this.pn_payment.Name = "pn_payment";
            this.pn_payment.Size = new System.Drawing.Size(397, 58);
            this.pn_payment.TabIndex = 11;
            this.pn_payment.Click += new System.EventHandler(this.lb_store_Click);
            this.pn_payment.Paint += new System.Windows.Forms.PaintEventHandler(this.pn_payment_Paint);
            this.pn_payment.MouseEnter += new System.EventHandler(this.lb_payment_MouseEnter);
            this.pn_payment.MouseLeave += new System.EventHandler(this.pn_payment_MouseLeave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Baskerville Old Face", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(355, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(28, 31);
            this.label5.TabIndex = 9;
            this.label5.Text = ">";
            this.label5.Click += new System.EventHandler(this.lb_store_Click);
            this.label5.MouseEnter += new System.EventHandler(this.lb_payment_MouseEnter);
            // 
            // lb_store
            // 
            this.lb_store.AutoSize = true;
            this.lb_store.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_store.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_store.Location = new System.Drawing.Point(14, 16);
            this.lb_store.Name = "lb_store";
            this.lb_store.Size = new System.Drawing.Size(109, 22);
            this.lb_store.TabIndex = 8;
            this.lb_store.Text = "Your Store";
            this.lb_store.Click += new System.EventHandler(this.lb_store_Click);
            this.lb_store.MouseEnter += new System.EventHandler(this.lb_payment_MouseEnter);
            this.lb_store.MouseLeave += new System.EventHandler(this.pn_payment_MouseLeave);
            // 
            // lb_logOut
            // 
            this.lb_logOut.AutoSize = true;
            this.lb_logOut.BackColor = System.Drawing.Color.Transparent;
            this.lb_logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lb_logOut.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_logOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lb_logOut.Location = new System.Drawing.Point(149, 456);
            this.lb_logOut.Name = "lb_logOut";
            this.lb_logOut.Size = new System.Drawing.Size(108, 33);
            this.lb_logOut.TabIndex = 11;
            this.lb_logOut.Text = "Log Out";
            this.lb_logOut.Click += new System.EventHandler(this.lb_logOut_Click);
            // 
            // pb_logOut
            // 
            this.pb_logOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_logOut.Image = ((System.Drawing.Image)(resources.GetObject("pb_logOut.Image")));
            this.pb_logOut.Location = new System.Drawing.Point(93, 441);
            this.pb_logOut.Name = "pb_logOut";
            this.pb_logOut.Size = new System.Drawing.Size(221, 68);
            this.pb_logOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_logOut.TabIndex = 10;
            this.pb_logOut.TabStop = false;
            this.pb_logOut.Click += new System.EventHandler(this.lb_logOut_Click);
            // 
            // pb_edit
            // 
            this.pb_edit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pb_edit.Image = global::Project_CS511.Properties.Resources.white_pen;
            this.pb_edit.Location = new System.Drawing.Point(344, 69);
            this.pb_edit.Name = "pb_edit";
            this.pb_edit.Size = new System.Drawing.Size(30, 28);
            this.pb_edit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_edit.TabIndex = 6;
            this.pb_edit.TabStop = false;
            this.pb_edit.Click += new System.EventHandler(this.pb_edit_Click);
            // 
            // pb_avatar
            // 
            this.pb_avatar.Image = global::Project_CS511.Properties.Resources.customer_active;
            this.pb_avatar.Location = new System.Drawing.Point(264, 19);
            this.pb_avatar.Name = "pb_avatar";
            this.pb_avatar.Size = new System.Drawing.Size(82, 78);
            this.pb_avatar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_avatar.TabIndex = 5;
            this.pb_avatar.TabStop = false;
            this.pb_avatar.Click += new System.EventHandler(this.pb_avatar_Click);
            // 
            // account
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lb_logOut);
            this.Controls.Add(this.pb_logOut);
            this.Controls.Add(this.pn_payment);
            this.Controls.Add(this.pn_savedPlaces);
            this.Controls.Add(this.pn_favourites);
            this.Controls.Add(this.pn_changePassword);
            this.Controls.Add(this.pn_changeUsername);
            this.Controls.Add(this.panel1);
            this.Name = "account";
            this.Size = new System.Drawing.Size(400, 520);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pn_changeUsername.ResumeLayout(false);
            this.pn_changeUsername.PerformLayout();
            this.pn_changePassword.ResumeLayout(false);
            this.pn_changePassword.PerformLayout();
            this.pn_favourites.ResumeLayout(false);
            this.pn_favourites.PerformLayout();
            this.pn_savedPlaces.ResumeLayout(false);
            this.pn_savedPlaces.PerformLayout();
            this.pn_payment.ResumeLayout(false);
            this.pn_payment.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_edit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_avatar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lb_name;
        private System.Windows.Forms.PictureBox pb_avatar;
        private System.Windows.Forms.PictureBox pb_edit;
        private System.Windows.Forms.Panel pn_changeUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lb_updateInfo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_yourLocation;
        private System.Windows.Forms.Panel pn_changePassword;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lb_favourites;
        private System.Windows.Forms.Panel pn_favourites;
        private System.Windows.Forms.Panel pn_savedPlaces;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lb_savedPlaces;
        private System.Windows.Forms.Panel pn_payment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lb_store;
        private System.Windows.Forms.Label lb_logOut;
        private System.Windows.Forms.PictureBox pb_logOut;
    }
}
