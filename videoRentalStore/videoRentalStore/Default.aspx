<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="videoRentalStore.Defaulr" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 50%;
            text-align:center;
        }
        .auto-style2 {
            direction: ltr;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div style="text-align:center;">
             <div style="float:left; width:100%; text-align:left; font-size:14pt; font-weight:bold; background-color:royalblue; ">
                 <h2>Welcome to Store</h2></div>
            <br />
            <br />
            <table cellpadding="5" cellspacing="5" class="auto-style1">
                <tr>
                    <td class="auto-style2" style="text-align: center">
                        <asp:ImageButton ID="ImageButton1" runat="server" AlternateText="Customer List" Height="90px" ImageUrl="~/Images/list.png" Width="80px" PostBackUrl="~/Customers.aspx" />
                    </td>
                    <td style="text-align: center">
                        <asp:ImageButton ID="ImageButton2" runat="server" AlternateText="New Customer" ImageUrl="~/Images/Add_New.png" Width="80px" PostBackUrl="~/NewCustomer.aspx" />
                    </td>
                    <td style="text-align: center">
                        <asp:ImageButton ID="ImageButton3" runat="server" AlternateText="Rented Media List" Height="90px" Width="80px"  ImageUrl="~/Images/media-list.png" PostBackUrl="~/RentMedia.aspx" />
                    </td>
                    <td style="text-align: center">
                        <asp:ImageButton ID="ImageButton4" runat="server" AlternateText="New Media" ImageUrl="~/Images/add-video.png" Width="80px" PostBackUrl="~/NewMedia.aspx" />
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
