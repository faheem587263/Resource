<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminResourceAllocation.Master" AutoEventWireup="true" CodeBehind="ConfigMasterForm.aspx.cs" Inherits="Net_Resource_Booking_Allocation.Admin.ConfigMasterForm" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<div>
<table style="margin:12px,12px,12px,12px">

<tr>
<td>
<asp:Label ID="lblCnfgEmailTo" runat="server" Text="Config Email To"></asp:Label></td>
<td>
<asp:TextBox ID="txtEmailTo" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblCnfgEmailCC" runat="server" Text="Config Email CC"></asp:Label></td>
<td>
<asp:TextBox ID="txtEmailCC" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblCnfgEmailSubject" runat="server" Text="Config Email Subject"></asp:Label></td>
<td>
<asp:TextBox ID="txtEmailSubject" runat="server"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblCnfgEmailBody" runat="server" Text="Config Email Body"></asp:Label></td>
<td>
<asp:TextBox ID="txtEmailBody" runat="server" TextMode="MultiLine"></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblCnfgAttflag" runat="server" Text="Config Attachment Flag"></asp:Label></td>
<td>
<asp:CheckBox ID="chkCnfgattflag" runat="server"/>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblCnfgSMTPServer" runat="server" Text="Config SMTP Server"></asp:Label></td>
<td>
<asp:TextBox ID="txtSMTPServer" runat="server" ></asp:TextBox>
</td>
</tr>
<tr>
<td>
<asp:Label ID="CnfgActive" runat="server" Text="Config Active"></asp:Label>
</td>
<td>
<asp:CheckBox ID="chkCnfgActive" runat="server" />
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblCnfgDel" runat="server" Text="Config Delete"></asp:Label>
</td>
<td>
<asp:CheckBox ID="chkConfgDel" runat="server" />
</td>
</tr>






<tr>
<td>
<asp:Label ID="lblInsertUseID" runat="server" Text="Config Insert User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpInsertUserID" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblUpdateUseID" runat="server" Text="Config Update User ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpUpdateuserId" runat="server"></asp:DropDownList>
</td>
</tr>
<tr>
<td>
<asp:Label ID="lblCnfgYrId" runat="server" Text="Config Yr ID"></asp:Label>
</td>
<td>
<asp:DropDownList ID="drpCnfgYrId" runat="server"></asp:DropDownList>
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
