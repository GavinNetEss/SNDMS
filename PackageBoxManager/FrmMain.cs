using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Threading;

namespace SNDMS.PackageBoxManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            // 根据UserInfo显示
            lblName.Text = UserInfo.UserName;
            lblTitle.Text = UserInfo.UserTitle;

            // 如果是麻醉医师，隐藏补药、回收药箱 
            if (UserInfo.UserTitle == "麻醉医师")
            {
                btnRecycle.Visible = false;
                btnReplenish.Visible = false;
            }
            //
        }
        
        //注销
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //注销前，检测所有柜门，是否全部关闭


            //若全部关闭
            this.Close();

            //清空UserInfo
            UserInfo.UserName = "";
            UserInfo.UserTitle = "麻醉医师";
            UserInfo.UserID = "anesthetist";
            
            //登录窗体 TopMost
            Application.OpenForms[0].TopMost = true;
        }

        //常用设置
        private void btnUsualBoxTypeSet_Click(object sender, EventArgs e)
        {
            FrmUsualBoxSet frmSet = new FrmUsualBoxSet();
            //frmSet.Location = new Point(455, 0);
            frmSet.ShowDialog();
        }

        private void btnReplenish_Click(object sender, EventArgs e)
        {
            FrmReplenish frm = new FrmReplenish();
            //frmSet.Location = new Point(455, 0);
            frm.ShowDialog();

        }    
    }
}
