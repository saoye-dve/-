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
    public partial class frmConsumptionTypeSetup : Form
    {
        public frmConsumptionTypeSetup()
        {
            InitializeComponent();

            if (frmLogin.UserLevel == 2)
            {
                gbAddConsumptionType.ForeColor = Color.FromArgb(250, 250, 250);
                foreach (Control lbl in gbAddConsumptionType.Controls)
                {
                    if (lbl is Label)
                    {
                        lbl.ForeColor = Color.FromArgb(250, 250, 250);
                    }
                }
                frmMainMenu mianColor = new frmMainMenu();
                this.btnAddConsumptionType.BackColor = mianColor.color4;
                this.BackColor = mianColor.color3;

                //设置dgv背景色
                this.dgvConsumptioTypeInfo.BackgroundColor = mianColor.color3;
                //设置dgv网格线色
                this.dgvConsumptioTypeInfo.GridColor = mianColor.color2;
                //设置列单元格色
                this.dgvConsumptioTypeInfo.ColumnHeadersDefaultCellStyle.BackColor = mianColor.color2;
                //设置在被选定时的背景色
                //  this.dgvConsumptioTypeInfo.ColumnHeadersDefaultCellStyle.SelectionBackColor = mianColor.color3;
                //设置在被选定时的字体色
                // this.dgvConsumptioTypeInfo.ColumnHeadersDefaultCellStyle.SelectionForeColor = mianColor.color3;
                //设置未选中单元格色
                this.dgvConsumptioTypeInfo.RowsDefaultCellStyle.BackColor = mianColor.color3;
                //设置选中单元格色
                this.dgvConsumptioTypeInfo.RowsDefaultCellStyle.SelectionBackColor = mianColor.color4;
                //设置选中字体色
                // this.dgvConsumptioTypeInfo.RowsDefaultCellStyle.SelectionForeColor = mianColor.color3;
            }
        }
        DBHelper dbHelper = new DBHelper();
        DataSet ds = null;
        SqlDataAdapter sda = null;
        SqlCommand cmd = null;
        /// <summary>
        /// 获取消费类型信息
        /// </summary>
        public void GetConsumptionTypeInfo()
        {

            try
            {
                ds = new DataSet();
                string sql = @"select  TypeName 
                                ,Price,Enable ,DueToTime 
                                from ConsumptionType";
                sda = new SqlDataAdapter(sql, dbHelper.Connection);
                sda.Fill(ds, "ConsumptionType");
                this.dgvConsumptioTypeInfo.DataSource = ds.Tables["ConsumptionType"];
            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }
        }

        private void frmConsumptionTypeSetup_Load(object sender, EventArgs e)
        {
            // 获取消费类型信息
            GetConsumptionTypeInfo();
        }


        /// <summary>
        /// 添加消费类型
        /// </summary>
        public void AddConsumptionTypeName()
        {
            try
            {
                dbHelper.OpenConnection();
                string enabl = string.Empty;
                if (rbYes.Checked == true)
                {
                    enabl = "启用";
                }
                else
                {
                    enabl = "禁用";
                }
                string sql = string.Format(@"insert ConsumptionType
                                             values ('{0}','{1}','{2}','{3}')",
                                 txtConsumptionTypeName.Text, txtPrice.Text, enabl, dtpDueToTime.Value);
                cmd = new SqlCommand(sql, dbHelper.Connection);
                int iRet = cmd.ExecuteNonQuery();
                if (iRet > 0)
                {
                    MessageBox.Show("添加成功", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // 获取消费类型信息
                    GetConsumptionTypeInfo();
                }
                else
                {
                    MessageBox.Show("添加失败", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// <returns></returns>
        public bool CheckedInput()
        {
            if (txtConsumptionTypeName.Text.Trim().Equals(string.Empty)||
                txtPrice.Text.Trim().Equals(string.Empty))
            {
                MessageBox.Show("请完整填写信息", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else
            {
                return true;
            }
        }

        private void btnAddConsumptionType_Click(object sender, EventArgs e)
        {
            //非空验证
            if (CheckedInput())
            {
                //添加消费类型
                AddConsumptionTypeName();
            }

        }

        private void tsmiUpdate_Click(object sender, EventArgs e)
        {
            frmEditConsumptionType frmEdit = new frmEditConsumptionType();
            frmEdit.TypeName = this.dgvConsumptioTypeInfo.SelectedRows[0].Cells[0].Value.ToString();
            frmEdit.ShowDialog();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            try
            {
                string typeName = dgvConsumptioTypeInfo.SelectedRows[0].Cells[0].Value.ToString();
                dbHelper.OpenConnection();
                string sql = string.Format(@"delete from [MemberManagementDB].[dbo].[ConsumptionType] 
                        where TypeName = '{0}'", typeName);
                cmd = new SqlCommand(sql,dbHelper.Connection);
                int iRet = cmd.ExecuteNonQuery();
                if (iRet>0)
                {
                    MessageBox.Show("删除成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // 获取消费类型信息
                    GetConsumptionTypeInfo();
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
