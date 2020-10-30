namespace MemberManagementSystem.StatisticalQueryMenu
{
    partial class frmPayStatistical
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dgvPayStatisticalInfo = new System.Windows.Forms.DataGridView();
            this.gbScreeningStatistical = new System.Windows.Forms.GroupBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dtpTopupDate = new System.Windows.Forms.DateTimePicker();
            this.cboMethodPayment = new System.Windows.Forms.ComboBox();
            this.txtPaidinAmount = new System.Windows.Forms.TextBox();
            this.txtTopupAmount = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.lblTopupDate = new System.Windows.Forms.Label();
            this.lblPaidinAmount = new System.Windows.Forms.Label();
            this.lblMethodPayment = new System.Windows.Forms.Label();
            this.lblTopupAmount = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPaymentName = new System.Windows.Forms.TextBox();
            this.sStrip = new System.Windows.Forms.StatusStrip();
            this.tsslTotalRevenue = new System.Windows.Forms.ToolStripStatusLabel();
            this.tsslRealIncome = new System.Windows.Forms.ToolStripStatusLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayStatisticalInfo)).BeginInit();
            this.gbScreeningStatistical.SuspendLayout();
            this.sStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvPayStatisticalInfo
            // 
            this.dgvPayStatisticalInfo.AllowUserToAddRows = false;
            this.dgvPayStatisticalInfo.AllowUserToResizeRows = false;
            this.dgvPayStatisticalInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvPayStatisticalInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayStatisticalInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvPayStatisticalInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvPayStatisticalInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(25)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayStatisticalInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvPayStatisticalInfo.ColumnHeadersHeight = 35;
            this.dgvPayStatisticalInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvPayStatisticalInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column7,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dgvPayStatisticalInfo.EnableHeadersVisualStyles = false;
            this.dgvPayStatisticalInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.dgvPayStatisticalInfo.Location = new System.Drawing.Point(0, 173);
            this.dgvPayStatisticalInfo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvPayStatisticalInfo.MultiSelect = false;
            this.dgvPayStatisticalInfo.Name = "dgvPayStatisticalInfo";
            this.dgvPayStatisticalInfo.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvPayStatisticalInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvPayStatisticalInfo.RowHeadersVisible = false;
            this.dgvPayStatisticalInfo.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(25)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvPayStatisticalInfo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvPayStatisticalInfo.RowTemplate.Height = 27;
            this.dgvPayStatisticalInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvPayStatisticalInfo.Size = new System.Drawing.Size(1290, 524);
            this.dgvPayStatisticalInfo.TabIndex = 0;
            // 
            // gbScreeningStatistical
            // 
            this.gbScreeningStatistical.Controls.Add(this.btnFilter);
            this.gbScreeningStatistical.Controls.Add(this.dtpTopupDate);
            this.gbScreeningStatistical.Controls.Add(this.cboMethodPayment);
            this.gbScreeningStatistical.Controls.Add(this.txtPaidinAmount);
            this.gbScreeningStatistical.Controls.Add(this.txtTopupAmount);
            this.gbScreeningStatistical.Controls.Add(this.txtPaymentName);
            this.gbScreeningStatistical.Controls.Add(this.txtName);
            this.gbScreeningStatistical.Controls.Add(this.txtCardNo);
            this.gbScreeningStatistical.Controls.Add(this.label6);
            this.gbScreeningStatistical.Controls.Add(this.lblTopupDate);
            this.gbScreeningStatistical.Controls.Add(this.lblPaidinAmount);
            this.gbScreeningStatistical.Controls.Add(this.lblMethodPayment);
            this.gbScreeningStatistical.Controls.Add(this.label1);
            this.gbScreeningStatistical.Controls.Add(this.lblTopupAmount);
            this.gbScreeningStatistical.Controls.Add(this.lblName);
            this.gbScreeningStatistical.Controls.Add(this.lblCardNo);
            this.gbScreeningStatistical.Font = new System.Drawing.Font("宋体", 10F);
            this.gbScreeningStatistical.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbScreeningStatistical.Location = new System.Drawing.Point(12, 8);
            this.gbScreeningStatistical.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbScreeningStatistical.Name = "gbScreeningStatistical";
            this.gbScreeningStatistical.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbScreeningStatistical.Size = new System.Drawing.Size(1264, 160);
            this.gbScreeningStatistical.TabIndex = 1;
            this.gbScreeningStatistical.TabStop = false;
            this.gbScreeningStatistical.Text = "筛选统计";
            // 
            // btnFilter
            // 
            this.btnFilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnFilter.FlatAppearance.BorderSize = 0;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnFilter.Location = new System.Drawing.Point(973, 94);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(150, 35);
            this.btnFilter.TabIndex = 6;
            this.btnFilter.Text = "筛选";
            this.btnFilter.UseVisualStyleBackColor = false;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // dtpTopupDate
            // 
            this.dtpTopupDate.Font = new System.Drawing.Font("宋体", 12F);
            this.dtpTopupDate.Location = new System.Drawing.Point(556, 114);
            this.dtpTopupDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpTopupDate.Name = "dtpTopupDate";
            this.dtpTopupDate.Size = new System.Drawing.Size(260, 30);
            this.dtpTopupDate.TabIndex = 3;
            this.dtpTopupDate.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // cboMethodPayment
            // 
            this.cboMethodPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMethodPayment.Font = new System.Drawing.Font("宋体", 12F);
            this.cboMethodPayment.FormattingEnabled = true;
            this.cboMethodPayment.Location = new System.Drawing.Point(556, 73);
            this.cboMethodPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMethodPayment.Name = "cboMethodPayment";
            this.cboMethodPayment.Size = new System.Drawing.Size(260, 28);
            this.cboMethodPayment.TabIndex = 2;
            // 
            // txtPaidinAmount
            // 
            this.txtPaidinAmount.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPaidinAmount.Location = new System.Drawing.Point(556, 30);
            this.txtPaidinAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaidinAmount.Name = "txtPaidinAmount";
            this.txtPaidinAmount.Size = new System.Drawing.Size(260, 30);
            this.txtPaidinAmount.TabIndex = 1;
            // 
            // txtTopupAmount
            // 
            this.txtTopupAmount.Font = new System.Drawing.Font("宋体", 12F);
            this.txtTopupAmount.Location = new System.Drawing.Point(144, 114);
            this.txtTopupAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTopupAmount.Name = "txtTopupAmount";
            this.txtTopupAmount.Size = new System.Drawing.Size(260, 30);
            this.txtTopupAmount.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtName.Location = new System.Drawing.Point(144, 72);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(260, 30);
            this.txtName.TabIndex = 1;
            // 
            // txtCardNo
            // 
            this.txtCardNo.Font = new System.Drawing.Font("宋体", 12F);
            this.txtCardNo.Location = new System.Drawing.Point(144, 30);
            this.txtCardNo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.Size = new System.Drawing.Size(260, 30);
            this.txtCardNo.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.Location = new System.Drawing.Point(236, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 20);
            this.label6.TabIndex = 0;
            // 
            // lblTopupDate
            // 
            this.lblTopupDate.AutoSize = true;
            this.lblTopupDate.Font = new System.Drawing.Font("宋体", 12F);
            this.lblTopupDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblTopupDate.Location = new System.Drawing.Point(451, 119);
            this.lblTopupDate.Name = "lblTopupDate";
            this.lblTopupDate.Size = new System.Drawing.Size(89, 20);
            this.lblTopupDate.TabIndex = 0;
            this.lblTopupDate.Text = "充值日期";
            // 
            // lblPaidinAmount
            // 
            this.lblPaidinAmount.AutoSize = true;
            this.lblPaidinAmount.Font = new System.Drawing.Font("宋体", 12F);
            this.lblPaidinAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblPaidinAmount.Location = new System.Drawing.Point(451, 35);
            this.lblPaidinAmount.Name = "lblPaidinAmount";
            this.lblPaidinAmount.Size = new System.Drawing.Size(89, 20);
            this.lblPaidinAmount.TabIndex = 0;
            this.lblPaidinAmount.Text = "实收金额";
            // 
            // lblMethodPayment
            // 
            this.lblMethodPayment.AutoSize = true;
            this.lblMethodPayment.Font = new System.Drawing.Font("宋体", 12F);
            this.lblMethodPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblMethodPayment.Location = new System.Drawing.Point(451, 77);
            this.lblMethodPayment.Name = "lblMethodPayment";
            this.lblMethodPayment.Size = new System.Drawing.Size(89, 20);
            this.lblMethodPayment.TabIndex = 0;
            this.lblMethodPayment.Text = "支付方式";
            // 
            // lblTopupAmount
            // 
            this.lblTopupAmount.AutoSize = true;
            this.lblTopupAmount.Font = new System.Drawing.Font("宋体", 12F);
            this.lblTopupAmount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblTopupAmount.Location = new System.Drawing.Point(32, 119);
            this.lblTopupAmount.Name = "lblTopupAmount";
            this.lblTopupAmount.Size = new System.Drawing.Size(89, 20);
            this.lblTopupAmount.TabIndex = 0;
            this.lblTopupAmount.Text = "充值金额";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 12F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblName.Location = new System.Drawing.Point(72, 77);
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
            this.lblCardNo.Location = new System.Drawing.Point(72, 35);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(49, 20);
            this.lblCardNo.TabIndex = 0;
            this.lblCardNo.Text = "卡号";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "CardNo";
            this.Column1.HeaderText = "卡号";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "Name";
            this.Column7.HeaderText = "姓名";
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PaymentName";
            this.Column2.HeaderText = "付款人姓名";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Credit";
            this.Column3.HeaderText = "充值金额";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "ActualMoney";
            this.Column4.HeaderText = "实收金额";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "CreDate";
            this.Column5.HeaderText = "充值日期";
            this.Column5.MinimumWidth = 6;
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "TypeName";
            this.Column6.HeaderText = "支付方式";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 12F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(849, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "付款人姓名";
            // 
            // txtPaymentName
            // 
            this.txtPaymentName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPaymentName.Location = new System.Drawing.Point(964, 30);
            this.txtPaymentName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaymentName.Name = "txtPaymentName";
            this.txtPaymentName.Size = new System.Drawing.Size(260, 30);
            this.txtPaymentName.TabIndex = 1;
            // 
            // sStrip
            // 
            this.sStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsslTotalRevenue,
            this.tsslRealIncome});
            this.sStrip.Location = new System.Drawing.Point(0, 672);
            this.sStrip.Name = "sStrip";
            this.sStrip.Size = new System.Drawing.Size(1288, 25);
            this.sStrip.TabIndex = 3;
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
            // frmPayStatistical
            // 
            this.AcceptButton = this.btnFilter;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1288, 697);
            this.Controls.Add(this.sStrip);
            this.Controls.Add(this.gbScreeningStatistical);
            this.Controls.Add(this.dgvPayStatisticalInfo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmPayStatistical";
            this.Text = "充值统计";
            this.Load += new System.EventHandler(this.frmPayStatistical_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayStatisticalInfo)).EndInit();
            this.gbScreeningStatistical.ResumeLayout(false);
            this.gbScreeningStatistical.PerformLayout();
            this.sStrip.ResumeLayout(false);
            this.sStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvPayStatisticalInfo;
        private System.Windows.Forms.GroupBox gbScreeningStatistical;
        private System.Windows.Forms.DateTimePicker dtpTopupDate;
        private System.Windows.Forms.ComboBox cboMethodPayment;
        private System.Windows.Forms.TextBox txtTopupAmount;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblTopupDate;
        private System.Windows.Forms.Label lblMethodPayment;
        private System.Windows.Forms.Label lblTopupAmount;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.TextBox txtPaidinAmount;
        private System.Windows.Forms.Label lblPaidinAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.TextBox txtPaymentName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip sStrip;
        private System.Windows.Forms.ToolStripStatusLabel tsslTotalRevenue;
        private System.Windows.Forms.ToolStripStatusLabel tsslRealIncome;
    }
}