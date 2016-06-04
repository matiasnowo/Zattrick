<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Actualizacion.aspx.cs" Inherits="AppWeb.About" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    <hgroup class="title">
        <h1>&nbsp;</h1>
    </hgroup>
    Plantillas:<br />
    <asp:Button ID="Actualizar" runat="server" Text="Actualizar Base de datos desde TXT" OnClick="Actualizar_Click" />
    <asp:Button ID="DeBaseATxt" runat="server" Text="Actualizar TXT desde DB" OnClick="DeBaseATxt_Click" />
    <br />
    <br />
    Partidos:<br />
    <asp:Button ID="CrearPartidoEnBase" runat="server" Text="Crear Partido En Base" OnClick="CrearPartidoEnBase_Click" />
    <br />
    <br />
    <asp:Label ID="Label1" runat="server" Text=""></asp:Label>
    <br />
    <br />
    <br />
    <asp:Label ID="Label2" runat="server" Font-Size="XX-Large"></asp:Label>
    <br />
</asp:Content>