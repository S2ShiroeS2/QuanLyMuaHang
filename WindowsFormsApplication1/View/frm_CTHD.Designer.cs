namespace WindowsFormsApplication1
{
    partial class frm_CTHD
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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "Thêm sản phẩm"}, -1, System.Drawing.Color.Empty, System.Drawing.Color.Empty, new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0))));
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CTHD));
            this.lbl_chitiethoadon = new System.Windows.Forms.Label();
            this.txt_Ma_HD = new System.Windows.Forms.TextBox();
            this.lbl_nhacc = new System.Windows.Forms.Label();
            this.lbl_ngay_dat_hang = new System.Windows.Forms.Label();
            this.dtpk_ngay_dat_hang = new System.Windows.Forms.DateTimePicker();
            this.lstv_list_cthd = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txt_tong_tien_HD_khong_thue = new System.Windows.Forms.TextBox();
            this.lbl_tientruocthue = new System.Windows.Forms.Label();
            this.txt_Thue_HD = new System.Windows.Forms.TextBox();
            this.lbl_thue = new System.Windows.Forms.Label();
            this.txt_Tong_tien_HD = new System.Windows.Forms.TextBox();
            this.lbl_tongtien = new System.Windows.Forms.Label();
            this.btn_luu = new System.Windows.Forms.Button();
            this.lbl_ma_hoa_don = new System.Windows.Forms.Label();
            this.cbo_nha_cc = new System.Windows.Forms.ComboBox();
            this.btn_Xoa_SP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_chitiethoadon
            // 
            this.lbl_chitiethoadon.AutoSize = true;
            this.lbl_chitiethoadon.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_chitiethoadon.Location = new System.Drawing.Point(12, 9);
            this.lbl_chitiethoadon.Name = "lbl_chitiethoadon";
            this.lbl_chitiethoadon.Size = new System.Drawing.Size(158, 24);
            this.lbl_chitiethoadon.TabIndex = 0;
            this.lbl_chitiethoadon.Text = "Chi tiết hóa đơn";
            // 
            // txt_Ma_HD
            // 
            this.txt_Ma_HD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_Ma_HD.Enabled = false;
            this.txt_Ma_HD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ma_HD.Location = new System.Drawing.Point(142, 36);
            this.txt_Ma_HD.Name = "txt_Ma_HD";
            this.txt_Ma_HD.Size = new System.Drawing.Size(100, 29);
            this.txt_Ma_HD.TabIndex = 1;
            this.txt_Ma_HD.TextChanged += new System.EventHandler(this.txt_Ma_HD_TextChanged);
            // 
            // lbl_nhacc
            // 
            this.lbl_nhacc.AutoSize = true;
            this.lbl_nhacc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nhacc.Location = new System.Drawing.Point(21, 90);
            this.lbl_nhacc.Name = "lbl_nhacc";
            this.lbl_nhacc.Size = new System.Drawing.Size(107, 20);
            this.lbl_nhacc.TabIndex = 2;
            this.lbl_nhacc.Text = "Nhà cung cấp";
            // 
            // lbl_ngay_dat_hang
            // 
            this.lbl_ngay_dat_hang.AutoSize = true;
            this.lbl_ngay_dat_hang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ngay_dat_hang.Location = new System.Drawing.Point(459, 90);
            this.lbl_ngay_dat_hang.Name = "lbl_ngay_dat_hang";
            this.lbl_ngay_dat_hang.Size = new System.Drawing.Size(112, 20);
            this.lbl_ngay_dat_hang.TabIndex = 4;
            this.lbl_ngay_dat_hang.Text = "Ngày đặt hàng";
            // 
            // dtpk_ngay_dat_hang
            // 
            this.dtpk_ngay_dat_hang.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dtpk_ngay_dat_hang.Enabled = false;
            this.dtpk_ngay_dat_hang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_ngay_dat_hang.Location = new System.Drawing.Point(586, 84);
            this.dtpk_ngay_dat_hang.Name = "dtpk_ngay_dat_hang";
            this.dtpk_ngay_dat_hang.Size = new System.Drawing.Size(273, 26);
            this.dtpk_ngay_dat_hang.TabIndex = 6;
            // 
            // lstv_list_cthd
            // 
            this.lstv_list_cthd.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.lstv_list_cthd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstv_list_cthd.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.lstv_list_cthd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstv_list_cthd.FullRowSelect = true;
            this.lstv_list_cthd.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lstv_list_cthd.Location = new System.Drawing.Point(25, 146);
            this.lstv_list_cthd.MultiSelect = false;
            this.lstv_list_cthd.Name = "lstv_list_cthd";
            this.lstv_list_cthd.Size = new System.Drawing.Size(900, 199);
            this.lstv_list_cthd.TabIndex = 7;
            this.lstv_list_cthd.UseCompatibleStateImageBehavior = false;
            this.lstv_list_cthd.View = System.Windows.Forms.View.Details;
            this.lstv_list_cthd.SelectedIndexChanged += new System.EventHandler(this.lstv_list_cthd_SelectedIndexChanged);
            this.lstv_list_cthd.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstv_list_cthd_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã CT hóa đơn";
            this.columnHeader1.Width = 167;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Tên sản phẩm";
            this.columnHeader6.Width = 175;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Số lượng";
            this.columnHeader2.Width = 129;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Đơn giá";
            this.columnHeader3.Width = 115;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thuế";
            this.columnHeader4.Width = 115;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tổng tiền";
            this.columnHeader5.Width = 190;
            // 
            // txt_tong_tien_HD_khong_thue
            // 
            this.txt_tong_tien_HD_khong_thue.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_tong_tien_HD_khong_thue.Enabled = false;
            this.txt_tong_tien_HD_khong_thue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tong_tien_HD_khong_thue.Location = new System.Drawing.Point(728, 351);
            this.txt_tong_tien_HD_khong_thue.Name = "txt_tong_tien_HD_khong_thue";
            this.txt_tong_tien_HD_khong_thue.Size = new System.Drawing.Size(175, 22);
            this.txt_tong_tien_HD_khong_thue.TabIndex = 9;
            this.txt_tong_tien_HD_khong_thue.TextChanged += new System.EventHandler(this.txt_tong_tien_HD_khong_thue_TextChanged);
            // 
            // lbl_tientruocthue
            // 
            this.lbl_tientruocthue.AutoSize = true;
            this.lbl_tientruocthue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tientruocthue.Location = new System.Drawing.Point(611, 357);
            this.lbl_tientruocthue.Name = "lbl_tientruocthue";
            this.lbl_tientruocthue.Size = new System.Drawing.Size(95, 16);
            this.lbl_tientruocthue.TabIndex = 8;
            this.lbl_tientruocthue.Text = "Tiền trước thuế";
            // 
            // txt_Thue_HD
            // 
            this.txt_Thue_HD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_Thue_HD.Enabled = false;
            this.txt_Thue_HD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Thue_HD.Location = new System.Drawing.Point(728, 395);
            this.txt_Thue_HD.Name = "txt_Thue_HD";
            this.txt_Thue_HD.Size = new System.Drawing.Size(175, 22);
            this.txt_Thue_HD.TabIndex = 11;
            this.txt_Thue_HD.TextChanged += new System.EventHandler(this.txt_Thue_HD_TextChanged);
            // 
            // lbl_thue
            // 
            this.lbl_thue.AutoSize = true;
            this.lbl_thue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_thue.Location = new System.Drawing.Point(611, 401);
            this.lbl_thue.Name = "lbl_thue";
            this.lbl_thue.Size = new System.Drawing.Size(39, 16);
            this.lbl_thue.TabIndex = 10;
            this.lbl_thue.Text = "Thuế";
            // 
            // txt_Tong_tien_HD
            // 
            this.txt_Tong_tien_HD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_Tong_tien_HD.Enabled = false;
            this.txt_Tong_tien_HD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tong_tien_HD.Location = new System.Drawing.Point(728, 440);
            this.txt_Tong_tien_HD.Name = "txt_Tong_tien_HD";
            this.txt_Tong_tien_HD.Size = new System.Drawing.Size(175, 22);
            this.txt_Tong_tien_HD.TabIndex = 13;
            this.txt_Tong_tien_HD.TextChanged += new System.EventHandler(this.txt_Tong_tien_HD_TextChanged);
            // 
            // lbl_tongtien
            // 
            this.lbl_tongtien.AutoSize = true;
            this.lbl_tongtien.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tongtien.Location = new System.Drawing.Point(611, 446);
            this.lbl_tongtien.Name = "lbl_tongtien";
            this.lbl_tongtien.Size = new System.Drawing.Size(64, 16);
            this.lbl_tongtien.TabIndex = 12;
            this.lbl_tongtien.Text = "Tổng tiền";
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_luu.Enabled = false;
            this.btn_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(12, 426);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(87, 36);
            this.btn_luu.TabIndex = 16;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // lbl_ma_hoa_don
            // 
            this.lbl_ma_hoa_don.AutoSize = true;
            this.lbl_ma_hoa_don.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ma_hoa_don.Location = new System.Drawing.Point(21, 45);
            this.lbl_ma_hoa_don.Name = "lbl_ma_hoa_don";
            this.lbl_ma_hoa_don.Size = new System.Drawing.Size(93, 20);
            this.lbl_ma_hoa_don.TabIndex = 17;
            this.lbl_ma_hoa_don.Text = "Mã hóa đơn";
            // 
            // cbo_nha_cc
            // 
            this.cbo_nha_cc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbo_nha_cc.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_nha_cc.FormattingEnabled = true;
            this.cbo_nha_cc.Location = new System.Drawing.Point(142, 89);
            this.cbo_nha_cc.Name = "cbo_nha_cc";
            this.cbo_nha_cc.Size = new System.Drawing.Size(231, 21);
            this.cbo_nha_cc.TabIndex = 18;
            this.cbo_nha_cc.DropDown += new System.EventHandler(this.cbo_nha_cc_DropDown);
            this.cbo_nha_cc.SelectedIndexChanged += new System.EventHandler(this.cbo_nha_cc_SelectedIndexChanged);
            // 
            // btn_Xoa_SP
            // 
            this.btn_Xoa_SP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Xoa_SP.Enabled = false;
            this.btn_Xoa_SP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Xoa_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Xoa_SP.Location = new System.Drawing.Point(12, 351);
            this.btn_Xoa_SP.Name = "btn_Xoa_SP";
            this.btn_Xoa_SP.Size = new System.Drawing.Size(129, 36);
            this.btn_Xoa_SP.TabIndex = 19;
            this.btn_Xoa_SP.Text = "Xóa sản phẩm";
            this.btn_Xoa_SP.UseVisualStyleBackColor = false;
            this.btn_Xoa_SP.Click += new System.EventHandler(this.btn_Xoa_SP_Click);
            // 
            // frm_CTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(924, 474);
            this.Controls.Add(this.btn_Xoa_SP);
            this.Controls.Add(this.cbo_nha_cc);
            this.Controls.Add(this.lbl_ma_hoa_don);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.txt_Tong_tien_HD);
            this.Controls.Add(this.lbl_tongtien);
            this.Controls.Add(this.txt_Thue_HD);
            this.Controls.Add(this.lbl_thue);
            this.Controls.Add(this.txt_tong_tien_HD_khong_thue);
            this.Controls.Add(this.lbl_tientruocthue);
            this.Controls.Add(this.lstv_list_cthd);
            this.Controls.Add(this.dtpk_ngay_dat_hang);
            this.Controls.Add(this.lbl_ngay_dat_hang);
            this.Controls.Add(this.lbl_nhacc);
            this.Controls.Add(this.txt_Ma_HD);
            this.Controls.Add(this.lbl_chitiethoadon);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_CTHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "form_CTHD";
            this.Load += new System.EventHandler(this.frm_CTHD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_chitiethoadon;
        private System.Windows.Forms.TextBox txt_Ma_HD;
        private System.Windows.Forms.Label lbl_nhacc;
        private System.Windows.Forms.Label lbl_ngay_dat_hang;
        private System.Windows.Forms.DateTimePicker dtpk_ngay_dat_hang;
        private System.Windows.Forms.ListView lstv_list_cthd;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox txt_tong_tien_HD_khong_thue;
        private System.Windows.Forms.Label lbl_tientruocthue;
        private System.Windows.Forms.TextBox txt_Thue_HD;
        private System.Windows.Forms.Label lbl_thue;
        private System.Windows.Forms.TextBox txt_Tong_tien_HD;
        private System.Windows.Forms.Label lbl_tongtien;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.Label lbl_ma_hoa_don;
        private System.Windows.Forms.ComboBox cbo_nha_cc;
        private System.Windows.Forms.Button btn_Xoa_SP;
    }
}