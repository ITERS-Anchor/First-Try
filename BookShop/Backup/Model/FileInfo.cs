using System;
namespace BookShop.Model
{
	/// <summary>
	/// 实体类FileInfo 。(属性说明自动提取数据库字段的描述信息)
	/// </summary>
	[Serializable]
	public class FileInfo
	{
		public FileInfo()
		{}
		#region Model
		private int _id;
		private string _alt;
		private string _url;
		private int _size;
		private string _filetype;
		private string _filename;
		private string _ext;
		private int _wf_instanceid;
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
		public string Alt
		{
			set{ _alt=value;}
			get{return _alt;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Url
		{
			set{ _url=value;}
			get{return _url;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int size
		{
			set{ _size=value;}
			get{return _size;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FileType
		{
			set{ _filetype=value;}
			get{return _filetype;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string FileName
		{
			set{ _filename=value;}
			get{return _filename;}
		}
		/// <summary>
		/// 
		/// </summary>
		public string Ext
		{
			set{ _ext=value;}
			get{return _ext;}
		}
		/// <summary>
		/// 
		/// </summary>
		public int WF_InstanceID
		{
			set{ _wf_instanceid=value;}
			get{return _wf_instanceid;}
		}
		#endregion Model

	}
}

