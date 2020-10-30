namespace MemberManagementSystem
{
    partial class frmUserManage
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvUserInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDeleteUser = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserLock = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUserActivate = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiUpdateUserInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtQueryNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gbQueryMethods = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).BeginInit();
            this.ctmsMenu.SuspendLayout();
            this.gbQueryMethods.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUserInfo
            // 
            this.dgvUserInfo.AllowUserToAddRows = false;
            this.dgvUserInfo.AllowUserToResizeRows = false;
            this.dgvUserInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvUserInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(25)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserInfo.ColumnHeadersHeight = 35;
            this.dgvUserInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUserInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9,
            this.Column10,
            this.Column11,
            this.Column12,
            this.Column13});
            this.dgvUserInfo.ContextMenuStrip = this.ctmsMenu;
            this.dgvUserInfo.EnableHeadersVisualStyles = false;
            this.dgvUserInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.dgvUserInfo.Location = new System.Drawing.Point(0, 106);
            this.dgvUserInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvUserInfo.MultiSelect = false;
            this.dgvUserInfo.Name = "dgvUserInfo";
            this.dgvUserInfo.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserInfo.RowHeadersVisible = false;
            this.dgvUserInfo.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 11.25F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(25)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvUserInfo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserInfo.RowTemplate.Height = 27;
            this.dgvUserInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserInfo.Size = new System.Drawing.Size(1267, 593);
            this.dgvUserInfo.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CardNo";
            this.Column1.HeaderText = "卡号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "MemberState";
            this.Column2.HeaderText = "会员状态";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Name";
            this.Column3.HeaderText = "姓名";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PassWord";
            this.Column4.HeaderText = "密码";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "Wechat";
            this.Column5.HeaderText = "微信";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Phone";
            this.Column6.HeaderText = "手机号";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Sex";
            this.Column7.HeaderText = "性别";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "Birthday";
            this.Column8.HeaderText = "生日";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "MembersName";
            this.Column9.HeaderText = "会员等级";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // Column10
            // 
            this.Column10.DataPropertyName = "Balance";
            this.Column10.HeaderText = "余额";
            this.Column10.MinimumWidth = 6;
            this.Column10.Name = "Column10";
            this.Column10.ReadOnly = true;
            // 
            // Column11
            // 
            this.Column11.DataPropertyName = "Note";
            this.Column11.HeaderText = "备注";
            this.Column11.MinimumWidth = 6;
            this.Column11.Name = "Column11";
            this.Column11.ReadOnly = true;
            // 
            // Column12
            // 
            this.Column12.DataPropertyName = "OpenCardDate";
            this.Column12.HeaderText = "开卡日期";
            this.Column12.MinimumWidth = 6;
            this.Column12.Name = "Column12";
            this.Column12.ReadOnly = true;
            // 
            // Column13
            // 
            this.Column13.DataPropertyName = "DueToTime";
            this.Column13.HeaderText = "到期时间";
            this.Column13.MinimumWidth = 6;
            this.Column13.Name = "Column13";
            this.Column13.ReadOnly = true;
            // 
            // ctmsMenu
            // 
            this.ctmsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDeleteUser,
            this.tsmiUserLock,
            this.tsmiUserActivate,
            this.tsmiUpdateUserInfo});
            this.ctmsMenu.Name = "contextMenuStrip1";
            this.ctmsMenu.Size = new System.Drawing.Size(187, 100);
            // 
            // tsmiDeleteUser
            // 
            this.tsmiDeleteUser.Name = "tsmiDeleteUser";
            this.tsmiDeleteUser.Size = new System.Drawing.Size(186, 24);
            this.tsmiDeleteUser.Text = "删除会员(&A)";
            this.tsmiDeleteUser.Click += new System.EventHandler(this.tsmiDeleteUser_Click);
            // 
            // tsmiUserLock
            // 
            this.tsmiUserLock.Name = "tsmiUserLock";
            this.tsmiUserLock.Size = new System.Drawing.Size(186, 24);
            this.tsmiUserLock.Text = "会员锁定(&S)";
            this.tsmiUserLock.Click += new System.EventHandler(this.tsmiUserLock_Click);
            // 
            // tsmiUserActivate
            // 
            this.tsmiUserActivate.Name = "tsmiUserActivate";
            this.tsmiUserActivate.Size = new System.Drawing.Size(186, 24);
            this.tsmiUserActivate.Text = "会员激活(&D)";
            this.tsmiUserActivate.Click += new System.EventHandler(this.tsmiUserActivate_Click);
            // 
            // tsmiUpdateUserInfo
            // 
            this.tsmiUpdateUserInfo.Name = "tsmiUpdateUserInfo";
            this.tsmiUpdateUserInfo.Size = new System.Drawing.Size(186, 24);
            this.tsmiUpdateUserInfo.Text = "修改会员信息(&F)";
            this.tsmiUpdateUserInfo.Click += new System.EventHandler(this.tsmiUpdateUserInfo_Click);
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.Font = new System.Drawing.Font("宋体", 10F);
            this.btnQuery.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQuery.Location = new System.Drawing.Point(732, 38);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 30);
            this.btnQuery.TabIndex = 3;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtQueryNo
            // 
            this.txtQueryNo.Font = new System.Drawing.Font("宋体", 16F);
            this.txtQueryNo.Location = new System.Drawing.Point(24, 34);
            this.txtQueryNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQueryNo.Name = "txtQueryNo";
            this.txtQueryNo.Size = new System.Drawing.Size(677, 38);
            this.txtQueryNo.TabIndex = 7;
            this.txtQueryNo.Text = "支持卡号、手机号、姓名、微信查询、为空查询全部";
            this.txtQueryNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQueryNo.Enter += new System.EventHandler(this.txtQueryNo_Enter);
            this.txtQueryNo.Leave += new System.EventHandler(this.txtQueryNo_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(913, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(282, 27);
            this.label1.TabIndex = 8;
            this.label1.Text = "选中会员右键更多功能";
            // 
            // gbQueryMethods
            // 
            this.gbQueryMethods.Controls.Add(this.txtQueryNo);
            this.gbQueryMethods.Controls.Add(this.btnQuery);
            this.gbQueryMethods.Font = new System.Drawing.Font("宋体", 10F);
            this.gbQueryMethods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbQueryMethods.Location = new System.Drawing.Point(50, 4);
            this.gbQueryMethods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbQueryMethods.Name = "gbQueryMethods";
            this.gbQueryMethods.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbQueryMethods.Size = new System.Drawing.Size(834, 96);
            this.gbQueryMethods.TabIndex = 10;
            this.gbQueryMethods.TabStop = false;
            this.gbQueryMethods.Text = "查询方式";
            // 
            // frmUserManage
            // 
            this.AcceptButton = this.btnQuery;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1267, 697);
            this.Controls.Add(this.gbQueryMethods);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvUserInfo);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmUserManage";
            this.Text = "会员管理";
            this.Load += new System.EventHandler(this.frmUserManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).EndInit();
            this.ctmsMenu.ResumeLayout(false);
            this.gbQueryMethods.ResumeLayout(false);
            this.gbQueryMethods.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserInfo;
        private System.Windows.Forms.ContextMenuStrip ctmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiDeleteUser;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserLock;
        private System.Windows.Forms.ToolStripMenuItem tsmiUserActivate;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdateUserInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column11;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column12;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column13;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtQueryNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbQueryMethods;


    }
}