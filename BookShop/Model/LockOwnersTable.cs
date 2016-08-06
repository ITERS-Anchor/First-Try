using System;
namespace BookShop.Model
{
	/// <summary>
	/// 实体类LockOwnersTable 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class LockOwnersTable
	{
		public LockOwnersTable()
		{}
		#region Model
		private Guid _id;
		private long _surrogatelockownerid;
		private DateTime _lockexpiration;
        private Guid _workflowhosttype;
		private string _machinename;
		private bool _enqueuecommand;
		private bool _deletesinstanceoncompletion;
		private byte[] _primitivelockownerdata;
		private byte[] _complexlockownerdata;
		private byte[] _writeonlyprimitivelockownerdata;
		private byte[] _writeonlycomplexlockownerdata;
		private int? _encodingoption;
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
		public long SurrogateLockOwnerId
		{
			set{ _surrogatelockownerid=value;}
			get{return _surrogatelockownerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime LockExpiration
		{
			set{ _lockexpiration=value;}
			get{return _lockexpiration;}
		}
		/// <summary>
		/// 
		/// </summary>
        public Guid WorkflowHostType
		{
			set{ _workflowhosttype=value;}
			get{return _workflowhosttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string MachineName
		{
			set{ _machinename=value;}
			get{return _machinename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool EnqueueCommand
		{
			set{ _enqueuecommand=value;}
			get{return _enqueuecommand;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool DeletesInstanceOnCompletion
		{
			set{ _deletesinstanceoncompletion=value;}
			get{return _deletesinstanceoncompletion;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] PrimitiveLockOwnerData
		{
			set{ _primitivelockownerdata=value;}
			get{return _primitivelockownerdata;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] ComplexLockOwnerData
		{
			set{ _complexlockownerdata=value;}
			get{return _complexlockownerdata;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] WriteOnlyPrimitiveLockOwnerData
		{
			set{ _writeonlyprimitivelockownerdata=value;}
			get{return _writeonlyprimitivelockownerdata;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] WriteOnlyComplexLockOwnerData
		{
			set{ _writeonlycomplexlockownerdata=value;}
			get{return _writeonlycomplexlockownerdata;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? EncodingOption
		{
			set{ _encodingoption=value;}
			get{return _encodingoption;}
		}
		#endregion Model

	}
}

