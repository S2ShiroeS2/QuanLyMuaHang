﻿namespace WindowsFormsApplication1
{
    partial class frm_QLNCC
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
            this.tb_tim_kiem_NCC = new System.Windows.Forms.TextBox();
            this.bt_tim_kiem_NCC = new System.Windows.Forms.Button();
            this.bt_tai_len_NCC = new System.Windows.Forms.Button();
            this.bt_tao_moi_NCC = new System.Windows.Forms.Button();
            this.lv_list_ncc = new System.Windows.Forms.ListView();
            this.ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VendorName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VendorAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VAT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VendorPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.VendorAvailable = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // tb_tim_kiem_NCC
            // 
            this.tb_tim_kiem_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tim_kiem_NCC.Location = new System.Drawing.Point(888, 44);
            this.tb_tim_kiem_NCC.Margin = new System.Windows.Forms.Padding(4);
            this.tb_tim_kiem_NCC.Name = "tb_tim_kiem_NCC";
            this.tb_tim_kiem_NCC.Size = new System.Drawing.Size(324, 36);
            this.tb_tim_kiem_NCC.TabIndex = 23;
            // 
            // bt_tim_kiem_NCC
            // 
            this.bt_tim_kiem_NCC.Location = new System.Drawing.Point(736, 34);
            this.bt_tim_kiem_NCC.Margin = new System.Windows.Forms.Padding(4);
            this.bt_tim_kiem_NCC.Name = "bt_tim_kiem_NCC";
            this.bt_tim_kiem_NCC.Size = new System.Drawing.Size(108, 49);
            this.bt_tim_kiem_NCC.TabIndex = 22;
            this.bt_tim_kiem_NCC.Text = "Tìm kiếm";
            this.bt_tim_kiem_NCC.UseVisualStyleBackColor = true;
            this.bt_tim_kiem_NCC.Click += new System.EventHandler(this.bt_tim_kiem_NCC_Click);
            // 
            // bt_tai_len_NCC
            // 
            this.bt_tai_len_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tai_len_NCC.Location = new System.Drawing.Point(148, 32);
            this.bt_tai_len_NCC.Margin = new System.Windows.Forms.Padding(4);
            this.bt_tai_len_NCC.Name = "bt_tai_len_NCC";
            this.bt_tai_len_NCC.Size = new System.Drawing.Size(105, 49);
            this.bt_tai_len_NCC.TabIndex = 21;
            this.bt_tai_len_NCC.Text = "Tải lên";
            this.bt_tai_len_NCC.UseVisualStyleBackColor = true;
            // 
            // bt_tao_moi_NCC
            // 
            this.bt_tao_moi_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tao_moi_NCC.Location = new System.Drawing.Point(13, 32);
            this.bt_tao_moi_NCC.Margin = new System.Windows.Forms.Padding(4);
            this.bt_tao_moi_NCC.Name = "bt_tao_moi_NCC";
            this.bt_tao_moi_NCC.Size = new System.Drawing.Size(105, 49);
            this.bt_tao_moi_NCC.TabIndex = 20;
            this.bt_tao_moi_NCC.Text = "Tạo mới";
            this.bt_tao_moi_NCC.UseVisualStyleBackColor = true;
            this.bt_tao_moi_NCC.Click += new System.EventHandler(this.bt_tao_moi_NCC_Click);
            // 
            // lv_list_ncc
            // 
            this.lv_list_ncc.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ID,
            this.VendorName,
            this.VendorAddress,
            this.VAT,
            this.Email,
            this.VendorPhone,
            this.VendorAvailable});
            this.lv_list_ncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_list_ncc.FullRowSelect = true;
            this.lv_list_ncc.Location = new System.Drawing.Point(28, 136);
            this.lv_list_ncc.Margin = new System.Windows.Forms.Padding(4);
            this.lv_list_ncc.MultiSelect = false;
            this.lv_list_ncc.Name = "lv_list_ncc";
            this.lv_list_ncc.Size = new System.Drawing.Size(1314, 447);
            this.lv_list_ncc.TabIndex = 24;
            this.lv_list_ncc.UseCompatibleStateImageBehavior = false;
            this.lv_list_ncc.View = System.Windows.Forms.View.Details;
            this.lv_list_ncc.SelectedIndexChanged += new System.EventHandler(this.lv_list_ncc_SelectedIndexChanged);
            this.lv_list_ncc.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lv_list_ncc_MouseDoubleClick);
            // 
            // ID
            // 
            this.ID.Text = "Mã nhà cung cấp";
            this.ID.Width = 164;
            // 
            // VendorName
            // 
            this.VendorName.Text = "Tên nhà cung cấp";
            this.VendorName.Width = 174;
            // 
            // VendorAddress
            // 
            this.VendorAddress.Text = "Địa chỉ";
            this.VendorAddress.Width = 200;
            // 
            // VAT
            // 
            this.VAT.Text = "VAT";
            this.VAT.Width = 63;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 179;
            // 
            // VendorPhone
            // 
            this.VendorPhone.Text = "Số điện thoại";
            this.VendorPhone.Width = 149;
            // 
            // VendorAvailable
            // 
            this.VendorAvailable.Text = "Been there done that";
            this.VendorAvailable.Width = 198;
            // 
            // Form_QLNCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1340, 583);
            this.Controls.Add(this.lv_list_ncc);
            this.Controls.Add(this.tb_tim_kiem_NCC);
            this.Controls.Add(this.bt_tim_kiem_NCC);
            this.Controls.Add(this.bt_tai_len_NCC);
            this.Controls.Add(this.bt_tao_moi_NCC);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form_QLNCC";
            this.Text = "Form_QLNCC";
            this.Load += new System.EventHandler(this.Form_QLNCC_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_tim_kiem_NCC;
        private System.Windows.Forms.Button bt_tim_kiem_NCC;
        private System.Windows.Forms.Button bt_tai_len_NCC;
        private System.Windows.Forms.Button bt_tao_moi_NCC;
        private System.Windows.Forms.ListView lv_list_ncc;
        private System.Windows.Forms.ColumnHeader ID;
        private System.Windows.Forms.ColumnHeader VendorName;
        private System.Windows.Forms.ColumnHeader VendorAddress;
        private System.Windows.Forms.ColumnHeader VAT;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader VendorPhone;
        private System.Windows.Forms.ColumnHeader VendorAvailable;
    }
}