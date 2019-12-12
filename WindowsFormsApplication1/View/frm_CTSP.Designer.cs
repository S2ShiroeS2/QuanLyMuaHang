namespace WindowsFormsApplication1
{
    partial class frm_CTSP
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_CTSP));
            this.lbl_ma_sp = new System.Windows.Forms.Label();
            this.txt_ma_sp = new System.Windows.Forms.TextBox();
            this.lbl_ten_sp = new System.Windows.Forms.Label();
            this.lbl_loại_sp = new System.Windows.Forms.Label();
            this.lbl_danh_muc_sp = new System.Windows.Forms.Label();
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
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_ma_sp
            // 
            this.lbl_ma_sp.AutoSize = true;
            this.lbl_ma_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ma_sp.Location = new System.Drawing.Point(26, 45);
            this.lbl_ma_sp.Name = "lbl_ma_sp";
            this.lbl_ma_sp.Size = new System.Drawing.Size(105, 20);
            this.lbl_ma_sp.TabIndex = 0;
            this.lbl_ma_sp.Text = "Mã sản phẩm";
            // 
            // txt_ma_sp
            // 
            this.txt_ma_sp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_ma_sp.Enabled = false;
            this.txt_ma_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ma_sp.Location = new System.Drawing.Point(137, 39);
            this.txt_ma_sp.Name = "txt_ma_sp";
            this.txt_ma_sp.Size = new System.Drawing.Size(168, 26);
            this.txt_ma_sp.TabIndex = 1;
            // 
            // lbl_ten_sp
            // 
            this.lbl_ten_sp.AutoSize = true;
            this.lbl_ten_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten_sp.Location = new System.Drawing.Point(26, 86);
            this.lbl_ten_sp.Name = "lbl_ten_sp";
            this.lbl_ten_sp.Size = new System.Drawing.Size(110, 20);
            this.lbl_ten_sp.TabIndex = 2;
            this.lbl_ten_sp.Text = "Tên sản phẩm";
            // 
            // lbl_loại_sp
            // 
            this.lbl_loại_sp.AutoSize = true;
            this.lbl_loại_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_loại_sp.Location = new System.Drawing.Point(26, 168);
            this.lbl_loại_sp.Name = "lbl_loại_sp";
            this.lbl_loại_sp.Size = new System.Drawing.Size(113, 20);
            this.lbl_loại_sp.TabIndex = 7;
            this.lbl_loại_sp.Text = "Loại sản phẩm";
            // 
            // lbl_danh_muc_sp
            // 
            this.lbl_danh_muc_sp.AutoSize = true;
            this.lbl_danh_muc_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_danh_muc_sp.Location = new System.Drawing.Point(313, 168);
            this.lbl_danh_muc_sp.Name = "lbl_danh_muc_sp";
            this.lbl_danh_muc_sp.Size = new System.Drawing.Size(82, 20);
            this.lbl_danh_muc_sp.TabIndex = 9;
            this.lbl_danh_muc_sp.Text = "Danh mục";
            // 
            // txt_nha_sx
            // 
            this.txt_nha_sx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_nha_sx.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nha_sx.Location = new System.Drawing.Point(30, 248);
            this.txt_nha_sx.Name = "txt_nha_sx";
            this.txt_nha_sx.Size = new System.Drawing.Size(275, 26);
            this.txt_nha_sx.TabIndex = 16;
            // 
            // lbl_nha_san_xuat
            // 
            this.lbl_nha_san_xuat.AutoSize = true;
            this.lbl_nha_san_xuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nha_san_xuat.Location = new System.Drawing.Point(29, 225);
            this.lbl_nha_san_xuat.Name = "lbl_nha_san_xuat";
            this.lbl_nha_san_xuat.Size = new System.Drawing.Size(102, 20);
            this.lbl_nha_san_xuat.TabIndex = 15;
            this.lbl_nha_san_xuat.Text = "Nhà sản xuất";
            // 
            // cbo_loai_sp
            // 
            this.cbo_loai_sp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbo_loai_sp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_loai_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_loai_sp.FormattingEnabled = true;
            this.cbo_loai_sp.Items.AddRange(new object[] {
            "Không bán",
            "Được bán"});
            this.cbo_loai_sp.Location = new System.Drawing.Point(30, 191);
            this.cbo_loai_sp.Name = "cbo_loai_sp";
            this.cbo_loai_sp.Size = new System.Drawing.Size(168, 28);
            this.cbo_loai_sp.TabIndex = 17;
            // 
            // cbo_danh_muc_sp
            // 
            this.cbo_danh_muc_sp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cbo_danh_muc_sp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_danh_muc_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_danh_muc_sp.FormattingEnabled = true;
            this.cbo_danh_muc_sp.Location = new System.Drawing.Point(317, 191);
            this.cbo_danh_muc_sp.Name = "cbo_danh_muc_sp";
            this.cbo_danh_muc_sp.Size = new System.Drawing.Size(168, 28);
            this.cbo_danh_muc_sp.TabIndex = 18;
            this.cbo_danh_muc_sp.SelectedIndexChanged += new System.EventHandler(this.cbo_danh_muc_sp_SelectedIndexChanged);
            // 
            // lstv_nha_cung_cap
            // 
            this.lstv_nha_cung_cap.BackColor = System.Drawing.Color.White;
            this.lstv_nha_cung_cap.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstv_nha_cung_cap.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstv_nha_cung_cap.FullRowSelect = true;
            this.lstv_nha_cung_cap.Location = new System.Drawing.Point(602, 61);
            this.lstv_nha_cung_cap.MultiSelect = false;
            this.lstv_nha_cung_cap.Name = "lstv_nha_cung_cap";
            this.lstv_nha_cung_cap.Size = new System.Drawing.Size(149, 168);
            this.lstv_nha_cung_cap.TabIndex = 19;
            this.lstv_nha_cung_cap.UseCompatibleStateImageBehavior = false;
            this.lstv_nha_cung_cap.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nhà cung cấp";
            this.columnHeader1.Width = 143;
            // 
            // btn_sua
            // 
            this.btn_sua.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sua.Location = new System.Drawing.Point(150, 293);
            this.btn_sua.Name = "btn_sua";
            this.btn_sua.Size = new System.Drawing.Size(94, 58);
            this.btn_sua.TabIndex = 20;
            this.btn_sua.Text = "Sửa";
            this.btn_sua.UseVisualStyleBackColor = false;
            this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
            // 
            // btn_luu
            // 
            this.btn_luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(329, 293);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(94, 58);
            this.btn_luu.TabIndex = 21;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = false;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // txt_ten_sp
            // 
            this.txt_ten_sp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_ten_sp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ten_sp.Location = new System.Drawing.Point(30, 124);
            this.txt_ten_sp.Name = "txt_ten_sp";
            this.txt_ten_sp.Size = new System.Drawing.Size(455, 26);
            this.txt_ten_sp.TabIndex = 3;
            // 
            // btn_them_ncc
            // 
            this.btn_them_ncc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_them_ncc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_them_ncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_them_ncc.Location = new System.Drawing.Point(602, 235);
            this.btn_them_ncc.Name = "btn_them_ncc";
            this.btn_them_ncc.Size = new System.Drawing.Size(140, 28);
            this.btn_them_ncc.TabIndex = 22;
            this.btn_them_ncc.Text = "Thêm nhà cung cấp";
            this.btn_them_ncc.UseVisualStyleBackColor = false;
            this.btn_them_ncc.Click += new System.EventHandler(this.btn_them_ncc_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(149, 20);
            this.label8.TabIndex = 38;
            this.label8.Text = "Chi tiết sản phẩm";
            // 
            // frm_CTSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(802, 352);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btn_them_ncc);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.btn_sua);
            this.Controls.Add(this.lstv_nha_cung_cap);
            this.Controls.Add(this.cbo_danh_muc_sp);
            this.Controls.Add(this.cbo_loai_sp);
            this.Controls.Add(this.txt_nha_sx);
            this.Controls.Add(this.lbl_nha_san_xuat);
            this.Controls.Add(this.lbl_danh_muc_sp);
            this.Controls.Add(this.lbl_loại_sp);
            this.Controls.Add(this.txt_ten_sp);
            this.Controls.Add(this.lbl_ten_sp);
            this.Controls.Add(this.txt_ma_sp);
            this.Controls.Add(this.lbl_ma_sp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_CTSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "S";
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
        private System.Windows.Forms.Label label8;
    }
}