<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.FileInfo.Show" Title="��ʾҳ" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		ID
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblID" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Alt
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblAlt" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Url
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblUrl" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		size
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblsize" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FileType
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFileType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FileName
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFileName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Ext
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblExt" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WF_InstanceID
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWF_InstanceID" runat="server"></asp:Label>
	</td></tr>
</table>

</asp:Content>
