<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Estadio.aspx.cs" Inherits="AppWeb.Estadio" %>

 
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
     
    <p>
        <asp:Label ID="Titulo" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>

        <br />

        <br />
        <asp:Label ID="NombreEstadio" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
        <br />
    </p>
    <p>
        Capacidad:&nbsp; <asp:Label ID="Capacidad" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label></p>
    <p>
        Hinchada:&nbsp; <asp:Label ID="Hinchada" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label></p>
    <p>
        Popularidad Actual:&nbsp; <asp:Label ID="PopuActual" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label></p>
    <p>
        Valor historico:&nbsp; <asp:Label ID="VHistorico" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label></p>
    <p>
        Porcentaje de ventas de entradas para el siguiente partido:&nbsp; <asp:Label ID="SiguientePartido" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
        <br />
    </p>
    </asp:Content>

        
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    </asp:Content>