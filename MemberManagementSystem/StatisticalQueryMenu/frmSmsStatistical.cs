using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MemberManagementSystem.StatisticalQueryMenu
{
    public partial class gbStatisticalFilter : Form
    {
        public gbStatisticalFilter()
        {
            InitializeComponent();
            if (frmLogin.UserLevel == 2)
            {
                groupBox1.ForeColor = Color.FromArgb(250, 250, 250);
                groupBox2.ForeColor = Color.FromArgb(250, 250, 250);
                tsslSendSuccess.ForeColor = Color.FromArgb(250, 250, 250);
                tsslAlwaysSend.ForeColor = Color.FromArgb(250, 250, 250);
                foreach (Control lbl in groupBox1.Controls)
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
                this.dgvSmsInfo.BackgroundColor = mianColor.color3;
                //设置dgv网格线色
                this.dgvSmsInfo.GridColor = mianColor.color2;
                //设置列单元格色
                this.dgvSmsInfo.ColumnHeadersDefaultCellStyle.BackColor = mianColor.color2;
                //设置在被选定时的背景色
                //  this.dgvSmsInfo.ColumnHeadersDefaultCellStyle.SelectionBackColor = mianColor.color3;
                //设置在被选定时的字体色
                // this.dgvSmsInfo.ColumnHeadersDefaultCellStyle.SelectionForeColor = mianColor.color3;
                //设置未选中单元格色
                this.dgvSmsInfo.RowsDefaultCellStyle.BackColor = mianColor.color3;
                //设置选中单元格色
                this.dgvSmsInfo.RowsDefaultCellStyle.SelectionBackColor = mianColor.color4;
                //设置选中字体色
                // this.dgvSmsInfo.RowsDefaultCellStyle.SelectionForeColor = mianColor.color3;
            }
        }

        DBHelper dbHelper = new DBHelper();
        DataSet ds = null;
        SqlDataAdapter sda = null;
        /// <summary>
        /// 获取短信记录
        /// </summary>
        public void GetSmsInfo(string querySql)
        {
            try
            {
                ds = new DataSet();
                string sql = string.Format(@"select s.CardNo,s.Name,s.Phone,s.InDate,s.MessageText,st.TypeName,s.WhetherToSend
                                            from sms as s,SmsType as st
                                            where s.MessageTypeNo = st.MessageTypeNo {0}", querySql);
                sda = new SqlDataAdapter(sql, dbHelper.Connection);
                sda.Fill(ds, "SmsInfo");
                this.dgvSmsInfo.DataSource = ds.Tables["SmsInfo"];
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 获取短信类型
        /// </summary>
        public void GetSmsType()
        {
            try
            {
                ds = new DataSet();
                string sql = "select MessageTypeNo,TypeName from SmsType";
                sda = new SqlDataAdapter(sql, dbHelper.Connection);
                sda.Fill(ds, "SmsType");
                DataRow row = ds.Tables["SmsType"].NewRow();
                row[0] = -1;
                row[1] = "全部";
                ds.Tables["SmsType"].Rows.InsertAt(row, 0);
                this.cboTypeName.DataSource = ds.Tables["SmsType"];
                this.cboTypeName.DisplayMember = "TypeName";
                this.cboTypeName.ValueMember = "MessageTypeNo";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 获取总发送数
        /// </summary>
        /// <returns>总发送数</returns>
        public int GetTotalToSend()
        {
            return dgvSmsInfo.RowCount;
        }


        /// <summary>
        /// 获取发送成功数
        /// </summary>
        /// <returns></returns>
        public int GetRealIncomeSum()
        {
            int sum = 0;
            for (int i = 0; i < dgvSmsInfo.RowCount; i++)
            {
                if (dgvSmsInfo.Rows[i].Cells[6].Value.ToString().Equals("发送成功"))
                {
                    sum += 1;
                }
            }
            return sum;
        }


        private void gbStatisticalFilter_Load(object sender, EventArgs e)
        {
            //无参获取短信记录
            GetSmsInfo(string.Empty);
            //获取短信类型
            GetSmsType();

            //获取总收入给状态栏
            this.tsslAlwaysSend.Text = "总发送：" + Convert.ToString(GetTotalToSend());

            //获取发送成功数给状态栏
            this.tsslSendSuccess.Text = "发送成功：" + Convert.ToString(GetRealIncomeSum());
        }

        /// <summary>
        /// 筛选方法
        /// </summary>
        public void Filter()
        {

            StringBuilder sbSql = new StringBuilder();
            if (!this.txtCardNo.Text.Trim().Equals(string.Empty))
            {
                sbSql.AppendFormat(" and s.CardNo = '{0}'", this.txtCardNo.Text);
            }
            if (!this.txtPhone.Text.Trim().Equals(string.Empty))
            {
                sbSql.AppendFormat(" and s.Phone = '{0}'", this.txtPhone.Text);
            }
            if (!this.txtName.Text.Trim().Equals(string.Empty))
            {
                sbSql.AppendFormat(" and s.Name= '{0}'", this.txtName.Text);
            }
            if (!this.dtpInDate.Value.Equals(DateTime.Parse("1999/1/1")))
            {
                sbSql.AppendFormat(" and DATEDIFF(day, s.InDate , '{0}')=0", this.dtpInDate.Value);
            }
            if (!this.cboTypeName.Text.Equals("全部"))
            {
                sbSql.AppendFormat(" and s.MessageTypeNo = {0}", this.cboTypeName.SelectedValue);
            }

            //有参获取短信记录
            GetSmsInfo(sbSql.ToString());
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //筛选方法
            Filter();
            //获取总收入给状态栏
            this.tsslAlwaysSend.Text = "总发送：" + Convert.ToString(GetTotalToSend());

            //获取发送成功数给状态栏
            this.tsslSendSuccess.Text = "发送成功：" + Convert.ToString(GetRealIncomeSum());
        }

        private void tPreview_Tick(object sender, EventArgs e)
        {
            if (this.dgvSmsInfo.RowCount>0)
            {
                this.txtSendPreview.Text = this.dgvSmsInfo.SelectedRows[0].Cells[4].Value.ToString();
            }
        }
    }
}
