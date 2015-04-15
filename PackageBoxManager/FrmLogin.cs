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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //连接数据库验证用户名、密码，返回用户信息

            UserInfo.UserName = "郭晓蕾";
            UserInfo.UserTitle = "专职药师";
            UserInfo.UserID = "0";


            //清空输入区
            txtUser.Text = "";
            txtPsw.Text = "";
            gbKeyBoard.Visible = false;

            //打开FrmMain
            this.TopMost = false;

            FrmMain frm = new FrmMain();
            frm.TopMost = true;
            frm.Show();
        }
        

        private void lblLog_Click(object sender, EventArgs e)
        {
        }


        #region  登录
        
        private TextBox txtBoxAcctive;
        private void btnKeyBoard_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            txtBoxAcctive.Text = txtBoxAcctive.Text + btn.Text;
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtBoxAcctive = txtUser;
            gbKeyBoard.Visible = true;
        }

        private void txtPsw_Enter(object sender, EventArgs e)
        {
            txtBoxAcctive = txtPsw;
            gbKeyBoard.Visible = true;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Focus();
            txtUser.Text = "";
            txtPsw.Text = "";
        }

        #endregion

        private void pnlLogout_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

     
    }
}
