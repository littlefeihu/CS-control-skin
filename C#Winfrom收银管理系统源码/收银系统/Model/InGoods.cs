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
namespace Dong.Model
{
	/// <summary>
	/// InGoods:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class InGoods
	{
		public InGoods()
		{}
		#region Model
		private int _id;
		private string _pcode;
		private string _goodscode;
		private double? _price=0;
		private int? _counts=0;
		private DateTime? _idate;
		private int? _supplier=0;
		private string _oper;
		private string _remark;
		/// <summary>
		/// 
		/// </summary>
		public int Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 单号
		/// </summary>
		public string PCode
		{
			set{ _pcode=value;}
			get{return _pcode;}
		}
		/// <summary>
		/// 商品编号
		/// </summary>
		public string GoodsCode
		{
			set{ _goodscode=value;}
			get{return _goodscode;}
		}
		/// <summary>
		/// 价格
		/// </summary>
		public double? Price
		{
			set{ _price=value;}
			get{return _price;}
		}
		/// <summary>
		/// 数量
		/// </summary>
		public int? Counts
		{
			set{ _counts=value;}
			get{return _counts;}
		}
		/// <summary>
		///  进货日期
		/// </summary>
		public DateTime? IDate
		{
			set{ _idate=value;}
			get{return _idate;}
		}
		/// <summary>
		/// 供应商
		/// </summary>
		public int? Supplier
		{
			set{ _supplier=value;}
			get{return _supplier;}
		}
		/// <summary>
		/// 操作者
		/// </summary>
		public string Oper
		{
			set{ _oper=value;}
			get{return _oper;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Remark
		{
			set{ _remark=value;}
			get{return _remark;}
		}
		#endregion Model

	}
}

