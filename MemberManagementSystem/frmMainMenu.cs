using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;
using FontAwesome.Sharp;
using MemberManagementSystem.Function;
using MemberManagementSystem.StatisticalQueryMenu;
using MemberManagementSystem.SystemSettingsMenu;
using System.Data.SqlClient;
using System.Drawing.Drawing2D;

namespace MemberManagementSystem
{
    public partial class frmMainMenu : Form
    {

        //当前打开的按钮
        private IconButton currentBtn;
        //按钮左边彩虹条按钮
        // private Panel leftBorderBtn;
        //当前打开的子按钮
        private IconButton childCurrentBtn;
        //当前打开的Form
        private Form currentChildForm;


        //构造函数
        public frmMainMenu()
        {
            InitializeComponent();

            if (frmLogin.UserLevel == 2)
            {
                //颜色初始化
                ColorAll();
                TitleButtnColor();
                FontColorAll();
            }

            //定义左边彩虹条按钮
            //  leftBorderBtn = new Panel();
            // int height = this.btnNewUser.Size.Height;
            //设置左边彩虹条尺寸
            // leftBorderBtn.Size = new Size(7, height);
            //左边加入彩虹条按钮
            // pMenu.Controls.Add(leftBorderBtn);

            //Form
            this.Text = string.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;


            //初始化隐藏抽屉
            HideSubMenu();


        }

        /// <summary>
        /// 字体颜色统一
        /// </summary>
        public void FontColorAll()
        {
            lblhora.ForeColor = Color.FromArgb(220, 220, 220);
            lblFecha.ForeColor = Color.FromArgb(220, 220, 220);
            lblTitleChildForm.ForeColor = Color.FromArgb(169, 11, 10);
        }

        //颜色结构体
        private struct RGBColors
        {
            public static Color color1 = Color.FromArgb(172, 126, 241);
            public static Color color2 = Color.FromArgb(249, 118, 176);
            public static Color color3 = Color.FromArgb(253, 138, 114);
            public static Color color4 = Color.FromArgb(95, 77, 221);
            public static Color color5 = Color.FromArgb(24, 161, 251);
        }


        public Color color1 = Color.FromArgb(ColorSetup.Default.R, ColorSetup.Default.G, ColorSetup.Default.B);
        public Color color2 = Color.FromArgb(ColorSetup.Default.R - 5, ColorSetup.Default.G - 5, ColorSetup.Default.B - 6);
        public Color color3 = Color.FromArgb(ColorSetup.Default.R + 3, ColorSetup.Default.G + 3, ColorSetup.Default.B + 6);
        public Color color4 = Color.FromArgb(ColorSetup.Default.R + 10, ColorSetup.Default.G + 10, ColorSetup.Default.B + 20);
        public Color color5 = Color.FromArgb(ColorSetup.Default.R + 9, ColorSetup.Default.G + 9, ColorSetup.Default.B + 15);


//         public Color color1 = Color.FromArgb(ColorSetup.Default.R, ColorSetup.Default.G, ColorSetup.Default.B);
//         public Color color2 = Color.FromArgb(ColorSetup.Default.R, ColorSetup.Default.G, ColorSetup.Default.B);
//         public Color color3 = Color.FromArgb(ColorSetup.Default.R, ColorSetup.Default.G, ColorSetup.Default.B);
//         public Color color4 = Color.FromArgb(ColorSetup.Default.R, ColorSetup.Default.G, ColorSetup.Default.B);
//         public Color color5 = Color.FromArgb(ColorSetup.Default.R, ColorSetup.Default.G, ColorSetup.Default.B);

        public static Color colorsBlack = Color.FromArgb(51, 51, 51);
        public static Color colorsRed = Color.FromArgb(163, 5, 4);
        public static Color colorsWhite = Color.FromArgb(250, 250, 250);
        public static Color colorsDark = Color.FromArgb(61, 61, 61);
        public static Color colorsBlackWhite = Color.FromArgb(61, 61, 61);

