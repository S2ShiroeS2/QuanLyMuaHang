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
            this.txb_NVRole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_NVName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txb_NVActivation = new System.Windows.Forms.TextBox();
            this.btn_NVActive = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(486, 269);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 25);
            this.label7.TabIndex = 32;
            this.label7.Text = "Kích hoạt";
            // 
            // txb_NVAccount
            // 
            this.txb_NVAccount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NVAccount.Location = new System.Drawing.Point(491, 67);
            this.txb_NVAccount.Margin = new System.Windows.Forms.Padding(4);
            this.txb_NVAccount.Name = "txb_NVAccount";
            this.txb_NVAccount.Size = new System.Drawing.Size(265, 30);
            this.txb_NVAccount.TabIndex = 0;
            this.txb_NVAccount.TextChanged += new System.EventHandler(this.txb_NVAccount_TextChanged);
            this.txb_NVAccount.Validating += new System.ComponentModel.CancelEventHandler(this.txb_NVAccount_Validating);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(486, 39);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(99, 25);
            this.label6.TabIndex = 30;
            this.label6.Text = "Tài khoản";
            // 
            // btn_NVSave
            // 
            this.btn_NVSave.Enabled = false;
            this.btn_NVSave.Location = new System.Drawing.Point(884, 466);
            this.btn_NVSave.Name = "btn_NVSave";
            this.btn_NVSave.Size = new System.Drawing.Size(127, 55);
            this.btn_NVSave.TabIndex = 8;
            this.btn_NVSave.Text = "Lưu";
            this.btn_NVSave.UseVisualStyleBackColor = true;
            this.btn_NVSave.Click += new System.EventHandler(this.btn_nv_luu_Click);
            // 
            // btn_NVUpdate
            // 
            this.btn_NVUpdate.Location = new System.Drawing.Point(685, 466);
            this.btn_NVUpdate.Name = "btn_NVUpdate";
            this.btn_NVUpdate.Size = new System.Drawing.Size(127, 55);
            this.btn_NVUpdate.TabIndex = 7;
            this.btn_NVUpdate.Text = "Sửa ";
            this.btn_NVUpdate.UseVisualStyleBackColor = true;
            this.btn_NVUpdate.Click += new System.EventHandler(this.btn_nv_update_Click);
            // 
            // txb_NVEmail
            // 
            this.txb_NVEmail.Location = new System.Drawing.Point(32, 224);
            this.txb_NVEmail.Name = "txb_NVEmail";
            this.txb_NVEmail.Size = new System.Drawing.Size(301, 22);
            this.txb_NVEmail.TabIndex = 3;
            this.txb_NVEmail.TextChanged += new System.EventHandler(this.txb_NVEmail_TextChanged);
            this.txb_NVEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txb_NVEmail_Validating);
            // 
            // txb_NVID
            // 
            this.txb_NVID.Enabled = false;
            this.txb_NVID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NVID.Location = new System.Drawing.Point(32, 141);
            this.txb_NVID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_NVID.Name = "txb_NVID";
            this.txb_NVID.Size = new System.Drawing.Size(265, 30);
            this.txb_NVID.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(27, 112);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Mã nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 187);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 23;
            this.label4.Text = "Email";
            // 
            // txb_NVPhone
            // 
            this.txb_NVPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NVPhone.Location = new System.Drawing.Point(491, 216);
            this.txb_NVPhone.Margin = new System.Windows.Forms.Padding(4);
            this.txb_NVPhone.Name = "txb_NVPhone";
            this.txb_NVPhone.Size = new System.Drawing.Size(265, 30);
            this.txb_NVPhone.TabIndex = 4;
            this.txb_NVPhone.TextChanged += new System.EventHandler(this.txb_NVPhone_TextChanged);
            this.txb_NVPhone.Validating += new System.ComponentModel.CancelEventHandler(this.txb_NVPhone_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(486, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 21;
            this.label3.Text = "Số điện thoại";
            // 
            // txb_NVRole
            // 
            this.txb_NVRole.Enabled = false;
            this.txb_NVRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NVRole.Location = new System.Drawing.Point(32, 314);
            this.txb_NVRole.Margin = new System.Windows.Forms.Padding(4);
            this.txb_NVRole.Multiline = true;
            this.txb_NVRole.Name = "txb_NVRole";
            this.txb_NVRole.Size = new System.Drawing.Size(105, 30);
            this.txb_NVRole.TabIndex = 5;
            this.txb_NVRole.Text = "Nhân viên";
            this.txb_NVRole.TextChanged += new System.EventHandler(this.txb_NVRole_TextChanged);
            this.txb_NVRole.Validating += new System.ComponentModel.CancelEventHandler(this.txb_NVRole_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 269);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 19;
            this.label2.Text = "Quyền";
            // 
            // txb_NVName
            // 
            this.txb_NVName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_NVName.Location = new System.Drawing.Point(32, 67);
            this.txb_NVName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_NVName.Name = "txb_NVName";
            this.txb_NVName.Size = new System.Drawing.Size(265, 30);
            this.txb_NVName.TabIndex = 1;
            this.txb_NVName.TextChanged += new System.EventHandler(this.txb_NVName_TextChanged);
            this.txb_NVName.Validating += new System.ComponentModel.CancelEventHandler(this.txb_NVName_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Tên nhân viên";
            // 
            // txb_NVActivation
            // 
            this.txb_NVActivation.Enabled = false;
            this.txb_NVActivation.Location = new System.Drawing.Point(491, 314);
            this.txb_NVActivation.Name = "txb_NVActivation";
            this.txb_NVActivation.Size = new System.Drawing.Size(100, 22);
            this.txb_NVActivation.TabIndex = 33;
            // 
            // btn_NVActive
            // 
            this.btn_NVActive.Enabled = false;
            this.btn_NVActive.Location = new System.Drawing.Point(597, 298);
            this.btn_NVActive.Name = "btn_NVActive";
            this.btn_NVActive.Size = new System.Drawing.Size(127, 55);
            this.btn_NVActive.TabIndex = 6;
            this.btn_NVActive.Text = "Active";
            this.btn_NVActive.UseVisualStyleBackColor = true;
            this.btn_NVActive.Click += new System.EventHandler(this.btn_nv_active_Click);
            // 
            // frm_CTNV
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1118, 561);
            this.Controls.Add(this.btn_NVActive);
            this.Controls.Add(this.txb_NVActivation);
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
            this.Controls.Add(this.txb_NVRole);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_NVName);
            this.Controls.Add(this.label1);
            this.Name = "frm_CTNV";
            this.Text = "frm_CTNV";
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
        private System.Windows.Forms.TextBox txb_NVRole;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_NVName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_NVActivation;
        private System.Windows.Forms.Button btn_NVActive;
    }
}