<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="calculator.aspx.cs" Inherits="InvestmentCalculateor.calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 364px;
            height: 260px;
        }
        .auto-style2 {
            height: 23px;
        }
        .auto-style3 {
            height: 23px;
            width: 205px;
        }
        .auto-style4 {
            width: 205px;
        }
        .auto-style5 {
            width: 32%;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>

            <img alt="investment" class="auto-style1" src="images/investment.jpg" />
            <br />
         

            <br />
            <br />
            <%-- <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:test1ConnectionString %>" SelectCommand="SELECT [values] FROM [monthlyValues]"></asp:SqlDataSource>
            <asp:DropDownList ID="dpMonthlyValues2" runat="server" DataSourceID="SqlDataSource1" DataTextField="values" DataValueField="values">
               
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>--%>
            <table class="auto-style5">
                <tr>
                    <td class="auto-style3">
            <asp:Label ID="Label2" runat="server" Text="Monthly Investment:"></asp:Label>
                    </td>
                    <td class="auto-style2">
           
                        <asp:DropDownList ID="dpMonthlyValues" runat="server">
                        </asp:DropDownList>
           
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style4">
            <asp:Label ID="Label1" runat="server" Text="Interest Rate:"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="tbIntRate" runat="server"></asp:TextBox>
                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style4">
            <asp:Label ID="Label3" runat="server" Text="Number Of years:"></asp:Label>
                    </td>
                    <td>
            <asp:TextBox ID="tbNumYears" runat="server"></asp:TextBox>

                    </td>
                    
                </tr>
                <tr>
                    <td class="auto-style4">
            <asp:Button ID="btnCalculate" runat="server" Text="Calculate" OnClick="btnCalculate_Click" />
                    </td>
                    <td>
          <asp:Button ID="btnClear" runat="server" OnClick="btnClear_Click" Text="Clear" Width="91px" />

                    </td>
                    
                </tr>
            </table>
           <br />           
             <asp:Label ID="lblValue" runat="server" Text="Label" Width="357px"></asp:Label>
            
            <br />
            <br />
            

        </div>
        <asp:RangeValidator ID="RVInterest" runat="server" ControlToValidate="tbIntRate" ErrorMessage="Interest Rate Error: has to be between 1.0 &amp; 20.0" ForeColor="Maroon" MaximumValue="20" MinimumValue="1" Type="Double"></asp:RangeValidator>
        <br />
            
        <asp:RangeValidator ID="RangeValidator1" runat="server" ErrorMessage="Years Error: has to be between 1&amp;45" ControlToValidate="tbNumYears" ForeColor="Maroon" MaximumValue="45" MinimumValue="1" Type="Integer"></asp:RangeValidator>
        <br />
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Inteerst Rate is required field" ControlToValidate="tbIntRate" ForeColor="Maroon"></asp:RequiredFieldValidator>
    </form>
</body>
</html>
