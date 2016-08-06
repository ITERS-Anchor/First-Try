<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.R_UserInfo_ActionInfo.Show" Title="ÏÔÊ¾Ò³" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		ID
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsPass
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblIsPass" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ActionInfoID
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblActionInfoID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		UserInfoID
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUserInfoID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ActionInfo_ID
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblActionInfo_ID" runat="server"></asp:Label>
	</td></tr>
</table>

</asp:Content>
