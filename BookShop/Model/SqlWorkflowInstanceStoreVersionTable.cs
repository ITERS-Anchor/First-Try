using System;
namespace BookShop.Model
{
	/// <summary>
	/// ʵ����SqlWorkflowInstanceStoreVersionTable ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class SqlWorkflowInstanceStoreVersionTable
	{
		public SqlWorkflowInstanceStoreVersionTable()
		{}
		#region Model
		private long _major;
		private long _minor;
		private long _build;
		private long _revision;
		private DateTime? _lastupdated;
		/// <summary>
		/// 
		/// </summary>
		public long Major
		{
			set{ _major=value;}
			get{return _major;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long Minor
		{
			set{ _minor=value;}
			get{return _minor;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long Build
		{
			set{ _build=value;}
			get{return _build;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long Revision
		{
			set{ _revision=value;}
			get{return _revision;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LastUpdated
		{
			set{ _lastupdated=value;}
			get{return _lastupdated;}
		}
		#endregion Model

	}
}

