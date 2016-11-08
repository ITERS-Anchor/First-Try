using BookShop.BLL;
using BookShop.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApp
{
    public partial class test1 : System.Web.UI.Page
    {
        public IList<Categories> Categories { get; set; }

        CategoriesBLL bll = new CategoriesBLL();
        protected void Page_Load(object sender, EventArgs e)
        {
            // 查询全部数据
            Categories = bll.QueryList(0, 10, null, "").ToList();
        }

        int level,flag;
        
        protected StringBuilder LoadCategories(int pid)
        {
            StringBuilder sbHtml = new StringBuilder();
            level++;
            flag++;
            if (level>3)
            {
                level--;
                return sbHtml;
            }

            // 判断有满足条件的元素
            if (Categories.Any(s => s.ParentId == pid))
            {
                if (flag==1)
                {
                    sbHtml.Append("<ul id='categories' class='dropdown-menu'>");
                }
                else
                {
                    sbHtml.Append("<ul class='sub-item'>");
                }
                
                foreach (Categories item in Categories)
                {
                    if (item.ParentId == pid)
                    {                        
                        if (level == 1)
                        {
                            sbHtml.AppendFormat("<li><a href='#'><i class='icon-main icon-0'></i>{0}</a>", item.Name + "@" + level);
                        }
                        else
                        {
                            sbHtml.AppendFormat("<li><a href='#'>{0}</a>", item.Name+"@"+level);
                        }
                        //sbHtml.AppendFormat("<li><a href='#'>{0}</a>", item.DisplayName);
                        sbHtml.Append(LoadCategories(item.Id));
                        sbHtml.Append("</li>");
                    }
                }
                sbHtml.Append("</ul>");
            }
            level--;
            return sbHtml;
        }
    }
}