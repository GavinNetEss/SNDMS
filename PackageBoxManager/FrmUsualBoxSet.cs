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
    public partial class FrmUsualBoxSet : Form
    {
        public FrmUsualBoxSet()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //从数据库加载药箱类别，动态生成添加在界面上

            //button1.Click += TypeSelected;
            //button2.Click += TypeSelected;
            //button4.Click += TypeSelected;
            //button5.Click += TypeSelected;
            

            //根据UserInfo ，把此人的常用药箱蓝色显示

            //药箱类别== UserInfo常用药箱
            //btnTyepe.BackgroundColor = Bule；
            //lblSelectedType.Text=btnTyepe.Text;
        }
        
        //药箱类别选择
        private void TypeSelected(object sender, EventArgs e)
        {
            //Button btnType = sender as Button;
            //lblSelectedType.Text = btnType.Text;


            //更新数据库表 StaffMostUsed
        }


        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
       
    }
}
