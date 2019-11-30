namespace WindowsFormsApplication1
{
    partial class frm_PasswordChange
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_PasswordChange));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ConfirmPassword = new System.Windows.Forms.Button();
            this.txb_OldPassword = new System.Windows.Forms.TextBox();
            this.txb_NewPassword = new System.Windows.Forms.TextBox();
            this.txb_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(12, 91);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(12, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(12, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại password mới";
            // 
            // btn_ConfirmPassword
            // 
            this.btn_ConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ConfirmPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ConfirmPassword.Location = new System.Drawing.Point(210, 188);
            this.btn_ConfirmPassword.Name = "btn_ConfirmPassword";
            this.btn_ConfirmPassword.Size = new System.Drawing.Size(75, 36);
            this.btn_ConfirmPassword.TabIndex = 3;
            this.btn_ConfirmPassword.Text = "Lưu";
            this.btn_ConfirmPassword.UseVisualStyleBackColor = false;
            this.btn_ConfirmPassword.Click += new System.EventHandler(this.btn_ConfirmPassword_Click);
            // 
            // txb_OldPassword
            // 
            this.txb_OldPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_OldPassword.Location = new System.Drawing.Point(250, 91);
            this.txb_OldPassword.Name = "txb_OldPassword";
            this.txb_OldPassword.Size = new System.Drawing.Size(226, 22);
            this.txb_OldPassword.TabIndex = 4;
            this.txb_OldPassword.UseSystemPasswordChar = true;
            // 
            // txb_NewPassword
            // 
            this.txb_NewPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_NewPassword.Location = new System.Drawing.Point(250, 119);
            this.txb_NewPassword.Name = "txb_NewPassword";
            this.txb_NewPassword.Size = new System.Drawing.Size(226, 22);
            this.txb_NewPassword.TabIndex = 5;
            this.txb_NewPassword.UseSystemPasswordChar = true;
            // 
            // txb_ConfirmPassword
            // 
            this.txb_ConfirmPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_ConfirmPassword.Location = new System.Drawing.Point(250, 148);
            this.txb_ConfirmPassword.Name = "txb_ConfirmPassword";
            this.txb_ConfirmPassword.Size = new System.Drawing.Size(226, 22);
            this.txb_ConfirmPassword.TabIndex = 6;
            this.txb_ConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(-2, -1);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 25);
            this.label4.TabIndex = 7;
            this.label4.Text = "Đổi mật khẩu";
            // 
            // frm_PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(520, 257);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_ConfirmPassword);
            this.Controls.Add(this.txb_NewPassword);
            this.Controls.Add(this.txb_OldPassword);
            this.Controls.Add(this.btn_ConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_PasswordChange";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_PasswordChange";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_ConfirmPassword;
        private System.Windows.Forms.TextBox txb_OldPassword;
        private System.Windows.Forms.TextBox txb_NewPassword;
        private System.Windows.Forms.TextBox txb_ConfirmPassword;
        private System.Windows.Forms.Label label4;
    }
}