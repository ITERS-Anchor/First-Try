using System; 
namespace BookShop.Model
{
	public class Categories
	{
   		     
      	/// <summary>
		/// Id
        /// </summary>
        public int Id { get; set; }
		/// <summary>
		/// Name
        /// </summary>
        public string Name { get; set; }
        public int ParentId { get; set; }
    }
}

