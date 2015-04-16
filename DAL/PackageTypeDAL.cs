using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;//Please add references

namespace SNDMS.DAL
{
    /// <summary>
    /// 数据访问类:PackageType
    /// </summary>
    public partial  class PackageTypeDAL
    {
        public PackageTypeDAL()
        { }
        #region  Method

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(int PackageTypeNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from PackageType");
            strSql.Append(" where PackageTypeNo=" + PackageTypeNo + " ");
            object obj= SqlHelper.ExecuteScalar(strSql.ToString());

            if (obj != null)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(SNDMS.Model.PackageType model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.PackageTypeName != null)
            {
                strSql1.Append("PackageTypeName,");
                strSql2.Append("'" + model.PackageTypeName + "',");
            }
            strSql.Append("insert into PackageType(");
            strSql.Append(strSql1.ToString().Remove(strSql1.Length - 1));
            strSql.Append(")");
            strSql.Append(" values (");
            strSql.Append(strSql2.ToString().Remove(strSql2.Length - 1));
            strSql.Append(")");
            strSql.Append(";select @@IDENTITY");
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
        /// 更新一条数据
        /// </summary>
        public bool Update(SNDMS.Model.PackageType model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update PackageType set ");
            if (model.PackageTypeName != null)
            {
                strSql.Append("PackageTypeName='" + model.PackageTypeName + "',");
            }
            else
            {
                strSql.Append("PackageTypeName= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where PackageTypeNo=" + model.PackageTypeNo + "");
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
        public bool Delete(int PackageTypeNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PackageType ");
            strSql.Append(" where PackageTypeNo=" + PackageTypeNo + "");
            int rowsAffected = SqlHelper.ExecuteNonQuery(strSql.ToString());
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }		/// <summary>
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string PackageTypeNolist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from PackageType ");
            strSql.Append(" where PackageTypeNo in (" + PackageTypeNolist + ")  ");
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
        /// 得到一个对象实体
        /// </summary>
        public SNDMS.Model.PackageType GetModel(int PackageTypeNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" PackageTypeNo,PackageTypeName ");
            strSql.Append(" from PackageType ");
            strSql.Append(" where PackageTypeNo=" + PackageTypeNo + "");
            SNDMS.Model.PackageType model = new SNDMS.Model.PackageType();
            DataSet ds = SqlHelper.ExecuteDataset(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["PackageTypeNo"] != null && ds.Tables[0].Rows[0]["PackageTypeNo"].ToString() != "")
                {
                    model.PackageTypeNo = int.Parse(ds.Tables[0].Rows[0]["PackageTypeNo"].ToString());
                }
                if (ds.Tables[0].Rows[0]["PackageTypeName"] != null && ds.Tables[0].Rows[0]["PackageTypeName"].ToString() != "")
                {
                    model.PackageTypeName = ds.Tables[0].Rows[0]["PackageTypeName"].ToString();
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
            strSql.Append("select PackageTypeNo,PackageTypeName ");
            strSql.Append(" FROM PackageType ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return SqlHelper.ExecuteDataset(strSql.ToString());
        }

        /// <summary>
        /// 获取数据列表 
        /// </summary>
        public DataSet GetListWithDrugName(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select PackageTypeNo,DrugNo,Count,DrugName,DrugSpec,Manufactory ");
            strSql.Append(" FROM dbo.View_PackageContent ");
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
            strSql.Append(" PackageTypeNo,PackageTypeName ");
            strSql.Append(" FROM PackageType ");
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
            strSql.Append("select count(1) FROM PackageType ");
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
                strSql.Append("order by T.PackageTypeNo desc");
            }
            strSql.Append(")AS Row, T.*  from PackageType T ");
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

