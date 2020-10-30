using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MemberManagementSystem
{
    public partial class frmLockScreen : Form
    {
        public frmLockScreen()
        {
            InitializeComponent();
            if (frmLogin.UserLevel == 2)
            {
                frmMainMenu mianColor = new frmMainMenu();
                this.btnLockScreen.BackColor = mianColor.color4;
                this.btnCancel.BackColor = mianColor.color4;
                this.pTitle.BackColor = mianColor.color3;
            }
        }

        /// <summary>
        /// 非空验证
        /// </summary>
        public bool CheckedInput()
        {
            if (this.txtLockScreenPwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("锁屏密码不允许为空！","温馨提示",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.txtLockScreenPwd.Focus();
                return false;
            }
            else if (this.txtConfirmPwd.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("确认密码不允许为空！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtConfirmPwd.Focus();
                return false;
            }
            else if (!this.txtLockScreenPwd.Text.Trim().Equals(this.txtConfirmPwd.Text.Trim()))
            {
                MessageBox.Show("密码不一样，请重新输入！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.txtLockScreenPwd.Focus();
                return false;
            }
            else
            {
                return true;
            }

        }
        string passWord = string.Empty;

        private void btnLockScreen_Click(object sender, EventArgs e)
        {
            //非空验证
            if (CheckedInput())
            {

                if (this.btnLockScreen.Text.Equals("解锁"))
                {

                    if (this.txtUnlockPwd.Text.Trim().Equals(passWord))
                    {
                        this.btnLockScreen.Text = "锁屏";
                        this.btnCancel.Enabled = true;
                        this.txtConfirmPwd.Enabled = true;
                        this.txtLockScreenPwd.Enabled = true;

                        DialogResult not = MessageBox.Show("你不需要我了吗？", "提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                        if (not == DialogResult.Yes)
                        {
                            //关闭当前窗体
                            this.Close();
                        }
                        else
                        {
                            this.txtConfirmPwd.Clear();
                            this.txtLockScreenPwd.Clear();
                            this.txtUnlockPwd.Clear();
                            this.txtLockScreenPwd.Focus();
                        }
                    }
                    else
                    {
                        MessageBox.Show("密码错误！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.txtUnlockPwd.Clear();
                    }
                }
                else
                {
                    passWord = this.txtConfirmPwd.Text.Trim();
                    this.btnLockScreen.Text = "解锁";
                    this.btnCancel.Enabled = false;
                    this.txtLockScreenPwd.Enabled = false;
                    this.txtConfirmPwd.Enabled = false;
                    this.txtUnlockPwd.Enabled = true;
                    this.txtUnlockPwd.Focus();
                }

            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭当前窗体
            this.Close();
        }
    }
}
