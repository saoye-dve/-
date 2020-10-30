namespace MemberManagementSystem
{
    partial class frmUserConsumption
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
            this.lblConsumptionType = new System.Windows.Forms.Label();
            this.cboConsumptionType = new System.Windows.Forms.ComboBox();
            this.gbDirectConsumption = new System.Windows.Forms.GroupBox();
            this.dgvConsumptionDate = new System.Windows.Forms.DateTimePicker();
            this.lblConsumptionDate = new System.Windows.Forms.Label();
            this.cboConsumptionPatterns = new System.Windows.Forms.ComboBox();
            this.lblConsumptionPatterns = new System.Windows.Forms.Label();
            this.txtNote = new System.Windows.Forms.TextBox();
            this.lblNote = new System.Windows.Forms.Label();
            this.cboMethodPayment = new System.Windows.Forms.ComboBox();
            this.lblMethodPayment = new System.Windows.Forms.Label();
            this.txtPaidinAmount = new System.Windows.Forms.TextBox();
            this.txtPwd = new System.Windows.Forms.TextBox();
            this.txtActualMoney = new System.Windows.Forms.TextBox();
            this.txtShouldBeMoney = new System.Windows.Forms.TextBox();
            this.lblPwd = new System.Windows.Forms.Label();
            this.lblDateConsumption = new System.Windows.Forms.Label();
            this.lblActualMoney = new System.Windows.Forms.Label();
            this.lblShouldBeMoney = new System.Windows.Forms.Label();
            this.btnConsumption = new System.Windows.Forms.Button();
            this.gbUserInfo = new System.Windows.Forms.GroupBox();
            this.txtMembersName = new System.Windows.Forms.TextBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.lblMembersName = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.lblMoney = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblCardNo = new System.Windows.Forms.Label();
            this.gbQueryMethods = new System.Windows.Forms.GroupBox();
            this.txtQueryNo = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.gbCodeScann = new System.Windows.Forms.GroupBox();
            this.pCodeScann = new System.Windows.Forms.Panel();
            this.tQrCode = new System.Windows.Forms.Timer(this.components);
            this.gbDirectConsumption.SuspendLayout();
            this.gbUserInfo.SuspendLayout();
            this.gbQueryMethods.SuspendLayout();
            this.gbCodeScann.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblConsumptionType
            // 
            this.lblConsumptionType.AutoSize = true;
            this.lblConsumptionType.Font = new System.Drawing.Font("宋体", 12F);
            this.lblConsumptionType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblConsumptionType.Location = new System.Drawing.Point(43, 46);
            this.lblConsumptionType.Name = "lblConsumptionType";
            this.lblConsumptionType.Size = new System.Drawing.Size(89, 20);
            this.lblConsumptionType.TabIndex = 0;
            this.lblConsumptionType.Text = "消费类型";
            // 
            // cboConsumptionType
            // 
            this.cboConsumptionType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsumptionType.Font = new System.Drawing.Font("宋体", 12F);
            this.cboConsumptionType.FormattingEnabled = true;
            this.cboConsumptionType.Location = new System.Drawing.Point(152, 42);
            this.cboConsumptionType.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboConsumptionType.Name = "cboConsumptionType";
            this.cboConsumptionType.Size = new System.Drawing.Size(382, 28);
            this.cboConsumptionType.TabIndex = 1;
            this.cboConsumptionType.SelectedIndexChanged += new System.EventHandler(this.cboConsumptionType_SelectedIndexChanged);
            // 
            // gbDirectConsumption
            // 
            this.gbDirectConsumption.Controls.Add(this.dgvConsumptionDate);
            this.gbDirectConsumption.Controls.Add(this.lblConsumptionDate);
            this.gbDirectConsumption.Controls.Add(this.cboConsumptionPatterns);
            this.gbDirectConsumption.Controls.Add(this.lblConsumptionPatterns);
            this.gbDirectConsumption.Controls.Add(this.txtNote);
            this.gbDirectConsumption.Controls.Add(this.lblNote);
            this.gbDirectConsumption.Controls.Add(this.cboMethodPayment);
            this.gbDirectConsumption.Controls.Add(this.lblMethodPayment);
            this.gbDirectConsumption.Controls.Add(this.txtPaidinAmount);
            this.gbDirectConsumption.Controls.Add(this.txtPwd);
            this.gbDirectConsumption.Controls.Add(this.txtActualMoney);
            this.gbDirectConsumption.Controls.Add(this.txtShouldBeMoney);
            this.gbDirectConsumption.Controls.Add(this.lblPwd);
            this.gbDirectConsumption.Controls.Add(this.cboConsumptionType);
            this.gbDirectConsumption.Controls.Add(this.lblDateConsumption);
            this.gbDirectConsumption.Controls.Add(this.lblActualMoney);
            this.gbDirectConsumption.Controls.Add(this.lblShouldBeMoney);
            this.gbDirectConsumption.Controls.Add(this.lblConsumptionType);
            this.gbDirectConsumption.Font = new System.Drawing.Font("宋体", 10F);
            this.gbDirectConsumption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbDirectConsumption.Location = new System.Drawing.Point(24, 131);
            this.gbDirectConsumption.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDirectConsumption.Name = "gbDirectConsumption";
            this.gbDirectConsumption.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.gbDirectConsumption.Size = new System.Drawing.Size(581, 489);
            this.gbDirectConsumption.TabIndex = 3;
            this.gbDirectConsumption.TabStop = false;
            this.gbDirectConsumption.Text = "直接消费";
            // 
            // dgvConsumptionDate
            // 
            this.dgvConsumptionDate.Font = new System.Drawing.Font("宋体", 12F);
            this.dgvConsumptionDate.Location = new System.Drawing.Point(150, 287);
            this.dgvConsumptionDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dgvConsumptionDate.Name = "dgvConsumptionDate";
            this.dgvConsumptionDate.Size = new System.Drawing.Size(382, 30);
            this.dgvConsumptionDate.TabIndex = 6;
            // 
            // lblConsumptionDate
            // 
            this.lblConsumptionDate.AutoSize = true;
            this.lblConsumptionDate.Font = new System.Drawing.Font("宋体", 12F);
            this.lblConsumptionDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblConsumptionDate.Location = new System.Drawing.Point(43, 292);
            this.lblConsumptionDate.Name = "lblConsumptionDate";
            this.lblConsumptionDate.Size = new System.Drawing.Size(89, 20);
            this.lblConsumptionDate.TabIndex = 5;
            this.lblConsumptionDate.Text = "消费日期";
            // 
            // cboConsumptionPatterns
            // 
            this.cboConsumptionPatterns.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboConsumptionPatterns.Font = new System.Drawing.Font("宋体", 12F);
            this.cboConsumptionPatterns.FormattingEnabled = true;
            this.cboConsumptionPatterns.Location = new System.Drawing.Point(151, 247);
            this.cboConsumptionPatterns.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboConsumptionPatterns.Name = "cboConsumptionPatterns";
            this.cboConsumptionPatterns.Size = new System.Drawing.Size(382, 28);
            this.cboConsumptionPatterns.TabIndex = 4;
            // 
            // lblConsumptionPatterns
            // 
            this.lblConsumptionPatterns.AutoSize = true;
            this.lblConsumptionPatterns.Font = new System.Drawing.Font("宋体", 12F);
            this.lblConsumptionPatterns.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblConsumptionPatterns.Location = new System.Drawing.Point(43, 251);
            this.lblConsumptionPatterns.Name = "lblConsumptionPatterns";
            this.lblConsumptionPatterns.Size = new System.Drawing.Size(89, 20);
            this.lblConsumptionPatterns.TabIndex = 3;
            this.lblConsumptionPatterns.Text = "消费方式";
            // 
            // txtNote
            // 
            this.txtNote.Font = new System.Drawing.Font("宋体", 12F);
            this.txtNote.Location = new System.Drawing.Point(150, 374);
            this.txtNote.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNote.Multiline = true;
            this.txtNote.Name = "txtNote";
            this.txtNote.Size = new System.Drawing.Size(382, 100);
            this.txtNote.TabIndex = 2;
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Font = new System.Drawing.Font("宋体", 12F);
            this.lblNote.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblNote.Location = new System.Drawing.Point(43, 376);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(89, 20);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "消费备注";
            // 
            // cboMethodPayment
            // 
            this.cboMethodPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMethodPayment.Font = new System.Drawing.Font("宋体", 12F);
            this.cboMethodPayment.FormattingEnabled = true;
            this.cboMethodPayment.Location = new System.Drawing.Point(152, 210);
            this.cboMethodPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMethodPayment.Name = "cboMethodPayment";
            this.cboMethodPayment.Size = new System.Drawing.Size(382, 28);
            this.cboMethodPayment.TabIndex = 4;
            // 
            // lblMethodPayment
            // 
            this.lblMethodPayment.AutoSize = true;
            this.lblMethodPayment.Font = new System.Drawing.Font("宋体", 12F);
            this.lblMethodPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblMethodPayment.Location = new System.Drawing.Point(43, 214);
            this.lblMethodPayment.Name = "lblMethodPayment";
            this.lblMethodPayment.Size = new System.Drawing.Size(89, 20);
            this.lblMethodPayment.TabIndex = 3;
            this.lblMethodPayment.Text = "支付方式";
            // 
            // txtPaidinAmount
            // 
            this.txtPaidinAmount.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPaidinAmount.Location = new System.Drawing.Point(152, 168);
            this.txtPaidinAmount.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPaidinAmount.Name = "txtPaidinAmount";
            this.txtPaidinAmount.Size = new System.Drawing.Size(382, 30);
            this.txtPaidinAmount.TabIndex = 2;
            // 
            // txtPwd
            // 
            this.txtPwd.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPwd.Location = new System.Drawing.Point(150, 329);
            this.txtPwd.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPwd.Name = "txtPwd";
            this.txtPwd.PasswordChar = '*';
            this.txtPwd.Size = new System.Drawing.Size(382, 30);
            this.txtPwd.TabIndex = 2;
            // 
            // txtActualMoney
            // 
            this.txtActualMoney.Font = new System.Drawing.Font("宋体", 12F);
            this.txtActualMoney.Location = new System.Drawing.Point(152, 128);
            this.txtActualMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtActualMoney.Name = "txtActualMoney";
            this.txtActualMoney.Size = new System.Drawing.Size(382, 30);
            this.txtActualMoney.TabIndex = 2;
            // 
            // txtShouldBeMoney
            // 
            this.txtShouldBeMoney.Font = new System.Drawing.Font("宋体", 12F);
            this.txtShouldBeMoney.Location = new System.Drawing.Point(152, 85);
            this.txtShouldBeMoney.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtShouldBeMoney.Name = "txtShouldBeMoney";
            this.txtShouldBeMoney.Size = new System.Drawing.Size(382, 30);
            this.txtShouldBeMoney.TabIndex = 2;
            // 
            // lblPwd
            // 
            this.lblPwd.AutoSize = true;
            this.lblPwd.Font = new System.Drawing.Font("宋体", 12F);
            this.lblPwd.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblPwd.Location = new System.Drawing.Point(43, 334);
            this.lblPwd.Name = "lblPwd";
            this.lblPwd.Size = new System.Drawing.Size(89, 20);
            this.lblPwd.TabIndex = 0;
            this.lblPwd.Text = "密    码";
            // 
            // lblDateConsumption
            // 
            this.lblDateConsumption.AutoSize = true;
            this.lblDateConsumption.Font = new System.Drawing.Font("宋体", 12F);
            this.lblDateConsumption.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblDateConsumption.Location = new System.Drawing.Point(43, 173);
            this.lblDateConsumption.Name = "lblDateConsumption";
            this.lblDateConsumption.Size = new System.Drawing.Size(89, 20);
            this.lblDateConsumption.TabIndex = 0;
            this.lblDateConsumption.Text = "实收金额";
            // 
            // lblActualMoney
            // 
            this.lblActualMoney.AutoSize = true;
            this.lblActualMoney.Font = new System.Drawing.Font("宋体", 12F);
            this.lblActualMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblActualMoney.Location = new System.Drawing.Point(43, 133);
            this.lblActualMoney.Name = "lblActualMoney";
            this.lblActualMoney.Size = new System.Drawing.Size(89, 20);
            this.lblActualMoney.TabIndex = 0;
            this.lblActualMoney.Text = "折后金额";
            // 
            // lblShouldBeMoney
            // 
            this.lblShouldBeMoney.AutoSize = true;
            this.lblShouldBeMoney.Font = new System.Drawing.Font("宋体", 12F);
            this.lblShouldBeMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblShouldBeMoney.Location = new System.Drawing.Point(43, 90);
            this.lblShouldBeMoney.Name = "lblShouldBeMoney";
            this.lblShouldBeMoney.Size = new System.Drawing.Size(89, 20);
            this.lblShouldBeMoney.TabIndex = 0;
            this.lblShouldBeMoney.Text = "应收金额";
            // 
            // btnConsumption
            // 
            this.btnConsumption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnConsumption.FlatAppearance.BorderSize = 0;
            this.btnConsumption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsumption.Font = new System.Drawing.Font("宋体", 14F);
            this.btnConsumption.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConsumption.Location = new System.Drawing.Point(101, 640);
            this.btnConsumption.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsumption.Name = "btnConsumption";
            this.btnConsumption.Size = new System.Drawing.Size(420, 49);
            this.btnConsumption.TabIndex = 7;
            this.btnConsumption.Text = "消费";
            this.btnConsumption.UseVisualStyleBackColor = false;
            this.btnConsumption.Click += new System.EventHandler(this.btnConsumption_Click);
            // 
            // gbUserInfo
            // 
            this.gbUserInfo.Controls.Add(this.txtMembersName);
            this.gbUserInfo.Controls.Add(this.txtMoney);
            this.gbUserInfo.Controls.Add(this.txtName);
            this.gbUserInfo.Controls.Add(this.txtPhone);
            this.gbUserInfo.Controls.Add(this.lblMembersName);
            this.gbUserInfo.Controls.Add(this.txtCardNo);
            this.gbUserInfo.Controls.Add(this.lblMoney);
            this.gbUserInfo.Controls.Add(this.lblName);
            this.gbUserInfo.Controls.Add(this.lblPhone);
            this.gbUserInfo.Controls.Add(this.lblCardNo);
            this.gbUserInfo.Font = new System.Drawing.Font("宋体", 10F);
            this.gbUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbUserInfo.Location = new System.Drawing.Point(625, 13);
            this.gbUserInfo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUserInfo.Name = "gbUserInfo";
            this.gbUserInfo.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbUserInfo.Size = new System.Drawing.Size(614, 235);
            this.gbUserInfo.TabIndex = 8;
            this.gbUserInfo.TabStop = false;
            this.gbUserInfo.Text = "会员基本信息";
            // 
            // txtMembersName
            // 
            this.txtMembersName.Enabled = false;
            this.txtMembersName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtMembersName.Location = new System.Drawing.Point(141, 184);
            this.txtMembersName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMembersName.Name = "txtMembersName";
            this.txtMembersName.ReadOnly = true;
            this.txtMembersName.Size = new System.Drawing.Size(434, 30);
            this.txtMembersName.TabIndex = 4;
            // 
            // txtMoney
            // 
            this.txtMoney.Enabled = false;
            this.txtMoney.Font = new System.Drawing.Font("宋体", 12F);
            this.txtMoney.Location = new System.Drawing.Point(141, 145);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(434, 30);
            this.txtMoney.TabIndex = 4;
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtName.Location = new System.Drawing.Point(141, 105);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(434, 30);
            this.txtName.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPhone.Location = new System.Drawing.Point(141, 66);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(434, 30);
            this.txtPhone.TabIndex = 4;
            // 
            // lblMembersName
            // 
            this.lblMembersName.AutoSize = true;
            this.lblMembersName.Font = new System.Drawing.Font("宋体", 12F);
            this.lblMembersName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblMembersName.Location = new System.Drawing.Point(29, 189);
            this.lblMembersName.Name = "lblMembersName";
            this.lblMembersName.Size = new System.Drawing.Size(89, 20);
            this.lblMembersName.TabIndex = 1;
            this.lblMembersName.Text = "会员等级";
            // 
            // txtCardNo
            // 
            this.txtCardNo.Enabled = false;
            this.txtCardNo.Font = new System.Drawing.Font("宋体", 12F);
            this.txtCardNo.Location = new System.Drawing.Point(141, 26);
            this.txtCardNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.ReadOnly = true;
            this.txtCardNo.Size = new System.Drawing.Size(434, 30);
            this.txtCardNo.TabIndex = 4;
            // 
            // lblMoney
            // 
            this.lblMoney.AutoSize = true;
            this.lblMoney.Font = new System.Drawing.Font("宋体", 12F);
            this.lblMoney.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblMoney.Location = new System.Drawing.Point(29, 150);
            this.lblMoney.Name = "lblMoney";
            this.lblMoney.Size = new System.Drawing.Size(89, 20);
            this.lblMoney.TabIndex = 1;
            this.lblMoney.Text = "账户余额";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 12F);
            this.lblName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblName.Location = new System.Drawing.Point(69, 110);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(49, 20);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "姓名";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("宋体", 12F);
            this.lblPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblPhone.Location = new System.Drawing.Point(49, 71);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(69, 20);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "手机号";
            // 
            // lblCardNo
            // 
            this.lblCardNo.AutoSize = true;
            this.lblCardNo.Font = new System.Drawing.Font("宋体", 12F);
            this.lblCardNo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblCardNo.Location = new System.Drawing.Point(69, 31);
            this.lblCardNo.Name = "lblCardNo";
            this.lblCardNo.Size = new System.Drawing.Size(49, 20);
            this.lblCardNo.TabIndex = 0;
            this.lblCardNo.Text = "卡号";
            // 
            // gbQueryMethods
            // 
            this.gbQueryMethods.Controls.Add(this.txtQueryNo);
            this.gbQueryMethods.Controls.Add(this.btnQuery);
            this.gbQueryMethods.Font = new System.Drawing.Font("宋体", 10F);
            this.gbQueryMethods.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbQueryMethods.Location = new System.Drawing.Point(24, 13);
            this.gbQueryMethods.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbQueryMethods.Name = "gbQueryMethods";
            this.gbQueryMethods.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbQueryMethods.Size = new System.Drawing.Size(581, 89);
            this.gbQueryMethods.TabIndex = 9;
            this.gbQueryMethods.TabStop = false;
            this.gbQueryMethods.Text = "查询方式";
            // 
            // txtQueryNo
            // 
            this.txtQueryNo.Font = new System.Drawing.Font("宋体", 14F);
            this.txtQueryNo.Location = new System.Drawing.Point(35, 35);
            this.txtQueryNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQueryNo.Name = "txtQueryNo";
            this.txtQueryNo.Size = new System.Drawing.Size(416, 34);
            this.txtQueryNo.TabIndex = 6;
            this.txtQueryNo.Text = "支持卡号、手机号、姓名、微信查询";
            this.txtQueryNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQueryNo.Enter += new System.EventHandler(this.txtQueryNo_Enter);
            this.txtQueryNo.Leave += new System.EventHandler(this.txtQueryNo_Leave);
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.ForeColor = System.Drawing.Color.GhostWhite;
            this.btnQuery.Location = new System.Drawing.Point(466, 35);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 30);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // gbCodeScann
            // 
            this.gbCodeScann.Controls.Add(this.pCodeScann);
            this.gbCodeScann.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbCodeScann.Location = new System.Drawing.Point(625, 264);
            this.gbCodeScann.Name = "gbCodeScann";
            this.gbCodeScann.Size = new System.Drawing.Size(630, 448);
            this.gbCodeScann.TabIndex = 17;
            this.gbCodeScann.TabStop = false;
            this.gbCodeScann.Text = "二维码扫描";
            // 
            // pCodeScann
            // 
            this.pCodeScann.Location = new System.Drawing.Point(11, 24);
            this.pCodeScann.Name = "pCodeScann";
            this.pCodeScann.Size = new System.Drawing.Size(612, 418);
            this.pCodeScann.TabIndex = 0;
            // 
            // tQrCode
            // 
            this.tQrCode.Enabled = true;
            this.tQrCode.Tick += new System.EventHandler(this.tQrCode_Tick);
            // 
            // frmUserConsumption
            // 
            this.AcceptButton = this.btnConsumption;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1267, 724);
            this.Controls.Add(this.gbCodeScann);
            this.Controls.Add(this.gbQueryMethods);
            this.Controls.Add(this.gbUserInfo);
            this.Controls.Add(this.btnConsumption);
            this.Controls.Add(this.gbDirectConsumption);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmUserConsumption";
            this.Text = "会员消费";
            this.Load += new System.EventHandler(this.frmUserConsumption_Load);
            this.gbDirectConsumption.ResumeLayout(false);
            this.gbDirectConsumption.PerformLayout();
            this.gbUserInfo.ResumeLayout(false);
            this.gbUserInfo.PerformLayout();
            this.gbQueryMethods.ResumeLayout(false);
            this.gbQueryMethods.PerformLayout();
            this.gbCodeScann.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblConsumptionType;
        private System.Windows.Forms.ComboBox cboConsumptionType;
        private System.Windows.Forms.GroupBox gbDirectConsumption;
        private System.Windows.Forms.DateTimePicker dgvConsumptionDate;
        private System.Windows.Forms.Label lblConsumptionDate;
        private System.Windows.Forms.ComboBox cboMethodPayment;
        private System.Windows.Forms.Label lblMethodPayment;
        private System.Windows.Forms.TextBox txtPaidinAmount;
        private System.Windows.Forms.TextBox txtNote;
        private System.Windows.Forms.TextBox txtActualMoney;
        private System.Windows.Forms.TextBox txtShouldBeMoney;
        private System.Windows.Forms.Label lblNote;
        private System.Windows.Forms.Label lblDateConsumption;
        private System.Windows.Forms.Label lblActualMoney;
        private System.Windows.Forms.Label lblShouldBeMoney;
        private System.Windows.Forms.Button btnConsumption;
        private System.Windows.Forms.GroupBox gbUserInfo;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label lblMoney;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblCardNo;
        private System.Windows.Forms.GroupBox gbQueryMethods;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.TextBox txtPwd;
        private System.Windows.Forms.Label lblPwd;
        private System.Windows.Forms.TextBox txtMembersName;
        private System.Windows.Forms.Label lblMembersName;
        private System.Windows.Forms.ComboBox cboConsumptionPatterns;
        private System.Windows.Forms.Label lblConsumptionPatterns;
        private System.Windows.Forms.TextBox txtQueryNo;
        private System.Windows.Forms.GroupBox gbCodeScann;
        private System.Windows.Forms.Panel pCodeScann;
        private System.Windows.Forms.Timer tQrCode;
    }
}