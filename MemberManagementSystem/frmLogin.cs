using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net;
using System.Text;
using System.Runtime.InteropServices;

namespace MemberManagementSystem
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        string str = "Data Source=.;Initial Catalog=MemberUserDB;Integrated Security=True";
        SqlConnection conn = null;
        SqlCommand cmd = null;

        /// <summary>
        /// 获取提取IP位置
        /// </summary>
        /// <param name="Content"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        /// <returns></returns>
        public static string GetStr(string Content, string start, string end)
        {
            var posStart = Content.IndexOf(start);
            var posEnd = Content.IndexOf(end);
            return Content.Substring(posStart, (posEnd - posStart + end.Length));
        }

        public static int UserLevel;
        SqlDataReader reader = null;
        /// <summary>
        /// 获取用户等级
        /// </summary>
        public void GetUserLevel()
        {
            conn = new SqlConnection(str);

            try
            {
                conn.Open();
                string sql = string.Format(@"select LevelType
                from[MemberUserDB].[dbo].[User]
                where UserNo = '{0}' and PassWord = '{1}'", this.txtUserNo.Text, this.txtPwd.Text);
                cmd = new SqlCommand(sql, conn);
                reader = cmd.ExecuteReader();
                while (reader.Read())
                {
                    UserLevel = Convert.ToInt32(reader[0]);
                }
         
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                reader.Close();
                conn.Close();
            }
        }

        /// <summary>
        /// 登录
        /// </summary>
        public void Login()
        {
            conn = new SqlConnection(str);
            try
            {
                conn.Open();
                string sql = string.Format(@"select COUNT(UserNo)
                  from[MemberUserDB].[dbo].[User]
                  where UserNo = '{0}' and PassWord = '{1}' and State='正常'", this.txtUserNo.Text, this.txtPwd.Text);
                cmd = new SqlCommand(sql, conn);
                int iRet = Convert.ToInt32(cmd.ExecuteScalar());
                if (iRet > 0)
                {
                    //添加登录记录
                    AddLoginLog();
                    this.Hide();
                    frmMainMenu frmMain = new frmMainMenu();
                    frmMain.ShowDialog(this);
                }
                else
                {
                    MessageBox.Show("账号或密码错误!", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        /// <summary>
        /// 添加登录记录
        /// </summary>
        public void AddLoginLog()
        {
            WebClient MyWebClient = new WebClient();
            MyWebClient.Credentials = CredentialCache.DefaultCredentials;//获取或设置用于向Internet资源的请求进行身份验证的网络凭据
            Byte[] pageData = MyWebClient.DownloadData("http://www.net.cn/static/customercare/yourip.asp"); //从指定网站下载数据
            string pageHtml = Encoding.Default.GetString(pageData);  //如果获取网站页面采用的是GB2312，则使用这句
            string s = GetStr(pageHtml, "<h2>", "</h2>");
            string IpAddress = s.Substring(s.IndexOf('>') + 1, s.Length - 9);


            conn = new SqlConnection(str);
            try
            {
                conn.Open();
                string sql = string.Format(@"  insert [MemberUserDB].[dbo].[LoginLog]
                                          values ('{0}','{1}','{2}','{3}')",
                                            this.txtUserNo.Text, Dns.GetHostName(), DateTime.Now, IpAddress);
                cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();
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


        private void btnLogin_Click(object sender, EventArgs e)
        {
            //获取用户等级
            GetUserLevel();
            //登录
            Login();
  
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void llblForgotPassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string url = "http://wpa.qq.com/msgrd?v=3&uin=" + "2693451077" + "&site=qq&menu=yes";
            System.Diagnostics.Process.Start(url);
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


        /// <summary>
        /// 登录账户密码读取
        /// </summary>
        public void LoginConfigRead()
        {
            this.txtUserNo.Text = MyLogin.Default.UserNo;
            this.txtPwd.Text = MyLogin.Default.PassWord;
            this.cbRememb.Checked = MyLogin.Default.Rememb;

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            //登录账户密码读取
            LoginConfigRead();
        }

        /// <summary>
        /// 登录账户密码保存
        /// </summary>
        public void LoginConfigSave()
        {
            if (cbRememb.Checked == true)
            {
                MyLogin.Default.UserNo = this.txtUserNo.Text;
                MyLogin.Default.PassWord = this.txtPwd.Text;
                MyLogin.Default.Rememb = this.cbRememb.Checked;
                MyLogin.Default.Save();
            }
            else
            {
                MyLogin.Default.UserNo = string.Empty;
                MyLogin.Default.PassWord = string.Empty;
                MyLogin.Default.Rememb = false;
                MyLogin.Default.Save();
            }
        }



        private void frmLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            //登录账户密码保存
            LoginConfigSave();
            //停止扫描
            frmCodeScann.StopScann();
        }



    }
}
