using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace SNDMS.PackageBoxManager
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        FrmLogin MainFrom;

        public Login(FrmLogin f)
        {
            InitializeComponent();
        }
        private TextBox txtBoxAcctive;

        private void btnLogin_Click(object sender, EventArgs e)
        {
            bool boolLogin = UserLogin();
             if (boolLogin == true)
             {
                 this.Close();
             }              
        }

      private  bool UserLogin()
        {
            //
            return true;           
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Login_Load(object sender, EventArgs e)
        {
            txtUser.Focus();
            txtBoxAcctive = txtUser;
        }

        private void btnKeyBoard_Click(object sender, EventArgs e)
        {
            
            Button btn = sender as Button;

            txtBoxAcctive.Text = txtBoxAcctive.Text + btn.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtUser.Focus();
            txtUser.Text = "";
            txtPsw.Text = "";
        }

        private void txtUser_Enter(object sender, EventArgs e)
        {
            txtBoxAcctive = txtUser;          
        }

        private void txtPsw_Enter(object sender, EventArgs e)
        {
            txtBoxAcctive = txtPsw;
        }
    }
}
