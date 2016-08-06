using System;
using System.Data;
using System.Configuration;
using System.Collections;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Text;
using LTP.Common;
namespace BookShop.Web.ActionGroupActionInfo
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.TabTitle="信息添加，请详细填写下列信息";            
        }

        		protected void btnAdd_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(!PageValidate.IsNumber(txtActionGroup_ID.Text))
			{
				strErr+="ActionGroup_ID不是数字！\\n";	
			}
			if(!PageValidate.IsNumber(txtActionInfo_ID.Text))
			{
				strErr+="ActionInfo_ID不是数字！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			int ActionGroup_ID=int.Parse(this.txtActionGroup_ID.Text);
			int ActionInfo_ID=int.Parse(this.txtActionInfo_ID.Text);

			BookShop.Model.ActionGroupActionInfo model=new BookShop.Model.ActionGroupActionInfo();
			model.ActionGroup_ID=ActionGroup_ID;
			model.ActionInfo_ID=ActionInfo_ID;

			BookShop.BLL.ActionGroupActionInfoService bll=new BookShop.BLL.ActionGroupActionInfoService();
			bll.Add(model);

		}

    }
}
