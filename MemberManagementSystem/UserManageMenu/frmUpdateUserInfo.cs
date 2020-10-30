using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Runtime.InteropServices;

namespace MemberManagementSystem.UserManageMenu
{
    public partial class frmUpdateUserInfo : Form
    {
        public frmUpdateUserInfo()
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

        public string cardNo = string.Empty;
        string str = "Data Source=.;Initial Catalog=MemberManagementDB;Integrated Security=True";
        SqlConnection conn = null;
        string state = string.Empty;
        string name = string.Empty;
        string pwd = string.Empty;
        string wechat = string.Empty;
        string phone = string.Empty;
        string sex = string.Empty;
        DateTime birthday;
        int LevelNo = 0;
        string note = string.Empty;
        DateTime dueToDate;

        /// <summary>
        /// 获取会员信息
        /// </summary>
        public void GetUserInfo()
        {
            conn = new SqlConnection(str);
            SqlDataReader reader = null;
            try
            {
                conn.Open();
                string sql = string.Format(@"select U.MemberState, U.Name
                                            ,U.PassWord,U.Wechat,U.Phone,U.Sex
                                            ,U.Birthday,U.LevelNo,U.Note,U.DueToTime
                                            from Userinfo as U
                                            where U.CardNo ='{0}'", this.cardNo);
                SqlCommand cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    state = reader[0].ToString();
                    name = reader[1].ToString();
                    pwd = reader[2].ToString();
                    wechat = reader[3].ToString();
                    phone = reader[4].ToString();
                    sex = reader[5].ToString();
                    birthday = Convert.ToDateTime(reader[6]);
                    LevelNo = Convert.ToInt32(reader[7].ToString());
                    note = reader[8].ToString();
                    dueToDate = Convert.ToDateTime(reader[9]);


                    this.txtCardNo.Text = this.cardNo;



                    if (state.Trim().Equals("正常"))
                    {
                        this.rbNormal.Checked = true;
                    }
                    else
                    {
                        this.rbLock.Checked = true;
                    }
                    this.txtName.Text = name;
                    this.txtPwd.Text = pwd;
                    this.txtWechat.Text = wechat;
                    this.txtPhone.Text = phone;
                    if (sex.Trim().Equals("男"))
                    {
                        this.rbMale.Checked = true;
                    }
                    else
                    {
                        this.rbShe.Checked = true;
                    }

                    this.dtpBirthday.Value = birthday;
                    this.cboUserLevel.SelectedIndex = LevelNo - 1;
                    this.txtNote.Text = note;
                    this.dtpDueToTime.Value = dueToDate;
                }
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }




        DataSet ds = null;
        SqlDataAdapter sda = null;
        /// <summary>
        /// 获取会员等级
        /// </summary>
        public void GetUserLevel()
        {
            conn = new SqlConnection(str);
            try
            {
                ds = new DataSet();
                string sql = string.Format("select LevelNo,MembersName from MembershipGrade");
                sda = new SqlDataAdapter(sql, conn);
                sda.Fill(ds, "Level");
                this.cboUserLevel.DataSource = ds.Tables["Level"];
                this.cboUserLevel.DisplayMember = "MembersName";
                this.cboUserLevel.ValueMember = "LevelNo";

            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmUpdateUserInfo_Load(object sender, EventArgs e)
        {
            //调用获取会员等级
            GetUserLevel();
            //调用获取会员信息
            GetUserInfo();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 修改会员信息
        /// </summary>
        public void UpdateUserInfo()
        {
            conn = new SqlConnection(str);
            try
            {
                conn.Open();

                if (this.rbNormal.Checked)
                {
                    state = "正常";
                }
                else
                {
                    state = "锁定";
                }
                name = this.txtName.Text;
                pwd = this.txtPwd.Text;
                wechat = this.txtWechat.Text;
                phone = this.txtPhone.Text;
                if (this.rbMale.Checked)
                {
                    sex = "男";
                }
                else
                {
                    sex = "女";
                }
                birthday = this.dtpBirthday.Value;
                LevelNo = Convert.ToInt32(this.cboUserLevel.SelectedValue);
                note = this.txtNote.Text;
                dueToDate = this.dtpDueToTime.Value;
                string sql = string.Format(@"update UserInfo
                                            set MemberState = '{0}',Name = '{1}',PassWord = '{2}',Wechat = '{3}',Phone = '{4}'
                                            ,Sex = '{5}',Birthday = '{6}',LevelNo = {7},Note = '{8}',DueToTime = '{9}'
                                            where CardNo = '{10}'", state, name, pwd, wechat, phone, sex, birthday, LevelNo, note, dueToDate, cardNo);
                SqlCommand cmd = new SqlCommand(sql, conn);
                int iRet = cmd.ExecuteNonQuery();
                if (iRet > 0)
                {
                    MessageBox.Show("修改成功！", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    //frmUserManage frmUser = new frmUserManage();
                    //frmUser.GetUserInfo(null);
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
                conn.Close();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //调用修改会员信息
            UpdateUserInfo();
            this.Close();
        }

        private void TDate_Tick(object sender, EventArgs e)
        {
            if (this.dtpDueToTime.Value > DateTime.Parse("2000/01/01"))
            {
                //时间如果大于现在的时间
                if (this.dtpDueToTime.Value > DateTime.Today)
                {
                    this.rbNormal.Checked = true;
                }
                else
                {
                    this.rbLock.Checked = true;
                }
            }

        }

        //DragForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();// 鼠标捕获

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void pTitle_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xF012, 0);
        }
    }
}
