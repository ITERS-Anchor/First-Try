using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApp.shared;

namespace WebApp
{
    public partial class index : BasePage
    {
        protected Site CurrentMaster
        {
            get
            {
                return this.Master as Site;
            }
        }
        protected void Page_Load(object sender, EventArgs e)
        {
            CurrentMaster.CurrentUser = this.CurrentUser;
            CurrentMaster.isIndex = true;
        }
    }
}