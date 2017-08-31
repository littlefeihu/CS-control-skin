/**  版本信息模板在安装目录下，可自行修改。
* GoodsInfo.cs
*
* 功 能： N/A
* 类 名： GoodsInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-11-20 22:50:30   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Dong.Model
{
	/// <summary>
	/// GoodsInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class GoodsInfo
	{
		public GoodsInfo()
		{}
		#region Model
		private int _id;
		private string _code;
        private string _goodsname;
		private int? _category=0;
		private string _categoryname;
		private int? _unit=0;
		private string _unitname;
		private string _factory;
		private int? _supplier=0;
		private string _suppliername;
		private double? _price0=0;
		private double? _price1=0;
		private double? _price2=0;
		private int? _counts=0;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
        public string GoodsName
        {
            set { _goodsname = value; }
            get { return _goodsname; }
        }
		/// <summary>
		/// 
		/// </summary>
		public int? Category
		{
			set{ _category=value;}
			get{return _category;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CategoryName
		{
			set{ _categoryname=value;}
			get{return _categoryname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Unit
		{
			set{ _unit=value;}
			get{return _unit;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string UnitName
		{
			set{ _unitname=value;}
			get{return _unitname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Factory
		{
			set{ _factory=value;}
			get{return _factory;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Supplier
		{
			set{ _supplier=value;}
			get{return _supplier;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SupplierName
		{
			set{ _suppliername=value;}
			get{return _suppliername;}
		}
		/// <summary>
		/// 零售价
		/// </summary>
		public double? Price0
		{
			set{ _price0=value;}
			get{return _price0;}
		}
		/// <summary>
		/// 进货价
		/// </summary>
		public double? Price1
		{
			set{ _price1=value;}
			get{return _price1;}
		}
		/// <summary>
		/// 成本价
		/// </summary>
		public double? Price2
		{
			set{ _price2=value;}
			get{return _price2;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? Counts
		{
			set{ _counts=value;}
			get{return _counts;}
		}
		#endregion Model

	}
}

