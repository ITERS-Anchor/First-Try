using BookShop.Model;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Web;

namespace BookShop.Web
{
    /// <summary>
    /// UserInfoList 的摘要说明
    /// </summary>
    public class UserInfoList : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/html";
            BLL.UserInfoService UserInfoService = new BLL.UserInfoService();
            List<UserInfo> list = UserInfoService.GetModelList("");
            StringBuilder sb = new StringBuilder();
            foreach (UserInfo userInfo in list)
            {
                sb.AppendFormat("<tr><td>{0}</td><td>{1}</td><td>{2}</td><td>{3}</td><td>{4}</td><td><a href='UserInfoDetail.ashx?uid={0}'>详细</a></td><td><a href='DeleteUserInfo.ashx?uid={0}' class='deletes'>删除</a></td><td><a href='EditUserInfo.ashx?uid={0}'>编辑</a></td></tr>", userInfo.ID, userInfo.UserName, userInfo.UserPass, userInfo.RegTime.ToShortDateString(), userInfo.Email);
            }
            string filePath = context.Request.MapPath("UserInfoListModel.html");
            string fileContent = File.ReadAllText(filePath);
            fileContent = fileContent.Replace("$tbody", sb.ToString());
            context.Response.Write(fileContent);
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