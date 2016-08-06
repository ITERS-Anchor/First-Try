using System;
namespace BookShop.Model
{
	/// <summary>
	/// 实体类WF_Step 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class WF_Step
	{
		public WF_Step()
		{}
		#region Model
		private int _id;
		private DateTime _subtime;
		private DateTime _processtime;
		private int _processby;
		private string _stepname;
		private string _comment;
		private int _flowto;
		private bool _isstart;
		private bool _isend;
		private int _state;
		private int _parentstepid;
		private int _sort;
		private int _wf_instanceid;
		private Guid _instanceid;
		private bool _isprocessed;
		/// <summary>
		/// 
		/// </summary>
		public int ID
		{
			set{ _id=value;}
			get{return _id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime subTime
		{
			set{ _subtime=value;}
			get{return _subtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime ProcessTime
		{
			set{ _processtime=value;}
			get{return _processtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ProcessBy
		{
			set{ _processby=value;}
			get{return _processby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string StepName
		{
			set{ _stepname=value;}
			get{return _stepname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Comment
		{
			set{ _comment=value;}
			get{return _comment;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int FlowTo
		{
			set{ _flowto=value;}
			get{return _flowto;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsStart
		{
			set{ _isstart=value;}
			get{return _isstart;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsEnd
		{
			set{ _isend=value;}
			get{return _isend;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int State
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ParentStepId
		{
			set{ _parentstepid=value;}
			get{return _parentstepid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Sort
		{
			set{ _sort=value;}
			get{return _sort;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int WF_InstanceID
		{
			set{ _wf_instanceid=value;}
			get{return _wf_instanceid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public Guid InstanceId
		{
			set{ _instanceid=value;}
			get{return _instanceid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public bool IsProcessed
		{
			set{ _isprocessed=value;}
			get{return _isprocessed;}
		}
		#endregion Model

	}
}

