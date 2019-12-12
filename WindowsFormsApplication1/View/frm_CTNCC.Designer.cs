namespace WindowsFormsApplication1
{
    partial class frm_CTNCC
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CTNCC));
            this.label1 = new System.Windows.Forms.Label();
            this.txb_VendorName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_VendorAddress = new System.Windows.Forms.TextBox();
            this.txb_Phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txb_VendorEmail = new System.Windows.Forms.TextBox();
            this.txb_VendorID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.btn_UpdateVendor = new System.Windows.Forms.Button();
            this.btn_SaveVendor = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txb_Available = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txb_VAT = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhà cung cấp";
            // 
            // txb_VendorName
            // 
            this.txb_VendorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_VendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_VendorName.Location = new System.Drawing.Point(9, 140);
            this.txb_VendorName.MaxLength = 100;
            this.txb_VendorName.Name = "txb_VendorName";
            this.txb_VendorName.Size = new System.Drawing.Size(200, 26);
            this.txb_VendorName.TabIndex = 1;
            this.txb_VendorName.TextChanged += new System.EventHandler(this.txb_VendorName_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 185);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ";
            // 
            // txb_VendorAddress
            // 
            this.txb_VendorAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_VendorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_VendorAddress.Location = new System.Drawing.Point(9, 209);
            this.txb_VendorAddress.MaxLength = 200;
            this.txb_VendorAddress.Name = "txb_VendorAddress";
            this.txb_VendorAddress.Size = new System.Drawing.Size(440, 26);
            this.txb_VendorAddress.TabIndex = 3;
            this.txb_VendorAddress.TextChanged += new System.EventHandler(this.txb_VendorAddress_TextChanged);
            // 
            // txb_Phone
            // 
            this.txb_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Phone.Location = new System.Drawing.Point(250, 271);
            this.txb_Phone.MaxLength = 20;
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(200, 26);
            this.txb_Phone.TabIndex = 5;
            this.txb_Phone.TextChanged += new System.EventHandler(this.txb_Phone_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(249, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(10, 248);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // txb_VendorEmail
            // 
            this.txb_VendorEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_VendorEmail.Location = new System.Drawing.Point(9, 271);
            this.txb_VendorEmail.Margin = new System.Windows.Forms.Padding(2);
            this.txb_VendorEmail.MaxLength = 200;
            this.txb_VendorEmail.Name = "txb_VendorEmail";
            this.txb_VendorEmail.Size = new System.Drawing.Size(227, 20);
            this.txb_VendorEmail.TabIndex = 4;
            this.txb_VendorEmail.TextChanged += new System.EventHandler(this.txb_VendorEmail_TextChanged);
            // 
            // txb_VendorID
            // 
            this.txb_VendorID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_VendorID.Enabled = false;
            this.txb_VendorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_VendorID.Location = new System.Drawing.Point(8, 74);
            this.txb_VendorID.Name = "txb_VendorID";
            this.txb_VendorID.Size = new System.Drawing.Size(56, 26);
            this.txb_VendorID.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(8, 51);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(131, 20);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã nhà cung cấp";
            // 
            // btn_UpdateVendor
            // 
            this.btn_UpdateVendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_UpdateVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateVendor.Location = new System.Drawing.Point(113, 318);
            this.btn_UpdateVendor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_UpdateVendor.Name = "btn_UpdateVendor";
            this.btn_UpdateVendor.Size = new System.Drawing.Size(95, 45);
            this.btn_UpdateVendor.TabIndex = 6;
            this.btn_UpdateVendor.Text = "Sửa ";
            this.btn_UpdateVendor.UseVisualStyleBackColor = false;
            this.btn_UpdateVendor.Click += new System.EventHandler(this.bt__sua_ncc_Click);
            // 
            // btn_SaveVendor
            // 
            this.btn_SaveVendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_SaveVendor.Enabled = false;
            this.btn_SaveVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaveVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaveVendor.Location = new System.Drawing.Point(253, 318);
            this.btn_SaveVendor.Margin = new System.Windows.Forms.Padding(2);
            this.btn_SaveVendor.Name = "btn_SaveVendor";
            this.btn_SaveVendor.Size = new System.Drawing.Size(95, 45);
            this.btn_SaveVendor.TabIndex = 7;
            this.btn_SaveVendor.Text = "Lưu";
            this.btn_SaveVendor.UseVisualStyleBackColor = false;
            this.btn_SaveVendor.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(246, 51);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(103, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Có sản phẩm";
            // 
            // txb_Available
            // 
            this.txb_Available.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_Available.Enabled = false;
            this.txb_Available.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Available.Location = new System.Drawing.Point(249, 78);
            this.txb_Available.Name = "txb_Available";
            this.txb_Available.Size = new System.Drawing.Size(200, 26);
            this.txb_Available.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(246, 118);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(34, 20);
            this.label7.TabIndex = 15;
            this.label7.Text = "TIN";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(8, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(179, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Chi tiết nhà cung cấp";
            // 
            // txb_VAT
            // 
            this.txb_VAT.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_VAT.Enabled = false;
            this.txb_VAT.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_VAT.Location = new System.Drawing.Point(249, 141);
            this.txb_VAT.Name = "txb_VAT";
            this.txb_VAT.Size = new System.Drawing.Size(200, 26);
            this.txb_VAT.TabIndex = 2;
            this.txb_VAT.TextChanged += new System.EventHandler(this.txb_VAT_TextChanged);
            // 
            // frm_CTNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(513, 387);
            this.Controls.Add(this.txb_VAT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txb_Available);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btn_SaveVendor);
            this.Controls.Add(this.btn_UpdateVendor);
            this.Controls.Add(this.txb_VendorEmail);
            this.Controls.Add(this.txb_VendorID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txb_Phone);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txb_VendorAddress);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_VendorName);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_CTNCC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "formCT_ncc";
            this.Load += new System.EventHandler(this.formCT_ncc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txb_VendorName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_VendorAddress;
        private System.Windows.Forms.TextBox txb_Phone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txb_VendorEmail;
        private System.Windows.Forms.TextBox txb_VendorID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btn_UpdateVendor;
        private System.Windows.Forms.Button btn_SaveVendor;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txb_Available;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txb_VAT;
    }
}