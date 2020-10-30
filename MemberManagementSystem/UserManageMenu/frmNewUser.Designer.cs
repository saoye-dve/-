namespace MemberManagementSystem
{
    partial class frmNewUser
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
            this.components = new System.ComponentModel.Container();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.lblMemberState = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblWechat = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblUserLevel = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblDueToTime = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.rbLock = new System.Windows.Forms.RadioButton();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtWechat = new System.Windows.Forms.TextBox();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.rbShe = new System.Windows.Forms.RadioButton();
            this.cboUserLevel = new System.Windows.Forms.ComboBox();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.dtpDueToTime = new System.Windows.Forms.DateTimePicker();
            this.pMemberState = new System.Windows.Forms.Panel();
            this.pSex = new System.Windows.Forms.Panel();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.gbCodeScann = new System.Windows.Forms.GroupBox();
            this.pCodeScann = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtQrCode = new System.Windows.Forms.TextBox();
            this.tQrCode = new System.Windows.Forms.Timer(this.components);
            this.pMemberState.SuspendLayout();
            this.pSex.SuspendLayout();
            this.gbCodeScann.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Font = new System.Drawing.Font("宋体", 12F);
            this.lblCardNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblCardNo.Location = new System.Drawing.Point(94, 43);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(49, 20);
            this.lblCardNo.TabIndex = 0;
            this.lblCardNo.Text = "卡号";
            // 
            // lblMemberState
            // 
            this.lblMemberState.AutoSize = true;
            this.lblMemberState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblMemberState.Location = new System.Drawing.Point(54, 90);
            this.lblMemberState.Name = "lblMemberState";
            this.lblMemberState.Size = new System.Drawing.Size(89, 20);
            this.lblMemberState.TabIndex = 0;
            this.lblMemberState.Text = "会员状态";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblName.Location = new System.Drawing.Point(94, 140);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblPass.Location = new System.Drawing.Point(94, 188);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(49, 20);
            this.lblPass.TabIndex = 0;
            this.lblPass.Text = "密码";
            // 
            // lblWechat
            // 
            this.lblWechat.AutoSize = true;
            this.lblWechat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblWechat.Location = new System.Drawing.Point(94, 235);
            this.lblWechat.Name = "lblWechat";
            this.lblWechat.Size = new System.Drawing.Size(49, 20);
            this.lblWechat.TabIndex = 0;
            this.lblWechat.Text = "微信";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblPhone.Location = new System.Drawing.Point(74, 281);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(69, 20);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "手机号";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblSex.Location = new System.Drawing.Point(94, 365);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(49, 20);
            this.lblSex.TabIndex = 0;
            this.lblSex.Text = "性别";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblBirthday.Location = new System.Drawing.Point(94, 411);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(49, 20);
            this.lblBirthday.TabIndex = 0;
            this.lblBirthday.Text = "生日";
            // 
            // lblUserLevel
            // 
            this.lblUserLevel.AutoSize = true;
            this.lblUserLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblUserLevel.Location = new System.Drawing.Point(54, 459);
            this.lblUserLevel.Name = "lblUserLevel";
            this.lblUserLevel.Size = new System.Drawing.Size(89, 20);
            this.lblUserLevel.TabIndex = 0;
            this.lblUserLevel.Text = "会员等级";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblNote.Location = new System.Drawing.Point(94, 555);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(49, 20);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "备注";
            // 
            // lblDueToTime
            // 
            this.lblDueToTime.AutoSize = true;
            this.lblDueToTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblDueToTime.Location = new System.Drawing.Point(54, 504);
            this.lblDueToTime.Name = "lblDueToTime";
            this.lblDueToTime.Size = new System.Drawing.Size(89, 20);
            this.lblDueToTime.TabIndex = 0;
            this.lblDueToTime.Text = "到期时间";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Enabled = false;
            this.txtCardNo.Font = new System.Drawing.Font("宋体", 12F);
            this.txtCardNo.Location = new System.Drawing.Point(171, 38);
            this.txtCardNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCardNo.MaxLength = 10;
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.ReadOnly = true;
            this.txtCardNo.Size = new System.Drawing.Size(330, 30);
            this.txtCardNo.TabIndex = 1;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.Location = new System.Drawing.Point(9, 3);
            this.rbNormal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(70, 24);
            this.rbNormal.TabIndex = 2;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "正常";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // rbLock
            // 
            this.rbLock.AutoSize = true;
            this.rbLock.Location = new System.Drawing.Point(149, 3);
            this.rbLock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbLock.Name = "rbLock";
            this.rbLock.Size = new System.Drawing.Size(70, 24);
            this.rbLock.TabIndex = 3;
            this.rbLock.Text = "锁定";
            this.rbLock.UseVisualStyleBackColor = true;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(171, 135);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(330, 30);
            this.txtName.TabIndex = 4;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(171, 183);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(330, 30);
            this.txtPwd.TabIndex = 5;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(171, 276);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(330, 30);
            this.txtPhone.TabIndex = 7;
            // 
            // txtWechat
            // 
            this.txtWechat.Location = new System.Drawing.Point(171, 230);
            this.txtWechat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWechat.Name = "txtWechat";
            this.txtWechat.Size = new System.Drawing.Size(330, 30);
            this.txtWechat.TabIndex = 6;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.Location = new System.Drawing.Point(11, 3);
            this.rbMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(50, 24);
            this.rbMale.TabIndex = 8;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "男";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // rbShe
            // 
            this.rbShe.AutoSize = true;
            this.rbShe.Location = new System.Drawing.Point(146, 3);
            this.rbShe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbShe.Name = "rbShe";
            this.rbShe.Size = new System.Drawing.Size(50, 24);
            this.rbShe.TabIndex = 9;
            this.rbShe.Text = "女";
            this.rbShe.UseVisualStyleBackColor = true;
            // 
            // cboUserLevel
            // 
            this.cboUserLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserLevel.FormattingEnabled = true;
            this.cboUserLevel.Location = new System.Drawing.Point(171, 455);
            this.cboUserLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboUserLevel.Name = "cboUserLevel";
            this.cboUserLevel.Size = new System.Drawing.Size(330, 28);
            this.cboUserLevel.TabIndex = 11;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(169, 550);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(332, 111);
            this.txtNote.TabIndex = 12;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(171, 406);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(330, 30);
            this.dtpBirthday.TabIndex = 10;
            this.dtpBirthday.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // dtpDueToTime
            // 
            this.dtpDueToTime.Location = new System.Drawing.Point(171, 499);
            this.dtpDueToTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDueToTime.Name = "dtpDueToTime";
            this.dtpDueToTime.Size = new System.Drawing.Size(330, 30);
            this.dtpDueToTime.TabIndex = 13;
            this.dtpDueToTime.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // pMemberState
            // 
            this.pMemberState.Controls.Add(this.rbLock);
            this.pMemberState.Controls.Add(this.rbNormal);
            this.pMemberState.Location = new System.Drawing.Point(171, 85);
            this.pMemberState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pMemberState.Name = "pMemberState";
            this.pMemberState.Size = new System.Drawing.Size(330, 30);
            this.pMemberState.TabIndex = 6;
            // 
            // pSex
            // 
            this.pSex.Controls.Add(this.rbShe);
            this.pSex.Controls.Add(this.rbMale);
            this.pSex.Location = new System.Drawing.Point(171, 359);
            this.pSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pSex.Name = "pSex";
            this.pSex.Size = new System.Drawing.Size(330, 30);
            this.pSex.TabIndex = 7;
            // 
            // btnNew
            // 
            this.btnNew.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnNew.FlatAppearance.BorderSize = 0;
            this.btnNew.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNew.Font = new System.Drawing.Font("宋体", 14F);
            this.btnNew.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNew.Location = new System.Drawing.Point(98, 693);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(134, 34);
            this.btnNew.TabIndex = 14;
            this.btnNew.Text = "新建";
            this.btnNew.UseVisualStyleBackColor = false;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnClear
            // 
            this.btnClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("宋体", 14F);
            this.btnClear.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnClear.Location = new System.Drawing.Point(367, 693);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(134, 34);
            this.btnClear.TabIndex = 15;
            this.btnClear.Text = "清空";
            this.btnClear.UseVisualStyleBackColor = false;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // gbCodeScann
            // 
            this.gbCodeScann.Controls.Add(this.pCodeScann);
            this.gbCodeScann.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbCodeScann.Location = new System.Drawing.Point(547, 25);
            this.gbCodeScann.Name = "gbCodeScann";
            this.gbCodeScann.Size = new System.Drawing.Size(696, 702);
            this.gbCodeScann.TabIndex = 16;
            this.gbCodeScann.TabStop = false;
            this.gbCodeScann.Text = "二维码扫描";
            // 
            // pCodeScann
            // 
            this.pCodeScann.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCodeScann.Location = new System.Drawing.Point(3, 26);
            this.pCodeScann.Name = "pCodeScann";
            this.pCodeScann.Size = new System.Drawing.Size(690, 673);
            this.pCodeScann.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(74, 325);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "二维码";
            // 
            // txtQrCode
            // 
            this.txtQrCode.Location = new System.Drawing.Point(171, 319);
            this.txtQrCode.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQrCode.MaxLength = 11;
            this.txtQrCode.Name = "txtQrCode";
            this.txtQrCode.Size = new System.Drawing.Size(330, 30);
            this.txtQrCode.TabIndex = 7;
            // 
            // tQrCode
            // 
            this.tQrCode.Enabled = true;
            this.tQrCode.Tick += new System.EventHandler(this.tQrCode_Tick);
            // 
            // frmNewUser
            // 
            this.AcceptButton = this.btnNew;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1267, 741);
            this.Controls.Add(this.gbCodeScann);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.pSex);
            this.Controls.Add(this.pMemberState);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.cboUserLevel);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.dtpDueToTime);
            this.Controls.Add(this.txtWechat);
            this.Controls.Add(this.txtQrCode);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.lblDueToTime);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblUserLevel);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblWechat);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMemberState);
            this.Controls.Add(this.lblCardNo);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmNewUser";
            this.Text = "新建会员";
            this.Load += new System.EventHandler(this.frmNewUser_Load);
            this.pMemberState.ResumeLayout(false);
            this.pMemberState.PerformLayout();
            this.pSex.ResumeLayout(false);
            this.pSex.PerformLayout();
            this.gbCodeScann.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.Label lblMemberState;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblWechat;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblUserLevel;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblDueToTime;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.RadioButton rbLock;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtWechat;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.RadioButton rbShe;
        private System.Windows.Forms.ComboBox cboUserLevel;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.DateTimePicker dtpDueToTime;
        private System.Windows.Forms.Panel pMemberState;
        private System.Windows.Forms.Panel pSex;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox gbCodeScann;
        private System.Windows.Forms.Panel pCodeScann;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtQrCode;
        private System.Windows.Forms.Timer tQrCode;
    }
}