namespace WindowsFormsApplication1
{
    partial class frm_CTNV
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CTNV));
            this.label7 = new System.Windows.Forms.Label();
            this.txb_NVAccount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_NVSave = new System.Windows.Forms.Button();
            this.btn_NVUpdate = new System.Windows.Forms.Button();
            this.txb_NVEmail = new System.Windows.Forms.TextBox();
            this.txb_NVID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_NVPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_NVName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb_NVActivation = new System.Windows.Forms.ComboBox();
            this.cmb_NVRole = new System.Windows.Forms.ComboBox();
            this.btn_ResetPassword = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(368, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Kích hoạt";
            // 
            // txb_NVAccount
            // 
            this.txb_NVAccount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_NVAccount.Enabled = false;
            this.txb_NVAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NVAccount.Location = new System.Drawing.Point(368, 79);
            this.txb_NVAccount.Name = "txb_NVAccount";
            this.txb_NVAccount.Size = new System.Drawing.Size(200, 26);
            this.txb_NVAccount.TabIndex = 0;
            this.txb_NVAccount.TextChanged += new System.EventHandler(this.txb_NVAccount_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(364, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Tài khoản";
            // 
            // btn_NVSave
            // 
            this.btn_NVSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_NVSave.Enabled = false;
            this.btn_NVSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NVSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NVSave.Location = new System.Drawing.Point(472, 351);
            this.btn_NVSave.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NVSave.Name = "btn_NVSave";
            this.btn_NVSave.Size = new System.Drawing.Size(95, 45);
            this.btn_NVSave.TabIndex = 8;
            this.btn_NVSave.Text = "Lưu";
            this.btn_NVSave.UseVisualStyleBackColor = false;
            this.btn_NVSave.Click += new System.EventHandler(this.btn_nv_luu_Click);
            // 
            // btn_NVUpdate
            // 
            this.btn_NVUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_NVUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NVUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NVUpdate.Location = new System.Drawing.Point(22, 351);
            this.btn_NVUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.btn_NVUpdate.Name = "btn_NVUpdate";
            this.btn_NVUpdate.Size = new System.Drawing.Size(95, 45);
            this.btn_NVUpdate.TabIndex = 7;
            this.btn_NVUpdate.Text = "Sửa ";
            this.btn_NVUpdate.UseVisualStyleBackColor = false;
            this.btn_NVUpdate.Click += new System.EventHandler(this.btn_nv_update_Click);
            // 
            // txb_NVEmail
            // 
            this.txb_NVEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_NVEmail.Location = new System.Drawing.Point(24, 207);
            this.txb_NVEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txb_NVEmail.Name = "txb_NVEmail";
            this.txb_NVEmail.Size = new System.Drawing.Size(227, 20);
            this.txb_NVEmail.TabIndex = 3;
            this.txb_NVEmail.TextChanged += new System.EventHandler(this.txb_NVEmail_TextChanged);
            // 
            // txb_NVID
            // 
            this.txb_NVID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_NVID.Enabled = false;
            this.txb_NVID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NVID.Location = new System.Drawing.Point(24, 140);
            this.txb_NVID.Name = "txb_NVID";
            this.txb_NVID.Size = new System.Drawing.Size(227, 26);
            this.txb_NVID.TabIndex = 2;
            this.txb_NVID.TextChanged += new System.EventHandler(this.txb_NVID_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(20, 116);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(20, 177);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Email";
            // 
            // txb_NVPhone
            // 
            this.txb_NVPhone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_NVPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NVPhone.Location = new System.Drawing.Point(368, 140);
            this.txb_NVPhone.Name = "txb_NVPhone";
            this.txb_NVPhone.Size = new System.Drawing.Size(200, 26);
            this.txb_NVPhone.TabIndex = 4;
            this.txb_NVPhone.TextChanged += new System.EventHandler(this.txb_NVPhone_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(364, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "Số điện thoại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(20, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 20);
            this.label2.TabIndex = 19;
            this.label2.Text = "Quyền";
            // 
            // txb_NVName
            // 
            this.txb_NVName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_NVName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NVName.Location = new System.Drawing.Point(24, 79);
            this.txb_NVName.Name = "txb_NVName";
            this.txb_NVName.Size = new System.Drawing.Size(227, 26);
            this.txb_NVName.TabIndex = 1;
            this.txb_NVName.TextChanged += new System.EventHandler(this.txb_NVName_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tên nhân viên";
            // 
            // cmb_NVActivation
            // 
            this.cmb_NVActivation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_NVActivation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_NVActivation.FormattingEnabled = true;
            this.cmb_NVActivation.Items.AddRange(new object[] {
            "Active",
            "Deactive"});
            this.cmb_NVActivation.Location = new System.Drawing.Point(368, 200);
            this.cmb_NVActivation.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_NVActivation.Name = "cmb_NVActivation";
            this.cmb_NVActivation.Size = new System.Drawing.Size(92, 25);
            this.cmb_NVActivation.TabIndex = 34;
            this.cmb_NVActivation.SelectedIndexChanged += new System.EventHandler(this.cmb_NVActivation_SelectedIndexChanged);
            // 
            // cmb_NVRole
            // 
            this.cmb_NVRole.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmb_NVRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_NVRole.FormattingEnabled = true;
            this.cmb_NVRole.Items.AddRange(new object[] {
            "Nhân viên",
            "Admin"});
            this.cmb_NVRole.Location = new System.Drawing.Point(24, 266);
            this.cmb_NVRole.Margin = new System.Windows.Forms.Padding(2);
            this.cmb_NVRole.Name = "cmb_NVRole";
            this.cmb_NVRole.Size = new System.Drawing.Size(92, 25);
            this.cmb_NVRole.TabIndex = 35;
            this.cmb_NVRole.SelectedIndexChanged += new System.EventHandler(this.cmb_NVRole_SelectedIndexChanged);
            // 
            // btn_ResetPassword
            // 
            this.btn_ResetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ResetPassword.Enabled = false;
            this.btn_ResetPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ResetPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ResetPassword.Location = new System.Drawing.Point(368, 246);
            this.btn_ResetPassword.Margin = new System.Windows.Forms.Padding(2);
            this.btn_ResetPassword.Name = "btn_ResetPassword";
            this.btn_ResetPassword.Size = new System.Drawing.Size(157, 45);
            this.btn_ResetPassword.TabIndex = 36;
            this.btn_ResetPassword.Text = "Reset Password";
            this.btn_ResetPassword.UseVisualStyleBackColor = false;
            this.btn_ResetPassword.Click += new System.EventHandler(this.btn_ResetPassword_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(20, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(148, 20);
            this.label8.TabIndex = 37;
            this.label8.Text = "Chi tiết nhân viên";
            // 
            // frm_CTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(586, 414);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_ResetPassword);
            this.Controls.Add(this.cmb_NVRole);
            this.Controls.Add(this.cmb_NVActivation);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_NVAccount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_NVSave);
            this.Controls.Add(this.btn_NVUpdate);
            this.Controls.Add(this.txb_NVEmail);
            this.Controls.Add(this.txb_NVID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_NVPhone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_NVName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frm_CTNV";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin chi tiết nhân viên";
            this.Load += new System.EventHandler(this.frm_CTNV_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txb_NVAccount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_NVSave;
        private System.Windows.Forms.Button btn_NVUpdate;
        private System.Windows.Forms.TextBox txb_NVEmail;
        private System.Windows.Forms.TextBox txb_NVID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_NVPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_NVName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmb_NVActivation;
        private System.Windows.Forms.ComboBox cmb_NVRole;
        private System.Windows.Forms.Button btn_ResetPassword;
        private System.Windows.Forms.Label label8;
    }
}