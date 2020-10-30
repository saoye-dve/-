namespace MemberManagementSystem
{
    partial class frmMainMenu
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainMenu));
            this.pMenu = new System.Windows.Forms.Panel();
            this.btnExit2 = new FontAwesome.Sharp.IconButton();
            this.pSystemSettingsMenu = new System.Windows.Forms.Panel();
            this.btnBasicSetup = new FontAwesome.Sharp.IconButton();
            this.btnUserLevelSetup = new FontAwesome.Sharp.IconButton();
            this.btnConsumptionTypeSetup = new FontAwesome.Sharp.IconButton();
            this.btnSystemSettingsMenu = new FontAwesome.Sharp.IconButton();
            this.pStatisticalQueryMenu = new System.Windows.Forms.Panel();
            this.btnSmsStatistical = new FontAwesome.Sharp.IconButton();
            this.btnPayStatistical = new FontAwesome.Sharp.IconButton();
            this.btnConsumptionStatistical = new FontAwesome.Sharp.IconButton();
            this.btnUserStatistical = new FontAwesome.Sharp.IconButton();
            this.btnStatisticalQueryMenu = new FontAwesome.Sharp.IconButton();
            this.pUserManageMenu = new System.Windows.Forms.Panel();
            this.btnUserManage = new FontAwesome.Sharp.IconButton();
            this.btnUserConsumption = new FontAwesome.Sharp.IconButton();
            this.btnNewUser = new FontAwesome.Sharp.IconButton();
            this.btnUserPay = new FontAwesome.Sharp.IconButton();
            this.btnUserManageMenu = new FontAwesome.Sharp.IconButton();
            this.pLogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.pTitle = new System.Windows.Forms.Panel();
            this.btnExit = new FontAwesome.Sharp.IconButton();
            this.btnTitleUserManage = new FontAwesome.Sharp.IconButton();
            this.btnTitleNewUser = new FontAwesome.Sharp.IconButton();
            this.btnTitleUserPay = new FontAwesome.Sharp.IconButton();
            this.btnTitleHome = new FontAwesome.Sharp.IconButton();
            this.btnLockScreen = new FontAwesome.Sharp.IconButton();
            this.btnTitleUserConsumption = new FontAwesome.Sharp.IconButton();
            this.btnMinimize = new FontAwesome.Sharp.IconButton();
            this.btnMaximize = new FontAwesome.Sharp.IconButton();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.iconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.pDesktop = new System.Windows.Forms.Panel();
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblhora = new System.Windows.Forms.Label();
            this.pbLogo = new System.Windows.Forms.PictureBox();
            this.tUserDueTo = new System.Windows.Forms.Timer(this.components);
            this.tDate = new System.Windows.Forms.Timer(this.components);
            this.pMenu.SuspendLayout();
            this.pSystemSettingsMenu.SuspendLayout();
            this.pStatisticalQueryMenu.SuspendLayout();
            this.pUserManageMenu.SuspendLayout();
            this.pLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            this.pTitle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).BeginInit();
            this.pDesktop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pMenu
            // 
            this.pMenu.AutoScroll = true;
            this.pMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pMenu.Controls.Add(this.btnExit2);
            this.pMenu.Controls.Add(this.pSystemSettingsMenu);
            this.pMenu.Controls.Add(this.btnSystemSettingsMenu);
            this.pMenu.Controls.Add(this.pStatisticalQueryMenu);
            this.pMenu.Controls.Add(this.btnStatisticalQueryMenu);
            this.pMenu.Controls.Add(this.pUserManageMenu);
            this.pMenu.Controls.Add(this.btnUserManageMenu);
            this.pMenu.Controls.Add(this.pLogo);
            this.pMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pMenu.Location = new System.Drawing.Point(0, 0);
            this.pMenu.Margin = new System.Windows.Forms.Padding(4);
            this.pMenu.Name = "pMenu";
            this.pMenu.Size = new System.Drawing.Size(293, 850);
            this.pMenu.TabIndex = 0;
            // 
            // btnExit2
            // 
            this.btnExit2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnExit2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnExit2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnExit2.FlatAppearance.BorderSize = 0;
            this.btnExit2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit2.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit2.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit2.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit2.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit2.IconSize = 32;
            this.btnExit2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit2.Location = new System.Drawing.Point(0, 1105);
            this.btnExit2.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit2.Name = "btnExit2";
            this.btnExit2.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnExit2.Rotation = 3D;
            this.btnExit2.Size = new System.Drawing.Size(272, 75);
            this.btnExit2.TabIndex = 15;
            this.btnExit2.Text = "退出系统";
            this.btnExit2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExit2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExit2.UseVisualStyleBackColor = false;
            this.btnExit2.Click += new System.EventHandler(this.btnExit2_Click);
            // 
            // pSystemSettingsMenu
            // 
            this.pSystemSettingsMenu.BackColor = System.Drawing.Color.White;
            this.pSystemSettingsMenu.Controls.Add(this.btnBasicSetup);
            this.pSystemSettingsMenu.Controls.Add(this.btnUserLevelSetup);
            this.pSystemSettingsMenu.Controls.Add(this.btnConsumptionTypeSetup);
            this.pSystemSettingsMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pSystemSettingsMenu.Location = new System.Drawing.Point(0, 910);
            this.pSystemSettingsMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pSystemSettingsMenu.Name = "pSystemSettingsMenu";
            this.pSystemSettingsMenu.Size = new System.Drawing.Size(272, 195);
            this.pSystemSettingsMenu.TabIndex = 4;
            // 
            // btnBasicSetup
            // 
            this.btnBasicSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnBasicSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnBasicSetup.FlatAppearance.BorderSize = 0;
            this.btnBasicSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBasicSetup.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnBasicSetup.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnBasicSetup.IconChar = FontAwesome.Sharp.IconChar.Briefcase;
            this.btnBasicSetup.IconColor = System.Drawing.Color.Gainsboro;
            this.btnBasicSetup.IconSize = 32;
            this.btnBasicSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBasicSetup.Location = new System.Drawing.Point(0, 130);
            this.btnBasicSetup.Margin = new System.Windows.Forms.Padding(4);
            this.btnBasicSetup.Name = "btnBasicSetup";
            this.btnBasicSetup.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnBasicSetup.Rotation = 0D;
            this.btnBasicSetup.Size = new System.Drawing.Size(272, 65);
            this.btnBasicSetup.TabIndex = 14;
            this.btnBasicSetup.Text = "基本设置";
            this.btnBasicSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBasicSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBasicSetup.UseVisualStyleBackColor = false;
            this.btnBasicSetup.Click += new System.EventHandler(this.btnBasicSetup_Click);
            // 
            // btnUserLevelSetup
            // 
            this.btnUserLevelSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnUserLevelSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserLevelSetup.FlatAppearance.BorderSize = 0;
            this.btnUserLevelSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserLevelSetup.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUserLevelSetup.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUserLevelSetup.IconChar = FontAwesome.Sharp.IconChar.LayerGroup;
            this.btnUserLevelSetup.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUserLevelSetup.IconSize = 32;
            this.btnUserLevelSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserLevelSetup.Location = new System.Drawing.Point(0, 65);
            this.btnUserLevelSetup.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserLevelSetup.Name = "btnUserLevelSetup";
            this.btnUserLevelSetup.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnUserLevelSetup.Rotation = 0D;
            this.btnUserLevelSetup.Size = new System.Drawing.Size(272, 65);
            this.btnUserLevelSetup.TabIndex = 13;
            this.btnUserLevelSetup.Text = "会员等级设置";
            this.btnUserLevelSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserLevelSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserLevelSetup.UseVisualStyleBackColor = false;
            this.btnUserLevelSetup.Click += new System.EventHandler(this.btnUserLevelSetup_Click);
            // 
            // btnConsumptionTypeSetup
            // 
            this.btnConsumptionTypeSetup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnConsumptionTypeSetup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsumptionTypeSetup.FlatAppearance.BorderSize = 0;
            this.btnConsumptionTypeSetup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsumptionTypeSetup.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConsumptionTypeSetup.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConsumptionTypeSetup.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.btnConsumptionTypeSetup.IconColor = System.Drawing.Color.Gainsboro;
            this.btnConsumptionTypeSetup.IconSize = 32;
            this.btnConsumptionTypeSetup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsumptionTypeSetup.Location = new System.Drawing.Point(0, 0);
            this.btnConsumptionTypeSetup.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsumptionTypeSetup.Name = "btnConsumptionTypeSetup";
            this.btnConsumptionTypeSetup.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnConsumptionTypeSetup.Rotation = 0D;
            this.btnConsumptionTypeSetup.Size = new System.Drawing.Size(272, 65);
            this.btnConsumptionTypeSetup.TabIndex = 12;
            this.btnConsumptionTypeSetup.Text = "消费类型设置";
            this.btnConsumptionTypeSetup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsumptionTypeSetup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsumptionTypeSetup.UseVisualStyleBackColor = false;
            this.btnConsumptionTypeSetup.Click += new System.EventHandler(this.btnConsumptionTypeSetup_Click);
            // 
            // btnSystemSettingsMenu
            // 
            this.btnSystemSettingsMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSystemSettingsMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSystemSettingsMenu.FlatAppearance.BorderSize = 0;
            this.btnSystemSettingsMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSystemSettingsMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSystemSettingsMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSystemSettingsMenu.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.btnSystemSettingsMenu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSystemSettingsMenu.IconSize = 32;
            this.btnSystemSettingsMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSystemSettingsMenu.Location = new System.Drawing.Point(0, 835);
            this.btnSystemSettingsMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnSystemSettingsMenu.Name = "btnSystemSettingsMenu";
            this.btnSystemSettingsMenu.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnSystemSettingsMenu.Rotation = 3D;
            this.btnSystemSettingsMenu.Size = new System.Drawing.Size(272, 75);
            this.btnSystemSettingsMenu.TabIndex = 11;
            this.btnSystemSettingsMenu.Text = "系统设置";
            this.btnSystemSettingsMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSystemSettingsMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnSystemSettingsMenu.UseVisualStyleBackColor = false;
            this.btnSystemSettingsMenu.Click += new System.EventHandler(this.btnSystemSettingsMenu_Click);
            // 
            // pStatisticalQueryMenu
            // 
            this.pStatisticalQueryMenu.BackColor = System.Drawing.Color.White;
            this.pStatisticalQueryMenu.Controls.Add(this.btnSmsStatistical);
            this.pStatisticalQueryMenu.Controls.Add(this.btnPayStatistical);
            this.pStatisticalQueryMenu.Controls.Add(this.btnConsumptionStatistical);
            this.pStatisticalQueryMenu.Controls.Add(this.btnUserStatistical);
            this.pStatisticalQueryMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pStatisticalQueryMenu.Location = new System.Drawing.Point(0, 575);
            this.pStatisticalQueryMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pStatisticalQueryMenu.Name = "pStatisticalQueryMenu";
            this.pStatisticalQueryMenu.Size = new System.Drawing.Size(272, 260);
            this.pStatisticalQueryMenu.TabIndex = 4;
            // 
            // btnSmsStatistical
            // 
            this.btnSmsStatistical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnSmsStatistical.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSmsStatistical.FlatAppearance.BorderSize = 0;
            this.btnSmsStatistical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSmsStatistical.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnSmsStatistical.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSmsStatistical.IconChar = FontAwesome.Sharp.IconChar.Comment;
            this.btnSmsStatistical.IconColor = System.Drawing.Color.Gainsboro;
            this.btnSmsStatistical.IconSize = 32;
            this.btnSmsStatistical.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSmsStatistical.Location = new System.Drawing.Point(0, 195);
            this.btnSmsStatistical.Margin = new System.Windows.Forms.Padding(4);
            this.btnSmsStatistical.Name = "btnSmsStatistical";
            this.btnSmsStatistical.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnSmsStatistical.Rotation = 0D;
            this.btnSmsStatistical.Size = new System.Drawing.Size(272, 65);
            this.btnSmsStatistical.TabIndex = 10;
            this.btnSmsStatistical.Text = "短信统计";
            this.btnSmsStatistical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSmsStatistical.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSmsStatistical.UseVisualStyleBackColor = false;
            this.btnSmsStatistical.Click += new System.EventHandler(this.btnSmsStatistical_Click);
            // 
            // btnPayStatistical
            // 
            this.btnPayStatistical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnPayStatistical.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPayStatistical.FlatAppearance.BorderSize = 0;
            this.btnPayStatistical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayStatistical.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnPayStatistical.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnPayStatistical.IconChar = FontAwesome.Sharp.IconChar.MoneyBillWaveAlt;
            this.btnPayStatistical.IconColor = System.Drawing.Color.Gainsboro;
            this.btnPayStatistical.IconSize = 32;
            this.btnPayStatistical.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayStatistical.Location = new System.Drawing.Point(0, 130);
            this.btnPayStatistical.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayStatistical.Name = "btnPayStatistical";
            this.btnPayStatistical.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnPayStatistical.Rotation = 9D;
            this.btnPayStatistical.Size = new System.Drawing.Size(272, 65);
            this.btnPayStatistical.TabIndex = 3;
            this.btnPayStatistical.Text = "充值统计";
            this.btnPayStatistical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayStatistical.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPayStatistical.UseVisualStyleBackColor = false;
            this.btnPayStatistical.Click += new System.EventHandler(this.btnPayStatistical_Click);
            // 
            // btnConsumptionStatistical
            // 
            this.btnConsumptionStatistical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnConsumptionStatistical.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConsumptionStatistical.FlatAppearance.BorderSize = 0;
            this.btnConsumptionStatistical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConsumptionStatistical.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnConsumptionStatistical.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnConsumptionStatistical.IconChar = FontAwesome.Sharp.IconChar.Wallet;
            this.btnConsumptionStatistical.IconColor = System.Drawing.Color.Gainsboro;
            this.btnConsumptionStatistical.IconSize = 32;
            this.btnConsumptionStatistical.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsumptionStatistical.Location = new System.Drawing.Point(0, 65);
            this.btnConsumptionStatistical.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsumptionStatistical.Name = "btnConsumptionStatistical";
            this.btnConsumptionStatistical.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnConsumptionStatistical.Rotation = 0D;
            this.btnConsumptionStatistical.Size = new System.Drawing.Size(272, 65);
            this.btnConsumptionStatistical.TabIndex = 8;
            this.btnConsumptionStatistical.Text = "消费统计";
            this.btnConsumptionStatistical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnConsumptionStatistical.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConsumptionStatistical.UseVisualStyleBackColor = false;
            this.btnConsumptionStatistical.Click += new System.EventHandler(this.btnConsumptionStatistical_Click);
            // 
            // btnUserStatistical
            // 
            this.btnUserStatistical.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnUserStatistical.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserStatistical.FlatAppearance.BorderSize = 0;
            this.btnUserStatistical.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserStatistical.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUserStatistical.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUserStatistical.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.btnUserStatistical.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUserStatistical.IconSize = 32;
            this.btnUserStatistical.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserStatistical.Location = new System.Drawing.Point(0, 0);
            this.btnUserStatistical.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserStatistical.Name = "btnUserStatistical";
            this.btnUserStatistical.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnUserStatistical.Rotation = 0D;
            this.btnUserStatistical.Size = new System.Drawing.Size(272, 65);
            this.btnUserStatistical.TabIndex = 7;
            this.btnUserStatistical.Text = "会员统计";
            this.btnUserStatistical.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserStatistical.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserStatistical.UseVisualStyleBackColor = false;
            this.btnUserStatistical.Click += new System.EventHandler(this.btnUserStatistical_Click);
            // 
            // btnStatisticalQueryMenu
            // 
            this.btnStatisticalQueryMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnStatisticalQueryMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnStatisticalQueryMenu.FlatAppearance.BorderSize = 0;
            this.btnStatisticalQueryMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatisticalQueryMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnStatisticalQueryMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnStatisticalQueryMenu.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.btnStatisticalQueryMenu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnStatisticalQueryMenu.IconSize = 32;
            this.btnStatisticalQueryMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStatisticalQueryMenu.Location = new System.Drawing.Point(0, 500);
            this.btnStatisticalQueryMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnStatisticalQueryMenu.Name = "btnStatisticalQueryMenu";
            this.btnStatisticalQueryMenu.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnStatisticalQueryMenu.Rotation = 0D;
            this.btnStatisticalQueryMenu.Size = new System.Drawing.Size(272, 75);
            this.btnStatisticalQueryMenu.TabIndex = 6;
            this.btnStatisticalQueryMenu.Text = "统计查询";
            this.btnStatisticalQueryMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStatisticalQueryMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnStatisticalQueryMenu.UseVisualStyleBackColor = false;
            this.btnStatisticalQueryMenu.Click += new System.EventHandler(this.btnStatisticalQueryMenu_Click);
            // 
            // pUserManageMenu
            // 
            this.pUserManageMenu.BackColor = System.Drawing.Color.White;
            this.pUserManageMenu.Controls.Add(this.btnUserManage);
            this.pUserManageMenu.Controls.Add(this.btnUserConsumption);
            this.pUserManageMenu.Controls.Add(this.btnNewUser);
            this.pUserManageMenu.Controls.Add(this.btnUserPay);
            this.pUserManageMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.pUserManageMenu.Location = new System.Drawing.Point(0, 240);
            this.pUserManageMenu.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pUserManageMenu.Name = "pUserManageMenu";
            this.pUserManageMenu.Size = new System.Drawing.Size(272, 260);
            this.pUserManageMenu.TabIndex = 3;
            // 
            // btnUserManage
            // 
            this.btnUserManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnUserManage.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserManage.FlatAppearance.BorderSize = 0;
            this.btnUserManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManage.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUserManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUserManage.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btnUserManage.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUserManage.IconSize = 32;
            this.btnUserManage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManage.Location = new System.Drawing.Point(0, 195);
            this.btnUserManage.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserManage.Name = "btnUserManage";
            this.btnUserManage.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnUserManage.Rotation = 0D;
            this.btnUserManage.Size = new System.Drawing.Size(272, 65);
            this.btnUserManage.TabIndex = 4;
            this.btnUserManage.Text = "会员管理";
            this.btnUserManage.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserManage.UseVisualStyleBackColor = false;
            this.btnUserManage.Click += new System.EventHandler(this.btnUserManage_Click);
            // 
            // btnUserConsumption
            // 
            this.btnUserConsumption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnUserConsumption.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserConsumption.FlatAppearance.BorderSize = 0;
            this.btnUserConsumption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserConsumption.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUserConsumption.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUserConsumption.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.btnUserConsumption.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUserConsumption.IconSize = 32;
            this.btnUserConsumption.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserConsumption.Location = new System.Drawing.Point(0, 130);
            this.btnUserConsumption.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserConsumption.Name = "btnUserConsumption";
            this.btnUserConsumption.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnUserConsumption.Rotation = 0D;
            this.btnUserConsumption.Size = new System.Drawing.Size(272, 65);
            this.btnUserConsumption.TabIndex = 6;
            this.btnUserConsumption.Text = "会员消费";
            this.btnUserConsumption.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserConsumption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserConsumption.UseVisualStyleBackColor = false;
            this.btnUserConsumption.Click += new System.EventHandler(this.btnUserConsumption_Click);
            // 
            // btnNewUser
            // 
            this.btnNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnNewUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnNewUser.FlatAppearance.BorderSize = 0;
            this.btnNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNewUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnNewUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnNewUser.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnNewUser.IconColor = System.Drawing.Color.Gainsboro;
            this.btnNewUser.IconSize = 32;
            this.btnNewUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNewUser.Location = new System.Drawing.Point(0, 65);
            this.btnNewUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnNewUser.Name = "btnNewUser";
            this.btnNewUser.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnNewUser.Rotation = 0D;
            this.btnNewUser.Size = new System.Drawing.Size(272, 65);
            this.btnNewUser.TabIndex = 2;
            this.btnNewUser.Text = "新建会员";
            this.btnNewUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNewUser.UseVisualStyleBackColor = false;
            this.btnNewUser.Click += new System.EventHandler(this.btnNewUser_Click);
            // 
            // btnUserPay
            // 
            this.btnUserPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnUserPay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserPay.FlatAppearance.BorderSize = 0;
            this.btnUserPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserPay.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUserPay.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUserPay.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnUserPay.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUserPay.IconSize = 32;
            this.btnUserPay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserPay.Location = new System.Drawing.Point(0, 0);
            this.btnUserPay.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserPay.Name = "btnUserPay";
            this.btnUserPay.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnUserPay.Rotation = 0D;
            this.btnUserPay.Size = new System.Drawing.Size(272, 65);
            this.btnUserPay.TabIndex = 3;
            this.btnUserPay.Text = "会员充值";
            this.btnUserPay.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnUserPay.UseVisualStyleBackColor = false;
            this.btnUserPay.Click += new System.EventHandler(this.btnUserPay_Click);
            // 
            // btnUserManageMenu
            // 
            this.btnUserManageMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnUserManageMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUserManageMenu.FlatAppearance.BorderSize = 0;
            this.btnUserManageMenu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUserManageMenu.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnUserManageMenu.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnUserManageMenu.IconChar = FontAwesome.Sharp.IconChar.ChevronLeft;
            this.btnUserManageMenu.IconColor = System.Drawing.Color.Gainsboro;
            this.btnUserManageMenu.IconSize = 32;
            this.btnUserManageMenu.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUserManageMenu.Location = new System.Drawing.Point(0, 165);
            this.btnUserManageMenu.Margin = new System.Windows.Forms.Padding(4);
            this.btnUserManageMenu.Name = "btnUserManageMenu";
            this.btnUserManageMenu.Padding = new System.Windows.Forms.Padding(13, 0, 27, 0);
            this.btnUserManageMenu.Rotation = 0D;
            this.btnUserManageMenu.Size = new System.Drawing.Size(272, 75);
            this.btnUserManageMenu.TabIndex = 1;
            this.btnUserManageMenu.Text = "会员管理";
            this.btnUserManageMenu.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUserManageMenu.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnUserManageMenu.UseVisualStyleBackColor = false;
            this.btnUserManageMenu.Click += new System.EventHandler(this.btnUserManageMenu_Click);
            // 
            // pLogo
            // 
            this.pLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pLogo.Controls.Add(this.btnHome);
            this.pLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.pLogo.Location = new System.Drawing.Point(0, 0);
            this.pLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pLogo.Name = "pLogo";
            this.pLogo.Size = new System.Drawing.Size(272, 165);
            this.pLogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnHome.Image = global::MemberManagementSystem.Properties.Resources.titleLogo;
            this.btnHome.Location = new System.Drawing.Point(21, 34);
            this.btnHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(232, 104);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // pTitle
            // 
            this.pTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.pTitle.Controls.Add(this.btnExit);
            this.pTitle.Controls.Add(this.btnTitleUserManage);
            this.pTitle.Controls.Add(this.btnTitleNewUser);
            this.pTitle.Controls.Add(this.btnTitleUserPay);
            this.pTitle.Controls.Add(this.btnTitleHome);
            this.pTitle.Controls.Add(this.btnLockScreen);
            this.pTitle.Controls.Add(this.btnTitleUserConsumption);
            this.pTitle.Controls.Add(this.btnMinimize);
            this.pTitle.Controls.Add(this.btnMaximize);
            this.pTitle.Controls.Add(this.lblTitleChildForm);
            this.pTitle.Controls.Add(this.iconCurrentChildForm);
            this.pTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pTitle.Location = new System.Drawing.Point(293, 0);
            this.pTitle.Margin = new System.Windows.Forms.Padding(4);
            this.pTitle.Name = "pTitle";
            this.pTitle.Size = new System.Drawing.Size(1286, 94);
            this.pTitle.TabIndex = 1;
            this.pTitle.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pTitleBar_MouseDown);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(11)))), ((int)(((byte)(10)))));
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(11)))), ((int)(((byte)(10)))));
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnExit.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Times;
            this.btnExit.IconColor = System.Drawing.Color.Gainsboro;
            this.btnExit.IconSize = 25;
            this.btnExit.Location = new System.Drawing.Point(1260, 2);
            this.btnExit.Margin = new System.Windows.Forms.Padding(4);
            this.btnExit.Name = "btnExit";
            this.btnExit.Rotation = 0D;
            this.btnExit.Size = new System.Drawing.Size(25, 25);
            this.btnExit.TabIndex = 18;
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnTitleUserManage
            // 
            this.btnTitleUserManage.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnTitleUserManage.FlatAppearance.BorderSize = 0;
            this.btnTitleUserManage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(11)))), ((int)(((byte)(10)))));
            this.btnTitleUserManage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitleUserManage.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTitleUserManage.Font = new System.Drawing.Font("宋体", 9F);
            this.btnTitleUserManage.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTitleUserManage.IconChar = FontAwesome.Sharp.IconChar.Tasks;
            this.btnTitleUserManage.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTitleUserManage.IconSize = 32;
            this.btnTitleUserManage.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTitleUserManage.Location = new System.Drawing.Point(592, 2);
            this.btnTitleUserManage.Margin = new System.Windows.Forms.Padding(4);
            this.btnTitleUserManage.Name = "btnTitleUserManage";
            this.btnTitleUserManage.Rotation = 0D;
            this.btnTitleUserManage.Size = new System.Drawing.Size(84, 90);
            this.btnTitleUserManage.TabIndex = 22;
            this.btnTitleUserManage.Text = "会员管理";
            this.btnTitleUserManage.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTitleUserManage.UseVisualStyleBackColor = false;
            this.btnTitleUserManage.Click += new System.EventHandler(this.btnTitleUserManage_Click);
            // 
            // btnTitleNewUser
            // 
            this.btnTitleNewUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnTitleNewUser.FlatAppearance.BorderSize = 0;
            this.btnTitleNewUser.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(11)))), ((int)(((byte)(10)))));
            this.btnTitleNewUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitleNewUser.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTitleNewUser.Font = new System.Drawing.Font("宋体", 9F);
            this.btnTitleNewUser.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTitleNewUser.IconChar = FontAwesome.Sharp.IconChar.Plus;
            this.btnTitleNewUser.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTitleNewUser.IconSize = 32;
            this.btnTitleNewUser.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTitleNewUser.Location = new System.Drawing.Point(418, 2);
            this.btnTitleNewUser.Margin = new System.Windows.Forms.Padding(4);
            this.btnTitleNewUser.Name = "btnTitleNewUser";
            this.btnTitleNewUser.Rotation = 0D;
            this.btnTitleNewUser.Size = new System.Drawing.Size(84, 90);
            this.btnTitleNewUser.TabIndex = 21;
            this.btnTitleNewUser.Text = "新建会员";
            this.btnTitleNewUser.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTitleNewUser.UseVisualStyleBackColor = false;
            this.btnTitleNewUser.Click += new System.EventHandler(this.btnTitleNewUser_Click);
            // 
            // btnTitleUserPay
            // 
            this.btnTitleUserPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnTitleUserPay.FlatAppearance.BorderSize = 0;
            this.btnTitleUserPay.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(11)))), ((int)(((byte)(10)))));
            this.btnTitleUserPay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitleUserPay.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTitleUserPay.Font = new System.Drawing.Font("宋体", 9F);
            this.btnTitleUserPay.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTitleUserPay.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckAlt;
            this.btnTitleUserPay.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTitleUserPay.IconSize = 32;
            this.btnTitleUserPay.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTitleUserPay.Location = new System.Drawing.Point(331, 2);
            this.btnTitleUserPay.Margin = new System.Windows.Forms.Padding(4);
            this.btnTitleUserPay.Name = "btnTitleUserPay";
            this.btnTitleUserPay.Rotation = 0D;
            this.btnTitleUserPay.Size = new System.Drawing.Size(84, 90);
            this.btnTitleUserPay.TabIndex = 22;
            this.btnTitleUserPay.Text = "会员充值";
            this.btnTitleUserPay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTitleUserPay.UseVisualStyleBackColor = false;
            this.btnTitleUserPay.Click += new System.EventHandler(this.btnTitleUserPay_Click);
            // 
            // btnTitleHome
            // 
            this.btnTitleHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnTitleHome.FlatAppearance.BorderSize = 0;
            this.btnTitleHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(11)))), ((int)(((byte)(10)))));
            this.btnTitleHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitleHome.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTitleHome.Font = new System.Drawing.Font("宋体", 9F);
            this.btnTitleHome.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTitleHome.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.btnTitleHome.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTitleHome.IconSize = 32;
            this.btnTitleHome.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTitleHome.Location = new System.Drawing.Point(244, 2);
            this.btnTitleHome.Margin = new System.Windows.Forms.Padding(4);
            this.btnTitleHome.Name = "btnTitleHome";
            this.btnTitleHome.Rotation = 0D;
            this.btnTitleHome.Size = new System.Drawing.Size(84, 90);
            this.btnTitleHome.TabIndex = 21;
            this.btnTitleHome.Text = "首页";
            this.btnTitleHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTitleHome.UseVisualStyleBackColor = false;
            this.btnTitleHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // btnLockScreen
            // 
            this.btnLockScreen.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnLockScreen.FlatAppearance.BorderSize = 0;
            this.btnLockScreen.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(11)))), ((int)(((byte)(10)))));
            this.btnLockScreen.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLockScreen.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnLockScreen.Font = new System.Drawing.Font("宋体", 9F);
            this.btnLockScreen.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnLockScreen.IconChar = FontAwesome.Sharp.IconChar.Lock;
            this.btnLockScreen.IconColor = System.Drawing.Color.Gainsboro;
            this.btnLockScreen.IconSize = 32;
            this.btnLockScreen.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnLockScreen.Location = new System.Drawing.Point(679, 2);
            this.btnLockScreen.Margin = new System.Windows.Forms.Padding(4);
            this.btnLockScreen.Name = "btnLockScreen";
            this.btnLockScreen.Rotation = 0D;
            this.btnLockScreen.Size = new System.Drawing.Size(84, 90);
            this.btnLockScreen.TabIndex = 20;
            this.btnLockScreen.Text = "锁屏";
            this.btnLockScreen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnLockScreen.UseVisualStyleBackColor = false;
            this.btnLockScreen.Click += new System.EventHandler(this.btnLockScreen_Click);
            // 
            // btnTitleUserConsumption
            // 
            this.btnTitleUserConsumption.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnTitleUserConsumption.FlatAppearance.BorderSize = 0;
            this.btnTitleUserConsumption.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(11)))), ((int)(((byte)(10)))));
            this.btnTitleUserConsumption.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTitleUserConsumption.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnTitleUserConsumption.Font = new System.Drawing.Font("宋体", 9F);
            this.btnTitleUserConsumption.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTitleUserConsumption.IconChar = FontAwesome.Sharp.IconChar.Donate;
            this.btnTitleUserConsumption.IconColor = System.Drawing.Color.Gainsboro;
            this.btnTitleUserConsumption.IconSize = 32;
            this.btnTitleUserConsumption.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnTitleUserConsumption.Location = new System.Drawing.Point(505, 2);
            this.btnTitleUserConsumption.Margin = new System.Windows.Forms.Padding(4);
            this.btnTitleUserConsumption.Name = "btnTitleUserConsumption";
            this.btnTitleUserConsumption.Rotation = 0D;
            this.btnTitleUserConsumption.Size = new System.Drawing.Size(84, 90);
            this.btnTitleUserConsumption.TabIndex = 19;
            this.btnTitleUserConsumption.Text = "会员消费";
            this.btnTitleUserConsumption.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnTitleUserConsumption.UseVisualStyleBackColor = false;
            this.btnTitleUserConsumption.Click += new System.EventHandler(this.btnTitleUserConsumption_Click);
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
            this.btnMinimize.Location = new System.Drawing.Point(1210, 2);
            this.btnMinimize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.btnMinimize.Rotation = 0D;
            this.btnMinimize.Size = new System.Drawing.Size(25, 25);
            this.btnMinimize.TabIndex = 16;
            this.btnMinimize.UseVisualStyleBackColor = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.btnMaximize.FlatAppearance.BorderSize = 0;
            this.btnMaximize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaximize.Flip = FontAwesome.Sharp.FlipOrientation.Normal;
            this.btnMaximize.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.Gainsboro;
            this.btnMaximize.IconSize = 25;
            this.btnMaximize.Location = new System.Drawing.Point(1235, 2);
            this.btnMaximize.Margin = new System.Windows.Forms.Padding(4);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Rotation = 0D;
            this.btnMaximize.Size = new System.Drawing.Size(25, 25);
            this.btnMaximize.TabIndex = 17;
            this.btnMaximize.UseVisualStyleBackColor = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.Font = new System.Drawing.Font("宋体", 10F);
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblTitleChildForm.Location = new System.Drawing.Point(75, 38);
            this.lblTitleChildForm.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(42, 17);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "首页";
            this.lblTitleChildForm.Click += new System.EventHandler(this.lblTitleChildForm_Click);
            // 
            // iconCurrentChildForm
            // 
            this.iconCurrentChildForm.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.iconCurrentChildForm.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(11)))), ((int)(((byte)(10)))));
            this.iconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.iconCurrentChildForm.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(11)))), ((int)(((byte)(10)))));
            this.iconCurrentChildForm.IconSize = 40;
            this.iconCurrentChildForm.Location = new System.Drawing.Point(27, 28);
            this.iconCurrentChildForm.Margin = new System.Windows.Forms.Padding(4);
            this.iconCurrentChildForm.Name = "iconCurrentChildForm";
            this.iconCurrentChildForm.Size = new System.Drawing.Size(43, 40);
            this.iconCurrentChildForm.TabIndex = 0;
            this.iconCurrentChildForm.TabStop = false;
            this.iconCurrentChildForm.Click += new System.EventHandler(this.iconCurrentChildForm_Click);
            // 
            // pDesktop
            // 
            this.pDesktop.BackColor = System.Drawing.SystemColors.Control;
            this.pDesktop.Controls.Add(this.lblFecha);
            this.pDesktop.Controls.Add(this.lblhora);
            this.pDesktop.Controls.Add(this.pbLogo);
            this.pDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pDesktop.Location = new System.Drawing.Point(293, 94);
            this.pDesktop.Margin = new System.Windows.Forms.Padding(4);
            this.pDesktop.Name = "pDesktop";
            this.pDesktop.Size = new System.Drawing.Size(1286, 756);
            this.pDesktop.TabIndex = 3;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.BackColor = System.Drawing.Color.Transparent;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(11)))), ((int)(((byte)(10)))));
            this.lblFecha.Location = new System.Drawing.Point(488, 577);
            this.lblFecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(456, 48);
            this.lblFecha.TabIndex = 31;
            this.lblFecha.Text = "2020年10月26日星期一";
            // 
            // lblhora
            // 
            this.lblhora.AutoSize = true;
            this.lblhora.BackColor = System.Drawing.Color.Transparent;
            this.lblhora.Font = new System.Drawing.Font("Microsoft Sans Serif", 80F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblhora.Location = new System.Drawing.Point(588, 414);
            this.lblhora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblhora.Name = "lblhora";
            this.lblhora.Size = new System.Drawing.Size(589, 153);
            this.lblhora.TabIndex = 30;
            this.lblhora.Text = "10:59:58";
            // 
            // pbLogo
            // 
            this.pbLogo.BackColor = System.Drawing.SystemColors.Control;
            this.pbLogo.Image = global::MemberManagementSystem.Properties.Resources.titleLogo;
            this.pbLogo.Location = new System.Drawing.Point(298, 135);
            this.pbLogo.Margin = new System.Windows.Forms.Padding(4);
            this.pbLogo.Name = "pbLogo";
            this.pbLogo.Size = new System.Drawing.Size(701, 243);
            this.pbLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbLogo.TabIndex = 23;
            this.pbLogo.TabStop = false;
            // 
            // tUserDueTo
            // 
            this.tUserDueTo.Enabled = true;
            this.tUserDueTo.Interval = 1000;
            this.tUserDueTo.Tick += new System.EventHandler(this.tUserDueTo_Tick);
            // 
            // tDate
            // 
            this.tDate.Enabled = true;
            this.tDate.Tick += new System.EventHandler(this.tDate_Tick);
            // 
            // frmMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(120F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.CancelButton = this.btnExit2;
            this.ClientSize = new System.Drawing.Size(1579, 850);
            this.Controls.Add(this.pDesktop);
            this.Controls.Add(this.pTitle);
            this.Controls.Add(this.pMenu);
            this.Font = new System.Drawing.Font("宋体", 10F);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 1, 3, 1);
            this.Name = "frmMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "小红花会员管理系统";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMainMenu_FormClosing);
            this.Load += new System.EventHandler(this.frmMainMenu_Load);
            this.pMenu.ResumeLayout(false);
            this.pSystemSettingsMenu.ResumeLayout(false);
            this.pStatisticalQueryMenu.ResumeLayout(false);
            this.pUserManageMenu.ResumeLayout(false);
            this.pLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            this.pTitle.ResumeLayout(false);
            this.pTitle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCurrentChildForm)).EndInit();
            this.pDesktop.ResumeLayout(false);
            this.pDesktop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pMenu;
        private FontAwesome.Sharp.IconButton btnStatisticalQueryMenu;
        private FontAwesome.Sharp.IconButton btnUserManageMenu;
        private System.Windows.Forms.Panel pLogo;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel pTitle;
        private FontAwesome.Sharp.IconPictureBox iconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private System.Windows.Forms.Panel pDesktop;
        private System.Windows.Forms.Panel pUserManageMenu;
        private FontAwesome.Sharp.IconButton btnUserManage;
        private FontAwesome.Sharp.IconButton btnUserPay;
        private FontAwesome.Sharp.IconButton btnNewUser;
        private System.Windows.Forms.Panel pStatisticalQueryMenu;
        private FontAwesome.Sharp.IconButton btnSmsStatistical;
        private FontAwesome.Sharp.IconButton btnPayStatistical;
        private FontAwesome.Sharp.IconButton btnConsumptionStatistical;
        private FontAwesome.Sharp.IconButton btnUserStatistical;
        private System.Windows.Forms.Panel pSystemSettingsMenu;
        private FontAwesome.Sharp.IconButton btnBasicSetup;
        private FontAwesome.Sharp.IconButton btnUserLevelSetup;
        private FontAwesome.Sharp.IconButton btnConsumptionTypeSetup;
        private FontAwesome.Sharp.IconButton btnExit2;
        private FontAwesome.Sharp.IconButton btnSystemSettingsMenu;
        private FontAwesome.Sharp.IconButton btnMinimize;
        private FontAwesome.Sharp.IconButton btnMaximize;
        private FontAwesome.Sharp.IconButton btnExit;
        private FontAwesome.Sharp.IconButton btnTitleUserConsumption;
        private FontAwesome.Sharp.IconButton btnLockScreen;
        private FontAwesome.Sharp.IconButton btnTitleNewUser;
        private FontAwesome.Sharp.IconButton btnTitleUserPay;
        private FontAwesome.Sharp.IconButton btnTitleUserManage;
        private System.Windows.Forms.Timer tUserDueTo;
        private FontAwesome.Sharp.IconButton btnUserConsumption;
        private FontAwesome.Sharp.IconButton btnTitleHome;
        private System.Windows.Forms.PictureBox pbLogo;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblhora;
        private System.Windows.Forms.Timer tDate;
    }
}

