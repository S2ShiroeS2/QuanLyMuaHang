namespace WindowsFormsApplication1
{
    partial class Form_QLSP
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
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_tao_moi_SP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_tim_kiem_SP
            // 
            this.txt_tim_kiem_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_tim_kiem_SP.Location = new System.Drawing.Point(672, 36);
            this.txt_tim_kiem_SP.Name = "txt_tim_kiem_SP";
            this.txt_tim_kiem_SP.Size = new System.Drawing.Size(244, 30);
            this.txt_tim_kiem_SP.TabIndex = 19;
            // 
            // btn_tim_kiem_SP
            // 
            this.btn_tim_kiem_SP.Location = new System.Drawing.Point(565, 26);
            this.btn_tim_kiem_SP.Name = "btn_tim_kiem_SP";
            this.btn_tim_kiem_SP.Size = new System.Drawing.Size(81, 40);
            this.btn_tim_kiem_SP.TabIndex = 18;
            this.btn_tim_kiem_SP.Text = "Tìm kiếm";
            this.btn_tim_kiem_SP.UseVisualStyleBackColor = true;
            this.btn_tim_kiem_SP.Click += new System.EventHandler(this.btn_tim_kiem_SP_Click);
            // 
            // lstv_list_SP
            // 
            this.lstv_list_SP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lstv_list_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstv_list_SP.Location = new System.Drawing.Point(11, 103);
            this.lstv_list_SP.Name = "lstv_list_SP";
            this.lstv_list_SP.Size = new System.Drawing.Size(907, 242);
            this.lstv_list_SP.TabIndex = 17;
            this.lstv_list_SP.UseCompatibleStateImageBehavior = false;
            this.lstv_list_SP.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã sản phẩm";
            this.columnHeader8.Width = 110;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên sản phẩm";
            this.columnHeader9.Width = 230;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Loại";
            this.columnHeader10.Width = 167;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Danh mục";
            this.columnHeader11.Width = 248;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Số lượng";
            this.columnHeader12.Width = 191;
            // 
            // btn_tao_moi_SP
            // 
            this.btn_tao_moi_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tao_moi_SP.Location = new System.Drawing.Point(12, 26);
            this.btn_tao_moi_SP.Name = "btn_tao_moi_SP";
            this.btn_tao_moi_SP.Size = new System.Drawing.Size(79, 40);
            this.btn_tao_moi_SP.TabIndex = 15;
            this.btn_tao_moi_SP.Text = "Tạo mới";
            this.btn_tao_moi_SP.UseVisualStyleBackColor = true;
            // 
            // Form_QLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 474);
            this.Controls.Add(this.txt_tim_kiem_SP);
            this.Controls.Add(this.btn_tim_kiem_SP);
            this.Controls.Add(this.lstv_list_SP);
            this.Controls.Add(this.btn_tao_moi_SP);
            this.Name = "Form_QLSP";
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
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button btn_tao_moi_SP;
    }
}