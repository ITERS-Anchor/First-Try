using System;
namespace BookShop.Model
{
	/// <summary>
	/// 实体类ServiceDeploymentsTable 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ServiceDeploymentsTable
	{
		public ServiceDeploymentsTable()
		{}
		#region Model
		private long _id;
		private Guid _servicedeploymenthash;
		private string _sitename;
		private string _relativeservicepath;
		private string _relativeapplicationpath;
		private string _servicename;
		private string _servicenamespace;
		/// <summary>
		/// 
		/// </summary>
		public long Id
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
        public Guid ServiceDeploymentHash
		{
			set{ _servicedeploymenthash=value;}
			get{return _servicedeploymenthash;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string SiteName
		{
			set{ _sitename=value;}
			get{return _sitename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RelativeServicePath
		{
			set{ _relativeservicepath=value;}
			get{return _relativeservicepath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string RelativeApplicationPath
		{
			set{ _relativeapplicationpath=value;}
			get{return _relativeapplicationpath;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ServiceName
		{
			set{ _servicename=value;}
			get{return _servicename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string ServiceNamespace
		{
			set{ _servicenamespace=value;}
			get{return _servicenamespace;}
		}
		#endregion Model

	}
}

