<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="BookShop.Web.LockOwnersTable.Modify" Title="ÐÞ¸ÄÒ³" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Id
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		SurrogateLockOwnerId
	£º</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblSurrogateLockOwnerId" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LockExpiration
	£º</td>
	<td height="25" width="*" align="left">
		<INPUT onselectstart="return false;" onkeypress="return false" id="txtLockExpiration" onfocus="setday(this)"
		 readOnly type="text" size="10" name="Text1" runat="server">
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkflowHostType
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWorkflowHostType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MachineName
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMachineName" runat="server" Width="200px"></asp:TextBox>
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
		<asp:TextBox id="txtPrimitiveLockOwnerData" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ComplexLockOwnerData
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtComplexLockOwnerData" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WriteOnlyPrimitiveLockOwnerData
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWriteOnlyPrimitiveLockOwnerData" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WriteOnlyComplexLockOwnerData
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWriteOnlyComplexLockOwnerData" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EncodingOption
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEncodingOption" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" colspan="2"><div align="center">
		<asp:Button ID="btnUpdate" runat="server" Text="¡¤ Ìá½» ¡¤" OnClick="btnUpdate_Click" ></asp:Button>
	</div></td></tr>
</table>

</asp:Content>
