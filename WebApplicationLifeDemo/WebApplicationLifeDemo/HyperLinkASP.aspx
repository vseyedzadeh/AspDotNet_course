<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HyperLinkASP.aspx.cs" Inherits="WebApplicationLifeDemo.HyperLinkASP" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:HyperLink ID="MyHAP" NavigateUrl="~/HyperLink2.aspx" runat="server">GOOOOO</asp:HyperLink>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="change my URL" />
            <br />
        </div>
    </form>
</body>
</html>
