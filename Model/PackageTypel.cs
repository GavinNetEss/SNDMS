using System;

namespace SNDMS.Model
{
    /// <summary>
    /// PackageType:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class PackageType
    {
        public PackageType()
        { }
        #region Model
        private int _packagetypeno;
        private string _packagetypename;
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
        public string PackageTypeName
        {
            set { _packagetypename = value; }
            get { return _packagetypename; }
        }
        #endregion Model
    }
}

