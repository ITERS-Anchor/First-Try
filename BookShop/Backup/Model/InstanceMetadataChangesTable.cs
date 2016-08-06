using System;
namespace BookShop.Model
{
	/// <summary>
	/// ʵ����InstanceMetadataChangesTable ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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

