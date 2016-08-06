<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.FileInfo.Show" Title="ÏÔÊ¾Ò³" %>
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
		Alt
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAlt" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Url
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUrl" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		size
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsize" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FileType
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFileType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FileName
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFileName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ext
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExt" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WF_InstanceID
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWF_InstanceID" runat="server"></asp:Label>
	</td></tr>
</table>

</asp:Content>
