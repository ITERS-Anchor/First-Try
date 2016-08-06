using System;
namespace BookShop.Model
{
	/// <summary>
	/// 实体类ActionGroupActionInfo 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class ActionGroupActionInfo
	{
		public ActionGroupActionInfo()
		{}
		#region Model
		private int _actiongroup_id;
		private int _actioninfo_id;
		/// <summary>
		/// 
		/// </summary>
		public int ActionGroup_ID
		{
			set{ _actiongroup_id=value;}
			get{return _actiongroup_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ActionInfo_ID
		{
			set{ _actioninfo_id=value;}
			get{return _actioninfo_id;}
		}
		#endregion Model

	}
}

