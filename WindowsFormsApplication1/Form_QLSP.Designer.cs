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
            this.tb_tim_kiem_SP = new System.Windows.Forms.TextBox();
            this.bt_tim_kiem_SP = new System.Windows.Forms.Button();
            this.lv_SP = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bt_Tai_len_SP = new System.Windows.Forms.Button();
            this.bt_tao_moi_SP = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tb_tim_kiem_SP
            // 
            this.tb_tim_kiem_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_tim_kiem_SP.Location = new System.Drawing.Point(672, 36);
            this.tb_tim_kiem_SP.Name = "tb_tim_kiem_SP";
            this.tb_tim_kiem_SP.Size = new System.Drawing.Size(244, 30);
            this.tb_tim_kiem_SP.TabIndex = 19;
            // 
            // bt_tim_kiem_SP
            // 
            this.bt_tim_kiem_SP.Location = new System.Drawing.Point(565, 26);
            this.bt_tim_kiem_SP.Name = "bt_tim_kiem_SP";
            this.bt_tim_kiem_SP.Size = new System.Drawing.Size(81, 40);
            this.bt_tim_kiem_SP.TabIndex = 18;
            this.bt_tim_kiem_SP.Text = "Tìm kiếm";
            this.bt_tim_kiem_SP.UseVisualStyleBackColor = true;
            // 
            // lv_SP
            // 
            this.lv_SP.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader11,
            this.columnHeader12});
            this.lv_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lv_SP.Location = new System.Drawing.Point(11, 103);
            this.lv_SP.Name = "lv_SP";
            this.lv_SP.Size = new System.Drawing.Size(907, 242);
            this.lv_SP.TabIndex = 17;
            this.lv_SP.UseCompatibleStateImageBehavior = false;
            this.lv_SP.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Mã sản phẩm";
            this.columnHeader8.Width = 133;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Tên sản phẩm";
            this.columnHeader9.Width = 230;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Nhà cung cấp";
            this.columnHeader10.Width = 215;
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Giá";
            this.columnHeader11.Width = 133;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Số lượng";
            this.columnHeader12.Width = 191;
            // 
            // bt_Tai_len_SP
            // 
            this.bt_Tai_len_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Tai_len_SP.Location = new System.Drawing.Point(117, 26);
            this.bt_Tai_len_SP.Name = "bt_Tai_len_SP";
            this.bt_Tai_len_SP.Size = new System.Drawing.Size(79, 40);
            this.bt_Tai_len_SP.TabIndex = 16;
            this.bt_Tai_len_SP.Text = "Tải lên";
            this.bt_Tai_len_SP.UseVisualStyleBackColor = true;
            // 
            // bt_tao_moi_SP
            // 
            this.bt_tao_moi_SP.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_tao_moi_SP.Location = new System.Drawing.Point(12, 26);
            this.bt_tao_moi_SP.Name = "bt_tao_moi_SP";
            this.bt_tao_moi_SP.Size = new System.Drawing.Size(79, 40);
            this.bt_tao_moi_SP.TabIndex = 15;
            this.bt_tao_moi_SP.Text = "Tạo mới";
            this.bt_tao_moi_SP.UseVisualStyleBackColor = true;
            // 
            // Form_QLSP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 474);
            this.Controls.Add(this.tb_tim_kiem_SP);
            this.Controls.Add(this.bt_tim_kiem_SP);
            this.Controls.Add(this.lv_SP);
            this.Controls.Add(this.bt_Tai_len_SP);
            this.Controls.Add(this.bt_tao_moi_SP);
            this.Name = "Form_QLSP";
            this.Text = "Form_QLSP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_tim_kiem_SP;
        private System.Windows.Forms.Button bt_tim_kiem_SP;
        private System.Windows.Forms.ListView lv_SP;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.Button bt_Tai_len_SP;
        private System.Windows.Forms.Button bt_tao_moi_SP;
    }
}