using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Web;

namespace WebApp.handler
{
    /// <summary>
    /// Summary description for file
    /// </summary>
    public class file : IHttpHandler
    {
        HttpContext context;
        public void ProcessRequest(HttpContext context)
        {
            this.context = context;
            context.Response.ContentType = "text/plain";
            var action = context.Request.QueryString["action"];
            switch (action)
            {
                case "cut": CutImage();
                    break;              
            }
        }

        private void CutImage()
        {
            string width = context.Request["width"];
            string height = context.Request["height"];
            string top = context.Request["top"];
            string left = context.Request["left"];
            if (!string.IsNullOrEmpty(width)&& !string.IsNullOrEmpty(height)&&!string.IsNullOrEmpty(top)&&!string.IsNullOrEmpty(left))
            {
                int w = Convert.ToInt32(width);
                int h= Convert.ToInt32(height);
                int t = Convert.ToInt32(top);
                int l = Convert.ToInt32(left);
                string filePath= context.Request["file"];
                //创建画布
                using (Bitmap map=new Bitmap(w,h))
                {
                    //为map创建画笔
                    using (Graphics g=Graphics.FromImage(map))
                    {
                        //创建素材
                        using (Image img = Bitmap.FromFile(context.Server.MapPath(filePath)))
                        {
                             g.DrawImage(img,new Rectangle(0,0,map.Width,map.Height), new Rectangle(l, t, map.Width, map.Height),GraphicsUnit.Pixel);
                           var vPath = string.Format("/uploads/{0}.jpg", Guid.NewGuid().ToString("N"));
                            map.Save(context.Server.MapPath(vPath),ImageFormat.Jpeg);
                            context.Response.Write(vPath);
                        }
                        
                        
                    }
                }
            }
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