using System; 
namespace BookShop.Model
{
	public class Articel_Words
	{
   		     
      	/// <summary>
		/// Id
        /// </summary>
        public int Id { get; set; }
		/// <summary>
		/// WordPattern
        /// </summary>
        public string WordPattern { get; set; }
		/// <summary>
		/// 是否禁用
        /// </summary>
        public bool IsForbid { get; set; }
		/// <summary>
		/// 是否需要审核
        /// </summary>
        public bool IsMod { get; set; }
		/// <summary>
		/// ReplaceWord
        /// </summary>
        public string ReplaceWord { get; set; }
		   
	}
}

