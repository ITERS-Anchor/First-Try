<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Show.aspx.cs" Inherits="BookShop.Web.LockOwnersTable.Show" Title="��ʾҳ" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Id
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SurrogateLockOwnerId
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblSurrogateLockOwnerId" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LockExpiration
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblLockExpiration" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkflowHostType
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWorkflowHostType" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MachineName
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblMachineName" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EnqueueCommand
	��</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkEnqueueCommand" Text="EnqueueCommand" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DeletesInstanceOnCompletion
	��</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkDeletesInstanceOnCompletion" Text="DeletesInstanceOnCompletion" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PrimitiveLockOwnerData
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblPrimitiveLockOwnerData" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ComplexLockOwnerData
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblComplexLockOwnerData" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WriteOnlyPrimitiveLockOwnerData
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWriteOnlyPrimitiveLockOwnerData" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WriteOnlyComplexLockOwnerData
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblWriteOnlyComplexLockOwnerData" runat="server"></asp:Label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EncodingOption
	��</td>
	<td height="25" width="*" align="left">
		<asp:Label id="lblEncodingOption" runat="server"></asp:Label>
	</td></tr>
</table>

</asp:Content>
