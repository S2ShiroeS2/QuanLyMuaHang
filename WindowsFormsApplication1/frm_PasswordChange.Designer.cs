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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_ConfirmPassword = new System.Windows.Forms.Button();
            this.txb_OldPassword = new System.Windows.Forms.TextBox();
            this.txb_ConfirmPassword = new System.Windows.Forms.TextBox();
            this.txb_NewPassword = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password cũ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.Location = new System.Drawing.Point(44, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password mới";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.Location = new System.Drawing.Point(24, 109);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Nhập lại password mới";
            // 
            // btn_ConfirmPassword
            // 
            this.btn_ConfirmPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ConfirmPassword.Location = new System.Drawing.Point(211, 150);
            this.btn_ConfirmPassword.Name = "btn_ConfirmPassword";
            this.btn_ConfirmPassword.Size = new System.Drawing.Size(75, 36);
            this.btn_ConfirmPassword.TabIndex = 3;
            this.btn_ConfirmPassword.Text = "Lưu";
            this.btn_ConfirmPassword.UseVisualStyleBackColor = true;
            // 
            // txb_OldPassword
            // 
            this.txb_OldPassword.Location = new System.Drawing.Point(260, 34);
            this.txb_OldPassword.Name = "txb_OldPassword";
            this.txb_OldPassword.Size = new System.Drawing.Size(226, 22);
            this.txb_OldPassword.TabIndex = 4;
            // 
            // txb_ConfirmPassword
            // 
            this.txb_ConfirmPassword.Location = new System.Drawing.Point(260, 113);
            this.txb_ConfirmPassword.Name = "txb_ConfirmPassword";
            this.txb_ConfirmPassword.Size = new System.Drawing.Size(226, 22);
            this.txb_ConfirmPassword.TabIndex = 5;
            // 
            // txb_NewPassword
            // 
            this.txb_NewPassword.Location = new System.Drawing.Point(260, 70);
            this.txb_NewPassword.Name = "txb_NewPassword";
            this.txb_NewPassword.Size = new System.Drawing.Size(226, 22);
            this.txb_NewPassword.TabIndex = 6;
            // 
            // frm_PasswordChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(520, 202);
            this.Controls.Add(this.txb_NewPassword);
            this.Controls.Add(this.txb_ConfirmPassword);
            this.Controls.Add(this.txb_OldPassword);
            this.Controls.Add(this.btn_ConfirmPassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frm_PasswordChange";
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
        private System.Windows.Forms.TextBox txb_ConfirmPassword;
        private System.Windows.Forms.TextBox txb_NewPassword;
    }
}