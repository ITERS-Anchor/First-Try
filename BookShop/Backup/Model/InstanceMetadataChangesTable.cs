using System;
namespace BookShop.Model
{
	/// <summary>
	/// 实体类InstanceMetadataChangesTable 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class InstanceMetadataChangesTable
	{
		public InstanceMetadataChangesTable()
		{}
		#region Model
		private long _surrogateinstanceid;
		private long _changetime;
		private int _encodingoption;
		private byte[] _change;
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
		public long ChangeTime
		{
			set{ _changetime=value;}
			get{return _changetime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int EncodingOption
		{
			set{ _encodingoption=value;}
			get{return _encodingoption;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] Change
		{
			set{ _change=value;}
			get{return _change;}
		}
		#endregion Model

	}
}

