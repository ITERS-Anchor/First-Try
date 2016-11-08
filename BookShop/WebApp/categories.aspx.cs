using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class categories : System.Web.UI.Page
    {
        //protected abstract void Render();
        public Action<IList<Category>> RenderCategories;
        public IList<Category> Categories { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            Categories = new List<Category>
            {
                new Category
                {
                    Name = "Category 1",
                    Children = new List<Category>
                    {
                        new Category
                        {
                            Name = "Category 1 - 1",
                            Children = new List<Category>()
                        },
                        new Category
                        {
                            Name = "Category 1 - 2",
                            Children = new List<Category>()
                        },
                    }
                },
                new Category
                {
                    Name = "Category 2",
                    Children = new List<Category>
                    {
                        new Category
                        {
                            Name = "Category 2 - 1",
                            Children = new List<Category>()
                        },
                        new Category
                        {
                            Name = "Category 2 - 2",
                            Children = new List<Category>()
                        },
                    }
                },
            };
        }


        //public string RenderCategory(IList<Category> cats)
        //{
        //    StringBuilder sbHtml = new StringBuilder();
        //    sbHtml.Append("\r\n<ul>");
        //    foreach (var item in cats)
        //    {
        //        // li
        //        sbHtml.AppendFormat("\r\n\t<li>\r\n\t{0}", item.Name);
        //        if (item.Children.Count > 0)
        //            sbHtml.Append(RenderCategory(item.Children));
        //        sbHtml.Append("\r\n\t</li>");

        //    }
        //    sbHtml.Append("\r\n</ul>");
        //    return sbHtml.ToString();
        //}
    }
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Parent { get; set; }
        public IList<Category> Children { get; set; }
    }
}
