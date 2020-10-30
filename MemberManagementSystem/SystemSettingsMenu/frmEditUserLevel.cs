using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace MemberManagementSystem.SystemSettingsMenu
{
    public partial class frmEditUserLevel : Form
    {

        public frmEditUserLevel()
        {
            InitializeComponent();
            if (frmLogin.UserLevel == 2)
            {
//                 this.btnAddLevel.BackColor = frmMainMenu.color4;
//                 this.btnCancel.BackColor = frmMainMenu.color4;
//                 this.pTitle.BackColor = frmMainMenu.color3;
//                 this.btnMinimize.BackColor = frmMainMenu.color3;
//                 this.btnExit.BackColor = frmMainMenu.color3;
            }
        }

        DBHelper dbHelper = new DBHelper();
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        public string levelName = string.Empty;
        /// <summary>
        /// 获取等级信息
        /// </summary>
        public void GetUserLevelInfo()
        {

            try
            {
                dbHelper.OpenConnection();
                string sql = string.Format(@"select MembersName,money,Discount,Enable,DueToTime 
                                            from MembershipGrade
                                            where MembersName = '{0}'", levelName);
                cmd = new SqlCommand(sql, dbHelper.Connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.txtLevelName.Text = reader[0].ToString();
                    this.txtPrice.Text = reader[1].ToString();
                    this.txtDiscount.Text = reader[2].ToString();
                    if (reader[3].ToString().Equals("启用"))
                    {
                        rbYes.Checked = true;
                    }
                    else
                    {
                        rbNo.Checked = true;
                    }
                    this.dtpDueToTime.Value = Convert.ToDateTime(reader[4]);
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

        private void frmEditUserLevel_Load(object sender, EventArgs e)
        {
            //获取等级信息
            GetUserLevelInfo();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭当前窗体
            this.Close();
        }
        /// <summary>
        /// 修改会员等级
        /// </summary>
        public void UpdateUserLevel()
        {
            try
            {
                dbHelper.OpenConnection();
                string enable = string.Empty;
                if (rbYes.Checked == true)
                {
                    enable = "启用";
                }
                else
                {
                    enable = "禁用";
                }
                string sql = string.Format(@"update MembershipGrade
                set MembersName = '{1}',money = {2},Discount={3},Enable = '{4}',DueToTime = '{5}'
                where MembersName = '{0}' ", levelName, txtLevelName.Text, txtPrice.Text, txtDiscount.Text, enable, dtpDueToTime.Value);
                cmd = new SqlCommand(sql, dbHelper.Connection);
                int iRet = cmd.ExecuteNonQuery();
                if (iRet > 0)
                {
                    MessageBox.Show("修改成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("修改失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void btnAddLevel_Click(object sender, EventArgs e)
        {
            // 修改会员等级
            UpdateUserLevel();
        }


    }
}