        /// <summary>
        /// 顶部按钮颜色
        /// </summary>
        public void TitleButtnColor()
        {
            this.btnTitleUserPay.FlatAppearance.MouseOverBackColor = RGBColors.color1;
            this.btnTitleNewUser.FlatAppearance.MouseOverBackColor = RGBColors.color2;
            this.btnTitleUserConsumption.FlatAppearance.MouseOverBackColor = RGBColors.color3;
            this.btnTitleUserManage.FlatAppearance.MouseOverBackColor = RGBColors.color4;
            this.btnLockScreen.FlatAppearance.MouseOverBackColor = RGBColors.color5;
        }

        //颜色统一
        public void ColorAll()
        {
            this.pLogo.BackColor = color1;
            this.pMenu.BackColor = color1;
            this.btnUserManageMenu.BackColor = color1;
            this.btnStatisticalQueryMenu.BackColor = color1;
            this.btnSystemSettingsMenu.BackColor = color1;
            this.btnExit2.BackColor = color1;
            this.btnHome.BackColor = color1;


            this.btnNewUser.BackColor = color2;
            this.btnUserPay.BackColor = color2;
            this.btnUserManage.BackColor = color2;
            this.btnUserConsumption.BackColor = color2;
            this.btnUserStatistical.BackColor = color2;
            this.btnConsumptionStatistical.BackColor = color2;
            this.btnPayStatistical.BackColor = color2;
            this.btnSmsStatistical.BackColor = color2;
            this.btnConsumptionTypeSetup.BackColor = color2;
            this.btnUserLevelSetup.BackColor = color2;
            this.btnBasicSetup.BackColor = color2;
            this.pDesktop.BackColor = color2;
            this.pTitle.BackColor = color2;
            this.btnExit.BackColor = color2;
            this.btnMaximize.BackColor = color2;
            this.btnMinimize.BackColor = color2;
            this.btnTitleUserConsumption.BackColor = color2;
            this.btnLockScreen.BackColor = color2;
            this.btnTitleNewUser.BackColor = color2;
            this.btnTitleUserPay.BackColor = color2;
            this.btnTitleHome.BackColor = color2;
            this.btnTitleUserManage.BackColor = color2;
            this.pbLogo.BackColor = color3;


            this.pDesktop.BackColor = color3;
        }




        /// <summary>
        /// 按钮单击方法
        /// </summary>
        /// <param name="senderBtn">按钮</param>
        /// <param name="color">颜色</param>
        private void ActivateButton(object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                DisableButton();
                //按钮
                currentBtn = (IconButton)senderBtn;


                if (frmLogin.UserLevel == 2)
                {
                    //高级用户
                    //设置按钮按下的背景色
                    currentBtn.BackColor = color5;
                    //设置当前按钮的前景色
                    currentBtn.ForeColor = color;
                    //设置图标颜色
                    currentBtn.IconColor = color;
                }
                else
                {
                    //普通用户
                    //设置按钮按下的背景色
                    currentBtn.BackColor = colorsRed;
                }


                //设置图标为下图标
                currentBtn.IconChar = IconChar.ChevronDown;


                //显示彩虹条
                //   leftBorderBtn.Visible = true;
                // leftBorderBtn.BringToFront();

            }

        }



        /// <summary>
        /// 按钮被禁用方法
        /// </summary>
        private void DisableButton()
        {
            if (currentBtn != null)
            {

                if (frmLogin.UserLevel == 2)
                {
                    //高级用户
                    //背景色恢复
                    currentBtn.BackColor = Color.FromArgb(ColorSetup.Default.R, ColorSetup.Default.G, ColorSetup.Default.B);
                    //字体颜色恢复
                    currentBtn.ForeColor = Color.Gainsboro;
                    //图标颜色恢复
                    currentBtn.IconColor = Color.Gainsboro;
                }
                else
                {
                    //普通用户
                    currentBtn.BackColor = colorsBlack;
                }

                //图标恢复
                currentBtn.IconChar = IconChar.ChevronLeft;

                //关闭左边彩虹条
                //    leftBorderBtn.Visible = false;

            }
        }


