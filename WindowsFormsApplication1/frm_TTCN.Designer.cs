namespace WindowsFormsApplication1
{
    partial class frm_TTCN
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
            this.txb_Account = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_Email = new System.Windows.Forms.TextBox();
            this.txb_ID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txb_Name = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_ChangePassword = new System.Windows.Forms.Button();
            this.btn_ChangeInform = new System.Windows.Forms.Button();
            this.btn_SaveInform = new System.Windows.Forms.Button();
            this.txb_Role = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txb_Account
            // 
            this.txb_Account.Enabled = false;
            this.txb_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Account.Location = new System.Drawing.Point(636, 143);
            this.txb_Account.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Account.Name = "txb_Account";
            this.txb_Account.Size = new System.Drawing.Size(265, 30);
            this.txb_Account.TabIndex = 47;
            this.txb_Account.Validating += new System.ComponentModel.CancelEventHandler(this.txb_Account_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(631, 115);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 46;
            this.label6.Text = "Tài khoản";
            // 
            // txb_Email
            // 
            this.txb_Email.Enabled = false;
            this.txb_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txb_Email.Location = new System.Drawing.Point(177, 300);
            this.txb_Email.Name = "txb_Email";
            this.txb_Email.Size = new System.Drawing.Size(301, 30);
            this.txb_Email.TabIndex = 45;
            this.txb_Email.Validating += new System.ComponentModel.CancelEventHandler(this.txb_Email_Validating);
            // 
            // txb_ID
            // 
            this.txb_ID.Enabled = false;
            this.txb_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_ID.Location = new System.Drawing.Point(177, 217);
            this.txb_ID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_ID.Name = "txb_ID";
            this.txb_ID.Size = new System.Drawing.Size(125, 30);
            this.txb_ID.TabIndex = 44;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(172, 188);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(172, 263);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 42;
            this.label4.Text = "Email";
            // 
            // txb_Phone
            // 
            this.txb_Phone.Enabled = false;
            this.txb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Phone.Location = new System.Drawing.Point(636, 292);
            this.txb_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(265, 30);
            this.txb_Phone.TabIndex = 41;
            this.txb_Phone.Validating += new System.ComponentModel.CancelEventHandler(this.txb_Phone_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(631, 263);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 40;
            this.label3.Text = "Số điện thoại";
            // 
            // txb_Name
            // 
            this.txb_Name.Enabled = false;
            this.txb_Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Name.Location = new System.Drawing.Point(177, 143);
            this.txb_Name.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Name.Name = "txb_Name";
            this.txb_Name.Size = new System.Drawing.Size(265, 30);
            this.txb_Name.TabIndex = 37;
            this.txb_Name.Validating += new System.ComponentModel.CancelEventHandler(this.txb_Name_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(172, 115);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 36;
            this.label1.Text = "Tên nhân viên";
            // 
            // btn_ChangePassword
            // 
            this.btn_ChangePassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ChangePassword.Location = new System.Drawing.Point(177, 382);
            this.btn_ChangePassword.Name = "btn_ChangePassword";
            this.btn_ChangePassword.Size = new System.Drawing.Size(151, 38);
            this.btn_ChangePassword.TabIndex = 48;
            this.btn_ChangePassword.Text = "Đổi mật khẩu";
            this.btn_ChangePassword.UseVisualStyleBackColor = true;
            this.btn_ChangePassword.Click += new System.EventHandler(this.btn_ChangePassword_Click);
            // 
            // btn_ChangeInform
            // 
            this.btn_ChangeInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ChangeInform.Location = new System.Drawing.Point(636, 382);
            this.btn_ChangeInform.Name = "btn_ChangeInform";
            this.btn_ChangeInform.Size = new System.Drawing.Size(231, 38);
            this.btn_ChangeInform.TabIndex = 49;
            this.btn_ChangeInform.Text = "Đổi thông tin cá nhân";
            this.btn_ChangeInform.UseVisualStyleBackColor = true;
            this.btn_ChangeInform.Click += new System.EventHandler(this.btn_ChangeInform_Click);
            // 
            // btn_SaveInform
            // 
            this.btn_SaveInform.Enabled = false;
            this.btn_SaveInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_SaveInform.Location = new System.Drawing.Point(903, 382);
            this.btn_SaveInform.Name = "btn_SaveInform";
            this.btn_SaveInform.Size = new System.Drawing.Size(108, 38);
            this.btn_SaveInform.TabIndex = 50;
            this.btn_SaveInform.Text = "Lưu";
            this.btn_SaveInform.UseVisualStyleBackColor = true;
            this.btn_SaveInform.Click += new System.EventHandler(this.btn_SaveInform_Click);
            // 
            // txb_Role
            // 
            this.txb_Role.Enabled = false;
            this.txb_Role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Role.Location = new System.Drawing.Point(636, 217);
            this.txb_Role.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Role.Name = "txb_Role";
            this.txb_Role.Size = new System.Drawing.Size(265, 30);
            this.txb_Role.TabIndex = 52;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(631, 188);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 25);
            this.label2.TabIndex = 51;
            this.label2.Text = "Vai trò";
            // 
            // frm_TTCN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1073, 544);
            this.Controls.Add(this.txb_Role);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_SaveInform);
            this.Controls.Add(this.btn_ChangeInform);
            this.Controls.Add(this.btn_ChangePassword);
            this.Controls.Add(this.txb_Account);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txb_Email);
            this.Controls.Add(this.txb_ID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_Phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_Name);
            this.Controls.Add(this.label1);
            this.Name = "frm_TTCN";
            this.Text = "frm_TTCN";
            this.Load += new System.EventHandler(this.frm_TTCN_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Account;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_Email;
        private System.Windows.Forms.TextBox txb_ID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txb_Name;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_ChangePassword;
        private System.Windows.Forms.Button btn_ChangeInform;
        private System.Windows.Forms.Button btn_SaveInform;
        private System.Windows.Forms.TextBox txb_Role;
        private System.Windows.Forms.Label label2;
    }
}