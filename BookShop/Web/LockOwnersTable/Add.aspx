<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true"
    Codebehind="Add.aspx.cs" Inherits="BookShop.Web.LockOwnersTable.Add" Title="增加页" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		Id
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		LockExpiration
	：</td>
	<td height="25" width="*" align="left">
		<INPUT onselectstart="return false;" onkeypress="return false" id="txtLockExpiration" onfocus="setday(this)"
		 readOnly type="text" size="10" name="Text1" runat="server">
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WorkflowHostType
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWorkflowHostType" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		MachineName
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtMachineName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EnqueueCommand
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkEnqueueCommand" Text="EnqueueCommand" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		DeletesInstanceOnCompletion
	：</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkDeletesInstanceOnCompletion" Text="DeletesInstanceOnCompletion" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		PrimitiveLockOwnerData
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtPrimitiveLockOwnerData" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ComplexLockOwnerData
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtComplexLockOwnerData" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WriteOnlyPrimitiveLockOwnerData
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWriteOnlyPrimitiveLockOwnerData" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WriteOnlyComplexLockOwnerData
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWriteOnlyComplexLockOwnerData" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		EncodingOption
	：</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtEncodingOption" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" colspan="2"><div align="center">
		<asp:Button ID="btnAdd" runat="server" Text="· 提交 ·" OnClick="btnAdd_Click" ></asp:Button>
	</div></td></tr>
</table>

</asp:Content>
