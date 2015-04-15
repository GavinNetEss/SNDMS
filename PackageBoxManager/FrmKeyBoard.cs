using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Drawing.Drawing2D;

namespace DrugMgrCabinet
{
    public partial class FrmKeyBoard : Form
    {
        public FrmKeyBoard()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmKeyBoard_Load(object sender, EventArgs e)
        {
            int num = gbKeyBoard.Controls.Count;

            for (int i = 0; i < num-2;i++ )
            {
                gbKeyBoard.Controls[i].Click += btnCommon_Click; 
            }
        }

        private void gbKeyBoard_Enter(object sender, EventArgs e)
        {
            this.button1.Click += btnCommon_Click;
            this.button10.Click += btnCommon_Click; 
        }


        private void AttachThreadInput(bool b)
        {
            //设置线程亲和,附到前台窗口所在线程,只有在线程内才可以获取线程内控件的焦点
            //线程亲和: AttachThreadInput(目标线程标识, 当前线程标识, 非零值关联) 零表示取消
            //窗口所在的线程的标识: GetWindowThreadProcessId(窗体句柄, 这里返回进程标识)
            //当前的前台窗口的句柄: GetForegroundWindow()
            //当前程序所在的线程标识: GetCurrentThreadId()
            Win32API.AttachThreadInput(
                   Win32API.GetWindowThreadProcessId(
                            Win32API.GetForegroundWindow(), 0),
                   Win32API.GetCurrentThreadId(), Convert.ToInt32(b));
        }

        private void btnCommon_Click(object o, EventArgs e)
        {
            AttachThreadInput(true); //设置线程亲和的关联
            int getFocus = Win32API.GetFocus();
            //o为object类型,使用强制转换成vkButton
            char keyvalue = ((Button)o).Text.ToCharArray()[0];
            //向前台窗口发送按键消息
            Win32API.PostMessage(getFocus, Win32API.WM_KEYDOWN, (byte)keyvalue, 0);
            AttachThreadInput(false); //取消线程亲和的关联
        }

        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            //若在窗体上产生鼠标点击事件的消息则使消息返回值标记为不激活
            //程序内部的窗口切换仅需返回 MA_NOACTIVATE 即可,若相对其它
            //的程序窗口切换时 还需要设置 WS_EX_NOACTIVATE 样式
            if (m.Msg == Win32API.WM_MOUSEACTIVATE)
                m.Result = (IntPtr)Win32API.MA_NOACTIVATE;
            //MA_ACTIVATE 激活窗体，但不删除鼠标消息。
            //MA_NOACTIVATE 不激活窗体，也不删除鼠标消息。
            //MA_ACTIVATEANDEAT 激活窗体，删除鼠标消息。
            //MA_NOACTIVATEANDEAT 不激活窗体，但删除鼠标消息。

        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                //为窗体样式添加不激活标识
                cp.ExStyle = Win32API.WS_EX_NOACTIVATE;
                return cp;
            }
        }
       
    }



    public static class Win32API
    {
        [DllImport("user32.dll", EntryPoint = "SendMessageW")]
        public static extern int SendMessage(
             int hwnd,
             int wMsg,
             int wParam,
             int lParam);


        [DllImport("user32.dll", EntryPoint = "PostMessageW")]
        public static extern int PostMessage(
             int hwnd,
             int wMsg,
             int wParam,
             int lParam);


        [DllImport("user32.dll")]
        public static extern int GetForegroundWindow();


        [DllImport("user32.dll")]
        public static extern int GetFocus();


        [DllImport("user32.dll")]
        public static extern int AttachThreadInput(
             int idAttach,
             int idAttachTo,
             int fAttach);


        [DllImport("user32.dll")]
        public static extern int GetWindowThreadProcessId(
             int hwnd,
             int lpdwProcessId);


        [DllImport("kernel32.dll")]
        public static extern int GetCurrentThreadId();


        public const int WM_MOUSEACTIVATE = 0x21;
        public const int WM_KEYDOWN = 0x100;
        public const int MA_NOACTIVATE = 3;
        public const int WS_EX_NOACTIVATE = 0x8000000;
    }

}
