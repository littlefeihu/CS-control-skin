/**  版本信息模板在安装目录下，可自行修改。
* MemberInfo.cs
*
* 功 能： N/A
* 类 名： MemberInfo
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2013-11-13 9:40:39   N/A    初版
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
	/// MemberInfo:实体类(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public partial class MemberInfo
	{
		public MemberInfo()
		{}
		#region Model
		private int _id;
		private string _idcode;
		private string _name;
		private DateTime? _stime;
		private DateTime? _etime;
		private string _email;
		private string _addr;
		private DateTime? _birthday;
		private double _discount=0;
		private double? _money=0;
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
		public string IdCode
		{
			set{ _idcode=value;}
			get{return _idcode;}
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
		public DateTime? Stime
		{
			set{ _stime=value;}
			get{return _stime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? Etime
		{
			set{ _etime=value;}
			get{return _etime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Email
		{
			set{ _email=value;}
			get{return _email;}
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
		public DateTime? Birthday
		{
			set{ _birthday=value;}
			get{return _birthday;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double Discount
		{
			set{ _discount=value;}
			get{return _discount;}
		}
		/// <summary>
		/// 
		/// </summary>
		public double? Money
		{
			set{ _money=value;}
			get{return _money;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Oper
		{
			set{ _oper=value;}
			get{return _oper;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? OperDate
		{
			set{ _operdate=value;}
			get{return _operdate;}
		}
		#endregion Model

	}
}

