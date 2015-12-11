<%@ Page Title="" Language="C#" MasterPageFile="~/Admin/AdminResourceAllocation.Master"
    AutoEventWireup="true" CodeBehind="CommonMasterForm.aspx.cs" Inherits="Net_Resource_Booking_Allocation.Admin.CommonMasterForm" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        <table style="margin: 12px,12px,12px,12px">
            <tr>
                <td>
                    <asp:Label ID="lblCommonID" runat="server" Text="Common ID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCommonID" class="numValidator" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCommonName" runat="server" Text="Common Name"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCommonName" class="txtValidator"  runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCommonDescription" runat="server" Text="Common Description"></asp:Label>
                </td>
                <td>
                    <asp:TextBox ID="txtCommonDescription" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblgrpId" runat="server" Text="Common Group"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="drpgroupID" runat="server" class="drpValidation">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCommonActive" runat="server" Text="Common Active"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="chkCommonActive" class="chkValidator chkActive"  runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCommonDelete" runat="server" Text="Common Delete"></asp:Label>
                </td>
                <td>
                    <asp:CheckBox ID="chkCommonDelete" class="chkValidator chkDelete" runat="server" />
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblInsertUseID" runat="server" Text="Common Insert User ID"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="drpInsertUserID" class="drpInsert" runat="server" >
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblUpdateUseID" runat="server" Text="Common Update User ID"></asp:Label>
                </td>
                <td>
                    <asp:DropDownList ID="drpUpdateuserId" class="drpUpdate" runat="server" >
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblCommonYrId" runat="server" Text="Common Yr ID"></asp:Label>
                </td>
                <td>
                    <asp:TextBox runat="server" class="numValidator" ID="txtCommonYrId"></asp:TextBox>
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
                    <asp:Button ID="btnAdd" runat="server" class="btn btn-info" Text="Add" OnClick="btnAdd_Click" OnClientClick="return callMethod();"/>
                    <asp:Button ID="btnSubmit" runat="server" class="btn btn-success" Text="Submit" 
                        onclick="btnSubmit_Click" OnClientClick="return callMethod();"/>
                    <asp:Button ID="dtynEdit" runat="server" class="btn btn-default" Text="Edit" 
                        onclick="dtynEdit_Click" />
                </td>
            </tr>
        </table>
    </div>
    <script src="../Scripts/Validation.js" type="text/javascript"></script>

</asp:Content>
