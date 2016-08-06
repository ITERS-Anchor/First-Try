using System;
namespace BookShop.Model
{
	/// <summary>
	/// 实体类Department 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class Department
	{
		public Department()
		{}
		#region Model
		private int _id;
		private string _depname;
		private int _roleid;
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
		public string DepName
		{
			set{ _depname=value;}
			get{return _depname;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int RoleID
		{
			set{ _roleid=value;}
			get{return _roleid;}
		}
		#endregion Model

	}
}

