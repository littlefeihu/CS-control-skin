/**  版本信息模板在安装目录下，可自行修改。
* MemberInfo.cs
*
* 功 能： N/A
* 类 名： MemberInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-11-13 9:40:40   N/A    初版
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
	/// 数据访问类:MemberInfo
	/// </summary>
	public partial class MemberInfo
	{
		public MemberInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
		return DbHelperOleDb.GetMaxID("Id", "MemberInfo"); 
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) from MemberInfo");
			strSql.Append(" where Id=" + Id.ToString());
			

			return DbHelperOleDb.Exists(strSql.ToString());
		}


		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Dong.Model.MemberInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into MemberInfo(");
			strSql.Append("IdCode,UserName,Stime,Etime,Email,Addr,Birthday,Discount,iMoney,Oper,OperDate)");
			strSql.Append(" values (");
            strSql.Append("@IdCode,@UserName,@Stime,@Etime,@Email,@Addr,@Birthday,@Discount,@Money,@Oper,@OperDate)");
			OleDbParameter[] parameters = {
					new OleDbParameter("@IdCode", OleDbType.VarChar,50),
					new OleDbParameter("@UserName", OleDbType.VarChar,50),
					new OleDbParameter("@Stime", OleDbType.Date),
					new OleDbParameter("@Etime", OleDbType.Date),
					new OleDbParameter("@Email", OleDbType.VarChar,50),
					new OleDbParameter("@Addr", OleDbType.VarChar,200),
					new OleDbParameter("@Birthday", OleDbType.Date),
					new OleDbParameter("@Discount", OleDbType.Double),
					new OleDbParameter("@iMoney", OleDbType.Double),
					new OleDbParameter("@Oper", OleDbType.VarChar,50),
					new OleDbParameter("@OperDate", OleDbType.Date)};
			parameters[0].Value = model.IdCode;
            parameters[1].Value = model.Name;
            parameters[2].Value = model.Stime;
            parameters[3].Value = model.Etime;
            parameters[4].Value = model.Email;
            parameters[5].Value = model.Addr;
            parameters[6].Value = model.Birthday;
            parameters[7].Value = model.Discount;
            parameters[8].Value = model.Money;
            parameters[9].Value = model.Oper;
            parameters[10].Value = model.OperDate;

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
		public bool Update(Dong.Model.MemberInfo model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update MemberInfo set ");
			strSql.Append("IdCode=@IdCode,");
            strSql.Append("UserName=@UserName,");
			strSql.Append("Stime=@Stime,");
			strSql.Append("Etime=@Etime,");
			strSql.Append("Email=@Email,");
			strSql.Append("Addr=@Addr,");
			strSql.Append("Birthday=@Birthday,");
			strSql.Append("Discount=@Discount,");
            strSql.Append("iMoney=@iMoney,");
			strSql.Append("Oper=@Oper,");
			strSql.Append("OperDate=@OperDate");
			strSql.Append(" where Id=@Id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@IdCode", OleDbType.VarChar,50),
					new OleDbParameter("@UserName", OleDbType.VarChar,50),
					new OleDbParameter("@Stime", OleDbType.Date),
					new OleDbParameter("@Etime", OleDbType.Date),
					new OleDbParameter("@Email", OleDbType.VarChar,50),
					new OleDbParameter("@Addr", OleDbType.VarChar,200),
					new OleDbParameter("@Birthday", OleDbType.Date),
					new OleDbParameter("@Discount", OleDbType.Double),
					new OleDbParameter("@iMoney", OleDbType.Double),
					new OleDbParameter("@Oper", OleDbType.VarChar,50),
					new OleDbParameter("@OperDate", OleDbType.Date),
					new OleDbParameter("@Id", OleDbType.Integer,4)};
			parameters[0].Value = model.IdCode;
			parameters[1].Value = model.Name;
			parameters[2].Value = model.Stime;
			parameters[3].Value = model.Etime;
			parameters[4].Value = model.Email;
			parameters[5].Value = model.Addr;
			parameters[6].Value = model.Birthday;
			parameters[7].Value = model.Discount;
			parameters[8].Value = model.Money;
			parameters[9].Value = model.Oper;
			parameters[10].Value = model.OperDate;
			parameters[11].Value = model.Id;

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
			strSql.Append("delete from MemberInfo ");
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
			strSql.Append("delete from MemberInfo ");
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
		public Dong.Model.MemberInfo GetModel(int Id)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select Id,IdCode,UserName,Stime,Etime,Email,Addr,Birthday,Discount,iMoney,Oper,OperDate from MemberInfo ");
			strSql.Append(" where Id=@Id");
			OleDbParameter[] parameters = {
					new OleDbParameter("@Id", OleDbType.Integer,4)
			};
			parameters[0].Value = Id;

			Dong.Model.MemberInfo model=new Dong.Model.MemberInfo();
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
        public Dong.Model.MemberInfo GetModel(string Code)
        {

            StringBuilder strSql = new StringBuilder();
            strSql.Append("select Id,IdCode,UserName,Stime,Etime,Email,Addr,Birthday,Discount,iMoney,Oper,OperDate from MemberInfo ");
            strSql.Append(" where IdCode=@IdCode");
            OleDbParameter[] parameters = {
					new OleDbParameter("@IdCode", OleDbType.VarChar,50)
			};
            parameters[0].Value = Code;

            Dong.Model.MemberInfo model = new Dong.Model.MemberInfo();
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
		public Dong.Model.MemberInfo DataRowToModel(DataRow row)
		{
			Dong.Model.MemberInfo model=new Dong.Model.MemberInfo();
			if (row != null)
			{
				if(row["Id"]!=null && row["Id"].ToString()!="")
				{
					model.Id=int.Parse(row["Id"].ToString());
				}
				if(row["IdCode"]!=null)
				{
					model.IdCode=row["IdCode"].ToString();
				}
                if (row["UserName"] != null)
				{
                    model.Name = row["UserName"].ToString();
				}
				if(row["Stime"]!=null && row["Stime"].ToString()!="")
				{
					model.Stime=DateTime.Parse(row["Stime"].ToString());
				}
				if(row["Etime"]!=null && row["Etime"].ToString()!="")
				{
					model.Etime=DateTime.Parse(row["Etime"].ToString());
				}
				if(row["Email"]!=null)
				{
					model.Email=row["Email"].ToString();
				}
				if(row["Addr"]!=null)
				{
					model.Addr=row["Addr"].ToString();
				}
				if(row["Birthday"]!=null && row["Birthday"].ToString()!="")
				{
					model.Birthday=DateTime.Parse(row["Birthday"].ToString());
				}
                if (row["Discount"] != null && row["Discount"].ToString() != "")
                {
                    model.Discount = double.Parse(row["Discount"].ToString());
                }
					//model.Discount=row["Discount"].ToString();
					//model.Money=row["Money"].ToString();
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
            strSql.Append("select Id,IdCode,UserName,Stime,Etime,Email,Addr,Birthday,Discount,iMoney,Oper,OperDate ");
			strSql.Append(" FROM MemberInfo ");
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
			strSql.Append("select count(1) FROM MemberInfo ");
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
			strSql.Append(")AS Row, T.*  from MemberInfo T ");
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
			parameters[0].Value = "MemberInfo";
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

