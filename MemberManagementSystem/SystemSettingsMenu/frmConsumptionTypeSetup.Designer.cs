namespace MemberManagementSystem.SystemSettingsMenu
{
    partial class frmConsumptionTypeSetup
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
            this.dgvConsumptioTypeInfo = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctmsMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUpdate = new System.Windows.Forms.ToolStripMenuItem();
            this.gbAddConsumptionType = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddConsumptionType = new System.Windows.Forms.Button();
            this.dtpDueToTime = new System.Windows.Forms.DateTimePicker();
            this.pEnable = new System.Windows.Forms.Panel();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.rbYes = new System.Windows.Forms.RadioButton();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtConsumptionTypeName = new System.Windows.Forms.TextBox();
            this.lblDueToTime = new System.Windows.Forms.Label();
            this.lblEnable = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblConsumptionTypeName = new System.Windows.Forms.Label();
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumptioTypeInfo)).BeginInit();
            this.ctmsMenu.SuspendLayout();
            this.gbAddConsumptionType.SuspendLayout();
            this.pEnable.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvConsumptioTypeInfo
            // 
            this.dgvConsumptioTypeInfo.AllowUserToAddRows = false;
            this.dgvConsumptioTypeInfo.AllowUserToResizeRows = false;
            this.dgvConsumptioTypeInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvConsumptioTypeInfo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvConsumptioTypeInfo.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.dgvConsumptioTypeInfo.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvConsumptioTypeInfo.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(25)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsumptioTypeInfo.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvConsumptioTypeInfo.ColumnHeadersHeight = 35;
            this.dgvConsumptioTypeInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvConsumptioTypeInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4});
            this.dgvConsumptioTypeInfo.ContextMenuStrip = this.ctmsMenu;
            this.dgvConsumptioTypeInfo.EnableHeadersVisualStyles = false;
            this.dgvConsumptioTypeInfo.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(50)))), ((int)(((byte)(68)))));
            this.dgvConsumptioTypeInfo.Location = new System.Drawing.Point(0, 151);
            this.dgvConsumptioTypeInfo.Margin = new System.Windows.Forms.Padding(4);
            this.dgvConsumptioTypeInfo.MultiSelect = false;
            this.dgvConsumptioTypeInfo.Name = "dgvConsumptioTypeInfo";
            this.dgvConsumptioTypeInfo.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Maroon;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvConsumptioTypeInfo.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvConsumptioTypeInfo.RowHeadersVisible = false;
            this.dgvConsumptioTypeInfo.RowHeadersWidth = 51;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(81)))), ((int)(((byte)(81)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("宋体", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(25)))), ((int)(((byte)(24)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.dgvConsumptioTypeInfo.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvConsumptioTypeInfo.RowTemplate.Height = 23;
            this.dgvConsumptioTypeInfo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvConsumptioTypeInfo.Size = new System.Drawing.Size(1378, 545);
            this.dgvConsumptioTypeInfo.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "TypeName";
            this.Column1.HeaderText = "消费类型名";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Price";
            this.Column2.HeaderText = "价格";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Enable";
            this.Column3.HeaderText = "是否启用";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DueToTime";
            this.Column4.HeaderText = "到期时间";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
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
            // gbAddConsumptionType
            // 
            this.gbAddConsumptionType.Controls.Add(this.label1);
            this.gbAddConsumptionType.Controls.Add(this.btnAddConsumptionType);
            this.gbAddConsumptionType.Controls.Add(this.dtpDueToTime);
            this.gbAddConsumptionType.Controls.Add(this.pEnable);
            this.gbAddConsumptionType.Controls.Add(this.txtPrice);
            this.gbAddConsumptionType.Controls.Add(this.txtConsumptionTypeName);
            this.gbAddConsumptionType.Controls.Add(this.lblDueToTime);
            this.gbAddConsumptionType.Controls.Add(this.lblEnable);
            this.gbAddConsumptionType.Controls.Add(this.lblPrice);
            this.gbAddConsumptionType.Controls.Add(this.lblConsumptionTypeName);
            this.gbAddConsumptionType.Font = new System.Drawing.Font("宋体", 10F);
            this.gbAddConsumptionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbAddConsumptionType.Location = new System.Drawing.Point(9, 9);
            this.gbAddConsumptionType.Name = "gbAddConsumptionType";
            this.gbAddConsumptionType.Size = new System.Drawing.Size(1268, 135);
            this.gbAddConsumptionType.TabIndex = 2;
            this.gbAddConsumptionType.TabStop = false;
            this.gbAddConsumptionType.Text = "添加消费类型";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 16F);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label1.Location = new System.Drawing.Point(855, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(363, 27);
            this.label1.TabIndex = 9;
            this.label1.Text = "选中消费类型右键可修改信息";
            // 
            // btnAddConsumptionType
            // 
            this.btnAddConsumptionType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnAddConsumptionType.FlatAppearance.BorderSize = 0;
            this.btnAddConsumptionType.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddConsumptionType.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAddConsumptionType.Location = new System.Drawing.Point(860, 83);
            this.btnAddConsumptionType.Name = "btnAddConsumptionType";
            this.btnAddConsumptionType.Size = new System.Drawing.Size(150, 35);
            this.btnAddConsumptionType.TabIndex = 7;
            this.btnAddConsumptionType.Text = "添加消费类型";
            this.btnAddConsumptionType.UseVisualStyleBackColor = false;
            this.btnAddConsumptionType.Click += new System.EventHandler(this.btnAddConsumptionType_Click);
            // 
            // dtpDueToTime
            // 
            this.dtpDueToTime.Font = new System.Drawing.Font("宋体", 12F);
            this.dtpDueToTime.Location = new System.Drawing.Point(545, 85);
            this.dtpDueToTime.Name = "dtpDueToTime";
            this.dtpDueToTime.Size = new System.Drawing.Size(260, 30);
            this.dtpDueToTime.TabIndex = 6;
            this.dtpDueToTime.Value = new System.DateTime(1999, 1, 1, 0, 0, 0, 0);
            // 
            // pEnable
            // 
            this.pEnable.Controls.Add(this.rbNo);
            this.pEnable.Controls.Add(this.rbYes);
            this.pEnable.Font = new System.Drawing.Font("宋体", 12F);
            this.pEnable.Location = new System.Drawing.Point(544, 35);
            this.pEnable.Name = "pEnable";
            this.pEnable.Size = new System.Drawing.Size(189, 29);
            this.pEnable.TabIndex = 5;
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Location = new System.Drawing.Point(103, 3);
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
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPrice.Location = new System.Drawing.Point(140, 85);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(260, 30);
            this.txtPrice.TabIndex = 3;
            // 
            // txtConsumptionTypeName
            // 
            this.txtConsumptionTypeName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtConsumptionTypeName.Location = new System.Drawing.Point(140, 34);
            this.txtConsumptionTypeName.Name = "txtConsumptionTypeName";
            this.txtConsumptionTypeName.Size = new System.Drawing.Size(260, 30);
            this.txtConsumptionTypeName.TabIndex = 3;
            // 
            // lblDueToTime
            // 
            this.lblDueToTime.AutoSize = true;
            this.lblDueToTime.Font = new System.Drawing.Font("宋体", 12F);
            this.lblDueToTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblDueToTime.Location = new System.Drawing.Point(437, 90);
            this.lblDueToTime.Name = "lblDueToTime";
            this.lblDueToTime.Size = new System.Drawing.Size(89, 20);
            this.lblDueToTime.TabIndex = 2;
            this.lblDueToTime.Text = "到期时间";
            // 
            // lblEnable
            // 
            this.lblEnable.AutoSize = true;
            this.lblEnable.Font = new System.Drawing.Font("宋体", 12F);
            this.lblEnable.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblEnable.Location = new System.Drawing.Point(437, 39);
            this.lblEnable.Name = "lblEnable";
            this.lblEnable.Size = new System.Drawing.Size(89, 20);
            this.lblEnable.TabIndex = 2;
            this.lblEnable.Text = "是否启用";
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("宋体", 12F);
            this.lblPrice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblPrice.Location = new System.Drawing.Point(79, 90);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(49, 20);
            this.lblPrice.TabIndex = 1;
            this.lblPrice.Text = "价格";
            // 
            // lblConsumptionTypeName
            // 
            this.lblConsumptionTypeName.AutoSize = true;
            this.lblConsumptionTypeName.Font = new System.Drawing.Font("宋体", 12F);
            this.lblConsumptionTypeName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblConsumptionTypeName.Location = new System.Drawing.Point(19, 39);
            this.lblConsumptionTypeName.Name = "lblConsumptionTypeName";
            this.lblConsumptionTypeName.Size = new System.Drawing.Size(109, 20);
            this.lblConsumptionTypeName.TabIndex = 0;
            this.lblConsumptionTypeName.Text = "消费类型名";
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(152, 24);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // frmConsumptionTypeSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1378, 697);
            this.Controls.Add(this.gbAddConsumptionType);
            this.Controls.Add(this.dgvConsumptioTypeInfo);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmConsumptionTypeSetup";
            this.Text = "消费类型设置";
            this.Load += new System.EventHandler(this.frmConsumptionTypeSetup_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvConsumptioTypeInfo)).EndInit();
            this.ctmsMenu.ResumeLayout(false);
            this.gbAddConsumptionType.ResumeLayout(false);
            this.gbAddConsumptionType.PerformLayout();
            this.pEnable.ResumeLayout(false);
            this.pEnable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvConsumptioTypeInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.GroupBox gbAddConsumptionType;
        private System.Windows.Forms.Button btnAddConsumptionType;
        private System.Windows.Forms.DateTimePicker dtpDueToTime;
        private System.Windows.Forms.Panel pEnable;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbYes;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtConsumptionTypeName;
        private System.Windows.Forms.Label lblDueToTime;
        private System.Windows.Forms.Label lblEnable;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblConsumptionTypeName;
        private System.Windows.Forms.ContextMenuStrip ctmsMenu;
        private System.Windows.Forms.ToolStripMenuItem tsmiUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
    }
}