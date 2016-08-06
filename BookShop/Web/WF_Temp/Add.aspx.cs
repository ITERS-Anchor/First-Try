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
namespace BookShop.Web.WF_Temp
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
			if(this.txtTempName.Text =="")
			{
				strErr+="TempName不能为空！\\n";	
			}
			if(!PageValidate.IsDateTime(txtSubTime.Text))
			{
				strErr+="SubTime不是时间格式！\\n";	
			}
			if(this.txtActiveType.Text =="")
			{
				strErr+="ActiveType不能为空！\\n";	
			}
			if(this.txtDescription.Text =="")
			{
				strErr+="Description不能为空！\\n";	
			}
			if(this.txtFormTemp.Text =="")
			{
				strErr+="FormTemp不能为空！\\n";	
			}
			if(!PageValidate.IsNumber(txtstate.Text))
			{
				strErr+="state不是数字！\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string TempName=this.txtTempName.Text;
			DateTime SubTime=DateTime.Parse(this.txtSubTime.Text);
			string ActiveType=this.txtActiveType.Text;
			string Description=this.txtDescription.Text;
			string FormTemp=this.txtFormTemp.Text;
			int state=int.Parse(this.txtstate.Text);

			BookShop.Model.WF_Temp model=new BookShop.Model.WF_Temp();
			model.TempName=TempName;
			model.SubTime=SubTime;
			model.ActiveType=ActiveType;
			model.Description=Description;
			model.FormTemp=FormTemp;
			model.state=state;

			BookShop.BLL.WF_TempService bll=new BookShop.BLL.WF_TempService();
			bll.Add(model);

		}

    }
}