        /// <summary>
        /// 子按钮单击方法
        /// </summary>
        /// <param name="senderBtn">按钮</param>
        /// <param name="color">颜色</param>
        private void ChildActivateButton(Panel pLocation, object senderBtn, Color color)
        {
            if (senderBtn != null)
            {
                ChildDisableButton();

                childCurrentBtn = (IconButton)senderBtn;


                //设置字体加粗
                //                 Font newFont = new Font(childCurrentBtn.Font, FontStyle.Bold);
                //                 childCurrentBtn.Font = newFont;


                if (frmLogin.UserLevel == 2)
                {
                    //高级用户
                    //设置按钮按下的背景色
                    childCurrentBtn.BackColor = color4;
                    //设置当前按钮的前景色
                    childCurrentBtn.ForeColor = color;
                    //设置图标颜色
                    childCurrentBtn.IconColor = color;
                    //修改标题当前颜色
                    lblTitleChildForm.ForeColor = color;
                    //修改标题当前图标颜色
                    iconCurrentChildForm.IconColor = color;

                }
                else
                {
                    //普通用户
                    //设置按钮按下的背景色
                    childCurrentBtn.BackColor = colorsBlackWhite;
                    //设置当前按钮的前景色
                    //childCurrentBtn.ForeColor = colorsRed;
                    //设置图标颜色
                    childCurrentBtn.IconColor = colorsRed;
                }




                //设置当前按钮文本的对齐方式
                childCurrentBtn.TextAlign = ContentAlignment.MiddleLeft;

                //设置图标和字的相对位置
                childCurrentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                //设置图片对齐方式
                childCurrentBtn.ImageAlign = ContentAlignment.MiddleRight;
                childCurrentBtn.FlatAppearance.BorderColor = color;



                //显示边框
                // childCurrentBtn.FlatAppearance.BorderSize = 1;
                //左边彩虹条颜色
                //  leftBorderBtn.BackColor = color;

                //设置左边彩虹条位置
                //   leftBorderBtn.Location = new Point(0, childCurrentBtn.Location.Y + pLocation.Location.Y);

                //显示彩虹条
                //  leftBorderBtn.Visible = true;
                //  leftBorderBtn.BringToFront();

            }

        }




        /// <summary>
        /// 子按钮被禁用方法
        /// </summary>
        private void ChildDisableButton()
        {
            if (childCurrentBtn != null)
            {

                if (frmLogin.UserLevel == 2)
                {
                    //高级用户
                    //背景色恢复
                    childCurrentBtn.BackColor = Color.FromArgb(ColorSetup.Default.R - 5, ColorSetup.Default.G - 5, ColorSetup.Default.B - 6);
                    //字体颜色恢复
                    childCurrentBtn.ForeColor = Color.Gainsboro;
                    //图标颜色恢复
                    childCurrentBtn.IconColor = Color.Gainsboro;

                }
                else
                {
                    //普通用户
                    //背景色恢复
                    childCurrentBtn.BackColor = colorsBlack;
                    //字体颜色恢复
                    //childCurrentBtn.ForeColor = Color.Gainsboro;
                    //图标颜色恢复
                    childCurrentBtn.IconColor = Color.Gainsboro;
                }





                //字体对齐方式恢复
                childCurrentBtn.TextAlign = ContentAlignment.MiddleLeft;
                //图标文本相对位置恢复
                childCurrentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                //图标位置恢复
                childCurrentBtn.ImageAlign = ContentAlignment.MiddleLeft;


                //去掉边框
                // childCurrentBtn.FlatAppearance.BorderSize = 0;
                //关闭左边彩虹条
                //     leftBorderBtn.Visible = false;
            }
        }


        /// <summary>
        /// 嵌入式打开form窗体方法
        /// </summary>
        /// <param name="childForm">窗体</param>
        private void OpenChildForm(Form childForm)
        {
            //当前窗体不等于空
            if (currentChildForm != null)
            {
                //停止扫描
                frmCodeScann.StopScann();
                //只开放形式
                currentChildForm.Close();
            }

            currentChildForm = childForm;
            childForm.TopLevel = false;
            //设置form窗体边框为无边框
            childForm.FormBorderStyle = FormBorderStyle.None;
            //设置form为全部停靠
            childForm.Dock = DockStyle.Fill;
            //将form添加显示到控件
            pDesktop.Controls.Add(childForm);
            //控件数据对象设置为form
            pDesktop.Tag = childForm;
            childForm.BringToFront();
            //显示from
            childForm.Show();
            //修改标题为当前窗体标题
            lblTitleChildForm.Text = childForm.Text;
            //修改图标为当前窗体
            iconCurrentChildForm.IconChar = childCurrentBtn.IconChar;


        }

