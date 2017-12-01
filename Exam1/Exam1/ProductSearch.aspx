<%@ Page Language="C#" AutoEventWireup="true" MaintainScrollPositionOnPostback="true" CodeBehind="ProductSearch.aspx.cs" Inherits="Exam1.ProductSearch" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            Select a Product:&nbsp;
            <asp:DropDownList ID="DropDownList1" runat="server" DataSourceID="ProductListDS" DataTextField="ProductName" DataValueField="ProductID" AppendDataBoundItems="True" AutoPostBack="True">
                <asp:ListItem Text="Select a Product" Value="" />
            </asp:DropDownList>
            <asp:SqlDataSource ID="ProductListDS" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString %>" SelectCommand="SELECT DISTINCT [ProductID], [ProductName] FROM [Products]"></asp:SqlDataSource>
        </div>
        <p>
            <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" DataSourceID="OrderListDS" AllowPaging="True" CellPadding="4" DataKeyNames="OrderID" ForeColor="#333333" GridLines="None" Caption="Order List" CaptionAlign="Left">
                <AlternatingRowStyle BackColor="White" />
                <Columns>
                    <asp:CommandField ShowSelectButton="True" />
                    <asp:BoundField DataField="OrderID" HeaderText="Order ID" SortExpression="OrderID" />
                    <asp:BoundField DataField="CustomerID" HeaderText="Customer ID" SortExpression="CustomerID" />
                    <asp:BoundField DataField="OrderDate" HeaderText="Order Date" SortExpression="OrderDate" />
                </Columns>
                <EditRowStyle BackColor="#2461BF" />
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
                <SelectedRowStyle BackColor="#D1DDF1" Font-Bold="True" ForeColor="#333333" />
                <SortedAscendingCellStyle BackColor="#F5F7FB" />
                <SortedAscendingHeaderStyle BackColor="#6D95E1" />
                <SortedDescendingCellStyle BackColor="#E9EBEF" />
                <SortedDescendingHeaderStyle BackColor="#4870BE" />
            </asp:GridView>
            <asp:SqlDataSource ID="OrderListDS" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString2 %>" SelectCommand="SELECT p.ProductID, od.OrderID, o.CustomerID, o.OrderDate FROM Products AS p INNER JOIN [Order Details] AS od ON od.ProductID = p.ProductID INNER JOIN Orders AS o ON od.OrderID = o.OrderID INNER JOIN Customers AS c ON o.CustomerID = c.CustomerID WHERE (p.ProductID = @ProductID)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="DropDownList1" DefaultValue="" Name="ProductID" PropertyName="SelectedValue" />
                </SelectParameters>
            </asp:SqlDataSource>
        </p>
        <p>
            &nbsp;</p>
        <p>
            <asp:DetailsView ID="DetailsView1" runat="server" AutoGenerateRows="False" CellPadding="4" DataKeyNames="OrderID" DataSourceID="OrderDetailDS" ForeColor="#333333" GridLines="None" Height="50px" Width="301px" HeaderText="Order Details">
                <AlternatingRowStyle BackColor="White" />
                <CommandRowStyle BackColor="#D1DDF1" Font-Bold="True" />
                <EditRowStyle BackColor="#2461BF" />
                <FieldHeaderStyle BackColor="#DEE8F5" Font-Bold="True" />
                <Fields>
                    <asp:BoundField DataField="OrderID" HeaderText="Order ID" InsertVisible="False" ReadOnly="True" SortExpression="OrderID" />
                    <asp:BoundField DataField="CustomerID" HeaderText="Customer ID" SortExpression="CustomerID" />
                    <asp:BoundField DataField="EmployeeID" HeaderText="Employee ID" SortExpression="EmployeeID" />
                    <asp:BoundField DataField="OrderDate" HeaderText="Order Date" SortExpression="OrderDate" />
                    <asp:BoundField DataField="RequiredDate" HeaderText="Required Date" SortExpression="RequiredDate" />
                    <asp:BoundField DataField="ShippedDate" HeaderText="Shipped Date" SortExpression="ShippedDate" />
                    <asp:BoundField DataField="ShipVia" HeaderText="Ship Via" SortExpression="ShipVia" />
                    <asp:BoundField DataField="Freight" HeaderText="Freight" SortExpression="Freight" />
                    <asp:BoundField DataField="ShipName" HeaderText="Ship Name" SortExpression="ShipName" />
                    <asp:BoundField DataField="ShipAddress" HeaderText="Ship Address" SortExpression="ShipAddress" />
                    <asp:BoundField DataField="ShipCity" HeaderText="Ship City" SortExpression="ShipCity" />
                    <asp:BoundField DataField="ShipRegion" HeaderText="Ship Region" SortExpression="ShipRegion" />
                    <asp:BoundField DataField="ShipPostalCode" HeaderText="Ship Postal Code" SortExpression="ShipPostalCode" />
                    <asp:BoundField DataField="ShipCountry" HeaderText="Ship Country" SortExpression="ShipCountry" />
                </Fields>
                <FooterStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <HeaderStyle BackColor="#507CD1" Font-Bold="True" ForeColor="White" />
                <PagerStyle BackColor="#2461BF" ForeColor="White" HorizontalAlign="Center" />
                <RowStyle BackColor="#EFF3FB" />
            </asp:DetailsView>
            <asp:SqlDataSource ID="OrderDetailDS" runat="server" ConnectionString="<%$ ConnectionStrings:NORTHWNDConnectionString %>" SelectCommand="SELECT * FROM [Orders] WHERE ([OrderID] = @OrderID)">
                <SelectParameters>
                    <asp:ControlParameter ControlID="GridView1" Name="OrderID" PropertyName="SelectedValue" Type="Int32" />
                </SelectParameters>
            </asp:SqlDataSource>
        </p>
    </form>
</body>
</html>
