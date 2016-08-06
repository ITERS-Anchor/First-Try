<%@ Page Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeBehind="Modify.aspx.cs" Inherits="BookShop.Web.WF_Step.Modify" Title="ÐÞ¸ÄÒ³" %>
<%@ MasterType VirtualPath="~/MasterPage.master" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

<table cellSpacing="0" cellPadding="0" width="100%" border="0">
	<tr>
	<td height="25" width="30%" align="right">
		ID
	£º</td>
	<td height="25" width="*" align="left">
		<asp:label id="lblID" runat="server"></asp:label>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		subTime
	£º</td>
	<td height="25" width="*" align="left">
		<INPUT onselectstart="return false;" onkeypress="return false" id="txtsubTime" onfocus="setday(this)"
		 readOnly type="text" size="10" name="Text1" runat="server">
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ProcessTime
	£º</td>
	<td height="25" width="*" align="left">
		<INPUT onselectstart="return false;" onkeypress="return false" id="txtProcessTime" onfocus="setday(this)"
		 readOnly type="text" size="10" name="Text1" runat="server">
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ProcessBy
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtProcessBy" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		StepName
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtStepName" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Comment
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtComment" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		FlowTo
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtFlowTo" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsStart
	£º</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsStart" Text="IsStart" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsEnd
	£º</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsEnd" Text="IsEnd" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		State
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtState" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		ParentStepId
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtParentStepId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		Sort
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtSort" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		WF_InstanceID
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtWF_InstanceID" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		InstanceId
	£º</td>
	<td height="25" width="*" align="left">
		<asp:TextBox id="txtInstanceId" runat="server" Width="200px"></asp:TextBox>
	</td></tr>
	<tr>
	<td height="25" width="30%" align="right">
		IsProcessed
	£º</td>
	<td height="25" width="*" align="left">
		<asp:CheckBox ID="chkIsProcessed" Text="IsProcessed" runat="server" Checked="False" />
	</td></tr>
	<tr>
	<td height="25" colspan="2"><div align="center">
		<asp:Button ID="btnUpdate" runat="server" Text="¡¤ Ìá½» ¡¤" OnClick="btnUpdate_Click" ></asp:Button>
	</div></td></tr>
</table>

</asp:Content>
