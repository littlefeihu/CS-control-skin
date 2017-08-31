/**  版本信息模板在安装目录下，可自行修改。
* Supplier.cs
*
* 功 能： N/A
* 类 名： Supplier
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-11-13 9:40:45   N/A    初版
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
	/// 数据访问类:Supplier
	/// </summary>
	public partial class Supplier
	{
		public Supplier()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("Id", "Supplier"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from Supplier");
			strSql.Append(" where Id="+ Id.ToString());
			

			return DbHelperOleDb.Exists(strSql.ToString());
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Dong.Model.Supplier model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into Supplier(");
			strSql.Append("Name,Addr,Contact,Phone,Code,Account,Bank,Oper,OperDate)");
			strSql.Append(" values (");
			strSql.Append("@Name,@Addr,@Contact,@Phone,@Code,@Account,@Bank,@Oper,@OperDate)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@Name", OleDbType.VarChar,50),
					new OleDbParameter("@Addr", OleDbType.VarChar,100),
					new OleDbParameter("@Contact", OleDbType.VarChar,50),
					new OleDbParameter("@Phone", OleDbType.VarChar,50),
					new OleDbParameter("@Code", OleDbType.VarChar,50),
					new OleDbParameter("@Account", OleDbType.VarChar,50),
					new OleDbParameter("@Bank", OleDbType.VarChar,50),
					new OleDbParameter("@Oper", OleDbType.VarChar,50),
					new OleDbParameter("@OperDate", OleDbType.Date)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.Addr;
			parameters[2].Value = model.Contact;
			parameters[3].Value = model.Phone;
			parameters[4].Value = model.Code;
			parameters[5].Value = model.Account;
			parameters[6].Value = model.Bank;
			parameters[7].Value = model.Oper;
			parameters[8].Value = model.OperDate;

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
		public bool Update(Dong.Model.Supplier model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update Supplier set ");
			strSql.Append("Name=@Name,");
			strSql.Append("Addr=@Addr,");
			strSql.Append("Contact=@Contact,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Code=@Code,");
			strSql.Append("Account=@Account,");
			strSql.Append("Bank=@Bank,");
			strSql.Append("Oper=@Oper,");
			strSql.Append("OperDate=@OperDate");
			strSql.Append(" where Id=@Id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@Name", OleDbType.VarChar,50),
					new OleDbParameter("@Addr", OleDbType.VarChar,100),
					new OleDbParameter("@Contact", OleDbType.VarChar,50),
					new OleDbParameter("@Phone", OleDbType.VarChar,50),
					new OleDbParameter("@Code", OleDbType.VarChar,50),
					new OleDbParameter("@Account", OleDbType.VarChar,50),
					new OleDbParameter("@Bank", OleDbType.VarChar,50),
					new OleDbParameter("@Oper", OleDbType.VarChar,50),
					new OleDbParameter("@OperDate", OleDbType.Date),
					new OleDbParameter("@Id", OleDbType.Integer,4)};
			parameters[0].Value = model.Name;
			parameters[1].Value = model.Addr;
			parameters[2].Value = model.Contact;
			parameters[3].Value = model.Phone;
			parameters[4].Value = model.Code;
			parameters[5].Value = model.Account;
			parameters[6].Value = model.Bank;
			parameters[7].Value = model.Oper;
			parameters[8].Value = model.OperDate;
			parameters[9].Value = model.Id;

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
		public bool Delete(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Supplier ");
			strSql.Append(" where Id=@Id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.Integer,4)
			};
			parameters[0].Value = Id;

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
		public bool DeleteList(string Idlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from Supplier ");
			strSql.Append(" where Id in ("+Idlist + ")  ");
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
		public Dong.Model.Supplier GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,Name,Addr,Contact,Phone,Code,Account,Bank,Oper,OperDate from Supplier ");
			strSql.Append(" where Id=@Id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.Integer,4)
			};
			parameters[0].Value = Id;

			Dong.Model.Supplier model=new Dong.Model.Supplier();
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
		public Dong.Model.Supplier DataRowToModel(DataRow row)
		{
			Dong.Model.Supplier model=new Dong.Model.Supplier();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Addr"]!=null)
				{
					model.Addr=row["Addr"].ToString();
				}
				if(row["Contact"]!=null)
				{
					model.Contact=row["Contact"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["Code"]!=null)
				{
					model.Code=row["Code"].ToString();
				}
				if(row["Account"]!=null)
				{
					model.Account=row["Account"].ToString();
				}
				if(row["Bank"]!=null)
				{
					model.Bank=row["Bank"].ToString();
				}
				if(row["Oper"]!=null)
				{
					model.Oper=row["Oper"].ToString();
				}
				if(row["OperDate"]!=null && row["OperDate"].ToString()!="")
				{
					model.OperDate=DateTime.Parse(row["OperDate"].ToString());
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
			strSql.Append("select Id,Name,Addr,Contact,Phone,Code,Account,Bank,Oper,OperDate ");
			strSql.Append(" FROM Supplier ");
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
			strSql.Append("select count(1) FROM Supplier ");
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
				strSql.Append("order by T.Id desc");
			}
			strSql.Append(")AS Row, T.*  from Supplier T ");
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
			parameters[0].Value = "Supplier";
			parameters[1].Value = "Id";
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

