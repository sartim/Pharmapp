<%@ Page Title="Contact" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeFile="Contact.aspx.cs" Inherits="Contact" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <h2><%: Title %>.</h2>
    <h3>Your contact page.</h3>
    <address>
        Nairobi, Kenya<br />
        Redmond, WA 98052-6399<br />
        <abbr title="Phone">P:</abbr>
        +242 111 222
    </address>

    <address>
        <strong>Support:</strong>   <a href="mailto:Support@example.com">info@mail.com</a><br />
        <strong>Marketing:</strong> <a href="mailto:Marketing@example.com">Marketing@mail.com</a>
    </address>
</asp:Content>
