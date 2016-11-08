using LoginMvc.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LoginMvc.Controllers
{
    public class AccountController : Controller
    {
        book_shopContext dbContext = new book_shopContext();
        [HttpPost]
        public ActionResult Login(string username,string password,string redirect)
        {
            var user = dbContext.Set<User>().FirstOrDefault(u=>u.LoginId.Equals(username,System.StringComparison.InvariantCultureIgnoreCase));
            if (user==null ||user.LoginPwd!=password)
            {
                ViewBag.Msg = "Wrong name or password!";
                return View();
            }
            //return Redirect(string.IsNullOrEmpty(redirect)?"/": redirect);
            return Redirect(redirect);
        }
    }
}