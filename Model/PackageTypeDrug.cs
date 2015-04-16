using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SNDMS.Model
{
    /// PackageTypeDrug:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class PackageTypeDrug
    {
        public PackageTypeDrug()
        { }
        #region Model
        private int _packagetypeno;
        private int _drugno;
        private int? _count;
        /// <summary>
        /// 
        /// </summary>
        public int PackageTypeNo
        {
            set { _packagetypeno = value; }
            get { return _packagetypeno; }
        }
        /// <summary>
        /// 
        /// </summary>
        public int DrugNo
        {
            set { _drugno = value; }
            get { return _drugno; }
        }
        /// <summary>
        /// 数量
        /// </summary>
        public int? Count
        {
            set { _count = value; }
            get { return _count; }
        }
        #endregion Model

    }
}
