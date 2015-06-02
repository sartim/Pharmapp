<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ShoppingCart.aspx.cs" Inherits="Page_ShoppingCart" MasterPageFile="~/Site.master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:Panel ID="pnlShoppingCart" runat="server">

    </asp:Panel>
    <table>
        <tr>
            <td><b>Total: </b></td>
            <td><asp:Literal ID="litTotal" runat="server" Text="" /></td>
        </tr>
        <tr>
            <td><b>Vat: </b></td>
            <td><asp:Literal ID="litVat" runat="server" Text="" /></td>
        </tr>
        <tr>
            <td><b>Shipping: </b></td>
            <td>$ 15</td>
        </tr>
        <tr>
            <td><b>Ttal Amount: </b></td>
            <td><asp:Literal ID="litTotalAmount" runat="server" Text="" /></td>
        </tr>
        <tr>
            <td>
                <asp:LinkButton ID="lnkContinue" runat="server" PostBackUrl="~/Index.aspx" Text="Continue shopping" />
                OR
                <asp:Button ID="btnCheckout" runat="server" PostBackUrl="~/Page/Success.aspx" CssClass="button" Width="250px" Text="Continue Checkout" />
            </td>
        </tr>
    </table>
</asp:Content>
