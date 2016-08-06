using System;
namespace BookShop.Model
{
	/// <summary>
	/// 实体类Order 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Order
	{
		public Order()
		{}
		#region Model
		private uniqueidentifier _id;
		private string _ordernum;
		private DateTime _subdatetime;
		private int _customerid;
		/// <summary>
		/// 
		/// </summary>
		public uniqueidentifier ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string OrderNum
		{
			set{ _ordernum=value;}
			get{return _ordernum;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime SubDateTime
		{
			set{ _subdatetime=value;}
			get{return _subdatetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int CustomerID
		{
			set{ _customerid=value;}
			get{return _customerid;}
		}
		#endregion Model

	}
}

