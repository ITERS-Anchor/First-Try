using System;
namespace BookShop.Model
{
	/// <summary>
	/// 实体类RunnableInstancesTable 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class RunnableInstancesTable
	{
		public RunnableInstancesTable()
		{}
		#region Model
		private long _surrogateinstanceid;
		private uniqueidentifier _workflowhosttype;
		private long _servicedeploymentid;
		private DateTime _runnabletime;
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
		public DateTime RunnableTime
		{
			set{ _runnabletime=value;}
			get{return _runnabletime;}
		}
		#endregion Model

	}
}

