<%@ Page Title="Partidos" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Partidos.aspx.cs" Inherits="AppWeb.Partidos" %>

 
<asp:Content runat="server" ID="BodyContent" ContentPlaceHolderID="MainContent">
    
     
    <p>
        <asp:Label ID="Titulo" runat="server" Text="Label" Font-Bold="true" Font-Size="Large"></asp:Label>
        <br />
    </p>
    <p>
        Partidos<p>
            <strong __designer:mapid="221" >Temporada Actual:</strong>     
            
            <asp:Panel ID="PanelDePartidos" runat="server" CssClass="float-right" style="margin-right:50px" Width="400px" Height="700px" ScrollBars="Auto" BorderStyle="Dashed">
        <strong>Partidos de
        <asp:Label ID="Liga" runat="server" Text="Liga"></asp:Label>
        :<asp:GridView ID="GridViewLiga"  runat="server" AllowPaging="True"  HorizontalAlign="Center" style="text-align: center" AutoGenerateColumns="False" DataSourceID="SqlDataSource2" PageSize="8" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <Columns>
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                <asp:BoundField DataField="EquipoLocal" HeaderText="Local" SortExpression="EquipoLocal" />
                <asp:BoundField DataField="ResultadoLocal" HeaderText="-" SortExpression="ResultadoLocal" >
                <ItemStyle Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="ResultadoVisitante" HeaderText="-" SortExpression="ResultadoVisitante" >
                <FooterStyle Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="EquipoVisitante" HeaderText="Visitante" SortExpression="EquipoVisitante" />
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

            <strong>Partidos de
        <asp:Label ID="Copa" runat="server" Text="Copa"></asp:Label>
        :<asp:GridView ID="GridViewCopa"  runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource3"  HorizontalAlign="Center" style="text-align: center" PageSize="8" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <Columns>
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                <asp:BoundField DataField="EquipoLocal" HeaderText="Local" SortExpression="EquipoLocal" />
                <asp:BoundField DataField="ResultadoLocal" HeaderText="-" SortExpression="ResultadoLocal" >
                <ItemStyle Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="ResultadoVisitante" HeaderText="-" SortExpression="ResultadoVisitante" >
                <ItemStyle Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="EquipoVisitante" HeaderText="Visitante" SortExpression="EquipoVisitante" />
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

                  <asp:Label ID="Amistosos" runat="server" Text="Amistosos"></asp:Label>
        :<asp:GridView ID="GridViewAmistosos"  runat="server" AllowPaging="True" AutoGenerateColumns="False"  HorizontalAlign="Center" style="text-align: center" DataSourceID="SqlDataSource4" PageSize="8" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <Columns>
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                <asp:BoundField DataField="EquipoLocal" HeaderText="Local" SortExpression="EquipoLocal" />
                <asp:BoundField DataField="ResultadoLocal" HeaderText="-" SortExpression="ResultadoLocal" >
                <ItemStyle Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="ResultadoVisitante" HeaderText="-" SortExpression="ResultadoVisitante" >
                <ItemStyle Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="EquipoVisitante" HeaderText="Visitante" SortExpression="EquipoVisitante" />
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
        </strong></asp:Panel>
            
            <asp:Panel ID="TodosLosPartidos" runat="server" Width="450px" Height="700px" BorderStyle="Dashed" ScrollBars="Auto">
        <strong >Todos los Partidos:<br />
        <asp:GridView ID="GridViewTodoslosPartidos" runat="server" AllowPaging="True" AutoGenerateColumns="False" DataSourceID="SqlDataSource1" PageSize="30" HorizontalAlign="Center" style="text-align: center" BackColor="White" BorderColor="#3366CC" BorderStyle="None" BorderWidth="1px" CellPadding="4">
            <Columns>
                <asp:BoundField DataField="Fecha" HeaderText="Fecha" SortExpression="Fecha" />
                <asp:BoundField DataField="EquipoLocal" HeaderText="Local" SortExpression="EquipoLocal" />
                <asp:BoundField DataField="ResultadoLocal" HeaderText="-" SortExpression="ResultadoLocal" >
                <ItemStyle Font-Bold="True" />
                </asp:BoundField>
                <asp:BoundField DataField="ResultadoVisitante" HeaderText="-" SortExpression="ResultadoVisitante" >

                <ItemStyle Font-Bold="True" />
                </asp:BoundField>

                <asp:BoundField DataField="EquipoVisitante" HeaderText="Visitante" SortExpression="EquipoVisitante" />
                <asp:BoundField DataField="Competencia" HeaderText="Competencia" SortExpression="Competencia" >
                                </asp:BoundField>
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
        <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionString %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionString.ProviderName %>" SelectCommand="SELECT [Fecha], [EquipoLocal], [ResultadoLocal], [ResultadoVisitante], [EquipoVisitante], [Competencia] FROM [Partidos] WHERE (([EquipoLocal] = ?) OR ([EquipoVisitante] = ?))">
            <SelectParameters>
                <asp:SessionParameter Name="EquipoLocal" SessionField="Equipo" Type="String" />
                <asp:SessionParameter Name="EquipoVisitante" SessionField="Equipo" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        </strong>
    </asp:Panel>
    
    

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
        <asp:SqlDataSource ID="SqlDataSource4" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionString %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionString.ProviderName %>" SelectCommand="SELECT [Fecha], [EquipoLocal], [ResultadoLocal], [ResultadoVisitante], [EquipoVisitante], [Competencia] FROM [Partidos] WHERE [Competencia] = 'Primera Division' AND ([EquipoLocal] = ?) OR ([EquipoVisitante] = ?)">
            <SelectParameters>
                <asp:SessionParameter Name="EquipoLocal" SessionField="Equipo" Type="String" />
                <asp:SessionParameter Name="EquipoVisitante" SessionField="Equipo" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        </strong>
    </asp:Panel>
        <strong __designer:mapid="4f" >
        <asp:SqlDataSource ID="SqlDataSource2" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionString %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionString.ProviderName %>" SelectCommand="SELECT [Fecha], [EquipoLocal], [ResultadoLocal], [ResultadoVisitante], [EquipoVisitante], [Competencia] FROM [Partidos] WHERE [Competencia] = 'Primera Division' AND ([EquipoLocal] = ?) OR ([EquipoVisitante] = ?)">
            <SelectParameters>
                <asp:SessionParameter Name="EquipoLocal" SessionField="Equipo" Type="String" />
                <asp:SessionParameter Name="EquipoVisitante" SessionField="Equipo" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>

            <asp:SqlDataSource ID="SqlDataSource3" runat="server" ConnectionString="<%$ ConnectionStrings:ZattrickConnectionString %>" ProviderName="<%$ ConnectionStrings:ZattrickConnectionString.ProviderName %>" SelectCommand="SELECT [Fecha], [EquipoLocal], [ResultadoLocal], [ResultadoVisitante], [EquipoVisitante], [Competencia] FROM [Partidos] WHERE [Competencia] = 'Primera Division' AND ([EquipoLocal] = ?) OR ([EquipoVisitante] = ?)">
            <SelectParameters>
                <asp:SessionParameter Name="EquipoLocal" SessionField="Equipo" Type="String" />
                <asp:SessionParameter Name="EquipoVisitante" SessionField="Equipo" Type="String" />
            </SelectParameters>
        </asp:SqlDataSource>
        </strong>
    </asp:Content>

        
<asp:Content ID="Content1" runat="server" contentplaceholderid="HeadContent">
    </asp:Content>