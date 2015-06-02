<%@ Page Language="C#" AutoEventWireup="true" CodeFile="Product.aspx.cs" Inherits="Page_Management_Product" MasterPageFile="~/Site.master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table>
        <tr>
            <td rowspan="4">
                <asp:Image ID="imgProduct" runat="server" CssClass="detailsImage" />
            </td>
            <td><h2><asp:Label ID="lblTitle" runat="server" Text="Label"></asp:Label><hr /></h2>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblDescription" runat="server" CssClass="detailsDescription"></asp:Label>
            </td>
            <td>
                <asp:Label ID="lblPrice" runat="server" CssClass="detailsPrice"></asp:Label>
            </td>
                
        </tr>
        <tr>
            <td>
                PruductNumber: <asp:Label ID="lblItemNr" runat="server" Text="label"></asp:Label>
                <asp:Button ID="AddButton" runat="server" CssClass="button" Text="Add To Cart" OnClick="AddButton_Click" />
                Quantity :<asp:DropDownList ID="ddlAmount" runat="server"></asp:DropDownList><br />
                
                <asp:Label ID=lblResult runat="server" Text=""></asp:Label>
            </td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="Label1" runat="server" Text="Available" CssClass="productPrice"></asp:Label>
            </td>
            
        </tr>
    </table>
</asp:Content>
