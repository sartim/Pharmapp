<%@ Page Language="C#" AutoEventWireup="true" CodeFile="ManageProductTypes.aspx.cs" Inherits="Page_Management_ManageProductTypes" MasterPageFile="~/Site.Master" %>

  <asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">  
    <p>&nbsp;</p>
      <p>&nbsp;</p>
      <p>&nbsp;</p>
    <table class="auto-style1">
        <tr>
            <td style="height: 41px">Name</td>
            <td style="height: 41px">
                <asp:TextBox ID="txtName" runat="server"></asp:TextBox>
            </td>
            <td style="height: 41px"></td>
        </tr>
        <tr>
            <td style="height: 10px"></td>
            <td style="height: 10px">
                <asp:Button ID="SubmitButton" runat="server" Text="Submit" OnClick="SubmitButton_Click" />
            </td>
            <td style="height: 10px"></td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Label ID="lblResult" runat="server"></asp:Label>
            </td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
