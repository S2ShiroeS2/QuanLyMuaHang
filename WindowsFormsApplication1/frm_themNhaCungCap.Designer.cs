namespace WindowsFormsApplication1
{
    partial class frm_themNhaCungCap
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
            this.btn_add_all = new System.Windows.Forms.Button();
            this.btn_delete = new System.Windows.Forms.Button();
            this.lstv_list_ncc_co = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lsvt_list_ncc_them = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_luu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_add_one
            // 
            this.btn_add_one.Location = new System.Drawing.Point(138, 118);
            this.btn_add_one.Name = "btn_add_one";
            this.btn_add_one.Size = new System.Drawing.Size(75, 23);
            this.btn_add_one.TabIndex = 2;
            this.btn_add_one.Text = ">";
            this.btn_add_one.UseVisualStyleBackColor = true;
            this.btn_add_one.Click += new System.EventHandler(this.btn_add_one_Click);
            // 
            // btn_add_all
            // 
            this.btn_add_all.Location = new System.Drawing.Point(138, 147);
            this.btn_add_all.Name = "btn_add_all";
            this.btn_add_all.Size = new System.Drawing.Size(75, 23);
            this.btn_add_all.TabIndex = 3;
            this.btn_add_all.Text = ">>";
            this.btn_add_all.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            this.btn_delete.Location = new System.Drawing.Point(138, 176);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(75, 23);
            this.btn_delete.TabIndex = 4;
            this.btn_delete.Text = "Xóa";
            this.btn_delete.UseVisualStyleBackColor = true;
            // 
            // lstv_list_ncc_co
            // 
            this.lstv_list_ncc_co.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.lstv_list_ncc_co.FullRowSelect = true;
            this.lstv_list_ncc_co.Location = new System.Drawing.Point(12, 12);
            this.lstv_list_ncc_co.Name = "lstv_list_ncc_co";
            this.lstv_list_ncc_co.Size = new System.Drawing.Size(121, 321);
            this.lstv_list_ncc_co.TabIndex = 5;
            this.lstv_list_ncc_co.UseCompatibleStateImageBehavior = false;
            this.lstv_list_ncc_co.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Nhà cung cấp sẵn có";
            this.columnHeader1.Width = 115;
            // 
            // lsvt_list_ncc_them
            // 
            this.lsvt_list_ncc_them.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.lsvt_list_ncc_them.FullRowSelect = true;
            this.lsvt_list_ncc_them.Location = new System.Drawing.Point(218, 12);
            this.lsvt_list_ncc_them.Name = "lsvt_list_ncc_them";
            this.lsvt_list_ncc_them.Size = new System.Drawing.Size(121, 321);
            this.lsvt_list_ncc_them.TabIndex = 6;
            this.lsvt_list_ncc_them.UseCompatibleStateImageBehavior = false;
            this.lsvt_list_ncc_them.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nhà cung cấp thêm";
            this.columnHeader2.Width = 114;
            // 
            // btn_luu
            // 
            this.btn_luu.Location = new System.Drawing.Point(137, 205);
            this.btn_luu.Name = "btn_luu";
            this.btn_luu.Size = new System.Drawing.Size(75, 23);
            this.btn_luu.TabIndex = 7;
            this.btn_luu.Text = "Lưu";
            this.btn_luu.UseVisualStyleBackColor = true;
            this.btn_luu.Click += new System.EventHandler(this.btn_luu_Click);
            // 
            // frm_themNhaCungCap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(351, 345);
            this.Controls.Add(this.btn_luu);
            this.Controls.Add(this.lsvt_list_ncc_them);
            this.Controls.Add(this.lstv_list_ncc_co);
            this.Controls.Add(this.btn_delete);
            this.Controls.Add(this.btn_add_all);
            this.Controls.Add(this.btn_add_one);
            this.Name = "frm_themNhaCungCap";
            this.Text = "Thêm nhà cung cấp";
            this.Load += new System.EventHandler(this.frm_themNhaCungCap_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_add_one;
        private System.Windows.Forms.Button btn_add_all;
        private System.Windows.Forms.Button btn_delete;
        private System.Windows.Forms.ListView lstv_list_ncc_co;
        private System.Windows.Forms.ListView lsvt_list_ncc_them;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button btn_luu;
    }
}