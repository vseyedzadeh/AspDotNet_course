<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CheckOut.aspx.cs" Inherits="CheckOutPage.CheckOut" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 55%;
        }
        .auto-style2 {
            width: 489px;
        }
        .auto-style3 {
            width: 1120px;
        }
        .auto-style4 {
            width: 431px;
        }
        .auto-style5 {
            width: 626px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <h2>Check Out Page</h2>
    <table cellpadding="3" cellspacing="5" class="auto-style1">
        <tr>
            <td colspan="3">
                <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#990000" HeaderText="Please correct these entries:" ShowModelStateErrors="False" ValidationGroup="checkOut" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" />
            </td>
            
        </tr>
        <tr>
            <td colspan="3"><h3>Contact Information</h3></td>
            
        </tr>
        <tr>
            <td class="auto-style5" dir="ltr" style="text-align: right">Email Address:</td>
            <td class="auto-style4">
                <asp:TextBox ID="tbEmail" runat="server" Width="250px" ></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbEmail" ErrorMessage="Email Address" ForeColor="#990000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="checkOut">Must be a valid email address</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" dir="ltr" style="text-align: right">Email Re-entry:</td>
            <td class="auto-style4">
                <asp:TextBox ID="tbReentryEmail" runat="server" Width="250px" ></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="tbEmail" ControlToValidate="tbReentryEmail" ErrorMessage="Email Re-entry" ForeColor="#990000" ValidationGroup="checkOut">Must match first email address</asp:CompareValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" dir="ltr" style="text-align: right">First Name:</td>
            <td class="auto-style4">
                <asp:TextBox ID="tbFirstName" runat="server" Width="250px" ></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5" dir="ltr" style="text-align: right">Last Name:</td>
            <td class="auto-style4">
                <asp:TextBox ID="tbLastName" runat="server" Width="250px" ></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5" dir="ltr" style="text-align: right">Phone Number:</td>
            <td class="auto-style4">
                <asp:TextBox ID="tbPhoneNumber" runat="server" Width="250px" ></asp:TextBox>
            </td>
            <td class="auto-style3">
                <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="tbPhoneNumber" ErrorMessage="Phone Number" ForeColor="#990000" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}" ValidationGroup="checkOut">Use this format: 123-456-7890</asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr>
            <td colspan="3"><h3>Billing Address</h3></td>
            
        </tr>
        <tr>
            <td class="auto-style5" style="text-align: right">Address:</td>
            <td class="auto-style4">
                <asp:TextBox ID="tbBlAddress" runat="server" Width="250px" ></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5" style="text-align: right">City:</td>
            <td class="auto-style4">
                <asp:TextBox ID="tbBlCity" runat="server" Width="250px" ></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5" style="text-align: right">State:</td>
            <td class="auto-style4">
                <asp:DropDownList ID="ddlBlState" runat="server" Width="250px">
                    <asp:ListItem Value="Select State">Select State</asp:ListItem>
                    <asp:ListItem>Alberta</asp:ListItem>
                    <asp:ListItem Value="BritishColumbia">British Columbia</asp:ListItem>
                    <asp:ListItem>Manitoba</asp:ListItem>
                    <asp:ListItem Value="NewBrunswick">New Brunswick</asp:ListItem>
                    <asp:ListItem Value="NovaScotia">Nova Scotia</asp:ListItem>
                    <asp:ListItem>Newfoundland</asp:ListItem>
                    <asp:ListItem Value="PrinceEdwardIsland">Prince Edward Island</asp:ListItem>
                    <asp:ListItem>Ontario</asp:ListItem>
                    <asp:ListItem>Quebec</asp:ListItem>
                    <asp:ListItem>Saskatchewan</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="ddlBlState" ErrorMessage="State - Billing Address" ForeColor="#990000" ValidationGroup="checkOut" InitialValue="Select State">Required</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" style="text-align: right">Zip Code:</td>
            <td class="auto-style4">
                <asp:TextBox ID="tbBlZipCode" runat="server" Width="250px" ></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5"><h3>Shipping Address</h3></td>
            
        </tr>
         <tr>
             <td class="auto-style5">&nbsp;</td>
            <td colspan="2"><asp:CheckBox ID="chSameAddress" runat="server" Text="Same as billing address" OnCheckedChanged="chSameAddress_CheckedChanged" AutoPostBack="True" />
             </td>
            
        </tr>
        <tr>
            <td class="auto-style5" style="text-align: right">Address:</td>
            <td class="auto-style4">
                <asp:TextBox ID="tbShAddress" runat="server" Width="250px" ></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5" style="text-align: right">City:</td>
            <td class="auto-style4">
                <asp:TextBox ID="tbShCity" runat="server" Width="250px" ></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
            <td class="auto-style5" style="text-align: right">State:</td>
            <td class="auto-style4">
                <asp:DropDownList ID="ddlShState" runat="server" Width="250px">
                    <asp:ListItem>Select State</asp:ListItem>
                    <asp:ListItem>Alberta</asp:ListItem>
                    <asp:ListItem Value="BritishColumbia">British Columbia</asp:ListItem>
                    <asp:ListItem>Manitoba</asp:ListItem>
                    <asp:ListItem Value="NewBrunswick">New Brunswick</asp:ListItem>
                    <asp:ListItem Value="NovaScotia">Nova Scotia</asp:ListItem>
                    <asp:ListItem>Newfoundland</asp:ListItem>
                    <asp:ListItem Value="PrinceEdwardIsland">Prince Edward Island</asp:ListItem>
                    <asp:ListItem>Ontario</asp:ListItem>
                    <asp:ListItem>Quebec</asp:ListItem>
                    <asp:ListItem>Saskatchewan</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td class="auto-style3">
                <asp:RequiredFieldValidator ID="vldRqShAdrState" runat="server" ControlToValidate="ddlShState" ErrorMessage="State - Shipping Address" ForeColor="#990000" InitialValue="Select State" ValidationGroup="checkOut">Required</asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td class="auto-style5" style="text-align: right">Zip Code:</td>
            <td class="auto-style4">
                <asp:TextBox ID="tbShZipCode" runat="server" Width="250px" ></asp:TextBox>
            </td>
            <td class="auto-style3">&nbsp;</td>
        </tr>
        <tr>
             <td class="auto-style5">&nbsp;</td>
            <td class="auto-style2" colspan="2">
                <asp:Button ID="btnCheckOut" runat="server" Text="Check Out" OnClick="btnCheckOut_Click" />
            </td>
            
        </tr>
       
    </table>
        <br />
        <asp:Label ID="lblPrint" runat="server" BorderColor="#999999" BorderStyle="Solid" BorderWidth="1px" Font-Size="Medium" Width="606px"></asp:Label>
        <br />
    </form>
</body>
</html>
