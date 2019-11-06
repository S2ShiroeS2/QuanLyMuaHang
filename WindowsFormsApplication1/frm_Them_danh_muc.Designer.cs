namespace WindowsFormsApplication1
{
    partial class frm_Them_danh_muc
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
            this.lbl_Ma_danh_muc = new System.Windows.Forms.Label();
            this.txt_ma_danh_muc = new System.Windows.Forms.TextBox();
            this.txt_Ten_danh_muc = new System.Windows.Forms.TextBox();
            this.lbl_ten_danh_muc = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Ma_danh_muc
            // 
            this.lbl_Ma_danh_muc.AutoSize = true;
            this.lbl_Ma_danh_muc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ma_danh_muc.Location = new System.Drawing.Point(12, 26);
            this.lbl_Ma_danh_muc.Name = "lbl_Ma_danh_muc";
            this.lbl_Ma_danh_muc.Size = new System.Drawing.Size(105, 20);
            this.lbl_Ma_danh_muc.TabIndex = 0;
            this.lbl_Ma_danh_muc.Text = "Mã danh mục";
            // 
            // txt_ma_danh_muc
            // 
            this.txt_ma_danh_muc.Enabled = false;
            this.txt_ma_danh_muc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ma_danh_muc.Location = new System.Drawing.Point(148, 20);
            this.txt_ma_danh_muc.Name = "txt_ma_danh_muc";
            this.txt_ma_danh_muc.Size = new System.Drawing.Size(83, 26);
            this.txt_ma_danh_muc.TabIndex = 1;
            // 
            // txt_Ten_danh_muc
            // 
            this.txt_Ten_danh_muc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten_danh_muc.Location = new System.Drawing.Point(148, 58);
            this.txt_Ten_danh_muc.Name = "txt_Ten_danh_muc";
            this.txt_Ten_danh_muc.Size = new System.Drawing.Size(165, 26);
            this.txt_Ten_danh_muc.TabIndex = 3;
            // 
            // lbl_ten_danh_muc
            // 
            this.lbl_ten_danh_muc.AutoSize = true;
            this.lbl_ten_danh_muc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten_danh_muc.Location = new System.Drawing.Point(12, 64);
            this.lbl_ten_danh_muc.Name = "lbl_ten_danh_muc";
            this.lbl_ten_danh_muc.Size = new System.Drawing.Size(110, 20);
            this.lbl_ten_danh_muc.TabIndex = 2;
            this.lbl_ten_danh_muc.Text = "Tên danh mục";
            // 
            // btn_Luu
            // 
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(16, 137);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(85, 35);
            this.btn_Luu.TabIndex = 4;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // frm_Them_danh_muc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 216);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_Ten_danh_muc);
            this.Controls.Add(this.lbl_ten_danh_muc);
            this.Controls.Add(this.txt_ma_danh_muc);
            this.Controls.Add(this.lbl_Ma_danh_muc);
            this.Name = "frm_Them_danh_muc";
            this.Text = "frm_Them_danh_muc";
            this.Load += new System.EventHandler(this.frm_Them_danh_muc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Ma_danh_muc;
        private System.Windows.Forms.TextBox txt_ma_danh_muc;
        private System.Windows.Forms.TextBox txt_Ten_danh_muc;
        private System.Windows.Forms.Label lbl_ten_danh_muc;
        private System.Windows.Forms.Button btn_Luu;
    }
}