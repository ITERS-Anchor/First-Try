using System;
namespace BookShop.Model
{
	/// <summary>
	/// 实体类WF_Instance 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class WF_Instance
	{
		public WF_Instance()
		{}
		#region Model
		private int _id;
		private string _title;
		private int _subby;
		private DateTime _subtime;
		private DateTime _outtime;
		private int _state;
		private int _result;
		private string _content;
		private int _level;
		private int _wf_tempid;
		private uniqueidentifier _instanceid;
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
		public string Title
		{
			set{ _title=value;}
			get{return _title;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int SubBy
		{
			set{ _subby=value;}
			get{return _subby;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime SubTime
		{
			set{ _subtime=value;}
			get{return _subtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public DateTime OutTime
		{
			set{ _outtime=value;}
			get{return _outtime;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int state
		{
			set{ _state=value;}
			get{return _state;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Result
		{
			set{ _result=value;}
			get{return _result;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Content
		{
			set{ _content=value;}
			get{return _content;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Level
		{
			set{ _level=value;}
			get{return _level;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int WF_TempID
		{
			set{ _wf_tempid=value;}
			get{return _wf_tempid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public uniqueidentifier InstanceId
		{
			set{ _instanceid=value;}
			get{return _instanceid;}
		}
		#endregion Model

	}
}

