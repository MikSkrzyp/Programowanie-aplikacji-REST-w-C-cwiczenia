<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <p>
        <br />
        <asp:TextBox runat="server"></asp:TextBox>
    </p>
    <p>
        <br />
        <asp:Button runat="server" Text="Button" OnClick="Unnamed2_Click">

        </asp:Button><asp:Label runat="server" Text="Label"></asp:Label>
    </p>

</asp:Content>
