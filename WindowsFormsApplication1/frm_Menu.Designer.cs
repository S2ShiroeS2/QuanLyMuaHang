namespace WindowsFormsApplication1
{
    partial class frm_Menu
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
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_QLHD = new System.Windows.Forms.Button();
            this.btn_QLSP = new System.Windows.Forms.Button();
            this.btn_QLNV = new System.Windows.Forms.Button();
            this.btn_QLNCC = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_LogOut.Location = new System.Drawing.Point(1006, 12);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(112, 38);
            this.btn_LogOut.TabIndex = 0;
            this.btn_LogOut.Text = "Đăng xuất";
            this.btn_LogOut.UseVisualStyleBackColor = true;
            // 
            // btn_QLHD
            // 
            this.btn_QLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_QLHD.Location = new System.Drawing.Point(129, 198);
            this.btn_QLHD.Name = "btn_QLHD";
            this.btn_QLHD.Size = new System.Drawing.Size(173, 63);
            this.btn_QLHD.TabIndex = 1;
            this.btn_QLHD.Text = "Quản lý hóa đơn";
            this.btn_QLHD.UseVisualStyleBackColor = true;
            // 
            // btn_QLSP
            // 
            this.btn_QLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_QLSP.Location = new System.Drawing.Point(328, 198);
            this.btn_QLSP.Name = "btn_QLSP";
            this.btn_QLSP.Size = new System.Drawing.Size(205, 63);
            this.btn_QLSP.TabIndex = 2;
            this.btn_QLSP.Text = "Quản lý sản phẩm";
            this.btn_QLSP.UseVisualStyleBackColor = true;
            // 
            // btn_QLNV
            // 
            this.btn_QLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_QLNV.Location = new System.Drawing.Point(805, 198);
            this.btn_QLNV.Name = "btn_QLNV";
            this.btn_QLNV.Size = new System.Drawing.Size(187, 63);
            this.btn_QLNV.TabIndex = 3;
            this.btn_QLNV.Text = "Quản lý nhân viên";
            this.btn_QLNV.UseVisualStyleBackColor = true;
            // 
            // btn_QLNCC
            // 
            this.btn_QLNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_QLNCC.Location = new System.Drawing.Point(555, 198);
            this.btn_QLNCC.Name = "btn_QLNCC";
            this.btn_QLNCC.Size = new System.Drawing.Size(230, 63);
            this.btn_QLNCC.TabIndex = 4;
            this.btn_QLNCC.Text = "Quản lý nhà cung cấp";
            this.btn_QLNCC.UseVisualStyleBackColor = true;
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 505);
            this.Controls.Add(this.btn_QLNCC);
            this.Controls.Add(this.btn_QLNV);
            this.Controls.Add(this.btn_QLSP);
            this.Controls.Add(this.btn_QLHD);
            this.Controls.Add(this.btn_LogOut);
            this.Name = "frm_Menu";
            this.Text = "frm_Menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_QLHD;
        private System.Windows.Forms.Button btn_QLSP;
        private System.Windows.Forms.Button btn_QLNV;
        private System.Windows.Forms.Button btn_QLNCC;
    }
}