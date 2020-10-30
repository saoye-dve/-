using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MemberManagementSystem
{
    public partial class frmNewUser : Form
    {
        public frmNewUser()
        {
            InitializeComponent();
            if (frmLogin.UserLevel == 2)
            {
                gbCodeScann.ForeColor = Color.FromArgb(250, 250, 250);
                foreach (Control lbl in Controls)
                {
                    if (lbl is Label)
                    {
                        lbl.ForeColor = Color.FromArgb(250, 250, 250);
                    }
                }
                this.rbNormal.ForeColor = Color.FromArgb(250, 250, 250);
                this.rbLock.ForeColor = Color.FromArgb(250, 250, 250);
                this.rbMale.ForeColor = Color.FromArgb(250, 250, 250);
                this.rbShe.ForeColor = Color.FromArgb(250, 250, 250);

                frmMainMenu mianColor = new frmMainMenu();
                this.btnNew.BackColor = mianColor.color4;
                this.btnClear.BackColor = mianColor.color4;
                this.BackColor = mianColor.color3;
            }
        }


        DBHelper dbHelper = new DBHelper();
        DataSet ds = null;
        SqlDataAdapter sda = null;
        /// <summary>
        /// 获取用户等级信息
        /// </summary>
        public void GetUserLevelInfo()
        {

            try
            {
                ds = new DataSet();
                string sql = string.Format("select LevelNo,MembersName from MembershipGrade");
                sda = new SqlDataAdapter(sql, dbHelper.Connection);
                sda.Fill(ds, "Level");
                this.cboUserLevel.DataSource = ds.Tables["Level"];
                this.cboUserLevel.DisplayMember = "MembersName";
                this.cboUserLevel.ValueMember = "LevelNo";

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 随机生成卡号
        /// </summary>
        public void GetCardNo()
        {
            Random ran = new Random();
            string cardNo = Convert.ToString(ran.Next(1000000, 9999999));
            this.txtCardNo.Text = cardNo;
        }



        //当前打开的Form
        private Form currentChildForm;

        /// <summary>
        /// 嵌入式打开form窗体方法
        /// </summary>
        /// <param name="childForm">窗体</param>
        private void OpenChildForm(Form childForm)
        {
            //当前窗体不等于空
            if (currentChildForm != null)
            {
                //只开放形式
                currentChildForm.Close();

            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            //设置form窗体边框为无边框
            childForm.FormBorderStyle = FormBorderStyle.None;
            //设置form为全部停靠
            childForm.Dock = DockStyle.Fill;
            //将form添加显示到控件
            pCodeScann.Controls.Add(childForm);
            //控件数据对象设置为form
            pCodeScann.Tag = childForm;
            childForm.BringToFront();
            //显示from
            childForm.Show();

        }

        private void frmNewUser_Load(object sender, EventArgs e)
        {
            //调用随机生成卡号
            GetCardNo();
            //调用获取用户等级信息
            GetUserLevelInfo();

            //嵌入式打开form窗体方法
            OpenChildForm(new frmCodeScann());


        }

        string money = string.Empty;
        SqlDataReader reader = null;
        /// <summary>
        /// 获取会员等级价格
        /// </summary>
        public void GetPackageMoney()
        {
            try
            {
                dbHelper.OpenConnection();
                string sql = string.Format("select money from MembershipGrade where LevelNo = {0}", this.cboUserLevel.SelectedValue);
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    money = reader[0].ToString();
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                dbHelper.CloseConnection();
            }
        }



        //发送是否成功参数
        string res = string.Empty;
        /// <summary>
        /// 新建用户
        /// </summary>
        public void NewUser()
        {
            string cardNo = this.txtCardNo.Text;
            string state = string.Empty;
            if (rbNormal.Checked)
            {
                state = "正常";
            }
            else
            {
                state = "锁定";
            }

            string name = this.txtName.Text;
            string pass = this.txtPwd.Text;
            string wechat = this.txtWechat.Text;
            string phone = this.txtPhone.Text;
            string sex = string.Empty;
            if (rbMale.Checked)
            {
                sex = "男";
            }
            else
            {
                sex = "女";
            }
            DateTime birthday = this.dtpBirthday.Value;
            int userLevel = Convert.ToInt32(cboUserLevel.SelectedValue);
            string note = this.txtNote.Text;
            DateTime dueToTime = this.dtpDueToTime.Value;

            try
            {
                dbHelper.OpenConnection();
                string sql = string.Format(@"insert UserInfo values ('{0}','{1}','{2}'
                ,'{3}','{4}','{13}','{5}','{6}','{7}',{8},'{9}',GETDATE(),'{10}');
                insert Balance values ('{0}',{12},{11})"
                    , cardNo, state, name, pass, wechat, phone, sex, birthday
                    , userLevel, note, dueToTime, this.cboUserLevel.SelectedValue, money, txtQrCode.Text);
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                int iRet = cmd.ExecuteNonQuery();
                if (iRet > 0)
                {
                    if (BasicSetup.Default.SmsStart == true)
                    {
                        //发送短信
                        res = SmsSend(phone, name, cboUserLevel.Text, cardNo, money);
                        //添加记录短信
                        AddSms(cardNo, name, phone, cboUserLevel.Text, money, res);
                    }
                    MessageBox.Show("新建成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearUserInput();
                    GetCardNo();
                }
                else
                {
                    MessageBox.Show("新建失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }
        /// <summary>
        /// 添加记录短信
        /// </summary>
        public void AddSms(string cardNo, string name, string phone, string userLevel, string money, string res)
        {
            try
            {
                dbHelper.OpenConnection();
                string sql = string.Format(@"insert Sms
                values ('{0}','{1}','{2}',GETDATE(),
                '尊敬的客户：{1} 您今天在本店开通：{3} 卡号是：{0} 卡上余额：{4}',1,'{5}')"
                    , cardNo, name, phone, userLevel, money, res);
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                dbHelper.CloseConnection();
            }
        }

        /// <summary>
        /// 发送短信
        /// </summary>
        public string SmsSend(string phone, string name, string userLevel, string cardNo, string money)
        {
            string SmsID = BasicSetup.Default.SmsID;
            string SmsKey = BasicSetup.Default.SmsKey;
            MessageHelper msh = new MessageHelper(true, SmsID, SmsKey, phone, "\n尊敬的客户：" + name + "\n您今天在本店开通：" + userLevel + "\n卡号是：" + cardNo + "\n卡上余额：" + money);
            return msh.GetSendStr();
        }

        /// <summary>
        /// 非空验证
        /// </summary>
        /// <returns>不为空返回true</returns>
        public bool CheckedInput()
        {
            if (this.txtQrCode.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请先绑定二维码信息！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (this.txtName.Text.Trim().Equals(string.Empty) ||
               this.txtPhone.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请完整填写信息！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }

        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            //非空验证
            if (CheckedInput())
            {
                //调用获取会员等级价格
                GetPackageMoney();
                //调用新建用户
                NewUser();
            }
        }
        /// <summary>
        /// 清空编辑框内容
        /// </summary>
        public void ClearUserInput()
        {

            this.txtName.Clear();
            this.txtPwd.Clear();
            this.txtWechat.Clear();
            this.txtPhone.Clear();
            this.txtNote.Clear();
            this.txtQrCode.Clear();
            this.rbNormal.Checked = true;
            this.rbMale.Checked = true;
            this.cboUserLevel.SelectedIndex = 0;
            this.dtpBirthday.Value = Convert.ToDateTime("1999/1/1");
            this.dtpDueToTime.Value = Convert.ToDateTime("1999/1/1");
        }


        private void btnClear_Click(object sender, EventArgs e)
        {
            //调用清空编辑框内容
            ClearUserInput();
        }

        private void tQrCode_Tick(object sender, EventArgs e)
        {
            if (!frmCodeScann.qrCode.Trim().Equals(string.Empty))
            {
                this.txtQrCode.Text = frmCodeScann.qrCode;
                frmCodeScann.qrCode = string.Empty;
            }
        }
    }
}
