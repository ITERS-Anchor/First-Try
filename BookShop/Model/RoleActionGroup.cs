using System;
namespace BookShop.Model
{
	/// <summary>
	/// ʵ����RoleActionGroup ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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

