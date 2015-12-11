<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminResourceAllocation.Master" AutoEventWireup="true" CodeBehind="GroupMasterForm.aspx.cs" Inherits="Net_Resource_Booking_Allocation.Admin.GroupMasterForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
<table style="margin:12px,12px,12px,12px">

<tr>
<td>
<asp:Label ID="lblGrpName" runat="server" Text="Group Name"></asp:Label></td>
<td>
<asp:TextBox ID="txtGrpName" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblGrpDescription" runat="server" Text="Group Description"></asp:Label></td>
<td>
<asp:TextBox ID="txtGrpDescription" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="GrpActive" runat="server" Text="Group Active"></asp:Label>
</td>
<td>
<asp:CheckBox ID="chkGrpActive" runat="server" />
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblGrpDel" runat="server" Text="Group Delete"></asp:Label>
</td>
<td>
<asp:CheckBox ID="chkGrpDel" runat="server" />
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblInsertUseID" runat="server" Text="Group Insert User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpInsertUserID" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblUpdateUseID" runat="server" Text="Group Update User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpUpdateuserId" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblGrpYrId" runat="server" Text="Group Yr ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpGrpYrId" runat="server"></asp:DropDownList>
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
