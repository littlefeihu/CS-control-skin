/**  版本信息模板在安装目录下，可自行修改。
* OperInfo.cs
*
* 功 能： N/A
* 类 名： OperInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-11-13 9:40:41   N/A    初版
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
	/// 数据访问类:OperInfo
	/// </summary>
	public partial class OperInfo
	{
		public OperInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Code)
		{
            bool flag = true;
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from OperInfo");
			strSql.Append(" where Code='" + Code + "'");
            DataSet ds = new DataSet();
            ds = DbHelperOleDb.Query(strSql.ToString());
            if (ds.Tables[0].Rows[0][0].ToString() != "0")
            {
                flag = true;
            }
            else
            {
                flag = false;
            }
            return flag;
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Dong.Model.OperInfo model)
		{ 
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into OperInfo(");
			strSql.Append("Code,Pwd,Name,Sex,CId,Phone,Role)");
			strSql.Append(" values (");
			strSql.Append("@Code,@Pwd,@Name,@Sex,@CId,@Phone,@Role)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@Code", OleDbType.VarChar,50),
					new OleDbParameter("@Pwd", OleDbType.VarChar,50),
					new OleDbParameter("@Name", OleDbType.VarChar,50),
					new OleDbParameter("@Sex", OleDbType.VarChar,50),
					new OleDbParameter("@CId", OleDbType.VarChar,50),
					new OleDbParameter("@Phone", OleDbType.VarChar,50),
					new OleDbParameter("@Role", OleDbType.Integer,4)};
			parameters[0].Value = model.Code;
			parameters[1].Value = model.Pwd;
			parameters[2].Value = model.Name;
			parameters[3].Value = model.Sex;
			parameters[4].Value = model.CId;
			parameters[5].Value = model.Phone;
			parameters[6].Value = model.Role;

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
		public bool Update(Dong.Model.OperInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update OperInfo set ");
			strSql.Append("Pwd=@Pwd,");
			strSql.Append("Name=@Name,");
			strSql.Append("Sex=@Sex,");
			strSql.Append("CId=@CId,");
			strSql.Append("Phone=@Phone,");
			strSql.Append("Role=@Role");
			strSql.Append(" where Code=@Code ");
			OleDbParameter[] parameters = {
					new OleDbParameter("@Pwd", OleDbType.VarChar,50),
					new OleDbParameter("@Name", OleDbType.VarChar,50),
					new OleDbParameter("@Sex", OleDbType.VarChar,50),
					new OleDbParameter("@CId", OleDbType.VarChar,50),
					new OleDbParameter("@Phone", OleDbType.VarChar,50),
					new OleDbParameter("@Role", OleDbType.Integer,4),
					new OleDbParameter("@Code", OleDbType.VarChar,50)};
			parameters[0].Value = model.Pwd;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Sex;
			parameters[3].Value = model.CId;
			parameters[4].Value = model.Phone;
			parameters[5].Value = model.Role;
			parameters[6].Value = model.Code;

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
		public bool Delete(string Code)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OperInfo ");
			strSql.Append(" where Code=@Code ");
			OleDbParameter[] parameters = {
					new OleDbParameter("@Code", OleDbType.VarChar,50)			};
			parameters[0].Value = Code;

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
		public bool DeleteList(string Codelist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from OperInfo ");
			strSql.Append(" where Code in ("+Codelist + ")  ");
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
		public Dong.Model.OperInfo GetModel(string Code)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,Code,Pwd,Name,Sex,CId,Phone,Role from OperInfo ");
			strSql.Append(" where Code=@Code ");
			OleDbParameter[] parameters = {
					new OleDbParameter("@Code", OleDbType.VarChar,50)			};
			parameters[0].Value = Code;

			Dong.Model.OperInfo model=new Dong.Model.OperInfo();
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
		public Dong.Model.OperInfo DataRowToModel(DataRow row)
		{
			Dong.Model.OperInfo model=new Dong.Model.OperInfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["Code"]!=null)
				{
					model.Code=row["Code"].ToString();
				}
				if(row["Pwd"]!=null)
				{
					model.Pwd=row["Pwd"].ToString();
				}
				if(row["Name"]!=null)
				{
					model.Name=row["Name"].ToString();
				}
				if(row["Sex"]!=null)
				{
					model.Sex=row["Sex"].ToString();
				}
				if(row["CId"]!=null)
				{
					model.CId=row["CId"].ToString();
				}
				if(row["Phone"]!=null)
				{
					model.Phone=row["Phone"].ToString();
				}
				if(row["Role"]!=null && row["Role"].ToString()!="")
				{
					model.Role=int.Parse(row["Role"].ToString());
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
			strSql.Append("select Id,Code,Pwd,Name,Sex,CId,Phone,Role ");
			strSql.Append(" FROM OperInfo ");
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
			strSql.Append("select count(1) FROM OperInfo ");
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
				strSql.Append("order by T.Code desc");
			}
			strSql.Append(")AS Row, T.*  from OperInfo T ");
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
			parameters[0].Value = "OperInfo";
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

		#endregion  ExtensionMethod
	}
}

