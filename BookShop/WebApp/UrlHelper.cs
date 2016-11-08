using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp
{
    public static class UrlHelper
    {
        public static string PicUrl(string isbn)
        {
            return string.Format("/content/books/{0}.jpg", isbn);
        }

        public static string Detail(int id)
        {
            return string.Format("/detail.aspx?item={0}", id);
        }
    }
}