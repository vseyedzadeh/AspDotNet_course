<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="QuotationBuilder.aspx.cs" Inherits="InvestmentCalculateor.QuotationBuilder" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
        .auto-style2 {
            width: 180px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <table class="auto-style1">
            <tr>
                <td class="auto-style2">Price Quotation</td>
                <td>&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style2">Sales price:</td>
                <td>
                    <asp:TextBox ID="tbPrice" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Discount Percent</td>
                <td>
                    <asp:TextBox ID="tbDscPercent" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Discount Amount</td>
                 <td>
                     <asp:Label ID="lblDscamount" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style2">Total Amount

                </td>
                 <td>
                     <asp:Label ID="lblTotal" runat="server" Text="Label"></asp:Label>
                </td>
            </tr>
        </table>
        <div>
            <asp:Button ID="btnSubmit" runat="server" OnClick="btnSubmit_Click" Text="Submit" />
        </div>
        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="tbPrice" ErrorMessage="Price must be grather than 0" ForeColor="Maroon" MaximumValue="999999999999999" MinimumValue="0" Type="Double"></asp:RangeValidator>
        <br />
        <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="tbDscPercent" ErrorMessage="discount has to be between 1 &amp; 90" ForeColor="Maroon" MaximumValue="90" MinimumValue="1" Type="Double"></asp:RangeValidator>
    </form>
</body>
</html>
