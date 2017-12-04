<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="RentMedia.aspx.cs" Inherits="videoRentalStore.RentMedia" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <br />
            Search:
            <asp:TextBox ID="tbSearchTitle" runat="server" Width="420px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="Button1" runat="server" Text="Search" />
                        <br />
                        <br />

            <asp:CheckBoxList ID="chbMediaList" runat="server" DataSourceID="MediaListByTitle" DataTextField="Title" DataValueField="ID">
            </asp:CheckBoxList>
            <asp:ObjectDataSource ID="MediaListByTitle" runat="server" SelectMethod="getMediaByTitle" TypeName="videoRentalStore.Models.VideoRentalStoreRepository">
                <SelectParameters>
                    <asp:ControlParameter ControlID="tbSearchTitle" DefaultValue="NULL" Name="title" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </form>
</body>
</html>
