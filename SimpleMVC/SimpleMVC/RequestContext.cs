using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVC
{
    public class RequestContext
    {
        public HttpContext Context{get;set;}
        public Dictionary<string ,string> RouteValues { get; set; }
       

    }
}