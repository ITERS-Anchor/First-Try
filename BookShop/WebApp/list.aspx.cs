using BookShop.BLL;
using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class list : System.Web.UI.Page
    {
        private BooksBLL booksbll = new BooksBLL();
        private CategoriesBLL catbll = new CategoriesBLL();
        public IEnumerable<Books> ProductList { get; set; }

        public int pageSize = 20;
        public int CurrentPage { get; set; }
        public int TotalCount { get; set; }
        public int TotalPage { get; set; }
        public Categories CurrentCategory { get; set; }
        public SortType Sort { get; set; }
        public string OrderField { get; set; }
        public bool IsAsc { get; set; }
        
        protected void Page_Load(object sender, EventArgs e)
        {            
            int pageIndex, category,sort;
            
            if (!Int32.TryParse(Request["page"], out pageIndex))
            {
                pageIndex = 1;
            }
            // pageIndex = pageIndex < 1 ? 1 : pageIndex;
            //// pageIndex = pageIndex > pageCount ? pageCount : pageIndex;            
            CurrentPage = pageIndex;
            
            if (!Int32.TryParse(Request["sort"], out sort))
            {
                sort =Convert.ToInt32( SortType.Default);
            }
            Sort =(SortType)sort;
            switch (Sort)
            {
                case SortType.PriceDesc:
                    OrderField = "UnitPrice";
                    break;
                case SortType.PriceAsc:
                    IsAsc = true;
                    OrderField = "UnitPrice";
                    break;
                case SortType.SalesDesc:
                    OrderField = "PublishDate";
                    break;
                case SortType.OnSaleDesc:
                    OrderField = "PublishDate";
                    break;
                case SortType.CommentCountDesc:
                    OrderField = "PublishDate";
                    break;
            }
            Int32.TryParse(Request["cat"], out category);
            if (category == 0)
            {
                // 没有分类
                throw new HttpException(404, "Not Found");
                //Response.Redirect("PageDoesNotExist.aspx");
                //as this page will not be existing, it will fire the 404 error, which will redirect     to the error page
            }

            //
            CurrentCategory = catbll.QuerySingle(new { Id = category });
            if (CurrentCategory == null)
            {
                // 没有分类
                throw new HttpException(404, "Not Found");
                //Response.Redirect("PageDoesNotExist.aspx");
            }
            // 确保有分类
            var where = new { CategoryId = CurrentCategory.Id };
            TotalCount = booksbll.QueryCount(where);
            TotalPage = (int)Math.Ceiling(TotalCount / (double)pageSize);

            ProductList = booksbll.QueryList(CurrentPage, pageSize, where, OrderField, !IsAsc);
            
        }
    }
    public enum SortType
    {
        Default = 2,
        PriceDesc = 1,
        PriceAsc = 2,
        SalesDesc = 3,
        OnSaleDesc = 4,
        CommentCountDesc = 5,
    }
}