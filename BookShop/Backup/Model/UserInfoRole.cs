using System;
namespace BookShop.Model
{
	/// <summary>
	/// ʵ����UserInfoRole ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class UserInfoRole
	{
		public UserInfoRole()
		{}
		#region Model
		private int _userinfo_id;
		private int _role_id;
		/// <summary>
		/// 
		/// </summary>
		public int UserInfo_ID
		{
			set{ _userinfo_id=value;}
			get{return _userinfo_id;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int Role_ID
		{
			set{ _role_id=value;}
			get{return _role_id;}
		}
		#endregion Model

	}
}

