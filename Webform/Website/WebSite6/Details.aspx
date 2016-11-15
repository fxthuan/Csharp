<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="Details.aspx.cs" Inherits="Details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
    <asp:DataList ID="DataList1" runat="server" DataKeyField="ProductID" DataSourceID="SqlDataSource1" RepeatColumns="4">
    <ItemTemplate>
        ProductID:
        <asp:Label ID="ProductIDLabel" runat="server" Text='<%# Eval("ProductID") %>' />
        <br />
        ProductName:
        <asp:Label ID="ProductNameLabel" runat="server" Text='<%# Eval("ProductName") %>' />
        <br />
        SupplierID:
        <asp:Label ID="SupplierIDLabel" runat="server" Text='<%# Eval("SupplierID") %>' />
        <br />
        CategoryID:
        <asp:Label ID="CategoryIDLabel" runat="server" Text='<%# Eval("CategoryID") %>' />
        <br />
        QuantityPerUnit:
        <asp:Label ID="QuantityPerUnitLabel" runat="server" Text='<%# Eval("QuantityPerUnit") %>' />
        <br />
        UnitPrice:
        <asp:Label ID="UnitPriceLabel" runat="server" Text='<%# Eval("UnitPrice") %>' />
        <br />
        UnitsInStock:
        <asp:Label ID="UnitsInStockLabel" runat="server" Text='<%# Eval("UnitsInStock") %>' />
        <br />
        UnitsOnOrder:
        <asp:Label ID="UnitsOnOrderLabel" runat="server" Text='<%# Eval("UnitsOnOrder") %>' />
        <br />
        ReorderLevel:
        <asp:Label ID="ReorderLevelLabel" runat="server" Text='<%# Eval("ReorderLevel") %>' />
        <br />
        Discontinued:
        <asp:Label ID="DiscontinuedLabel" runat="server" Text='<%# Eval("Discontinued") %>' />
        <br />
        CategoryName:
        <asp:Label ID="CategoryNameLabel" runat="server" Text='<%# Eval("CategoryName") %>' />
        <br />
<br />
    </ItemTemplate>
</asp:DataList>
<asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:NorthwindConnectionString %>" SelectCommand="SELECT * FROM [Alphabetical list of products] WHERE ([CategoryID] = @CategoryID)">
    <SelectParameters>
        <asp:QueryStringParameter Name="CategoryID" QueryStringField="CID" Type="Int32" />
    </SelectParameters>
</asp:SqlDataSource>
</asp:Content>

