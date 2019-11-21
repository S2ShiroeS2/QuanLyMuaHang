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
            this.nbb_Vat = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.nbb_Vat)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 57);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhà cung cấp";
            // 
            // txb_VendorName
            // 
            this.txb_VendorName.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_VendorName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_VendorName.Location = new System.Drawing.Point(13, 90);
            this.txb_VendorName.Margin = new System.Windows.Forms.Padding(4);
            this.txb_VendorName.Name = "txb_VendorName";
            this.txb_VendorName.Size = new System.Drawing.Size(265, 30);
            this.txb_VendorName.TabIndex = 1;
            this.txb_VendorName.TextChanged += new System.EventHandler(this.txb_VendorName_TextChanged);
            this.txb_VendorName.Validating += new System.ComponentModel.CancelEventHandler(this.txb_ten_ncc_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 187);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ";
            // 
            // txb_VendorAddress
            // 
            this.txb_VendorAddress.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_VendorAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_VendorAddress.Location = new System.Drawing.Point(13, 216);
            this.txb_VendorAddress.Margin = new System.Windows.Forms.Padding(4);
            this.txb_VendorAddress.Multiline = true;
            this.txb_VendorAddress.Name = "txb_VendorAddress";
            this.txb_VendorAddress.Size = new System.Drawing.Size(301, 30);
            this.txb_VendorAddress.TabIndex = 3;
            this.txb_VendorAddress.TextChanged += new System.EventHandler(this.txb_VendorAddress_TextChanged);
            this.txb_VendorAddress.Validating += new System.ComponentModel.CancelEventHandler(this.txb_VendorAddress_Validating);
            // 
            // txb_Phone
            // 
            this.txb_Phone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_Phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Phone.Location = new System.Drawing.Point(334, 216);
            this.txb_Phone.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Phone.Name = "txb_Phone";
            this.txb_Phone.Size = new System.Drawing.Size(265, 30);
            this.txb_Phone.TabIndex = 5;
            this.txb_Phone.TextChanged += new System.EventHandler(this.txb_Phone_TextChanged);
            this.txb_Phone.Validating += new System.ComponentModel.CancelEventHandler(this.txb_Phone_Validating);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(332, 187);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 250);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // txb_VendorEmail
            // 
            this.txb_VendorEmail.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_VendorEmail.Location = new System.Drawing.Point(12, 278);
            this.txb_VendorEmail.Name = "txb_VendorEmail";
            this.txb_VendorEmail.Size = new System.Drawing.Size(301, 22);
            this.txb_VendorEmail.TabIndex = 9;
            this.txb_VendorEmail.TextChanged += new System.EventHandler(this.txb_VendorEmail_TextChanged);
            this.txb_VendorEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txb_VendorEmail_Validating);
            // 
            // txb_VendorID
            // 
            this.txb_VendorID.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_VendorID.Enabled = false;
            this.txb_VendorID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_VendorID.Location = new System.Drawing.Point(12, 153);
            this.txb_VendorID.Margin = new System.Windows.Forms.Padding(4);
            this.txb_VendorID.Name = "txb_VendorID";
            this.txb_VendorID.Size = new System.Drawing.Size(74, 30);
            this.txb_VendorID.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(7, 124);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã nhà cung cấp";
            // 
            // btn_UpdateVendor
            // 
            this.btn_UpdateVendor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_UpdateVendor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_UpdateVendor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_UpdateVendor.Location = new System.Drawing.Point(151, 332);
            this.btn_UpdateVendor.Name = "btn_UpdateVendor";
            this.btn_UpdateVendor.Size = new System.Drawing.Size(127, 55);
            this.btn_UpdateVendor.TabIndex = 11;
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
            this.btn_SaveVendor.Location = new System.Drawing.Point(337, 332);
            this.btn_SaveVendor.Name = "btn_SaveVendor";
            this.btn_SaveVendor.Size = new System.Drawing.Size(127, 55);
            this.btn_SaveVendor.TabIndex = 12;
            this.btn_SaveVendor.Text = "Lưu";
            this.btn_SaveVendor.UseVisualStyleBackColor = false;
            this.btn_SaveVendor.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(329, 57);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 25);
            this.label6.TabIndex = 13;
            this.label6.Text = "Có sản phẩm";
            // 
            // txb_Available
            // 
            this.txb_Available.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_Available.Enabled = false;
            this.txb_Available.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Available.Location = new System.Drawing.Point(334, 90);
            this.txb_Available.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Available.Name = "txb_Available";
            this.txb_Available.Size = new System.Drawing.Size(265, 30);
            this.txb_Available.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(329, 124);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 25);
            this.label7.TabIndex = 15;
            this.label7.Text = "VAT";
            // 
            // nbb_Vat
            // 
            this.nbb_Vat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.nbb_Vat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.nbb_Vat.Location = new System.Drawing.Point(334, 153);
            this.nbb_Vat.Name = "nbb_Vat";
            this.nbb_Vat.Size = new System.Drawing.Size(120, 30);
            this.nbb_Vat.TabIndex = 17;
            // 
            // frm_CTNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(644, 440);
            this.Controls.Add(this.nbb_Vat);
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
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_CTNCC";
            this.Text = "formCT_ncc";
            this.Load += new System.EventHandler(this.formCT_ncc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.nbb_Vat)).EndInit();
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
        private System.Windows.Forms.NumericUpDown nbb_Vat;
    }
}