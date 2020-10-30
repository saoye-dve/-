using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MemberManagementSystem.SystemSettingsMenu
{
    public partial class frmUserLevelSetup : Form
    {
        public frmUserLevelSetup()
        {
            InitializeComponent();
            if (frmLogin.UserLevel == 2)
            {
                gbAddUserlLevel.ForeColor = Color.FromArgb(250, 250, 250);
                foreach (Control lbl in gbAddUserlLevel.Controls)
                {
                    if (lbl is Label)
                    {
                        lbl.ForeColor = Color.FromArgb(250, 250, 250);
                    }
                }
                frmMainMenu mianColor = new frmMainMenu();

                this.btnAddLevel.BackColor = mianColor.color4;
                this.BackColor = mianColor.color3;
                //设置窗体背景色
                this.BackColor = mianColor.color3;
                //设置dgv背景色
                this.dgvUserLevelInfo.BackgroundColor = mianColor.color3;
                //设置dgv网格线色
                this.dgvUserLevelInfo.GridColor = mianColor.color2;
                //设置列单元格色
                this.dgvUserLevelInfo.ColumnHeadersDefaultCellStyle.BackColor = mianColor.color2;
                //设置在被选定时的背景色
                //  this.dgvUserLevelInfo.ColumnHeadersDefaultCellStyle.SelectionBackColor = mianColor.color3;
                //设置在被选定时的字体色
                // this.dgvUserLevelInfo.ColumnHeadersDefaultCellStyle.SelectionForeColor = mianColor.color3;
                //设置未选中单元格色
                this.dgvUserLevelInfo.RowsDefaultCellStyle.BackColor = mianColor.color3;
                //设置选中单元格色
                this.dgvUserLevelInfo.RowsDefaultCellStyle.SelectionBackColor = mianColor.color4;
                //设置选中字体色
                // this.dgvUserLevelInfo.RowsDefaultCellStyle.SelectionForeColor = mianColor.color3;
            }
        }
        DBHelper dbHelper = new DBHelper();
        DataSet ds = null;
        SqlDataAdapter sda = null;
        /// <summary>
        /// 获取会员等级信息
        /// </summary>
        public void GetUserLevelInfo()
        {

            try
            {
                ds = new DataSet();
                string sql = @"select MembersName ,money
                                ,Discount,Enable,DueToTime
                                from MembershipGrade";
                sda = new SqlDataAdapter(sql, dbHelper.Connection);
                sda.Fill(ds, "UserLevel");
                this.dgvUserLevelInfo.DataSource = ds.Tables["UserLevel"];
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmUserLevelSetup_Load(object sender, EventArgs e)
        {
            //获取会员等级信息
            GetUserLevelInfo();
        }

        /// <summary>
        /// 添加会员等级
        /// </summary>
        public void AddUserLevel()
        {
            try
            {
                dbHelper.OpenConnection();
                string enabl = string.Empty;
                if (this.rbYes.Checked == true)
                {
                    enabl = "启用";
                }
                else
                {
                    enabl = "禁用";
                }
                string sql = string.Format(@"insert MembershipGrade values('{0}',{1},{2},'{3}','{4}')",
                                            this.txtLevelName.Text, this.txtPrice.Text, this.txtDiscount.Text, enabl, this.dtpDueToTime.Value);
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                int iRet = cmd.ExecuteNonQuery();
                if (iRet > 0)
                {
                    MessageBox.Show("添加成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //获取会员等级信息
                    GetUserLevelInfo();
                }
                else
                {
                    MessageBox.Show("添加失败！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// 非空验证
        /// </summary>
        public bool CheckedInput()
        {
            if (this.txtDiscount.Text.Trim().Equals(string.Empty) ||
                this.txtLevelName.Text.Trim().Equals(string.Empty) ||
                this.txtPrice.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请完整填写信息！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }
        private void btnAddLevel_Click(object sender, EventArgs e)
        {
            //非空验证
            if (CheckedInput())
            {
                //添加会员等级
                AddUserLevel();
            }

        }



        public string levelName = string.Empty;
        /// <summary>
        /// 获取选中等级信息
        /// </summary>
        public void GetSelectUserLevelInfo()
        {
            frmEditUserLevel frmEdit = new frmEditUserLevel();
            frmEdit.levelName = this.dgvUserLevelInfo.SelectedRows[0].Cells[0].Value.ToString();
            frmEdit.ShowDialog();
        }

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            //获取选中等级信息
            GetSelectUserLevelInfo();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string typeName = dgvUserLevelInfo.SelectedRows[0].Cells[0].Value.ToString();
                dbHelper.OpenConnection();
                string sql = string.Format(@"  delete from MembershipGrade where MembersName = '{0}'", typeName);
               SqlCommand  cmd = new SqlCommand(sql, dbHelper.Connection);
                int iRet = cmd.ExecuteNonQuery();
                if (iRet > 0)
                {
                    MessageBox.Show("删除成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //获取会员等级信息
                    GetUserLevelInfo();
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
}
