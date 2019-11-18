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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Menu));
            this.btn_LogOut = new System.Windows.Forms.Button();
            this.btn_QLHD = new System.Windows.Forms.Button();
            this.btn_QLSP = new System.Windows.Forms.Button();
            this.btn_QLNV = new System.Windows.Forms.Button();
            this.btn_QLNCC = new System.Windows.Forms.Button();
            this.btn_ChangeInform = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_LogOut
            // 
            this.btn_LogOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_LogOut.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_LogOut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_LogOut.ForeColor = System.Drawing.Color.Black;
            this.btn_LogOut.Location = new System.Drawing.Point(324, 425);
            this.btn_LogOut.Name = "btn_LogOut";
            this.btn_LogOut.Size = new System.Drawing.Size(230, 38);
            this.btn_LogOut.TabIndex = 0;
            this.btn_LogOut.Text = "Đăng xuất";
            this.btn_LogOut.UseVisualStyleBackColor = false;
            this.btn_LogOut.Click += new System.EventHandler(this.btn_LogOut_Click);
            // 
            // btn_QLHD
            // 
            this.btn_QLHD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_QLHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_QLHD.ForeColor = System.Drawing.Color.Black;
            this.btn_QLHD.Location = new System.Drawing.Point(324, 218);
            this.btn_QLHD.Name = "btn_QLHD";
            this.btn_QLHD.Size = new System.Drawing.Size(230, 63);
            this.btn_QLHD.TabIndex = 1;
            this.btn_QLHD.Text = "Quản lý hóa đơn";
            this.btn_QLHD.UseVisualStyleBackColor = false;
            this.btn_QLHD.Click += new System.EventHandler(this.btn_QLHD_Click);
            // 
            // btn_QLSP
            // 
            this.btn_QLSP.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_QLSP.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLSP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_QLSP.ForeColor = System.Drawing.Color.Black;
            this.btn_QLSP.Location = new System.Drawing.Point(324, 304);
            this.btn_QLSP.Name = "btn_QLSP";
            this.btn_QLSP.Size = new System.Drawing.Size(230, 63);
            this.btn_QLSP.TabIndex = 2;
            this.btn_QLSP.Text = "Quản lý sản phẩm";
            this.btn_QLSP.UseVisualStyleBackColor = false;
            this.btn_QLSP.Click += new System.EventHandler(this.btn_QLSP_Click);
            // 
            // btn_QLNV
            // 
            this.btn_QLNV.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_QLNV.Enabled = false;
            this.btn_QLNV.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_QLNV.ForeColor = System.Drawing.Color.Black;
            this.btn_QLNV.Location = new System.Drawing.Point(12, 218);
            this.btn_QLNV.Name = "btn_QLNV";
            this.btn_QLNV.Size = new System.Drawing.Size(230, 63);
            this.btn_QLNV.TabIndex = 3;
            this.btn_QLNV.Text = "Quản lý nhân viên";
            this.btn_QLNV.UseVisualStyleBackColor = false;
            this.btn_QLNV.Click += new System.EventHandler(this.btn_QLNV_Click);
            // 
            // btn_QLNCC
            // 
            this.btn_QLNCC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_QLNCC.Enabled = false;
            this.btn_QLNCC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_QLNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_QLNCC.ForeColor = System.Drawing.Color.Black;
            this.btn_QLNCC.Location = new System.Drawing.Point(12, 304);
            this.btn_QLNCC.Name = "btn_QLNCC";
            this.btn_QLNCC.Size = new System.Drawing.Size(230, 63);
            this.btn_QLNCC.TabIndex = 4;
            this.btn_QLNCC.Text = "Quản lý nhà cung cấp";
            this.btn_QLNCC.UseVisualStyleBackColor = false;
            this.btn_QLNCC.Click += new System.EventHandler(this.btn_QLNCC_Click);
            // 
            // btn_ChangeInform
            // 
            this.btn_ChangeInform.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_ChangeInform.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ChangeInform.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btn_ChangeInform.ForeColor = System.Drawing.Color.Black;
            this.btn_ChangeInform.Location = new System.Drawing.Point(12, 425);
            this.btn_ChangeInform.Name = "btn_ChangeInform";
            this.btn_ChangeInform.Size = new System.Drawing.Size(230, 38);
            this.btn_ChangeInform.TabIndex = 5;
            this.btn_ChangeInform.Text = "Đổi thông tin cá nhân";
            this.btn_ChangeInform.UseVisualStyleBackColor = false;
            this.btn_ChangeInform.Click += new System.EventHandler(this.btn_ChangeInform_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 29);
            this.label1.TabIndex = 11;
            this.label1.Text = "Menu";
            // 
            // frm_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(566, 513);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_ChangeInform);
            this.Controls.Add(this.btn_QLNCC);
            this.Controls.Add(this.btn_QLNV);
            this.Controls.Add(this.btn_QLSP);
            this.Controls.Add(this.btn_QLHD);
            this.Controls.Add(this.btn_LogOut);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frm_Menu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_Menu";
            this.Load += new System.EventHandler(this.frm_Menu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_LogOut;
        private System.Windows.Forms.Button btn_QLHD;
        private System.Windows.Forms.Button btn_QLSP;
        private System.Windows.Forms.Button btn_QLNV;
        private System.Windows.Forms.Button btn_QLNCC;
        private System.Windows.Forms.Button btn_ChangeInform;
        private System.Windows.Forms.Label label1;
    }
}