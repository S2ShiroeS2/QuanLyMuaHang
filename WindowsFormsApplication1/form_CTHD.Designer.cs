namespace WindowsFormsApplication1
{
    partial class form_CTHD
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
            this.tb_Ma_HD = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_NCC = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpk_ngay_dat_hang = new System.Windows.Forms.DateTimePicker();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tb_tong_tien_HD_khong_thue = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_Thue_HD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_Tong_tien_HD = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_hanh_dong = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Chi tiết hóa đơn";
            // 
            // tb_Ma_HD
            // 
            this.tb_Ma_HD.Enabled = false;
            this.tb_Ma_HD.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Ma_HD.Location = new System.Drawing.Point(12, 36);
            this.tb_Ma_HD.Name = "tb_Ma_HD";
            this.tb_Ma_HD.Size = new System.Drawing.Size(100, 29);
            this.tb_Ma_HD.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(107, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nhà cung cấp";
            // 
            // tb_NCC
            // 
            this.tb_NCC.Enabled = false;
            this.tb_NCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NCC.Location = new System.Drawing.Point(142, 81);
            this.tb_NCC.Name = "tb_NCC";
            this.tb_NCC.Size = new System.Drawing.Size(175, 29);
            this.tb_NCC.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(459, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Ngày đặt hàng";
            // 
            // dtpk_ngay_dat_hang
            // 
            this.dtpk_ngay_dat_hang.Enabled = false;
            this.dtpk_ngay_dat_hang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpk_ngay_dat_hang.Location = new System.Drawing.Point(586, 84);
            this.dtpk_ngay_dat_hang.Name = "dtpk_ngay_dat_hang";
            this.dtpk_ngay_dat_hang.Size = new System.Drawing.Size(273, 26);
            this.dtpk_ngay_dat_hang.TabIndex = 6;
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.OneClick;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader6,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(12, 138);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(900, 197);
            this.listView1.TabIndex = 7;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã hóa đơn";
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
            this.columnHeader3.Width = 104;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Thuế";
            this.columnHeader4.Width = 107;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tổng tiền";
            this.columnHeader5.Width = 130;
            // 
            // tb_tong_tien_HD_khong_thue
            // 
            this.tb_tong_tien_HD_khong_thue.Enabled = false;
            this.tb_tong_tien_HD_khong_thue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tong_tien_HD_khong_thue.Location = new System.Drawing.Point(728, 351);
            this.tb_tong_tien_HD_khong_thue.Name = "tb_tong_tien_HD_khong_thue";
            this.tb_tong_tien_HD_khong_thue.Size = new System.Drawing.Size(175, 22);
            this.tb_tong_tien_HD_khong_thue.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(611, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Tiền trước thuế";
            // 
            // tb_Thue_HD
            // 
            this.tb_Thue_HD.Enabled = false;
            this.tb_Thue_HD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Thue_HD.Location = new System.Drawing.Point(728, 395);
            this.tb_Thue_HD.Name = "tb_Thue_HD";
            this.tb_Thue_HD.Size = new System.Drawing.Size(175, 22);
            this.tb_Thue_HD.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(611, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 16);
            this.label5.TabIndex = 10;
            this.label5.Text = "Thuế";
            // 
            // tb_Tong_tien_HD
            // 
            this.tb_Tong_tien_HD.Enabled = false;
            this.tb_Tong_tien_HD.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Tong_tien_HD.Location = new System.Drawing.Point(728, 440);
            this.tb_Tong_tien_HD.Name = "tb_Tong_tien_HD";
            this.tb_Tong_tien_HD.Size = new System.Drawing.Size(175, 22);
            this.tb_Tong_tien_HD.TabIndex = 13;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(611, 446);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 16);
            this.label6.TabIndex = 12;
            this.label6.Text = "Tổng tiền";
            // 
            // cb_hanh_dong
            // 
            this.cb_hanh_dong.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_hanh_dong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_hanh_dong.FormattingEnabled = true;
            this.cb_hanh_dong.Items.AddRange(new object[] {
            "Hành động",
            "Sửa hóa đơn",
            "Xóa hóa đơn"});
            this.cb_hanh_dong.Location = new System.Drawing.Point(728, 12);
            this.cb_hanh_dong.Name = "cb_hanh_dong";
            this.cb_hanh_dong.Size = new System.Drawing.Size(121, 28);
            this.cb_hanh_dong.TabIndex = 14;
            this.cb_hanh_dong.Tag = "";
            this.cb_hanh_dong.SelectedIndexChanged += new System.EventHandler(this.cb_hanh_dong_SelectedIndexChanged);
            // 
            // form_CTHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 474);
            this.Controls.Add(this.cb_hanh_dong);
            this.Controls.Add(this.tb_Tong_tien_HD);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tb_Thue_HD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.tb_tong_tien_HD_khong_thue);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.dtpk_ngay_dat_hang);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_NCC);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_Ma_HD);
            this.Controls.Add(this.label1);
            this.Name = "form_CTHD";
            this.Text = "form_CTHD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_Ma_HD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_NCC;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpk_ngay_dat_hang;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.TextBox tb_tong_tien_HD_khong_thue;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_Thue_HD;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_Tong_tien_HD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_hanh_dong;
    }
}