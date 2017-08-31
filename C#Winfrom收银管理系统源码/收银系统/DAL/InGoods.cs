/**  版本信息模板在安装目录下，可自行修改。
* InGoods.cs
*
* 功 能： N/A
* 类 名： InGoods
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-11-13 9:40:38   N/A    初版
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
	/// 数据访问类:InGoods
	/// </summary>
	public partial class InGoods
	{
		public InGoods()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
        public bool Exists(string PCode)
        {
            StringBuilder strSql = new StringBuilder();
            strSql.Append("select count(1) from InGoods");
            strSql.Append(" where PCode='" + PCode + "'");


            return DbHelperOleDb.Exists(strSql.ToString());
        }

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Dong.Model.InGoods model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into InGoods(");
			strSql.Append("PCode,GoodsCode,Price,Counts,IDate,Supplier,Oper,Remark)");
			strSql.Append(" values (");
			strSql.Append("@PCode,@GoodsCode,@Price,@Counts,@IDate,@Supplier,@Oper,@Remark)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@PCode", OleDbType.VarChar,50),
					new OleDbParameter("@GoodsCode", OleDbType.VarChar,50),
					new OleDbParameter("@Price", OleDbType.Double),
					new OleDbParameter("@Counts", OleDbType.Integer,4),
					new OleDbParameter("@IDate", OleDbType.Date),
					new OleDbParameter("@Supplier", OleDbType.Integer,4),
					new OleDbParameter("@Oper", OleDbType.VarChar,50),
					new OleDbParameter("@Remark", OleDbType.VarChar,0)};
			parameters[0].Value = model.PCode;
			parameters[1].Value = model.GoodsCode;
			parameters[2].Value = model.Price;
			parameters[3].Value = model.Counts;
			parameters[4].Value = model.IDate;
			parameters[5].Value = model.Supplier;
			parameters[6].Value = model.Oper;
			parameters[7].Value = model.Remark;

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
		public bool Update(Dong.Model.InGoods model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update InGoods set ");
			strSql.Append("GoodsCode=@GoodsCode,");
			strSql.Append("Price=@Price,");
			strSql.Append("Counts=@Counts,");
			strSql.Append("IDate=@IDate,");
			strSql.Append("Supplier=@Supplier,");
			strSql.Append("Oper=@Oper,");
			strSql.Append("Remark=@Remark");
			strSql.Append(" where PCode=@PCode ");
			OleDbParameter[] parameters = {
					new OleDbParameter("@GoodsCode", OleDbType.VarChar,50),
					new OleDbParameter("@Price", OleDbType.Double),
					new OleDbParameter("@Counts", OleDbType.Integer,4),
					new OleDbParameter("@IDate", OleDbType.Date),
					new OleDbParameter("@Supplier", OleDbType.Integer,4),
					new OleDbParameter("@Oper", OleDbType.VarChar,50),
					new OleDbParameter("@Remark", OleDbType.VarChar,0),
					new OleDbParameter("@PCode", OleDbType.VarChar,50)};
			parameters[0].Value = model.GoodsCode;
			parameters[1].Value = model.Price;
			parameters[2].Value = model.Counts;
			parameters[3].Value = model.IDate;
			parameters[4].Value = model.Supplier;
			parameters[5].Value = model.Oper;
			parameters[6].Value = model.Remark;
			parameters[7].Value = model.PCode;

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
		public bool Delete(string PCode)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InGoods ");
			strSql.Append(" where PCode=@PCode ");
			OleDbParameter[] parameters = {
					new OleDbParameter("@PCode", OleDbType.VarChar,50)			};
			parameters[0].Value = PCode;

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
		public bool DeleteList(string PCodelist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from InGoods ");
			strSql.Append(" where PCode in ("+PCodelist + ")  ");
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
		public Dong.Model.InGoods GetModel(string PCode)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,PCode,GoodsCode,Price,Counts,IDate,Supplier,Oper,Remark from InGoods ");
			strSql.Append(" where PCode=@PCode ");
			OleDbParameter[] parameters = {
					new OleDbParameter("@PCode", OleDbType.VarChar,50)			};
			parameters[0].Value = PCode;

			Dong.Model.InGoods model=new Dong.Model.InGoods();
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
		public Dong.Model.InGoods DataRowToModel(DataRow row)
		{
			Dong.Model.InGoods model=new Dong.Model.InGoods();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["PCode"]!=null)
				{
					model.PCode=row["PCode"].ToString();
				}
				if(row["GoodsCode"]!=null)
				{
					model.GoodsCode=row["GoodsCode"].ToString();
				}
					//model.Price=row["Price"].ToString();
				if(row["Counts"]!=null && row["Counts"].ToString()!="")
				{
					model.Counts=int.Parse(row["Counts"].ToString());
				}
				if(row["IDate"]!=null && row["IDate"].ToString()!="")
				{
					model.IDate=DateTime.Parse(row["IDate"].ToString());
				}
				if(row["Supplier"]!=null && row["Supplier"].ToString()!="")
				{
					model.Supplier=int.Parse(row["Supplier"].ToString());
				}
				if(row["Oper"]!=null)
				{
					model.Oper=row["Oper"].ToString();
				}
				if(row["Remark"]!=null)
				{
					model.Remark=row["Remark"].ToString();
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
			strSql.Append("select Id,PCode,GoodsCode,Price,Counts,IDate,Supplier,Oper,Remark ");
			strSql.Append(" FROM InGoods ");
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
			strSql.Append("select count(1) FROM InGoods ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
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
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.PCode desc");
			}
			strSql.Append(")AS Row, T.*  from InGoods T ");
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
			parameters[0].Value = "InGoods";
			parameters[1].Value = "PCode";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperOleDb.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