        //隐藏菜单抽屉
        private void HideSubMenu()
        {
            pUserManageMenu.Visible = false;
            pStatisticalQueryMenu.Visible = false;
            pSystemSettingsMenu.Visible = false;
        }


        bool menu = false;
        //显示或隐藏抽屉
        private void ShowSubMenu(Panel subMenu)
        {

            if (subMenu.Visible == false)
            {
                HideSubMenu();
                subMenu.Visible = true;
                menu = false;
            }
            else
            {
                subMenu.Visible = false;
                menu = true;

            }
        }


        /// <summary>
        /// 重置方法
        /// </summary>
        private void Reset()
        {
            DisableButton();

            iconCurrentChildForm.IconChar = IconChar.Home;
            iconCurrentChildForm.IconColor = Color.FromArgb(169, 11, 10);
            lblTitleChildForm.Text = "首页";
            if (frmLogin.UserLevel == 2)
            {
                lblTitleChildForm.ForeColor = Color.FromArgb(169, 11, 10);
            }
        }

        //logo首页单击事件
        private void btnHome_Click(object sender, EventArgs e)
        {
            //停止扫描
            frmCodeScann.StopScann();
            if (currentChildForm != null)
            {
                currentChildForm.Close();
                Reset();
            }
            HideSubMenu();
            ChildDisableButton();
        }


