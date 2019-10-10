namespace WindowsFormsApplication1
{
    partial class formCT_ncc
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
            this.label1 = new System.Windows.Forms.Label();
            this.tb_ten_ncc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_dia_chi = new System.Windows.Forms.TextBox();
            this.tb_dt = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tb_NccEmail = new System.Windows.Forms.TextBox();
            this.tb_NccID = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.bt_tao_ncc = new System.Windows.Forms.Button();
            this.bt__sua_ncc = new System.Windows.Forms.Button();
            this.btn_Luu = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(170, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên nhà cung cấp";
            // 
            // tb_ten_ncc
            // 
            this.tb_ten_ncc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_ten_ncc.Location = new System.Drawing.Point(21, 39);
            this.tb_ten_ncc.Margin = new System.Windows.Forms.Padding(4);
            this.tb_ten_ncc.Name = "tb_ten_ncc";
            this.tb_ten_ncc.Size = new System.Drawing.Size(265, 30);
            this.tb_ten_ncc.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(16, 272);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Địa chỉ";
            // 
            // tb_dia_chi
            // 
            this.tb_dia_chi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dia_chi.Location = new System.Drawing.Point(133, 240);
            this.tb_dia_chi.Margin = new System.Windows.Forms.Padding(4);
            this.tb_dia_chi.Multiline = true;
            this.tb_dia_chi.Name = "tb_dia_chi";
            this.tb_dia_chi.Size = new System.Drawing.Size(301, 57);
            this.tb_dia_chi.TabIndex = 3;
            // 
            // tb_dt
            // 
            this.tb_dt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dt.Location = new System.Drawing.Point(815, 267);
            this.tb_dt.Margin = new System.Windows.Forms.Padding(4);
            this.tb_dt.Name = "tb_dt";
            this.tb_dt.Size = new System.Drawing.Size(265, 30);
            this.tb_dt.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(669, 272);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(126, 25);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số điện thoại";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(16, 352);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 25);
            this.label4.TabIndex = 6;
            this.label4.Text = "Email";
            // 
            // tb_NccEmail
            // 
            this.tb_NccEmail.Location = new System.Drawing.Point(133, 352);
            this.tb_NccEmail.Name = "tb_NccEmail";
            this.tb_NccEmail.Size = new System.Drawing.Size(301, 22);
            this.tb_NccEmail.TabIndex = 9;
            // 
            // tb_NccID
            // 
            this.tb_NccID.Enabled = false;
            this.tb_NccID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_NccID.Location = new System.Drawing.Point(216, 116);
            this.tb_NccID.Margin = new System.Windows.Forms.Padding(4);
            this.tb_NccID.Name = "tb_NccID";
            this.tb_NccID.Size = new System.Drawing.Size(265, 30);
            this.tb_NccID.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(16, 116);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(163, 25);
            this.label5.TabIndex = 7;
            this.label5.Text = "Mã nhà cung cấp";
            // 
            // bt_tao_ncc
            // 
            this.bt_tao_ncc.Location = new System.Drawing.Point(238, 438);
            this.bt_tao_ncc.Name = "bt_tao_ncc";
            this.bt_tao_ncc.Size = new System.Drawing.Size(127, 55);
            this.bt_tao_ncc.TabIndex = 10;
            this.bt_tao_ncc.Text = "Tạo";
            this.bt_tao_ncc.UseVisualStyleBackColor = true;
            // 
            // bt__sua_ncc
            // 
            this.bt__sua_ncc.Location = new System.Drawing.Point(674, 438);
            this.bt__sua_ncc.Name = "bt__sua_ncc";
            this.bt__sua_ncc.Size = new System.Drawing.Size(127, 55);
            this.bt__sua_ncc.TabIndex = 11;
            this.bt__sua_ncc.Text = "Sửa ";
            this.bt__sua_ncc.UseVisualStyleBackColor = true;
            this.bt__sua_ncc.Click += new System.EventHandler(this.bt__sua_ncc_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.Location = new System.Drawing.Point(873, 438);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.Size = new System.Drawing.Size(127, 55);
            this.btn_Luu.TabIndex = 12;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.UseVisualStyleBackColor = true;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // formCT_ncc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1232, 583);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.bt__sua_ncc);
            this.Controls.Add(this.bt_tao_ncc);
            this.Controls.Add(this.tb_NccEmail);
            this.Controls.Add(this.tb_NccID);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.tb_dt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_dia_chi);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_ten_ncc);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "formCT_ncc";
            this.Text = "formCT_ncc";
            this.Load += new System.EventHandler(this.formCT_ncc_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_ten_ncc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_dia_chi;
        private System.Windows.Forms.TextBox tb_dt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tb_NccEmail;
        private System.Windows.Forms.TextBox tb_NccID;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button bt_tao_ncc;
        private System.Windows.Forms.Button bt__sua_ncc;
        private System.Windows.Forms.Button btn_Luu;
    }
}