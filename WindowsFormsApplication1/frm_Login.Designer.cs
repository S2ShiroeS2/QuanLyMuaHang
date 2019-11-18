namespace WindowsFormsApplication1
{
    partial class frm_Login
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm_Login));
            this.txb_Account = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txb_Password = new System.Windows.Forms.TextBox();
            this.bt_Login = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txb_Account
            // 
            this.txb_Account.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_Account.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Account.ForeColor = System.Drawing.Color.Black;
            this.txb_Account.Location = new System.Drawing.Point(231, 101);
            this.txb_Account.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Account.Name = "txb_Account";
            this.txb_Account.Size = new System.Drawing.Size(239, 34);
            this.txb_Account.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(16, 105);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tên Đăng Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(16, 167);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 30);
            this.label2.TabIndex = 3;
            this.label2.Text = "Mật Khẩu:";
            // 
            // txb_Password
            // 
            this.txb_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.txb_Password.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txb_Password.ForeColor = System.Drawing.Color.Black;
            this.txb_Password.Location = new System.Drawing.Point(231, 163);
            this.txb_Password.Margin = new System.Windows.Forms.Padding(4);
            this.txb_Password.Name = "txb_Password";
            this.txb_Password.Size = new System.Drawing.Size(239, 34);
            this.txb_Password.TabIndex = 2;
            this.txb_Password.UseSystemPasswordChar = true;
            // 
            // bt_Login
            // 
            this.bt_Login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bt_Login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt_Login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Login.ForeColor = System.Drawing.Color.Black;
            this.bt_Login.Location = new System.Drawing.Point(260, 248);
            this.bt_Login.Margin = new System.Windows.Forms.Padding(4);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(210, 57);
            this.bt_Login.TabIndex = 4;
            this.bt_Login.Text = "Đăng nhập";
            this.bt_Login.UseVisualStyleBackColor = false;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(117, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(281, 58);
            this.label3.TabIndex = 5;
            this.label3.Text = "LOGIN";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Exit
            // 
            this.btn_Exit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.btn_Exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Exit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Exit.ForeColor = System.Drawing.Color.Black;
            this.btn_Exit.Location = new System.Drawing.Point(22, 248);
            this.btn_Exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(210, 57);
            this.btn_Exit.TabIndex = 6;
            this.btn_Exit.Text = "Thoát";
            this.btn_Exit.UseVisualStyleBackColor = false;
            this.btn_Exit.Click += new System.EventHandler(this.btn_Exit_Click);
            // 
            // frm_Login
            // 
            this.AcceptButton = this.bt_Login;
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(497, 318);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txb_Password);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txb_Account);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frm_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txb_Account;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txb_Password;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btn_Exit;
    }
}

