﻿namespace WindowsFormsApplication1
{
    partial class frm_QLHD
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
            this.txt_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.lstv_list_HD = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_tao_moi = new System.Windows.Forms.Button();
            this.btn_xac_nhan_HD = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_search
            // 
            this.txt_search.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_search.Location = new System.Drawing.Point(743, 57);
            this.txt_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_search.Name = "txt_search";
            this.txt_search.Size = new System.Drawing.Size(324, 36);
            this.txt_search.TabIndex = 17;
            this.txt_search.Text = " ";
            // 
            // btn_search
            // 
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(1093, 57);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(108, 36);
            this.btn_search.TabIndex = 16;
            this.btn_search.Text = "Tìm kiếm";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // lstv_list_HD
            // 
            this.lstv_list_HD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstv_list_HD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader7});
            this.lstv_list_HD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstv_list_HD.FullRowSelect = true;
            this.lstv_list_HD.Location = new System.Drawing.Point(9, 101);
            this.lstv_list_HD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstv_list_HD.MultiSelect = false;
            this.lstv_list_HD.Name = "lstv_list_HD";
            this.lstv_list_HD.Size = new System.Drawing.Size(1208, 297);
            this.lstv_list_HD.TabIndex = 15;
            this.lstv_list_HD.UseCompatibleStateImageBehavior = false;
            this.lstv_list_HD.View = System.Windows.Forms.View.Details;
            this.lstv_list_HD.SelectedIndexChanged += new System.EventHandler(this.lstv_list_HD_SelectedIndexChanged);
            this.lstv_list_HD.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstv_list_HD_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã hóa đơn";
            this.columnHeader1.Width = 106;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Ngày đặt hàng";
            this.columnHeader2.Width = 118;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Nhà cung cấp";
            this.columnHeader3.Width = 123;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Nhân viên đặt";
            this.columnHeader4.Width = 146;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Tình trạng";
            this.columnHeader5.Width = 191;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tổng tiền";
            this.columnHeader7.Width = 91;
            // 
            // btn_tao_moi
            // 
            this.btn_tao_moi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tao_moi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tao_moi.Location = new System.Drawing.Point(13, 44);
            this.btn_tao_moi.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_tao_moi.Name = "btn_tao_moi";
            this.btn_tao_moi.Size = new System.Drawing.Size(105, 49);
            this.btn_tao_moi.TabIndex = 13;
            this.btn_tao_moi.Text = "Tạo mới";
            this.btn_tao_moi.UseVisualStyleBackColor = true;
            this.btn_tao_moi.Click += new System.EventHandler(this.bt_tao_moi_Click);
            // 
            // btn_xac_nhan_HD
            // 
            this.btn_xac_nhan_HD.Enabled = false;
            this.btn_xac_nhan_HD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_xac_nhan_HD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xac_nhan_HD.Location = new System.Drawing.Point(9, 406);
            this.btn_xac_nhan_HD.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_xac_nhan_HD.Name = "btn_xac_nhan_HD";
            this.btn_xac_nhan_HD.Size = new System.Drawing.Size(163, 44);
            this.btn_xac_nhan_HD.TabIndex = 18;
            this.btn_xac_nhan_HD.Text = "Xác nhận nhập hàng";
            this.btn_xac_nhan_HD.UseVisualStyleBackColor = true;
            this.btn_xac_nhan_HD.Click += new System.EventHandler(this.btn_xac_nhan_HD_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(1, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 25);
            this.label2.TabIndex = 20;
            this.label2.Text = "Quản lý hóa đơn";
            // 
            // frm_QLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1232, 462);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_xac_nhan_HD);
            this.Controls.Add(this.txt_search);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.lstv_list_HD);
            this.Controls.Add(this.btn_tao_moi);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_QLHD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_QLHD";
            this.Load += new System.EventHandler(this.frm_QLHD_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.ListView lstv_list_HD;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button btn_tao_moi;
        private System.Windows.Forms.Button btn_xac_nhan_HD;
        private System.Windows.Forms.Label label2;
    }
}