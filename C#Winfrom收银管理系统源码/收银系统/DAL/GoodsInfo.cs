/**  版本信息模板在安装目录下，可自行修改。
* GoodsInfo.cs
*
* 功 能： N/A
* 类 名： GoodsInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-11-20 22:50:30   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.OleDb;
using Maticsoft.DBUtility;//Please add references
namespace Dong.DAL
{
    /// <summary>
    /// 数据访问类:GoodsInfo
    /// </summary>
    public partial class GoodsInfo
    {
        public GoodsInfo()
        { }
        #region  BasicMethod

        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Code)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from GoodsInfo");
            strSql.Append(" where Code='" + Code + "'");


            return DbHelperOleDb.Exists(strSql.ToString());


        }


        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Dong.Model.GoodsInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("insert into GoodsInfo(");
            strSql.Append("Code,GoodName,Category,CategoryName,Unit,UnitName,Factory,Supplier,SupplierName,Price0,Price1,Price2,Counts)");
            strSql.Append(" values (");
            strSql.Append("@Code,@GoodName,@Category,@CategoryName,@Unit,@UnitName,@Factory,@Supplier,@SupplierName,@Price0,@Price1,@Price2,@Counts)");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Code", OleDbType.VarChar,50),
                    new OleDbParameter("@GoodName", OleDbType.VarChar,50),
					new OleDbParameter("@Category", OleDbType.Integer,4),
					new OleDbParameter("@CategoryName", OleDbType.VarChar,50),
					new OleDbParameter("@Unit", OleDbType.Integer,4),
					new OleDbParameter("@UnitName", OleDbType.VarChar,50),
					new OleDbParameter("@Factory", OleDbType.VarChar,50),
					new OleDbParameter("@Supplier", OleDbType.Integer,4),
					new OleDbParameter("@SupplierName", OleDbType.VarChar,50),
					new OleDbParameter("@Price0", OleDbType.Double),
					new OleDbParameter("@Price1", OleDbType.Double),
					new OleDbParameter("@Price2", OleDbType.Double),
					new OleDbParameter("@Counts", OleDbType.Integer,4)};
            parameters[0].Value = model.Code;
            parameters[1].Value = model.GoodsName;
            parameters[2].Value = model.Category;
            parameters[3].Value = model.CategoryName;
            parameters[4].Value = model.Unit;
            parameters[5].Value = model.UnitName;
            parameters[6].Value = model.Factory;
            parameters[7].Value = model.Supplier;
            parameters[8].Value = model.SupplierName;
            parameters[9].Value = model.Price0;
            parameters[10].Value = model.Price1;
            parameters[11].Value = model.Price2;
            parameters[12].Value = model.Counts;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
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
        public bool Update(Dong.Model.GoodsInfo model)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("update GoodsInfo set ");
            strSql.Append("Code=@Code,");
            strSql.Append("GoodName=@GoodsName,");
            strSql.Append("Category=@Category,");
            strSql.Append("CategoryName=@CategoryName,");
            strSql.Append("Unit=@Unit,");
            strSql.Append("UnitName=@UnitName,");
            strSql.Append("Factory=@Factory,");
            strSql.Append("Supplier=@Supplier,");
            strSql.Append("SupplierName=@SupplierName,");
            strSql.Append("Price0=@Price0,");
            strSql.Append("Price1=@Price1,");
            strSql.Append("Price2=@Price2,");
            strSql.Append("Counts=@Counts");
            strSql.Append(" where Id=@Id ");
            OleDbParameter[] parameters = {
                    new OleDbParameter("@Code", OleDbType.VarChar,50),
                    new OleDbParameter("@GoodsName", OleDbType.VarChar,50),
					new OleDbParameter("@Category", OleDbType.Integer,4),
					new OleDbParameter("@CategoryName", OleDbType.VarChar,50),
					new OleDbParameter("@Unit", OleDbType.Integer,4),
					new OleDbParameter("@UnitName", OleDbType.VarChar,50),
					new OleDbParameter("@Factory", OleDbType.VarChar,50),
					new OleDbParameter("@Supplier", OleDbType.Integer,4),
					new OleDbParameter("@SupplierName", OleDbType.VarChar,50),
					new OleDbParameter("@Price0", OleDbType.Double),
					new OleDbParameter("@Price1", OleDbType.Double),
					new OleDbParameter("@Price2", OleDbType.Double),
					new OleDbParameter("@Counts", OleDbType.Integer,4),
					new OleDbParameter("@Id", OleDbType.Integer,4)
					};
            parameters[0].Value = model.Code;
            parameters[1].Value = model.GoodsName;
            parameters[2].Value = model.Category;
            parameters[3].Value = model.CategoryName;
            parameters[4].Value = model.Unit;
            parameters[5].Value = model.UnitName;
            parameters[6].Value = model.Factory;
            parameters[7].Value = model.Supplier;
            parameters[8].Value = model.SupplierName;
            parameters[9].Value = model.Price0;
            parameters[10].Value = model.Price1;
            parameters[11].Value = model.Price2;
            parameters[12].Value = model.Counts;
            parameters[13].Value = model.Id;
            

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(int Id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from GoodsInfo ");
            strSql.Append(" where Id=@Id");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.Integer,4)
			};
            parameters[0].Value = Id;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
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
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from GoodsInfo ");
            strSql.Append(" where Code=@Code ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Code", OleDbType.VarChar,50)			};
            parameters[0].Value = Code;

            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString(), parameters);
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
        /// 批量删除数据
        /// </summary>
        public bool DeleteList(string Codelist)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("delete from GoodsInfo ");
            strSql.Append(" where Code in (" + Codelist + ")  ");
            int rows = DbHelperOleDb.ExecuteSql(strSql.ToString());
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
        public Dong.Model.GoodsInfo GetModel(string Code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Code,GoodName,Category,CategoryName,Unit,UnitName,Factory,Supplier,SupplierName,Price0,Price1,Price2,Counts from GoodsInfo ");
            strSql.Append(" where Code=@Code ");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Code", OleDbType.VarChar,50)			};
            parameters[0].Value = Code;

            Dong.Model.GoodsInfo model = new Dong.Model.GoodsInfo();
            DataSet ds = DbHelperOleDb.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Dong.Model.GoodsInfo GetModelById(int id)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Code,GoodName,Category,CategoryName,Unit,UnitName,Factory,Supplier,SupplierName,Price0,Price1,Price2,Counts from GoodsInfo ");
            strSql.Append(" where Id=@Id");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.Integer,4)
			};
            parameters[0].Value = id;

            Dong.Model.GoodsInfo model = new Dong.Model.GoodsInfo();
            DataSet ds = DbHelperOleDb.Query(strSql.ToString(), parameters);
            if (ds.Tables[0].Rows.Count > 0)
            {
                return DataRowToModel(ds.Tables[0].Rows[0]);
            }
            else
            {
                return null;
            }
        }
        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Dong.Model.GoodsInfo DataRowToModel(DataRow row)
        {
            Dong.Model.GoodsInfo model = new Dong.Model.GoodsInfo();
            if (row != null)
            {
                if (row["Id"] != null && row["Id"].ToString() != "")
                {
                    model.Id = int.Parse(row["Id"].ToString());
                }
                if (row["Code"] != null)
                {
                    model.Code = row["Code"].ToString();
                }
                if (row["GoodName"] != null)
                {
                    model.GoodsName = row["GoodName"].ToString();
                }
                if (row["Category"] != null && row["Category"].ToString() != "")
                {
                    model.Category = int.Parse(row["Category"].ToString());
                }
                if (row["CategoryName"] != null)
                {
                    model.CategoryName = row["CategoryName"].ToString();
                }
                if (row["Unit"] != null && row["Unit"].ToString() != "")
                {
                    model.Unit = int.Parse(row["Unit"].ToString());
                }
                if (row["UnitName"] != null)
                {
                    model.UnitName = row["UnitName"].ToString();
                }
                if (row["Factory"] != null)
                {
                    model.Factory = row["Factory"].ToString();
                }
                if (row["Supplier"] != null && row["Supplier"].ToString() != "")
                {
                    model.Supplier = int.Parse(row["Supplier"].ToString());
                }
                if (row["SupplierName"] != null)
                {
                    model.SupplierName = row["SupplierName"].ToString();
                }
                if (row["Price0"] != null && row["Price0"].ToString() != "")
                {
                    model.Price0 = double.Parse(row["Price0"].ToString());
                }
                if (row["Price1"] != null && row["Price1"].ToString() != "")
                {
                    model.Price1 = double.Parse(row["Price1"].ToString());
                }
                if (row["Price2"] != null && row["Price2"].ToString() != "")
                {
                    model.Price2 = double.Parse(row["Price2"].ToString());
                }
                if (row["Counts"] != null && row["Counts"].ToString() != "")
                {
                    model.Counts = int.Parse(row["Counts"].ToString());
                }
            }
            return model;
        }

        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetList(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,Code,GoodName,Category,CategoryName,Unit,UnitName,Factory,Supplier,SupplierName,Price0,Price1,Price2,Counts ");
            strSql.Append(" FROM GoodsInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where " + strWhere);
            }
            return DbHelperOleDb.Query(strSql.ToString());
        }

        /// <summary>
        /// 获取记录总数
        /// </summary>
        public int GetRecordCount(string strWhere)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) FROM GoodsInfo ");
            if (strWhere.Trim() != "")
            {
                strSql.Append(" where 1=1 " + strWhere);
            }
            object obj = DbHelperOleDb.GetSingle(strSql.ToString());
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
                strSql.Append("order by T.Code desc");
            }
            strSql.Append(")AS Row, T.*  from GoodsInfo T ");
            if (!string.IsNullOrEmpty(strWhere.Trim()))
            {
                strSql.Append(" WHERE " + strWhere);
            }
            strSql.Append(" ) TT");
            strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
            return DbHelperOleDb.Query(strSql.ToString());
        }

        /*
        /// <summary>
        /// 分页获取数据列表
        /// </summary>
        public DataSet GetList(int PageSize,int PageIndex,string strWhere)
        {
            OleDbParameter[] parameters = {
                    new OleDbParameter("@tblName", OleDbType.VarChar, 255),
                    new OleDbParameter("@fldName", OleDbType.VarChar, 255),
                    new OleDbParameter("@PageSize", OleDbType.Integer),
                    new OleDbParameter("@PageIndex", OleDbType.Integer),
                    new OleDbParameter("@IsReCount", OleDbType.Boolean),
                    new OleDbParameter("@OrderType", OleDbType.Boolean),
                    new OleDbParameter("@strWhere", OleDbType.VarChar,1000),
                    };
            parameters[0].Value = "GoodsInfo";
            parameters[1].Value = "Code";
            parameters[2].Value = PageSize;
            parameters[3].Value = PageIndex;
            parameters[4].Value = 0;
            parameters[5].Value = 0;
            parameters[6].Value = strWhere;	
            return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
        }*/

        #endregion  BasicMethod
        #region  ExtensionMethod
        public bool UpdateCount(int counts, string code)
        {
            string strSql = "update GoodsInfo set Counts=Counts-" + counts + " where Code='" + code + "'";
            int rowsAffected = DbHelperOleDb.ExecuteSql(strSql);
            if (rowsAffected > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        #endregion  ExtensionMethod
    }
}

