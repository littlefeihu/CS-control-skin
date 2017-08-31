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
using System.Collections.Generic;
using Dong.Model;
namespace Dong.BLL
{
	/// <summary>
	/// OperInfo
	/// </summary>
	public partial class OperInfo
	{
		private readonly Dong.DAL.OperInfo dal=new Dong.DAL.OperInfo();
		public OperInfo()
		{}
		#region  BasicMethod
		/// <summary>
		/// 是否存在该记录
		/// </summary>
		public bool Exists(string Code)
		{
			return dal.Exists(Code);
		}

		/// <summary>
		/// 增加一条数据
		/// </summary>
		public bool Add(Dong.Model.OperInfo model)
		{
			return dal.Add(model);
		}

		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Dong.Model.OperInfo model)
		{
			return dal.Update(model);
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(string Code)
		{
			
			return dal.Delete(Code);
		}
		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool DeleteList(string Codelist )
		{
			return dal.DeleteList(Codelist );
		}

		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Dong.Model.OperInfo GetModel(string Code)
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
		public List<Dong.Model.OperInfo> GetModelList(string strWhere)
		{
			DataSet ds = dal.GetList(strWhere);
			return DataTableToList(ds.Tables[0]);
		}
		/// <summary>
		/// 获得数据列表
		/// </summary>
		public List<Dong.Model.OperInfo> DataTableToList(DataTable dt)
		{
			List<Dong.Model.OperInfo> modelList = new List<Dong.Model.OperInfo>();
			int rowsCount = dt.Rows.Count;
			if (rowsCount > 0)
			{
				Dong.Model.OperInfo model;
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
        /// <summary>
        /// 验证用户登录
        /// </summary>
        /// <param name="Userid"></param>
        /// <param name="Pwd"></param>
        /// <returns></returns>
        public bool CheckUser(string Userid, string Pwd)
        {
            Model.OperInfo mOper = new Model.OperInfo();
            mOper = this.GetModel(Userid);
            if (mOper == null)
            {
                return false;
            }
            if (Pwd != mOper.Pwd)
            {
                return false;
            }
            Dong.Model.GlobalsInfo.userflag = int.Parse(mOper.Role.ToString());
            return true;
        }


        public DataSet GetListPage(string strWhere, int pageSize, int page)
        {
            DataSet ds = new DataSet();
            string strSql = "";
            if (strWhere != "")
            {
                strSql = "select top " + pageSize + " * from OperInfo where id >=(select top 1 max(id) from (select top " + (((page - 1) * pageSize) + 1).ToString() + " * from OperInfo where " + strWhere + " order by id)) and " + strWhere;
            }
            else
            {
                strSql = "select top " + pageSize + " * from OperInfo where id >=(select top 1 max(id) from (select top " + (((page - 1) * pageSize) + 1).ToString() + " * from OperInfo order by id)) order by id";

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
            ds.Tables[0].Columns["Code"].ColumnName = "工号";
            ds.Tables[0].Columns["Pwd"].ColumnName = "密码";
            ds.Tables[0].Columns["Name"].ColumnName = "姓名";
            ds.Tables[0].Columns["Sex"].ColumnName = "性别";
            ds.Tables[0].Columns["Cid"].ColumnName = "身份证";
            ds.Tables[0].Columns["Phone"].ColumnName = "电话";
            ds.Tables[0].Columns["Role"].ColumnName = "类别";
            //foreach (DataRow item in ds.Tables[0].Rows)
            //{
            //    if (item["类别"].ToString() == "0")
            //    {
            //        item["类别"] = "管理员";
            //    }
            //    else
            //    {
            //        item["类别"] = "收银员";
            //    }
            //}
            return ds;
        }

		#endregion  ExtensionMethod
	}
}

