<%@ Page Language="C#" MasterPageFile="~/DefaulMaster.Master" AutoEventWireup="true" CodeBehind="RentMedia.aspx.cs" Inherits="videoRentalStore.RentMedia" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="mainContentPH" runat="server">
    <div>
            <br />
            Search:
            <asp:TextBox ID="tbSearchTitle" runat="server" Width="420px"></asp:TextBox>
            <br />
            <br />
            <asp:Button ID="btnSearchMedia" runat="server" Text="Search" />
                        <br />
                        <br />
            <asp:Label ID="lblMessaage" runat="server"></asp:Label>
                        <br />

            <asp:CheckBoxList ID="chbMediaList" runat="server" DataSourceID="MediaListByTitle" DataTextField="Title" DataValueField="ID" OnDataBound="chbMediaList_DataBound">
            </asp:CheckBoxList>
            <asp:ObjectDataSource ID="MediaListByTitle" runat="server" SelectMethod="GetMediaByTitle" 
                TypeName="videoRentalStore.Models.VideoRentalStoreRepository">
                <SelectParameters>
                    <asp:ControlParameter ControlID="tbSearchTitle" DefaultValue="NULL" Name="title" PropertyName="Text" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <br />
            <br />
            <asp:Button ID="btnAddtoRentalList" runat="server" OnClick="btnAddtoRentalList_Click" Text="Add To Rental List" />
            <br />
            <br />
        </div>
    </asp:Content>
