<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminResourceAllocation.Master"
    AutoEventWireup="true" CodeBehind="CountryMasterForm.aspx.cs" Inherits="Net_Resource_Booking_Allocation.Admin.CountryMasterForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <script src="/Scripts/Validation.js" type="text/javascript"></script>
    <div>
        <table style="margin: 12px,12px,12px,12px">
            <tr>
                <td>
                    <asp:Label ID="lblCountyName" runat="server" Text="County Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCountryName" class="txtValidator" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="CountryActive" runat="server" Text="Country Active"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="chkCountryActive" class="chkValidator chkActive" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCountryDel" runat="server" Text="Country Delete"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox class="chkValidator chkDelete" ID="chkCountryDel" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblInsertUseID" runat="server" Text="Country Insert User ID"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="drpInsertUserID" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblUpdateUseID" runat="server" Text="Country Update User ID"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="drpUpdateUserId" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCountryYrId" runat="server" Text="Country Yr ID"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="drpCountryYrId" runat="server">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                </td>
                <td>
                </td>
            </tr>
            <tr>
                <td colspan="2" align="center">
                    <asp:Button ID="btnSubmit" runat="server" class="btn btn-success" Text="Submit" OnClick="dtynSubmit_Click" OnClientClick="return callMethod();" />
                    <asp:Button ID="dtynEdit" runat="server" class="btn btn-default" Text="Edit" OnClick="dtynEdit_Click"/>
                </td>
            </tr>
        </table>
    </div>
</asp:Content>
