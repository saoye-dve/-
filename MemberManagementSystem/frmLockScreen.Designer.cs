namespace MemberManagementSystem
{
    partial class frmLockScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLockScreen));
            this.btnLockScreen = new System.Windows.Forms.Button();
            this.txtLockScreenPwd = new System.Windows.Forms.TextBox();
            this.lblLockScreenPwd = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtConfirmPwd = new System.Windows.Forms.TextBox();
            this.lblConfirmPwd = new System.Windows.Forms.Label();
            this.txtUnlockPwd = new System.Windows.Forms.TextBox();
            this.lblUnlockPwd = new System.Windows.Forms.Label();
            this.pTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLockScreen
            // 
            this.btnLockScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnLockScreen.FlatAppearance.BorderSize = 0;
            this.btnLockScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnLockScreen.Location = new System.Drawing.Point(33, 198);
            this.btnLockScreen.Name = "btnLockScreen";
            this.btnLockScreen.Size = new System.Drawing.Size(85, 30);
            this.btnLockScreen.TabIndex = 4;
            this.btnLockScreen.Text = "锁屏";
            this.btnLockScreen.UseVisualStyleBackColor = false;
            this.btnLockScreen.Click += new System.EventHandler(this.btnLockScreen_Click);
            // 
            // txtLockScreenPwd
            // 
            this.txtLockScreenPwd.Location = new System.Drawing.Point(119, 52);
            this.txtLockScreenPwd.MaxLength = 16;
            this.txtLockScreenPwd.Name = "txtLockScreenPwd";
            this.txtLockScreenPwd.PasswordChar = '*';
            this.txtLockScreenPwd.Size = new System.Drawing.Size(177, 25);
            this.txtLockScreenPwd.TabIndex = 1;
            // 
            // lblLockScreenPwd
            // 
            this.lblLockScreenPwd.AutoSize = true;
            this.lblLockScreenPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblLockScreenPwd.Location = new System.Drawing.Point(19, 56);
            this.lblLockScreenPwd.Name = "lblLockScreenPwd";
            this.lblLockScreenPwd.Size = new System.Drawing.Size(67, 15);
            this.lblLockScreenPwd.TabIndex = 2;
            this.lblLockScreenPwd.Text = "锁屏密码";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCancel.Location = new System.Drawing.Point(191, 198);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(85, 30);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtConfirmPwd
            // 
            this.txtConfirmPwd.Location = new System.Drawing.Point(119, 101);
            this.txtConfirmPwd.MaxLength = 16;
            this.txtConfirmPwd.Name = "txtConfirmPwd";
            this.txtConfirmPwd.PasswordChar = '*';
            this.txtConfirmPwd.Size = new System.Drawing.Size(177, 25);
            this.txtConfirmPwd.TabIndex = 2;
            // 
            // lblConfirmPwd
            // 
            this.lblConfirmPwd.AutoSize = true;
            this.lblConfirmPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblConfirmPwd.Location = new System.Drawing.Point(19, 106);
            this.lblConfirmPwd.Name = "lblConfirmPwd";
            this.lblConfirmPwd.Size = new System.Drawing.Size(67, 15);
            this.lblConfirmPwd.TabIndex = 2;
            this.lblConfirmPwd.Text = "确认密码";
            // 
            // txtUnlockPwd
            // 
            this.txtUnlockPwd.Enabled = false;
            this.txtUnlockPwd.Location = new System.Drawing.Point(119, 150);
            this.txtUnlockPwd.MaxLength = 16;
            this.txtUnlockPwd.Name = "txtUnlockPwd";
            this.txtUnlockPwd.PasswordChar = '*';
            this.txtUnlockPwd.Size = new System.Drawing.Size(177, 25);
            this.txtUnlockPwd.TabIndex = 3;
            // 
            // lblUnlockPwd
            // 
            this.lblUnlockPwd.AutoSize = true;
            this.lblUnlockPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblUnlockPwd.Location = new System.Drawing.Point(19, 156);
            this.lblUnlockPwd.Name = "lblUnlockPwd";
            this.lblUnlockPwd.Size = new System.Drawing.Size(67, 15);
            this.lblUnlockPwd.TabIndex = 2;
            this.lblUnlockPwd.Text = "解锁密码";
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pTitle.Controls.Add(this.lblTitle);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(313, 32);
            this.pTitle.TabIndex = 41;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 10F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblTitle.Location = new System.Drawing.Point(107, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 17);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "修改会员信息";
            // 
            // frmLockScreen
            // 
            this.AcceptButton = this.btnLockScreen;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(313, 250);
            this.Controls.Add(this.pTitle);
            this.Controls.Add(this.lblUnlockPwd);
            this.Controls.Add(this.lblConfirmPwd);
            this.Controls.Add(this.lblLockScreenPwd);
            this.Controls.Add(this.txtUnlockPwd);
            this.Controls.Add(this.txtConfirmPwd);
            this.Controls.Add(this.txtLockScreenPwd);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnLockScreen);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLockScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "锁屏";
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnLockScreen;
        private System.Windows.Forms.TextBox txtLockScreenPwd;
        private System.Windows.Forms.Label lblLockScreenPwd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtConfirmPwd;
        private System.Windows.Forms.Label lblConfirmPwd;
        private System.Windows.Forms.TextBox txtUnlockPwd;
        private System.Windows.Forms.Label lblUnlockPwd;
        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.Label lblTitle;
    }
}