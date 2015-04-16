using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Text;
using System.Windows.Forms;
using System.Threading;
using ESS.COMM;

namespace ESS
{
    public partial class InputMethodFrm : Form
    {
        #region 变量
        public static readonly string INPUT_CODE_DICT = "INPUT_CODE_DICT";    // 输入法字典名称
   
        public    ItemInputed ItemSelected  = null;                     // 项目选择事件
        
        private readonly int frmHeight      = 337;                      // 默认高度
        
        protected Control _textBox          = null;                     // 当前文本框
        
        protected string _dictName          = string.Empty;             // 字典名称
        protected string _itemId            = string.Empty;             // 选择的项目ID
        protected string _itemName          = string.Empty;             // 选中的项目名称
        protected bool   _autoLoaded        = false;                    // 后台加载的数据加载完成
        
        private Mutex    _locker            = new Mutex();              // 锁
        
       // private DbInfo SqlHelper       = null;                     // 数据接口
        private DataSet  dsDictItem         = null;                     // 字典项目
        private DataSet  dsData             = new DataSet();            // 存储数据
        private Hashtable arrFilter         = new Hashtable(7);         // 过滤条件
        
        private DataSet  dsSearchMode       = null;                     // 检索方式
        private Hashtable arrSearchMode     = new Hashtable(7);         // 可用检索方式
        
        private Point    mousePoint;                                    // 鼠标下按时的位置
        private bool     userInput          = true;                     // 是否是用户输入
        
        private InputResult result          = new InputResult();        // 结果
        
        private string   col_Filter         = string.Empty;             // 搜索码的列
        private string   outFilter          = string.Empty;             // 外部设置的过滤条件
        
        private bool     userLoacate        = false;                    // 用户自已定位
        private Point    ptCtrlLeftTop      = new Point(0, 0);
        private int      ctrlHeight         = 0;
        #endregion
        SNDMS.DAL.DrugDict dalDrug = new SNDMS.DAL.DrugDict();
        
