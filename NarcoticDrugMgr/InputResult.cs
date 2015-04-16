using System;
using System.Collections.Generic;
using System.Text;

namespace ESS
{
    public delegate void ItemInputed(object sender, InputResult e);
    
    
    public class InputResult
    {
        #region 变量
        private string _itemCode            = string.Empty;                     // 代码
        private string _itemName            = string.Empty;                     // 名称
        private string _itemClass           = string.Empty;                     // 类别
        private string _itemSpec            = string.Empty;                     // 规格
        private string _itemUnit            = string.Empty;                     // 单位
        private string _itemFirm            = string.Empty;                     // 厂商
        private string _itemPrice           = string.Empty;                     // 价格
        private string _itemQuantity        = string.Empty;                     // 数量
        private string _itemPackageSpec     = string.Empty;                     // 包装规格
        private string _itemPackageUnits    = string.Empty;                     // 包装单位
        private string _performed_dept      = string.Empty;                     // 执行科室
        #endregion
        
            
        public InputResult()
        {
            
        }
        
        
        #region 属性
        /// <summary>
        /// 项目代码
        /// </summary>
        public string ItemCode
        {
            get { return _itemCode; }
            set { _itemCode = value; }
        }
        
        
        /// <summary>
        /// 项目名称
        /// </summary>
        public string ItemName
        {
            get { return _itemName; }
            set { _itemName = value; }
        }


        /// <summary>
        /// 项目类别
        /// </summary>
        public string ItemClass
        {
            get { return _itemClass; }
            set { _itemClass = value; }
        }
        
        
        /// <summary>
        /// 项目规格
        /// </summary>
        public string ItemSpec
        {
            get { return _itemSpec; }
            set { _itemSpec = value; }
        }
        
        
        /// <summary>
        /// 项目单位
        /// </summary>
        public string ItemUnit
        {
            get { return _itemUnit; }
            set { _itemUnit = value; }
        }
        
        
        /// <summary>
        /// 属性[生产厂商]
        /// </summary>
        public string ItemFirm
        {
            get
            {
                return _itemFirm;
            }
            set
            {
                _itemFirm = value;
            }
        }
        
        
        /// <summary>
        /// 单价
        /// </summary>
        public string ItemPrice
        {
            get { return _itemPrice; }
            set { _itemPrice = value; }
        }
        
        
        /// <summary>
        /// 数量
        /// </summary>
        public string ItemQuantity
        {
            get { return _itemQuantity; }
            set { _itemQuantity = value; }
        }
        
        
        /// <summary>
        /// 属性[包装规格]
        /// </summary>
        public string ItemPackageSpec
        {
            get
            {
                return _itemPackageSpec;
            }
            set
            {
                _itemPackageSpec = value;
            }
        }
        
        
        /// <summary>
        /// 属性[包装单位]
        /// </summary>
        public string ItemPackageUnits
        {
            get
            {
                return _itemPackageUnits;
            }
            set
            {
                _itemPackageUnits = value;
            }
        }
        
        
        /// <summary>
        /// 执行科室
        /// </summary>
        public string Performed_dept
        {
            get { return _performed_dept; }
            set { _performed_dept = value; }
        }
        #endregion
        
        
        /// <summary>
        /// 清除
        /// </summary>
        public void Clear()
        {
            _itemCode        = string.Empty;                     // 代码
            _itemName        = string.Empty;                     // 名称
            _itemClass       = string.Empty;                     // 类别
            _itemSpec        = string.Empty;                     // 规格
            _itemUnit        = string.Empty;                     // 单位
            _itemPrice       = string.Empty;                     // 价格
            _itemQuantity    = string.Empty;                     // 数量
            _performed_dept  = string.Empty;                     // 执行科室
        }
        
        
        /// <summary>
        /// 设置返回结果
        /// </summary>
        /// <param name="resultSort"></param>
        /// <param name="result"></param>
        public void SetResult(string resultSort, string result)
        {
            switch(resultSort)
            {
                case "1":
                    _itemCode           = result;
                    break;
                case "2":
                    _itemName           = result;
                    break;
                case "3":
                    _itemClass          = result;
                    break;
                case "4":
                    _itemSpec           = result;
                    break;
                case "5":
                    _itemUnit           = result;
                    break;
                case "6":
                    _itemPrice          = result;
                    break;
                case "7":
                    _itemQuantity       = result;
                    break;
                case "8":
                    _performed_dept     = result;
                    break;
                case "9":
                    _itemFirm           = result;
                    break;
                case "10":
                    _itemPackageSpec    = result;
                    break;
                case "11":
                    _itemPackageUnits   = result;
                    break;
                default:
                    break;
            }
        }
    }
}
