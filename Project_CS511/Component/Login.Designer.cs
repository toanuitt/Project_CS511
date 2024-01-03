namespace Project_CS511.Component
{
    partial class Login
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lb_forgetPassword = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.lb_exit = new System.Windows.Forms.Label();
            this.lb_error = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 33);
            this.label1.TabIndex = 2;
            this.label1.Text = "Tên Tài Khoản";
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(17, 62);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(319, 36);
            this.tb_username.TabIndex = 3;
            this.tb_username.Text = "trasua";
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Bahnschrift", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(17, 148);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '*';
            this.tb_password.Size = new System.Drawing.Size(319, 36);
            this.tb_password.TabIndex = 5;
            this.tb_password.Text = "taca";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(127, 33);
            this.label2.TabIndex = 4;
            this.label2.Text = "Mật Khẩu";
            // 
            // lb_forgetPassword
            // 
            this.lb_forgetPassword.AutoSize = true;
            this.lb_forgetPassword.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_forgetPassword.Location = new System.Drawing.Point(13, 187);
            this.lb_forgetPassword.Name = "lb_forgetPassword";
            this.lb_forgetPassword.Size = new System.Drawing.Size(146, 23);
            this.lb_forgetPassword.TabIndex = 6;
            this.lb_forgetPassword.Text = "Quên mật khẩu?";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkOliveGreen;
            this.button1.Font = new System.Drawing.Font("Bahnschrift", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(88, 223);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(208, 71);
            this.button1.TabIndex = 7;
            this.button1.Text = "Đăng Nhập";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lb_exit
            // 
            this.lb_exit.AutoSize = true;
            this.lb_exit.Font = new System.Drawing.Font("Bahnschrift", 14.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_exit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lb_exit.Location = new System.Drawing.Point(322, 293);
            this.lb_exit.Name = "lb_exit";
            this.lb_exit.Size = new System.Drawing.Size(56, 23);
            this.lb_exit.TabIndex = 8;
            this.lb_exit.Text = "Thoát";
            this.lb_exit.Click += new System.EventHandler(this.lb_exit_Click);
            // 
            // lb_error
            // 
            this.lb_error.AutoSize = true;
            this.lb_error.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_error.ForeColor = System.Drawing.Color.DarkRed;
            this.lb_error.Location = new System.Drawing.Point(13, 297);
            this.lb_error.Name = "lb_error";
            this.lb_error.Size = new System.Drawing.Size(0, 19);
            this.lb_error.TabIndex = 9;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.Controls.Add(this.lb_error);
            this.Controls.Add(this.lb_exit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lb_forgetPassword);
            this.Controls.Add(this.tb_password);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_username);
            this.Controls.Add(this.label1);
            this.Location = new System.Drawing.Point(0, 200);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(400, 330);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lb_forgetPassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lb_exit;
        private System.Windows.Forms.Label lb_error;
    }
}
