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
using System.Collections.Generic;
using Dong.Model;
namespace Dong.BLL
{
	/// <summary>
	/// MemberInfo
	/// </summary>
	public partial class MemberInfo
	{
		private readonly Dong.DAL.MemberInfo dal=new Dong.DAL.MemberInfo();
		public MemberInfo()
		{}
		#region  BasicMethod

		/// <summary>
		/// 得到最大ID
		/// </summary>
		public int GetMaxId()
		{
			return dal.GetMaxId();
		}

		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(int Id)
		{
			return dal.Exists(Id);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Dong.Model.MemberInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Dong.Model.MemberInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int Id)
		{
			
			return dal.Delete(Id);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Idlist )
		{
			return dal.DeleteList(Idlist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Dong.Model.MemberInfo GetModel(int Id)
		{
			
			return dal.GetModel(Id);
		}

        public Dong.Model.MemberInfo GetModel(string Code)
        {
            return dal.GetModel(Code);
        }

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			return dal.GetList(strWhere);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Dong.Model.MemberInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Dong.Model.MemberInfo> DataTableToList(DataTable dt)
		{
			List<Dong.Model.MemberInfo> modelList = new List<Dong.Model.MemberInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Dong.Model.MemberInfo model;
				for (int n = 0; n < rowsCount; n++)
				{
					model = dal.DataRowToModel(dt.Rows[n]);
					if (model != null)
					{
						modelList.Add(model);
					}
				}
			}
			return modelList;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetAllList()
		{
			return GetList("");
		}

		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			return dal.GetRecordCount(strWhere);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			return dal.GetListByPage( strWhere,  orderby,  startIndex,  endIndex);
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		//public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		//{
			//return dal.GetList(PageSize,PageIndex,strWhere);
		//}

		#endregion  BasicMethod
		#region  ExtensionMethod

        public DataSet GetListPage(string strWhere, int pageSize, int page)
        {
            DataSet ds = new DataSet();
            string strSql = "";
            if (strWhere != "")
            {
                strSql = "select top " + pageSize + " * from MemberInfo where id >=(select top 1 max(id) from (select top " + (((page - 1) * pageSize) + 1).ToString() + " * from MemberInfo where " + strWhere + " order by id)) and " + strWhere;
            }
            else
            {
                strSql = "select top " + pageSize + " * from MemberInfo where id >=(select top 1 max(id) from (select top " + (((page - 1) * pageSize) + 1).ToString() + " * from MemberInfo order by id)) order by id";

            }
            ds = Maticsoft.DBUtility.DbHelperOleDb.Query(strSql);
            return ds;
        }


        /// <summary>
        /// 获得数据列表
        /// </summary>
        public DataSet GetListN(string strWhere, int pageSize, int page)
        {
            DataSet ds = new DataSet();
            ds = GetListPage(strWhere, pageSize, page);
            ds.Tables[0].Columns["Id"].ColumnName = "编号";
            ds.Tables[0].Columns["IdCode"].ColumnName = "会员卡号";
            ds.Tables[0].Columns["UserName"].ColumnName = "姓名";
            ds.Tables[0].Columns["Stime"].ColumnName = "开始时间";
            ds.Tables[0].Columns["Etime"].ColumnName = "结束时间";
            ds.Tables[0].Columns["Email"].ColumnName = "Email";
            ds.Tables[0].Columns["Addr"].ColumnName = "地址";
            ds.Tables[0].Columns["Birthday"].ColumnName = "生日";
            ds.Tables[0].Columns["Discount"].ColumnName = "折扣";
            ds.Tables[0].Columns["iMoney"].ColumnName = "消费金额";
            ds.Tables[0].Columns["Oper"].ColumnName = "添加人";
            ds.Tables[0].Columns["OperDate"].ColumnName = "添加时间";
            return ds;
        }
		#endregion  ExtensionMethod
	}
}

