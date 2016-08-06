using System;
namespace BookShop.Model
{
	/// <summary>
	/// ʵ����Order ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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

