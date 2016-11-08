using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SimpleMVC
{
    public class HomeController : IController
    {
        HttpContext _context;
        //public void Execute(HttpContext context)
        //{
        //    _context = context;
        //    var actionName = context.Request["a"]??string.Empty;
        //    switch (actionName)
        //    {
        //        case "index":
        //            Index();
        //            break;
        //    }
        //}
        public void Execute(RequestContext context)
        {
            _context = context.Context;
            switch (context.RouteValues["action"].ToLower())
            {
                case "index":
                    Index();
                    break;
                case "demo":
                    Demo();
                    break;
            }
        }

        private void Index()
        {
            _context.Response.Write("Index action");
        }
        private void Demo()
        {
            _context.Response.Write("123");
        }
    }
}