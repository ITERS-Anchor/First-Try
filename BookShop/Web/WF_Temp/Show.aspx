<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.WF_Temp.Show" Title="��ʾҳ" %>
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
		TempName
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblTempName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SubTime
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSubTime" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ActiveType
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblActiveType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Description
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblDescription" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FormTemp
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblFormTemp" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		state
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblstate" runat="server"></asp:Label>
	</td></tr>
</table>

</asp:Content>
