using System;
namespace BookShop.Model
{
	/// <summary>
	/// ʵ����RoleDepartment ��(����˵���Զ���ȡ���ݿ��ֶε�������Ϣ)
	/// </summary>
	[Serializable]
	public class RoleDepartment
	{
		public RoleDepartment()
		{}
		#region Model
		private int _role_id;
		private int _department_id;
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
		public int Department_ID
		{
			set{ _department_id=value;}
			get{return _department_id;}
		}
		#endregion Model

	}
}

