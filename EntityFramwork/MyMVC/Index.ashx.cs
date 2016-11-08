using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;

namespace MyMVC
{
    /// <summary>
    /// Summary description for Index
    /// </summary>
    public class Index : IHttpHandler
    {
        private static readonly IList<Type> AllControllerTypes=new List<Type>();
        static Index()
        {
            var types = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in types)
            {
                //判断当前类型是否实现IController的类型
                if (typeof(IController).IsAssignableFrom(type)&&type.IsClass&&type.IsPublic&&! type.IsAbstract)
                {
                    AllControllerTypes.Add(type);
                }
            }
        }
        public void ProcessRequest(HttpContext context)
        {
            var controllerName = context.Request["c"];
            IController controller = null;
            //遍历所有的控制器类型，找当前
            foreach (var item in AllControllerTypes)
            {
                if (item.Name.Equals(controllerName+"controller",StringComparison.InvariantCultureIgnoreCase))
                {
                    controller = Activator.CreateInstance(item) as IController;
                     
                }
            }
            if (controller == null)
            {
                throw new HttpException(404, "Not Found ");
            }
            controller.Execute(context);
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}