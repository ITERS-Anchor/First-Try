using System;
namespace BookShop.Model
{
	/// <summary>
	/// ʵ����R_UserInfo_ActionInfo ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class R_UserInfo_ActionInfo
	{
		public R_UserInfo_ActionInfo()
		{}
		#region Model
		private int _id;
		private int _ispass;
		private int _actioninfoid;
		private int _userinfoid;
		private int _actioninfo_id;
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
		public int IsPass
		{
			set{ _ispass=value;}
			get{return _ispass;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int ActionInfoID
		{
			set{ _actioninfoid=value;}
			get{return _actioninfoid;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int UserInfoID
		{
			set{ _userinfoid=value;}
			get{return _userinfoid;}
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

