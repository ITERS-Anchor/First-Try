using System;
namespace BookShop.Model
{
	/// <summary>
	/// 实体类RoleActionGroup 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class RoleActionGroup
	{
		public RoleActionGroup()
		{}
		#region Model
		private int _role_id;
		private int _actiongroup_id;
		/// <summary>
		/// 
		/// </summary>
		public int Role_ID
		{
			set{ _role_id=value;}
			get{return _role_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ActionGroup_ID
		{
			set{ _actiongroup_id=value;}
			get{return _actiongroup_id;}
		}
		#endregion Model

	}
}

