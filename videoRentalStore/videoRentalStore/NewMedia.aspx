<%@ Page Language="C#" MasterPageFile="~/DefaulMaster.Master" AutoEventWireup="true" CodeBehind="NewMedia.aspx.cs" Inherits="videoRentalStore.NewMedia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentPH" runat="server">
    <div>
            <br />
            <table cellpadding="5" cellspacing="5" width="60%">
                <tr>
                    <td>Title:</td>
                    <td>
                        <asp:TextBox ID="tbTitle" runat="server" Width="419px"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbTitle" Display="Dynamic" ErrorMessage="*" ForeColor="#990000"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>Type:</td>
                    <td>
                        <asp:DropDownList ID="ddlType" runat="server">
                            <asp:ListItem Value="0">Select a Type</asp:ListItem>
                            <asp:ListItem>Movie</asp:ListItem>
                            <asp:ListItem Value="TVShow">Tv Show</asp:ListItem>
                        </asp:DropDownList>
                    &nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="ddlType" ErrorMessage="Please select a media type" ForeColor="#990000" InitialValue="0"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>Production Year:</td>
                    <td>
                        <asp:TextBox ID="tbProductionYear" runat="server"></asp:TextBox>
                    &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbProductionYear" ErrorMessage="*" ForeColor="#990000"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnAddMedia" runat="server" Text="Add Media" OnClick="btnAddMedia_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </asp:Content>
