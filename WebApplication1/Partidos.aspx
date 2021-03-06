﻿<%@ Page Title="Partidos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Partidos.aspx.cs" Inherits="AppWeb.Partidos" %>

 
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
     
    <p>
        <asp:Label ID="Titulo" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
        <br />
    </p>
    <p>
        Partidos<p>
            <strong __designer:mapid="221" >Temporada Actual:</strong>               
            
            <asp:Panel ID="PanelDePartidos" runat="server" CssClass="float-right" style="margin-right:30px" Width="400px" Height="700px" ScrollBars="Auto" BorderStyle="Dashed">
        <strong>Partidos de</strong>
        <asp:Label ID="Liga" runat="server" Text="Liga" Font-Bold="True"></asp:Label>
        :<asp:GridView ID="GridViewLiga" OnRowDataBound="GridViewLiga_RowDataBound" runat="server" AllowPaging="True"  HorizontalAlign="Center" style="text-align: center" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" PageSize="8" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <Columns>
                <asp:ImageField HeaderImageUrl="~/Content/circulo-azul-icono-3849-16.png">
                </asp:ImageField>
              <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="/Public/Partido.aspx?partido={0}" DataTextField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                   <asp:HyperLinkField DataNavigateUrlFields="EquipoLocal" DataNavigateUrlFormatString="/Public/PerfilEquipo.aspx?name={0}" DataTextField="EquipoLocal" HeaderText="Local" SortExpression="EquipoLocal" />
               <asp:BoundField DataField="ResultadoLocal" HeaderText="-" SortExpression="ResultadoLocal" >
                <ItemStyle Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="ResultadoVisitante" HeaderText="-" SortExpression="ResultadoVisitante" >
                <FooterStyle Font-Bold="True" />
                <ItemStyle Font-Bold="True" />
                </asp:BoundField>
            <asp:HyperLinkField DataNavigateUrlFields="EquipoVisitante" DataNavigateUrlFormatString="/Public/PerfilEquipo.aspx?name={0}" DataTextField="EquipoVisitante" HeaderText="Visitante" SortExpression="EquipoVisitante" />
            </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>

            <strong>Partidos de </strong>
        <asp:Label ID="Copa" runat="server" Text="Copa" Font-Bold="True"></asp:Label>
        :<asp:GridView ID="GridViewCopa" OnRowDataBound="GridViewCopa_RowDataBound" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource3"  HorizontalAlign="Center" style="text-align: center" PageSize="8" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <Columns>
                <asp:ImageField HeaderImageUrl="~/Content/circulo-azul-icono-3849-16.png">
                </asp:ImageField>
              <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="/Public/Partido.aspx?partido={0}" DataTextField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                    <asp:HyperLinkField DataNavigateUrlFields="EquipoLocal" DataNavigateUrlFormatString="/Public/PerfilEquipo.aspx?name={0}" DataTextField="EquipoLocal" HeaderText="Local" SortExpression="EquipoLocal" />
                  <asp:BoundField DataField="ResultadoLocal" HeaderText="-" SortExpression="ResultadoLocal" >
                <ItemStyle Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="ResultadoVisitante" HeaderText="-" SortExpression="ResultadoVisitante" >
                <ItemStyle Font-Bold="True" />
                </asp:BoundField>
              <asp:HyperLinkField DataNavigateUrlFields="EquipoVisitante" DataNavigateUrlFormatString="/Public/PerfilEquipo.aspx?name={0}" DataTextField="EquipoVisitante" HeaderText="Visitante" SortExpression="EquipoVisitante" />
            </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>

                  <asp:Label ID="Amistosos" runat="server" Text="Amistosos" Font-Bold="True"></asp:Label>
        :<asp:GridView ID="GridViewAmistosos" OnRowDataBound="GridViewAmistosos_RowDataBound" runat="server" AllowPaging="True" AutoGenerateColumns="False"  HorizontalAlign="Center" style="text-align: center" DataSourceID="SqlDataSource4" PageSize="8" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <Columns>
                <asp:ImageField HeaderImageUrl="~/Content/circulo-azul-icono-3849-16.png">
                </asp:ImageField>
          <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="/Public/Partido.aspx?partido={0}" DataTextField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                       <asp:HyperLinkField DataNavigateUrlFields="EquipoLocal" DataNavigateUrlFormatString="/Public/PerfilEquipo.aspx?name={0}" DataTextField="EquipoLocal" HeaderText="Local" SortExpression="EquipoLocal" />
               <asp:BoundField DataField="ResultadoLocal" HeaderText="-" SortExpression="ResultadoLocal" >
                <ItemStyle Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="ResultadoVisitante" HeaderText="-" SortExpression="ResultadoVisitante" >
                <ItemStyle Font-Bold="True" />
                </asp:BoundField>
         <asp:HyperLinkField DataNavigateUrlFields="EquipoVisitante" DataNavigateUrlFormatString="/Public/PerfilEquipo.aspx?name={0}" DataTextField="EquipoVisitante" HeaderText="Visitante" SortExpression="EquipoVisitante" />
             </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="White" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        </asp:Panel>
            
            <asp:Panel ID="TodosLosPartidos" runat="server" Width="500px" Height="700px" BorderStyle="Dashed" ScrollBars="Auto">
        <strong >Todos los Partidos:</strong><asp:GridView ID="GridViewTodoslosPartidos" OnRowDataBound="GridViewTodoslosPartidos_RowDataBound" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" PageSize="30" HorizontalAlign="Center" style="text-align: center" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <Columns>
                <asp:ImageField HeaderImageUrl="~/Content/circulo-azul-icono-3849-16.png">
                </asp:ImageField>
               <asp:HyperLinkField DataNavigateUrlFields="ID" DataNavigateUrlFormatString="/Public/Partido.aspx?partido={0}" DataTextField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
               <asp:HyperLinkField DataNavigateUrlFields="EquipoLocal" DataNavigateUrlFormatString="/Public/PerfilEquipo.aspx?name={0}" DataTextField="EquipoLocal" HeaderText="Local" SortExpression="EquipoLocal" />
                  <asp:BoundField DataField="ResultadoLocal" HeaderText="-" SortExpression="ResultadoLocal" >
                <ItemStyle Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="ResultadoVisitante" HeaderText="-" SortExpression="ResultadoVisitante" >

                <ItemStyle Font-Bold="True" />
                </asp:BoundField>

               <asp:HyperLinkField DataNavigateUrlFields="EquipoVisitante" DataNavigateUrlFormatString="/Public/PerfilEquipo.aspx?name={0}" DataTextField="EquipoVisitante" HeaderText="Visitante" SortExpression="EquipoVisitante" />
               <asp:HyperLinkField DataNavigateUrlFields="Competencia" DataNavigateUrlFormatString="/Public/Competencia.aspx?name={0}" DataTextField="Competencia" HeaderText="Competencia" SortExpression="Competencia" />
             
                
            </Columns>
            <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
            <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
            <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
            <RowStyle BackColor="White" ForeColor="#003399" />
            <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
            <SortedAscendingCellStyle BackColor="#EDF6F6" />
            <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
            <SortedDescendingCellStyle BackColor="#D6DFDF" />
            <SortedDescendingHeaderStyle BackColor="#002876" />
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionStringAccDB %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionStringAccDB.ProviderName %>" SelectCommand="SELECT [ID], [Fecha], [EquipoLocal], [ResultadoLocal], [ResultadoVisitante], [EquipoVisitante], [Competencia] FROM [Partidos] WHERE (([EquipoLocal] = ?) OR ([EquipoVisitante] = ?)) ORDER BY [Fecha] DESC">
            <SelectParameters>
                <asp:SessionParameter Name="EquipoLocal" SessionField="Equipo" Type="String" />
                <asp:SessionParameter Name="EquipoVisitante" SessionField="Equipo" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        
    </asp:Panel>
    
    

    <br />
    <br />
    <br />
    <br />
            <strong __designer:mapid="221" >Temporadas Anteriores:::</strong><br />
    <asp:Panel ID="Panel4" runat="server" CssClass="float-left" Width="333px">
        
        <br />
        <asp:GridView ID="GridView2" runat="server">
        </asp:GridView>
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionStringAccDB %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionStringAccDB.ProviderName %>" SelectCommand="SELECT [Fecha], [EquipoLocal], [ResultadoLocal], [ResultadoVisitante], [EquipoVisitante], [Competencia] FROM [Partidos] WHERE [Competencia] = 'Primera Division' AND ([EquipoLocal] = ?) OR ([EquipoVisitante] = ?) ORDER BY [Fecha] DESC">
            <SelectParameters>
                <asp:SessionParameter Name="EquipoLocal" SessionField="Equipo" Type="String" />
                <asp:SessionParameter Name="EquipoVisitante" SessionField="Equipo" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        
    </asp:Panel>
        <strong __designer:mapid="4f" >
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionStringAccDB %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionStringAccDB.ProviderName %>" SelectCommand="SELECT [Fecha], [EquipoLocal], [ResultadoLocal], [ResultadoVisitante], [EquipoVisitante], [Competencia] FROM [Partidos] WHERE [Competencia] = 'Primera Division' AND ([EquipoLocal] = ?) OR ([EquipoVisitante] = ?) ORDER BY [Fecha] DESC">
            <SelectParameters>
                <asp:SessionParameter Name="EquipoLocal" SessionField="Equipo" Type="String" />
                <asp:SessionParameter Name="EquipoVisitante" SessionField="Equipo" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>

            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionStringAccDB %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionStringAccDB.ProviderName %>" SelectCommand="SELECT [Fecha], [EquipoLocal], [ResultadoLocal], [ResultadoVisitante], [EquipoVisitante], [Competencia] FROM [Partidos] WHERE [Competencia] = 'Primera Division' AND ([EquipoLocal] = ?) OR ([EquipoVisitante] = ?) ORDER BY [Fecha] DESC">
            <SelectParameters>
                <asp:SessionParameter Name="EquipoLocal" SessionField="Equipo" Type="String" />
                <asp:SessionParameter Name="EquipoVisitante" SessionField="Equipo" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        </strong>
    </asp:Content>

        
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    </asp:Content>