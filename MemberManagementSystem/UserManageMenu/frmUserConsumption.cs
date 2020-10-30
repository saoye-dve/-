using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MemberManagementSystem
{
    public partial class frmUserConsumption : Form
    {
        public frmUserConsumption()
        {
            InitializeComponent();
            if (frmLogin.UserLevel == 2)
            {
                gbCodeScann.ForeColor = Color.FromArgb(250, 250, 250);
                gbQueryMethods.ForeColor = Color.FromArgb(250, 250, 250);
                gbDirectConsumption.ForeColor = Color.FromArgb(250, 250, 250);
                gbUserInfo.ForeColor = Color.FromArgb(250, 250, 250);
                foreach (Control lbl in gbDirectConsumption.Controls)
                {
                    if (lbl is Label)
                    {
                        lbl.ForeColor = Color.FromArgb(250, 250, 250);
                    }
                }
                foreach (Control lbl in gbUserInfo.Controls)
                {
                    if (lbl is Label)
                    {
                        lbl.ForeColor = Color.FromArgb(250, 250, 250);
                    }
                }


                frmMainMenu mianColor = new frmMainMenu();
                this.btnQuery.BackColor = mianColor.color4;
                this.btnConsumption.BackColor = mianColor.color4;
                this.BackColor = mianColor.color3;
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

        //会员折扣
        double discount;
        //会员到期时间
        DateTime dueToTime;
        //支付密码
        string pwd;
        //会员状态
        string memberState;
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
                string sql = string.Format(@"select U.CardNo,U.Phone,U.Name,B.Balance,U.MemberState,U.PassWord,M.MembersName,M.Discount,U.DueToTime
                                        from UserInfo as U,Balance as B ,MembershipGrade as M 
                                        where B.CardNo = U.CardNo and U.CardNo = '{0}' and  M.LevelNo = U.LevelNo", queryCardNo);
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    this.txtCardNo.Text = reader[0].ToString();
                    this.txtPhone.Text = reader[1].ToString();
                    this.txtName.Text = reader[2].ToString();
                    this.txtMoney.Text = reader[3].ToString();
                    pwd = reader[5].ToString();
                    memberState = reader[4].ToString();
                    this.txtMembersName.Text = reader[6].ToString();
                    discount = Convert.ToDouble(reader[7]);
                    dueToTime = Convert.ToDateTime(reader[8]);


                    if (memberState.Trim().Equals("锁定"))
                    {
                        MessageBox.Show("账户已锁定，无法进行消费", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    if (dueToTime > DateTime.Parse("2000/01/01"))
                    {
                        if (dueToTime <= DateTime.Now)
                        {
                            MessageBox.Show("会员已到期", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }

                }
                reader.Close();
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

        private void btnQuery_Click(object sender, EventArgs e)
        {
            //查询用户
            QueryUser();
            //获取消费价格
            GetConsumptionPrice();
        }




        public double price;//消费价格
        /// <summary>
        /// 获取消费价格
        /// </summary>
        public void GetConsumptionPrice()
        {

            SqlDataReader reader = null;
            try
            {
                dbHelper.OpenConnection();
                string sql = string.Format(@"select Price from ConsumptionType where TypeName = '{0}'", this.cboConsumptionType.Text);
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                reader = cmd.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        price = Convert.ToDouble(reader[0]);
                        this.txtShouldBeMoney.Text = price.ToString();
                        this.txtActualMoney.Text = (discount * price).ToString();
                        this.txtPaidinAmount.Text = (discount * price).ToString();
                    }

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
        /// <summary>
        /// 获取消费类型
        /// </summary>
        public void GetConsumptionType()
        {
            try
            {
                ds = new DataSet();
                string sql = string.Format(@"select * from ConsumptionType where Enable = '启用' and DueToTime > GETDATE()");
                sda = new SqlDataAdapter(sql, dbHelper.Connection);
                sda.Fill(ds, "ConsumptionType");
                this.cboConsumptionType.DataSource = ds.Tables["ConsumptionType"];
                this.cboConsumptionType.DisplayMember = "TypeName";
                this.cboConsumptionType.ValueMember = "ConsumptionTypeNo";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //获取消费方式
        public void GetConsumptionPatterns()
        {
            try
            {
                ds = new DataSet();
                string sql = "select ConsumptionPatternsNo,TypeName from ConsumptionPatterns";
                sda = new SqlDataAdapter(sql, dbHelper.Connection);
                sda.Fill(ds, "ConsumptionPatterns");
                this.cboConsumptionPatterns.DataSource = ds.Tables["ConsumptionPatterns"];
                this.cboConsumptionPatterns.DisplayMember = "TypeName";
                this.cboConsumptionPatterns.ValueMember = "ConsumptionPatternsNo";
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

        private void frmUserConsumption_Load(object sender, EventArgs e)
        {
            //获取消费方式
            GetConsumptionPatterns();

            //获取付款方式
            GetMethodPayment();

            //获取消费类型
            GetConsumptionType();

            //嵌入式打开form窗体方法
            OpenChildForm(new frmCodeScann());
        }



        string res = string.Empty;
        /// <summary>
        /// 消费
        /// </summary>
        public void Consumption()
        {
            try
            {
                dbHelper.OpenConnection();
                string sql = string.Format(@"update Balance set Balance = Balance - '{0}' where CardNo = '{1}' and Balance>'{0}'",
                                           this.txtPaidinAmount.Text, queryCardNo);
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                int iRet = cmd.ExecuteNonQuery();
                if (iRet > 0)
                {
                    double balance = Convert.ToDouble(txtMoney.Text) - Convert.ToDouble(txtPaidinAmount.Text);
                    //添加消费记录
                    RecordsConsumption();
                    if (BasicSetup.Default.SmsStart == true)
                    {
                        //发送短信
                        res = SmsSend(txtPhone.Text, txtName.Text, txtPaidinAmount.Text, txtCardNo.Text, balance);
                        //添加记录短信
                        AddSms(txtCardNo.Text, txtName.Text, txtPhone.Text, txtPaidinAmount.Text, balance, res);
                    }

                    MessageBox.Show("消费成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("消费失败！余额不足！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// 发送短信
        /// </summary>
        public string SmsSend(string phone, string name, string paidinAmount, string cardNo, double balance)
        {
            string SmsID = BasicSetup.Default.SmsID;
            string SmsKey = BasicSetup.Default.SmsKey;
            MessageHelper msh = new MessageHelper(true, SmsID, SmsKey, phone, "\n尊敬的客户：" + name + "\n您今天在本店消费：" + paidinAmount + "\n卡号是：" + cardNo + "\n卡上余额：" + balance);
            return msh.GetSendStr();
        }
        /// <summary>
        /// 添加记录短信
        /// </summary>
        public void AddSms(string cardNo, string name, string phone, string paidinAmount, double balance, string res)
        {
            try
            {
                dbHelper.OpenConnection();
                string sql = string.Format(@"insert Sms
                values ('{0}','{1}','{2}',GETDATE(),
                '尊敬的客户：{1} 您今天在本店消费：{3} 卡号是：{0} 卡上余额：{4}',3,'{5}')"
                    , cardNo, name, phone, paidinAmount, balance, res);
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
        /// 添加消费记录
        /// </summary>
        public void RecordsConsumption()
        {
            try
            {
                dbHelper.OpenConnection();
                string sql = string.Format(@"insert Orders values ('{0}','{1}',{2},{3},{4},{5},{6},GETDATE(),'{7}')",
                                              queryCardNo, this.txtName.Text, this.cboConsumptionPatterns.SelectedValue,
                                              this.cboMethodPayment.SelectedValue, this.cboConsumptionType.SelectedValue,
                                              this.txtShouldBeMoney.Text, this.txtPaidinAmount.Text, this.txtNote.Text);
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
        /// 非空验证
        /// </summary>
        public bool CheckedInput()
        {
            if (txtCardNo.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请先查询用户！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (!this.txtPwd.Text.Equals(pwd))
            {
                MessageBox.Show("密码错误！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnConsumption_Click(object sender, EventArgs e)
        {
            //非空验证
            if (CheckedInput())
            {
                //消费
                Consumption();
            }
        }


        private void cboConsumptionType_SelectedIndexChanged(object sender, EventArgs e)
        {
            //获取消费价格
            GetConsumptionPrice();
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
                //获取消费价格
                GetConsumptionPrice();
                frmCodeScann.qrCode = string.Empty;
       
            }
        }

    }
}
