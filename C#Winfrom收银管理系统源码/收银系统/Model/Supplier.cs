/**  版本信息模板在安装目录下，可自行修改。
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
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
namespace Dong.Model
{
	/// <summary>
	/// Supplier:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class Supplier
	{
		public Supplier()
		{}
		#region Model
		private int _id;
		private string _name;
		private string _addr;
		private string _contact;
		private string _phone;
		private string _code;
		private string _account;
		private string _bank;
		private string _oper;
		private DateTime? _operdate;
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
		public string Name
		{
			set{ _name=value;}
			get{return _name;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Addr
		{
			set{ _addr=value;}
			get{return _addr;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Contact
		{
			set{ _contact=value;}
			get{return _contact;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Phone
		{
			set{ _phone=value;}
			get{return _phone;}
		}
		/// <summary>
		/// 税号
		/// </summary>
		public string Code
		{
			set{ _code=value;}
			get{return _code;}
		}
		/// <summary>
		/// 银行帐号
		/// </summary>
		public string Account
		{
			set{ _account=value;}
			get{return _account;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Bank
		{
			set{ _bank=value;}
			get{return _bank;}
		}
		/// <summary>
        /// 操作人
		/// </summary>
		public string Oper
		{
			set{ _oper=value;}
			get{return _oper;}
		}
		/// <summary>
        /// 操作时间
		/// </summary>
		public DateTime? OperDate
		{
			set{ _operdate=value;}
			get{return _operdate;}
		}
		#endregion Model

	}
}

