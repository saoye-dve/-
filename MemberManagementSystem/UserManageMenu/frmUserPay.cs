using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MemberManagementSystem.Function
{
    public partial class frmUserPay : Form
    {
        public frmUserPay()
        {
            InitializeComponent();

            if (frmLogin.UserLevel == 2)
            {
                gbCodeScann.ForeColor = Color.FromArgb(250, 250, 250);
                groupBox1.ForeColor = Color.FromArgb(250, 250, 250);
                groupBox2.ForeColor = Color.FromArgb(250, 250, 250);
                foreach (Control lbl in groupBox2.Controls)
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
                frmMainMenu mianColor = new frmMainMenu();
                //高级用户
                this.BackColor = mianColor.color3;
                this.ForeColor = Color.FromArgb(250, 250, 250);
                groupBox1.ForeColor = Color.FromArgb(250, 250, 250);

                this.btnQuery.BackColor = mianColor.color4;
                this.btnPay.BackColor = mianColor.color4;
                this.BackColor = mianColor.color3;
            }

            //统一按钮颜色
            // BtnStyleAll();

        }
        /// <summary>
        /// 统一按钮颜色
        /// </summary>
        public void BtnStyleAll()
        {
            foreach (Control btn in Controls)
            {
                if (btn is Button)
                {
                    btn.BackColor = Color.FromArgb(163, 5, 4);
                    btn.ForeColor = Color.FromArgb(220, 220, 220);
                }
            }
        }



        DBHelper dbHelper = new DBHelper();
        DataSet ds = null;
        SqlDataAdapter sda = null;


        /// <summary>
        /// 获取付款方式
        /// </summary>
        public void GetMethodPayment()
        {

            try
            {
                ds = new DataSet();
                string sql = "select MethodPaymentNo,TypeName from MethodPayment";
                sda = new SqlDataAdapter(sql, dbHelper.Connection);
                sda.Fill(ds, "MethodPayment");
                this.cboMethodPayment.DataSource = ds.Tables["MethodPayment"];
                this.cboMethodPayment.DisplayMember = "TypeName";
                this.cboMethodPayment.ValueMember = "MethodPaymentNo";

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

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

        private void frmUserPay_Load(object sender, EventArgs e)
        {

            //获取付款方式
            GetMethodPayment();


            //嵌入式打开form窗体方法
            OpenChildForm(new frmCodeScann());

        }


        /// <summary>
        /// 用 ASCII 码范围判断字符是不是汉字
        /// </summary>
        /// <param name="text">待判断字符或字符串</param>
        /// <returns>真：是汉字；假：不是</returns>
        public bool CheckStringChinese(string text)
        {
            bool res = false;
            foreach (char t in text)
            {
                if ((int)t > 127)
                    res = true;
            }
            return res;
        }

        SqlDataReader reader = null;
        string queryType = string.Empty;
        string queryCardNo = string.Empty;
        /// <summary>
        /// 获取查询类型
        /// </summary>
        public void QueryMode()
        {

            if (this.txtQueryNo.Text.Length == 7)
            {
                queryType = "CardNo";
            }
            else if (this.txtQueryNo.Text.Length == 11)
            {
                queryType = "Phone";
            }
            else if (CheckStringChinese(txtQueryNo.Text) && !txtQueryNo.Text.Trim().Equals("支持卡号、手机号、姓名、微信查询"))
            {
                queryType = "Name";
            }
            else if (!qrCode.Trim().Equals(string.Empty))
            {
                queryType = "QrCode";
                txtQueryNo.Text = qrCode;
            }
            else
            {
                queryType = "Wechat";
            }



            try
            {
                dbHelper.OpenConnection();
                string sql = string.Format(@"select CardNo from UserInfo where {1} = '{0}'", this.txtQueryNo.Text, queryType);
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    queryCardNo = reader[0].ToString();
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
        string cardNo = string.Empty;
        string phone = string.Empty;
        string name = string.Empty;
        string balance = string.Empty;
        /// <summary>
        /// 查询用户
        /// </summary>
        public void QueryUser()
        {
            //获取查询类型
            QueryMode();

            try
            {
                dbHelper.OpenConnection();
                string sql = string.Format(@"select U.CardNo,U.Phone,U.Name,B.Balance
                                            from UserInfo as U,Balance as B
                                            where U.CardNo = B.CardNo and U.CardNo = '{0}'", queryCardNo);
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.cardNo = reader[0].ToString();
                    this.phone = reader[1].ToString();
                    this.name = reader[2].ToString();
                    this.balance = reader[3].ToString();
                    this.txtCardNo.Text = cardNo;
                    this.txtPhone.Text = phone;
                    this.txtName.Text = name;
                    this.txtMoney.Text = balance;
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //查询用户
            QueryUser();
        }


        string res = string.Empty;
        /// <summary>
        /// 充值
        /// </summary>
        public void Pay()
        {
            try
            {
                dbHelper.OpenConnection();
                string sql = string.Format(@"insert Recharge values ('{0}','{5}','{1}',{2},{3},GETDATE(),{4});
                                            update Balance set Balance =Balance + {2} where CardNo = '{0}'"
                                            , this.cardNo, this.txtToPayName.Text, this.txtPayMoney.Text,
                                            this.txtNetReceiptsMoney.Text, this.cboMethodPayment.SelectedIndex + 1,txtName.Text);
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                int iRet = cmd.ExecuteNonQuery();
                if (iRet > 0)
                {
                    MessageBox.Show("充值成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    if (BasicSetup.Default.SmsStart == true)
                    {
                        double balance = Convert.ToDouble(txtMoney.Text) + Convert.ToDouble(txtPayMoney.Text);
                        //发送短信
                        res = SmsSend(phone, name, txtPayMoney.Text, cardNo, balance);
                        //添加记录短信
                        AddSms(cardNo, name, phone, txtPayMoney.Text, balance, res);
                    }
                    //刷新数据
                    QueryUser();
                }
                else
                {
                    MessageBox.Show("充值失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        public void AddSms(string cardNo, string name, string phone, string payMoney, double money, string res)
        {
            try
            {
                dbHelper.OpenConnection();
                string sql = string.Format(@"insert Sms
                values ('{0}','{1}','{2}',GETDATE(),
                '尊敬的客户：{1} 您今天在本店充值：{3} 卡号是：{0} 卡上余额：{4}',2,'{5}')"
                    , cardNo, name, phone, payMoney, money, res);
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
        public string SmsSend(string phone, string name, string payMoney, string cardNo, double balance)
        {
            string SmsID = BasicSetup.Default.SmsID;
            string SmsKey = BasicSetup.Default.SmsKey;
            MessageHelper msh = new MessageHelper(true, SmsID, SmsKey, phone, "\n尊敬的客户：" + name + "\n您今天在本店充值：" + payMoney + "\n卡号是：" + cardNo + "\n卡上余额：" + balance);
            return msh.GetSendStr();
        }

        /// <summary>
        /// 非空验证
        /// </summary>
        public bool CheckedInput()
        {
            if (this.txtCardNo.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请先查询用户！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (txtToPayName.Text.Trim().Equals(string.Empty) ||
                    txtPayMoney.Text.Trim().Equals(string.Empty) ||
                    txtNetReceiptsMoney.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请完整填写信息！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (CheckedInput())
            {
                //充值
                Pay();
            }
           
        }

        private void txtQueryNo_Enter(object sender, EventArgs e)
        {

            if (this.txtQueryNo.Text == "支持卡号、手机号、姓名、微信查询")
            {
                this.txtQueryNo.Text = "";
            }
        }

        private void txtQueryNo_Leave(object sender, EventArgs e)
        {
            if (this.txtQueryNo.Text.Length == 0)
            {
                this.txtQueryNo.Text = "支持卡号、手机号、姓名、微信查询";
            }

        }

        public string qrCode = string.Empty;

        private void tQrCode_Tick(object sender, EventArgs e)
        {
            if (!frmCodeScann.qrCode.Trim().Equals(string.Empty))
            {
                qrCode = frmCodeScann.qrCode;
                //查询用户
                QueryUser();
                frmCodeScann.qrCode = string.Empty;

            }
        }
    }
}
