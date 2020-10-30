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
    public partial class frmUserStatistical : Form
    {
        public frmUserStatistical()
        {
            InitializeComponent();
            if (frmLogin.UserLevel == 2)
            {
                gbScreen.ForeColor = Color.FromArgb(250, 250, 250);
                groupBox2.ForeColor = Color.FromArgb(250, 250, 250);
                tsslTotalMembership.ForeColor = Color.FromArgb(250, 250, 250);
                foreach (Control lbl in gbScreen.Controls)
                {
                    if (lbl is Label)
                    {
                        lbl.ForeColor = Color.FromArgb(250, 250, 250);
                    }
                }
                frmMainMenu mianColor = new frmMainMenu();
                this.btnFilter.BackColor = mianColor.color4;
                this.BackColor = mianColor.color3;

                this.sStrip.BackColor = mianColor.color3;
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
        DataSet ds = null;
        SqlDataAdapter sda = null;
        DBHelper dbHelper = new DBHelper();
 
        /// <summary>
        /// 获取会员等级
        /// </summary>
        public void GetUserLevel()
        {
            try
            {
                ds = new DataSet();
                string sql = "select LevelNo,MembersName,Discount,Enable,DueToTime from MembershipGrade";
                sda = new SqlDataAdapter(sql,dbHelper.Connection);
                sda.Fill(ds,"UserLevel");
                DataRow row = ds.Tables["UserLevel"].NewRow();
                row[0] = -1;
                row[1] = "全部";
                ds.Tables["UserLevel"].Rows.InsertAt(row, 0);
                this.cboUserLevel.DataSource = ds.Tables["UserLevel"];
                this.cboUserLevel.ValueMember = "LevelNo";
                this.cboUserLevel.DisplayMember = "MembersName";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// 获取会员信息
        /// </summary>
        public void GetUserInfo(string querySql)
        {
            try
            {
                ds = new DataSet();
                string sql = string.Format(@"select U.CardNo,U.MemberState, U.Name
                                        ,U.PassWord,U.Wechat,U.Phone,U.Sex
                                        ,U.Birthday,M.MembersName,B.Balance,U.Note
                                        ,U.OpenCardDate,U.DueToTime
                                        from Userinfo as U,MembershipGrade as M ,Balance as B
                                        where U.LevelNo = M.LevelNo and U.CardNo = B.CardNo {0}",querySql);
                sda = new SqlDataAdapter(sql,dbHelper.Connection);
                sda.Fill(ds, "UserInfo");
                this.dgvUserInfo.DataSource = ds.Tables["UserInfo"];
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 获取总会员数
        /// </summary>
        /// <returns>总会员数</returns>
        public int GetTotalToSend()
        {
            return dgvUserInfo.RowCount;
        }

        private void frmUserStatistical_Load(object sender, EventArgs e)
        {
            //获取会员等级
            GetUserLevel();
            //获取会员信息无参调用
            GetUserInfo(string.Empty);

            //获取总会员数给状态栏
            this.tsslTotalMembership.Text = "总会员数：" + Convert.ToString(GetTotalToSend());
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            StringBuilder sbSql = new StringBuilder();
            if (!dtpOpenCardDate.Value.Equals(DateTime.Parse("1999/1/1")))
            {
                sbSql.AppendFormat(" and DATEDIFF(day, U.OpenCardDate , '{0}')=0",this.dtpOpenCardDate.Value);
            }
            if (!cboUserLevel.Text.Trim().Equals("全部"))
            {
                sbSql.AppendFormat(" and U.LevelNo = {0}",this.cboUserLevel.SelectedValue);
            }
            if (!txtBalance.Text.Trim().Equals(string.Empty))
            {
                sbSql.AppendFormat(" and B.Balance>={0}",this.txtBalance.Text.Trim());
            }
            //获取会员信息有参调用
            GetUserInfo(sbSql.ToString());


            //获取总会员数给状态栏
            this.tsslTotalMembership.Text = "总会员数：" + Convert.ToString(GetTotalToSend());
        }

        private void tPreview_Tick(object sender, EventArgs e)
        {
            if (this.dgvUserInfo.RowCount>0)
            {
                this.txtNotePreview.Text = this.dgvUserInfo.SelectedRows[0].Cells[10].Value.ToString();
            }

        }


    }
}
