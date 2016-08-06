<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    Codebehind="Add.aspx.cs" Inherits="BookShop.Web.ServiceDeploymentsTable.Add" Title="增加页" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		ServiceDeploymentHash
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtServiceDeploymentHash" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SiteName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSiteName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RelativeServicePath
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRelativeServicePath" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		RelativeApplicationPath
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtRelativeApplicationPath" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ServiceName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtServiceName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ServiceNamespace
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtServiceNamespace" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" colspan="2"><div align="center">
		<asp:Button ID="btnAdd" runat="server" Text="· 提交 ·" OnClick="btnAdd_Click" ></asp:Button>
	</div></td></tr>
</table>

</asp:Content>
