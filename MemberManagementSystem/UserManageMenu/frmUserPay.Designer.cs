namespace MemberManagementSystem.Function
{
    partial class frmUserPay
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.txtQueryNo = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPayMoney = new System.Windows.Forms.TextBox();
            this.txtNetReceiptsMoney = new System.Windows.Forms.TextBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.cboMethodPayment = new System.Windows.Forms.ComboBox();
            this.lblMethodPayment = new System.Windows.Forms.Label();
            this.lblToPayName = new System.Windows.Forms.Label();
            this.txtToPayName = new System.Windows.Forms.TextBox();
            this.gbCodeScann = new System.Windows.Forms.GroupBox();
            this.pCodeScann = new System.Windows.Forms.Panel();
            this.tQrCode = new System.Windows.Forms.Timer(this.components);
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbCodeScann.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnQuery);
            this.groupBox1.Controls.Add(this.txtQueryNo);
            this.groupBox1.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.groupBox1.Location = new System.Drawing.Point(42, 31);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox1.Size = new System.Drawing.Size(576, 86);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询方式";
            // 
            // btnQuery
            // 
            this.btnQuery.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnQuery.FlatAppearance.BorderSize = 0;
            this.btnQuery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnQuery.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnQuery.Location = new System.Drawing.Point(453, 34);
            this.btnQuery.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(80, 30);
            this.btnQuery.TabIndex = 5;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = false;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // txtQueryNo
            // 
            this.txtQueryNo.Font = new System.Drawing.Font("宋体", 14F);
            this.txtQueryNo.Location = new System.Drawing.Point(13, 33);
            this.txtQueryNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtQueryNo.Name = "txtQueryNo";
            this.txtQueryNo.Size = new System.Drawing.Size(416, 34);
            this.txtQueryNo.TabIndex = 4;
            this.txtQueryNo.Text = "支持卡号、手机号、姓名、微信查询";
            this.txtQueryNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQueryNo.Enter += new System.EventHandler(this.txtQueryNo_Enter);
            this.txtQueryNo.Leave += new System.EventHandler(this.txtQueryNo_Leave);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtMoney);
            this.groupBox2.Controls.Add(this.txtName);
            this.groupBox2.Controls.Add(this.txtPhone);
            this.groupBox2.Controls.Add(this.txtCardNo);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("宋体", 10F);
            this.groupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.groupBox2.Location = new System.Drawing.Point(42, 142);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.groupBox2.Size = new System.Drawing.Size(576, 214);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "会员基本信息";
            // 
            // txtMoney
            // 
            this.txtMoney.Enabled = false;
            this.txtMoney.Font = new System.Drawing.Font("宋体", 12F);
            this.txtMoney.Location = new System.Drawing.Point(125, 167);
            this.txtMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.ReadOnly = true;
            this.txtMoney.Size = new System.Drawing.Size(420, 30);
            this.txtMoney.TabIndex = 4;
            this.txtMoney.Text = "0.00";
            // 
            // txtName
            // 
            this.txtName.Enabled = false;
            this.txtName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtName.Location = new System.Drawing.Point(125, 119);
            this.txtName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(420, 30);
            this.txtName.TabIndex = 4;
            // 
            // txtPhone
            // 
            this.txtPhone.Enabled = false;
            this.txtPhone.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPhone.Location = new System.Drawing.Point(125, 71);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.ReadOnly = true;
            this.txtPhone.Size = new System.Drawing.Size(420, 30);
            this.txtPhone.TabIndex = 4;
            // 
            // txtCardNo
            // 
            this.txtCardNo.Enabled = false;
            this.txtCardNo.Font = new System.Drawing.Font("宋体", 12F);
            this.txtCardNo.Location = new System.Drawing.Point(125, 26);
            this.txtCardNo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.ReadOnly = true;
            this.txtCardNo.Size = new System.Drawing.Size(420, 30);
            this.txtCardNo.TabIndex = 4;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("宋体", 12F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label6.Location = new System.Drawing.Point(21, 172);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 20);
            this.label6.TabIndex = 1;
            this.label6.Text = "账户余额";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("宋体", 12F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label5.Location = new System.Drawing.Point(61, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "姓名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("宋体", 12F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label4.Location = new System.Drawing.Point(41, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "手机号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 12F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label3.Location = new System.Drawing.Point(61, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "卡号";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("宋体", 12F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label7.Location = new System.Drawing.Point(61, 543);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(89, 20);
            this.label7.TabIndex = 4;
            this.label7.Text = "实收金额";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("宋体", 12F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.label8.Location = new System.Drawing.Point(61, 488);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(89, 20);
            this.label8.TabIndex = 4;
            this.label8.Text = "充值金额";
            // 
            // txtPayMoney
            // 
            this.txtPayMoney.Font = new System.Drawing.Font("宋体", 12F);
            this.txtPayMoney.Location = new System.Drawing.Point(168, 482);
            this.txtPayMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPayMoney.Name = "txtPayMoney";
            this.txtPayMoney.Size = new System.Drawing.Size(420, 30);
            this.txtPayMoney.TabIndex = 4;
            // 
            // txtNetReceiptsMoney
            // 
            this.txtNetReceiptsMoney.Font = new System.Drawing.Font("宋体", 12F);
            this.txtNetReceiptsMoney.Location = new System.Drawing.Point(168, 539);
            this.txtNetReceiptsMoney.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNetReceiptsMoney.Name = "txtNetReceiptsMoney";
            this.txtNetReceiptsMoney.Size = new System.Drawing.Size(420, 30);
            this.txtNetReceiptsMoney.TabIndex = 4;
            // 
            // btnPay
            // 
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(163)))), ((int)(((byte)(5)))), ((int)(((byte)(4)))));
            this.btnPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPay.Font = new System.Drawing.Font("宋体", 14F);
            this.btnPay.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPay.Location = new System.Drawing.Point(152, 616);
            this.btnPay.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(420, 49);
            this.btnPay.TabIndex = 5;
            this.btnPay.Text = "充值";
            this.btnPay.UseVisualStyleBackColor = false;
            this.btnPay.Click += new System.EventHandler(this.btnPay_Click);
            // 
            // cboMethodPayment
            // 
            this.cboMethodPayment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboMethodPayment.Font = new System.Drawing.Font("宋体", 12F);
            this.cboMethodPayment.FormattingEnabled = true;
            this.cboMethodPayment.Location = new System.Drawing.Point(168, 380);
            this.cboMethodPayment.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cboMethodPayment.Name = "cboMethodPayment";
            this.cboMethodPayment.Size = new System.Drawing.Size(420, 28);
            this.cboMethodPayment.TabIndex = 6;
            // 
            // lblMethodPayment
            // 
            this.lblMethodPayment.AutoSize = true;
            this.lblMethodPayment.Font = new System.Drawing.Font("宋体", 12F);
            this.lblMethodPayment.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblMethodPayment.Location = new System.Drawing.Point(61, 383);
            this.lblMethodPayment.Name = "lblMethodPayment";
            this.lblMethodPayment.Size = new System.Drawing.Size(89, 20);
            this.lblMethodPayment.TabIndex = 7;
            this.lblMethodPayment.Text = "支付方式";
            // 
            // lblToPayName
            // 
            this.lblToPayName.AutoSize = true;
            this.lblToPayName.Font = new System.Drawing.Font("宋体", 12F);
            this.lblToPayName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.lblToPayName.Location = new System.Drawing.Point(41, 434);
            this.lblToPayName.Name = "lblToPayName";
            this.lblToPayName.Size = new System.Drawing.Size(109, 20);
            this.lblToPayName.TabIndex = 4;
            this.lblToPayName.Text = "付款人姓名";
            // 
            // txtToPayName
            // 
            this.txtToPayName.Font = new System.Drawing.Font("宋体", 12F);
            this.txtToPayName.Location = new System.Drawing.Point(168, 428);
            this.txtToPayName.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtToPayName.Name = "txtToPayName";
            this.txtToPayName.Size = new System.Drawing.Size(420, 30);
            this.txtToPayName.TabIndex = 4;
            // 
            // gbCodeScann
            // 
            this.gbCodeScann.Controls.Add(this.pCodeScann);
            this.gbCodeScann.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(10)))), ((int)(((byte)(10)))), ((int)(((byte)(10)))));
            this.gbCodeScann.Location = new System.Drawing.Point(633, 32);
            this.gbCodeScann.Name = "gbCodeScann";
            this.gbCodeScann.Size = new System.Drawing.Size(620, 653);
            this.gbCodeScann.TabIndex = 17;
            this.gbCodeScann.TabStop = false;
            this.gbCodeScann.Text = "二维码扫描";
            // 
            // pCodeScann
            // 
            this.pCodeScann.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pCodeScann.Location = new System.Drawing.Point(3, 21);
            this.pCodeScann.Name = "pCodeScann";
            this.pCodeScann.Size = new System.Drawing.Size(614, 629);
            this.pCodeScann.TabIndex = 0;
            // 
            // tQrCode
            // 
            this.tQrCode.Enabled = true;
            this.tQrCode.Tick += new System.EventHandler(this.tQrCode_Tick);
            // 
            // frmUserPay
            // 
            this.AcceptButton = this.btnPay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(1267, 709);
            this.Controls.Add(this.gbCodeScann);
            this.Controls.Add(this.lblMethodPayment);
            this.Controls.Add(this.cboMethodPayment);
            this.Controls.Add(this.btnPay);
            this.Controls.Add(this.txtNetReceiptsMoney);
            this.Controls.Add(this.txtToPayName);
            this.Controls.Add(this.lblToPayName);
            this.Controls.Add(this.txtPayMoney);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUserPay";
            this.Text = "会员充值";
            this.Load += new System.EventHandler(this.frmUserPay_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbCodeScann.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPayMoney;
        private System.Windows.Forms.TextBox txtNetReceiptsMoney;
        private System.Windows.Forms.TextBox txtQueryNo;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ComboBox cboMethodPayment;
        private System.Windows.Forms.Label lblMethodPayment;
        private System.Windows.Forms.Label lblToPayName;
        private System.Windows.Forms.TextBox txtToPayName;
        private System.Windows.Forms.GroupBox gbCodeScann;
        private System.Windows.Forms.Panel pCodeScann;
        private System.Windows.Forms.Timer tQrCode;
    }
}