namespace MemberManagementSystem.UserManageMenu
{
    partial class frmUpdateUserInfo
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.pSex = new System.Windows.Forms.Panel();
            this.rbShe = new System.Windows.Forms.RadioButton();
            this.rbMale = new System.Windows.Forms.RadioButton();
            this.pMemberState = new System.Windows.Forms.Panel();
            this.rbLock = new System.Windows.Forms.RadioButton();
            this.rbNormal = new System.Windows.Forms.RadioButton();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.cboUserLevel = new System.Windows.Forms.ComboBox();
            this.dtpBirthday = new System.Windows.Forms.DateTimePicker();
            this.dtpDueToTime = new System.Windows.Forms.DateTimePicker();
            this.txtWechat = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.lblDueToTime = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.lblUserLevel = new System.Windows.Forms.Label();
            this.lblBirthday = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblWechat = new System.Windows.Forms.Label();
            this.lblPass = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblMemberState = new System.Windows.Forms.Label();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.TDate = new System.Windows.Forms.Timer(this.components);
            this.pTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.pSex.SuspendLayout();
            this.pMemberState.SuspendLayout();
            this.pTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Font = new System.Drawing.Font("宋体", 10F);
            this.btnCancel.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnCancel.Location = new System.Drawing.Point(246, 520);
            this.btnCancel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = new System.Drawing.Font("宋体", 10F);
            this.btnUpdate.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnUpdate.Location = new System.Drawing.Point(68, 520);
            this.btnUpdate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // pSex
            // 
            this.pSex.Controls.Add(this.rbShe);
            this.pSex.Controls.Add(this.rbMale);
            this.pSex.Location = new System.Drawing.Point(107, 275);
            this.pSex.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pSex.Name = "pSex";
            this.pSex.Size = new System.Drawing.Size(235, 25);
            this.pSex.TabIndex = 33;
            // 
            // rbShe
            // 
            this.rbShe.AutoSize = true;
            this.rbShe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rbShe.Location = new System.Drawing.Point(109, 3);
            this.rbShe.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbShe.Name = "rbShe";
            this.rbShe.Size = new System.Drawing.Size(43, 19);
            this.rbShe.TabIndex = 9;
            this.rbShe.Text = "女";
            this.rbShe.UseVisualStyleBackColor = true;
            // 
            // rbMale
            // 
            this.rbMale.AutoSize = true;
            this.rbMale.Checked = true;
            this.rbMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rbMale.Location = new System.Drawing.Point(9, 3);
            this.rbMale.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbMale.Name = "rbMale";
            this.rbMale.Size = new System.Drawing.Size(43, 19);
            this.rbMale.TabIndex = 8;
            this.rbMale.TabStop = true;
            this.rbMale.Text = "男";
            this.rbMale.UseVisualStyleBackColor = true;
            // 
            // pMemberState
            // 
            this.pMemberState.Controls.Add(this.rbLock);
            this.pMemberState.Controls.Add(this.rbNormal);
            this.pMemberState.Location = new System.Drawing.Point(107, 82);
            this.pMemberState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pMemberState.Name = "pMemberState";
            this.pMemberState.Size = new System.Drawing.Size(235, 25);
            this.pMemberState.TabIndex = 31;
            // 
            // rbLock
            // 
            this.rbLock.AutoSize = true;
            this.rbLock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rbLock.Location = new System.Drawing.Point(109, 3);
            this.rbLock.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbLock.Name = "rbLock";
            this.rbLock.Size = new System.Drawing.Size(58, 19);
            this.rbLock.TabIndex = 3;
            this.rbLock.Text = "锁定";
            this.rbLock.UseVisualStyleBackColor = true;
            // 
            // rbNormal
            // 
            this.rbNormal.AutoSize = true;
            this.rbNormal.Checked = true;
            this.rbNormal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.rbNormal.Location = new System.Drawing.Point(8, 3);
            this.rbNormal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rbNormal.Name = "rbNormal";
            this.rbNormal.Size = new System.Drawing.Size(58, 19);
            this.rbNormal.TabIndex = 2;
            this.rbNormal.TabStop = true;
            this.rbNormal.Text = "正常";
            this.rbNormal.UseVisualStyleBackColor = true;
            // 
            // txtNote
            // 
            this.txtNote.Location = new System.Drawing.Point(107, 410);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(235, 25);
            this.txtNote.TabIndex = 12;
            // 
            // cboUserLevel
            // 
            this.cboUserLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserLevel.FormattingEnabled = true;
            this.cboUserLevel.Location = new System.Drawing.Point(107, 363);
            this.cboUserLevel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboUserLevel.Name = "cboUserLevel";
            this.cboUserLevel.Size = new System.Drawing.Size(235, 23);
            this.cboUserLevel.TabIndex = 11;
            // 
            // dtpBirthday
            // 
            this.dtpBirthday.Location = new System.Drawing.Point(107, 320);
            this.dtpBirthday.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpBirthday.Name = "dtpBirthday";
            this.dtpBirthday.Size = new System.Drawing.Size(235, 25);
            this.dtpBirthday.TabIndex = 10;
            this.dtpBirthday.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // dtpDueToTime
            // 
            this.dtpDueToTime.Location = new System.Drawing.Point(107, 459);
            this.dtpDueToTime.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDueToTime.Name = "dtpDueToTime";
            this.dtpDueToTime.Size = new System.Drawing.Size(235, 25);
            this.dtpDueToTime.TabIndex = 13;
            this.dtpDueToTime.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // txtWechat
            // 
            this.txtWechat.Location = new System.Drawing.Point(107, 195);
            this.txtWechat.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtWechat.Name = "txtWechat";
            this.txtWechat.Size = new System.Drawing.Size(235, 25);
            this.txtWechat.TabIndex = 6;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(107, 238);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(235, 25);
            this.txtPhone.TabIndex = 7;
            // 
            // txtPwd
            // 
            this.txtPwd.Location = new System.Drawing.Point(107, 155);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.Size = new System.Drawing.Size(235, 25);
            this.txtPwd.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(107, 115);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(235, 25);
            this.txtName.TabIndex = 4;
            // 
            // txtCardNo
            // 
            this.txtCardNo.Enabled = false;
            this.txtCardNo.Location = new System.Drawing.Point(107, 48);
            this.txtCardNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.ReadOnly = true;
            this.txtCardNo.Size = new System.Drawing.Size(235, 25);
            this.txtCardNo.TabIndex = 1;
            // 
            // lblDueToTime
            // 
            this.lblDueToTime.AutoSize = true;
            this.lblDueToTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblDueToTime.Location = new System.Drawing.Point(17, 464);
            this.lblDueToTime.Name = "lblDueToTime";
            this.lblDueToTime.Size = new System.Drawing.Size(67, 15);
            this.lblDueToTime.TabIndex = 25;
            this.lblDueToTime.Text = "到期时间";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblNote.Location = new System.Drawing.Point(47, 415);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(37, 15);
            this.lblNote.TabIndex = 24;
            this.lblNote.Text = "备注";
            // 
            // lblUserLevel
            // 
            this.lblUserLevel.AutoSize = true;
            this.lblUserLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblUserLevel.Location = new System.Drawing.Point(17, 367);
            this.lblUserLevel.Name = "lblUserLevel";
            this.lblUserLevel.Size = new System.Drawing.Size(67, 15);
            this.lblUserLevel.TabIndex = 23;
            this.lblUserLevel.Text = "会员等级";
            // 
            // lblBirthday
            // 
            this.lblBirthday.AutoSize = true;
            this.lblBirthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblBirthday.Location = new System.Drawing.Point(47, 325);
            this.lblBirthday.Name = "lblBirthday";
            this.lblBirthday.Size = new System.Drawing.Size(37, 15);
            this.lblBirthday.TabIndex = 22;
            this.lblBirthday.Text = "生日";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblSex.Location = new System.Drawing.Point(47, 280);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(37, 15);
            this.lblSex.TabIndex = 21;
            this.lblSex.Text = "性别";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblPhone.Location = new System.Drawing.Point(32, 243);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(52, 15);
            this.lblPhone.TabIndex = 20;
            this.lblPhone.Text = "手机号";
            // 
            // lblWechat
            // 
            this.lblWechat.AutoSize = true;
            this.lblWechat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblWechat.Location = new System.Drawing.Point(47, 200);
            this.lblWechat.Name = "lblWechat";
            this.lblWechat.Size = new System.Drawing.Size(37, 15);
            this.lblWechat.TabIndex = 19;
            this.lblWechat.Text = "微信";
            // 
            // lblPass
            // 
            this.lblPass.AutoSize = true;
            this.lblPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblPass.Location = new System.Drawing.Point(47, 160);
            this.lblPass.Name = "lblPass";
            this.lblPass.Size = new System.Drawing.Size(37, 15);
            this.lblPass.TabIndex = 18;
            this.lblPass.Text = "密码";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblName.Location = new System.Drawing.Point(47, 120);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(37, 15);
            this.lblName.TabIndex = 17;
            this.lblName.Text = "姓名";
            // 
            // lblMemberState
            // 
            this.lblMemberState.AutoSize = true;
            this.lblMemberState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblMemberState.Location = new System.Drawing.Point(17, 87);
            this.lblMemberState.Name = "lblMemberState";
            this.lblMemberState.Size = new System.Drawing.Size(67, 15);
            this.lblMemberState.TabIndex = 26;
            this.lblMemberState.Text = "会员状态";
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblCardNo.Location = new System.Drawing.Point(47, 53);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(37, 15);
            this.lblCardNo.TabIndex = 16;
            this.lblCardNo.Text = "卡号";
            // 
            // TDate
            // 
            this.TDate.Enabled = true;
            this.TDate.Interval = 500;
            this.TDate.Tick += new System.EventHandler(this.TDate_Tick);
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pTitle.Controls.Add(this.lblTitle);
            this.pTitle.Controls.Add(this.btnExit);
            this.pTitle.Controls.Add(this.btnMinimize);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(0, 0);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(379, 32);
            this.pTitle.TabIndex = 40;
            this.pTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTitle_MouseDown);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 10F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblTitle.Location = new System.Drawing.Point(132, 8);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 17);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "修改会员信息";
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(346, 1);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(32, 30);
            this.btnExit.TabIndex = 20;
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMinimize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMinimize.IconSize = 25;
            this.btnMinimize.Location = new System.Drawing.Point(312, 1);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnMinimize.Rotation = 0D;
            this.btnMinimize.Size = new System.Drawing.Size(32, 30);
            this.btnMinimize.TabIndex = 19;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // frmUpdateUserInfo
            // 
            this.AcceptButton = this.btnUpdate;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(379, 569);
            this.Controls.Add(this.pTitle);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.pSex);
            this.Controls.Add(this.pMemberState);
            this.Controls.Add(this.txtNote);
            this.Controls.Add(this.cboUserLevel);
            this.Controls.Add(this.dtpBirthday);
            this.Controls.Add(this.dtpDueToTime);
            this.Controls.Add(this.txtWechat);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtPwd);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.lblDueToTime);
            this.Controls.Add(this.lblNote);
            this.Controls.Add(this.lblUserLevel);
            this.Controls.Add(this.lblBirthday);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblWechat);
            this.Controls.Add(this.lblPass);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblMemberState);
            this.Controls.Add(this.lblCardNo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUpdateUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改会员信息";
            this.Load += new System.EventHandler(this.frmUpdateUserInfo_Load);
            this.pSex.ResumeLayout(false);
            this.pSex.PerformLayout();
            this.pMemberState.ResumeLayout(false);
            this.pMemberState.PerformLayout();
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Panel pSex;
        private System.Windows.Forms.RadioButton rbShe;
        private System.Windows.Forms.RadioButton rbMale;
        private System.Windows.Forms.Panel pMemberState;
        private System.Windows.Forms.RadioButton rbLock;
        private System.Windows.Forms.RadioButton rbNormal;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.ComboBox cboUserLevel;
        private System.Windows.Forms.DateTimePicker dtpBirthday;
        private System.Windows.Forms.DateTimePicker dtpDueToTime;
        private System.Windows.Forms.TextBox txtWechat;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label lblDueToTime;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblUserLevel;
        private System.Windows.Forms.Label lblBirthday;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblWechat;
        private System.Windows.Forms.Label lblPass;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblMemberState;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.Timer TDate;
        private System.Windows.Forms.Panel pTitle;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private System.Windows.Forms.Label lblTitle;
    }
}