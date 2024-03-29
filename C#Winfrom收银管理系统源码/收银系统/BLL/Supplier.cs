﻿/**  版本信息模板在安装目录下，可自行修改。
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
*│　版权所有：安徽享智科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Collections.Generic;
using Dong.Model;
namespace Dong.BLL
{
	/// <summary>
	/// Supplier
	/// </summary>
	public partial class Supplier
	{
		private readonly Dong.DAL.Supplier dal=new Dong.DAL.Supplier();
		public Supplier()
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
		public bool Add(Dong.Model.Supplier model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Dong.Model.Supplier model)
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
		public Dong.Model.Supplier GetModel(int Id)
		{
			
			return dal.GetModel(Id);
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
		public List<Dong.Model.Supplier> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Dong.Model.Supplier> DataTableToList(DataTable dt)
		{
			List<Dong.Model.Supplier> modelList = new List<Dong.Model.Supplier>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Dong.Model.Supplier model;
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
                strSql = "select top " + pageSize + " * from Supplier where id >=(select top 1 max(id) from (select top " + (((page - 1) * pageSize) + 1).ToString() + " * from Supplier where " + strWhere + " order by id)) and " + strWhere;
            }
            else
            {
                strSql = "select top " + pageSize + " * from Supplier where id >=(select top 1 max(id) from (select top " + (((page - 1) * pageSize) + 1).ToString() + " * from Supplier order by id)) order by id";

            }
            ds = Maticsoft.DBUtility.DbHelperOleDb.Query(strSql);
            return ds;
        }
		#endregion  ExtensionMethod
	}
}

