/**  版本信息模板在安装目录下，可自行修改。
* SaleInfo.cs
*
* 功 能： N/A
* 类 名： SaleInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-11-13 9:40:43   N/A    初版
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
    /// SaleInfo
    /// </summary>
    public partial class SaleInfo
    {
        private readonly Dong.DAL.SaleInfo dal = new Dong.DAL.SaleInfo();
        public SaleInfo()
        { }
        #region  BasicMethod
        /// <summary>
        /// 是否存在该记录
        /// </summary>
        public bool Exists(string Pid)
        {
            return dal.Exists(Pid);
        }

        /// <summary>
        /// 增加一条数据
        /// </summary>
        public bool Add(Dong.Model.SaleInfo model)
        {
            return dal.Add(model);
        }

        /// <summary>
        /// 更新一条数据
        /// </summary>
        public bool Update(Dong.Model.SaleInfo model)
        {
            return dal.Update(model);
        }

        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool Delete(string Pid)
        {

            return dal.Delete(Pid);
        }
        /// <summary>
        /// 删除一条数据
        /// </summary>
        public bool DeleteList(string Pidlist)
        {
            return dal.DeleteList(Pidlist);
        }

        /// <summary>
        /// 得到一个对象实体
        /// </summary>
        public Dong.Model.SaleInfo GetModel(string Pid)
        {

            return dal.GetModel(Pid);
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
        public List<Dong.Model.SaleInfo> GetModelList(string strWhere)
        {
            DataSet ds = dal.GetList(strWhere);
            return DataTableToList(ds.Tables[0]);
        }
        /// <summary>
        /// 获得数据列表
        /// </summary>
        public List<Dong.Model.SaleInfo> DataTableToList(DataTable dt)
        {
            List<Dong.Model.SaleInfo> modelList = new List<Dong.Model.SaleInfo>();
            int rowsCount = dt.Rows.Count;
            if (rowsCount > 0)
            {
                Dong.Model.SaleInfo model;
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
            return dal.GetListByPage(strWhere, orderby, startIndex, endIndex);
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
        /// 获得日报表
        /// </summary>
        /// <param name="where"></param>
        /// <returns></returns>
        public DataTable GetDayReport(string where)
        {
            string sql = "SELECT sum(Counts) as Counts1,sum(Price) as Price1,Format(IDate,\"yyyy-mm-dd\")as IDate1 FROM SaleInfo where 1=1 " + where + " group by Format(IDate,\"yyyy-mm-dd\")";
            return Maticsoft.DBUtility.DbHelperOleDb.Query(sql).Tables[0];

        }

        /// <summary>
        /// 得到一个最新一个对象
        /// </summary>
        public Dong.Model.SaleInfo GetPreModel(string Oper)
        {
            return dal.GetPreModel(Oper);
        }

        public DataSet getToday(string userid)
        {
            DataSet ds = new DataSet();
            string strSql = "SELECT pid, priceSum, count(0) AS c, VipCode FROM SaleInfo where Oper='" + userid + "' and Idate>#" + DateTime.Now.Date + "# GROUP BY pid, priceSum, VipCode";
            ds = Maticsoft.DBUtility.DbHelperOleDb.Query(strSql);
            return ds;
        }
        public DataTable getDayRePort(DateTime dt1, DateTime dt2)
        {
            DataTable dt = new DataTable();
            dt = Maticsoft.DBUtility.DbHelperOleDb.Query("SELECT sum(Counts) as Counts1 ,sum(Price) as Price1,sum(SumGain1) as Gain,IdateT AS Idate1 FROM v_Gain where 1=1 and Idate>#" + dt1 + "# and Idate<=#" + dt2 + "# group by IdateT").Tables[0];
            
            return dt;
        }
        public DataTable getMonthRePort(string strYear)
        {
            DateTime dt1 = Convert.ToDateTime(strYear + "-01-01 00:00:00");
            DateTime dt2 = Convert.ToDateTime(strYear + "-12-31 23:59:59");
            DataTable dt = new DataTable();
            dt = Maticsoft.DBUtility.DbHelperOleDb.Query("SELECT sum(Counts) as Counts1 ,sum(Price) as Price1,sum(SumGain1) as Gain,IdateM AS Idate1 FROM v_Gain where 1=1 and Idate>#" + dt1 + "# and Idate<=#" + dt2 + "# group by IdateM").Tables[0];

            return dt;
        }
        public DataSet GetListPage(string strWhere, int pageSize, int page)
        {
            DataSet ds = new DataSet();
            string strSql = "";
            if (strWhere != "")
            {
                strSql = "select top " + pageSize + " * from v_SaleInfoDetail where id >=(select top 1 max(id) from (select top " + (((page - 1) * pageSize) + 1).ToString() + " * from v_SaleInfoDetail where " + strWhere + " order by id)) and " + strWhere;
            }
            else
            {
                strSql = "select top " + pageSize + " * from v_SaleInfoDetail where id >=(select top 1 max(id) from (select top " + (((page - 1) * pageSize) + 1).ToString() + " * from v_SaleInfoDetail order by id)) order by id";

            }
            ds = Maticsoft.DBUtility.DbHelperOleDb.Query(strSql);
            return ds;
        }
        #endregion  ExtensionMethod
    }
}

