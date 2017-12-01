<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Header.ascx.cs" Inherits="Exam1.Controls.Header" %>
<style type="text/css">
    .auto-style1 {
        width: 100%;
        height:120px;
    }
    .auto-style2 {
        width: 161px;
        height: 117px;
    }
</style>

<table cellpadding="0" cellspacing="0" class="auto-style1">
    <tr>
        <td style="text-align: left">
            <img alt="John abbott College" class="auto-style2" src="../images/john-abbott.jpg" />&#39;</td>
        <td><h1>WELCOME TO YOUR APPLICATION</h1></td>
        <td>
           <h3> <asp:Label ID="lblDateTime" runat="server" Text="Label"></asp:Label></h3>
        </td>
    </tr>
</table>

