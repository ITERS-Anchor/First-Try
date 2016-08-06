using System;
namespace BookShop.Model
{
	/// <summary>
	/// 实体类WF_Temp 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class WF_Temp
	{
		public WF_Temp()
		{}
		#region Model
		private int _id;
		private string _tempname;
		private DateTime _subtime;
		private string _activetype;
		private string _description;
		private string _formtemp;
		private int _state;
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
		public string TempName
		{
			set{ _tempname=value;}
			get{return _tempname;}
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
		public string ActiveType
		{
			set{ _activetype=value;}
			get{return _activetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Description
		{
			set{ _description=value;}
			get{return _description;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FormTemp
		{
			set{ _formtemp=value;}
			get{return _formtemp;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int state
		{
			set{ _state=value;}
			get{return _state;}
		}
		#endregion Model

	}
}

