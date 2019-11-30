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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Them_danh_muc));
            this.lbl_Ma_danh_muc = new System.Windows.Forms.Label();
            this.txt_ma_danh_muc = new System.Windows.Forms.TextBox();
            this.txt_Ten_danh_muc = new System.Windows.Forms.TextBox();
            this.lbl_ten_danh_muc = new System.Windows.Forms.Label();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_Ma_danh_muc
            // 
            this.lbl_Ma_danh_muc.AutoSize = true;
            this.lbl_Ma_danh_muc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Ma_danh_muc.Location = new System.Drawing.Point(13, 74);
            this.lbl_Ma_danh_muc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Ma_danh_muc.Name = "lbl_Ma_danh_muc";
            this.lbl_Ma_danh_muc.Size = new System.Drawing.Size(131, 25);
            this.lbl_Ma_danh_muc.TabIndex = 0;
            this.lbl_Ma_danh_muc.Text = "Mã danh mục";
            // 
            // txt_ma_danh_muc
            // 
            this.txt_ma_danh_muc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_ma_danh_muc.Enabled = false;
            this.txt_ma_danh_muc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ma_danh_muc.Location = new System.Drawing.Point(197, 74);
            this.txt_ma_danh_muc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_ma_danh_muc.Name = "txt_ma_danh_muc";
            this.txt_ma_danh_muc.Size = new System.Drawing.Size(109, 30);
            this.txt_ma_danh_muc.TabIndex = 1;
            // 
            // txt_Ten_danh_muc
            // 
            this.txt_Ten_danh_muc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txt_Ten_danh_muc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Ten_danh_muc.Location = new System.Drawing.Point(197, 131);
            this.txt_Ten_danh_muc.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Ten_danh_muc.Name = "txt_Ten_danh_muc";
            this.txt_Ten_danh_muc.Size = new System.Drawing.Size(219, 30);
            this.txt_Ten_danh_muc.TabIndex = 3;
            this.txt_Ten_danh_muc.TextChanged += new System.EventHandler(this.txt_Ten_danh_muc_TextChanged);
            // 
            // lbl_ten_danh_muc
            // 
            this.lbl_ten_danh_muc.AutoSize = true;
            this.lbl_ten_danh_muc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ten_danh_muc.Location = new System.Drawing.Point(13, 134);
            this.lbl_ten_danh_muc.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_ten_danh_muc.Name = "lbl_ten_danh_muc";
            this.lbl_ten_danh_muc.Size = new System.Drawing.Size(138, 25);
            this.lbl_ten_danh_muc.TabIndex = 2;
            this.lbl_ten_danh_muc.Text = "Tên danh mục";
            // 
            // btn_Luu
            // 
            this.btn_Luu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Luu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Luu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Luu.Location = new System.Drawing.Point(149, 177);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(113, 43);
            this.btn_Luu.TabIndex = 4;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = false;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 25);
            this.label1.TabIndex = 5;
            this.label1.Text = "Thêm danh mục";
            // 
            // frm_Them_danh_muc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(433, 233);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.txt_Ten_danh_muc);
            this.Controls.Add(this.lbl_ten_danh_muc);
            this.Controls.Add(this.txt_ma_danh_muc);
            this.Controls.Add(this.lbl_Ma_danh_muc);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Them_danh_muc";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.Label label1;
    }
}