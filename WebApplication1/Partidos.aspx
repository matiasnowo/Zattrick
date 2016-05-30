<%@ Page Title="Partidos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Partidos.aspx.cs" Inherits="AppWeb.Partidos" %>

 
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
     
    <p>
        <asp:Label ID="Titulo" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
        <br />
    </p>
    <p>
        Partidos<p>
            <strong __designer:mapid="221" >Temporada Actual:</strong><asp:Panel ID="Panel1" runat="server" CssClass="float-left" Width="333px">
        <strong >Todos los Partidos:<br />
        <asp:GridView ID="GridView1" runat="server">
        </asp:GridView>
        </strong>
    </asp:Panel>
    <asp:Panel ID="Panel2" runat="server" CssClass="float-left" Width="333px">
        <strong>Partidos de Liga:</strong></asp:Panel>
    <asp:Panel ID="Panel3" runat="server" CssClass="float-left" Width="333px">
        <strong >Partidos de Copa:</strong></asp:Panel>
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
    <br />
            <strong __designer:mapid="221" >Temporadas Anteriores:</strong><br />
    <asp:Panel ID="Panel4" runat="server" CssClass="float-left" Width="333px">
        <strong >
        <br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        </strong>
    </asp:Panel>
</asp:Content>

        
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    </asp:Content>