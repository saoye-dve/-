namespace MemberManagementSystem.SystemSettingsMenu
{
    partial class frmUserLevelSetup
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
            this.dgvUserLevelInfo = new System.Windows.Forms.DataGridView();
            this.MembersName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.money = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Discount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAddUserlLevel = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddLevel = new System.Windows.Forms.Button();
            this.dtpDueToTime = new System.Windows.Forms.DateTimePicker();
            this.pEnable = new System.Windows.Forms.Panel();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtLevelName = new System.Windows.Forms.TextBox();
            this.lblDueToTime = new System.Windows.Forms.Label();
            this.lblEnable = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblLevelName = new System.Windows.Forms.Label();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserLevelInfo)).BeginInit();
            this.ctmsMenu.SuspendLayout();
            this.gbAddUserlLevel.SuspendLayout();
            this.pEnable.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUserLevelInfo
            // 
            this.dgvUserLevelInfo.AllowUserToAddRows = false;
            this.dgvUserLevelInfo.AllowUserToResizeRows = false;
            this.dgvUserLevelInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvUserLevelInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserLevelInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvUserLevelInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUserLevelInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(25)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserLevelInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUserLevelInfo.ColumnHeadersHeight = 35;
            this.dgvUserLevelInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvUserLevelInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MembersName,
            this.money,
            this.Discount,
            this.Column6,
            this.Column7});
            this.dgvUserLevelInfo.ContextMenuStrip = this.ctmsMenu;
            this.dgvUserLevelInfo.EnableHeadersVisualStyles = false;
            this.dgvUserLevelInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.dgvUserLevelInfo.Location = new System.Drawing.Point(0, 167);
            this.dgvUserLevelInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvUserLevelInfo.MultiSelect = false;
            this.dgvUserLevelInfo.Name = "dgvUserLevelInfo";
            this.dgvUserLevelInfo.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUserLevelInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUserLevelInfo.RowHeadersVisible = false;
            this.dgvUserLevelInfo.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(25)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvUserLevelInfo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUserLevelInfo.RowTemplate.Height = 23;
            this.dgvUserLevelInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserLevelInfo.Size = new System.Drawing.Size(1267, 530);
            this.dgvUserLevelInfo.TabIndex = 0;
            // 
            // MembersName
            // 
            this.MembersName.DataPropertyName = "MembersName";
            this.MembersName.HeaderText = "会员等级名称";
            this.MembersName.MinimumWidth = 6;
            this.MembersName.Name = "MembersName";
            this.MembersName.ReadOnly = true;
            // 
            // money
            // 
            this.money.DataPropertyName = "money";
            this.money.HeaderText = "价格";
            this.money.MinimumWidth = 6;
            this.money.Name = "money";
            this.money.ReadOnly = true;
            // 
            // Discount
            // 
            this.Discount.DataPropertyName = "Discount";
            this.Discount.HeaderText = "折扣";
            this.Discount.MinimumWidth = 6;
            this.Discount.Name = "Discount";
            this.Discount.ReadOnly = true;
            // 
            // Column6
            // 
            this.Column6.DataPropertyName = "Enable";
            this.Column6.HeaderText = "是否启用";
            this.Column6.MinimumWidth = 6;
            this.Column6.Name = "Column6";
            this.Column6.ReadOnly = true;
            // 
            // Column7
            // 
            this.Column7.DataPropertyName = "DueToTime";
            this.Column7.HeaderText = "到期时间";
            this.Column7.MinimumWidth = 6;
            this.Column7.Name = "Column7";
            this.Column7.ReadOnly = true;
            // 
            // ctmsMenu
            // 
            this.ctmsMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ctmsMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUpdate,
            this.tsmiDelete});
            this.ctmsMenu.Name = "ctmsMenu";
            this.ctmsMenu.Size = new System.Drawing.Size(153, 74);
            // 
            // tsmiUpdate
            // 
            this.tsmiUpdate.Name = "tsmiUpdate";
            this.tsmiUpdate.Size = new System.Drawing.Size(152, 24);
            this.tsmiUpdate.Text = "修改";
            this.tsmiUpdate.Click += new System.EventHandler(this.tsmiUpdate_Click);
            // 
            // gbAddUserlLevel
            // 
            this.gbAddUserlLevel.Controls.Add(this.label1);
            this.gbAddUserlLevel.Controls.Add(this.btnAddLevel);
            this.gbAddUserlLevel.Controls.Add(this.dtpDueToTime);
            this.gbAddUserlLevel.Controls.Add(this.pEnable);
            this.gbAddUserlLevel.Controls.Add(this.txtDiscount);
            this.gbAddUserlLevel.Controls.Add(this.txtPrice);
            this.gbAddUserlLevel.Controls.Add(this.txtLevelName);
            this.gbAddUserlLevel.Controls.Add(this.lblDueToTime);
            this.gbAddUserlLevel.Controls.Add(this.lblEnable);
            this.gbAddUserlLevel.Controls.Add(this.lblDiscount);
            this.gbAddUserlLevel.Controls.Add(this.lblPrice);
            this.gbAddUserlLevel.Controls.Add(this.lblLevelName);
            this.gbAddUserlLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbAddUserlLevel.Location = new System.Drawing.Point(12, 12);
            this.gbAddUserlLevel.Name = "gbAddUserlLevel";
            this.gbAddUserlLevel.Size = new System.Drawing.Size(1243, 148);
            this.gbAddUserlLevel.TabIndex = 1;
            this.gbAddUserlLevel.TabStop = false;
            this.gbAddUserlLevel.Text = "添加会员等级";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(815, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 27);
            this.label1.TabIndex = 10;
            this.label1.Text = "选中会员等级右键可修改信息";
            // 
            // btnAddLevel
            // 
            this.btnAddLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnAddLevel.FlatAppearance.BorderSize = 0;
            this.btnAddLevel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddLevel.Font = new System.Drawing.Font("宋体", 10F);
            this.btnAddLevel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddLevel.Location = new System.Drawing.Point(925, 90);
            this.btnAddLevel.Name = "btnAddLevel";
            this.btnAddLevel.Size = new System.Drawing.Size(150, 35);
            this.btnAddLevel.TabIndex = 7;
            this.btnAddLevel.Text = "添加等级";
            this.btnAddLevel.UseVisualStyleBackColor = false;
            this.btnAddLevel.Click += new System.EventHandler(this.btnAddLevel_Click);
            // 
            // dtpDueToTime
            // 
            this.dtpDueToTime.Location = new System.Drawing.Point(528, 95);
            this.dtpDueToTime.Name = "dtpDueToTime";
            this.dtpDueToTime.Size = new System.Drawing.Size(260, 30);
            this.dtpDueToTime.TabIndex = 6;
            this.dtpDueToTime.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // pEnable
            // 
            this.pEnable.Controls.Add(this.rbNo);
            this.pEnable.Controls.Add(this.rbYes);
            this.pEnable.Location = new System.Drawing.Point(530, 42);
            this.pEnable.Name = "pEnable";
            this.pEnable.Size = new System.Drawing.Size(189, 29);
            this.pEnable.TabIndex = 5;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(86, 3);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(70, 24);
            this.rbNo.TabIndex = 4;
            this.rbNo.Text = "禁用";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // rbYes
            // 
            this.rbYes.AutoSize = true;
            this.rbYes.Checked = true;
            this.rbYes.Location = new System.Drawing.Point(3, 3);
            this.rbYes.Name = "rbYes";
            this.rbYes.Size = new System.Drawing.Size(70, 24);
            this.rbYes.TabIndex = 4;
            this.rbYes.TabStop = true;
            this.rbYes.Text = "启用";
            this.rbYes.UseVisualStyleBackColor = true;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(118, 107);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(260, 30);
            this.txtDiscount.TabIndex = 3;
            // 
            // txtPrice
            // 
            this.txtPrice.Location = new System.Drawing.Point(118, 68);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(260, 30);
            this.txtPrice.TabIndex = 3;
            // 
            // txtLevelName
            // 
            this.txtLevelName.Location = new System.Drawing.Point(118, 30);
            this.txtLevelName.Name = "txtLevelName";
            this.txtLevelName.Size = new System.Drawing.Size(260, 30);
            this.txtLevelName.TabIndex = 3;
            // 
            // lblDueToTime
            // 
            this.lblDueToTime.AutoSize = true;
            this.lblDueToTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblDueToTime.Location = new System.Drawing.Point(420, 99);
            this.lblDueToTime.Name = "lblDueToTime";
            this.lblDueToTime.Size = new System.Drawing.Size(89, 20);
            this.lblDueToTime.TabIndex = 2;
            this.lblDueToTime.Text = "到期时间";
            // 
            // lblEnable
            // 
            this.lblEnable.AutoSize = true;
            this.lblEnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblEnable.Location = new System.Drawing.Point(420, 46);
            this.lblEnable.Name = "lblEnable";
            this.lblEnable.Size = new System.Drawing.Size(89, 20);
            this.lblEnable.TabIndex = 2;
            this.lblEnable.Text = "是否启用";
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblDiscount.Location = new System.Drawing.Point(58, 110);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(49, 20);
            this.lblDiscount.TabIndex = 2;
            this.lblDiscount.Text = "折扣";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblPrice.Location = new System.Drawing.Point(58, 74);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 20);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "价格";
            // 
            // lblLevelName
            // 
            this.lblLevelName.AutoSize = true;
            this.lblLevelName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblLevelName.Location = new System.Drawing.Point(18, 33);
            this.lblLevelName.Name = "lblLevelName";
            this.lblLevelName.Size = new System.Drawing.Size(89, 20);
            this.lblLevelName.TabIndex = 0;
            this.lblLevelName.Text = "等级名称";
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(152, 24);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // frmUserLevelSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1267, 697);
            this.Controls.Add(this.gbAddUserlLevel);
            this.Controls.Add(this.dgvUserLevelInfo);
            this.Font = new System.Drawing.Font("宋体", 12F);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUserLevelSetup";
            this.Text = "会员等级设置";
            this.Load += new System.EventHandler(this.frmUserLevelSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserLevelInfo)).EndInit();
            this.ctmsMenu.ResumeLayout(false);
            this.gbAddUserlLevel.ResumeLayout(false);
            this.gbAddUserlLevel.PerformLayout();
            this.pEnable.ResumeLayout(false);
            this.pEnable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserLevelInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn MembersName;
        private System.Windows.Forms.DataGridViewTextBoxColumn money;
        private System.Windows.Forms.DataGridViewTextBoxColumn Discount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.GroupBox gbAddUserlLevel;
        private System.Windows.Forms.Label lblDueToTime;
        private System.Windows.Forms.Label lblEnable;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblLevelName;
        private System.Windows.Forms.DateTimePicker dtpDueToTime;
        private System.Windows.Forms.Panel pEnable;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtLevelName;
        private System.Windows.Forms.Button btnAddLevel;
        private System.Windows.Forms.ContextMenuStrip ctmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}