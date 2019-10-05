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
            this.bt_QLHD = new System.Windows.Forms.Button();
            this.bt_QLSP = new System.Windows.Forms.Button();
            this.bt_QLNCC = new System.Windows.Forms.Button();
            this.bt_QLNV = new System.Windows.Forms.Button();
            this.bt_gui_yc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // bt_QLHD
            // 
            this.bt_QLHD.Location = new System.Drawing.Point(302, 148);
            this.bt_QLHD.Name = "bt_QLHD";
            this.bt_QLHD.Size = new System.Drawing.Size(75, 39);
            this.bt_QLHD.TabIndex = 0;
            this.bt_QLHD.Text = "Quản lý hóa đơn";
            this.bt_QLHD.UseVisualStyleBackColor = true;
            // 
            // bt_QLSP
            // 
            this.bt_QLSP.Location = new System.Drawing.Point(571, 148);
            this.bt_QLSP.Name = "bt_QLSP";
            this.bt_QLSP.Size = new System.Drawing.Size(75, 39);
            this.bt_QLSP.TabIndex = 1;
            this.bt_QLSP.Text = "Quản lý sản phẩm";
            this.bt_QLSP.UseVisualStyleBackColor = true;
            // 
            // bt_QLNCC
            // 
            this.bt_QLNCC.Location = new System.Drawing.Point(571, 228);
            this.bt_QLNCC.Name = "bt_QLNCC";
            this.bt_QLNCC.Size = new System.Drawing.Size(75, 39);
            this.bt_QLNCC.TabIndex = 3;
            this.bt_QLNCC.Text = "Quản lý nhà cung cấp";
            this.bt_QLNCC.UseVisualStyleBackColor = true;
            // 
            // bt_QLNV
            // 
            this.bt_QLNV.Location = new System.Drawing.Point(302, 228);
            this.bt_QLNV.Name = "bt_QLNV";
            this.bt_QLNV.Size = new System.Drawing.Size(75, 39);
            this.bt_QLNV.TabIndex = 2;
            this.bt_QLNV.Text = "Quản lý nhân viên";
            this.bt_QLNV.UseVisualStyleBackColor = true;
            // 
            // bt_gui_yc
            // 
            this.bt_gui_yc.Location = new System.Drawing.Point(113, 148);
            this.bt_gui_yc.Name = "bt_gui_yc";
            this.bt_gui_yc.Size = new System.Drawing.Size(75, 39);
            this.bt_gui_yc.TabIndex = 4;
            this.bt_gui_yc.Text = "Gửi yêu cầu";
            this.bt_gui_yc.UseVisualStyleBackColor = true;
            // 
            // Form_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(924, 474);
            this.Controls.Add(this.bt_gui_yc);
            this.Controls.Add(this.bt_QLNCC);
            this.Controls.Add(this.bt_QLNV);
            this.Controls.Add(this.bt_QLSP);
            this.Controls.Add(this.bt_QLHD);
            this.Name = "Form_Menu";
            this.Text = "form_menu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_QLHD;
        private System.Windows.Forms.Button bt_QLSP;
        private System.Windows.Forms.Button bt_QLNCC;
        private System.Windows.Forms.Button bt_QLNV;
        private System.Windows.Forms.Button bt_gui_yc;
    }
}