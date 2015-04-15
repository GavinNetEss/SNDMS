using System;
namespace SNDMS.Model
{
    /// <summary>
    /// DrugDict:实体类(属性说明自动提取数据库字段的描述信息)
    /// </summary>
    [Serializable]
    public partial class DrugDict
    {
        public DrugDict()
        { }
        #region Model
        private int _drugno;
        private string _drugname;
        private string _drugspec;
        private string _manufactory;
        private string _unit;
        private string _drugclass;
        private string _isrecycle;
        /// <summary>
        /// 药品唯一编号
        /// </summary>
        public int DrugNo
        {
            set { _drugno = value; }
            get { return _drugno; }
        }
        /// <summary>
        /// 药品名称
        /// </summary>
        public string DrugName
        {
            set { _drugname = value; }
            get { return _drugname; }
        }
        /// <summary>
        /// 药品规格
        /// </summary>
        public string DrugSpec
        {
            set { _drugspec = value; }
            get { return _drugspec; }
        }
        /// <summary>
        /// 生产厂家
        /// </summary>
        public string Manufactory
        {
            set { _manufactory = value; }
            get { return _manufactory; }
        }
        /// <summary>
        /// 包装单位
        /// </summary>
        public string Unit
        {
            set { _unit = value; }
            get { return _unit; }
        }
        /// <summary>
        /// 药品类别
        /// </summary>
        public string DrugClass
        {
            set { _drugclass = value; }
            get { return _drugclass; }
        }
        /// <summary>
        /// 是否回收：0，否；1，是
        /// </summary>
        public string IsRecycle
        {
            set { _isrecycle = value; }
            get { return _isrecycle; }
        }
        #endregion Model

    }
}

