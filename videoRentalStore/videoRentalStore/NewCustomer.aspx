<%@ Page Language="C#" MasterPageFile="~/DefaulMaster.Master" AutoEventWireup="true" CodeBehind="NewCustomer.aspx.cs" Inherits="videoRentalStore.NewCustomer" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentPH" runat="server">
    <div>
            <br />

            <table cellpadding="5" cellspacing="6" width="60%">
                <tr>
                    <td>First Name:</td>
                    <td>
                        <asp:TextBox ID="tbfirstName" runat="server"></asp:TextBox>&nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbfirstName" ErrorMessage="*" ForeColor="#990000"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>Last Name:</td>
                    <td>
                        <asp:TextBox ID="tbLastName" runat="server"></asp:TextBox>&nbsp;
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbLastName" ErrorMessage="*" ForeColor="#990000"></asp:RequiredFieldValidator>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    
                    <td>Phone Number:</td>
                    <td>
                        <asp:TextBox ID="tbPhoneNumber" runat="server"></asp:TextBox>&nbsp;<span style="color:gray"><asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbPhoneNumber" ErrorMessage="*" ForeColor="#990000"></asp:RequiredFieldValidator>
                    &nbsp;Format: 123-456-7890</span>&nbsp;&nbsp;<asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbPhoneNumber" ErrorMessage="Phone Number is not in a correct format" ForeColor="#990000" ValidationExpression="((\(\d{3}\) ?)|(\d{3}-))?\d{3}-\d{4}"></asp:RegularExpressionValidator>
                    </td>
                    <td>
                        &nbsp;</td>
                </tr>
                <tr>
                    <td>Address: </td>
                    <td>
                        <asp:TextBox ID="tbAddress" runat="server" Height="65px" Width="465px"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td>&nbsp;</td>
                    <td>
                        <asp:Button ID="btnAddcustomer" runat="server" Text="Button" OnClick="btnAddcustomer_Click" />
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
   </asp:Content>
