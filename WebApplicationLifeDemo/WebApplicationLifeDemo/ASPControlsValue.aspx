<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ASPControlsValue.aspx.cs" Inherits="WebApplicationLifeDemo.ASPControlsValue" %>

<!DOCTYPE html>

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
            
            </div>
    </form>
</body>
</html>