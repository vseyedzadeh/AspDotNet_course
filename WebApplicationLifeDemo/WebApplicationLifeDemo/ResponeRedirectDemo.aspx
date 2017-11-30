<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ResponeRedirectDemo.aspx.cs" Inherits="WebApplicationLifeDemo.ResponeRedirectDemo" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Button ID="Button1" runat="server" Text="Go to Second Form!!!!!!" OnClick="Button1_Click" />
            <br />
            <br />
            <asp:DropDownList ID="DropDownList1" runat="server" OnSelectedIndexChanged="DropDownList1_SelectedIndexChanged">
                <asp:ListItem>Select Item</asp:ListItem>
                <asp:ListItem Value="HyperLink2">HyperLinkASP</asp:ListItem>
                <asp:ListItem Value="StateVariable">StateVariable</asp:ListItem>
            </asp:DropDownList>
        </div>
    </form>
</body>
</html>
