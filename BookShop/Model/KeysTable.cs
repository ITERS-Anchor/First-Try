using System;
namespace BookShop.Model
{
	/// <summary>
	/// 实体类KeysTable 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class KeysTable
	{
		public KeysTable()
		{}
		#region Model
		private Guid _id;
		private long _surrogatekeyid;
		private long _surrogateinstanceid;
		private int? _encodingoption;
		private byte[] _properties;
		private bool _isassociated;
		/// <summary>
		/// 
		/// </summary>
		public Guid Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long SurrogateKeyId
		{
			set{ _surrogatekeyid=value;}
			get{return _surrogatekeyid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long SurrogateInstanceId
		{
			set{ _surrogateinstanceid=value;}
			get{return _surrogateinstanceid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EncodingOption
		{
			set{ _encodingoption=value;}
			get{return _encodingoption;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] Properties
		{
			set{ _properties=value;}
			get{return _properties;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsAssociated
		{
			set{ _isassociated=value;}
			get{return _isassociated;}
		}
		#endregion Model

	}
}

