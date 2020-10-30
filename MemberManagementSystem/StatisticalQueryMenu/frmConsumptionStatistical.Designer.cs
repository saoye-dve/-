namespace MemberManagementSystem.StatisticalQueryMenu
{
    partial class frmConsumptionStatistical
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvConsumptionInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gbStatisticalFilter = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.cboConsumptionPatterns = new System.Windows.Forms.ComboBox();
            this.cboMethodPayment = new System.Windows.Forms.ComboBox();
            this.cboConsumptionType = new System.Windows.Forms.ComboBox();
            this.dtpDateConsumption = new System.Windows.Forms.DateTimePicker();
            this.txtPaidinAmount = new System.Windows.Forms.TextBox();
            this.txtConsumptionAmount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.lblConsumptionPatterns = new System.Windows.Forms.Label();
            this.lblMethodPayment = new System.Windows.Forms.Label();
            this.lblPaidinAmount = new System.Windows.Forms.Label();
            this.lblConsumptionType = new System.Windows.Forms.Label();
            this.lblConsumptionAmount = new System.Windows.Forms.Label();
            this.lblDateConsumption = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.sStrip = new System.Windows.Forms.StatusStrip();
            this.tsslTotalRevenue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRealIncome = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumptionInfo)).BeginInit();
            this.gbStatisticalFilter.SuspendLayout();
            this.sStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsumptionInfo
            // 
            this.dgvConsumptionInfo.AllowUserToAddRows = false;
            this.dgvConsumptionInfo.AllowUserToResizeRows = false;
            this.dgvConsumptionInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsumptionInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsumptionInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvConsumptionInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsumptionInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(25)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsumptionInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvConsumptionInfo.ColumnHeadersHeight = 35;
            this.dgvConsumptionInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvConsumptionInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8,
            this.Column9});
            this.dgvConsumptionInfo.EnableHeadersVisualStyles = false;
            this.dgvConsumptionInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.dgvConsumptionInfo.Location = new System.Drawing.Point(0, 194);
            this.dgvConsumptionInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvConsumptionInfo.MultiSelect = false;
            this.dgvConsumptionInfo.Name = "dgvConsumptionInfo";
            this.dgvConsumptionInfo.ReadOnly = true;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsumptionInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvConsumptionInfo.RowHeadersVisible = false;
            this.dgvConsumptionInfo.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle6.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(25)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvConsumptionInfo.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvConsumptionInfo.RowTemplate.Height = 27;
            this.dgvConsumptionInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsumptionInfo.Size = new System.Drawing.Size(1288, 503);
            this.dgvConsumptionInfo.TabIndex = 0;
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
            this.Column3.DataPropertyName = "TypeName";
            this.Column3.HeaderText = "消费方式";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TypeName1";
            this.Column4.HeaderText = "支付方式";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "TypeName2";
            this.Column5.HeaderText = "消费类型";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "ConsumptionMoney";
            this.Column6.HeaderText = "消费金额";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "ActualMoney";
            this.Column7.HeaderText = "实收金额";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column8
            // 
            this.Column8.DataPropertyName = "DateConsumption";
            this.Column8.HeaderText = "消费日期";
            this.Column8.MinimumWidth = 6;
            this.Column8.Name = "Column8";
            this.Column8.ReadOnly = true;
            // 
            // Column9
            // 
            this.Column9.DataPropertyName = "Note";
            this.Column9.HeaderText = "备注";
            this.Column9.MinimumWidth = 6;
            this.Column9.Name = "Column9";
            this.Column9.ReadOnly = true;
            // 
            // gbStatisticalFilter
            // 
            this.gbStatisticalFilter.Controls.Add(this.btnFilter);
            this.gbStatisticalFilter.Controls.Add(this.cboConsumptionPatterns);
            this.gbStatisticalFilter.Controls.Add(this.cboMethodPayment);
            this.gbStatisticalFilter.Controls.Add(this.cboConsumptionType);
            this.gbStatisticalFilter.Controls.Add(this.dtpDateConsumption);
            this.gbStatisticalFilter.Controls.Add(this.txtPaidinAmount);
            this.gbStatisticalFilter.Controls.Add(this.txtConsumptionAmount);
            this.gbStatisticalFilter.Controls.Add(this.txtName);
            this.gbStatisticalFilter.Controls.Add(this.txtCardNo);
            this.gbStatisticalFilter.Controls.Add(this.lblConsumptionPatterns);
            this.gbStatisticalFilter.Controls.Add(this.lblMethodPayment);
            this.gbStatisticalFilter.Controls.Add(this.lblPaidinAmount);
            this.gbStatisticalFilter.Controls.Add(this.lblConsumptionType);
            this.gbStatisticalFilter.Controls.Add(this.lblConsumptionAmount);
            this.gbStatisticalFilter.Controls.Add(this.lblDateConsumption);
            this.gbStatisticalFilter.Controls.Add(this.lblName);
            this.gbStatisticalFilter.Controls.Add(this.lblCardNo);
            this.gbStatisticalFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbStatisticalFilter.Font = new System.Drawing.Font("宋体", 10F);
            this.gbStatisticalFilter.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbStatisticalFilter.Location = new System.Drawing.Point(10, 7);
            this.gbStatisticalFilter.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbStatisticalFilter.Name = "gbStatisticalFilter";
            this.gbStatisticalFilter.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbStatisticalFilter.Size = new System.Drawing.Size(1268, 179);
            this.gbStatisticalFilter.TabIndex = 1;
            this.gbStatisticalFilter.TabStop = false;
            this.gbStatisticalFilter.Text = "统计筛选";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFilter.Location = new System.Drawing.Point(977, 128);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(150, 35);
            this.btnFilter.TabIndex = 5;
            this.btnFilter.Text = "筛选";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // cboConsumptionPatterns
            // 
            this.cboConsumptionPatterns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsumptionPatterns.Font = new System.Drawing.Font("宋体", 12F);
            this.cboConsumptionPatterns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboConsumptionPatterns.FormattingEnabled = true;
            this.cboConsumptionPatterns.Location = new System.Drawing.Point(125, 130);
            this.cboConsumptionPatterns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboConsumptionPatterns.Name = "cboConsumptionPatterns";
            this.cboConsumptionPatterns.Size = new System.Drawing.Size(260, 28);
            this.cboConsumptionPatterns.TabIndex = 3;
            // 
            // cboMethodPayment
            // 
            this.cboMethodPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMethodPayment.Font = new System.Drawing.Font("宋体", 12F);
            this.cboMethodPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboMethodPayment.FormattingEnabled = true;
            this.cboMethodPayment.Location = new System.Drawing.Point(532, 31);
            this.cboMethodPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMethodPayment.Name = "cboMethodPayment";
            this.cboMethodPayment.Size = new System.Drawing.Size(260, 28);
            this.cboMethodPayment.TabIndex = 3;
            // 
            // cboConsumptionType
            // 
            this.cboConsumptionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsumptionType.Font = new System.Drawing.Font("宋体", 12F);
            this.cboConsumptionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.cboConsumptionType.FormattingEnabled = true;
            this.cboConsumptionType.Location = new System.Drawing.Point(532, 82);
            this.cboConsumptionType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboConsumptionType.Name = "cboConsumptionType";
            this.cboConsumptionType.Size = new System.Drawing.Size(260, 28);
            this.cboConsumptionType.TabIndex = 3;
            // 
            // dtpDateConsumption
            // 
            this.dtpDateConsumption.Font = new System.Drawing.Font("宋体", 12F);
            this.dtpDateConsumption.Location = new System.Drawing.Point(943, 81);
            this.dtpDateConsumption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpDateConsumption.Name = "dtpDateConsumption";
            this.dtpDateConsumption.Size = new System.Drawing.Size(260, 30);
            this.dtpDateConsumption.TabIndex = 2;
            this.dtpDateConsumption.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // txtPaidinAmount
            // 
            this.txtPaidinAmount.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPaidinAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtPaidinAmount.Location = new System.Drawing.Point(942, 30);
            this.txtPaidinAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaidinAmount.Name = "txtPaidinAmount";
            this.txtPaidinAmount.Size = new System.Drawing.Size(260, 30);
            this.txtPaidinAmount.TabIndex = 1;
            // 
            // txtConsumptionAmount
            // 
            this.txtConsumptionAmount.Font = new System.Drawing.Font("宋体", 12F);
            this.txtConsumptionAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtConsumptionAmount.Location = new System.Drawing.Point(532, 129);
            this.txtConsumptionAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtConsumptionAmount.Name = "txtConsumptionAmount";
            this.txtConsumptionAmount.Size = new System.Drawing.Size(260, 30);
            this.txtConsumptionAmount.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtName.Location = new System.Drawing.Point(125, 81);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 30);
            this.txtName.TabIndex = 1;
            // 
            // txtCardNo
            // 
            this.txtCardNo.Font = new System.Drawing.Font("宋体", 12F);
            this.txtCardNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtCardNo.Location = new System.Drawing.Point(125, 30);
            this.txtCardNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(260, 30);
            this.txtCardNo.TabIndex = 1;
            // 
            // lblConsumptionPatterns
            // 
            this.lblConsumptionPatterns.AutoSize = true;
            this.lblConsumptionPatterns.Font = new System.Drawing.Font("宋体", 12F);
            this.lblConsumptionPatterns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblConsumptionPatterns.Location = new System.Drawing.Point(23, 134);
            this.lblConsumptionPatterns.Name = "lblConsumptionPatterns";
            this.lblConsumptionPatterns.Size = new System.Drawing.Size(89, 20);
            this.lblConsumptionPatterns.TabIndex = 0;
            this.lblConsumptionPatterns.Text = "消费方式";
            // 
            // lblMethodPayment
            // 
            this.lblMethodPayment.AutoSize = true;
            this.lblMethodPayment.Font = new System.Drawing.Font("宋体", 12F);
            this.lblMethodPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblMethodPayment.Location = new System.Drawing.Point(429, 35);
            this.lblMethodPayment.Name = "lblMethodPayment";
            this.lblMethodPayment.Size = new System.Drawing.Size(89, 20);
            this.lblMethodPayment.TabIndex = 0;
            this.lblMethodPayment.Text = "支付方式";
            // 
            // lblPaidinAmount
            // 
            this.lblPaidinAmount.AutoSize = true;
            this.lblPaidinAmount.Font = new System.Drawing.Font("宋体", 12F);
            this.lblPaidinAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblPaidinAmount.Location = new System.Drawing.Point(841, 35);
            this.lblPaidinAmount.Name = "lblPaidinAmount";
            this.lblPaidinAmount.Size = new System.Drawing.Size(89, 20);
            this.lblPaidinAmount.TabIndex = 0;
            this.lblPaidinAmount.Text = "实收金额";
            // 
            // lblConsumptionType
            // 
            this.lblConsumptionType.AutoSize = true;
            this.lblConsumptionType.Font = new System.Drawing.Font("宋体", 12F);
            this.lblConsumptionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblConsumptionType.Location = new System.Drawing.Point(429, 86);
            this.lblConsumptionType.Name = "lblConsumptionType";
            this.lblConsumptionType.Size = new System.Drawing.Size(89, 20);
            this.lblConsumptionType.TabIndex = 0;
            this.lblConsumptionType.Text = "消费类型";
            // 
            // lblConsumptionAmount
            // 
            this.lblConsumptionAmount.AutoSize = true;
            this.lblConsumptionAmount.Font = new System.Drawing.Font("宋体", 12F);
            this.lblConsumptionAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblConsumptionAmount.Location = new System.Drawing.Point(427, 134);
            this.lblConsumptionAmount.Name = "lblConsumptionAmount";
            this.lblConsumptionAmount.Size = new System.Drawing.Size(89, 20);
            this.lblConsumptionAmount.TabIndex = 0;
            this.lblConsumptionAmount.Text = "消费金额";
            // 
            // lblDateConsumption
            // 
            this.lblDateConsumption.AutoSize = true;
            this.lblDateConsumption.Font = new System.Drawing.Font("宋体", 12F);
            this.lblDateConsumption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblDateConsumption.Location = new System.Drawing.Point(841, 86);
            this.lblDateConsumption.Name = "lblDateConsumption";
            this.lblDateConsumption.Size = new System.Drawing.Size(89, 20);
            this.lblDateConsumption.TabIndex = 0;
            this.lblDateConsumption.Text = "消费日期";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 12F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblName.Location = new System.Drawing.Point(63, 86);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "姓名";
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Font = new System.Drawing.Font("宋体", 12F);
            this.lblCardNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblCardNo.Location = new System.Drawing.Point(63, 35);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(49, 20);
            this.lblCardNo.TabIndex = 0;
            this.lblCardNo.Text = "卡号";
            // 
            // sStrip
            // 
            this.sStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotalRevenue,
            this.tsslRealIncome});
            this.sStrip.Location = new System.Drawing.Point(0, 672);
            this.sStrip.Name = "sStrip";
            this.sStrip.Size = new System.Drawing.Size(1288, 25);
            this.sStrip.TabIndex = 2;
            this.sStrip.Text = "statusStrip1";
            // 
            // tsslTotalRevenue
            // 
            this.tsslTotalRevenue.Name = "tsslTotalRevenue";
            this.tsslTotalRevenue.Size = new System.Drawing.Size(78, 20);
            this.tsslTotalRevenue.Text = "总收入：0";
            // 
            // tsslRealIncome
            // 
            this.tsslRealIncome.Name = "tsslRealIncome";
            this.tsslRealIncome.Size = new System.Drawing.Size(108, 20);
            this.tsslRealIncome.Text = "总实际收入：0";
            // 
            // frmConsumptionStatistical
            // 
            this.AcceptButton = this.btnFilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1288, 697);
            this.Controls.Add(this.sStrip);
            this.Controls.Add(this.gbStatisticalFilter);
            this.Controls.Add(this.dgvConsumptionInfo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConsumptionStatistical";
            this.Text = "消费统计";
            this.Load += new System.EventHandler(this.frmConsumptionStatistical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumptionInfo)).EndInit();
            this.gbStatisticalFilter.ResumeLayout(false);
            this.gbStatisticalFilter.PerformLayout();
            this.sStrip.ResumeLayout(false);
            this.sStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsumptionInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column9;
        private System.Windows.Forms.GroupBox gbStatisticalFilter;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.ComboBox cboConsumptionPatterns;
        private System.Windows.Forms.ComboBox cboMethodPayment;
        private System.Windows.Forms.ComboBox cboConsumptionType;
        private System.Windows.Forms.DateTimePicker dtpDateConsumption;
        private System.Windows.Forms.TextBox txtPaidinAmount;
        private System.Windows.Forms.TextBox txtConsumptionAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label lblConsumptionPatterns;
        private System.Windows.Forms.Label lblMethodPayment;
        private System.Windows.Forms.Label lblPaidinAmount;
        private System.Windows.Forms.Label lblConsumptionType;
        private System.Windows.Forms.Label lblConsumptionAmount;
        private System.Windows.Forms.Label lblDateConsumption;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.StatusStrip sStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalRevenue;
        private System.Windows.Forms.ToolStripStatusLabel tsslRealIncome;
    }
}