namespace MemberManagementSystem.StatisticalQueryMenu
{
    partial class gbStatisticalFilter
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
            this.dgvSmsInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cboTypeName = new System.Windows.Forms.ComboBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.dtpInDate = new System.Windows.Forms.DateTimePicker();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblTypeName = new System.Windows.Forms.Label();
            this.lblInDate = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtSendPreview = new System.Windows.Forms.TextBox();
            this.tPreview = new System.Windows.Forms.Timer(this.components);
            this.sStrip = new System.Windows.Forms.StatusStrip();
            this.tsslAlwaysSend = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslSendSuccess = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSmsInfo)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.sStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSmsInfo
            // 
            this.dgvSmsInfo.AllowUserToAddRows = false;
            this.dgvSmsInfo.AllowUserToResizeRows = false;
            this.dgvSmsInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSmsInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSmsInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvSmsInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvSmsInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(25)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSmsInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvSmsInfo.ColumnHeadersHeight = 35;
            this.dgvSmsInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvSmsInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dgvSmsInfo.EnableHeadersVisualStyles = false;
            this.dgvSmsInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.dgvSmsInfo.Location = new System.Drawing.Point(0, 175);
            this.dgvSmsInfo.MultiSelect = false;
            this.dgvSmsInfo.Name = "dgvSmsInfo";
            this.dgvSmsInfo.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvSmsInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvSmsInfo.RowHeadersVisible = false;
            this.dgvSmsInfo.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(25)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvSmsInfo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvSmsInfo.RowTemplate.Height = 27;
            this.dgvSmsInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSmsInfo.Size = new System.Drawing.Size(1288, 522);
            this.dgvSmsInfo.TabIndex = 0;
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
            this.Column2.DataPropertyName = "Name";
            this.Column2.HeaderText = "姓名";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Phone";
            this.Column3.HeaderText = "手机号";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "InDate";
            this.Column4.HeaderText = "发送日期";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "MessageText";
            this.Column5.HeaderText = "发送内容";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TypeName";
            this.Column6.HeaderText = "短信类型";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "WhetherToSend";
            this.Column7.HeaderText = "状态";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFilter);
            this.groupBox1.Controls.Add(this.cboTypeName);
            this.groupBox1.Controls.Add(this.txtCardNo);
            this.groupBox1.Controls.Add(this.txtPhone);
            this.groupBox1.Controls.Add(this.dtpInDate);
            this.groupBox1.Controls.Add(this.lblCardNo);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Controls.Add(this.lblPhone);
            this.groupBox1.Controls.Add(this.lblTypeName);
            this.groupBox1.Controls.Add(this.lblInDate);
            this.groupBox1.Controls.Add(this.lblName);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.groupBox1.Location = new System.Drawing.Point(11, 9);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 160);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "统计筛选";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFilter.Location = new System.Drawing.Point(567, 111);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(150, 35);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.Text = "筛选";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cboTypeName
            // 
            this.cboTypeName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTypeName.Font = new System.Drawing.Font("宋体", 12F);
            this.cboTypeName.FormattingEnabled = true;
            this.cboTypeName.Location = new System.Drawing.Point(514, 71);
            this.cboTypeName.Name = "cboTypeName";
            this.cboTypeName.Size = new System.Drawing.Size(260, 28);
            this.cboTypeName.TabIndex = 3;
            // 
            // txtCardNo
            // 
            this.txtCardNo.Font = new System.Drawing.Font("宋体", 12F);
            this.txtCardNo.Location = new System.Drawing.Point(98, 27);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(260, 30);
            this.txtCardNo.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPhone.Location = new System.Drawing.Point(98, 70);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(260, 30);
            this.txtPhone.TabIndex = 1;
            // 
            // dtpInDate
            // 
            this.dtpInDate.Font = new System.Drawing.Font("宋体", 12F);
            this.dtpInDate.Location = new System.Drawing.Point(514, 27);
            this.dtpInDate.Name = "dtpInDate";
            this.dtpInDate.Size = new System.Drawing.Size(260, 30);
            this.dtpInDate.TabIndex = 2;
            this.dtpInDate.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Font = new System.Drawing.Font("宋体", 12F);
            this.lblCardNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblCardNo.Location = new System.Drawing.Point(36, 32);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(49, 20);
            this.lblCardNo.TabIndex = 0;
            this.lblCardNo.Text = "卡号";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtName.Location = new System.Drawing.Point(98, 113);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 30);
            this.txtName.TabIndex = 1;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("宋体", 12F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblPhone.Location = new System.Drawing.Point(16, 75);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(69, 20);
            this.lblPhone.TabIndex = 0;
            this.lblPhone.Text = "手机号";
            // 
            // lblTypeName
            // 
            this.lblTypeName.AutoSize = true;
            this.lblTypeName.Font = new System.Drawing.Font("宋体", 12F);
            this.lblTypeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblTypeName.Location = new System.Drawing.Point(401, 75);
            this.lblTypeName.Name = "lblTypeName";
            this.lblTypeName.Size = new System.Drawing.Size(89, 20);
            this.lblTypeName.TabIndex = 0;
            this.lblTypeName.Text = "短信类型";
            // 
            // lblInDate
            // 
            this.lblInDate.AutoSize = true;
            this.lblInDate.Font = new System.Drawing.Font("宋体", 12F);
            this.lblInDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblInDate.Location = new System.Drawing.Point(401, 32);
            this.lblInDate.Name = "lblInDate";
            this.lblInDate.Size = new System.Drawing.Size(89, 20);
            this.lblInDate.TabIndex = 0;
            this.lblInDate.Text = "发送日期";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 12F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblName.Location = new System.Drawing.Point(36, 118);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtSendPreview);
            this.groupBox2.Location = new System.Drawing.Point(807, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(469, 159);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发送内容预览";
            // 
            // txtSendPreview
            // 
            this.txtSendPreview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtSendPreview.Font = new System.Drawing.Font("宋体", 12F);
            this.txtSendPreview.Location = new System.Drawing.Point(3, 21);
            this.txtSendPreview.Multiline = true;
            this.txtSendPreview.Name = "txtSendPreview";
            this.txtSendPreview.Size = new System.Drawing.Size(463, 135);
            this.txtSendPreview.TabIndex = 3;
            // 
            // tPreview
            // 
            this.tPreview.Enabled = true;
            this.tPreview.Tick += new System.EventHandler(this.tPreview_Tick);
            // 
            // sStrip
            // 
            this.sStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslAlwaysSend,
            this.tsslSendSuccess});
            this.sStrip.Location = new System.Drawing.Point(0, 672);
            this.sStrip.Name = "sStrip";
            this.sStrip.Size = new System.Drawing.Size(1288, 25);
            this.sStrip.TabIndex = 3;
            this.sStrip.Text = "statusStrip1";
            // 
            // tsslAlwaysSend
            // 
            this.tsslAlwaysSend.Name = "tsslAlwaysSend";
            this.tsslAlwaysSend.Size = new System.Drawing.Size(78, 20);
            this.tsslAlwaysSend.Text = "总发送：0";
            // 
            // tsslSendSuccess
            // 
            this.tsslSendSuccess.Name = "tsslSendSuccess";
            this.tsslSendSuccess.Size = new System.Drawing.Size(93, 20);
            this.tsslSendSuccess.Text = "发送成功：0";
            // 
            // gbStatisticalFilter
            // 
            this.AcceptButton = this.btnFilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1288, 697);
            this.Controls.Add(this.sStrip);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dgvSmsInfo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "gbStatisticalFilter";
            this.Text = "短信统计";
            this.Load += new System.EventHandler(this.gbStatisticalFilter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSmsInfo)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.sStrip.ResumeLayout(false);
            this.sStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSmsInfo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboTypeName;
        private System.Windows.Forms.DateTimePicker dtpInDate;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblTypeName;
        private System.Windows.Forms.Label lblInDate;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtSendPreview;
        private System.Windows.Forms.Timer tPreview;
        private System.Windows.Forms.StatusStrip sStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslAlwaysSend;
        private System.Windows.Forms.ToolStripStatusLabel tsslSendSuccess;
    }
}