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
    public partial class detail : System.Web.UI.Page
    {
        BooksBLL bll = new BooksBLL();
        public Books CurrentBook { get; set; }
        protected void Page_Load(object sender, EventArgs e)
        {
            int item;
            Int32.TryParse(Request["item"], out item);
            if (item == 0)
            {
                // 没有找到资源
                throw new HttpException(404, "Not Found");
            }

            // 调用业务层方法查询实体
            CurrentBook = bll.QuerySingle(item);
            if (CurrentBook == null)
            {
                // 没有找到资源
                throw new HttpException(404, "Not Found");
            }

        }
    }
}