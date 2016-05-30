<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Inferiores.aspx.cs" Inherits="AppWeb.Inferiores" %>

 
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
     
    <asp:Panel ID="Panel2" runat="server" Height="213px">
    <p>
        <asp:Label ID="Titulo" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Inferioresd" runat="server" Text="Inferiores" Font-Bold="true" Font-Size="Large"></asp:Label>
    </p>
    <p>
        Pais:&nbsp;
        <asp:Label ID="Pais" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
    </p>
    <p>
        Nivel:&nbsp;
        <asp:Label ID="Nivel" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
    </p>
    <p>
        Puntos de Experiencia:&nbsp;
        <asp:Label ID="PuntosdeExperiencia" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
    </p>
</asp:Panel>
    <asp:Panel ID="Panel1" runat="server" Height="290px" Width="601px" BorderStyle="Dotted" CssClass="content-wrapper">
        <p>
            Juvenil surgido el dia:
            <asp:Label ID="Surgido" runat="server" Font-Bold="true" Font-Size="Large" Text="Label"></asp:Label>
        </p>
        <p>
            Edad:
            <asp:Label ID="Edad" runat="server" Font-Bold="true" Font-Size="Large" Text="Label"></asp:Label>
        </p>
        <p>
            Banda:
            <asp:Label ID="Banda" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
        </p>
        <p>
            Mejor Habilidad:
            <asp:Label ID="Rango" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
        </p>
        <p>
            <img alt="JugadordeInferiores" class="auto-style1" src="Content/pict--footballer-soccer-pictograms---vector-stencils-library.png--diagram-flowchart-example.png" />
            Nombre:&nbsp;&nbsp;&nbsp;<asp:TextBox ID="NombreJugadorInferiores" runat="server" MaxLength="13" Width="242px"></asp:TextBox>
            &nbsp;&nbsp; &nbsp;<asp:Button ID="BotonPromover" runat="server" Text="Promover" />
        </p>
    </asp:Panel>
    <p><br />


    </p>
</asp:Content>

        
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    <style type="text/css">
        .auto-style1 {
            width: 85px;
            height: 97px;
        }
    </style>
    </asp:Content>