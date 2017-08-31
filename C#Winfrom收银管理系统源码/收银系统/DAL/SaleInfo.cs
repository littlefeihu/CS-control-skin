/**  版本信息模板在安装目录下，可自行修改。
* SaleInfo.cs
*
* 功 能： N/A
* 类 名： SaleInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-11-13 9:40:42   N/A    初版
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
	/// 数据访问类:SaleInfo
	/// </summary>
	public partial class SaleInfo
	{
		public SaleInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Pid)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from SaleInfo");
			strSql.Append(" where Pid='" + Pid + "'");
			

			return DbHelperOleDb.Exists(strSql.ToString());
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Dong.Model.SaleInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into SaleInfo(");
            strSql.Append("Pid,GoodsCode,Counts,Price,PriceSum,VipCode,IDate,Oper)");
			strSql.Append(" values (");
            strSql.Append("@Pid,@GoodsCode,@Counts,@Price,@PriceSum,@VipCode,@IDate,@Oper)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@Pid", OleDbType.VarChar,50),
					new OleDbParameter("@GoodsCode", OleDbType.VarChar,50),
					new OleDbParameter("@Counts", OleDbType.Integer,4),
					new OleDbParameter("@Price", OleDbType.Double,4),
                    new OleDbParameter("@PriceSum", OleDbType.Double,4),
                    new OleDbParameter("@VipCode", OleDbType.VarChar,50),
					new OleDbParameter("@IDate", OleDbType.Date),
					new OleDbParameter("@Oper", OleDbType.VarChar,50)};
			parameters[0].Value = model.Pid;
			parameters[1].Value = model.GoodsCode;
			parameters[2].Value = model.Counts;
			parameters[3].Value = model.Price;
            parameters[4].Value = model.PriceSum;
            parameters[5].Value = model.VipCode;
			parameters[6].Value = model.IDate;
			parameters[7].Value = model.Oper;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Update(Dong.Model.SaleInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update SaleInfo set ");
			strSql.Append("GoodsCode=@GoodsCode,");
			strSql.Append("Counts=@Counts,");
			strSql.Append("Price=@Price,");
			strSql.Append("IDate=@IDate,");
			strSql.Append("Oper=@Oper");
			strSql.Append(" where Pid=@Pid ");
			OleDbParameter[] parameters = {
					new OleDbParameter("@GoodsCode", OleDbType.VarChar,50),
					new OleDbParameter("@Counts", OleDbType.Integer,4),
					new OleDbParameter("@Price", OleDbType.Integer,4),
					new OleDbParameter("@IDate", OleDbType.Date),
					new OleDbParameter("@Oper", OleDbType.VarChar,50),
					new OleDbParameter("@Id", OleDbType.Integer,4),
					new OleDbParameter("@Pid", OleDbType.VarChar,50)};
			parameters[0].Value = model.GoodsCode;
			parameters[1].Value = model.Counts;
			parameters[2].Value = model.Price;
			parameters[3].Value = model.IDate;
			parameters[4].Value = model.Oper;
			parameters[5].Value = model.Id;
			parameters[6].Value = model.Pid;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
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
		public bool Delete(string Pid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SaleInfo ");
			strSql.Append(" where Pid=@Pid ");
			OleDbParameter[] parameters = {
					new OleDbParameter("@Pid", OleDbType.VarChar,50)			};
			parameters[0].Value = Pid;

			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString(),parameters);
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
		public bool DeleteList(string Pidlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from SaleInfo ");
			strSql.Append(" where Pid in ("+Pidlist + ")  ");
			int rows=DbHelperOleDb.ExecuteSql(strSql.ToString());
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
		public Dong.Model.SaleInfo GetModel(string Pid)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,Pid,GoodsCode,Counts,Price,IDate,Oper from SaleInfo ");
			strSql.Append(" where Pid=@Pid ");
			OleDbParameter[] parameters = {
					new OleDbParameter("@Pid", OleDbType.VarChar,50)			};
			parameters[0].Value = Pid;

			Dong.Model.SaleInfo model=new Dong.Model.SaleInfo();
			DataSet ds=DbHelperOleDb.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
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
		public Dong.Model.SaleInfo DataRowToModel(DataRow row)
		{
			Dong.Model.SaleInfo model=new Dong.Model.SaleInfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["Pid"]!=null)
				{
					model.Pid=row["Pid"].ToString();
				}
				if(row["GoodsCode"]!=null)
				{
					model.GoodsCode=row["GoodsCode"].ToString();
				}
				if(row["Counts"]!=null && row["Counts"].ToString()!="")
				{
					model.Counts=int.Parse(row["Counts"].ToString());
				}
				if(row["Price"]!=null && row["Price"].ToString()!="")
				{
                    model.Price = double.Parse(row["Price"].ToString());
				}
                if (row["PriceSum"] != null && row["PriceSum"].ToString() != "")
                {
                    model.Price = double.Parse(row["PriceSum"].ToString());
                }
                if (row["VipCode"] != null && row["VipCode"].ToString() != "")
                {
                    model.VipCode = row["VipCode"].ToString();
                }
				if(row["IDate"]!=null && row["IDate"].ToString()!="")
				{
					model.IDate=DateTime.Parse(row["IDate"].ToString());
				}
				if(row["Oper"]!=null)
				{
					model.Oper=row["Oper"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,Pid,GoodsCode,Counts,Price,IDate,Oper ");
			strSql.Append(" FROM SaleInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperOleDb.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM SaleInfo ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.Pid desc");
			}
			strSql.Append(")AS Row, T.*  from SaleInfo T ");
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
			parameters[0].Value = "SaleInfo";
			parameters[1].Value = "Pid";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod
        /// <summary>
        /// 得到一个最新一个对象
        /// </summary>
        public Dong.Model.SaleInfo GetPreModel(string Oper)
        { 

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select top 1 * from SaleInfo ");
            strSql.Append(" where Oper=@Oper order by id desc");
            OleDbParameter[] parameters = {
					new OleDbParameter("@Oper", OleDbType.VarChar,50)			};
            parameters[0].Value = Oper;

            Dong.Model.SaleInfo model = new Dong.Model.SaleInfo();
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
		#endregion  ExtensionMethod
	}
}

