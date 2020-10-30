using CodeScaner;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MemberManagementSystem.SystemSettingsMenu
{
    public partial class frmBasicSetup : Form
    {
        public CamControl camControl;
        public frmBasicSetup()
        {
            camControl = new CamControl();
            InitializeComponent();
            //获取摄像头设备
            RefreshCombo();
            if (frmLogin.UserLevel == 2)
            {
                gbSmsSettings.ForeColor = Color.FromArgb(250, 250, 250);
                groupBox1.ForeColor = Color.FromArgb(250, 250, 250);
                foreach (Control lbl in gbSmsSettings.Controls)
                {
                    if (lbl is Label)
                    {
                        lbl.ForeColor = Color.FromArgb(250, 250, 250);
                    }
                }
                foreach (Control lbl in Controls)
                {
                    if (lbl is Label)
                    {
                        lbl.ForeColor = Color.FromArgb(250, 250, 250);
                    }
                }
                this.llblContactYourAdministrator.LinkColor = Color.FromArgb(250, 250, 250);
                this.label3.ForeColor = Color.FromArgb(250, 250, 250);
                frmMainMenu mianColor = new frmMainMenu();
                this.btnSaveSetup.BackColor = mianColor.color4;
                this.btnDefault.BackColor = mianColor.color4;
                this.llblForgotPassword.LinkColor = Color.FromArgb(250, 250, 250);
                this.BackColor = mianColor.color3;
            }
        }





        /// <summary>
        /// 读取短信配置
        /// </summary>
        public void SmsConfigRead()
        {
            this.txtUid.Text = BasicSetup.Default.SmsID;
            this.txtKey.Text = BasicSetup.Default.SmsKey;
            this.cbStartSms.Checked = BasicSetup.Default.SmsStart;
            this.cboCamera.SelectedIndex = BasicSetup.Default.Webcam;
        }

        /// <summary>
        /// 保存短信配置
        /// </summary>
        public void SmsConfigSave()
        {
            BasicSetup.Default.SmsID = this.txtUid.Text;
            BasicSetup.Default.SmsKey = this.txtKey.Text;
            BasicSetup.Default.SmsStart = this.cbStartSms.Checked;
            BasicSetup.Default.Webcam = this.cboCamera.SelectedIndex;
            BasicSetup.Default.Save();
        }

        /// <summary>
        /// 读取短信余额
        /// </summary>
        public void SmsBalanceOf()
        {
            if (!BasicSetup.Default.SmsID.Trim().Equals(string.Empty))
            {
                string balanceOf = MessageHelper.SmsBalanceOf(BasicSetup.Default.SmsID, BasicSetup.Default.SmsKey);
                this.lblBalanceOf.Text = string.Format("短信余额：{0} 条", balanceOf);
            }

        }


        private void frmBasicSetup_Load(object sender, EventArgs e)
        {
            //读取短信余额
            SmsBalanceOf();
            //读取短信配置
            SmsConfigRead();
        }

        private void btnSaveSetup_Click(object sender, EventArgs e)
        {
            //保存短信配置
            SmsConfigSave();
            //读取短信余额
            SmsBalanceOf();
            MessageBox.Show("保存成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        /// <summary>
        /// 恢复默认
        /// </summary>
        public void ClearInput()
        {
            txtKey.Clear();
            txtUid.Clear();
            cbStartSms.Checked = false;
            lblBalanceOf.Text = "短信余额：0 条";
        }

        private void btnDefault_Click(object sender, EventArgs e)
        {
            //恢复默认
            ClearInput();
            //保存短信配置
            SmsConfigSave();
        }

        private void llblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("http://sms.webchinese.cn/default.shtml");
        }


        /// <summary>
        /// 获取摄像头设备
        /// </summary>
        public void RefreshCombo()
        {
            this.cboCamera.Items.Clear();
            for (int i = 0; i < camControl.Devices.Count; i++)
            {
                this.cboCamera.Items.Add(camControl.Devices[i].Name);
            }

        }

        private void cboCamera_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (camControl.SelectedDevice.IsRunning)
            {
                camControl.SelectedDevice.SignalToStop();
            }
        }
        /// <summary>
        /// 保存颜色
        /// </summary>
        /// <param name="btnColor"></param>
        public void ColorSave(Button btnColor)
        {
            if (frmLogin.UserLevel == 2)
            {
                ColorSetup.Default.R = Convert.ToInt32(btnColor.BackColor.R);
                ColorSetup.Default.G = Convert.ToInt32(btnColor.BackColor.G);
                ColorSetup.Default.B = Convert.ToInt32(btnColor.BackColor.B);
                ColorSetup.Default.Save();
                Application.Restart();
            }
            else
            {
                MessageBox.Show("您不是高级用户，无法使用炫彩皮肤！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void btnColor1_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor1);
        }

        private void btnColor2_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor2);
        }

        private void btnColor3_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor3);
        }

        private void btnColor4_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor4);
        }

        private void btnColor5_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor5);
        }

        private void btnColor6_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor6);
        }

        private void btnColor7_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor7);
        }

        private void btnColor8_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor8);
        }

        private void btnColor9_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor9);
        }

        private void btnColor10_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor10);
        }

        private void btnColor11_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor11);
        }

        private void btnColor12_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor12);
        }

        private void btnColor13_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor13);
        }

        private void btnColor14_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor14);
        }

        private void btnColor15_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor15);
        }

        private void btnColor16_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor16);
        }

        private void btnColor17_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor17);
        }

        private void btnColor18_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor18);
        }

        private void btnColor19_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor19);
        }

        private void btnColor20_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor20);
        }

        private void btnColor21_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor21);
        }

        private void btnColor22_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor22);
        }

        private void btnColor23_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor23);
        }

        private void btnColor24_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor24);
        }

        private void btnColor25_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor25);
        }

        private void btnColor26_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor26);
        }

        private void btnColor27_Click(object sender, EventArgs e)
        {
            ColorSave(btnColor27);
        }

        private void llblContactYourAdministrator_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "http://wpa.qq.com/msgrd?v=3&uin=" + "2693451077" + "&site=qq&menu=yes";
            System.Diagnostics.Process.Start(url);
        }


    }
}
