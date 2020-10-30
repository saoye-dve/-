namespace MemberManagementSystem
{
    partial class frmUserStatistical
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbScreen = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.cboUserLevel = new System.Windows.Forms.ComboBox();
            this.dtpOpenCardDate = new System.Windows.Forms.DateTimePicker();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblUserLevel = new System.Windows.Forms.Label();
            this.lblOpenCardDate = new System.Windows.Forms.Label();
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtNotePreview = new System.Windows.Forms.TextBox();
            this.tPreview = new System.Windows.Forms.Timer(this.components);
            this.sStrip = new System.Windows.Forms.StatusStrip();
            this.tsslTotalMembership = new System.Windows.Forms.ToolStripStatusLabel();
            this.gbScreen.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.sStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbScreen
            // 
            this.gbScreen.Controls.Add(this.btnFilter);
            this.gbScreen.Controls.Add(this.txtBalance);
            this.gbScreen.Controls.Add(this.cboUserLevel);
            this.gbScreen.Controls.Add(this.dtpOpenCardDate);
            this.gbScreen.Controls.Add(this.lblBalance);
            this.gbScreen.Controls.Add(this.lblUserLevel);
            this.gbScreen.Controls.Add(this.lblOpenCardDate);
            this.gbScreen.Font = new System.Drawing.Font("宋体", 10F);
            this.gbScreen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbScreen.Location = new System.Drawing.Point(11, 7);
            this.gbScreen.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbScreen.Name = "gbScreen";
            this.gbScreen.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbScreen.Size = new System.Drawing.Size(607, 158);
            this.gbScreen.TabIndex = 1;
            this.gbScreen.TabStop = false;
            this.gbScreen.Text = "筛选统计";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Font = new System.Drawing.Font("宋体", 10F);
            this.btnFilter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFilter.Location = new System.Drawing.Point(420, 103);
            this.btnFilter.Margin = new System.Windows.Forms.Padding(4);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(150, 35);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "筛选";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // txtBalance
            // 
            this.txtBalance.Font = new System.Drawing.Font("宋体", 12F);
            this.txtBalance.Location = new System.Drawing.Point(138, 105);
            this.txtBalance.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(260, 30);
            this.txtBalance.TabIndex = 3;
            // 
            // cboUserLevel
            // 
            this.cboUserLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUserLevel.Font = new System.Drawing.Font("宋体", 12F);
            this.cboUserLevel.FormattingEnabled = true;
            this.cboUserLevel.Location = new System.Drawing.Point(138, 67);
            this.cboUserLevel.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.cboUserLevel.Name = "cboUserLevel";
            this.cboUserLevel.Size = new System.Drawing.Size(260, 28);
            this.cboUserLevel.TabIndex = 2;
            // 
            // dtpOpenCardDate
            // 
            this.dtpOpenCardDate.Font = new System.Drawing.Font("宋体", 12F);
            this.dtpOpenCardDate.Location = new System.Drawing.Point(138, 28);
            this.dtpOpenCardDate.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dtpOpenCardDate.Name = "dtpOpenCardDate";
            this.dtpOpenCardDate.Size = new System.Drawing.Size(260, 30);
            this.dtpOpenCardDate.TabIndex = 1;
            this.dtpOpenCardDate.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("宋体", 12F);
            this.lblBalance.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblBalance.Location = new System.Drawing.Point(23, 105);
            this.lblBalance.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(89, 20);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "余额大于";
            // 
            // lblUserLevel
            // 
            this.lblUserLevel.AutoSize = true;
            this.lblUserLevel.Font = new System.Drawing.Font("宋体", 12F);
            this.lblUserLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblUserLevel.Location = new System.Drawing.Point(23, 69);
            this.lblUserLevel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUserLevel.Name = "lblUserLevel";
            this.lblUserLevel.Size = new System.Drawing.Size(89, 20);
            this.lblUserLevel.TabIndex = 0;
            this.lblUserLevel.Text = "会员等级";
            // 
            // lblOpenCardDate
            // 
            this.lblOpenCardDate.AutoSize = true;
            this.lblOpenCardDate.Font = new System.Drawing.Font("宋体", 12F);
            this.lblOpenCardDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblOpenCardDate.Location = new System.Drawing.Point(23, 37);
            this.lblOpenCardDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblOpenCardDate.Name = "lblOpenCardDate";
            this.lblOpenCardDate.Size = new System.Drawing.Size(89, 20);
            this.lblOpenCardDate.TabIndex = 0;
            this.lblOpenCardDate.Text = "开卡日期";
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
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(25)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
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
            this.dgvUserInfo.EnableHeadersVisualStyles = false;
            this.dgvUserInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.dgvUserInfo.Location = new System.Drawing.Point(0, 173);
            this.dgvUserInfo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvUserInfo.MultiSelect = false;
            this.dgvUserInfo.Name = "dgvUserInfo";
            this.dgvUserInfo.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUserInfo.RowHeadersVisible = false;
            this.dgvUserInfo.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(25)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvUserInfo.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvUserInfo.RowTemplate.Height = 27;
            this.dgvUserInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserInfo.Size = new System.Drawing.Size(1288, 527);
            this.dgvUserInfo.TabIndex = 2;
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtNotePreview);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox2.Location = new System.Drawing.Point(627, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(649, 158);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "备注预览";
            // 
            // txtNotePreview
            // 
            this.txtNotePreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtNotePreview.Font = new System.Drawing.Font("宋体", 12F);
            this.txtNotePreview.Location = new System.Drawing.Point(3, 23);
            this.txtNotePreview.Multiline = true;
            this.txtNotePreview.Name = "txtNotePreview";
            this.txtNotePreview.Size = new System.Drawing.Size(643, 132);
            this.txtNotePreview.TabIndex = 3;
            // 
            // tPreview
            // 
            this.tPreview.Enabled = true;
            this.tPreview.Tick += new System.EventHandler(this.tPreview_Tick);
            // 
            // sStrip
            // 
            this.sStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotalMembership});
            this.sStrip.Location = new System.Drawing.Point(0, 672);
            this.sStrip.Name = "sStrip";
            this.sStrip.Size = new System.Drawing.Size(1288, 25);
            this.sStrip.TabIndex = 4;
            this.sStrip.Text = "statusStrip1";
            // 
            // tsslTotalMembership
            // 
            this.tsslTotalMembership.Name = "tsslTotalMembership";
            this.tsslTotalMembership.Size = new System.Drawing.Size(93, 20);
            this.tsslTotalMembership.Text = "总会员数：0";
            // 
            // frmUserStatistical
            // 
            this.AcceptButton = this.btnFilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1288, 697);
            this.Controls.Add(this.sStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.dgvUserInfo);
            this.Controls.Add(this.gbScreen);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "frmUserStatistical";
            this.Text = "会员统计";
            this.Load += new System.EventHandler(this.frmUserStatistical_Load);
            this.gbScreen.ResumeLayout(false);
            this.gbScreen.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserInfo)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.sStrip.ResumeLayout(false);
            this.sStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbScreen;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.ComboBox cboUserLevel;
        private System.Windows.Forms.DateTimePicker dtpOpenCardDate;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblUserLevel;
        private System.Windows.Forms.Label lblOpenCardDate;
        private System.Windows.Forms.DataGridView dgvUserInfo;
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
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNotePreview;
        private System.Windows.Forms.Timer tPreview;
        private System.Windows.Forms.StatusStrip sStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalMembership;
    }
}