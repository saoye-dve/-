using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using MemberManagementSystem.UserManageMenu;

namespace MemberManagementSystem
{
    public partial class frmUserManage : Form
    {
        public frmUserManage()
        {
            InitializeComponent();

            if (frmLogin.UserLevel == 2)
            {
                gbQueryMethods.ForeColor = Color.FromArgb(250, 250, 250);

                frmMainMenu mianColor = new frmMainMenu();
                this.btnQuery.BackColor = mianColor.color4;

                this.label1.ForeColor = Color.FromArgb(250, 250, 250);

                this.BackColor = mianColor.color3;

                //设置dgv背景色
                this.dgvUserInfo.BackgroundColor = mianColor.color3;
                //设置dgv网格线色
                this.dgvUserInfo.GridColor = mianColor.color2;
                //设置列单元格色
                this.dgvUserInfo.ColumnHeadersDefaultCellStyle.BackColor = mianColor.color2;
                //设置在被选定时的背景色
                //  this.dgvUserInfo.ColumnHeadersDefaultCellStyle.SelectionBackColor = mianColor.color3;
                //设置在被选定时的字体色
                // this.dgvUserInfo.ColumnHeadersDefaultCellStyle.SelectionForeColor = mianColor.color3;
                //设置未选中单元格色
                this.dgvUserInfo.RowsDefaultCellStyle.BackColor = mianColor.color3;
                //设置选中单元格色
                this.dgvUserInfo.RowsDefaultCellStyle.SelectionBackColor = mianColor.color4;
                //设置选中字体色
                // this.dgvUserInfo.RowsDefaultCellStyle.SelectionForeColor = mianColor.color3;
            }

        }

