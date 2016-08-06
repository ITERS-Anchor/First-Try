<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.ActionGroup.Show" Title="ÏÔÊ¾Ò³" %>
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
		GroupName
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGroupName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		GroupType
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblGroupType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DelFlag
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDelFlag" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sort
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSort" runat="server"></asp:Label>
	</td></tr>
</table>

</asp:Content>
