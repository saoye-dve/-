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
    public partial class frmConsumptionStatistical : Form
    {
        public frmConsumptionStatistical()
        {
            InitializeComponent();
            if (frmLogin.UserLevel == 2)
            {
                gbStatisticalFilter.ForeColor = Color.FromArgb(250, 250, 250);
                this.tsslTotalRevenue.ForeColor = Color.FromArgb(250, 250, 250);
                this.tsslRealIncome.ForeColor = Color.FromArgb(250, 250, 250);
                foreach (Control lbl in gbStatisticalFilter.Controls)
                {
                    if (lbl is Label)
                    {
                        lbl.ForeColor = Color.FromArgb(250, 250, 250);
                    }
                }
                frmMainMenu mianColor = new frmMainMenu();
                this.btnFilter.BackColor = mianColor.color4;

                //   高级用户
                this.BackColor = mianColor.color3;
                //设置dgv背景色
                this.dgvConsumptionInfo.BackgroundColor = mianColor.color3;

                this.sStrip.BackColor = mianColor.color3;
                //设置dgv网格线色
                this.dgvConsumptionInfo.GridColor = mianColor.color2;
                //设置列单元格色
                this.dgvConsumptionInfo.ColumnHeadersDefaultCellStyle.BackColor = mianColor.color2;
                //设置在被选定时的背景色
                //  this.dgvConsumptionInfo.ColumnHeadersDefaultCellStyle.SelectionBackColor = mianColor.color3;
                //设置在被选定时的字体色
                // this.dgvConsumptionInfo.ColumnHeadersDefaultCellStyle.SelectionForeColor = mianColor.color3;
                //设置未选中单元格色
                this.dgvConsumptionInfo.RowsDefaultCellStyle.BackColor = mianColor.color3;
                //设置选中单元格色
                this.dgvConsumptionInfo.RowsDefaultCellStyle.SelectionBackColor = mianColor.color4;
                //设置选中字体色
                // this.dgvConsumptionInfo.RowsDefaultCellStyle.SelectionForeColor = mianColor.color3;
            }

        }

        DBHelper dbHelper = new DBHelper();
        DataSet ds = null;
        SqlDataAdapter sda = null;
        /// <summary>
        /// 获取消费订单
        /// </summary>
        public void GetConsumption(string querySql)
        {
            try
            {
                ds = new DataSet();
                string sql = string.Format(@"select o.CardNo,o.Name,cp.TypeName
                                ,M.TypeName,ct.TypeName
                                ,o.ConsumptionMoney,o.ActualMoney ,o.DateConsumption ,o.Note 
                                from Orders as o,ConsumptionPatterns as cp,MethodPayment as M,ConsumptionType as ct
                                where o.ConsumptionPatternsNo = cp.ConsumptionPatternsNo and o.MethodPaymentNo = M.MethodPaymentNo
                                and o.ConsumptionTypeNo  = ct.ConsumptionTypeNo {0}", querySql);
                sda = new SqlDataAdapter(sql, dbHelper.Connection);
                sda.Fill(ds, "Consumption");
                this.dgvConsumptionInfo.DataSource = ds.Tables["Consumption"];
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
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
                DataRow row = ds.Tables["ConsumptionType"].NewRow();
                row[0] = -1;
                row[1] = "全部";
                ds.Tables["ConsumptionType"].Rows.InsertAt(row, 0);
                this.cboConsumptionType.DataSource = ds.Tables["ConsumptionType"];
                this.cboConsumptionType.DisplayMember = "TypeName";
                this.cboConsumptionType.ValueMember = "ConsumptionTypeNo";
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
                sda = new SqlDataAdapter(sql, dbHelper.Connection);
                sda.Fill(ds, "MethodPayment");
                DataRow row = ds.Tables["MethodPayment"].NewRow();
                row[0] = -1;
                row[1] = "全部";
                ds.Tables["MethodPayment"].Rows.InsertAt(row, 0);
                this.cboMethodPayment.DataSource = ds.Tables["MethodPayment"];
                this.cboMethodPayment.DisplayMember = "TypeName";
                this.cboMethodPayment.ValueMember = "MethodPaymentNo";
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

        }

        /// <summary>
        /// 获取消费方式
        /// </summary>
        public void GetConsumptionPatterns()
        {
            try
            {
                ds = new DataSet();
                string sql = "select ConsumptionPatternsNo,TypeName from ConsumptionPatterns";
                sda = new SqlDataAdapter(sql, dbHelper.Connection);
                sda.Fill(ds, "ConsumptionPatterns");
                DataRow row = ds.Tables["ConsumptionPatterns"].NewRow();
                row[0] = -1;
                row[1] = "全部";
                ds.Tables["ConsumptionPatterns"].Rows.InsertAt(row, 0);
                this.cboConsumptionPatterns.DataSource = ds.Tables["ConsumptionPatterns"];
                this.cboConsumptionPatterns.DisplayMember = "TypeName";
                this.cboConsumptionPatterns.ValueMember = "ConsumptionPatternsNo";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// 获取总收入
        /// </summary>
        public double GetConsumptionSum()
        {
            double sum = 0;
            for (int i = 0; i < dgvConsumptionInfo.RowCount; i++)
            {
                sum += Convert.ToDouble(dgvConsumptionInfo.Rows[i].Cells[5].Value);
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
            for (int i = 0; i < dgvConsumptionInfo.RowCount; i++)
            {
                sum += Convert.ToDouble(dgvConsumptionInfo.Rows[i].Cells[6].Value);
            }
            return sum;
        }




        private void frmConsumptionStatistical_Load(object sender, EventArgs e)
        {
            //获取消费订单无参
            GetConsumption(string.Empty);

            //获取总收入给状态
            this.tsslTotalRevenue.Text = "总收入：" + Convert.ToString(GetConsumptionSum());

            //获取实际总收入给状态
            this.tsslRealIncome.Text = "总实际收入：" + Convert.ToString(GetRealIncomeSum());

            //获取消费类型
            GetConsumptionType();

            //获取支付方式
            GetMethodPayment();

            //获取消费方式
            GetConsumptionPatterns();
        }


        /// <summary>
        /// 筛选方法
        /// </summary>
        public void Filter()
        {
            StringBuilder sbSql = new StringBuilder();
            if (!this.txtCardNo.Text.Trim().Equals(string.Empty))
            {
                sbSql.AppendFormat(" and o.CardNo = '{0}'", this.txtCardNo.Text);
            }
            if (!this.txtName.Text.Trim().Equals(string.Empty))
            {
                sbSql.AppendFormat(" and o.Name = '{0}'", this.txtName.Text);
            }
            if (!this.dtpDateConsumption.Value.Equals(DateTime.Parse("1999/1/1")))
            {
                sbSql.AppendFormat("  and DATEDIFF(day, o.DateConsumption , '{0}')=0", this.dtpDateConsumption.Value);
            }
            if (!this.txtConsumptionAmount.Text.Trim().Equals(string.Empty))
            {
                sbSql.AppendFormat(" and o.ConsumptionMoney >= {0}", this.txtConsumptionAmount.Text);
            }
            if (!this.txtPaidinAmount.Text.Trim().Equals(string.Empty))
            {
                sbSql.AppendFormat(" and o.ActualMoney >=  {0}", this.txtPaidinAmount.Text);
            }
            if (!this.cboConsumptionPatterns.Text.Equals("全部"))
            {
                sbSql.AppendFormat(" and o.ConsumptionPatternsNo = {0}", this.cboConsumptionPatterns.SelectedValue);
            }
            if (!this.cboConsumptionType.Text.Equals("全部"))
            {
                sbSql.AppendFormat(" and o.ConsumptionTypeNo = {0}", this.cboConsumptionType.SelectedValue);
            }
            if (!this.cboMethodPayment.Text.Equals("全部"))
            {
                sbSql.AppendFormat(" and o.MethodPaymentNo = {0}", this.cboMethodPayment.SelectedValue);
            }

            //有参获取消费订单
            GetConsumption(sbSql.ToString());
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
