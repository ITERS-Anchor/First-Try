<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.SqlWorkflowInstanceStoreVersionTable.Show" Title="ÏÔÊ¾Ò³" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Major
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMajor" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Minor
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMinor" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Build
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblBuild" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Revision
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblRevision" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LastUpdated
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLastUpdated" runat="server"></asp:Label>
	</td></tr>
</table>

</asp:Content>