        public InputMethodFrm()
        {
            InitializeComponent();
            
            //Remoting.Service.Register(SqlHelper);    randb
        }
        
        
        #region 属性
        /// <summary>
        /// 属性 字典名称
        /// </summary>
        public string DictName
        {
            get { return _dictName; }
        }
        
        
        /// <summary>
        /// 选中的项目ID
        /// </summary>
        public string SelectedItemId
        {
            get { return _itemId; }
            set { _itemId = value;}
        }
        
        
        /// <summary>
        /// 选中的项目名称
        /// </summary>
        public string SelectedItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }
        
        
        /// <summary>
        /// 属性 后台加载的数据加载完成
        /// </summary>
        public bool Loaded
        {
            get { return _autoLoaded; }
        }                
        #endregion
        
        
        #region 窗体事件
        /// <summary>
        /// 窗体加载事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputMethodFrm_Load(object sender, EventArgs e)
        {
        }
        
        
        /// <summary>
        /// 窗体失焦事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputMethodFrm_Leave(object sender, EventArgs e)
        {
            
        }
        
        
        /// <summary>
        /// 窗体失焦事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>        
        private void InputMethodFrm_Deactivate(object sender, EventArgs e)
        {
            try
            {
                this.Close();
                this.Visible = false;
            }
            catch (System.Exception ex)
            {
                //LogFile.WriteLog("err.txt", "err:" + ex.Message);
            }   
        }

        
        /// <summary>
        /// 鼠标下按事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputMethodFrm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.mousePoint.X = e.X;
                this.mousePoint.Y = e.Y;
            }
        }
        
        
        /// <summary>
        /// 让窗体随鼠标移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void InputMethodFrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Top += e.Y - mousePoint.Y;      // Control.MousePosition.Y 
                this.Left += e.X - mousePoint.X;     // Control.MousePosition.X
            }
        }
              
        
        /// <summary>
        /// 输入法选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbInputCodeType_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }        
        
        
        /// <summary>
        /// 输入法选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cmbInputCodeType_SelectedValueChanged(object sender, EventArgs e)
        {
           
        }
        
        
        /// <summary>
        /// 刷新
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblRefresh_Click(object sender, EventArgs e)
        {
          
        }
        
        
        /// <summary>
        /// 窗体按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EditControl_KeyDown(object sender, KeyEventArgs e)
        {
            bool blnStore = userInput;
            
            try
            {
                userInput = false;
                
                if (this.Visible == false)
                {
                    return;
                }
                
                if (dgvDictItem.Rows.Count == 0)
                {
                    return;
                }
                
                switch(e.KeyCode)
                {
                    case Keys.Up:
                        if (dgvDictItem.SelectedRows.Count == 0)
                        {
                            dgvDictItem.Rows[0].Selected = true;
                        }
                        else
                        {
                            if (dgvDictItem.SelectedRows[0].Index > 0)
                            {
                                dgvDictItem.Rows[dgvDictItem.SelectedRows[0].Index - 1].Selected = true;
                                ensureSelectedRowShow();
                            }
                        }
                        
                        e.Handled = true;
                        
                        break;
                    case Keys.Down:
                        if (dgvDictItem.SelectedRows.Count == 0)
                        {
                            dgvDictItem.Rows[0].Selected = true;
                        }
                        else
                        {
                            if (dgvDictItem.SelectedRows[0].Index < dgvDictItem.Rows.Count - 1)
                            {
                                dgvDictItem.Rows[dgvDictItem.SelectedRows[0].Index + 1].Selected = true;
                                ensureSelectedRowShow();
                            }
                        }
                        
                        e.Handled = true;
                        
                        break;
                }
            }
            catch (System.Exception ex)
            {
                //LogFile.WriteLog("err.txt", "err:" + ex.Message);
            }   
            finally
            {
                userInput = blnStore;
            }
        }
        
        
        /// <summary>
        /// 窗体按键事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void EditControl_KeyPress(object sender, KeyPressEventArgs e)
        {
            bool blnStore = userInput;
            
            try
            {
                userInput = false;
                
                if (this.Visible == true)
                {
                    // ESC
                    if (e.KeyChar == 27)
                    {
                        e.Handled = true;
                        
                        this.Visible = false;
                    }
                    
                    // 回车确认
                    if (e.KeyChar == 13)
                    {
                        e.Handled = true;
                        
                        result.Clear();
                        
                        if (dgvDictItem.SelectedRows.Count > 0 && _textBox != null)
                        {
                            DataGridViewRow dgvRow = dgvDictItem.SelectedRows[0];
                            
                            for(int i = 0; i < dgvDictItem.Columns.Count; i++)
                            {
                                DataGridViewColumn dgvCol = dgvDictItem.Columns[i];
                                
                                if (dgvCol.Tag != null && dgvCol.Tag.ToString().Equals("0") == false)
                                {
                                    result.SetResult(dgvCol.Tag.ToString(), dgvRow.Cells[i].Value.ToString());
                                }
                            }
                            
                            if (ItemSelected != null)
                            {
                                ItemSelected(_textBox, result);
                            }
                        }
                            
                        this.Visible = false;
                    }
                    
                }
            }
            catch (System.Exception ex)
            {

            }   
            finally
            {
                userInput = blnStore;
            }
        }        
        
        
        /// <summary>
        /// 检索
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lblInputCode_TextChanged(object sender, EventArgs e)
        {
            bool blnStore = userInput;
            
            try
            {
               if (userInput == false)
                {
                    return;
                }
                
                userInput = false;
                
                //if (col_Filter.Trim().Length == 0)
                //{
                //    return;
                //}

              

                string filter = string.Empty;
                
                if (lblInputCode.Text.Length > 0)
                {
                    filter = " PYcode LIKE '%" + lblInputCode.Text + "%' ";
                }
                else
                {
                  
                }
                
                dsData.Tables[_dictName].DefaultView.RowFilter = filter;
                dgvDictItem.DataSource = dsData.Tables[_dictName].DefaultView;
            }
            catch (System.Exception ex)
            {
                //LogFile.WriteLog("err.txt", "err:" + ex.Message);
            }   
            finally
            {
                userInput = blnStore;
            }
        }
        
        
        /// <summary>
        /// 选择事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDictItem_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (userInput == false)
                {
                    return;
                }

                if (dgvDictItem.SelectedRows.Count > 0)
                {
                    //EditControl_KeyPress(lblInputCode, new KeyPressEventArgs('\r'));
                }
            }
            catch (System.Exception ex)
            {
                //LogFile.WriteLog("err.txt", "err:" + ex.Message);
            }   
        }        
        
        
        /// <summary>
        /// 双击选择
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDictItem_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (dgvDictItem.SelectedRows.Count > 0)
                {
                    EditControl_KeyPress(lblInputCode, new KeyPressEventArgs('\r'));
                }
            }
            catch (System.Exception ex)
            {
                //LogFile.WriteLog("err.txt", "err:" + ex.Message);
            }   
        }        
        
        
        /// <summary>
        /// 列表上回车事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvDictItem_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                EditControl_KeyPress(sender, e);
            }
        }        
        #endregion
        
        
        #region 共通函数
        /// <summary>
        /// 初始化
        /// </summary>
        public void Initialize()
        {
            Thread thread = new Thread (new ParameterizedThreadStart(loadData));
            
            thread.IsBackground = true;
            thread.Priority = ThreadPriority.BelowNormal;
            thread.Start(string.Empty);
        }
        
        
        /// <summary>
        /// 加载字典表
        /// </summary>
        public void LoadDict(string dictList)
        {
            Thread thread = new Thread (new ParameterizedThreadStart(loadData));
            
            thread.IsBackground = true;
            thread.Priority = ThreadPriority.BelowNormal;
            thread.Start(dictList);
        }
        
        
        /// <summary>
        /// 开始进行输入
        /// </summary>
        /// <param name="ctrl">用于定位的控件</param>
        /// <param name="dictType">字典名称</param>
        /// <param name="filter">过滤条件</param>
        public void InputBegin(Control ctrl, string dictType, string filter)
        {
            bool blnStore = userInput;
            
            try
            {
                userInput   = false;
                
                outFilter   = filter;
               

                _textBox    = ctrl;
                _dictName = dictType;
                userLoacate = false;

                Thread thread = new Thread(new ThreadStart(showInputMethod));
                thread.Start();                
            }
            catch (System.Exception ex)
            {
                //LogFile.WriteLog("err.txt", "err:" + ex.Message);
            }   
            finally
            {
                userInput = blnStore;
            }
        }
                
        
        /// <summary>
        /// 开始进行输入
        /// </summary>
        /// <param name="ctrl">用于定位的控件</param>
        /// <param name="dictType">字典名称</param>
        /// <param name="filter">过滤条件</param>
        /// <param name="ptLeftTop">相对于控件的左上角坐标</param>
        /// <param name="height">高度</param>
        public void InputBegin(Control ctrl, string dictType, string filter, Point ptLeftTop, int height)
        {
            bool blnStore = userInput;
            
            try
            {
                userInput       = false;
                
                outFilter       = filter;
                _textBox        = ctrl;
                _dictName       = dictType;
                
                userLoacate     = true;
                ptCtrlLeftTop   = ptLeftTop;
                ctrlHeight      = height;
                
                //Thread thread = new Thread(new ThreadStart(showInputMethod));
                //thread.Start();
            }
            catch (System.Exception ex)
            {
                //LogFile.WriteLog("err.txt", "err:" + ex.Message);
            }   
            finally
            {
                userInput = blnStore;
            }
        }
                
        
        ///// <summary>
        ///// 获取拼音码
        ///// </summary>
        ///// <returns></returns>
        //public string GetCodePY(string chineseStr)
        //{
        //    if (dsData.Tables.Contains(INPUT_CODE_DICT) == false)
        //    {
        //        return string.Empty;
        //    }
            
        //    string      result = string.Empty;
        //    string      filter = "ITEM_NAME = '{0}'";
        //    DataRow[]   drFind = null;
            
        //    for(int i = 0; i < chineseStr.Length; i++)
        //    {
        //        string oneChar = chineseStr.Substring(i, 1);
        //        if (oneChar.Equals(ComConst.STR.BLANK) == true)
        //        {
        //            result += oneChar;
        //        }
        //        else
        //        {
        //            drFind = dsData.Tables[INPUT_CODE_DICT].Select(string.Format(filter, oneChar), string.Empty);
        //            if (drFind.Length == 0)
        //            {
        //                result += "?";
        //            }
        //            else
        //            {
        //                oneChar = drFind[0]["INPUT_CODE_PY"].ToString().Trim();
        //                if (oneChar.Length > 1)
        //                {
        //                    oneChar = oneChar.Substring(0, 1);
        //                }
                        
        //                result += oneChar;
        //            }
        //        }
        //    }
            
        //    return result;
        //}
        
        
        ///// <summary>
        ///// 获取五笔码
        ///// </summary>
        ///// <returns></returns>
        //public string GetCodeWB(string chineseStr)
        //{
        //    if (dsData.Tables.Contains(INPUT_CODE_DICT) == false)
        //    {
        //        return string.Empty;
        //    }
            
        //    string      result = string.Empty;
        //    string      filter = "ITEM_NAME = '{0}'";
        //    DataRow[]   drFind = null;
            
        //    for(int i = 0; i < chineseStr.Length; i++)
        //    {
        //        string oneChar = chineseStr.Substring(i, 1);
        //        if (oneChar.Equals(ComConst.STR.BLANK) == true)
        //        {
        //            result += oneChar;
        //        }
        //        else
        //        {
        //            drFind = dsData.Tables[INPUT_CODE_DICT].Select(string.Format(filter, oneChar), string.Empty);
        //            if (drFind.Length == 0)
        //            {
        //                result += "?";
        //            }
        //            else
        //            {
        //                oneChar = drFind[0]["INPUT_CODE_WB"].ToString().Trim();
        //                if (oneChar.Length > 1)
        //                {
        //                    oneChar = oneChar.Substring(0, 1);
        //                }
                        
        //                result += oneChar;
        //            }
        //        }
        //    }
            
        //    return result;
        //}


        /// <summary>
        /// 显示输入法
        /// </summary>
        private void showInputMethod()
        {
            try
            {
                Thread.Sleep(100);
                _locker.WaitOne();

                Control.CheckForIllegalCrossThreadCalls = false;

                // 获取输入法类型字典
                if (dsSearchMode == null)
                {
                    //dsSearchMode = SqlHelper.GetTableData("INPUT_TYPE", string.Empty);

                    //dsSearchMode.Tables[0].DefaultView.Sort = "INPUT_CODE";
                    //dsSearchMode.Tables[0].DefaultView.RowFilter = "INPUT_CODE <> '00'";

                    //cmbInputCodeType.DataSource = dsSearchMode.Tables[0].DefaultView;
                    //cmbInputCodeType.ValueMember = "INPUT_CODE";
                    //cmbInputCodeType.DisplayMember = "INPUT_NAME";
                }

                // 获取字典表及字典项目表
                if (dsDictItem == null)
                {
                    //dsDictItem = SqlHelper.GetTableData("INPUT_SETTING", string.Empty);
                }

                _autoLoaded = true;

                initDisp(_dictName);
                setDataGridViewProperty(_dictName);

                if (cmbInputCodeType.SelectedIndex == -1)
                {
                    cmbInputCodeType.SelectedIndex = 0;
                }

                cmbInputCodeType_SelectedValueChanged(null, null);

                //setDataGridViewProperty(_dictName);

                if (userLoacate == true)
                {
                    locate(ptCtrlLeftTop, ctrlHeight);
                }
                else
                {
                    locate();
                }

                this.Visible = false;
                this.ActiveControl = lblInputCode;
                this.ShowDialog();
            }
            catch (System.Exception ex)
            {
                //LogFile.WriteLog("err.txt", "err:" + ex.Message);
            }   
            finally
            {
                _locker.ReleaseMutex();
            }
        }
        
        
        /// <summary>
        /// 加载数据
        /// </summary>
        private void loadData(object dictList)
        {
            try
            {
                try
                {
                    _locker.WaitOne();
                    
                    // 获取输入法类型字典
                    if (dsSearchMode == null)
                    {
                        //dsSearchMode = SqlHelper.GetTableData("INPUT_TYPE", string.Empty);
                        
                        //dsSearchMode.Tables[0].DefaultView.Sort = "INPUT_CODE";
                        //dsSearchMode.Tables[0].DefaultView.RowFilter = "INPUT_CODE <> '00'";
                        
                        //cmbInputCodeType.DataSource = dsSearchMode.Tables[0].DefaultView;
                        //cmbInputCodeType.ValueMember = "INPUT_CODE";
                        //cmbInputCodeType.DisplayMember = "INPUT_NAME";
                    }
                    
                    // 获取字典表及字典项目表
                    if (dsDictItem == null)
                    {
                        //dsDictItem = SqlHelper.GetTableData("INPUT_SETTING", string.Empty);
                    }
                }
                finally
                {
                    _locker.ReleaseMutex();
                }
                
                string[] parts = dictList.ToString().Split(",".ToCharArray());
                
                for(int i = 0; i < parts.Length; i++)
                {
                    // 获取输入法名称
                    string dictType = parts[i].Trim();
                    if (dictType.Length == 0)
                    {
                        continue;
                    }
                    
                    // 获取输入法过滤条件
                    string filter = string.Empty;
                    int pos0 = dictType.IndexOf("{");
                    int pos1 = dictType.IndexOf("}");
                    
                    if (pos0 > 0 && pos0 < pos1)
                    {
                        filter = dictType.Substring(pos0 + 1, pos1 - pos0 - 1);
                    }
                    
                    if (pos0 > 0)
                    {
                        dictType = dictType.Substring(0, pos0).Trim();    
                    }
                    
                    // 获取输入法数据
                    try
                    {
                        _locker.WaitOne();
                        
                        if (dictType.ToUpper().Equals(INPUT_CODE_DICT) == true)
                        {
                            if (dsData.Tables.Contains(INPUT_CODE_DICT) == false)
                            {
                                //DataSet dsTemp = SqlHelper.GetTableData(INPUT_CODE_DICT, string.Empty);
                                //dsData.Tables.Add(dsTemp.Tables[0].Copy());
                            }
                        }
                        else
                        {
                            getDictDataFromDb(dictType, filter);
                            
                            // 保存过滤条件
                            if (arrFilter.ContainsKey(dictType) == true)
                            {
                                arrFilter.Remove(dictType);
                            }
                            
                            arrFilter.Add(dictType, filter);
                        }
                    }
                    finally
                    {
                        _locker.ReleaseMutex();
                    }
                }
            }
            catch (System.Exception ex)
            {
                //LogFile.WriteLog("err.txt", "err:" + ex.Message);
            }   
            finally
            {
                // 标识完成
                _autoLoaded = true;
            }
        }
        
        
        /// <summary>
        /// 从数据库中加载字典数据
        /// </summary>
        /// <returns></returns>
        private bool getDictDataFromDb(string dictName, string otherFilter)
        {
            dsData = dalDrug.GetList(otherFilter);

             dsData.Tables[0].TableName=_dictName;
            
            //dsData.Tables[_dictName]=
            return true;
        }
        
        
        /// <summary>
        /// 显示输入法时初始化
        /// </summary>
        private bool initDisp(string dictName)
        {
            result.Clear();
            
            //_dictName   = dictName;

            // 获取字典数据
            if (dsData.Tables.Contains(_dictName) == false)
            {
                getDictDataFromDb(_dictName, string.Empty);
            }
            
            // 设置表格属性
            lblInputCode.Text = string.Empty;
            if (outFilter != "")
            {
                lblInputCode.Text = outFilter;
                lblInputCode.Select(1, 0);
            }
            
            //string filter = getFilter(_dictName, outFilter);
            //dsData.Tables[dictName].DefaultView.RowFilter = filter;
            dgvDictItem.ShowCellToolTips = false;
            dgvDictItem.DataSource = dsData.Tables[dictName].DefaultView;
            
            // 调整高度
            //int row = 0;
            //int height = dgvDictItem.ColumnHeadersHeight;            
            //while(row < dgvDictItem.Rows.Count)
            //{
            //    height += dgvDictItem.Rows[row].Height;
                
               
                
            //    row++;
            //}
            
            //this.Height = pnlInput.Height + height + 20;
            
            return true;
        }
                
        
        /// <summary>
        /// 设置表格属性
        /// </summary>
        /// <param name="dictName"></param>
        private void setDataGridViewProperty(string dictName)
        {

            dgvDictItem.Columns[0].Tag = 1;
            dgvDictItem.Columns[1].Tag = 2;
            dgvDictItem.Columns[2].Tag = 4;
            dgvDictItem.Columns[4].Tag = 5;
            dgvDictItem.Columns["colMedFactory"].Tag = 8;
           // dgvDictItem.Columns[4].Tag = i;
            //// 宽度 与 检索方式 设置列标题, 列宽, 是否可见
            //string filter = "DICT_TYPE = " + SQL.SqlConvert(_dictName);
            //DataRow[] drFind = dsDictItem.Tables[0].Select(filter, "SHOW_SORT");
            //if (drFind.Length == 0)
            //{
            //    return ;
            //}
            
            //int width   = 0;
            //int tempInt = 0;
            //arrSearchMode.Clear();

            //for (int i = 0; i < dsData.Tables[_dictName].Columns.Count; i++)
            //{
            ////    DataColumn dc= dsData.Tables[_dictName].Columns[i];

            ////    // 检索方式
            ////    string inputCode = dr["INPUT_CODE"].ToString().Trim();
            ////    if (inputCode.Length > 0 && arrSearchMode.ContainsKey(inputCode) == false)
            ////    {
            ////        if (inputCode.EndsWith("0") == false)
            ////        {
            ////            arrSearchMode.Add(inputCode, dr["DATA_COL"].ToString());
            ////        }
            ////    }

            //// 返回类型
            //dgvDictItem.Columns[i].Tag = i;

            //    //// 是否可见
            //    //if (dr["FLAG_SHOW"].ToString().Equals("Y") == false)
            //    //{
            //    //    dgvDictItem.Columns[i].Visible = false;
            //    //    continue;
            //    //}

            //    //// 宽度
            //    //if (int.TryParse(dr["SHOW_WIDTH"].ToString(), out tempInt) == true)
            //    //{
            //    //    width += tempInt;
            //    //    dgvDictItem.Columns[i].Width = tempInt;
            //    //}

            //    // 标题
            //    //dgvDictItem.Columns[i].HeaderText = dr["DATA_TITLE"].ToString();
            //}

            //if (width < 214)
            //{
            //    width = 214;
            //}
            //else
            //{
            //    width += 20;
            //}

            //this.Width = width;
        }
        
        
        /// <summary>
        /// 设置选中行在可视区域
        /// </summary>
        private void ensureSelectedRowShow()
        {
            if (dgvDictItem.SelectedRows.Count == 0)
            {
                return;
            }
            
            for(int i = 0; i < dgvDictItem.Columns.Count; i++)
            {
                DataGridViewColumn dc = dgvDictItem.Columns[i];
                
                if (dc.Visible == true)
                {
                    dgvDictItem.CurrentCell = dgvDictItem.SelectedRows[0].Cells[i];
                    break;
                }
            }
        }
        
        
        /// <summary>
        /// 定位
        /// </summary>
        private void locate()
        {
            if (_textBox == null || _textBox.Parent == null)
            {
                return;
            }
            
            // 查找相对于窗体的位置
            Point pt = new Point(_textBox.Left, _textBox.Top);
            pt.Y += _textBox.Height;
            
            Win32API.ClientToScreen(_textBox.Parent.Handle, ref pt);
            
            if (pt.Y + this.Height < Screen.PrimaryScreen.Bounds.Height)
            {
                this.Top = pt.Y;
            }
            else
            {
                this.Top = pt.Y - _textBox.Height - this.Height;
            }
            
            if (pt.X + this.Width < Screen.PrimaryScreen.Bounds.Width)
            {
                this.Left = pt.X;
            }
            else
            {
                this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width;
            }
        }
        
        
        /// <summary>
        /// 定位
        /// </summary>
        /// <param name="ptLeftTop">相对于控件的左上角坐标</param>
        /// <param name="height">高度</param>
        private void locate(Point ptLeftTop, int height)
        {
            if (_textBox == null || _textBox.Parent == null)
            {
                return;
            }
            
            // 查找相对于窗体的位置
            Point pt = ptLeftTop;
            pt.Y += height;
            
            Win32API.ClientToScreen(_textBox.Handle, ref pt);
            
            if (pt.Y + this.Height < Screen.PrimaryScreen.Bounds.Height)
            {
                this.Top = pt.Y;
            }
            else
            {
                this.Top = pt.Y - _textBox.Height - this.Height;
            }
            
            if (pt.X + this.Width < Screen.PrimaryScreen.Bounds.Width)
            {
                this.Left = pt.X;
            }
            else
            {
                this.Left = Screen.PrimaryScreen.Bounds.Width - this.Width;
            }
        }        
        
        
        /// <summary>
        /// 获取加载时的过滤条件
        /// </summary>
        /// <param name="dictName">输入法名称</param>
        /// <returns>过滤条件</returns>
        private string getFilter(string dictName, string otherFilter)
        {
            return otherFilter;
            
            //otherFilter = otherFilter.Trim();
            
            //if (arrFilter.ContainsKey(dictName) == true)
            //{
            //    string filter = arrFilter[dictName].ToString().Trim();
                    
            //    if (filter.Length > 0 && otherFilter.Length > 0)
            //    {
            //        filter += " AND " + otherFilter;
            //    }
            //    else if (otherFilter.Length > 0)
            //    {
            //        filter = otherFilter;
            //    }
                
            //    return filter;
            //}
            //else
            //{
            //    return string.Empty;
            //}
        }        
        #endregion
    }
}
