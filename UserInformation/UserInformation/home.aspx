<%@ Page Language="C#"
    AutoEventWireup="true"
    CodeBehind="home.aspx.cs"
    Inherits="UserInformation.home" %>

<%@ Register src="Controls/header.ascx" tagname="header" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 57%;
            height: 315px;
            color:#000;
        }
        .auto-style2 {
            width: 111px;
        }
        .auto-style3 {
            width: 338px;
        }
        .auto-style4 {
            width: 111px;
            height: 30px;
        }
        .auto-style5 {
            width: 338px;
            height: 30px;
        }
        .auto-style6 {
            height: 61px;
        }
        .auto-style11 {
            width: 338px;
           
        }
        .auto-style14 {
            width: 100px;
            
        }
        .auto-style16 {
            width: 100px;
            
        }
        .auto-style17 {
            width: 86px;
        }
    </style>
</head>
<body>
    <form id="form1" defaultbutton="btnSubmit" runat="server">
        <input type="hidden" id="hiddenCount" value="0" runat="server" />
        <table class="auto-style1">
            <tr>
                <td colspan="2" style="height: 64px">
                    <uc1:header ID="header1" runat="server" />
                </td>
            </tr>
           
            <tr>
                <td class="auto-style17">Name</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbName" ErrorMessage="Name is required field" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">Date of Birth</td>
                <td class="auto-style3">
                    <asp:TextBox ID="tbDOB" runat="server"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbDOB" ErrorMessage="DOB is required field" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToValidate="tbDOB" ErrorMessage="*" Operator="DataTypeCheck" Type="Date"></asp:CompareValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">Email</td>
                <td class="auto-style5">
                    <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbEmail" ErrorMessage="Email is required field" ForeColor="Red">*</asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="tbEmail" ErrorMessage="*" ForeColor="Red" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">Province</td>
                <td class="auto-style5">
                    <asp:DropDownList ID="ddlProvince" runat="server" AutoPostBack="True" OnSelectedIndexChanged="ddlProvince_SelectedIndexChanged" Width="126px">
                        <asp:ListItem Selected="True" Value="">Select One</asp:ListItem>
                        <asp:ListItem>Quebec</asp:ListItem>
                        <asp:ListItem>Ontario</asp:ListItem>
                        <asp:ListItem>Alberta</asp:ListItem>
                        <asp:ListItem>Other</asp:ListItem>
                    </asp:DropDownList>
                &nbsp;<asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlProvince" ErrorMessage="Select a Province" ForeColor="Red">*</asp:RequiredFieldValidator>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">city</td>
                <td class="auto-style11">
                    <asp:DropDownList ID="ddlCity" runat="server" Width="127px">
                    </asp:DropDownList>
                </td>
            </tr>
            <tr>
                <td class="auto-style17"></td>
                <td class="auto-style14"></td>
            </tr>
            <tr>
                <td class="auto-style17">Result</td>
                <td class="auto-style16">
                    <asp:Label ID="lblResult" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">Count</td>
                <td class="auto-style3">
                    <asp:Label ID="lblCount" runat="server"></asp:Label>
                </td>
            </tr>
            <tr>
                <td class="auto-style17">
                    <asp:Button ID="btnSubmit" runat="server" BackColor="#3333FF" ForeColor="#CCFFFF" Text="Submit" Width="113px" OnClick="btnSubmit_Click" />
                </td>
                <td class="auto-style3">&nbsp;</td>
            </tr>
            <tr>
                <td class="auto-style6" colspan="2">
                    <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="Red" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    List of User</td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:ListBox ID="lbUser" runat="server" Height="131px" Width="327px"></asp:ListBox>
                </td>
            </tr>
        </table>
        
    </form>
</body>
</html>
