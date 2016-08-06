<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.LockOwnersTable.Show" Title="ÏÔÊ¾Ò³" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Id
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SurrogateLockOwnerId
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSurrogateLockOwnerId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LockExpiration
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLockExpiration" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkflowHostType
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWorkflowHostType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MachineName
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMachineName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EnqueueCommand
	£º</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkEnqueueCommand" Text="EnqueueCommand" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DeletesInstanceOnCompletion
	£º</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkDeletesInstanceOnCompletion" Text="DeletesInstanceOnCompletion" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PrimitiveLockOwnerData
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrimitiveLockOwnerData" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ComplexLockOwnerData
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblComplexLockOwnerData" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WriteOnlyPrimitiveLockOwnerData
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWriteOnlyPrimitiveLockOwnerData" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WriteOnlyComplexLockOwnerData
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWriteOnlyComplexLockOwnerData" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EncodingOption
	£º</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEncodingOption" runat="server"></asp:Label>
	</td></tr>
</table>

</asp:Content>
