using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Image = System.Drawing.Image;

namespace WebApp.account.member
{
    public partial class upload : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //post back
            if (Request.IsPostBack())
            {//get data from client
             //foreach (HttpPostedFile file in Request.Files)
             //{
             //    string filename = Path.GetFileName(file.FileName);
             //    var vPath = string.Format("~/uploads/{0}",filename);
             //    file.SaveAs(Server.MapPath(vPath));
             //}
                if (Request.Files.Count==0)
                {
                    return;
                }
                //多个文件
                //for (int i = 0; i < Request.Files.Count; i++)
                //{
                //    HttpPostedFile file = Request.Files[i];
                //    string fn = Path.GetFileName(file.FileName);
                //    MemoryStream mStrm = new MemoryStream(Encoding.UTF8.GetBytes(fn));
                //    string filename = EncryptHelper.GetStreamMD5(mStrm);//2
                //    var vPath = string.Format("~/uploads/{0}.jpg", filename);
                //    //上传后更改文件名再保存1.Guid 2.获取文件名的md5值，这样节省空间，会自动判断文件内容，重复了就不会再存一边
                //    //var vPath = string.Format("~/uploads/{0}.jpg", Guid.NewGuid().ToString("N"));//1
                //    file.SaveAs(Server.MapPath(vPath));
                //    Response.Write(vPath);
                //}
                HttpPostedFile file = Request.Files[0];
                string fn = Path.GetFileName(file.FileName);
                MemoryStream mStrm = new MemoryStream(Encoding.UTF8.GetBytes(fn));
                string filename = EncryptHelper.GetStreamMD5(mStrm);//2
                var vPath = string.Format("~/uploads/{0}.jpg", filename);
                //var vPath = string.Format("~/uploads/{0}.jpg", Guid.NewGuid().ToString("N"));//1
                var pPath = Server.MapPath(vPath);
                file.SaveAs(pPath);
                //Image img = Bitmap.FromFile(pPath);
                Response.Write(vPath);

                Response.End();
            }
        }
    }
}