using System; 
namespace BookShop.Model
{
	public class Books
	{
   		     
      	/// <summary>
		/// Id
        /// </summary>
        public int Id { get; set; }
		/// <summary>
		/// Title
        /// </summary>
        public string Title { get; set; }
		/// <summary>
		/// Author
        /// </summary>
        public string Author { get; set; }
		/// <summary>
		/// PublisherId
        /// </summary>
        public int PublisherId { get; set; }
		/// <summary>
		/// PublishDate
        /// </summary>
        public DateTime PublishDate { get; set; }
		/// <summary>
		/// ISBN
        /// </summary>
        public string ISBN { get; set; }
		/// <summary>
		/// WordsCount
        /// </summary>
        public int WordsCount { get; set; }
		/// <summary>
		/// UnitPrice
        /// </summary>
        public decimal UnitPrice { get; set; }
		/// <summary>
		/// ContentDescription
        /// </summary>
        public string ContentDescription { get; set; }
		/// <summary>
		/// AurhorDescription
        /// </summary>
        public string AurhorDescription { get; set; }
		/// <summary>
		/// EditorComment
        /// </summary>
        public string EditorComment { get; set; }
		/// <summary>
		/// TOC
        /// </summary>
        public string TOC { get; set; }
		/// <summary>
		/// CategoryId
        /// </summary>
        public int CategoryId { get; set; }
		/// <summary>
		/// Clicks
        /// </summary>
        public int Clicks { get; set; }
		   
	}
}

