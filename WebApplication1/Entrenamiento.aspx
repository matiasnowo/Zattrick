<%@ Page Title="Entrenamiento" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Entrenamiento.aspx.cs" Inherits="AppWeb.Entrenamiento" %>

 
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
     
    <asp:Panel ID="Panel2" runat="server" Height="182px">
    <p>
        <asp:Label ID="Titulo" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
        <br />
        <br />
        <asp:Label ID="Entrenamientod" runat="server" Font-Bold="true" Font-Size="Large" Text="Entrenamiento"></asp:Label>
    </p>
    <p>
        Entrenador:&nbsp;
        <asp:Label ID="Entrenador" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
        &nbsp;| Edad:
        <asp:Label ID="EdadEntrenador" runat="server" Font-Bold="true" Font-Size="Large" Text="Label"></asp:Label>
        &nbsp;| Nivel de Entrenador:&nbsp;
        <asp:Label ID="NivelEntrenador" runat="server" Font-Bold="true" Font-Size="Large" Text="Label"></asp:Label>
        &nbsp;| Especialidad:
        <asp:Label ID="Especialidad" runat="server" Font-Bold="true" Font-Size="Large" Text="Label"></asp:Label>
        &nbsp;| Sueldo de Entrenador:
        <asp:Label ID="SueldoEntrenador" runat="server" Font-Bold="true" Font-Size="Large" Text="Label"></asp:Label>
    </p>
        <p>
            Nivel de Instalaciones de Entrenamiento:
            <asp:Label ID="NivelInstalaciones" runat="server" Font-Bold="true" Font-Size="Large" Text="Label"></asp:Label>
            <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionStringAccDB %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionStringAccDB.ProviderName %>" SelectCommand="SELECT [Name] FROM [Jugadores] WHERE ([Equipo] = ?)">
                <SelectParameters>
                    <asp:SessionParameter Name="Equipo" SessionField="Equipo" Type="String" />
                </SelectParameters>
            </asp:SqlDataSource>
        </p>
</asp:Panel>
    <asp:Panel ID="Panel1" runat="server" Height="274px" Width="569px" BorderStyle="Dotted" CssClass="content-wrapper">
        <p>
            Jugador a Entrenar:
            <asp:DropDownList ID="ListaJugadores" runat="server" AutoPostBack="true" DataSourceID="SqlDataSource1" DataTextField="Name" DataValueField="Name" OnSelectedIndexChanged="ListaJugadores_SelectedIndexChanged">
                <asp:ListItem Selected="True"></asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="JugadorEntrenando" runat="server" Font-Bold="true" Visible="false" Text="JugadorEntrenando" Font-Size="Large"></asp:Label>
        </p>
        <p>
            Nueva Banda a Aprender:
            <asp:DropDownList ID="BandasDisponibles" runat="server" enable="false" AutoPostBack ="true" OnSelectedIndexChanged="BandasDisponibles_SelectedIndexChanged">
                <asp:ListItem>Entrenar L</asp:ListItem>
                <asp:ListItem>Entrenar C</asp:ListItem>
                <asp:ListItem Value="Entrenar R">Entrenar R</asp:ListItem>
                <asp:ListItem Selected="True"></asp:ListItem>
            </asp:DropDownList>
            <asp:Label ID="BandaEntrenando" runat="server" Text="BandaEntrenando" Font-Bold="true" Visible="false" Font-Size="Large"></asp:Label>
        </p>
        <asp:Panel ID="Panel3" runat="server" BorderStyle="None" BorderWidth="0px">
            Costo de Entrenamiento Especial:
            <asp:Label ID="CostoEntrenamiento" runat="server" Font-Bold="true" Font-Size="Large" Text="-"></asp:Label>
        </asp:Panel>
        <p>
            Fecha Estimada de Fin de Entrenamiento:
            <asp:Label ID="FechaFinEntrenamiento" runat="server" Font-Bold="true" Font-Size="Large" Text="-"></asp:Label>
            <asp:Label ID="FechaFindeEntrenando" runat="server" Text="FechaFindeEntrenando" Font-Bold="true" Visible="false" Font-Size="Large"></asp:Label>
        </p>
        <p class="auto-style2">
            <img alt="JugadordeInferiores" class="auto-style1" src="Content/pict--footballer-soccer-pictograms---vector-stencils-library.png--diagram-flowchart-example.png" />
            &nbsp;<asp:Button ID="BotonConfirmar" Enabled="false" runat="server" Text="Confirmar" OnClick="BotonConfirmar_Click" style="text-align: center" />
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
            text-align: center;
        }
        .auto-style2 {
            text-align: left;
        }
    </style>
    </asp:Content>