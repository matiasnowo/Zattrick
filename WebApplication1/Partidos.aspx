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
        <asp:GridView ID="GridViewTodoslosPartidos" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" PageSize="30">
            <Columns>
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                <asp:BoundField DataField="EquipoLocal" HeaderText="Local" SortExpression="EquipoLocal" />
                <asp:BoundField DataField="ResultadoLocal" HeaderText="-" SortExpression="ResultadoLocal" />
                <asp:BoundField DataField="ResultadoVisitante" HeaderText="-" SortExpression="ResultadoVisitante" />
                <asp:BoundField DataField="EquipoVisitante" HeaderText="Visitante" SortExpression="EquipoVisitante" />
                <asp:BoundField DataField="Competencia" HeaderText="Competencia" SortExpression="Competencia" />
            </Columns>
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionString %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionString.ProviderName %>" SelectCommand="SELECT [Fecha], [EquipoLocal], [ResultadoLocal], [ResultadoVisitante], [EquipoVisitante], [Competencia] FROM [Partidos] WHERE (([EquipoLocal] = ?) OR ([EquipoVisitante] = ?))">
            <SelectParameters>
                <asp:SessionParameter Name="EquipoLocal" SessionField="Equipo" Type="String" />
                <asp:SessionParameter Name="EquipoVisitante" SessionField="Equipo" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        </strong>
    </asp:Panel>
    <asp:Panel ID="PrimeraDivision" runat="server" CssClass="float-left" Width="333px">
        <strong>Partidos de
        <asp:Label ID="Liga" runat="server" Text="Liga"></asp:Label>
        :<asp:GridView ID="GridViewTodoslosPartidosSoloLiga" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" PageSize="30">
            <Columns>
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                <asp:BoundField DataField="EquipoLocal" HeaderText="Local" SortExpression="EquipoLocal" />
                <asp:BoundField DataField="ResultadoLocal" HeaderText="-" SortExpression="ResultadoLocal" />
                <asp:BoundField DataField="ResultadoVisitante" HeaderText="-" SortExpression="ResultadoVisitante" />
                <asp:BoundField DataField="EquipoVisitante" HeaderText="Visitante" SortExpression="EquipoVisitante" />
            </Columns>
        </asp:GridView>
        </strong></asp:Panel>
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
            <strong __designer:mapid="221" >Temporadas Anteriores:adas Anteriores:</strong><br />
    <asp:Panel ID="Panel4" runat="server" CssClass="float-left" Width="333px">
        <strong >
        <br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        </strong>
    </asp:Panel>
        <strong __designer:mapid="4f" >
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionString %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionString.ProviderName %>" SelectCommand="SELECT [Fecha], [EquipoLocal], [ResultadoLocal], [ResultadoVisitante], [EquipoVisitante], [Competencia] FROM [Partidos] WHERE [Competencia] = 'Primera Division' AND ([EquipoLocal] = ?) OR ([EquipoVisitante] = ?)">
            <SelectParameters>
                <asp:SessionParameter Name="EquipoLocal" SessionField="Equipo" Type="String" />
                <asp:SessionParameter Name="EquipoVisitante" SessionField="Equipo" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        </strong>
    </asp:Content>

        
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    </asp:Content>