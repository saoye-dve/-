using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MemberManagementSystem.SystemSettingsMenu
{
    public partial class frmEditConsumptionType : Form
    {
        public frmEditConsumptionType()
        {
            InitializeComponent();

            if (frmLogin.UserLevel == 2)
            {
                frmMainMenu mianColor = new frmMainMenu();
                this.btnUpdate.BackColor = mianColor.color4;
                this.btnCancel.BackColor = mianColor.color4;
                this.pTitle.BackColor = mianColor.color3;
                this.btnMinimize.BackColor = mianColor.color3;
                this.btnExit.BackColor = mianColor.color3;
            }
        }
        public string TypeName = string.Empty;
        DBHelper dbHelper = new DBHelper();
        SqlCommand cmd = null;
        SqlDataReader reader = null;
        /// <summary>
        /// 获取消费类型
        /// </summary>
        public void GetConsumptionType()
        {
            try
            {
                dbHelper.OpenConnection();
                string sql = string.Format(@"select  TypeName 
                                            ,Price ,Enable ,DueToTime 
                                            from ConsumptionType
                                            where TypeName = '{0}'",TypeName);
                cmd = new SqlCommand(sql,dbHelper.Connection);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    this.txtConsumptionType.Text = reader[0].ToString();
                    this.txtPrice.Text = reader[1].ToString();
                    string enable = reader[2].ToString();
                    if (enable.Equals("启用"))
                    {
                        rbYes.Checked = true;
                    }
                    else
                    {
                        rbNo.Checked = true;
                    }
                    this.dtpDueToTime.Value = DateTime.Parse(reader[3].ToString());
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
        /// 修改消费类型
        /// </summary>
        public void UpdateConsumptionType()
        {
            try
            {
                dbHelper.OpenConnection();
                string enable;
                if (rbYes.Checked == true)
                {
                    enable = "启用";
                }
                else
                {
                    enable = "禁用";
                }
                string sql = string.Format(@"update ConsumptionType 
                set TypeName = '{1}',Price={2},Enable='{3}',DueToTime='{4}'
                where TypeName = '{0}'", TypeName, txtConsumptionType.Text, txtPrice.Text, enable, dtpDueToTime.Value);
                cmd = new SqlCommand(sql,dbHelper.Connection);
                int iRet = cmd.ExecuteNonQuery();
                if (iRet>0)
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
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //修改消费类型
            UpdateConsumptionType();
        }

        private void frmEditConsumptionType_Load(object sender, EventArgs e)
        {
            //获取消费类型
            GetConsumptionType();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            //关闭当前窗体
            this.Close();
        }
    }
}
