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
            Master.TabTitle="��Ϣ��ӣ�����ϸ��д������Ϣ";            
        }

        		protected void btnAdd_Click(object sender, EventArgs e)
		{
			
			string strErr="";
			if(this.txtTempName.Text =="")
			{
				strErr+="TempName����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsDateTime(txtSubTime.Text))
			{
				strErr+="SubTime����ʱ���ʽ��\\n";	
			}
			if(this.txtActiveType.Text =="")
			{
				strErr+="ActiveType����Ϊ�գ�\\n";	
			}
			if(this.txtDescription.Text =="")
			{
				strErr+="Description����Ϊ�գ�\\n";	
			}
			if(this.txtFormTemp.Text =="")
			{
				strErr+="FormTemp����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsNumber(txtstate.Text))
			{
				strErr+="state�������֣�\\n";	
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
