<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="videoRentalStore.Defaulr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 50%;
        }
        .auto-style2 {
            direction: ltr;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Welcome to Store!!!!<br />
            <br />
            <table cellpadding="5" cellspacing="5" class="auto-style1">
                <tr>
                    <td class="auto-style2" style="text-align: center">
                        <asp:ImageButton ID="ImageButton1" runat="server" AlternateText="Customer List" Height="128px" ImageUrl="~/Images/list.png" Width="118px" PostBackUrl="~/Customers.aspx" />
                    </td>
                    <td style="text-align: center">
                        <asp:ImageButton ID="ImageButton2" runat="server" AlternateText="New Customer" ImageUrl="~/Images/Add_New.png" PostBackUrl="~/NewCustomer.aspx" />
                    </td>
                    <td style="text-align: center">
                        <asp:ImageButton ID="ImageButton3" runat="server" AlternateText="Rented Media List" Height="128px" Width="118px"  ImageUrl="~/Images/media-list.png" PostBackUrl="~/RentMedia.aspx" />
                    </td>
                    <td style="text-align: center">
                        <asp:ImageButton ID="ImageButton4" runat="server" AlternateText="New Media" ImageUrl="~/Images/add-video.png" PostBackUrl="~/NewMedia.aspx" />
                    </td>
                </tr>
            </table>
            <br />
            &nbsp;&nbsp;&nbsp;
            <br />
        </div>
    </form>
</body>
</html>
