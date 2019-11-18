namespace WindowsFormsApplication1
{
    partial class frm_QLSP
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
            this.txt_tim_kiem_SP = new System.Windows.Forms.TextBox();
            this.btn_tim_kiem_SP = new System.Windows.Forms.Button();
            this.lstv_list_SP = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_tao_moi_SP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_tim_kiem_SP
            // 
            this.txt_tim_kiem_SP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_tim_kiem_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim_kiem_SP.Location = new System.Drawing.Point(769, 61);
            this.txt_tim_kiem_SP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_tim_kiem_SP.Name = "txt_tim_kiem_SP";
            this.txt_tim_kiem_SP.Size = new System.Drawing.Size(324, 36);
            this.txt_tim_kiem_SP.TabIndex = 19;
            // 
            // btn_tim_kiem_SP
            // 
            this.btn_tim_kiem_SP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tim_kiem_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tim_kiem_SP.Location = new System.Drawing.Point(1116, 62);
            this.btn_tim_kiem_SP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tim_kiem_SP.Name = "btn_tim_kiem_SP";
            this.btn_tim_kiem_SP.Size = new System.Drawing.Size(108, 36);
            this.btn_tim_kiem_SP.TabIndex = 18;
            this.btn_tim_kiem_SP.Text = "Tìm";
            this.btn_tim_kiem_SP.UseVisualStyleBackColor = true;
            this.btn_tim_kiem_SP.Click += new System.EventHandler(this.btn_tim_kiem_SP_Click);
            // 
            // lstv_list_SP
            // 
            this.lstv_list_SP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lstv_list_SP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader2});
            this.lstv_list_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstv_list_SP.FullRowSelect = true;
            this.lstv_list_SP.Location = new System.Drawing.Point(16, 122);
            this.lstv_list_SP.Margin = new System.Windows.Forms.Padding(4);
            this.lstv_list_SP.MultiSelect = false;
            this.lstv_list_SP.Name = "lstv_list_SP";
            this.lstv_list_SP.Size = new System.Drawing.Size(1208, 297);
            this.lstv_list_SP.TabIndex = 17;
            this.lstv_list_SP.UseCompatibleStateImageBehavior = false;
            this.lstv_list_SP.View = System.Windows.Forms.View.Details;
            this.lstv_list_SP.SelectedIndexChanged += new System.EventHandler(this.lstv_list_SP_SelectedIndexChanged);
            this.lstv_list_SP.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstv_list_SP_MouseDoubleClick);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã sản phẩm";
            this.columnHeader8.Width = 153;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên sản phẩm";
            this.columnHeader9.Width = 191;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Loại";
            this.columnHeader10.Width = 150;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Danh mục";
            this.columnHeader11.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Nhà sản xuất";
            this.columnHeader2.Width = 267;
            // 
            // btn_tao_moi_SP
            // 
            this.btn_tao_moi_SP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_tao_moi_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tao_moi_SP.Location = new System.Drawing.Point(13, 56);
            this.btn_tao_moi_SP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_tao_moi_SP.Name = "btn_tao_moi_SP";
            this.btn_tao_moi_SP.Size = new System.Drawing.Size(105, 41);
            this.btn_tao_moi_SP.TabIndex = 15;
            this.btn_tao_moi_SP.Text = "Tạo mới";
            this.btn_tao_moi_SP.UseVisualStyleBackColor = true;
            this.btn_tao_moi_SP.Click += new System.EventHandler(this.btn_tao_moi_SP_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(766, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "Tìm kiếm theo tên";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(11, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(187, 25);
            this.label2.TabIndex = 27;
            this.label2.Text = "Quản lý sản phẩm";
            // 
            // frm_QLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1232, 428);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_tim_kiem_SP);
            this.Controls.Add(this.btn_tim_kiem_SP);
            this.Controls.Add(this.lstv_list_SP);
            this.Controls.Add(this.btn_tao_moi_SP);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_QLSP";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_QLSP";
            this.Load += new System.EventHandler(this.Form_QLSP_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_tim_kiem_SP;
        private System.Windows.Forms.Button btn_tim_kiem_SP;
        private System.Windows.Forms.ListView lstv_list_SP;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.Button btn_tao_moi_SP;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}