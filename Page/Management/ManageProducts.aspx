<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManageProducts.aspx.cs" Inherits="Page_Management_ManageProducts" MasterPageFile="~/Site.Master" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <p>&nbsp;</p>
    <p>&nbsp;</p>
    <table class="nav-justified">
    <tr>
        <td class="text-right" style="width: 112px; height: 46px;">Name:</td>
        <td class="text-left" style="height: 46px">
            <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="text-right" style="width: 112px; height: 66px;">Type:</td>
        <td class="text-left" style="height: 66px">
            <asp:DropDownList ID="ddListType" runat="server" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Id" Width="130px">
            </asp:DropDownList>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:PharmaConnectionString %>" SelectCommand="SELECT * FROM [ProductTypes] ORDER BY [Name]"></asp:SqlDataSource>
        </td>
    </tr>
    <tr>
        <td class="text-right" style="width: 112px; height: 49px;">Price:</td>
        <td class="text-left" style="height: 49px">
            <asp:TextBox ID="txtPrice" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="text-right" style="width: 112px; height: 56px;">Image:</td>
        <td class="text-left" style="height: 56px">
            <asp:DropDownList ID="ddListImage" runat="server" Width="126px">
            </asp:DropDownList>
        </td>
    </tr>
    <tr>
        <td class="text-right" style="width: 112px; height: 60px;">Description</td>
        <td class="text-left" style="height: 60px">
            <asp:TextBox ID="txtDescription" runat="server" TextMode="MultiLine"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td style="width: 112px; height: 64px;"></td>
        <td style="height: 64px">
            <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
        </td>
    </tr>
    <tr>
        <td style="width: 112px">&nbsp;</td>
        <td>
            <asp:Label ID="lblResult" runat="server"></asp:Label>
        </td>
    </tr>
</table>
    
</asp:Content>