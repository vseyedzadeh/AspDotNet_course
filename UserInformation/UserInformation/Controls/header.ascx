<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="header.ascx.cs" Inherits="UserInformation.Controls.header" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
        height: 64px;
    }
    .auto-style2 {
        width: 68px;
        height: 64px;
    }
    .auto-style3 {
        width: 100px;
    }
    .auto-style4 {
        color: #006600;
    }
    .auto-style5 {
        text-align: center;
    }
</style>

<table class="auto-style1">
    <tr>
        <td class="auto-style3">
            <img alt="Hello World" class="auto-style2" src="../Images/logo.png" /></td>
        <td class="auto-style4">
            <h1 class="auto-style5"><strong>Hello World Corp.</strong></h1>
        </td>
        <td>
            <asp:Label ID="lblCurrentDate" runat="server" Text="Label"></asp:Label>
        </td>
    </tr>
</table>

