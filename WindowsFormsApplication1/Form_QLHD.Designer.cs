namespace WindowsFormsApplication1
{
    partial class Form_QLHD
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
            this.tb_search = new System.Windows.Forms.TextBox();
            this.bt_search = new System.Windows.Forms.Button();
            this.lv_list_HD = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_import = new System.Windows.Forms.Button();
            this.bt_tao_moi = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(634, 22);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(244, 30);
            this.tb_search.TabIndex = 17;
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(527, 12);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(81, 40);
            this.bt_search.TabIndex = 16;
            this.bt_search.Text = "Tìm kiếm";
            this.bt_search.UseVisualStyleBackColor = true;
            // 
            // lv_list_HD
            // 
            this.lv_list_HD.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.lv_list_HD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_list_HD.Location = new System.Drawing.Point(5, 69);
            this.lv_list_HD.Name = "lv_list_HD";
            this.lv_list_HD.Size = new System.Drawing.Size(907, 242);
            this.lv_list_HD.TabIndex = 15;
            this.lv_list_HD.UseCompatibleStateImageBehavior = false;
            this.lv_list_HD.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Mã hóa đơn";
            this.columnHeader1.Width = 98;
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
            // columnHeader6
            // 
            this.columnHeader6.Text = "Thuế";
            this.columnHeader6.Width = 135;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tổng tiền";
            this.columnHeader7.Width = 91;
            // 
            // bt_import
            // 
            this.bt_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_import.Location = new System.Drawing.Point(112, 12);
            this.bt_import.Name = "bt_import";
            this.bt_import.Size = new System.Drawing.Size(79, 40);
            this.bt_import.TabIndex = 14;
            this.bt_import.Text = "Tải lên";
            this.bt_import.UseVisualStyleBackColor = true;
            // 
            // bt_tao_moi
            // 
            this.bt_tao_moi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tao_moi.Location = new System.Drawing.Point(7, 12);
            this.bt_tao_moi.Name = "bt_tao_moi";
            this.bt_tao_moi.Size = new System.Drawing.Size(79, 40);
            this.bt_tao_moi.TabIndex = 13;
            this.bt_tao_moi.Text = "Tạo mới";
            this.bt_tao_moi.UseVisualStyleBackColor = true;
            this.bt_tao_moi.Click += new System.EventHandler(this.bt_tao_moi_Click);
            // 
            // Form_QLHD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 474);
            this.Controls.Add(this.tb_search);
            this.Controls.Add(this.bt_search);
            this.Controls.Add(this.lv_list_HD);
            this.Controls.Add(this.bt_import);
            this.Controls.Add(this.bt_tao_moi);
            this.Name = "Form_QLHD";
            this.Text = "Form_QLHD";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button bt_search;
        private System.Windows.Forms.ListView lv_list_HD;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.Button bt_import;
        private System.Windows.Forms.Button bt_tao_moi;
    }
}