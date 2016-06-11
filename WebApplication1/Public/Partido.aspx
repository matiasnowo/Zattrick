<%@ Page Title="Partido" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Partido.aspx.cs" Inherits="AppWeb.Public.Partido" %>

<%@ Register assembly="System.Web.DataVisualization, Version=4.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35" namespace="System.Web.UI.DataVisualization.Charting" tagprefix="asp" %>

<%@ Register assembly="Microsoft.ReportViewer.WebForms, Version=12.0.0.0, Culture=neutral, PublicKeyToken=89845dcd8080cc91" namespace="Microsoft.Reporting.WebForms" tagprefix="rsweb" %>

<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">

    <section class="Partido">
        <header>
            <asp:Panel ID="EstadisticasLocal" runat="server" CssClass="float-left" Width="320px">
                <asp:GridView ID="GridViewLocal" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                    <Columns>
                         <asp:HyperLinkField DataTextField="Jugador" HeaderText="Jugador" SortExpression="Jugador" DataNavigateUrlFields="Jugador" DataNavigateUrlFormatString="/Public/Jugador.aspx?name={0}" >
                <ItemStyle Font-Bold="True" />
                </asp:HyperLinkField>
                        <asp:BoundField DataField="Ass" HeaderText="Ass" SortExpression="Ass" />
                        <asp:BoundField DataField="Gls" HeaderText="Gls" SortExpression="Gls" />
                        <asp:BoundField DataField="Yel" HeaderText="Yel" SortExpression="Yel" />
                        <asp:BoundField DataField="Red" HeaderText="Red" SortExpression="Red" />
                        <asp:BoundField DataField="Inj" HeaderText="Inj" SortExpression="Inj" />
                        <asp:BoundField DataField="Fit" HeaderText="Fit" SortExpression="Fit" />
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor= "#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="#CCFFCC" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
                
            </asp:Panel>

            
            <asp:Panel ID="ResultadoEInfo" runat="server" Width="320px" CssClass="float-left">
                <asp:Label ID="EquipoLocal" runat="server" Text="Label" Font-Bold="True" Font-Size="Large"></asp:Label>
                &nbsp;<asp:Label ID="ResultadoLocal" runat="server" Text="Label" Font-Bold="True" Font-Size="Large"></asp:Label>
                &nbsp;-
                <asp:Label ID="ResultadoVisitante" runat="server" Text="Label" Font-Bold="True" Font-Size="Large"></asp:Label>
                &nbsp;<asp:Label ID="EquipoVisiitante" runat="server" Text="Label" Font-Bold="True" Font-Size="Large"></asp:Label>
            </asp:Panel>
            
            <asp:Panel ID="EstadisticasVisitante" runat="server" Width="320px" CssClass="float-left">
                <asp:GridView ID="GridViewVisitante" runat="server" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
                    <Columns>
                 <asp:HyperLinkField DataTextField="Jugador" HeaderText="Jugador" SortExpression="Jugador" DataNavigateUrlFields="Jugador" DataNavigateUrlFormatString="/Public/Jugador.aspx?name={0}" >
                <ItemStyle Font-Bold="True" />
                </asp:HyperLinkField>
                        <asp:BoundField DataField="Ass" HeaderText="Ass" SortExpression="Ass" />
                        <asp:BoundField DataField="Gls" HeaderText="Gls" SortExpression="Gls" />
                        <asp:BoundField DataField="Yel" HeaderText="Yel" SortExpression="Yel" />
                        <asp:BoundField DataField="Red" HeaderText="Red" SortExpression="Red" />
                        <asp:BoundField DataField="Inj" HeaderText="Inj" SortExpression="Inj" />
                        <asp:BoundField DataField="Fit" HeaderText="Fit" SortExpression="Fit" />
                    </Columns>
                    <FooterStyle BackColor="#99CCCC" ForeColor="#003399" />
                    <HeaderStyle BackColor="#003399" Font-Bold="True" ForeColor="#CCCCFF" />
                    <PagerStyle BackColor="#99CCCC" ForeColor="#003399" HorizontalAlign="Left" />
                    <RowStyle BackColor="#CCFFCC" ForeColor="#003399" />
                    <SelectedRowStyle BackColor="#009999" Font-Bold="True" ForeColor="#CCFF99" />
                    <SortedAscendingCellStyle BackColor="#EDF6F6" />
                    <SortedAscendingHeaderStyle BackColor="#0D4AC4" />
                    <SortedDescendingCellStyle BackColor="#D6DFDF" />
                    <SortedDescendingHeaderStyle BackColor="#002876" />
                </asp:GridView>
            </asp:Panel>
           
           
           
            <asp:Panel ID="ResultadoEInfo0" runat="server" Width="320px" CssClass="float-left">
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionStringAccDB %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionStringAccDB.ProviderName %>" SelectCommand="SELECT JugadorEnPartido.Jugador, JugadorEnPartido.ID_Partido, JugadorEnPartido.Ass, JugadorEnPartido.Gls, JugadorEnPartido.Yel, JugadorEnPartido.Red, JugadorEnPartido.Inj, JugadorEnPartido.Fit FROM (Partidos INNER JOIN JugadorEnPartido ON Partidos.Id = JugadorEnPartido.ID_Partido) WHERE (Partidos.Id = ?)">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="Id" QueryStringField="Partido" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
                <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionStringAccDB %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionStringAccDB.ProviderName %>" SelectCommand="SELECT [Minuto], [RendimientoTk], [RendimientoPs], [RendimientoSh] FROM [RendimientoEnPartido] WHERE (([Id_Partido] = ?) AND ([Equipo] = true))">
                    <SelectParameters>
                        <asp:QueryStringParameter Name="Id" QueryStringField="Partido" Type="Int32" />
                    </SelectParameters>
                </asp:SqlDataSource>
            
                <asp:GridView ID="GridViewVisitante0" runat="server" AutoGenerateColumns="False" CellPadding="4" DataSourceID="SqlDataSource2" ForeColor="#333333" GridLines="None">
                    <AlternatingRowStyle BackColor="White" />
                    <Columns>
                        <asp:BoundField DataField="Minuto" HeaderText="Minuto" SortExpression="Minuto" />
                        <asp:BoundField DataField="RendimientoTk" HeaderText="RendimientoTk" SortExpression="RendimientoTk" />
                        <asp:BoundField DataField="RendimientoPs" HeaderText="RendimientoPs" SortExpression="RendimientoPs" />
                        <asp:BoundField DataField="RendimientoSh" HeaderText="RendimientoSh" SortExpression="RendimientoSh" />
                    </Columns>
                    <EditRowStyle BackColor="#7C6F57" />
                    <FooterStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <HeaderStyle BackColor="#1C5E55" Font-Bold="True" ForeColor="White" />
                    <PagerStyle BackColor="#666666" ForeColor="White" HorizontalAlign="Center" />
                    <RowStyle BackColor="#E3EAEB" />
                    <SelectedRowStyle BackColor="#C5BBAF" Font-Bold="True" ForeColor="#333333" />
                    <SortedAscendingCellStyle BackColor="#F8FAFA" />
                    <SortedAscendingHeaderStyle BackColor="#246B61" />
                    <SortedDescendingCellStyle BackColor="#D4DFE1" />
                    <SortedDescendingHeaderStyle BackColor="#15524A" />
                </asp:GridView>
            </asp:Panel>
            
           
           
        </header>
    </section>
</asp:Content>
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    </asp:Content>
