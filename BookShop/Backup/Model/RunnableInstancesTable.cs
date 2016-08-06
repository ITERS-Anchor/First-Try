using System;
namespace BookShop.Model
{
	/// <summary>
	/// ʵ����RunnableInstancesTable ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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

