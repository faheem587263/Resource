<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminResourceAllocation.Master" AutoEventWireup="true" CodeBehind="ConfigMasterForm.aspx.cs" Inherits="Net_Resource_Booking_Allocation.Admin.ConfigMasterForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
<table style="margin:12px,12px,12px,12px">
<%--<tr>
<td>
<asp:Label ID="lblID" runat="server" Text="Resource ID"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtResId" runat="server"></asp:TextBox>
</td>
</tr>--%>
<tr>
<td>
<asp:Label ID="lblName" runat="server" Text="Resource Name"></asp:Label></td>
<td>
<asp:TextBox ID="txtResName" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblglblId" runat="server" Text="Resource Global Company ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpgroupName" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblResIndId" runat="server" Text="Resource India Company ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpIncomanpyName" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblConId" runat="server" Text="Resource Country ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpConName" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblResSkillId" runat="server" Text="Resource Skill ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpSkillName" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblHrPrWeek" runat="server" Text="Resource Hour Per Week"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtHrPrWk" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblResComment" runat="server" Text="Resource Comment"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtResComment" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblResProfileLnk" runat="server" Text="Resource Profile Link"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtProfileLink" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblResRoll" runat="server" Text="Resource Roll"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtResRoll" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="ResActive" runat="server" Text="Resource Active"></asp:Label>
</td>
<td>
<asp:CheckBox ID="chkResActive" runat="server" />
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblResDel" runat="server" Text="Resource Delete"></asp:Label>
</td>
<td>
<asp:CheckBox ID="chkResDel" runat="server" />
</td>
</tr>

<tr>
<td>
<asp:Label ID="lblInsertUseID" runat="server" Text="Resource Insert User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpInsertUserID" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblUpdateUseID" runat="server" Text="Resource Update User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpUpdateuserId" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblResYrId" runat="server" Text="Resource Yr ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="DrpResYrId" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td></td>
<td></td>
</tr>
<tr>
<td colspan="2" align="center">
<asp:Button ID="btnSubmit" runat="server" Text="Submit" />

<asp:Button ID="dtynEdit" runat="server" Text="Edit" />
</td></tr>
</table>


</div>
</asp:Content>
