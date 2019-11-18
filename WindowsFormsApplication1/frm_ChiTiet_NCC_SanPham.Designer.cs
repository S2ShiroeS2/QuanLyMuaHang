namespace WindowsFormsApplication1
{
    partial class frm_ChiTiet_NCC_SanPham
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
            this.btn_add_one = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lstv_list_ncc_co = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstv_list_ncc_them = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_luu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add_one
            // 
            this.btn_add_one.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_one.Location = new System.Drawing.Point(185, 193);
            this.btn_add_one.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_add_one.Name = "btn_add_one";
            this.btn_add_one.Size = new System.Drawing.Size(100, 38);
            this.btn_add_one.TabIndex = 2;
            this.btn_add_one.Text = ">";
            this.btn_add_one.UseVisualStyleBackColor = true;
            this.btn_add_one.Click += new System.EventHandler(this.btn_add_one_Click);
            // 
            // btn_delete
            // 
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(185, 229);
            this.btn_delete.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(100, 38);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // lstv_list_ncc_co
            // 
            this.lstv_list_ncc_co.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstv_list_ncc_co.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstv_list_ncc_co.FullRowSelect = true;
            this.lstv_list_ncc_co.Location = new System.Drawing.Point(16, 65);
            this.lstv_list_ncc_co.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstv_list_ncc_co.Name = "lstv_list_ncc_co";
            this.lstv_list_ncc_co.Size = new System.Drawing.Size(160, 344);
            this.lstv_list_ncc_co.TabIndex = 5;
            this.lstv_list_ncc_co.UseCompatibleStateImageBehavior = false;
            this.lstv_list_ncc_co.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nhà cung cấp sẵn có";
            this.columnHeader1.Width = 115;
            // 
            // lstv_list_ncc_them
            // 
            this.lstv_list_ncc_them.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstv_list_ncc_them.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lstv_list_ncc_them.FullRowSelect = true;
            this.lstv_list_ncc_them.Location = new System.Drawing.Point(291, 65);
            this.lstv_list_ncc_them.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lstv_list_ncc_them.Name = "lstv_list_ncc_them";
            this.lstv_list_ncc_them.Size = new System.Drawing.Size(160, 344);
            this.lstv_list_ncc_them.TabIndex = 6;
            this.lstv_list_ncc_them.UseCompatibleStateImageBehavior = false;
            this.lstv_list_ncc_them.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nhà cung cấp thêm";
            this.columnHeader2.Width = 114;
            // 
            // btn_luu
            // 
            this.btn_luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_luu.Location = new System.Drawing.Point(185, 265);
            this.btn_luu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(100, 38);
            this.btn_luu.TabIndex = 7;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // frm_ChiTiet_NCC_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(468, 425);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.lstv_list_ncc_them);
            this.Controls.Add(this.lstv_list_ncc_co);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add_one);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frm_ChiTiet_NCC_SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thêm nhà cung cấp";
            this.Load += new System.EventHandler(this.frm_themNhaCungCap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add_one;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ListView lstv_list_ncc_co;
        private System.Windows.Forms.ListView lstv_list_ncc_them;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btn_luu;
    }
}