        SqlDataAdapter sda = null;
        DataSet ds = null;
        DBHelper dbHelper = new DBHelper();
        /// <summary>
        /// 获取用户信息
        /// </summary>
        /// <param name="sqlStatement">sql语句</param>
        public void GetUserInfo(string sqlStatement)
        {
            try
            {
                ds = new DataSet();
                string sql = string.Format(@"select U.CardNo,U.MemberState, U.Name
                                        ,U.PassWord,U.Wechat,U.Phone,U.Sex
                                        ,U.Birthday,M.MembersName,B.Balance,U.Note
                                        ,U.OpenCardDate,U.DueToTime
                                        from Userinfo as U,MembershipGrade as M ,Balance as B
                                        where U.LevelNo = M.LevelNo and U.CardNo = B.CardNo {0}", sqlStatement);
                sda = new SqlDataAdapter(sql, dbHelper.Connection);
                sda.Fill(ds, "UserInfo");
                
                this.dgvUserInfo.DataSource = ds.Tables["UserInfo"];

                
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

 


        private void frmUserManage_Load(object sender, EventArgs e)
        {
            //无参调用获取会员信息
            GetUserInfo(null);
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
        /// 根据查询类型查询
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
            else if (CheckStringChinese(txtQueryNo.Text))
            {
                queryType = "Name";
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



        private void btnQuery_Click(object sender, EventArgs e)
        {
            if (this.txtQueryNo.Text.Trim().Equals(string.Empty) 
                || this.txtQueryNo.Text.Trim().Equals("支持卡号、手机号、姓名、微信查询、为空查询全部"))
            {
                //无参调用获取会员信息
                GetUserInfo(null);
            }
            else
            {
                queryCardNo = string.Empty;
                //调用根据查询类型查询
                QueryMode();
                string sqlStatement = string.Format(" and U.CardNo ='{0}'", queryCardNo);
                //传参调用获取会员信息
                GetUserInfo(sqlStatement);
            }


        }



        /// <summary>
        /// 删除用户
        /// </summary>
        public void DeleteUser()
        {
            string cardNo = this.dgvUserInfo.SelectedRows[0].Cells[0].Value.ToString();
            DialogResult result = MessageBox.Show("是否删除卡号为" + cardNo + "的用户!", "温馨提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    dbHelper.OpenConnection();
                    string sql = string.Format(@"delete from Balance where CardNo = '{0}';
                                            delete from Orders where CardNo = '{0}';
                                            delete from Recharge where CardNo = '{0}';
                                            delete from UserInfo where CardNo = '{0}'", cardNo);
                    SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                    int iRet = cmd.ExecuteNonQuery();
                    if (iRet > 0)
                    {
                        MessageBox.Show("删除成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetUserInfo(null);
                    }
                    else
                    {
                        MessageBox.Show("删除失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetUserInfo(null);
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

        }

        private void tsmiDeleteUser_Click(object sender, EventArgs e)
        {
            //调用删除会员
            DeleteUser();
        }

        /// <summary>
        /// 判断会员状态
        /// </summary>
        /// <returns>为正常返回true</returns>
        public bool IsUserState()
        {
            string state = this.dgvUserInfo.SelectedRows[0].Cells[1].Value.ToString();
            if (state.Trim().Equals("正常"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 会员锁定
        /// </summary>
        public void UserLock()
        {
            string cardNo = this.dgvUserInfo.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                dbHelper.OpenConnection();
                string sql = string.Format(@"update UserInfo
                                            set MemberState = '锁定'
                                            where CardNo = '{0}'", cardNo);
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                int iRet = cmd.ExecuteNonQuery();
                if (iRet > 0)
                {
                    MessageBox.Show("锁定成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetUserInfo(null);
                }
                else
                {
                    MessageBox.Show("锁定失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetUserInfo(null);
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

        private void tsmiUserLock_Click(object sender, EventArgs e)
        {
            //判断会员状态
            if (IsUserState())
            {
                //锁定会员
                UserLock();
            }
            else
            {
                MessageBox.Show("当前已经是锁定状态！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        /// <summary>
        /// 用户激活
        /// </summary>
        public void UserActivate()
        {
            string cardNo = this.dgvUserInfo.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                dbHelper.OpenConnection();
                string sql = string.Format(@"update UserInfo
                                            set MemberState = '正常'
                                            where CardNo = '{0}'", cardNo);
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                int iRet = cmd.ExecuteNonQuery();
                if (iRet > 0)
                {
                    MessageBox.Show("激活成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetUserInfo(null);
                }
                else
                {
                    MessageBox.Show("激活失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GetUserInfo(null);
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
        /// 判断是否是期卡用户
        /// </summary>
        public bool DueToUser()
        {
            DateTime dueto = Convert.ToDateTime(this.dgvUserInfo.SelectedRows[0].Cells[12].Value);
            DateTime temp = Convert.ToDateTime("2000-01-01");
            DateTime onDay = DateTime.Today;
            if (dueto > temp)
            {
 
                if (dueto>onDay)
                {
                    return false;
                }
                else
                {
                    return true;
                }
        
            }
            else
            {
                return false;
            }
        }

        private void tsmiUserActivate_Click(object sender, EventArgs e)
        {
            //判断会员状态
            if (!IsUserState())
            {
                //判断是否是期卡用户
                if (DueToUser())
                {
                    frmUpdateUserInfo frmUserinfo = new frmUpdateUserInfo();
                    frmUserinfo.cardNo = this.dgvUserInfo.SelectedRows[0].Cells[0].Value.ToString();
                    frmUserinfo.Show();
                    
                }
                else
                {
                    //用户激活
                    UserActivate();
                }
            }
            else
            {
                MessageBox.Show("当前已经是正常状态！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void tsmiUpdateUserInfo_Click(object sender, EventArgs e)
        {

            frmUpdateUserInfo frmUserinfo = new frmUpdateUserInfo();
            frmUserinfo.cardNo = this.dgvUserInfo.SelectedRows[0].Cells[0].Value.ToString();
            frmUserinfo.ShowDialog();
            //获取会员信息无参
            GetUserInfo(null);
        }

        private void txtQueryNo_Enter(object sender, EventArgs e)
        {

            if (this.txtQueryNo.Text == "支持卡号、手机号、姓名、微信查询、为空查询全部")
            {
                this.txtQueryNo.Text = "";
            }
        }

        private void txtQueryNo_Leave(object sender, EventArgs e)
        {
            if (this.txtQueryNo.Text.Length == 0)
            {
                this.txtQueryNo.Text = "支持卡号、手机号、姓名、微信查询、为空查询全部";
            }

        }






    }
}
