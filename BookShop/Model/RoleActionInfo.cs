using System;
namespace BookShop.Model
{
	/// <summary>
	/// ʵ����RoleActionInfo ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class RoleActionInfo
	{
		public RoleActionInfo()
		{}
		#region Model
		private int _role_id;
		private int _actioninfo_id;
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
		public int ActionInfo_ID
		{
			set{ _actioninfo_id=value;}
			get{return _actioninfo_id;}
		}
		#endregion Model

	}
}

