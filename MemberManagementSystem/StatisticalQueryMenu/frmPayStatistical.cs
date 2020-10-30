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
    public partial class frmPayStatistical : Form
    {
        public frmPayStatistical()
        {
            InitializeComponent();
            if (frmLogin.UserLevel == 2)
            {
                gbScreeningStatistical.ForeColor = Color.FromArgb(250, 250, 250);
                this.tsslTotalRevenue.ForeColor = Color.FromArgb(250, 250, 250);
                this.tsslRealIncome.ForeColor = Color.FromArgb(250, 250, 250);
                foreach (Control lbl in gbScreeningStatistical.Controls)
                {
                    if (lbl is Label)
                    {
                        lbl.ForeColor = Color.FromArgb(250, 250, 250);
                    }
                }

                frmMainMenu mianColor = new frmMainMenu();
                this.btnFilter.BackColor = mianColor.color4;


                this.sStrip.BackColor = mianColor.color3;
                this.BackColor = mianColor.color3;
                this.sStrip.BackColor = mianColor.color3;
                //设置dgv背景色
                this.dgvPayStatisticalInfo.BackgroundColor = mianColor.color3;
                //设置dgv网格线色
                this.dgvPayStatisticalInfo.GridColor = mianColor.color2;
                //设置列单元格色
                this.dgvPayStatisticalInfo.ColumnHeadersDefaultCellStyle.BackColor = mianColor.color2;
                //设置在被选定时的背景色
                //  this.dgvPayStatisticalInfo.ColumnHeadersDefaultCellStyle.SelectionBackColor = mianColor.color3;
                //设置在被选定时的字体色
                // this.dgvPayStatisticalInfo.ColumnHeadersDefaultCellStyle.SelectionForeColor = mianColor.color3;
                //设置未选中单元格色
                this.dgvPayStatisticalInfo.RowsDefaultCellStyle.BackColor = mianColor.color3;
                //设置选中单元格色
                this.dgvPayStatisticalInfo.RowsDefaultCellStyle.SelectionBackColor = mianColor.color4;
                //设置选中字体色
                // this.dgvPayStatisticalInfo.RowsDefaultCellStyle.SelectionForeColor = mianColor.color3;
            }

        }

        DBHelper dbHelper = new DBHelper();
        DataSet ds = null;
        SqlDataAdapter sda = null;
        /// <summary>
        /// 获取充值订单
        /// </summary>
        public void GetPay(string querySql)
        {

            try
            {
                ds = new DataSet();
                string sql = string.Format(@"select R.CardNo  ,R.Name ,R.PaymentName,R.Credit ,R.ActualMoney ,R.CreDate ,M.TypeName 
                            from Recharge as R,MethodPayment as M
                            where R.MethodPaymentNo = M.MethodPaymentNo {0}", querySql);
                sda = new SqlDataAdapter(sql,dbHelper.Connection);
                sda.Fill(ds,"Pay");
                this.dgvPayStatisticalInfo.DataSource = ds.Tables["Pay"];
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 获取支付方式
        /// </summary>
        public void GetMethodPayment()
        {
            try
            {
                ds = new DataSet();
                string sql = "select MethodPaymentNo,TypeName from MethodPayment";
                sda = new SqlDataAdapter(sql,dbHelper.Connection);
                sda.Fill(ds, "MethodPayment");
                DataRow row = ds.Tables["MethodPayment"].NewRow();
                row[0] = -1;
                row[1] = "全部";
                ds.Tables["MethodPayment"].Rows.InsertAt(row, 0);
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
        /// 获取充值总收入
        /// </summary>
        public double GetConsumptionSum()
        {
            double sum = 0;
            for (int i = 0; i < dgvPayStatisticalInfo.RowCount; i++)
            {
                sum += Convert.ToDouble(dgvPayStatisticalInfo.Rows[i].Cells[3].Value);
            }
            return sum;
        }

        /// <summary>
        /// 获取实际总收入
        /// </summary>
        /// <returns>实际总收入</returns>
        public double GetRealIncomeSum()
        {
            double sum = 0;
            for (int i = 0; i < dgvPayStatisticalInfo.RowCount; i++)
            {
                sum += Convert.ToDouble(dgvPayStatisticalInfo.Rows[i].Cells[4].Value);
            }
            return sum;
        }


        private void frmPayStatistical_Load(object sender, EventArgs e)
        {


            //无参获取充值订单
            GetPay(string.Empty);

            //获取总收入给状态
            this.tsslTotalRevenue.Text = "总收入：" + Convert.ToString(GetConsumptionSum());

            //获取实际总收入给状态
            this.tsslRealIncome.Text = "总实际收入：" + Convert.ToString(GetRealIncomeSum());

            //获取支付方式
            GetMethodPayment();
        }

        /// <summary>
        /// 筛选方法
        /// </summary>
        public void Filter()
        {
            StringBuilder sbSql = new StringBuilder();
            if (!this.txtCardNo.Text.Trim().Equals(string.Empty))
            {
                sbSql.AppendFormat(" and R.CardNo = '{0}'",this.txtCardNo.Text);
            }
            if (!this.txtName.Text.Trim().Equals(string.Empty))
            {
                sbSql.AppendFormat(" and R.Name = '{0}'",this.txtName.Text);
            }
            if (!this.txtTopupAmount.Text.Equals(string.Empty))
            {
                sbSql.AppendFormat("  and R.Credit >= {0}",this.txtTopupAmount.Text);
            }
            if (!this.txtPaidinAmount.Text.Equals(string.Empty))
            {
                sbSql.AppendFormat(" and r.ActualMoney >= {0}",this.txtPaidinAmount.Text);
            }
            if (!this.cboMethodPayment.Text.Equals("全部"))
            {
                sbSql.AppendFormat(" and M.MethodPaymentNo = {0}",this.cboMethodPayment.SelectedValue);
            }
            if (!this.dtpTopupDate.Value.Equals(DateTime.Parse("1999/1/1")))
            {
                sbSql.AppendFormat(" and DATEDIFF(day, R.CreDate , '{0}')=0",this.dtpTopupDate.Value);
            }
            if (!this.txtPaymentName.Text.Trim().Equals(string.Empty))
            {
                sbSql.AppendFormat(" and R.PaymentName='{0}'", this.txtPaymentName.Text);
            }

            //有参获取充值订单
            GetPay(sbSql.ToString());
        }

        private void btnFilter_Click(object sender, EventArgs e)
        {
            //筛选方法
            Filter();

            //获取总收入给状态
            this.tsslTotalRevenue.Text = "总收入：" + Convert.ToString(GetConsumptionSum());

            //获取实际总收入给状态
            this.tsslRealIncome.Text = "总实际收入：" + Convert.ToString(GetRealIncomeSum());
        }
    }
}
