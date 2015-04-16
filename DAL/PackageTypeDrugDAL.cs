using System;
using System.Collections.Generic;
using System.Text;
using DBUtility;
using System.Data;//Please add references

namespace SNDMS.DAL
{
    /// <summary>
    /// 数据访问类:PackageTypeDrug
    /// </summary>
    public partial class PackageTypeDrugDAL
    {
        public PackageTypeDrugDAL()
        { }
        #region  Method

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        //public bool Exists(int PackageTypeNo, int DrugNo)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select count(1) from PackageTypeDrug");
        //    strSql.Append(" where PackageTypeNo=" + PackageTypeNo + " and DrugNo=" + DrugNo + " ");
        //    return SqlHelper.Exists(strSql.ToString());
        //}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(SNDMS.Model.PackageTypeDrug model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.PackageTypeNo != null)
            {
                strSql1.Append("PackageTypeNo,");
                strSql2.Append("" + model.PackageTypeNo + ",");
            }
            if (model.DrugNo != null)
            {
                strSql1.Append("DrugNo,");
                strSql2.Append("" + model.DrugNo + ",");
            }
            if (model.Count != null)
            {
                strSql1.Append("Count,");
                strSql2.Append("" + model.Count + ",");
            }
            strSql.Append("insert into PackageTypeDrug(");
            strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
            strSql.Append(")");
            int rows = SqlHelper.ExecuteNonQuery(strSql.ToString());
            if (rows > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(SNDMS.Model.PackageTypeDrug model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PackageTypeDrug set ");
            if (model.Count != null)
            {
                strSql.Append("Count=" + model.Count + ",");
            }
            else
            {
                strSql.Append("Count= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where PackageTypeNo=" + model.PackageTypeNo + " and DrugNo=" + model.DrugNo + " ");
            int rowsAffected = SqlHelper.ExecuteNonQuery(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(int PackageTypeNo, int DrugNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PackageTypeDrug ");
            strSql.Append(" where PackageTypeNo=" + PackageTypeNo + " and DrugNo=" + DrugNo + " ");
            int rowsAffected = SqlHelper.ExecuteNonQuery(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public SNDMS.Model.PackageTypeDrug GetModel(int PackageTypeNo, int DrugNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" PackageTypeNo,DrugNo,Count ");
            strSql.Append(" from PackageTypeDrug ");
            strSql.Append(" where PackageTypeNo=" + PackageTypeNo + " and DrugNo=" + DrugNo + " ");
            SNDMS.Model.PackageTypeDrug model = new SNDMS.Model.PackageTypeDrug();
            DataSet ds = SqlHelper.ExecuteDataset(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["PackageTypeNo"] != null && ds.Tables[0].Rows[0]["PackageTypeNo"].ToString() != "")
                {
                    model.PackageTypeNo = int.Parse(ds.Tables[0].Rows[0]["PackageTypeNo"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DrugNo"] != null && ds.Tables[0].Rows[0]["DrugNo"].ToString() != "")
                {
                    model.DrugNo = int.Parse(ds.Tables[0].Rows[0]["DrugNo"].ToString());
                }
                if (ds.Tables[0].Rows[0]["Count"] != null && ds.Tables[0].Rows[0]["Count"].ToString() != "")
                {
                    model.Count = int.Parse(ds.Tables[0].Rows[0]["Count"].ToString());
                }
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select PackageTypeNo,DrugNo,Count ");
            strSql.Append(" FROM PackageTypeDrug ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return SqlHelper.ExecuteDataset(strSql.ToString());
        }

        /// <summary>
        /// 获得前几行数据
        /// </summary>
        public DataSet GetList(int Top, string strWhere, string filedOrder)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select ");
            if (Top > 0)
            {
                strSql.Append(" top " + Top.ToString());
            }
            strSql.Append(" PackageTypeNo,DrugNo,Count ");
            strSql.Append(" FROM PackageTypeDrug ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" order by " + filedOrder);
            return SqlHelper.ExecuteDataset(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM PackageTypeDrug ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            object obj = SqlHelper.ExecuteScalar(strSql.ToString());
            if (obj == null)
            {
                return 0;
            }
            else
            {
                return Convert.ToInt32(obj);
            }
        }
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("SELECT * FROM ( ");
            strSql.Append(" SELECT ROW_NUMBER() OVER (");
            if (!string.IsNullOrEmpty(orderby.Trim()))
            {
                strSql.Append("order by T." + orderby);
            }
            else
            {
                strSql.Append("order by T.DrugNo desc");
            }
            strSql.Append(")AS Row, T.*  from PackageTypeDrug T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return SqlHelper.ExecuteDataset(strSql.ToString());
        }

        /*
        */

        #endregion  Method
    }
}
