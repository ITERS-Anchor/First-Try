using System;
namespace BookShop.Model
{
	/// <summary>
	/// 实体类Customer 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Customer
	{
		public Customer()
		{}
		#region Model
		private int _id;
		private string _customername;
		private DateTime _regtime;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string CustomerName
		{
			set{ _customername=value;}
			get{return _customername;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime RegTime
		{
			set{ _regtime=value;}
			get{return _regtime;}
		}
		#endregion Model

	}
}

