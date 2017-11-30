<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="StateVariable.aspx.cs" Inherits="WebApplicationLifeDemo.StateVariable" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            My Counter:
            <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            <br />
            <asp:Button ID="Button1" runat="server" Text="Button" OnClick="Button1_Click" />
            <br />
            <br />
            <br />
            My HTML counter
            <input id="Text1" type="text" /></div>
    </form>
</body>
</html>