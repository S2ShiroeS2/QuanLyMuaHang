namespace WindowsFormsApplication1
{
    partial class form_CTSP
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
            this.lbl_ma_sp = new System.Windows.Forms.Label();
            this.txt_ma_sp = new System.Windows.Forms.TextBox();
            this.lbl_ten_sp = new System.Windows.Forms.Label();
            this.lbl_loại_sp = new System.Windows.Forms.Label();
            this.lbl_danh_muc_sp = new System.Windows.Forms.Label();
            this.txt_so_luong_sp = new System.Windows.Forms.TextBox();
            this.lbl_so_luong_sp = new System.Windows.Forms.Label();
            this.txt_nha_sx = new System.Windows.Forms.TextBox();
            this.lbl_nha_san_xuat = new System.Windows.Forms.Label();
            this.cbo_loai_sp = new System.Windows.Forms.ComboBox();
            this.cbo_danh_muc_sp = new System.Windows.Forms.ComboBox();
            this.lstv_nha_cung_cap = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_sua = new System.Windows.Forms.Button();
            this.btn_luu = new System.Windows.Forms.Button();
            this.txt_ten_sp = new System.Windows.Forms.TextBox();
            this.btn_them_ncc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_ma_sp
            // 
            this.lbl_ma_sp.AutoSize = true;
            this.lbl_ma_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ma_sp.Location = new System.Drawing.Point(21, 29);
            this.lbl_ma_sp.Name = "lbl_ma_sp";
            this.lbl_ma_sp.Size = new System.Drawing.Size(105, 20);
            this.lbl_ma_sp.TabIndex = 0;
            this.lbl_ma_sp.Text = "Mã sản phẩm";
            // 
            // txt_ma_sp
            // 
            this.txt_ma_sp.Enabled = false;
            this.txt_ma_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ma_sp.Location = new System.Drawing.Point(25, 52);
            this.txt_ma_sp.Name = "txt_ma_sp";
            this.txt_ma_sp.Size = new System.Drawing.Size(168, 26);
            this.txt_ma_sp.TabIndex = 1;
            // 
            // lbl_ten_sp
            // 
            this.lbl_ten_sp.AutoSize = true;
            this.lbl_ten_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten_sp.Location = new System.Drawing.Point(21, 81);
            this.lbl_ten_sp.Name = "lbl_ten_sp";
            this.lbl_ten_sp.Size = new System.Drawing.Size(110, 20);
            this.lbl_ten_sp.TabIndex = 2;
            this.lbl_ten_sp.Text = "Tên sản phẩm";
            // 
            // lbl_loại_sp
            // 
            this.lbl_loại_sp.AutoSize = true;
            this.lbl_loại_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loại_sp.Location = new System.Drawing.Point(21, 135);
            this.lbl_loại_sp.Name = "lbl_loại_sp";
            this.lbl_loại_sp.Size = new System.Drawing.Size(113, 20);
            this.lbl_loại_sp.TabIndex = 7;
            this.lbl_loại_sp.Text = "Loại sản phẩm";
            // 
            // lbl_danh_muc_sp
            // 
            this.lbl_danh_muc_sp.AutoSize = true;
            this.lbl_danh_muc_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_danh_muc_sp.Location = new System.Drawing.Point(327, 33);
            this.lbl_danh_muc_sp.Name = "lbl_danh_muc_sp";
            this.lbl_danh_muc_sp.Size = new System.Drawing.Size(82, 20);
            this.lbl_danh_muc_sp.TabIndex = 9;
            this.lbl_danh_muc_sp.Text = "Danh mục";
            // 
            // txt_so_luong_sp
            // 
            this.txt_so_luong_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_so_luong_sp.Location = new System.Drawing.Point(331, 104);
            this.txt_so_luong_sp.Name = "txt_so_luong_sp";
            this.txt_so_luong_sp.Size = new System.Drawing.Size(168, 26);
            this.txt_so_luong_sp.TabIndex = 12;
            // 
            // lbl_so_luong_sp
            // 
            this.lbl_so_luong_sp.AutoSize = true;
            this.lbl_so_luong_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_so_luong_sp.Location = new System.Drawing.Point(327, 81);
            this.lbl_so_luong_sp.Name = "lbl_so_luong_sp";
            this.lbl_so_luong_sp.Size = new System.Drawing.Size(72, 20);
            this.lbl_so_luong_sp.TabIndex = 11;
            this.lbl_so_luong_sp.Text = "Số lượng";
            // 
            // txt_nha_sx
            // 
            this.txt_nha_sx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nha_sx.Location = new System.Drawing.Point(331, 156);
            this.txt_nha_sx.Name = "txt_nha_sx";
            this.txt_nha_sx.Size = new System.Drawing.Size(168, 26);
            this.txt_nha_sx.TabIndex = 16;
            // 
            // lbl_nha_san_xuat
            // 
            this.lbl_nha_san_xuat.AutoSize = true;
            this.lbl_nha_san_xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nha_san_xuat.Location = new System.Drawing.Point(327, 133);
            this.lbl_nha_san_xuat.Name = "lbl_nha_san_xuat";
            this.lbl_nha_san_xuat.Size = new System.Drawing.Size(102, 20);
            this.lbl_nha_san_xuat.TabIndex = 15;
            this.lbl_nha_san_xuat.Text = "Nhà sản xuất";
            // 
            // cbo_loai_sp
            // 
            this.cbo_loai_sp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_loai_sp.FormattingEnabled = true;
            this.cbo_loai_sp.Items.AddRange(new object[] {
            "Không bán",
            "Được bán"});
            this.cbo_loai_sp.Location = new System.Drawing.Point(25, 158);
            this.cbo_loai_sp.Name = "cbo_loai_sp";
            this.cbo_loai_sp.Size = new System.Drawing.Size(168, 21);
            this.cbo_loai_sp.TabIndex = 17;
            // 
            // cbo_danh_muc_sp
            // 
            this.cbo_danh_muc_sp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_danh_muc_sp.FormattingEnabled = true;
            this.cbo_danh_muc_sp.Location = new System.Drawing.Point(331, 57);
            this.cbo_danh_muc_sp.Name = "cbo_danh_muc_sp";
            this.cbo_danh_muc_sp.Size = new System.Drawing.Size(168, 21);
            this.cbo_danh_muc_sp.TabIndex = 18;
            // 
            // lstv_nha_cung_cap
            // 
            this.lstv_nha_cung_cap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstv_nha_cung_cap.FullRowSelect = true;
            this.lstv_nha_cung_cap.Location = new System.Drawing.Point(579, 29);
            this.lstv_nha_cung_cap.MultiSelect = false;
            this.lstv_nha_cung_cap.Name = "lstv_nha_cung_cap";
            this.lstv_nha_cung_cap.Size = new System.Drawing.Size(121, 168);
            this.lstv_nha_cung_cap.TabIndex = 19;
            this.lstv_nha_cung_cap.UseCompatibleStateImageBehavior = false;
            this.lstv_nha_cung_cap.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nhà cung cấp";
            this.columnHeader1.Width = 117;
            // 
            // btn_sua
            // 
            this.btn_sua.Location = new System.Drawing.Point(154, 259);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 50);
            this.btn_sua.TabIndex = 20;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = true;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(335, 259);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(94, 50);
            this.btn_luu.TabIndex = 21;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_ten_sp
            // 
            this.txt_ten_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten_sp.Location = new System.Drawing.Point(25, 104);
            this.txt_ten_sp.Name = "txt_ten_sp";
            this.txt_ten_sp.Size = new System.Drawing.Size(168, 26);
            this.txt_ten_sp.TabIndex = 3;
            // 
            // btn_them_ncc
            // 
            this.btn_them_ncc.Location = new System.Drawing.Point(592, 205);
            this.btn_them_ncc.Name = "btn_them_ncc";
            this.btn_them_ncc.Size = new System.Drawing.Size(94, 21);
            this.btn_them_ncc.TabIndex = 22;
            this.btn_them_ncc.Text = "Thêm";
            this.btn_them_ncc.UseVisualStyleBackColor = true;
            this.btn_them_ncc.Click += new System.EventHandler(this.btn_them_ncc_Click);
            // 
            // form_CTSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 321);
            this.Controls.Add(this.btn_them_ncc);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.lstv_nha_cung_cap);
            this.Controls.Add(this.cbo_danh_muc_sp);
            this.Controls.Add(this.cbo_loai_sp);
            this.Controls.Add(this.txt_nha_sx);
            this.Controls.Add(this.lbl_nha_san_xuat);
            this.Controls.Add(this.txt_so_luong_sp);
            this.Controls.Add(this.lbl_so_luong_sp);
            this.Controls.Add(this.lbl_danh_muc_sp);
            this.Controls.Add(this.lbl_loại_sp);
            this.Controls.Add(this.txt_ten_sp);
            this.Controls.Add(this.lbl_ten_sp);
            this.Controls.Add(this.txt_ma_sp);
            this.Controls.Add(this.lbl_ma_sp);
            this.Name = "form_CTSP";
            this.Text = "form_CTSP";
            this.Load += new System.EventHandler(this.form_CTSP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_ma_sp;
        private System.Windows.Forms.TextBox txt_ma_sp;
        private System.Windows.Forms.Label lbl_ten_sp;
        private System.Windows.Forms.Label lbl_loại_sp;
        private System.Windows.Forms.Label lbl_danh_muc_sp;
        private System.Windows.Forms.TextBox txt_so_luong_sp;
        private System.Windows.Forms.Label lbl_so_luong_sp;
        private System.Windows.Forms.TextBox txt_nha_sx;
        private System.Windows.Forms.Label lbl_nha_san_xuat;
        private System.Windows.Forms.ComboBox cbo_loai_sp;
        private System.Windows.Forms.ComboBox cbo_danh_muc_sp;
        private System.Windows.Forms.ListView lstv_nha_cung_cap;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button btn_sua;
        private System.Windows.Forms.Button btn_luu;
        private System.Windows.Forms.TextBox txt_ten_sp;
        private System.Windows.Forms.Button btn_them_ncc;
    }
}