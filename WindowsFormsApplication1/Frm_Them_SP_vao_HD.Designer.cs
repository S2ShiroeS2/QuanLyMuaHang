﻿namespace WindowsFormsApplication1
{
    partial class Frm_Them_SP_vao_HD
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
            this.components = new System.ComponentModel.Container();
            this.lbl_Ten_SP = new System.Windows.Forms.Label();
            this.cbo_Ten_SP = new System.Windows.Forms.ComboBox();
            this.txt_So_luong = new System.Windows.Forms.TextBox();
            this.lbl_So_luong = new System.Windows.Forms.Label();
            this.lbl_Nha_CC = new System.Windows.Forms.Label();
            this.txt_Nha_cc = new System.Windows.Forms.TextBox();
            this.lbl_Don_gia = new System.Windows.Forms.Label();
            this.txt_Don_gia = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Thue = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_tien_truoc_thue = new System.Windows.Forms.TextBox();
            this.btn_xac_nhan = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_Tong_tien = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_tien_thue = new System.Windows.Forms.TextBox();
            this.err_so_luong = new System.Windows.Forms.ErrorProvider(this.components);
            this.err_thue = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.err_so_luong)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_thue)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Ten_SP
            // 
            this.lbl_Ten_SP.AutoSize = true;
            this.lbl_Ten_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ten_SP.Location = new System.Drawing.Point(8, 86);
            this.lbl_Ten_SP.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ten_SP.Name = "lbl_Ten_SP";
            this.lbl_Ten_SP.Size = new System.Drawing.Size(110, 20);
            this.lbl_Ten_SP.TabIndex = 0;
            this.lbl_Ten_SP.Text = "Tên sản phẩm";
            // 
            // cbo_Ten_SP
            // 
            this.cbo_Ten_SP.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_Ten_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_Ten_SP.FormattingEnabled = true;
            this.cbo_Ten_SP.Location = new System.Drawing.Point(148, 78);
            this.cbo_Ten_SP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbo_Ten_SP.Name = "cbo_Ten_SP";
            this.cbo_Ten_SP.Size = new System.Drawing.Size(140, 28);
            this.cbo_Ten_SP.TabIndex = 1;
            this.cbo_Ten_SP.SelectedIndexChanged += new System.EventHandler(this.cbo_Ten_SP_SelectedIndexChanged);
            // 
            // txt_So_luong
            // 
            this.txt_So_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_So_luong.Location = new System.Drawing.Point(148, 137);
            this.txt_So_luong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_So_luong.Name = "txt_So_luong";
            this.txt_So_luong.Size = new System.Drawing.Size(72, 26);
            this.txt_So_luong.TabIndex = 2;
            this.txt_So_luong.TextChanged += new System.EventHandler(this.txt_So_luong_TextChanged);
            // 
            // lbl_So_luong
            // 
            this.lbl_So_luong.AutoSize = true;
            this.lbl_So_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_So_luong.Location = new System.Drawing.Point(8, 143);
            this.lbl_So_luong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_So_luong.Name = "lbl_So_luong";
            this.lbl_So_luong.Size = new System.Drawing.Size(72, 20);
            this.lbl_So_luong.TabIndex = 3;
            this.lbl_So_luong.Text = "Số lượng";
            // 
            // lbl_Nha_CC
            // 
            this.lbl_Nha_CC.AutoSize = true;
            this.lbl_Nha_CC.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nha_CC.Location = new System.Drawing.Point(7, 23);
            this.lbl_Nha_CC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nha_CC.Name = "lbl_Nha_CC";
            this.lbl_Nha_CC.Size = new System.Drawing.Size(133, 25);
            this.lbl_Nha_CC.TabIndex = 5;
            this.lbl_Nha_CC.Text = "Nhà cung cấp";
            // 
            // txt_Nha_cc
            // 
            this.txt_Nha_cc.Enabled = false;
            this.txt_Nha_cc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nha_cc.Location = new System.Drawing.Point(148, 18);
            this.txt_Nha_cc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Nha_cc.Name = "txt_Nha_cc";
            this.txt_Nha_cc.Size = new System.Drawing.Size(161, 30);
            this.txt_Nha_cc.TabIndex = 4;
            // 
            // lbl_Don_gia
            // 
            this.lbl_Don_gia.AutoSize = true;
            this.lbl_Don_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Don_gia.Location = new System.Drawing.Point(410, 86);
            this.lbl_Don_gia.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Don_gia.Name = "lbl_Don_gia";
            this.lbl_Don_gia.Size = new System.Drawing.Size(108, 20);
            this.lbl_Don_gia.TabIndex = 7;
            this.lbl_Don_gia.Text = "Đơn giá(VND)";
            // 
            // txt_Don_gia
            // 
            this.txt_Don_gia.Enabled = false;
            this.txt_Don_gia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Don_gia.Location = new System.Drawing.Point(542, 80);
            this.txt_Don_gia.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Don_gia.Name = "txt_Don_gia";
            this.txt_Don_gia.Size = new System.Drawing.Size(80, 26);
            this.txt_Don_gia.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(410, 143);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Thuế(%)";
            // 
            // txt_Thue
            // 
            this.txt_Thue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Thue.Location = new System.Drawing.Point(542, 137);
            this.txt_Thue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Thue.Name = "txt_Thue";
            this.txt_Thue.Size = new System.Drawing.Size(80, 26);
            this.txt_Thue.TabIndex = 8;
            this.txt_Thue.TextChanged += new System.EventHandler(this.txt_Thue_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(431, 201);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(115, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Tiền trước thuế";
            // 
            // txt_tien_truoc_thue
            // 
            this.txt_tien_truoc_thue.Enabled = false;
            this.txt_tien_truoc_thue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tien_truoc_thue.Location = new System.Drawing.Point(606, 196);
            this.txt_tien_truoc_thue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_tien_truoc_thue.Name = "txt_tien_truoc_thue";
            this.txt_tien_truoc_thue.Size = new System.Drawing.Size(133, 26);
            this.txt_tien_truoc_thue.TabIndex = 10;
            // 
            // btn_xac_nhan
            // 
            this.btn_xac_nhan.Location = new System.Drawing.Point(13, 268);
            this.btn_xac_nhan.Name = "btn_xac_nhan";
            this.btn_xac_nhan.Size = new System.Drawing.Size(127, 33);
            this.btn_xac_nhan.TabIndex = 12;
            this.btn_xac_nhan.Text = "Xác nhận";
            this.btn_xac_nhan.UseVisualStyleBackColor = true;
            this.btn_xac_nhan.Click += new System.EventHandler(this.btn_xac_nhan_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(431, 280);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Tổng tiền";
            // 
            // txt_Tong_tien
            // 
            this.txt_Tong_tien.Enabled = false;
            this.txt_Tong_tien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tong_tien.Location = new System.Drawing.Point(606, 274);
            this.txt_Tong_tien.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_Tong_tien.Name = "txt_Tong_tien";
            this.txt_Tong_tien.Size = new System.Drawing.Size(133, 26);
            this.txt_Tong_tien.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(431, 240);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 20);
            this.label4.TabIndex = 16;
            this.label4.Text = "Thuế";
            // 
            // txt_tien_thue
            // 
            this.txt_tien_thue.Enabled = false;
            this.txt_tien_thue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tien_thue.Location = new System.Drawing.Point(606, 234);
            this.txt_tien_thue.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txt_tien_thue.Name = "txt_tien_thue";
            this.txt_tien_thue.Size = new System.Drawing.Size(133, 26);
            this.txt_tien_thue.TabIndex = 15;
            // 
            // err_so_luong
            // 
            this.err_so_luong.ContainerControl = this;
            // 
            // err_thue
            // 
            this.err_thue.ContainerControl = this;
            // 
            // Frm_Them_SP_vao_HD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(752, 313);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_tien_thue);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_Tong_tien);
            this.Controls.Add(this.btn_xac_nhan);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_tien_truoc_thue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Thue);
            this.Controls.Add(this.lbl_Don_gia);
            this.Controls.Add(this.txt_Don_gia);
            this.Controls.Add(this.lbl_Nha_CC);
            this.Controls.Add(this.txt_Nha_cc);
            this.Controls.Add(this.lbl_So_luong);
            this.Controls.Add(this.txt_So_luong);
            this.Controls.Add(this.cbo_Ten_SP);
            this.Controls.Add(this.lbl_Ten_SP);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Frm_Them_SP_vao_HD";
            this.Text = "Frm_Them_SP_vao_HD";
            this.Load += new System.EventHandler(this.Frm_Them_SP_vao_HD_Load);
            ((System.ComponentModel.ISupportInitialize)(this.err_so_luong)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.err_thue)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ten_SP;
        private System.Windows.Forms.ComboBox cbo_Ten_SP;
        private System.Windows.Forms.TextBox txt_So_luong;
        private System.Windows.Forms.Label lbl_So_luong;
        private System.Windows.Forms.Label lbl_Nha_CC;
        private System.Windows.Forms.TextBox txt_Nha_cc;
        private System.Windows.Forms.Label lbl_Don_gia;
        private System.Windows.Forms.TextBox txt_Don_gia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_Thue;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_tien_truoc_thue;
        private System.Windows.Forms.Button btn_xac_nhan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_Tong_tien;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txt_tien_thue;
        private System.Windows.Forms.ErrorProvider err_so_luong;
        private System.Windows.Forms.ErrorProvider err_thue;
    }
}