using System;
namespace BookShop.Model
{
	/// <summary>
	/// ʵ����ActionGroupActionInfo ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
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

