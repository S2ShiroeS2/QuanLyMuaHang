namespace WindowsFormsApplication1
{
    partial class Form_Menu
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
            this.TabControl = new System.Windows.Forms.TabControl();
            this.TabP_QLHD = new System.Windows.Forms.TabPage();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_import = new System.Windows.Forms.Button();
            this.bt_tao_moi = new System.Windows.Forms.Button();
            this.TabP_QLSP = new System.Windows.Forms.TabPage();
            this.TabP_QLNCC = new System.Windows.Forms.TabPage();
            this.TabP_QLNV = new System.Windows.Forms.TabPage();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_search = new System.Windows.Forms.Button();
            this.tb_search = new System.Windows.Forms.TextBox();
            this.TabControl.SuspendLayout();
            this.TabP_QLHD.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabControl
            // 
            this.TabControl.Controls.Add(this.TabP_QLHD);
            this.TabControl.Controls.Add(this.TabP_QLSP);
            this.TabControl.Controls.Add(this.TabP_QLNCC);
            this.TabControl.Controls.Add(this.TabP_QLNV);
            this.TabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TabControl.Location = new System.Drawing.Point(0, 0);
            this.TabControl.Name = "TabControl";
            this.TabControl.SelectedIndex = 0;
            this.TabControl.Size = new System.Drawing.Size(924, 475);
            this.TabControl.TabIndex = 0;
            // 
            // TabP_QLHD
            // 
            this.TabP_QLHD.Controls.Add(this.tb_search);
            this.TabP_QLHD.Controls.Add(this.bt_search);
            this.TabP_QLHD.Controls.Add(this.listView1);
            this.TabP_QLHD.Controls.Add(this.bt_import);
            this.TabP_QLHD.Controls.Add(this.bt_tao_moi);
            this.TabP_QLHD.Location = new System.Drawing.Point(4, 29);
            this.TabP_QLHD.Name = "TabP_QLHD";
            this.TabP_QLHD.Padding = new System.Windows.Forms.Padding(3);
            this.TabP_QLHD.Size = new System.Drawing.Size(916, 442);
            this.TabP_QLHD.TabIndex = 0;
            this.TabP_QLHD.Text = "Quản lý hóa đơn";
            this.TabP_QLHD.UseVisualStyleBackColor = true;
            this.TabP_QLHD.Click += new System.EventHandler(this.TabP_QLHD_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView1.Location = new System.Drawing.Point(6, 77);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(907, 242);
            this.listView1.TabIndex = 3;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
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
            // bt_import
            // 
            this.bt_import.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_import.Location = new System.Drawing.Point(113, 20);
            this.bt_import.Name = "bt_import";
            this.bt_import.Size = new System.Drawing.Size(79, 40);
            this.bt_import.TabIndex = 2;
            this.bt_import.Text = "Tải lên";
            this.bt_import.UseVisualStyleBackColor = true;
            // 
            // bt_tao_moi
            // 
            this.bt_tao_moi.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tao_moi.Location = new System.Drawing.Point(8, 20);
            this.bt_tao_moi.Name = "bt_tao_moi";
            this.bt_tao_moi.Size = new System.Drawing.Size(79, 40);
            this.bt_tao_moi.TabIndex = 1;
            this.bt_tao_moi.Text = "Tạo mới";
            this.bt_tao_moi.UseVisualStyleBackColor = true;
            // 
            // TabP_QLSP
            // 
            this.TabP_QLSP.Location = new System.Drawing.Point(4, 29);
            this.TabP_QLSP.Name = "TabP_QLSP";
            this.TabP_QLSP.Padding = new System.Windows.Forms.Padding(3);
            this.TabP_QLSP.Size = new System.Drawing.Size(887, 409);
            this.TabP_QLSP.TabIndex = 1;
            this.TabP_QLSP.Text = "Quản lý sản phẩm";
            this.TabP_QLSP.UseVisualStyleBackColor = true;
            // 
            // TabP_QLNCC
            // 
            this.TabP_QLNCC.Location = new System.Drawing.Point(4, 29);
            this.TabP_QLNCC.Name = "TabP_QLNCC";
            this.TabP_QLNCC.Padding = new System.Windows.Forms.Padding(3);
            this.TabP_QLNCC.Size = new System.Drawing.Size(885, 496);
            this.TabP_QLNCC.TabIndex = 2;
            this.TabP_QLNCC.Text = "Quản lý nhà cung cấp";
            this.TabP_QLNCC.UseVisualStyleBackColor = true;
            // 
            // TabP_QLNV
            // 
            this.TabP_QLNV.Location = new System.Drawing.Point(4, 29);
            this.TabP_QLNV.Name = "TabP_QLNV";
            this.TabP_QLNV.Padding = new System.Windows.Forms.Padding(3);
            this.TabP_QLNV.Size = new System.Drawing.Size(885, 496);
            this.TabP_QLNV.TabIndex = 3;
            this.TabP_QLNV.Text = "Quản lý nhân viên";
            this.TabP_QLNV.UseVisualStyleBackColor = true;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Tổng tiền";
            this.columnHeader7.Width = 91;
            // 
            // bt_search
            // 
            this.bt_search.Location = new System.Drawing.Point(528, 20);
            this.bt_search.Name = "bt_search";
            this.bt_search.Size = new System.Drawing.Size(81, 40);
            this.bt_search.TabIndex = 4;
            this.bt_search.Text = "Tìm kiếm";
            this.bt_search.UseVisualStyleBackColor = true;
            // 
            // tb_search
            // 
            this.tb_search.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_search.Location = new System.Drawing.Point(638, 30);
            this.tb_search.Name = "tb_search";
            this.tb_search.Size = new System.Drawing.Size(199, 30);
            this.tb_search.TabIndex = 12;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 474);
            this.Controls.Add(this.TabControl);
            this.Name = "Form_Menu";
            this.Text = "form_menu";
            this.TabControl.ResumeLayout(false);
            this.TabP_QLHD.ResumeLayout(false);
            this.TabP_QLHD.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl TabControl;
        private System.Windows.Forms.TabPage TabP_QLHD;
        private System.Windows.Forms.TabPage TabP_QLSP;
        private System.Windows.Forms.TabPage TabP_QLNCC;
        private System.Windows.Forms.TabPage TabP_QLNV;
        private System.Windows.Forms.Button bt_tao_moi;
        private System.Windows.Forms.Button bt_import;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.TextBox tb_search;
        private System.Windows.Forms.Button bt_search;
    }
}