/**  版本信息模板在安装目录下，可自行修改。
* SaleInfo.cs
*
* 功 能： N/A
* 类 名： SaleInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-11-13 9:40:42   N/A    初版
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
	/// SaleInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class SaleInfo
	{
		public SaleInfo()
		{}
		#region Model
		private int _id;
		private string _pid;
		private string _goodscode;
		private int? _counts=0;
		private double? _price=0;
        private double? _pricesum = 0;
        private string _vipcode;
		private DateTime? _idate;
		private string _oper;
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
		public string Pid
		{
			set{ _pid=value;}
			get{return _pid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string GoodsCode
		{
			set{ _goodscode=value;}
			get{return _goodscode;}
		}
        public string VipCode
        {
            set { _vipcode = value; }
            get { return _vipcode; }
        }
		/// <summary>
		/// 
		/// </summary>
		public int? Counts
		{
			set{ _counts=value;}
			get{return _counts;}
		}
		/// <summary>
		/// 
		/// </summary>
        public double? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
        public double? PriceSum
        {
            set { _pricesum = value; }
            get { return _pricesum; }
        }
		/// <summary>
		/// 
		/// </summary>
		public DateTime? IDate
		{
			set{ _idate=value;}
			get{return _idate;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Oper
		{
			set{ _oper=value;}
			get{return _oper;}
		}
		#endregion Model

	}
}

