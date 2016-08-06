using System;
namespace BookShop.Model
{
	/// <summary>
	/// 实体类InstancesTable 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class InstancesTable
	{
		public InstancesTable()
		{}
		#region Model
		private uniqueidentifier _id;
		private long _surrogateinstanceid;
		private long _surrogatelockownerid;
		private byte[] _primitivedataproperties;
		private byte[] _complexdataproperties;
		private byte[] _writeonlyprimitivedataproperties;
		private byte[] _writeonlycomplexdataproperties;
		private byte[] _metadataproperties;
		private int? _dataencodingoption;
		private int? _metadataencodingoption;
		private long _version;
		private DateTime? _pendingtimer;
		private DateTime _creationtime;
		private DateTime? _lastupdated;
		private uniqueidentifier _workflowhosttype;
		private long _servicedeploymentid;
		private string _suspensionexceptionname;
		private string _suspensionreason;
		private string _blockingbookmarks;
		private string _lastmachinerunon;
		private string _executionstatus;
		private bool _isinitialized;
		private bool _issuspended;
		private bool _isreadytorun;
		private bool _iscompleted;
		/// <summary>
		/// 
		/// </summary>
		public uniqueidentifier Id
		{
			set{ _id=value;}
			get{return _id;}
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
		public long SurrogateLockOwnerId
		{
			set{ _surrogatelockownerid=value;}
			get{return _surrogatelockownerid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] PrimitiveDataProperties
		{
			set{ _primitivedataproperties=value;}
			get{return _primitivedataproperties;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] ComplexDataProperties
		{
			set{ _complexdataproperties=value;}
			get{return _complexdataproperties;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] WriteOnlyPrimitiveDataProperties
		{
			set{ _writeonlyprimitivedataproperties=value;}
			get{return _writeonlyprimitivedataproperties;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] WriteOnlyComplexDataProperties
		{
			set{ _writeonlycomplexdataproperties=value;}
			get{return _writeonlycomplexdataproperties;}
		}
		/// <summary>
		/// 
		/// </summary>
		public byte[] MetadataProperties
		{
			set{ _metadataproperties=value;}
			get{return _metadataproperties;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? DataEncodingOption
		{
			set{ _dataencodingoption=value;}
			get{return _dataencodingoption;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int? MetadataEncodingOption
		{
			set{ _metadataencodingoption=value;}
			get{return _metadataencodingoption;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long Version
		{
			set{ _version=value;}
			get{return _version;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? PendingTimer
		{
			set{ _pendingtimer=value;}
			get{return _pendingtimer;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime CreationTime
		{
			set{ _creationtime=value;}
			get{return _creationtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime? LastUpdated
		{
			set{ _lastupdated=value;}
			get{return _lastupdated;}
		}
		/// <summary>
		/// 
		/// </summary>
		public uniqueidentifier WorkflowHostType
		{
			set{ _workflowhosttype=value;}
			get{return _workflowhosttype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public long ServiceDeploymentId
		{
			set{ _servicedeploymentid=value;}
			get{return _servicedeploymentid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SuspensionExceptionName
		{
			set{ _suspensionexceptionname=value;}
			get{return _suspensionexceptionname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SuspensionReason
		{
			set{ _suspensionreason=value;}
			get{return _suspensionreason;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string BlockingBookmarks
		{
			set{ _blockingbookmarks=value;}
			get{return _blockingbookmarks;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string LastMachineRunOn
		{
			set{ _lastmachinerunon=value;}
			get{return _lastmachinerunon;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ExecutionStatus
		{
			set{ _executionstatus=value;}
			get{return _executionstatus;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsInitialized
		{
			set{ _isinitialized=value;}
			get{return _isinitialized;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsSuspended
		{
			set{ _issuspended=value;}
			get{return _issuspended;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsReadyToRun
		{
			set{ _isreadytorun=value;}
			get{return _isreadytorun;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsCompleted
		{
			set{ _iscompleted=value;}
			get{return _iscompleted;}
		}
		#endregion Model

	}
}