        //DragForm
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();// 鼠标捕获

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam); // 将消息发送给指定的窗口
        private void pTitleBar_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xF012, 0);
        }

        //退出
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //最大化
        private void btnMaximize_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        //最小化
        private void btnMinimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;

        }
        //左边退出按钮
        private void btnExit2_Click(object sender, EventArgs e)
        {
            //停止扫描
            frmCodeScann.StopScann();
            Application.Exit();

        }


        private void btnUserManageMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pUserManageMenu);

            ActivateButton(sender, RGBColors.color1);
            if (menu)
            {
                DisableButton();
                //   ChildDisableButton();
            }
        }


        private void btnStatisticalQueryMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pStatisticalQueryMenu);
            ActivateButton(sender, RGBColors.color3);
            if (menu)
            {
                DisableButton();
                //  ChildDisableButton();
            }
        }



        private void btnSystemSettingsMenu_Click(object sender, EventArgs e)
        {
            ShowSubMenu(pSystemSettingsMenu);
            ActivateButton(sender, RGBColors.color4);
            if (menu)
            {
                DisableButton();
                //   ChildDisableButton();
            }
        }



        private void btnNewUser_Click(object sender, EventArgs e)
        {
            //子按钮单击方法
            ChildActivateButton(pUserManageMenu, sender, RGBColors.color3);
            //嵌入式打开form窗体方法
            OpenChildForm(new frmNewUser());
        }

        private void btnUserConsumption_Click(object sender, EventArgs e)
        {

            ChildActivateButton(pUserManageMenu, sender, RGBColors.color4);
            OpenChildForm(new frmUserConsumption());

        }

        private void btnUserPay_Click(object sender, EventArgs e)
        {
            ChildActivateButton(pUserManageMenu, sender, RGBColors.color2);
            OpenChildForm(new frmUserPay());
        }

        private void btnUserManage_Click(object sender, EventArgs e)
        {
            ChildActivateButton(pUserManageMenu, sender, RGBColors.color5);
            OpenChildForm(new frmUserManage());
        }

        private void btnUserStatistical_Click(object sender, EventArgs e)
        {
            ChildActivateButton(pStatisticalQueryMenu, sender, RGBColors.color4);
            OpenChildForm(new frmUserStatistical());
        }

        private void btnConsumptionStatistical_Click(object sender, EventArgs e)
        {
            ChildActivateButton(pStatisticalQueryMenu, sender, RGBColors.color5);
            OpenChildForm(new frmConsumptionStatistical());
        }

        private void btnPayStatistical_Click(object sender, EventArgs e)
        {
            ChildActivateButton(pStatisticalQueryMenu, sender, RGBColors.color5);
            OpenChildForm(new frmPayStatistical());
        }

        private void btnSmsStatistical_Click(object sender, EventArgs e)
        {
            ChildActivateButton(pStatisticalQueryMenu, sender, RGBColors.color1);
            OpenChildForm(new gbStatisticalFilter());
        }

        private void btnConsumptionTypeSetup_Click(object sender, EventArgs e)
        {
            ChildActivateButton(pSystemSettingsMenu, sender, RGBColors.color1);
            OpenChildForm(new frmConsumptionTypeSetup());
        }

        private void btnUserLevelSetup_Click(object sender, EventArgs e)
        {
            ChildActivateButton(pSystemSettingsMenu, sender, RGBColors.color3);
            OpenChildForm(new frmUserLevelSetup());
        }

        private void btnBasicSetup_Click(object sender, EventArgs e)
        {
            ChildActivateButton(pSystemSettingsMenu, sender, RGBColors.color5);
            OpenChildForm(new frmBasicSetup());
        }

        //工具栏新建会员
        private void btnTitleNewUser_Click(object sender, EventArgs e)
        {
            pStatisticalQueryMenu.Visible = false;
            pSystemSettingsMenu.Visible = false;
            pUserManageMenu.Visible = true;
            ActivateButton(this.btnUserManageMenu, RGBColors.color1);
            ChildActivateButton(pUserManageMenu, this.btnNewUser, RGBColors.color3);
            OpenChildForm(new frmNewUser());
        }
        //工具栏会员充值
        private void btnTitleUserPay_Click(object sender, EventArgs e)
        {
            pStatisticalQueryMenu.Visible = false;
            pSystemSettingsMenu.Visible = false;
            pUserManageMenu.Visible = true;
            ActivateButton(this.btnUserManageMenu, RGBColors.color1);
            ChildActivateButton(pUserManageMenu, this.btnUserPay, RGBColors.color2);
            OpenChildForm(new frmUserPay());
        }
        //工具栏会员消费
        private void btnTitleUserConsumption_Click(object sender, EventArgs e)
        {
            pStatisticalQueryMenu.Visible = false;
            pSystemSettingsMenu.Visible = false;
            pUserManageMenu.Visible = true;
            ActivateButton(this.btnUserManageMenu, RGBColors.color1);
            ChildActivateButton(pUserManageMenu, this.btnUserConsumption, RGBColors.color4);
            OpenChildForm(new frmUserConsumption());
        }
        //工具栏会员管理
        private void btnTitleUserManage_Click(object sender, EventArgs e)
        {
            pStatisticalQueryMenu.Visible = false;
            pSystemSettingsMenu.Visible = false;
            pUserManageMenu.Visible = true;
            ActivateButton(this.btnUserManageMenu, RGBColors.color1);
            ChildActivateButton(pUserManageMenu, this.btnUserManage, RGBColors.color5);
            OpenChildForm(new frmUserManage());
        }





        /// <summary>
        /// 到期用户修改为锁定
        /// </summary>
        public void UserDueTo()
        {

            DBHelper dbHelper = new DBHelper();
            try
            {
                dbHelper.OpenConnection();

                string sql = string.Format(@"update UserInfo 
                                            set MemberState = '锁定' 
                                            where DueToTime>'2000-01-01' and  DATEDIFF(DD,GETDATE(),DueToTime)<=0 and  MemberState = '正常'");
                SqlCommand cmd = new SqlCommand(sql, dbHelper.Connection);
                cmd.ExecuteNonQuery();


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

        private void iconCurrentChildForm_Click(object sender, EventArgs e)
        {

        }



        private void lblTitleChildForm_Click(object sender, EventArgs e)
        {

        }

        private void tUserDueTo_Tick(object sender, EventArgs e)
        {
            //到期用户修改为锁定
            UserDueTo();
        }


        private void btnLockScreen_Click(object sender, EventArgs e)
        {
            frmLockScreen frmLoce = new frmLockScreen();
            frmLoce.ShowDialog();
        }

        private void frmMainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void tDate_Tick(object sender, EventArgs e)
        {
            lblhora.Text = DateTime.Now.ToString("hh:mm:ss ");
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void frmMainMenu_Load(object sender, EventArgs e)
        {

        }











    }
}
