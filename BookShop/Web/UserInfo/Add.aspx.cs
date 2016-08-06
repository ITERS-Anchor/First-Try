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
namespace BookShop.Web.UserInfo
{
    public partial class Add : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            Master.TabTitle="��Ϣ��ӣ�����ϸ��д������Ϣ";            
        }

        		protected void btnAdd_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtUserName.Text =="")
			{
				strErr+="UserName����Ϊ�գ�\\n";	
			}
			if(this.txtUserPass.Text =="")
			{
				strErr+="UserPass����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsDateTime(txtRegTime.Text))
			{
				strErr+="RegTime����ʱ���ʽ��\\n";	
			}
			if(this.txtEmail.Text =="")
			{
				strErr+="Email����Ϊ�գ�\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string UserName=this.txtUserName.Text;
			string UserPass=this.txtUserPass.Text;
			DateTime RegTime=DateTime.Parse(this.txtRegTime.Text);
			string Email=this.txtEmail.Text;

			BookShop.Model.UserInfo model=new BookShop.Model.UserInfo();
			model.UserName=UserName;
			model.UserPass=UserPass;
			model.RegTime=RegTime;
			model.Email=Email;

			BookShop.BLL.UserInfoService bll=new BookShop.BLL.UserInfoService();
			bll.Add(model);

		}

    }
}
