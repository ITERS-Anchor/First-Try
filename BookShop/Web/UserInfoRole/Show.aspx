<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.UserInfoRole.Show" Title="��ʾҳ" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		UserInfo_ID
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUserInfo_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Role_ID
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRole_ID" runat="server"></asp:Label>
	</td></tr>
</table>

</asp:Content>
