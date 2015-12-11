<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminResourceAllocation.Master" AutoEventWireup="true" CodeBehind="ResourceTransForm.aspx.cs" Inherits="Net_Resource_Booking_Allocation.Admin.ResourceTransForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
<table style="margin:12px,12px,12px,12px">

<tr>
<td>
<asp:Label ID="lblrscId" runat="server" Text="Resource ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpresourceID" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblprojectId" runat="server" Text="Project ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpProjectID" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblBookedHrs" runat="server" Text="Booked Hours"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtBokkedHrs" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblStartWeek" runat="server" Text="Start Week"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpStartWeek" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblEndWeek" runat="server" Text="End Week"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpEndWeek" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblComment" runat="server" Text="Comment"></asp:Label>
</td>
<td>
<asp:TextBox ID="txtComment" runat="server" TextMode="MultiLine"></asp:TextBox>
</td>
</tr>

<tr>
<td>
<asp:Label ID="lblInsertUseID" runat="server" Text="Insert User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpInsertUserID" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblUpdateUseID" runat="server" Text="Update User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpUpdateuserId" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblRtYrId" runat="server" Text="Trans Yr ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpRtYrId" runat="server"></asp:DropDownList>
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
