<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ServerTransfer.aspx.cs" Inherits="WebApplicationLifeDemo.ServerTransfer" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Name:&nbsp;&nbsp;
            <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
            <br />
            Email:&nbsp;&nbsp;&nbsp;
            <asp:TextBox ID="tbEmail" runat="server" Width="198px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Server Transfer" Width="112px" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button2" runat="server" Text="External server" Width="112px" OnClick="Button2_Click" />
            <br />
            <br />
            <br />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Server Execute" />
            <br />
            <br />
            <asp:Label ID="lbOutcome" runat="server" ForeColor="#CC3300" Text="Label"></asp:Label>
            <br />
            <br />
        </div>
    </form>
</body>
</html>
