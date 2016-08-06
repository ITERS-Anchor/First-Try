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
namespace BookShop.Web.InstanceMetadataChangesTable
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
			if(this.txtSurrogateInstanceId.Text =="")
			{
				strErr+="SurrogateInstanceId����Ϊ�գ�\\n";	
			}
			if(!PageValidate.IsNumber(txtEncodingOption.Text))
			{
				strErr+="EncodingOption�������֣�\\n";	
			}

			if(strErr!="")
			{
				MessageBox.Show(this,strErr);
				return;
			}
			string SurrogateInstanceId=this.txtSurrogateInstanceId.Text;
			int EncodingOption=int.Parse(this.txtEncodingOption.Text);
			byte[] Change= new UnicodeEncoding().GetBytes(this.txtChange.Text);

			BookShop.Model.InstanceMetadataChangesTable model=new BookShop.Model.InstanceMetadataChangesTable();
			model.SurrogateInstanceId=SurrogateInstanceId;
			model.EncodingOption=EncodingOption;
			model.Change=Change;

			BookShop.BLL.InstanceMetadataChangesTableService bll=new BookShop.BLL.InstanceMetadataChangesTableService();
			bll.Add(model);

		}

    }
}
