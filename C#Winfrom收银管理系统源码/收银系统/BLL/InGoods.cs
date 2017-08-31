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
using System.Collections.Generic;
using Dong.Model;
namespace Dong.BLL
{
	/// <summary>
	/// InGoods
	/// </summary>
	public partial class InGoods
	{
		private readonly Dong.DAL.InGoods dal=new Dong.DAL.InGoods();
		public InGoods()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string PCode)
		{
			return dal.Exists(PCode);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Dong.Model.InGoods model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Dong.Model.InGoods model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string PCode)
		{
			
			return dal.Delete(PCode);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string PCodelist )
		{
			return dal.DeleteList(PCodelist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Dong.Model.InGoods GetModel(string PCode)
		{
			
			return dal.GetModel(PCode);
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
		public List<Dong.Model.InGoods> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Dong.Model.InGoods> DataTableToList(DataTable dt)
		{
			List<Dong.Model.InGoods> modelList = new List<Dong.Model.InGoods>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Dong.Model.InGoods model;
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
                strSql = "select top " + pageSize + " * from v_inGoods where nid >=(select top 1 max(nid) from (select top " + (((page - 1) * pageSize) + 1).ToString() + " * from v_inGoods where  1=1 " + strWhere + " order by nid)) and 1=1 " + strWhere;
            }
            else
            {
                strSql = "select top " + pageSize + " * from v_inGoods where nid >=(select top 1 max(nid) from (select top " + (((page - 1) * pageSize) + 1).ToString() + " * from v_inGoods order by nid)) order by nid";
            }
            ds = Maticsoft.DBUtility.DbHelperOleDb.Query(strSql);
            return ds;
        }

        public DataSet getDetial(string Pid)
        {
            DataSet ds = new DataSet();
            ds = Maticsoft.DBUtility.DbHelperOleDb.Query("select * from v_inGoodsDetial where Pcode='" + Pid + "'");
            return ds;
        }
		#endregion  ExtensionMethod
	}
}

