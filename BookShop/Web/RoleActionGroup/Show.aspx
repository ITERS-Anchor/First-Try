<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.RoleActionGroup.Show" Title="ÏÔÊ¾Ò³" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Role_ID
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRole_ID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ActionGroup_ID
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblActionGroup_ID" runat="server"></asp:Label>
	</td></tr>
</table>

</asp:Content>
