using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using DBUtility;//Please add references
namespace SNDMS.DAL
{
    /// <summary>
    /// 数据访问类:DrugDict
    /// </summary>
    public partial class DrugDict
    {
        public DrugDict()
        { }
        #region  Method

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        //public bool Exists(int DrugNo)
        //{
        //    StringBuilder strSql = new StringBuilder();
        //    strSql.Append("select count(1) from DrugDict");
        //    strSql.Append(" where DrugNo=" + DrugNo + " ");
        //    return SqlHelper.(strSql.ToString());
        //}

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public int Add(SNDMS.Model.DrugModel model)
        {
            StringBuilder strSql = new StringBuilder();
            StringBuilder strSql1 = new StringBuilder();
            StringBuilder strSql2 = new StringBuilder();
            if (model.DrugName != null)
            {
                strSql1.Append("DrugName,");
                strSql2.Append("'" + model.DrugName + "',");
            }
            if (model.DrugSpec != null)
            {
                strSql1.Append("DrugSpec,");
                strSql2.Append("'" + model.DrugSpec + "',");
            }
            if (model.Manufactory != null)
            {
                strSql1.Append("Manufactory,");
                strSql2.Append("'" + model.Manufactory + "',");
            }
            if (model.Unit != null)
            {
                strSql1.Append("Unit,");
                strSql2.Append("'" + model.Unit + "',");
            }
            if (model.DrugClass != null)
            {
                strSql1.Append("DrugClass,");
                strSql2.Append("'" + model.DrugClass + "',");
            }
            if (model.IsRecycle != null)
            {
                strSql1.Append("IsRecycle,");
                strSql2.Append("'" + model.IsRecycle + "',");
            }
            if (model.PYcode != null)
            {
                strSql1.Append("PYcode,");
                strSql2.Append("'" + model.PYcode + "',");
            }
            strSql.Append("insert into DrugDict(");
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
        public bool Update(SNDMS.Model.DrugModel model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update DrugDict set ");
            if (model.DrugName != null)
            {
                strSql.Append("DrugName='" + model.DrugName + "',");
            }
            else
            {
                strSql.Append("DrugName= null ,");
            }
            if (model.DrugSpec != null)
            {
                strSql.Append("DrugSpec='" + model.DrugSpec + "',");
            }
            else
            {
                strSql.Append("DrugSpec= null ,");
            }
            if (model.Manufactory != null)
            {
                strSql.Append("Manufactory='" + model.Manufactory + "',");
            }
            else
            {
                strSql.Append("Manufactory= null ,");
            }
            if (model.Unit != null)
            {
                strSql.Append("Unit='" + model.Unit + "',");
            }
            else
            {
                strSql.Append("Unit= null ,");
            }
            if (model.DrugClass != null)
            {
                strSql.Append("DrugClass='" + model.DrugClass + "',");
            }
            else
            {
                strSql.Append("DrugClass= null ,");
            }
            if (model.IsRecycle != null)
            {
                strSql.Append("IsRecycle='" + model.IsRecycle + "',");
            }
            else
            {
                strSql.Append("IsRecycle= null ,");
            }
            if (model.PYcode != null)
            {
                strSql.Append("PYcode='" + model.PYcode + "',");
            }
            else
            {
                strSql.Append("PYcode= null ,");
            }
            int n = strSql.ToString().LastIndexOf(",");
            strSql.Remove(n, 1);
            strSql.Append(" where DrugNo=" + model.DrugNo + "");
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
        public bool Delete(int DrugNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DrugDict ");
            strSql.Append(" where DrugNo=" + DrugNo + "");
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
        public bool DeleteList(string DrugNolist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from DrugDict ");
            strSql.Append(" where DrugNo in (" + DrugNolist + ")  ");
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
        public SNDMS.Model.DrugModel GetModel(int DrugNo)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select  top 1  ");
            strSql.Append(" DrugNo,DrugName,DrugSpec,Manufactory,Unit,DrugClass,IsRecycle,PYcode ");
            strSql.Append(" from DrugDict ");
            strSql.Append(" where DrugNo=" + DrugNo + "");
            SNDMS.Model.DrugModel model = new SNDMS.Model.DrugModel();
            DataSet ds = SqlHelper.ExecuteDataset(strSql.ToString());
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["DrugNo"] != null && ds.Tables[0].Rows[0]["DrugNo"].ToString() != "")
                {
                    model.DrugNo = int.Parse(ds.Tables[0].Rows[0]["DrugNo"].ToString());
                }
                if (ds.Tables[0].Rows[0]["DrugName"] != null && ds.Tables[0].Rows[0]["DrugName"].ToString() != "")
                {
                    model.DrugName = ds.Tables[0].Rows[0]["DrugName"].ToString();
                }
                if (ds.Tables[0].Rows[0]["DrugSpec"] != null && ds.Tables[0].Rows[0]["DrugSpec"].ToString() != "")
                {
                    model.DrugSpec = ds.Tables[0].Rows[0]["DrugSpec"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Manufactory"] != null && ds.Tables[0].Rows[0]["Manufactory"].ToString() != "")
                {
                    model.Manufactory = ds.Tables[0].Rows[0]["Manufactory"].ToString();
                }
                if (ds.Tables[0].Rows[0]["Unit"] != null && ds.Tables[0].Rows[0]["Unit"].ToString() != "")
                {
                    model.Unit = ds.Tables[0].Rows[0]["Unit"].ToString();
                }
                if (ds.Tables[0].Rows[0]["DrugClass"] != null && ds.Tables[0].Rows[0]["DrugClass"].ToString() != "")
                {
                    model.DrugClass = ds.Tables[0].Rows[0]["DrugClass"].ToString();
                }
                if (ds.Tables[0].Rows[0]["IsRecycle"] != null && ds.Tables[0].Rows[0]["IsRecycle"].ToString() != "")
                {
                    model.IsRecycle = ds.Tables[0].Rows[0]["IsRecycle"].ToString();
                }
                if (ds.Tables[0].Rows[0]["PYcode"] != null && ds.Tables[0].Rows[0]["PYcode"].ToString() != "")
                {
                    model.PYcode = ds.Tables[0].Rows[0]["PYcode"].ToString();
                }
                return model;
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 获得数据列表，结果从高到低排序
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select DrugNo,DrugName,DrugSpec,Manufactory,Unit,DrugClass,IsRecycle,PYcode ");
            strSql.Append(" FROM DrugDict ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            strSql.Append(" Order by DrugNo Desc");
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
            strSql.Append(" DrugNo,DrugName,DrugSpec,Manufactory,Unit,DrugClass,IsRecycle,PYcode ");
            strSql.Append(" FROM DrugDict ");
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
            strSql.Append("select count(1) FROM DrugDict ");
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
            strSql.Append(")AS Row, T.*  from DrugDict T ");
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

