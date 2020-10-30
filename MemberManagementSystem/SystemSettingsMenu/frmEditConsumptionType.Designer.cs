namespace MemberManagementSystem.SystemSettingsMenu
{
    partial class frmEditConsumptionType
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
            this.btnUpdate = new System.Windows.Forms.Button();
            this.dtpDueToTime = new System.Windows.Forms.DateTimePicker();
            this.pEnable = new System.Windows.Forms.Panel();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblConsumptionType = new System.Windows.Forms.Label();
            this.lblDueToTime = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblEnable = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtConsumptionType = new System.Windows.Forms.TextBox();
            this.pTitle = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.pEnable.SuspendLayout();
            this.pTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnUpdate.Location = new System.Drawing.Point(27, 209);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(90, 30);
            this.btnUpdate.TabIndex = 18;
            this.btnUpdate.Text = "修改";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // dtpDueToTime
            // 
            this.dtpDueToTime.Location = new System.Drawing.Point(132, 162);
            this.dtpDueToTime.Name = "dtpDueToTime";
            this.dtpDueToTime.Size = new System.Drawing.Size(160, 25);
            this.dtpDueToTime.TabIndex = 17;
            this.dtpDueToTime.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // pEnable
            // 
            this.pEnable.Controls.Add(this.rbNo);
            this.pEnable.Controls.Add(this.rbYes);
            this.pEnable.Location = new System.Drawing.Point(131, 121);
            this.pEnable.Name = "pEnable";
            this.pEnable.Size = new System.Drawing.Size(161, 29);
            this.pEnable.TabIndex = 16;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(86, 7);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(58, 19);
            this.rbNo.TabIndex = 4;
            this.rbNo.Text = "禁用";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Checked = true;
            this.rbYes.Location = new System.Drawing.Point(3, 7);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(58, 19);
            this.rbYes.TabIndex = 4;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "启用";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnCancel.FlatAppearance.BorderSize = 0;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.btnCancel.Location = new System.Drawing.Point(201, 209);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(90, 30);
            this.btnCancel.TabIndex = 19;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblConsumptionType
            // 
            this.lblConsumptionType.AutoSize = true;
            this.lblConsumptionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblConsumptionType.Location = new System.Drawing.Point(21, 49);
            this.lblConsumptionType.Name = "lblConsumptionType";
            this.lblConsumptionType.Size = new System.Drawing.Size(82, 15);
            this.lblConsumptionType.TabIndex = 8;
            this.lblConsumptionType.Text = "消费类型名";
            // 
            // lblDueToTime
            // 
            this.lblDueToTime.AutoSize = true;
            this.lblDueToTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblDueToTime.Location = new System.Drawing.Point(36, 168);
            this.lblDueToTime.Name = "lblDueToTime";
            this.lblDueToTime.Size = new System.Drawing.Size(67, 15);
            this.lblDueToTime.TabIndex = 10;
            this.lblDueToTime.Text = "到期时间";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblPrice.Location = new System.Drawing.Point(66, 87);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(37, 15);
            this.lblPrice.TabIndex = 9;
            this.lblPrice.Text = "价格";
            // 
            // lblEnable
            // 
            this.lblEnable.AutoSize = true;
            this.lblEnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblEnable.Location = new System.Drawing.Point(36, 128);
            this.lblEnable.Name = "lblEnable";
            this.lblEnable.Size = new System.Drawing.Size(67, 15);
            this.lblEnable.TabIndex = 11;
            this.lblEnable.Text = "是否启用";
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(131, 81);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(161, 25);
            this.txtPrice.TabIndex = 14;
            // 
            // txtConsumptionType
            // 
            this.txtConsumptionType.Location = new System.Drawing.Point(131, 46);
            this.txtConsumptionType.Name = "txtConsumptionType";
            this.txtConsumptionType.Size = new System.Drawing.Size(161, 25);
            this.txtConsumptionType.TabIndex = 15;
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
            this.pTitle.Size = new System.Drawing.Size(318, 32);
            this.pTitle.TabIndex = 42;
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("宋体", 10F);
            this.lblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.lblTitle.Location = new System.Drawing.Point(90, 7);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(110, 17);
            this.lblTitle.TabIndex = 21;
            this.lblTitle.Text = "修改消费类型";
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
            this.btnExit.Location = new System.Drawing.Point(285, 1);
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
            this.btnMinimize.Location = new System.Drawing.Point(251, 1);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnMinimize.Rotation = 0D;
            this.btnMinimize.Size = new System.Drawing.Size(32, 30);
            this.btnMinimize.TabIndex = 19;
            this.btnMinimize.UseVisualStyleBackColor = false;
            // 
            // frmEditConsumptionType
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.ClientSize = new System.Drawing.Size(318, 254);
            this.Controls.Add(this.pTitle);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.dtpDueToTime);
            this.Controls.Add(this.pEnable);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.lblConsumptionType);
            this.Controls.Add(this.lblDueToTime);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblEnable);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.txtConsumptionType);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmEditConsumptionType";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "修改消费类型";
            this.Load += new System.EventHandler(this.frmEditConsumptionType_Load);
            this.pEnable.ResumeLayout(false);
            this.pEnable.PerformLayout();
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.DateTimePicker dtpDueToTime;
        private System.Windows.Forms.Panel pEnable;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblConsumptionType;
        private System.Windows.Forms.Label lblDueToTime;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblEnable;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtConsumptionType;
        private System.Windows.Forms.Panel pTitle;
        private System.Windows.Forms.Label lblTitle;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnMinimize;
    }
}