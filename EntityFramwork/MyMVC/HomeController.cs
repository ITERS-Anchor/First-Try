using System;
using System.Web;

namespace MyMVC
{
    public class HomeController:IController
    {
        private HttpContext _context;
        public void Execute(HttpContext context)
        {
            _context = context;
            //context.Response.Write("Home,OK");
            var actionName = context.Request["a"]?? string .Empty;
            switch (actionName.ToLower())
            {
                case "index":
                    Index();
                    break;
                default:

                    break;
            }

        }
        private void Index()
        {
            _context.Response.Write("Inside");

        } 
        private void Add()
        {
            //调用业务方法 拿到返回数据 将反回数据格式化，拿到view model，将vm传给视图渲染
        }
        private void Delete()
        {

        }
        
        
    }
}