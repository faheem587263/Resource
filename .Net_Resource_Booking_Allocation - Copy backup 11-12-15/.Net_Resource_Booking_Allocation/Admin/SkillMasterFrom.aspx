<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminResourceAllocation.Master" AutoEventWireup="true" CodeBehind="SkillMasterFrom.aspx.cs" Inherits="Net_Resource_Booking_Allocation.Admin.SkillMasterFrom" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
<table style="margin:12px,12px,12px,12px">

<tr>
<td>
<asp:Label ID="lblSkillName" runat="server" Text="Skill Name"></asp:Label></td>
<td>
<asp:TextBox ID="txtSkillName" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblSkillActive" runat="server" Text="Skill Active"></asp:Label>
</td>
<td>
<asp:CheckBox runat="server" ID="chkSkillActive"/>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblSkillDelete" runat="server" Text="Skill Delete"></asp:Label>
</td>
<td>
<asp:CheckBox runat="server" ID="chkSkillDelete"/>
</td>
</tr>



<tr>
<td>
<asp:Label ID="lblInsertUseID" runat="server" Text="Skill Insert User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpInsertUserID" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblUpdateUseID" runat="server" Text="Skill Update User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpUpdateuserId" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblSkillYrId" runat="server" Text="Skill Yr ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="DrpSkillYrId" runat="server"></asp:DropDownList>
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
