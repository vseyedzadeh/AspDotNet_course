<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Exam1.Default" %>

<%@ Register src="Controls/Header.ascx" tagname="Header" tagprefix="uc1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            width: 80%;
        }
        .auto-style4 {
            width: 181px;
        }
        .auto-style3 {
            width: 292px;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
        <div>
             <uc1:Header ID="Header1" runat="server" />
        </div>
        <div>
           
            <br />
            <table cellpadding="5" cellspacing="6" class="auto-style1">
                
                <tr>
                    <td class="auto-style4">Student Name:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbName" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Email Address:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbEmail" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="tbEmail" ErrorMessage="*" ForeColor="#990000"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RgEmailValidation" runat="server" ControlToValidate="tbEmail" ErrorMessage=" Email is not in a correct format" ForeColor="#990000" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*" ValidationGroup="gradeForm"></asp:RegularExpressionValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Confirm Email Address:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbConfirmEmail" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="tbConfirmEmail" ErrorMessage="*" ForeColor="#990000"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator1" runat="server" ControlToCompare="tbEmail" ControlToValidate="tbConfirmEmail" ErrorMessage="Confirm Email does not match with Email" ForeColor="#990000" ValidationGroup="gradeForm"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Date of Birth:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbDateBirth" runat="server"></asp:TextBox>
                    </td>
                    <td>&nbsp;</td>
                </tr>
                <tr>
                    <td class="auto-style4">Class:</td>
                    <td class="auto-style3">
                        <asp:DropDownList ID="ddlClass" runat="server">
                            <asp:ListItem Value="1">Select a class</asp:ListItem>
                            <asp:ListItem>Freshman</asp:ListItem>
                            <asp:ListItem>Sophomore</asp:ListItem>
                        </asp:DropDownList>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="ddlClass" ErrorMessage="*" ForeColor="#990000"></asp:RequiredFieldValidator>
                        <asp:CompareValidator ID="CompareValidator2" runat="server" ControlToValidate="ddlClass" ErrorMessage="Please select a class" ForeColor="#990000" Operator="NotEqual" ValidationGroup="gradeForm" ValueToCompare="1"></asp:CompareValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Final Grade:</td>
                    <td class="auto-style3">
                        <asp:TextBox ID="tbFinalGrade" runat="server"></asp:TextBox>
                    </td>
                    <td>
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="tbFinalGrade" ErrorMessage="*" ForeColor="#990000"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="tbFinalGrade" ErrorMessage="Final grade has to be decimal and between 0 and 100" ForeColor="#990000" MaximumValue="100" MinimumValue="0" Type="Double" ValidationGroup="gradeForm"></asp:RangeValidator>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">Alerts:</td>
                    <td class="auto-style3">
                        <asp:ValidationSummary ID="ValidationSummary1" runat="server" ForeColor="#990000" ValidationGroup="gradeForm" />
                        <br />
                        <br />
                        <br />
                    </td>
                    <td>&nbsp;</td>
                </tr>
               
                <tr>
                    <td class="auto-style4">Student Details:</td>
                    <td class="auto-style3">
                        Student Information:
                        <asp:ListBox ID="lbxStudentInfo" runat="server" Width="260px"></asp:ListBox>
                    </td>
                    <td>
                        Grade:<br />
                        <asp:ListBox ID="lbxGrade" runat="server" Width="116px"></asp:ListBox>
                    </td>
                </tr>
                <tr>
                    <td class="auto-style4">
                        
                    </td>
                    <td class="auto-style3" colspan="2"><asp:Button ID="btnAdd" runat="server" Text="Add Student &amp; Calculate Average" OnClick="btnAdd_Click" /></td>
                    
                </tr>
                <tr>
                    <td class="auto-style4">Class Average Class</td>
                    <td class="auto-style3">
                        <asp:Label ID="lblClassAverage" runat="server" Text="0.0"></asp:Label>
                    </td>
                    <td>&nbsp;</td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
